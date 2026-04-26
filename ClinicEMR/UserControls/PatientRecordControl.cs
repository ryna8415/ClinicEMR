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
        private readonly TableLayoutPanel _consultationActionsLayout = new();
        private readonly TableLayoutPanel _prescriptionActionsLayout = new();
        private readonly ReaLTaiizor.Controls.Button _btnEditConsultation = new();
        private readonly ReaLTaiizor.Controls.Button _btnVoidConsultation = new();
        private readonly ReaLTaiizor.Controls.Button _btnEditPrescription = new();
        private readonly ReaLTaiizor.Controls.Button _btnVoidPrescription = new();
        private bool IsDoctor => string.Equals(_user.Role, "doctor", StringComparison.OrdinalIgnoreCase);

        public PatientRecordControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;
            _vitalsPlaceholder = CreateGridPlaceholder(tabVitals, "Choose a patient to display vital signs.");
            _consultationsPlaceholder = CreateGridPlaceholder(tabConsultations, "Choose a patient to display consultations.");
            _prescriptionsPlaceholder = CreateGridPlaceholder(tabPrescriptions, "Choose a patient to display prescriptions.");
            ConfigureActionFooters();

            LoadPatients();
            ConfigureGrid(dgvVitals);
            ConfigureGrid(dgvConsultations);
            ConfigureGrid(dgvPrescriptions);
            dgvConsultations.CellDoubleClick += dgvConsultations_CellDoubleClick;
            dgvPrescriptions.CellDoubleClick += dgvPrescriptions_CellDoubleClick;
            dgvConsultations.SelectionChanged += (_, _) => UpdateConsultationActionState();
            dgvPrescriptions.SelectionChanged += (_, _) => UpdatePrescriptionActionState();
            ClearView();
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.ApplyRoundedCorners(tblSummary, 5);
            ThemeService.ApplyRoundedCorners(tblInfoIntro, 5);
            ThemeService.TryRoundGrid(dgvVitals, 4);
            ThemeService.TryRoundGrid(dgvConsultations, 4);
            ThemeService.TryRoundGrid(dgvPrescriptions, 4);
            WireButtonVisualResets(btnBack, btnPrint, btnEdit);

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

            lblMeta.Text = $"{p.PatientCode}      |      {age} y/o  {p.Sex}      |      {p.ContactNumber}";

            if (!string.IsNullOrWhiteSpace(p.KnownAllergies))
            {
                lblAllergy.Text = p.KnownAllergies;
                lblAllergy.Visible = true;
            }
            else
            {
                lblAllergy.Text = "None";
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

            txtHxConditions.Text = p.ChronicConditions ?? "";
            txtHxSurgeries.Text = p.PastSurgeries ?? "";
            txtHxFamilyHis.Text = p.FamilyHistory ?? "";
            txtHxMeds.Text = p.CurrentMedications ?? "";

            FormatVitalsGrid();
            FormatConsultGrid();
            FormatRxGrid();
            ShowPlaceholder(_vitalsPlaceholder, dgvVitals, vitals.Count == 0 ? "No vital signs to show for this patient yet." : null);
            ShowPlaceholder(_consultationsPlaceholder, dgvConsultations, consultations.Count == 0 ? "No consultations to show for this patient yet." : null);
            ShowPlaceholder(_prescriptionsPlaceholder, dgvPrescriptions, prescriptions.Count == 0 ? "No prescriptions to show for this patient yet." : null);
            UpdateConsultationActionState();
            UpdatePrescriptionActionState();
        }

        private void ConfigureGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            GridViewService.MakeReadOnly(grid);
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
            txtHxConditions.Clear();
            txtHxSurgeries.Clear();
            txtHxFamilyHis.Clear();
            txtHxMeds.Clear();
            UpdateConsultationActionState();
            UpdatePrescriptionActionState();
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
                "ConsultationId",
                "ConsultDate",
                "DoctorName",
                "ChiefComplaint",
                "Diagnosis",
                "Status");

            GridViewService.SetHeaders(dgvConsultations, new System.Collections.Generic.Dictionary<string, string>
            {
                ["ConsultDate"] = "Date",
                ["DoctorName"] = "Doctor",
                ["ChiefComplaint"] = "Chief Complaint",
                ["Diagnosis"] = "Diagnosis",
                ["Status"] = "Status"
            });

            if (dgvConsultations.Columns["ConsultationId"] != null)
            {
                dgvConsultations.Columns["ConsultationId"].Visible = false;
            }
        }

        private void FormatRxGrid()
        {
            GridViewService.ShowOnly(
                dgvPrescriptions,
                "PrescriptionId",
                "MedicationName",
                "Dosage",
                "Frequency",
                "Duration",
                "Instructions",
                "Status");

            GridViewService.SetHeaders(dgvPrescriptions, new System.Collections.Generic.Dictionary<string, string>
            {
                ["MedicationName"] = "Medication",
                ["Dosage"] = "Dosage",
                ["Frequency"] = "Frequency",
                ["Duration"] = "Duration",
                ["Instructions"] = "Instructions",
                ["Status"] = "Status"
            });

            if (dgvPrescriptions.Columns["PrescriptionId"] != null)
            {
                dgvPrescriptions.Columns["PrescriptionId"].Visible = false;
            }
        }

        private void dgvConsultations_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (!IsDoctor)
            {
                return;
            }

            if (e.RowIndex < 0 || dgvConsultations.Rows[e.RowIndex].Cells["ConsultationId"].Value == null)
            {
                return;
            }

            int consultationId = Convert.ToInt32(dgvConsultations.Rows[e.RowIndex].Cells["ConsultationId"].Value);
            _shell.NavigateTo("consultationedit", consultationId);
        }

        private void dgvPrescriptions_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (!IsDoctor)
            {
                return;
            }

            if (e.RowIndex < 0 || dgvPrescriptions.Rows[e.RowIndex].Cells["PrescriptionId"].Value == null)
            {
                return;
            }

            int prescriptionId = Convert.ToInt32(dgvPrescriptions.Rows[e.RowIndex].Cells["PrescriptionId"].Value);
            _shell.NavigateTo("prescriptionedit", prescriptionId);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            _shell.NavigateTo("patients");
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

        private void ConfigureActionFooters()
        {
            ConfigureActionTab(tabConsultations, dgvConsultations, _consultationActionsLayout,
                (_btnVoidConsultation, "Void", BtnVoidConsultation_Click),
                (_btnEditConsultation, "Edit", BtnEditConsultation_Click));

            ConfigureActionTab(tabPrescriptions, dgvPrescriptions, _prescriptionActionsLayout,
                (_btnVoidPrescription, "Void", BtnVoidPrescription_Click),
                (_btnEditPrescription, "Edit", BtnEditPrescription_Click));
        }

        private static bool TryGetGridId(DataGridView grid, int rowIndex, string columnName, out int id)
        {
            id = 0;
            if (rowIndex < 0 || rowIndex >= grid.Rows.Count)
            {
                return false;
            }

            object? value = grid.Rows[rowIndex].Cells[columnName].Value;
            if (value == null)
            {
                return false;
            }

            id = Convert.ToInt32(value);
            return true;
        }

        private void ConfigureActionTab(
            TabPage tabPage,
            DataGridView grid,
            TableLayoutPanel layout,
            params (ReaLTaiizor.Controls.Button Button, string Text, EventHandler Click)[] actions)
        {
            tabPage.SuspendLayout();

            tabPage.Controls.Remove(grid);

            layout.BackColor = tabPage.BackColor;
            layout.ColumnCount = 1;
            layout.RowCount = 2;
            layout.Dock = DockStyle.Fill;
            layout.Margin = new Padding(0);
            layout.Padding = new Padding(3);
            layout.RowStyles.Clear();
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layout.Controls.Clear();

            grid.Dock = DockStyle.Fill;
            layout.Controls.Add(grid, 0, 0);

            var footer = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = tabPage.BackColor,
                Margin = new Padding(0),
                ColumnCount = actions.Length + 1,
                RowCount = 1
            };

            footer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            for (int i = 0; i < actions.Length; i++)
            {
                footer.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            }
            footer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            for (int i = 0; i < actions.Length; i++)
            {
                var action = actions[i];
                bool isEditButton = string.Equals(action.Text, "Edit", StringComparison.OrdinalIgnoreCase);
                bool isLastButton = i == actions.Length - 1;
                ConfigureFooterButton(action.Button, action.Text, action.Click, tabPage.BackColor, isEditButton, isLastButton);
                footer.Controls.Add(action.Button, i + 1, 0);
            }

            layout.Controls.Add(footer, 0, 1);
            footer.Visible = IsDoctor;
            layout.RowStyles[1].Height = IsDoctor ? 48F : 0F;
            tabPage.Controls.Add(layout);

            tabPage.ResumeLayout();
        }

        private static void ConfigureFooterButton(
            ReaLTaiizor.Controls.Button button,
            string text,
            EventHandler clickHandler,
            Color backColor,
            bool isEditButton,
            bool isLastButton)
        {
            button.Anchor = AnchorStyles.Right;
            button.BackColor = backColor;
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            button.Image = null;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Margin = isLastButton
                ? new Padding(0, 4, 4, 4)
                : new Padding(0, 4, 8, 4);
            button.Name = $"{text}ActionButton";
            button.Size = new Size(100, 40);
            button.Text = text;
            button.TextAlignment = StringAlignment.Center;
            button.Click -= clickHandler;
            button.Click += clickHandler;
            button.MouseLeave -= ButtonVisualReset_MouseLeave;
            button.MouseUp -= ButtonVisualReset_MouseUp;
            button.LostFocus -= ButtonVisualReset_LostFocus;
            button.MouseLeave += ButtonVisualReset_MouseLeave;
            button.MouseUp += ButtonVisualReset_MouseUp;
            button.LostFocus += ButtonVisualReset_LostFocus;

            if (isEditButton)
            {
                button.BorderColor = Color.FromArgb(26, 35, 48);
                button.EnteredBorderColor = Color.FromArgb(26, 35, 48);
                button.EnteredColor = Color.FromArgb(69, 85, 97);
                button.InactiveColor = Color.FromArgb(26, 35, 48);
                button.PressedBorderColor = Color.FromArgb(69, 85, 97);
                button.PressedColor = Color.FromArgb(69, 85, 97);
            }
            else
            {
                button.BorderColor = Color.FromArgb(108, 111, 127);
                button.EnteredBorderColor = Color.FromArgb(108, 111, 127);
                button.EnteredColor = Color.FromArgb(69, 85, 97);
                button.InactiveColor = Color.FromArgb(92, 102, 114);
                button.PressedBorderColor = Color.FromArgb(108, 111, 127);
                button.PressedColor = Color.FromArgb(108, 111, 127);
            }
        }

        private void BtnEditConsultation_Click(object? sender, EventArgs e)
        {
            if (!TryGetSelectedId(dgvConsultations, "ConsultationId", out int consultationId))
            {
                MessageBox.Show("Select a consultation first.");
                return;
            }

            if (TryGetSelectedConsultationStatus(out string? status) && IsVoidedStatus(status))
            {
                MessageBox.Show("You cannot edit a voided consultation.");
                return;
            }

            _shell.NavigateTo("consultationedit", consultationId);
        }

        private void BtnVoidConsultation_Click(object? sender, EventArgs e)
        {
            if (!TryGetSelectedId(dgvConsultations, "ConsultationId", out int consultationId))
            {
                MessageBox.Show("Select a consultation first.");
                return;
            }

            if (TryGetSelectedConsultationStatus(out string? status) && !IsActiveStatus(status))
            {
                MessageBox.Show("You can only void an active consultation.");
                return;
            }

            UpdateConsultationStatus(consultationId, "Voided");
        }

        private void BtnEditPrescription_Click(object? sender, EventArgs e)
        {
            if (!TryGetSelectedId(dgvPrescriptions, "PrescriptionId", out int prescriptionId))
            {
                MessageBox.Show("Select a prescription first.");
                return;
            }

            if (TryGetSelectedPrescriptionStatus(out string? status) && IsVoidedStatus(status))
            {
                MessageBox.Show("You cannot edit a voided prescription.");
                return;
            }

            _shell.NavigateTo("prescriptionedit", prescriptionId);
        }

        private void BtnVoidPrescription_Click(object? sender, EventArgs e)
        {
            if (!TryGetSelectedId(dgvPrescriptions, "PrescriptionId", out int prescriptionId))
            {
                MessageBox.Show("Select a prescription first.");
                return;
            }

            if (TryGetSelectedPrescriptionStatus(out string? status) && !IsActiveStatus(status))
            {
                MessageBox.Show("You can only void an active prescription.");
                return;
            }

            UpdatePrescriptionStatus(prescriptionId, "Voided");
        }

        private static bool TryGetSelectedId(DataGridView grid, string columnName, out int id)
        {
            id = 0;
            if (grid.CurrentRow == null || grid.CurrentRow.Index < 0)
            {
                return false;
            }

            return TryGetGridId(grid, grid.CurrentRow.Index, columnName, out id);
        }

        private void UpdateConsultationActionState()
        {
            if (!IsDoctor)
            {
                _btnEditConsultation.Visible = false;
                _btnVoidConsultation.Visible = false;
                return;
            }

            _btnEditConsultation.Visible = true;
            _btnVoidConsultation.Visible = true;
            _btnEditConsultation.Enabled = true;
            _btnVoidConsultation.Enabled = true;
        }

        private void UpdatePrescriptionActionState()
        {
            if (!IsDoctor)
            {
                _btnEditPrescription.Visible = false;
                _btnVoidPrescription.Visible = false;
                return;
            }

            _btnEditPrescription.Visible = true;
            _btnVoidPrescription.Visible = true;
            _btnEditPrescription.Enabled = true;
            _btnVoidPrescription.Enabled = true;
        }

        private bool TryGetSelectedConsultationStatus(out string? status)
        {
            status = null;
            if (dgvConsultations.CurrentRow == null || dgvConsultations.Columns["Status"] == null)
            {
                return false;
            }

            status = NormalizeStatus(dgvConsultations.CurrentRow.Cells["Status"].Value?.ToString());
            return !string.IsNullOrWhiteSpace(status);
        }

        private bool TryGetSelectedPrescriptionStatus(out string? status)
        {
            status = null;
            if (dgvPrescriptions.CurrentRow == null || dgvPrescriptions.Columns["Status"] == null)
            {
                return false;
            }

            status = NormalizeStatus(dgvPrescriptions.CurrentRow.Cells["Status"].Value?.ToString());
            return !string.IsNullOrWhiteSpace(status);
        }

        private static bool IsActiveStatus(string? status)
        {
            return string.Equals(NormalizeStatus(status), "Active", StringComparison.OrdinalIgnoreCase);
        }

        private static bool IsVoidedStatus(string? status)
        {
            return string.Equals(NormalizeStatus(status), "Voided", StringComparison.OrdinalIgnoreCase);
        }

        private static string NormalizeStatus(string? status)
        {
            if (string.Equals(status, "Cancelled", StringComparison.OrdinalIgnoreCase))
            {
                return "Voided";
            }

            return status ?? string.Empty;
        }

        private void WireButtonVisualResets(params ReaLTaiizor.Controls.Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.MouseLeave -= ButtonVisualReset_MouseLeave;
                button.MouseUp -= ButtonVisualReset_MouseUp;
                button.LostFocus -= ButtonVisualReset_LostFocus;
                button.MouseLeave += ButtonVisualReset_MouseLeave;
                button.MouseUp += ButtonVisualReset_MouseUp;
                button.LostFocus += ButtonVisualReset_LostFocus;
            }
        }

        private static void ButtonVisualReset_MouseLeave(object? sender, EventArgs e)
        {
            RefreshButtonVisual(sender as Control);
        }

        private static void ButtonVisualReset_MouseUp(object? sender, MouseEventArgs e)
        {
            RefreshButtonVisual(sender as Control);
        }

        private static void ButtonVisualReset_LostFocus(object? sender, EventArgs e)
        {
            RefreshButtonVisual(sender as Control);
        }

        private static void RefreshButtonVisual(Control? control)
        {
            if (control == null || control.IsDisposed)
            {
                return;
            }

            if (control.IsHandleCreated)
            {
                control.BeginInvoke((MethodInvoker)(() =>
                {
                    if (control.IsDisposed)
                    {
                        return;
                    }

                    control.Invalidate();
                    control.Refresh();
                }));
                return;
            }

            control.Invalidate();
            control.Refresh();
        }

        private void UpdateConsultationStatus(int consultationId, string status)
        {
            var confirm = MessageBox.Show(
                $"Are you sure you want to mark this consultation as {status}?",
                status,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (!ConsultService.UpdateStatus(consultationId, _user.UserId, status))
            {
                MessageBox.Show("Only active consultations can be updated.");
                return;
            }

            LoadPatientDetails(_patientId);
            MessageBox.Show($"Consultation marked as {status.ToLowerInvariant()}.");
        }

        private void UpdatePrescriptionStatus(int prescriptionId, string status)
        {
            var confirm = MessageBox.Show(
                $"Are you sure you want to mark this prescription as {status}?",
                status,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (!PrescriptionService.UpdateStatus(prescriptionId, status, _user.UserId))
            {
                MessageBox.Show("Only active prescriptions can be updated.");
                return;
            }

            LoadPatientDetails(_patientId);
            MessageBox.Show($"Prescription marked as {status.ToLowerInvariant()}.");
        }

    }
}
