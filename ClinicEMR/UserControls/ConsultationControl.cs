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
    public partial class ConsultationControl : UserControl
    {
        // ── Private state ────────────────────────────────────────────────────
        private int _patientId = 0;
        private int _savedConsultId = 0;
        private bool _isLoadingPatients = false;
        private DateTime _consultationDate = DateTime.Now;

        private readonly User _user;
        private readonly MainShellForm _shell;
        private readonly Label _consultationPlaceholder;

        // ── Constructor ──────────────────────────────────────────────────────
        public ConsultationControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;
            _consultationPlaceholder = CreatePlaceholder();

            // Disable Rx button until a consultation is saved
            btnAddRx.Enabled = false;

            gbPatientInfo.Visible = false;
            LoadPatients();
            ShowPlaceholder("Choose a patient to display consultation details.");

            // Lock yesterday's records silently every time this control loads
            ConsultService.LockPastConsultations(_user.UserId);
        }

        // ════════════════════════════════════════════════════════════════════
        // PUBLIC ENTRY POINTS
        // Called by MainShellForm.NavigateTo() or PatientListControl
        // ════════════════════════════════════════════════════════════════════

        // Load a patient directly (Options B and C from the guide)
        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            SelectPatient(patientId);
        }

        // Load an existing consultation for viewing / adding more Rx
        // (called when doctor opens a consultation from PatientRecordControl)
        public void LoadConsultation(int consultId)
        {
            var consult = ConsultService.GetById(consultId);
            if (consult == null) return;

            _patientId = consult.PatientId;
            _savedConsultId = consultId;
            _consultationDate = consult.ConsultDate;

            // Fill the form fields
            txtChief.Text = consult.ChiefComplaint;
            txtFindings.Text = consult.Findings;
            txtDiagnosis.Text = consult.Diagnosis;
            txtNotes.Text = consult.DoctorNotes;

            // Show patient header
            var p = PatientService.GetById(consult.PatientId);
            if (p != null)
            {
                lblPatientName.Text = p.FullName;
                int age = DateTime.Today.Year - p.DateOfBirth.Year;
                lblMeta.Text = $"{p.PatientCode}  |  {age} y/o  {p.Sex}";

                // Allergy banner
                lblAllergy.Visible = !string.IsNullOrWhiteSpace(p.KnownAllergies);
                if (lblAllergy.Visible)
                {
                    lblAllergy.Text = "⚠  ALLERGY: " + p.KnownAllergies;
                    lblAllergy.BackColor = System.Drawing.Color.FromArgb(153, 27, 27);
                    lblAllergy.ForeColor = System.Drawing.Color.White;
                }
            }

            // Consultation is already saved — lock Save, unlock Rx
            btnSave.Enabled = false;
            btnAddRx.Enabled = true;

            gbPatientInfo.Visible = true;
            ShowPlaceholder(null);
        }

        public void RefreshPatients(int? selectedPatientId = null)
        {
            LoadPatients(selectedPatientId ?? _patientId);
        }

        private void LoadPatients(int? selectedPatientId = null)
        {
            _isLoadingPatients = true;
            var patients = PatientService.GetAll();

            cmbPatients.DataSource = null;
            cmbPatients.DataSource = patients;
            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "PatientId";
            cmbPatients.SelectedIndex = -1;

            if (selectedPatientId.HasValue && selectedPatientId.Value > 0)
            {
                for (int i = 0; i < cmbPatients.Items.Count; i++)
                {
                    if (cmbPatients.Items[i] is Patient patient && patient.PatientId == selectedPatientId.Value)
                    {
                        cmbPatients.SelectedIndex = i;
                        break;
                    }
                }
            }

            _isLoadingPatients = false;
        }

        // ════════════════════════════════════════════════════════════════════
        // CORE PATIENT LOADER
        // All three entry points (A, B, C) end up here
        // ════════════════════════════════════════════════════════════════════
        private void SelectPatient(int patientId)
        {
            _patientId = patientId;
            _savedConsultId = 0;           // new session — no saved consult yet
            _consultationDate = DateTime.Now;

            btnSave.Enabled = true;
            btnAddRx.Enabled = false;

            ClearForm();

            var p = PatientService.GetById(patientId);
            if (p == null) return;

            // ── Patient identity bar ─────────────────────────────────────────
            lblPatientName.Text = p.FullName;
            int age = DateTime.Today.Year - p.DateOfBirth.Year;
            lblMeta.Text = $"{p.PatientCode}  |  {age} y/o  {p.Sex}";

            // ── Allergy banner ───────────────────────────────────────────────
            lblAllergy.Visible = !string.IsNullOrWhiteSpace(p.KnownAllergies);
            if (lblAllergy.Visible)
            {
                lblAllergy.Text = "⚠  ALLERGY: " + p.KnownAllergies;
                lblAllergy.BackColor = System.Drawing.Color.FromArgb(153, 27, 27);
                lblAllergy.ForeColor = System.Drawing.Color.White;
            }

            // ── Latest vitals summary ────────────────────────────────────────
            var vitals = VitalsService.GetByPatient(patientId);
            lblVitals.Text = vitals.Count > 0
                ? $"BP: {vitals[0].BloodPressure}  " +
                  $"HR: {vitals[0].HeartRate} bpm  " +
                  $"Temp: {vitals[0].Temperature}°C  " +
                  $"BMI: {vitals[0].Bmi} ({vitals[0].BmiCategory})"
                : "No vitals recorded yet for this patient.";

            // ── Show the form ────────────────────────────────────────────────
            gbPatientInfo.Visible = true;
            ShowPlaceholder(null);
            txtChief.Focus();
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingPatients || cmbPatients.SelectedIndex == -1) return;
            if (cmbPatients.SelectedItem is not Patient selectedPatient) return;

            SelectPatient(selectedPatient.PatientId);
        }

        // ════════════════════════════════════════════════════════════════════
        // SAVE CONSULTATION
        // ════════════════════════════════════════════════════════════════════
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Guard: patient must be selected
            if (_patientId == 0)
            {
                MessageBox.Show("Please search for and select a patient first.",
                    "No patient selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guard: chief complaint is mandatory
            if (string.IsNullOrWhiteSpace(txtChief.Text))
            {
                MessageBox.Show("Chief complaint is required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChief.Focus();
                return;
            }

            var c = new Consultation
            {
                PatientId = _patientId,
                DoctorId = _user.UserId,
                ChiefComplaint = txtChief.Text.Trim(),
                Findings = txtFindings.Text.Trim(),
                Diagnosis = txtDiagnosis.Text.Trim(),
                DoctorNotes = txtNotes.Text.Trim()
            };

            _savedConsultId = ConsultService.Save(c);
            _consultationDate = DateTime.Now;
            btnSave.Enabled = false;    // prevent double-saving
            btnAddRx.Enabled = true;     // unlock prescription entry

            MessageBox.Show("Consultation saved.\nYou can now add prescriptions.",
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Navigate to PrescriptionControl with this consultation pre-loaded
        private void btnAddRx_Click(object sender, EventArgs e)
        {
            _shell.NavigateTo("prescription", _savedConsultId);
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

            var latestVitals = VitalsService.GetByPatient(_patientId).FirstOrDefault();

            PrintService.ShowPrintPreview(
                this,
                $"Consultation - {patient.FullName}",
                BuildPrintableConsultation(patient, latestVitals));
        }

        // ════════════════════════════════════════════════════════════════════
        // HELPERS
        // ════════════════════════════════════════════════════════════════════
        private void ClearForm()
        {
            txtChief.Clear();
            txtFindings.Clear();
            txtDiagnosis.Clear();
            txtNotes.Clear();
            lblAllergy.Visible = false;
            lblVitals.Text = "";
        }

        private Label CreatePlaceholder()
        {
            Control parent = gbPatientInfo.Parent ?? this;
            var placeholder = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 249, 250),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Margin = gbPatientInfo.Margin,
                Visible = false
            };

            if (parent is TableLayoutPanel layout)
            {
                var position = layout.GetPositionFromControl(gbPatientInfo);
                layout.Controls.Add(placeholder, position.Column, position.Row);
            }
            else
            {
                parent.Controls.Add(placeholder);
            }

            placeholder.BringToFront();
            return placeholder;
        }

        private void ShowPlaceholder(string? message)
        {
            bool showPlaceholder = !string.IsNullOrWhiteSpace(message);
            _consultationPlaceholder.Text = message ?? string.Empty;
            _consultationPlaceholder.Visible = showPlaceholder;
            gbPatientInfo.Visible = !showPlaceholder;
        }

        private string BuildPrintableConsultation(Patient patient, VitalSigns? latestVitals)
        {
            var builder = new StringBuilder();
            int age = CalculateAge(patient.DateOfBirth);

            builder.AppendLine("CLINIC EMR CONSULTATION");
            builder.AppendLine($"Date: {_consultationDate:MMMM dd, yyyy hh:mm tt}");
            builder.AppendLine($"Doctor: {_user.FullName}");
            builder.AppendLine(_savedConsultId > 0
                ? $"Consultation No.: {_savedConsultId}"
                : "Consultation Status: Draft / Not yet saved");
            builder.AppendLine();

            PrintService.AppendSection(builder, "Patient Information", new[]
            {
                $"Patient Code: {PrintService.DisplayValue(patient.PatientCode)}",
                $"Name: {patient.FullName}",
                $"Age / Sex: {age} years old / {PrintService.DisplayValue(patient.Sex)}",
                $"Allergies: {PrintService.DisplayValue(patient.KnownAllergies)}"
            });

            PrintService.AppendSection(builder, "Latest Vital Signs", latestVitals == null
                ? Array.Empty<string>()
                : new[]
                {
                    $"Recorded At: {latestVitals.RecordedAt:MMMM dd, yyyy hh:mm tt}",
                    $"Blood Pressure: {PrintService.DisplayValue(latestVitals.BloodPressure)}",
                    $"Heart Rate: {latestVitals.HeartRate} bpm",
                    $"Temperature: {latestVitals.Temperature:0.0} C",
                    $"BMI: {latestVitals.Bmi:0.0} {PrintService.DisplayValue(latestVitals.BmiCategory, string.Empty)}".Trim()
                });

            PrintService.AppendSection(builder, "Consultation Notes", new[]
            {
                $"Chief Complaint: {PrintService.DisplayValue(txtChief.Text)}",
                $"Findings: {PrintService.DisplayValue(txtFindings.Text)}",
                $"Diagnosis: {PrintService.DisplayValue(txtDiagnosis.Text)}",
                $"Doctor Notes: {PrintService.DisplayValue(txtNotes.Text)}"
            });

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
