using ClinicEMR.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;

namespace ClinicEMR.UserControls
{
    public partial class PatientListControl : UserControl
    {
        private readonly User _user;
        private readonly MainShellForm _shell;

        public PatientListControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;
        }

        private void PatientListControl_Load(object sender, EventArgs e)
          => LoadPatients();

        public void LoadPatients()
        {
            dgvPatients.DataSource = PatientService.GetAll();
            FormatGrid();
        }

        private void FormatGrid()
        {
            string[] hide = { "PatientId", "IsActive", "Address", "EmergencyContact" };
            foreach (var col in hide)
                if (dgvPatients.Columns[col] != null)
                    dgvPatients.Columns[col].Visible = false;
            if (dgvPatients.Columns["PatientCode"] != null)
                dgvPatients.Columns["PatientCode"].HeaderText = "ID";
            if (dgvPatients.Columns["FullName"] != null)
                dgvPatients.Columns["FullName"].HeaderText = "Name";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.ToLower().Trim();
            dgvPatients.DataSource = string.IsNullOrEmpty(kw)
              ? PatientService.GetAll()
              : PatientService.Search(kw);
            FormatGrid();
        }

        // Opens AddPatientForm as a DIALOG (small popup, not a new shell window)
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var form = new AddPatientForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadPatients(); // refresh after adding
        }

        // In Week 2/3 this navigates to the patient record inside the shell
        private void btnOpenRecord_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a patient first.");
                return;
            }
            int pid = (int)dgvPatients.SelectedRows[0].Cells["PatientId"].Value;
            // Week 3: _shell.NavigateTo("patientrecord", pid);
            MessageBox.Show($"Patient ID {pid} selected. Patient Record view builds in Week 3.");
        }
    }


}
