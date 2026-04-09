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
    public partial class VitalsControl : UserControl
    {
        private int _selectedPatientId = 0;
        private readonly User _user;
        private bool _isLoadingPatients = false;


        public VitalsControl(User user, MainShellForm shell)
        {
            InitializeComponent(); 
            _user = user;

            LoadPatients();

        }

        // Called from outside (e.g. patient list 'Take Vitals' button)
        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            _selectedPatientId = patientId;
            var p = PatientService.GetById(patientId);
            lblPatientName.Text = p?.FullName ?? "Unknown";
            LoadHistory();
        }

        private void CalculateBmi()
        {
            decimal h = nudHeight.Value / 100m;
            decimal w = nudWeight.Value;

            if (h > 0 && w > 0)
            {
                decimal bmi = w / (h * h);
                lblBmi.Text = bmi.ToString("F1");
            }
            else
            {
                lblBmi.Text = "";
            }
        }

        private void nudHeight_ValueChanged(object s, EventArgs e) => CalculateBmi();
        private void nudWeight_ValueChanged(object s, EventArgs e) => CalculateBmi();

        private void btnSave_Click(object s, EventArgs e)
        {
            if (cmbPatients.SelectedIndex == -1)
            {
                MessageBox.Show("Search and select a patient first.");
                return;
            }

            bool hasCoreVitals =
                (!string.IsNullOrWhiteSpace(txtBP.Text) && txtBP.Text.Contains("/")) ||
                nudHR.Value > 0 ||
                nudTemp.Value > 0;

            if (!hasCoreVitals)
            {
                MessageBox.Show("Please enter at least one valid vital sign before saving.");
                return;
            }

            bool hasHeightWeight =
                nudHeight.Value > 0 &&
                nudWeight.Value > 0;

            decimal bmi = 0;

            if ((nudHeight.Value > 0 && nudWeight.Value == 0) ||
                (nudHeight.Value == 0 && nudWeight.Value > 0))
            {
                MessageBox.Show("Please enter BOTH height and weight for BMI.");
                return;
            }
            if (hasHeightWeight)
            {
                decimal h = nudHeight.Value / 100m; // cm → meters
                bmi = nudWeight.Value / (h * h);
                bmi = Math.Round(bmi, 1);
                lblBmi.Text = bmi.ToString("F1");
            }
            else
            {
                bmi = 0; // or null if you change DB later
            }

            int patientId = (int)cmbPatients.SelectedValue;


            var v = new VitalSigns
            {
                PatientId = patientId,
                RecordedBy = _user.UserId,
                BloodPressure = txtBP.Text.Trim(),
                HeartRate = (int)nudHR.Value,
                Temperature = nudTemp.Value,
                HeightCm = nudHeight.Value,
                WeightKg = nudWeight.Value,
                Bmi = Math.Round(bmi, 1)
            };

            VitalsService.Record(v);

            MessageBox.Show("Vitals saved!");
            LoadHistory();
            dgvHistory.Refresh();
        }
        private void LoadHistory()
        {
            if (cmbPatients.SelectedIndex == -1)
            {
                dgvHistory.DataSource = null;
                return;
            }

            int patientId = (int)cmbPatients.SelectedValue;

            dgvHistory.DataSource = VitalsService.GetByPatient(patientId);
            dgvHistory.AutoGenerateColumns = false;

            dgvHistory.Columns["VitalId"].Visible = false;
            dgvHistory.Columns["PatientId"].Visible = false;
            dgvHistory.Columns["RecordedBy"].Visible = false;

            dgvHistory.Columns["PatientName"].HeaderText = "Patient";
            dgvHistory.Columns["RecordedByName"].HeaderText = "Recorded By";
            dgvHistory.Columns["RecordedAt"].HeaderText = "Date";
        }

        private void LoadPatients()
        {
            LoadPatients(_selectedPatientId);
        }

        public void RefreshPatients(int? selectedPatientId = null)
        {
            LoadPatients(selectedPatientId ?? _selectedPatientId);
        }

        private void LoadPatients(int? selectedPatientId)
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


        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingPatients) return;
            if (cmbPatients.SelectedIndex == -1) return;

            var selected = (Patient)cmbPatients.SelectedItem;
            _selectedPatientId = selected.PatientId;

            lblPatientName.Text = selected.FullName;

            LoadHistory();
        }
    }

}
