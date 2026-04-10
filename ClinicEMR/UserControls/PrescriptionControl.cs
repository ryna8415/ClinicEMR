using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class PrescriptionControl : UserControl
    {
        // ── Private state ────────────────────────────────────────────────────
        // _consultationId = 0  →  standalone mode  (NULL saved to DB)
        // _consultationId > 0  →  linked mode      (real ID saved to DB)
        private int _consultationId = 0;
        private int _patientId = 0;

        private readonly User _user;

        // ── Constructor ──────────────────────────────────────────────────────
        public PrescriptionControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            lstDrugs.DisplayMember = nameof(Prescription.Summary);

            // Load all patients into the combo once on startup
            LoadPatients();
            SetConsultDateNow();
        }

        // ════════════════════════════════════════════════════════════════════
        // PUBLIC ENTRY POINTS
        // ════════════════════════════════════════════════════════════════════

        // MODE 1 — Called by MainShellForm.NavigateTo("prescription", consultId)
        // Pre-loads the patient from the consultation and locks the combo.
        public void LoadConsultation(int consultId)
        {
            _consultationId = consultId;

            // Pre-load any drugs already saved under this consultation
            lstDrugs.Items.Clear();
            foreach (var rx in PrescriptionService.GetByConsultation(consultId))
                lstDrugs.Items.Add(rx);

            // Find the patient linked to this consultation
            var consult = ConsultService.GetById(consultId);
            if (consult == null) return;

            _patientId = consult.PatientId;

            // Select the matching patient in the combo by searching for their index.
            // SelectedValue is unreliable right after DataSource is set,
            // so we iterate and match by PatientId instead.
            for (int i = 0; i < cboPatient.Items.Count; i++)
            {
                var p = cboPatient.Items[i] as Patient;
                if (p != null && p.PatientId == consult.PatientId)
                {
                    cboPatient.SelectedIndex = i;
                    break;
                }
            }

            // Lock the combo so the doctor cannot change the patient
            // while working on a linked consultation
            cboPatient.Enabled = false;

            // Show mode indicator
            lblModeInfo.Text = $"Linked to consultation #{consultId}  —  patient is pre-selected.";
            lblModeInfo.Visible = true;
        }

        // MODE 2 — Called by MainShellForm nav button click (standalone)
        // Resets everything so the doctor can freely pick a patient.
        public void ResetForStandalone()
        {
            _consultationId = 0;
            _patientId = 0;

            lstDrugs.Items.Clear();
            ClearDrugFields();

            // Unlock the combo for free selection
            cboPatient.Enabled = true;
            cboPatient.SelectedIndex = -1;

            // Reload the patient list in case new patients were registered
            LoadPatients();

            // Show mode indicator
            lblModeInfo.Text = "Standalone prescription  —  select a patient from the list below.";
            lblModeInfo.Visible = true;
        }

        // ════════════════════════════════════════════════════════════════════
        // PATIENT COMBO
        // ════════════════════════════════════════════════════════════════════
        private void LoadPatients()
        {
            var patients = PatientService.GetAll();

            // Set DataSource to null first to avoid binding glitches
            cboPatient.DataSource = null;
            cboPatient.DataSource = patients;
            cboPatient.DisplayMember = "FullName";
            cboPatient.ValueMember = "PatientId";
            cboPatient.SelectedIndex = -1;
        }

        private void cboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPatient.SelectedIndex == -1)
            {
                _patientId = 0;
                return;
            }

            if (cboPatient.SelectedItem is Patient selectedPatient)
            {
                _patientId = selectedPatient.PatientId;
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // ADD DRUG
        // ════════════════════════════════════════════════════════════════════
        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            // ── Validation ───────────────────────────────────────────────────
            if (cboPatient.SelectedIndex < 0 || _patientId == 0)
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

            // ── Build the prescription object ────────────────────────────────
            var rx = new Prescription
            {
                // 0 → PrescriptionService sends NULL to the database (standalone)
                // >0 → linked to the consultation
                ConsultationId = _consultationId,
                PatientId = _patientId,
                MedicationName = txtMedication.Text.Trim(),
                Dosage = txtDosage.Text.Trim(),
                Frequency = txtFrequency.Text.Trim(),
                Duration = txtDuration.Text.Trim(),
                Instructions = txtInstructions.Text.Trim()
            };

            // ── Save and update the list ─────────────────────────────────────
            PrescriptionService.Add(rx);
            lstDrugs.Items.Add(rx);

            // Clear input fields and move focus back for the next drug
            ClearDrugFields();
            txtMedication.Focus();
        }

        // ════════════════════════════════════════════════════════════════════
        // HELPERS
        // ════════════════════════════════════════════════════════════════════
        private void ClearDrugFields()
        {
            txtMedication.Clear();
            txtDosage.Clear();
            txtFrequency.Clear();
            txtDuration.Clear();
            txtInstructions.Clear();
        }

        private void SetConsultDateNow()
        {
            lblConsultDate.Text = $"Date: {DateTime.Now:MMM dd, yyyy}";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prescription completed.");

            lstDrugs.Items.Clear();

            txtMedication.Clear();
            txtDosage.Clear();
            txtFrequency.Clear();
            txtDuration.Clear();
            txtInstructions.Clear();

            cboPatient.SelectedIndex = -1;

            _consultationId = 0;
            _patientId = 0;

            SetConsultDateNow(); // reset date
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

        private string BuildPrintablePrescription(Patient patient, System.Collections.Generic.IReadOnlyList<Prescription> prescriptions)
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
    }
}
