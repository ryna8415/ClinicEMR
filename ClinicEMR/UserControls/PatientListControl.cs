using ClinicEMR.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using ClinicEMR.Helpers;

namespace ClinicEMR.UserControls
{
    public partial class PatientListControl : UserControl
    {
        private readonly MainShellForm _shell;

        public PatientListControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _shell = shell;
            GridViewService.MakeReadOnly(dgvPatients);
            ThemeService.ApplyRoundedCorners(tblLayout, 10);
            ThemeService.TryRoundGrid(dgvPatients, 4);
        }

        private void PatientListControl_Load(object sender, EventArgs e)
          => LoadPatients();

        public void LoadPatients()
        {
            try
            {
                dgvPatients.DataSource = PatientService.GetAll();
                FormatGrid();
            }
            catch (Exception ex)
            {
                dgvPatients.DataSource = null;
                MessageBox.Show(ex.Message, "Patients", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ApplySearch()
        {
            try
            {
                var keyword = txtSearch.Text.Trim();
                dgvPatients.DataSource = string.IsNullOrWhiteSpace(keyword)
                    ? PatientService.GetAll()
                    : PatientService.Search(keyword);
                FormatGrid();
                GridViewService.ClearSelection(dgvPatients);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Patient Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            ApplySearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                ApplySearch();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            e.Handled = true;
            ApplySearch();
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
