using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUsername.MaxLength = 30;
            txtPassword.MaxLength = 64;
            txtFullName.MaxLength = 100;
            txtUsername.KeyPress += txtUsername_KeyPress;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var fullName = txtFullName.Text.Trim();
            var role = cboRole.SelectedItem?.ToString() ?? string.Empty;

            var validationErrors = UserValidationService.ValidateNewUser(
                username,
                password,
                fullName,
                role);

            if (validationErrors.Any())
            {
                MessageBox.Show(string.Join("\n", validationErrors), "Invalid account details");
                this.DialogResult = DialogResult.None;
                return;
            }

            try
            {
                UserService.Create(username, password, fullName, role);
                MessageBox.Show("User account created.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid account details");
                this.DialogResult = DialogResult.None;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Cannot create user");
                this.DialogResult = DialogResult.None;
            }

        }
    }
}
