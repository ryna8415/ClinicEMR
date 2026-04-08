using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class ConsultationControl : UserControl
    {
        // ── Private state ────────────────────────────────────────────────────
        private int _patientId = 0;
        private int _savedConsultId = 0;

        private readonly User _user;
        private readonly MainShellForm _shell;

        // ── Constructor ──────────────────────────────────────────────────────
        public ConsultationControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;

            // Disable Rx button until a consultation is saved
            btnAddRx.Enabled = false;

            // Hide the results list and patient info panel on startup
            lstResults.Visible = false;
            gbPatientInfo.Visible = false;

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
        }

        // ════════════════════════════════════════════════════════════════════
        // PATIENT SEARCH (Option A — search box inside ConsultationControl)
        // ════════════════════════════════════════════════════════════════════

        // Live search as the doctor types
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(kw))
            {
                lstResults.Visible = false;
                return;
            }

            var results = PatientService.Search(kw);

            // Rebind -- set DataSource to null first to force refresh
            lstResults.DataSource = null;
            lstResults.DataSource = results;
            lstResults.DisplayMember = "DisplayInfo";   // e.g. "Cruz, Ana — PT-00001"
            lstResults.ValueMember = "PatientId";

            lstResults.Visible = results.Count > 0;
            lstResults.Height = Math.Min(results.Count * 20 + 4, 120);
            lstResults.BringToFront();
        }

        // When the doctor clicks a result in the dropdown list
        private void lstResults_Click(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem == null) return;

            var p = lstResults.SelectedItem as Patient;
            if (p == null) return;

            SelectPatient(p.PatientId);

            lstResults.Visible = false;
            txtSearch.Text = "";
        }

        // Hide the dropdown when focus leaves the search box
        // (use BeginInvoke so the click event on lstResults fires first)
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                if (!lstResults.Focused)
                    lstResults.Visible = false;
            }));
        }

        // ════════════════════════════════════════════════════════════════════
        // CORE PATIENT LOADER
        // All three entry points (A, B, C) end up here
        // ════════════════════════════════════════════════════════════════════
        private void SelectPatient(int patientId)
        {
            _patientId = patientId;
            _savedConsultId = 0;           // new session — no saved consult yet

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
            txtChief.Focus();
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
    }
}