using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace ClinicEMR.UserControls
{
    public partial class PrescriptionControl : UserControl
    {
        private int _consultationId = 0;
        private int _patientId = 0;
        private int _editingPrescriptionId = 0;
        private bool _isLoadingPatients = false;
        private readonly User _user;
        private readonly MainShellForm _shell;

        public PrescriptionControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;

            LoadPatients();
            SetIssuedDateNow();
            ResetEditorState();
            ResetHeader();
            RefreshPrescriptionList();

            cboPatient.SelectedIndexChanged += cboPatient_SelectedIndexChanged;
            lstDrugs.SelectedIndexChanged += lstDrugs_SelectedIndexChanged;
            btnSave.Click += btnSave_Click;
            btnEdit.Click += btnEdit_Click;
            btnVoid.Click += btnVoid_Click;
            btnDone.Click += btnDone_Click;
            btnPrint.Click += btnPrint_Click;
            WireButtonVisualResets(btnPrint, btnSave, btnEdit, btnVoid, btnDone);
        }

        public void LoadConsultation(int consultId)
        {
            var consult = ConsultService.GetById(consultId);
            if (consult == null)
            {
                return;
            }

            _consultationId = consultId;
            _patientId = consult.PatientId;

            SelectPatient(consult.PatientId);
            cboPatient.Enabled = false;
            BindPatientHeader(consult.PatientId);
            RefreshPrescriptionList();
            ResetEditorState();
        }

        public void ResetForStandalone()
        {
            _consultationId = 0;
            _patientId = 0;
            cboPatient.Enabled = true;
            LoadPatients();
            cboPatient.SelectedIndex = -1;
            ResetHeader();
            RefreshPrescriptionList();
            ResetEditorState();
        }

        public void LoadPrescription(int prescriptionId)
        {
            var prescription = PrescriptionService.GetById(prescriptionId);
            if (prescription == null)
            {
                return;
            }

            if (prescription.ConsultationId > 0)
            {
                LoadConsultation(prescription.ConsultationId);
            }
            else
            {
                ResetForStandalone();
                _patientId = prescription.PatientId;
                SelectPatient(prescription.PatientId);
            }

            RefreshPrescriptionList(prescriptionId);
            LoadPrescriptionIntoEditor(prescription);
        }

        private void LoadPatients()
        {
            _isLoadingPatients = true;
            try
            {
                var patients = PatientService.GetAll();
                cboPatient.DataSource = null;
                cboPatient.DataSource = patients;
                cboPatient.DisplayMember = "FullName";
                cboPatient.ValueMember = "PatientId";
                cboPatient.SelectedIndex = -1;
            }
            finally
            {
                _isLoadingPatients = false;
            }
        }

        private void cboPatient_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isLoadingPatients || cboPatient.SelectedIndex == -1)
            {
                if (!_isLoadingPatients && cboPatient.SelectedIndex == -1 && _consultationId == 0)
                {
                    _patientId = 0;
                    ResetHeader();
                    RefreshPrescriptionList();
                    ResetEditorState();
                }
                return;
            }

            if (cboPatient.SelectedItem is not Patient patient)
            {
                return;
            }

            _patientId = patient.PatientId;
            BindPatientHeader(patient.PatientId);

            if (_consultationId == 0)
            {
                RefreshPrescriptionList();
            }

            ResetEditorState();
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (_patientId <= 0)
            {
                MessageBox.Show("Please select a patient first.",
                    "No patient selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPatient.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMedication.Text))
            {
                MessageBox.Show("Medication name is required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedication.Focus();
                return;
            }

            var prescription = new Prescription
            {
                PrescriptionId = _editingPrescriptionId,
                ConsultationId = _consultationId,
                PatientId = _patientId,
                MedicationName = txtMedication.Text.Trim(),
                Dosage = txtDosage.Text.Trim(),
                Frequency = txtFrequency.Text.Trim(),
                Duration = txtDuration.Text.Trim(),
                Instructions = txtInstructions.Text.Trim()
            };

            if (_editingPrescriptionId > 0)
            {
                if (!PrescriptionService.Update(prescription, _user.UserId))
                {
                    MessageBox.Show("Only active prescriptions can be updated.");
                    return;
                }

                RefreshPrescriptionList(prescription.PrescriptionId);
                MessageBox.Show("Prescription updated.",
                    "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetButtonPressedState(btnSave);
                return;
            }

            PrescriptionService.Add(prescription, _user.UserId);
            RefreshPrescriptionList();
            LoadLatestPrescriptionIntoEditor();
            MessageBox.Show("Prescription saved.",
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetButtonPressedState(btnSave);
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (lstDrugs.SelectedItem is not Prescription prescription)
            {
                MessageBox.Show("Select a prescription first.");
                return;
            }

            if (!IsEditablePrescription(prescription))
            {
                MessageBox.Show("You cannot edit a voided prescription.",
                    "Editing Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadPrescriptionIntoEditor(prescription);
        }

        private void btnVoid_Click(object? sender, EventArgs e)
        {
            if (lstDrugs.SelectedItem is not Prescription prescription)
            {
                MessageBox.Show("Select a prescription first.");
                return;
            }

            if (!IsActivePrescription(prescription))
            {
                MessageBox.Show("You can only void an active prescription.",
                    "Voiding Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to void this prescription?",
                "Void Prescription",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            if (!PrescriptionService.UpdateStatus(prescription.PrescriptionId, "Voided", _user.UserId))
            {
                MessageBox.Show("Only active prescriptions can be updated.");
                return;
            }

            RefreshPrescriptionList(prescription.PrescriptionId);
            MessageBox.Show("Prescription marked as voided.",
                "Voided", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDone_Click(object? sender, EventArgs e)
        {
            if (!HasDrugInputs())
            {
                MessageBox.Show("There are no prescription details to clear.",
                    "Nothing to clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lstDrugs.ClearSelected();
            ClearDrugFields();
            ResetEditorState();

            if (_consultationId == 0)
            {
                cboPatient.Enabled = true;
                cboPatient.SelectedIndex = -1;
                _patientId = 0;
                ResetHeader();
                RefreshPrescriptionList();
            }

            SetIssuedDateNow();
        }

        private void btnPrint_Click(object? sender, EventArgs e)
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

            var prescriptions = lstDrugs.Items.OfType<Prescription>().ToList();
            if (prescriptions.Count == 0)
            {
                MessageBox.Show("Add at least one medication before printing.");
                return;
            }

            PrintService.ShowPrintPreview(
                this,
                $"Prescription - {patient.FullName}",
                BuildPrintablePrescription(patient, prescriptions));
        }

        private void lstDrugs_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstDrugs.SelectedItem is Prescription prescription)
            {
                btnEdit.Enabled = true;
                btnVoid.Enabled = true;
                return;
            }

            btnEdit.Enabled = false;
            btnVoid.Enabled = false;
        }

        private void RefreshPrescriptionList(int? selectedPrescriptionId = null)
        {
            lstDrugs.Items.Clear();

            IEnumerable<Prescription> prescriptions = Enumerable.Empty<Prescription>();

            if (_consultationId > 0)
            {
                prescriptions = PrescriptionService.GetByConsultation(_consultationId);
            }
            else if (_patientId > 0)
            {
                prescriptions = PrescriptionService.GetByPatient(_patientId);
            }

            foreach (var prescription in prescriptions)
            {
                lstDrugs.Items.Add(prescription);
            }

            if (selectedPrescriptionId.HasValue)
            {
                SelectPrescriptionInList(selectedPrescriptionId.Value);
            }
        }

        private void LoadLatestPrescriptionIntoEditor()
        {
            if (lstDrugs.Items.Count == 0)
            {
                ResetEditorState();
                return;
            }

            var prescription = lstDrugs.Items[lstDrugs.Items.Count - 1] as Prescription;
            if (prescription != null)
            {
                lstDrugs.SelectedItem = prescription;
                LoadPrescriptionIntoEditor(prescription);
            }
        }

        private void LoadPrescriptionIntoEditor(Prescription prescription)
        {
            _editingPrescriptionId = prescription.PrescriptionId;
            txtMedication.Text = prescription.MedicationName;
            txtDosage.Text = prescription.Dosage;
            txtFrequency.Text = prescription.Frequency;
            txtDuration.Text = prescription.Duration;
            txtInstructions.Text = prescription.Instructions;
            btnSave.Text = "Update";

            bool isActive = string.Equals(prescription.Status, "Active", StringComparison.OrdinalIgnoreCase);
            btnSave.Enabled = isActive;
            btnVoid.Enabled = true;
            btnEdit.Enabled = true;

            txtMedication.Focus();
        }

        private void ResetEditorState()
        {
            _editingPrescriptionId = 0;
            btnSave.Text = "Add Drug";
            btnSave.Enabled = _patientId > 0;
            btnEdit.Enabled = lstDrugs.SelectedItem is Prescription;
            btnVoid.Enabled = _patientId > 0;
            ClearDrugFields();
        }

        private void ClearDrugFields()
        {
            txtMedication.Clear();
            txtDosage.Clear();
            txtFrequency.Clear();
            txtDuration.Clear();
            txtInstructions.Clear();
        }

        private bool HasDrugInputs()
        {
            return !string.IsNullOrWhiteSpace(txtMedication.Text)
                || !string.IsNullOrWhiteSpace(txtDosage.Text)
                || !string.IsNullOrWhiteSpace(txtFrequency.Text)
                || !string.IsNullOrWhiteSpace(txtDuration.Text)
                || !string.IsNullOrWhiteSpace(txtInstructions.Text);
        }

        private void SelectPatient(int patientId)
        {
            _isLoadingPatients = true;
            try
            {
                for (int i = 0; i < cboPatient.Items.Count; i++)
                {
                    if (cboPatient.Items[i] is Patient patient && patient.PatientId == patientId)
                    {
                        cboPatient.SelectedIndex = i;
                        break;
                    }
                }
            }
            finally
            {
                _isLoadingPatients = false;
            }
        }

        private void SelectPrescriptionInList(int prescriptionId)
        {
            for (int i = 0; i < lstDrugs.Items.Count; i++)
            {
                if (lstDrugs.Items[i] is Prescription prescription &&
                    prescription.PrescriptionId == prescriptionId)
                {
                    lstDrugs.SelectedIndex = i;
                    btnEdit.Enabled = true;
                    btnVoid.Enabled = true;
                    return;
                }
            }
        }

        private void BindPatientHeader(int patientId)
        {
            var patient = PatientService.GetById(patientId);
            if (patient == null)
            {
                ResetHeader();
                return;
            }

            lblPatientName.Text = patient.FullName;
            lblMeta.Text = patient.PatientCode;
            btnSave.Enabled = true;
            btnVoid.Enabled = true;
        }

        private void ResetHeader()
        {
            lblPatientName.Text = "None Selected";
            lblMeta.Text = "Select a patient from the list";
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnVoid.Enabled = false;
        }

        private void SetIssuedDateNow()
        {
            lblDate.Text = $"Date: {DateTime.Now:MMM dd, yyyy}";
        }

        private void ResetButtonPressedState(Control button)
        {
            txtMedication.Focus();
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

        private string BuildPrintablePrescription(Patient patient, IReadOnlyList<Prescription> prescriptions)
        {
            var builder = new StringBuilder();
            builder.AppendLine("CLINIC EMR PRESCRIPTION");
            builder.AppendLine($"Date: {DateTime.Now:MMMM dd, yyyy hh:mm tt}");
            builder.AppendLine($"Prescribed by: {_user.FullName}");
            builder.AppendLine();

            PrintService.AppendSection(builder, "Patient Information", new[]
            {
                $"Patient Code: {PrintService.DisplayValue(patient.PatientCode)}",
                $"Name: {patient.FullName}",
                $"Allergies: {PrintService.DisplayValue(patient.KnownAllergies)}"
            });

            PrintService.AppendSection(
                builder,
                "Medications",
                prescriptions.Select((prescription, index) =>
                    $"{index + 1}. {PrintService.DisplayValue(prescription.MedicationName)} | Dosage: {PrintService.DisplayValue(prescription.Dosage)} | Frequency: {PrintService.DisplayValue(prescription.Frequency)} | Duration: {PrintService.DisplayValue(prescription.Duration)} | Instructions: {PrintService.DisplayValue(prescription.Instructions)}"));

            return builder.ToString();
        }

        private static bool IsActivePrescription(Prescription prescription)
        {
            return string.Equals(NormalizeStatus(prescription.Status), "Active", StringComparison.OrdinalIgnoreCase);
        }

        private static bool IsEditablePrescription(Prescription prescription)
        {
            return IsActivePrescription(prescription);
        }

        private static string NormalizeStatus(string? status)
        {
            return string.Equals(status, "Cancelled", StringComparison.OrdinalIgnoreCase)
                ? "Voided"
                : status ?? "Active";
        }
    }
}
