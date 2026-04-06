using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class ConsultationControl : UserControl
    {
        private int _patientId = 0;
        private int _savedConsultId = 0;
        private readonly User _user;
        private readonly MainShellForm _shell;


        public ConsultationControl(User user, MainShellForm shell)
        {
            InitializeComponent(); _user = user; _shell = shell;
            btnAddRx.Enabled = false;
            // Lock yesterday's records silently on first load
            ConsultService.LockPastConsultations(_user.UserId);
            lstResults.Visible = false;
            gbPatientInfo.Visible = false;


        }

        // Called by shell NavigateTo() or patient list
        public void LoadPatient(int patientId)
        {
            SelectPatient(patientId);
        }

        private void btnSave_Click(object s, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChief.Text))
            {
                MessageBox.Show("Chief complaint is required."); return;
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
            btnSave.Enabled = false;
            btnAddRx.Enabled = true;
            MessageBox.Show("Consultation saved. You can now add prescriptions.");
        }

        private void btnAddRx_Click(object s, EventArgs e)
        {
            _shell.NavigateTo("prescription", _savedConsultId);
        }

        private void ClearForm()
        {
            txtChief.Clear(); txtFindings.Clear();
            txtDiagnosis.Clear(); txtNotes.Clear();
            lblAllergy.Visible = false;
            lblVitals.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(kw))
            {
                lstResults.Visible = false;
                return;
            }

            var results = PatientService.Search(kw);

            lstResults.DataSource = null;
            lstResults.DataSource = results;

            lstResults.DisplayMember = "DisplayInfo";
            lstResults.ValueMember = "PatientId";

            lstResults.Visible = true;
            lstResults.Height = 94;
            lstResults.BringToFront();
        }

        private void SelectPatient(int patientId)
        {
            _patientId = patientId;
            _savedConsultId = 0;
            btnSave.Enabled = true;
            btnAddRx.Enabled = false;
            ClearForm();

            var p = PatientService.GetById(patientId);
            if (p == null) return;

            lblPatientName.Text = p.FullName;
            int age = DateTime.Today.Year - p.DateOfBirth.Year;
            lblMeta.Text = $"{p.PatientCode}  |  {age} y/o  {p.Sex}";

            if (!string.IsNullOrWhiteSpace(p.KnownAllergies))
            {
                lblAllergy.Text = "⚠ ALLERGY: " + p.KnownAllergies;
                lblAllergy.Visible = true;
                lblAllergy.BackColor = System.Drawing.Color.FromArgb(153, 27, 27);
                lblAllergy.ForeColor = System.Drawing.Color.White;
            }


            var vitals = VitalsService.GetByPatient(patientId);
            lblVitals.Text = vitals.Count > 0
                ? $"BP: {vitals[0].BloodPressure}  HR: {vitals[0].HeartRate}  Temp: {vitals[0].Temperature}\u00b0C  BMI: {vitals[0].Bmi}"
                : "No vitals recorded yet";

            gbPatientInfo.Visible = true;
            txtChief.Focus();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                if (!lstResults.Focused)
                    lstResults.Visible = false;
            }));
        }

        private void lstResults_Click(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem == null) return;

            var p = (Patient)lstResults.SelectedItem;

            SelectPatient(p.PatientId);

            lstResults.Visible = false;

            txtSearch.Text = "";
        }
    }
}
