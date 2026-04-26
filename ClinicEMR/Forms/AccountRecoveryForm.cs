using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
    public partial class AccountRecoveryForm : Form
    {
        private Control[] _enterNavigationOrder = Array.Empty<Control>();

        public AccountRecoveryForm()
        {
            InitializeComponent();
            txtUsername.TextChanged += (_, _) => ClearError(lblError);
            txtRecoveryAnswer.TextChanged += (_, _) => ClearError(lblError);
            txtNewPassword.TextChanged += (_, _) => ClearError(lblPasswordError);
            txtConfirmPassword.TextChanged += (_, _) => ClearError(lblConfirmPasswordError);
            _enterNavigationOrder =
            [
                txtUsername,
                txtRecoveryAnswer,
                txtNewPassword,
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
                btnReset_Click(btnReset, EventArgs.Empty);
                return true;
            }

            _enterNavigationOrder[currentIndex + 1].Focus();
            return true;
        }

        private void btnLoadQuestion_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            lblRecoveryQuestion.Text = string.Empty;

            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Enter your username first.");
                txtUsername.Focus();
                return;
            }

            try
            {
                string question = UserService.GetRecoveryQuestion(username);
                if (string.IsNullOrWhiteSpace(question))
                {
                    ShowError("No active recovery setup was found for that username.");
                    return;
                }

                lblRecoveryQuestion.Text = question;
            }
            catch (Exception ex)
            {
                ShowError($"Unable to load the recovery question right now. {ex.Message}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllErrors();

            if (string.IsNullOrWhiteSpace(lblRecoveryQuestion.Text))
            {
                ShowError("Load the recovery question first.");
                return;
            }

            string username = txtUsername.Text.Trim();
            if (string.IsNullOrWhiteSpace(username))
            {
                ShowError("Enter your username first.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRecoveryAnswer.Text))
            {
                ShowError("Enter the recovery answer.");
                txtRecoveryAnswer.Focus();
                return;
            }

            var validationErrors = BuildRecoveryValidationErrors(username, txtNewPassword.Text);

            if (validationErrors.Any())
            {
                ShowError(lblPasswordError, validationErrors, "Password");
                FocusFirstInvalidField(validationErrors);
                return;
            }

            if (!string.Equals(txtNewPassword.Text, txtConfirmPassword.Text, StringComparison.Ordinal))
            {
                lblConfirmPasswordError.Text = "Passwords do not match.";
                lblConfirmPasswordError.Visible = true;
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                UserService.ResetPasswordWithRecovery(
                    username,
                    txtRecoveryAnswer.Text,
                    txtNewPassword.Text);

                MessageBox.Show("Password reset successfully.",
                    "Recovery Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                ShowError(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError($"Unable to reset the password right now. {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            Close();
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        private void ClearAllErrors()
        {
            ClearError(lblError);
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

        private static Dictionary<string, List<string>> BuildRecoveryValidationErrors(string username, string password)
        {
            var errors = new Dictionary<string, List<string>>();
            var passwordErrors = UserValidationService.ValidatePassword(password, username);

            if (passwordErrors.Any())
            {
                errors["Password"] = passwordErrors;
            }

            return errors;
        }

        private void FocusFirstInvalidField(Dictionary<string, List<string>> errors)
        {
            if (errors.ContainsKey("Password"))
            {
                txtNewPassword.Focus();
            }
            else if (lblConfirmPasswordError.Visible)
            {
                txtConfirmPassword.Focus();
            }
        }
    }
}
