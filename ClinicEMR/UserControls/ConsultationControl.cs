using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace ClinicEMR.UserControls
{
    public partial class ConsultationControl : UserControl
    {
        private int _patientId = 0;
        private int _savedConsultId = 0;
        private bool _isLoadingPatients = false;
        private DateTime _consultationDate = DateTime.Now;
        private string _consultationStatus = "Active";
        private bool _isConsultationLocked = false;
        private readonly User _user;
        private readonly MainShellForm _shell;
        private readonly Label _consultationPlaceholder;

        public ConsultationControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;
            _consultationPlaceholder = CreatePlaceholder();
            LoadPatients();
            ConsultService.LockPastConsultations(_user.UserId);
            ResetViewState();
            ResetConsultationActions();
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.ApplyRoundedCorners(tblInfoIntro, 5);
            ThemeService.ApplyRoundedCorners(tblContent, 5);
            WireButtonVisualResets(btnPrint, btnVoidRx, btnSave, btnAddRx);

        }

        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            SelectPatient(patientId);
        }

        public void LoadConsultation(int consultId)
        {
            var consult = ConsultService.GetById(consultId);
            if (consult == null) return;

            SetSelectedPatient(consult.PatientId);
            _patientId = consult.PatientId;
            _savedConsultId = consultId;
            _consultationDate = consult.ConsultDate;
            _consultationStatus = NormalizeStatus(consult.Status);
            _isConsultationLocked = consult.IsLocked;

            txtConditions.Text = consult.ChiefComplaint;
            txtSurgeries.Text = consult.Findings;
            txtFamHx.Text = consult.Diagnosis;
            txtCurrentMeds.Text = consult.DoctorNotes;

            var p = PatientService.GetById(consult.PatientId);
            if (p != null)
            {
                BindPatientSummary(p);
                int age = CalculateAge(p.DateOfBirth);
                lblMeta.Text = $"{p.PatientCode}  |  {age} y/o  {p.Sex}";
                BindPatientVitals(p.PatientId);
            }

            bool isActive = string.Equals(_consultationStatus, "Active", StringComparison.OrdinalIgnoreCase);
            bool isEditable = isActive && !consult.IsLocked;

            btnSave.Text = "Update";
            SetActionButtonEnabled(btnSave, true);
            SetActionButtonEnabled(btnAddRx, isActive);
            btnVoidRx.Visible = true;
            SetActionButtonEnabled(btnVoidRx, isActive);
            SetConsultationInputsEnabled(isEditable);

            if (!isActive)
            {
                lblMeta.Text = $"{lblMeta.Text}  |  {_consultationStatus}";
            }
            else if (consult.IsLocked)
            {
                lblMeta.Text = $"{lblMeta.Text}  |  Locked";
            }

            ToggleConsultationState(true);
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

        private void SelectPatient(int patientId)
        {
            _patientId = patientId;
            _savedConsultId = 0;
            _consultationDate = DateTime.Now;
            _consultationStatus = "Active";
            _isConsultationLocked = false;

            btnSave.Text = "Save";
            SetActionButtonEnabled(btnSave, true);
            SetActionButtonEnabled(btnAddRx, false);
            ResetConsultationActions();
            ClearForm();

            var p = PatientService.GetById(patientId);
            if (p == null) return;

            BindPatientSummary(p);
            int age = CalculateAge(p.DateOfBirth);
            lblMeta.Text = $"{p.PatientCode}  |  {age} y/o  {p.Sex}";
            BindPatientVitals(patientId);

            ToggleConsultationState(true);
            SetConsultationInputsEnabled(true);
            txtConditions.Focus();
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingPatients || cmbPatients.SelectedIndex == -1) return;
            if (cmbPatients.SelectedItem is not Patient selectedPatient) return;

            SelectPatient(selectedPatient.PatientId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_patientId == 0)
            {
                MessageBox.Show("Please search for and select a patient first.",
                    "No patient selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtConditions.Text))
            {
                MessageBox.Show("Chief complaint is required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConditions.Focus();
                return;
            }

            if (string.Equals(_consultationStatus, "Voided", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot edit a voided consultation.",
                    "Editing Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetButtonPressedState(btnSave);
                return;
            }

            if (_savedConsultId > 0 && _isConsultationLocked)
            {
                MessageBox.Show("You cannot edit this consultation because it is from a past date.",
                    "Editing Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetButtonPressedState(btnSave);
                return;
            }

            var consultation = new Consultation
            {
                ConsultationId = _savedConsultId,
                PatientId = _patientId,
                DoctorId = _user.UserId,
                ChiefComplaint = txtConditions.Text.Trim(),
                Findings = txtSurgeries.Text.Trim(),
                Diagnosis = txtFamHx.Text.Trim(),
                DoctorNotes = txtCurrentMeds.Text.Trim()
            };

            if (_savedConsultId > 0)
            {
                if (!ConsultService.Update(consultation))
                {
                    MessageBox.Show("This consultation can no longer be updated.");
                    return;
                }

                MessageBox.Show("Consultation updated.",
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetButtonPressedState(btnSave);
                return;
            }

            _savedConsultId = ConsultService.Save(consultation);
            _consultationDate = DateTime.Now;
            btnSave.Text = "Update";
            SetActionButtonEnabled(btnAddRx, true);
            btnVoidRx.Visible = true;
            SetActionButtonEnabled(btnVoidRx, true);

            MessageBox.Show("Consultation saved.\nYou can now add prescriptions.",
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetButtonPressedState(btnSave);
        }

        private void btnAddRx_Click(object sender, EventArgs e)
        {
            _shell.NavigateTo("prescription", _savedConsultId);
        }

        private void BtnVoidConsultation_Click(object? sender, EventArgs e)
        {
            UpdateConsultationStatus("Voided");
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

        private void ClearForm()
        {
            txtConditions.Clear();
            txtSurgeries.Clear();
            txtFamHx.Clear();
            txtCurrentMeds.Clear();
            lblPatientName.Text = "Select a patient";
            lblMeta.Text = "No patient selected";
            lblVitals.Text = "No records";
            lblAllergy.Text = "None";
            panel2.Visible = true;
        }

        private void ResetConsultationActions()
        {
            btnVoidRx.Visible = true;
            SetActionButtonEnabled(btnVoidRx, _patientId > 0);
        }

        private void UpdateConsultationStatus(string status)
        {
            if (_savedConsultId <= 0)
            {
                MessageBox.Show("Please choose or save a consultation first.",
                    "No consultation selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to mark this consultation as {status}?",
                status,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (!ConsultService.UpdateStatus(_savedConsultId, _user.UserId, status))
            {
                MessageBox.Show("This consultation could not be updated.");
                return;
            }

            _consultationStatus = NormalizeStatus(status);
            SetActionButtonEnabled(btnSave, false);
            SetActionButtonEnabled(btnAddRx, false);
            SetActionButtonEnabled(btnVoidRx, false);
            SetConsultationInputsEnabled(false);
            tblFooter.Visible = false;
            lblMeta.Text = $"{lblMeta.Text}  |  {status}";
            MessageBox.Show($"Consultation marked as {status.ToLowerInvariant()}.");
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
                $"Chief Complaint: {PrintService.DisplayValue(txtConditions.Text)}",
                $"Findings: {PrintService.DisplayValue(txtSurgeries.Text)}",
                $"Diagnosis: {PrintService.DisplayValue(txtFamHx.Text)}",
                $"Doctor Notes: {PrintService.DisplayValue(txtCurrentMeds.Text)}"
            });

            return builder.ToString();
        }

        private Label CreatePlaceholder()
        {
            var placeholder = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 249, 250),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Margin = tblContent.Margin,
                Visible = false
            };

            var position = tblLayout.GetPositionFromControl(tblContent);
            tblLayout.Controls.Add(placeholder, position.Column, position.Row);
            return placeholder;
        }

        private void ResetViewState()
        {
            ClearForm();
            ToggleConsultationState(false);
            SetActionButtonEnabled(btnAddRx, false);
            SetActionButtonEnabled(btnSave, false);
            btnSave.Text = "Save";
            _isConsultationLocked = false;
        }

        private void ToggleConsultationState(bool hasPatient)
        {
            _consultationPlaceholder.Text = hasPatient
                ? string.Empty
                : "Choose a patient to display consultation details.";
            _consultationPlaceholder.Visible = !hasPatient;
            tblContent.Visible = hasPatient;
            tblContent.Enabled = hasPatient;
            tblFooter.Enabled = hasPatient;
            tblFooter.Visible = hasPatient;
            if (!hasPatient)
            {
                SetActionButtonEnabled(btnAddRx, false);
                SetActionButtonEnabled(btnSave, false);
                SetActionButtonEnabled(btnVoidRx, false);
            }
        }

        private void SetConsultationInputsEnabled(bool enabled)
        {
            txtConditions.Enabled = enabled;
            txtSurgeries.Enabled = enabled;
            txtFamHx.Enabled = enabled;
            txtCurrentMeds.Enabled = enabled;
        }

        private void BindPatientSummary(Patient patient)
        {
            lblPatientName.Text = patient.FullName;
            panel2.Visible = true;
            lblAllergy.Text = string.IsNullOrWhiteSpace(patient.KnownAllergies)
                ? "None"
                : patient.KnownAllergies.Trim();
        }

        private void BindPatientVitals(int patientId)
        {
            var vitals = VitalsService.GetByPatient(patientId);
            lblVitals.Text = vitals.Count > 0
                ? $"BP: {vitals[0].BloodPressure}  HR: {vitals[0].HeartRate} bpm  Temp: {vitals[0].Temperature}°C  BMI: {vitals[0].Bmi} ({vitals[0].BmiCategory})"
                : "No vitals recorded yet for this patient.";
        }

        private void SetSelectedPatient(int patientId)
        {
            _isLoadingPatients = true;
            try
            {
                for (int i = 0; i < cmbPatients.Items.Count; i++)
                {
                    if (cmbPatients.Items[i] is Patient patient && patient.PatientId == patientId)
                    {
                        cmbPatients.SelectedIndex = i;
                        break;
                    }
                }
            }
            finally
            {
                _isLoadingPatients = false;
            }
        }

        private void SetActionButtonEnabled(ReaLTaiizor.Controls.Button button, bool enabled)
        {
            button.Enabled = enabled;
            button.Cursor = enabled ? Cursors.Hand : Cursors.Default;
            RefreshButtonVisual(button);
        }

        private void ResetButtonPressedState(ReaLTaiizor.Controls.Button button)
        {
            if (txtConditions.Enabled)
            {
                txtConditions.Focus();
            }
            else if (cmbPatients.Enabled)
            {
                cmbPatients.Focus();
            }

            RefreshButtonVisual(button);
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

        private void ButtonVisualReset_MouseLeave(object? sender, EventArgs e)
        {
            RefreshButtonVisual(sender as Control);
        }

        private void ButtonVisualReset_MouseUp(object? sender, MouseEventArgs e)
        {
            RefreshButtonVisual(sender as Control);
        }

        private void ButtonVisualReset_LostFocus(object? sender, EventArgs e)
        {
            RefreshButtonVisual(sender as Control);
        }

        private void RefreshButtonVisual(Control? control)
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

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private static string NormalizeStatus(string? status)
        {
            return string.Equals(status, "Cancelled", StringComparison.OrdinalIgnoreCase)
                ? "Voided"
                : status ?? "Active";
        }
    }
}
