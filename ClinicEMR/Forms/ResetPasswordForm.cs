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
    public partial class ResetPasswordForm : Form
    {
        private readonly string _username;
        private Control[] _enterNavigationOrder = Array.Empty<Control>();

        public string NewPassword => txtPassword.Text.Trim();

        public ResetPasswordForm(string fullName, string username)
        {
            InitializeComponent();
            _username = username;

            txtFullName.Text = fullName;
            txtFullName.Cursor = Cursors.Default;
            btnHeader.Text = "Reset Password";
            Text = "Reset Password";
            StartPosition = FormStartPosition.CenterParent;
            btnSave.Text = "Save";

            txtPassword.TextChanged += (_, _) => ClearError(lblPasswordError);
            txtConfirmPassword.TextChanged += (_, _) => ClearError(lblConfirmPasswordError);

            _enterNavigationOrder =
            [
                txtPassword,
                txtConfirmPassword
            ];
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData != Keys.Enter)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            var activeInput = _enterNavigationOrder.FirstOrDefault(control => control.Focused || control.ContainsFocus);
            if (activeInput == null)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            int currentIndex = Array.IndexOf(_enterNavigationOrder, activeInput);
            if (currentIndex < 0)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            if (currentIndex == _enterNavigationOrder.Length - 1)
            {
                btnSave_Click(btnSave, EventArgs.Empty);
                return true;
            }

            _enterNavigationOrder[currentIndex + 1].Focus();
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearAllErrors();

            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            var validationErrors = UserValidationService.ValidateNewUserByField(
                _username,
                password,
                txtFullName.Text.Trim(),
                "doctor");

            validationErrors.Remove("Username");
            validationErrors.Remove("FullName");
            validationErrors.Remove("Role");

            if (validationErrors.Any())
            {
                DialogResult = DialogResult.None;
                ShowError(lblPasswordError, validationErrors, "Password");
                FocusFirstInvalidField(validationErrors);
                return;
            }

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                DialogResult = DialogResult.None;
                lblConfirmPasswordError.Text = "Passwords do not match.";
                lblConfirmPasswordError.Visible = true;
                txtConfirmPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ClearAllErrors()
        {
            ClearError(lblPasswordError);
            ClearError(lblConfirmPasswordError);
        }

        private static void ShowError(Label label, Dictionary<string, List<string>> errors, string fieldName)
        {
            if (errors.TryGetValue(fieldName, out var fieldErrors))
            {
                label.Text = fieldName == "Password"
                    ? "Use 12-64 chars with 1 uppercase, 1 lowercase, 1 number, and 1 special. No spaces and don't use your username."
                    : string.Join(", ", fieldErrors);
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
            if (errors.ContainsKey("Password"))
            {
                txtPassword.Focus();
            }
            else if (lblConfirmPasswordError.Visible)
            {
                txtConfirmPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            Close();
        }
    }
}
