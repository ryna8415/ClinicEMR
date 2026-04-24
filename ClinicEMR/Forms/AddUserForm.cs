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
            txtFullName.TextChanged += (_, _) => ClearError(lblFullNameError);
            txtUsername.TextChanged += (_, _) => ClearError(lblUsernameError);
            txtPassword.TextChanged += (_, _) => ClearError(lblPasswordError);
            cboRole.SelectedIndexChanged += (_, _) => ClearError(lblRoleError);
            ThemeService.ApplyTheme(this);
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
            ClearAllErrors();

            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var fullName = txtFullName.Text.Trim();
            var role = cboRole.SelectedItem?.ToString() ?? string.Empty;

            var validationErrors = UserValidationService.ValidateNewUserByField(
                username,
                password,
                fullName,
                role);

            if (validationErrors.Any())
            {
                this.DialogResult = DialogResult.None;
                ShowError(lblFullNameError, validationErrors, "FullName");
                ShowError(lblUsernameError, validationErrors, "Username");
                ShowError(lblPasswordError, validationErrors, "Password");
                ShowError(lblRoleError, validationErrors, "Role");
                FocusFirstInvalidField(validationErrors);
                return;
            }

            try
            {
                UserService.Create(username, password, fullName, role);
                MessageBox.Show("User account created.");
            }
            catch (ArgumentException ex)
            {
                this.DialogResult = DialogResult.None;
                lblPasswordError.Text = ex.Message;
                lblPasswordError.Visible = true;
            }
            catch (InvalidOperationException ex)
            {
                this.DialogResult = DialogResult.None;
                lblUsernameError.Text = ex.Message;
                lblUsernameError.Visible = true;
                txtUsername.Focus();
            }

        }

        private void ClearAllErrors()
        {
            ClearError(lblFullNameError);
            ClearError(lblUsernameError);
            ClearError(lblPasswordError);
            ClearError(lblRoleError);
        }

        private static void ShowError(Label label, Dictionary<string, List<string>> errors, string fieldName)
        {
            if (errors.TryGetValue(fieldName, out var fieldErrors))
            {
                label.Text = string.Join(Environment.NewLine, fieldErrors);
                label.Visible = true;
                return;
            }

            ClearError(label);
        }

        private static void ClearError(Label label)
        {
            label.Text = string.Empty;
            label.Visible = false;
        }

        private void FocusFirstInvalidField(Dictionary<string, List<string>> errors)
        {
            if (errors.ContainsKey("FullName"))
            {
                txtFullName.Focus();
            }
            else if (errors.ContainsKey("Username"))
            {
                txtUsername.Focus();
            }
            else if (errors.ContainsKey("Password"))
            {
                txtPassword.Focus();
            }
            else if (errors.ContainsKey("Role"))
            {
                cboRole.Focus();
            }
        }


    }
}
