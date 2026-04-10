using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class PatientRecordControl : UserControl
    {
        private int _patientId = 0;
        private readonly User _user;
        private readonly MainShellForm _shell;
        private bool _isLoadingPatients = false;
        private readonly Label _vitalsPlaceholder;
        private readonly Label _consultationsPlaceholder;
        private readonly Label _prescriptionsPlaceholder;

        public PatientRecordControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;
            _vitalsPlaceholder = CreateGridPlaceholder(tabVitals, "Choose a patient to display vital signs.");
            _consultationsPlaceholder = CreateGridPlaceholder(tabConsultations, "Choose a patient to display consultations.");
            _prescriptionsPlaceholder = CreateGridPlaceholder(tabPrescriptions, "Choose a patient to display prescriptions.");

            LoadPatients();
            ConfigureGrid(dgvVitals);
            ConfigureGrid(dgvConsultations);
            ConfigureGrid(dgvPrescriptions);
            SetHistoryReadOnly();
            ClearView();
        }

        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            LoadPatientDetails(patientId);
        }

        public void RefreshPatients(int? selectedPatientId = null)
        {
            LoadPatients(selectedPatientId ?? _patientId);
        }

        private void LoadPatients(int? selectedPatientId = null)
        {
            _isLoadingPatients = true;

            var patients = PatientService.GetAll();
            cboPatient.DataSource = null;
            cboPatient.DataSource = patients;
            cboPatient.DisplayMember = "DisplayInfo";
            cboPatient.ValueMember = "PatientId";
            cboPatient.SelectedIndex = -1;

            if (selectedPatientId.HasValue && selectedPatientId.Value > 0)
            {
                for (int i = 0; i < cboPatient.Items.Count; i++)
                {
                    if (cboPatient.Items[i] is Patient patient && patient.PatientId == selectedPatientId.Value)
                    {
                        cboPatient.SelectedIndex = i;
                        break;
                    }
                }
            }

            _isLoadingPatients = false;
        }

        private void cboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingPatients || cboPatient.SelectedIndex == -1) return;
            if (cboPatient.SelectedItem is not Patient selectedPatient) return;

            LoadPatientDetails(selectedPatient.PatientId);
        }

        private void LoadPatientDetails(int patientId)
        {
            _patientId = patientId;

            var p = PatientService.GetById(patientId);
            if (p == null)
            {
                ClearView();
                return;
            }

            lblPatientName.Text = p.FullName;

            int age = DateTime.Today.Year - p.DateOfBirth.Year;
            if (p.DateOfBirth.Date > DateTime.Today.AddYears(-age))
                age--;

            lblMeta.Text = $"{p.PatientCode}  |  {age} y/o  {p.Sex}  |  {p.ContactNumber}";

            if (!string.IsNullOrWhiteSpace(p.KnownAllergies))
            {
                lblAllergy.Text = "ALLERGY ALERT: " + p.KnownAllergies;
                lblAllergy.Visible = true;
                lblAllergy.BackColor = Color.FromArgb(153, 27, 27);
                lblAllergy.ForeColor = Color.White;
            }
            else
            {
                lblAllergy.Text = "";
                lblAllergy.Visible = false;
            }

            dgvVitals.DataSource = null;
            var vitals = VitalsService.GetByPatient(_patientId);
            dgvVitals.DataSource = vitals;

            dgvConsultations.DataSource = null;
            var consultations = ConsultService.GetByPatient(_patientId);
            dgvConsultations.DataSource = consultations;

            dgvPrescriptions.DataSource = null;
            var prescriptions = PrescriptionService.GetByPatient(_patientId);
            dgvPrescriptions.DataSource = prescriptions;

            txtHxAllergies.Text = p.KnownAllergies ?? "";
            txtHxConditions.Text = p.ChronicConditions ?? "";
            txtHxSurgeries.Text = p.PastSurgeries ?? "";
            txtHxFamily.Text = p.FamilyHistory ?? "";
            txtHxMeds.Text = p.CurrentMedications ?? "";

            FormatVitalsGrid();
            FormatConsultGrid();
            FormatRxGrid();
            ShowPlaceholder(_vitalsPlaceholder, dgvVitals, vitals.Count == 0 ? "No vital signs to show for this patient yet." : null);
            ShowPlaceholder(_consultationsPlaceholder, dgvConsultations, consultations.Count == 0 ? "No consultations to show for this patient yet." : null);
            ShowPlaceholder(_prescriptionsPlaceholder, dgvPrescriptions, prescriptions.Count == 0 ? "No prescriptions to show for this patient yet." : null);
        }

        private void ConfigureGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            GridViewService.MakeReadOnly(grid);
        }

        private void SetHistoryReadOnly()
        {
            txtHxAllergies.ReadOnly = true;
            txtHxConditions.ReadOnly = true;
            txtHxSurgeries.ReadOnly = true;
            txtHxFamily.ReadOnly = true;
            txtHxMeds.ReadOnly = true;
        }

        private void ClearView()
        {
            _patientId = 0;
            lblPatientName.Text = "";
            lblMeta.Text = "";
            lblAllergy.Text = "";
            lblAllergy.Visible = false;
            dgvVitals.DataSource = null;
            dgvConsultations.DataSource = null;
            dgvPrescriptions.DataSource = null;
            ShowPlaceholder(_vitalsPlaceholder, dgvVitals, "Choose a patient to display vital signs.");
            ShowPlaceholder(_consultationsPlaceholder, dgvConsultations, "Choose a patient to display consultations.");
            ShowPlaceholder(_prescriptionsPlaceholder, dgvPrescriptions, "Choose a patient to display prescriptions.");
            txtHxAllergies.Clear();
            txtHxConditions.Clear();
            txtHxSurgeries.Clear();
            txtHxFamily.Clear();
            txtHxMeds.Clear();
        }

        private void FormatVitalsGrid()
        {
            GridViewService.ShowOnly(
                dgvVitals,
                "RecordedAt",
                "BloodPressure",
                "HeartRate",
                "Temperature",
                "Bmi",
                "RecordedByName");

            GridViewService.SetHeaders(dgvVitals, new System.Collections.Generic.Dictionary<string, string>
            {
                ["RecordedAt"] = "Date / Time",
                ["BloodPressure"] = "BP",
                ["HeartRate"] = "HR",
                ["Temperature"] = "Temp",
                ["Bmi"] = "BMI",
                ["RecordedByName"] = "Recorded By"
            });
        }

        private void FormatConsultGrid()
        {
            GridViewService.ShowOnly(
                dgvConsultations,
                "ConsultDate",
                "DoctorName",
                "ChiefComplaint",
                "Diagnosis");

            GridViewService.SetHeaders(dgvConsultations, new System.Collections.Generic.Dictionary<string, string>
            {
                ["ConsultDate"] = "Date",
                ["DoctorName"] = "Doctor",
                ["ChiefComplaint"] = "Chief Complaint",
                ["Diagnosis"] = "Diagnosis"
            });
        }

        private void FormatRxGrid()
        {
            GridViewService.ShowOnly(
                dgvPrescriptions,
                "MedicationName",
                "Dosage",
                "Frequency",
                "Duration",
                "Instructions");

            GridViewService.SetHeaders(dgvPrescriptions, new System.Collections.Generic.Dictionary<string, string>
            {
                ["MedicationName"] = "Medication",
                ["Dosage"] = "Dosage",
                ["Frequency"] = "Frequency",
                ["Duration"] = "Duration",
                ["Instructions"] = "Instructions"
            });
        }

        private void btnEditHistory_Click(object sender, EventArgs e)
        {
            if (_patientId <= 0)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            _shell.NavigateTo("medhistory", _patientId);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_patientId <= 0)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            var patient = PatientService.GetById(_patientId);
            if (patient == null)
            {
                MessageBox.Show("The selected patient could not be loaded.");
                return;
            }

            var vitals = VitalsService.GetByPatient(_patientId);
            var consultations = ConsultService.GetByPatient(_patientId);
            var prescriptions = PrescriptionService.GetByPatient(_patientId);

            PrintService.ShowPrintPreview(
                this,
                $"Patient Record - {patient.FullName}",
                BuildPrintableRecord(patient, vitals, consultations, prescriptions));
        }

        private Label CreateGridPlaceholder(Control parent, string text)
        {
            Control container = parent;
            var placeholder = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 249, 250),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Text = text,
                Visible = false
            };

            container.Controls.Add(placeholder);
            placeholder.BringToFront();
            return placeholder;
        }

        private void ShowPlaceholder(Label placeholder, DataGridView grid, string? message)
        {
            bool showPlaceholder = !string.IsNullOrWhiteSpace(message);
            placeholder.Text = message ?? string.Empty;
            placeholder.Visible = showPlaceholder;
            grid.Visible = !showPlaceholder;
        }

        private string BuildPrintableRecord(
            Patient patient,
            System.Collections.Generic.IReadOnlyList<VitalSigns> vitals,
            System.Collections.Generic.IReadOnlyList<Consultation> consultations,
            System.Collections.Generic.IReadOnlyList<Prescription> prescriptions)
        {
            var builder = new StringBuilder();
            int age = CalculateAge(patient.DateOfBirth);

            builder.AppendLine("CLINIC EMR PATIENT RECORD");
            builder.AppendLine($"Printed On: {DateTime.Now:MMMM dd, yyyy hh:mm tt}");
            builder.AppendLine($"Prepared by: {_user.FullName}");
            builder.AppendLine();

            PrintService.AppendSection(builder, "Patient Information", new[]
            {
                $"Patient Code: {PrintService.DisplayValue(patient.PatientCode)}",
                $"Name: {patient.FullName}",
                $"Date of Birth: {patient.DateOfBirth:MMMM dd, yyyy}",
                $"Age / Sex: {age} years old / {PrintService.DisplayValue(patient.Sex)}",
                $"Contact No.: {PrintService.DisplayValue(patient.ContactNumber)}",
                $"Address: {PrintService.DisplayValue(patient.Address)}",
                $"Emergency Contact: {patient.EmergencyContact?.ToString() ?? "N/A"}"
            });

            PrintService.AppendSection(builder, "Medical History", new[]
            {
                $"Allergies: {PrintService.DisplayValue(patient.KnownAllergies)}",
                $"Chronic Conditions: {PrintService.DisplayValue(patient.ChronicConditions)}",
                $"Past Surgeries: {PrintService.DisplayValue(patient.PastSurgeries)}",
                $"Family History: {PrintService.DisplayValue(patient.FamilyHistory)}",
                $"Current Medications: {PrintService.DisplayValue(patient.CurrentMedications)}"
            });

            var latestVitals = vitals.Count > 0 ? vitals[0] : null;
            PrintService.AppendSection(builder, "Latest Vital Signs", latestVitals == null
                ? Array.Empty<string>()
                : new[]
                {
                    $"Recorded At: {latestVitals.RecordedAt:MMMM dd, yyyy hh:mm tt}",
                    $"Blood Pressure: {PrintService.DisplayValue(latestVitals.BloodPressure)}",
                    $"Heart Rate: {latestVitals.HeartRate} bpm",
                    $"Temperature: {latestVitals.Temperature:0.0} C",
                    $"Height / Weight: {latestVitals.HeightCm:0.#} cm / {latestVitals.WeightKg:0.#} kg",
                    $"BMI: {latestVitals.Bmi:0.0} {PrintService.DisplayValue(latestVitals.BmiCategory, string.Empty)}".Trim(),
                    $"Recorded By: {PrintService.DisplayValue(latestVitals.RecordedByName)}"
                });

            PrintService.AppendSection(
                builder,
                "Consultations",
                consultations.Select((consultation, index) =>
                    $"{index + 1}. {consultation.ConsultDate:MMM dd, yyyy hh:mm tt} | Doctor: {PrintService.DisplayValue(consultation.DoctorName)} | Chief Complaint: {PrintService.DisplayValue(consultation.ChiefComplaint)} | Diagnosis: {PrintService.DisplayValue(consultation.Diagnosis)}"));

            PrintService.AppendSection(
                builder,
                "Prescriptions",
                prescriptions.Select((prescription, index) =>
                    $"{index + 1}. {PrintService.DisplayValue(prescription.MedicationName)} | Dosage: {PrintService.DisplayValue(prescription.Dosage)} | Frequency: {PrintService.DisplayValue(prescription.Frequency)} | Duration: {PrintService.DisplayValue(prescription.Duration)} | Instructions: {PrintService.DisplayValue(prescription.Instructions)}"));

            return builder.ToString();
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
