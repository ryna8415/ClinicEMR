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
    public partial class MedHistoryControl : UserControl
    {
        private int _patientId = 0;
        private bool _isLoadingPatients = false;

        public MedHistoryControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            LoadPatients();
        }

        public void LoadPatient(int patientId)
        {
            _patientId = patientId;
            var p = PatientService.GetById(patientId);
            if (p == null) return;

            SelectPatient(patientId);
            lblPatientName.Text = p.FullName;
            txtAllergies.Text = p.KnownAllergies;
            txtConditions.Text = p.ChronicConditions;
            txtSurgeries.Text = p.PastSurgeries;
            txtFamilyHx.Text = p.FamilyHistory;
            txtCurrentMeds.Text = p.CurrentMedications;
        }

        private void LoadPatients()
        {
            _isLoadingPatients = true;

            var patients = PatientService.GetAll();
            cboPatient.DataSource = null;
            cboPatient.DataSource = patients;
            cboPatient.DisplayMember = "FullName";
            cboPatient.ValueMember = "PatientId";
            cboPatient.SelectedIndex = -1;

            _isLoadingPatients = false;
        }

        private void SelectPatient(int patientId)
        {
            for (int i = 0; i < cboPatient.Items.Count; i++)
            {
                if (cboPatient.Items[i] is Patient patient && patient.PatientId == patientId)
                {
                    cboPatient.SelectedIndex = i;
                    return;
                }
            }
        }

        private void cboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingPatients || cboPatient.SelectedIndex == -1) return;
            if (cboPatient.SelectedItem is not Patient selectedPatient) return;

            LoadPatient(selectedPatient.PatientId);
        }

        private void btnSave_Click(object s, EventArgs e)
        {
            if (_patientId <= 0)
            {
                MessageBox.Show("Please select a patient first.");
                cboPatient.Focus();
                return;
            }

            var p = new Patient
            {
                PatientId = _patientId,
                KnownAllergies = txtAllergies.Text.Trim(),
                ChronicConditions = txtConditions.Text.Trim(),
                PastSurgeries = txtSurgeries.Text.Trim(),
                FamilyHistory = txtFamilyHx.Text.Trim(),
                CurrentMedications = txtCurrentMeds.Text.Trim()
            };
            PatientService.UpdateHistory(p);
            MessageBox.Show("Medical history saved.");
        }
    }

}
