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
            GridViewService.MakeReadOnly(dgvPatients);
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
            GridViewService.ShowOnly(dgvPatients, "PatientId", "PatientCode", "FullName", "Sex", "DateOfBirth", "ContactNumber");
            GridViewService.SetHeaders(dgvPatients, new Dictionary<string, string>
            {
                ["PatientCode"] = "Patient ID",
                ["FullName"] = "Name",
                ["Sex"] = "Sex",
                ["DateOfBirth"] = "Date of Birth",
                ["ContactNumber"] = "Contact No."
            });

            if (dgvPatients.Columns["PatientId"] != null)
                dgvPatients.Columns["PatientId"].Visible = false;

            if (dgvPatients.Columns["PatientCode"] != null)
                dgvPatients.Columns["PatientCode"].DisplayIndex = 0;
            if (dgvPatients.Columns["FullName"] != null)
                dgvPatients.Columns["FullName"].DisplayIndex = 1;
            if (dgvPatients.Columns["Sex"] != null)
                dgvPatients.Columns["Sex"].DisplayIndex = 2;
            if (dgvPatients.Columns["DateOfBirth"] != null)
            {
                dgvPatients.Columns["DateOfBirth"].DisplayIndex = 3;
                dgvPatients.Columns["DateOfBirth"].DefaultCellStyle.Format = "MMM dd, yyyy";
            }
            if (dgvPatients.Columns["ContactNumber"] != null)
                dgvPatients.Columns["ContactNumber"].DisplayIndex = 4;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string kw = txtSearch.Text.ToLower().Trim();
            dgvPatients.DataSource = string.IsNullOrEmpty(kw)
              ? PatientService.GetAll()
              : PatientService.Search(kw);
            FormatGrid();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var form = new AddPatientForm();
            if (form.ShowDialog() == DialogResult.OK)
                _shell.RefreshPatientViews();
        }

        private void btnOpenRecord_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a patient first.");
                return;
            }
            int pid = (int)dgvPatients.SelectedRows[0].Cells["PatientId"].Value;
            _shell.NavigateTo("patientrecord", pid);
        }
    }
}
