using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("First name and last name are required.");
                return;
            }
            var p = new Patient
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                DateOfBirth = dtpDOB.Value,
                Sex = cboSex.SelectedItem?.ToString(),
                ContactNumber = txtContact.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                EmergencyContact = txtEmergency.Text.Trim(),
                KnownAllergies = txtAllergies.Text.Trim()
            };
            PatientService.Add(p);
            MessageBox.Show("Patient registered successfully!");
            DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
