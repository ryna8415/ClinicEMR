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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cboRole.SelectedIndex < 0)
            {
                MessageBox.Show("All fields are required.");
                this.DialogResult = DialogResult.None;
                return;
            }
            UserService.Create(
              txtUsername.Text.Trim(),
              txtPassword.Text,
              txtFullName.Text.Trim(),
              cboRole.SelectedItem.ToString()
            );
            MessageBox.Show("User account created.");

        }
    }
}
