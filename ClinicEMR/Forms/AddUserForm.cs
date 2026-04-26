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
        private Control[] _enterNavigationOrder = Array.Empty<Control>();
        private readonly int? _actorUserId;
        private bool _isSaving;

        public AddUserForm(int? actorUserId = null)
        {
            InitializeComponent();
            _actorUserId = actorUserId;
            txtUsername.KeyPress += txtUsername_KeyPress;
            txtFullName.TextChanged += (_, _) => ClearError(lblFullNameError);
            txtUsername.TextChanged += (_, _) => ClearError(lblUsernameError);
            txtPassword.TextChanged += (_, _) => ClearError(lblPasswordError);
            txtConfirmPassword.TextChanged += (_, _) => ClearError(lblConfirmPasswordError);
            cboRole.SelectedIndexChanged += (_, _) => ClearError(lblRoleError);
            txtRecoveryQuestion.TextChanged += (_, _) => ClearRecoveryErrors();
            txtRecoveryAnswer.TextChanged += (_, _) => ClearRecoveryErrors();
            txtConfirmRecoveryAnswer.TextChanged += (_, _) => ClearRecoveryErrors();
            _enterNavigationOrder =
            [
                txtFullName,
                txtUsername,
                cboRole,
                txtPassword,
                txtConfirmPassword,
                txtRecoveryQuestion,
                txtRecoveryAnswer,
                txtConfirmRecoveryAnswer
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

            var currentIndex = Array.IndexOf(_enterNavigationOrder, activeInput);
            if (currentIndex < 0)
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

            if (activeInput == cboRole && cboRole.DroppedDown)
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

        private void AddUserForm_KeyDown(object? sender, KeyEventArgs e)
        {
        }

        private void txtUsername_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isSaving)
            {
                return;
            }

            ClearAllErrors();

            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var confirmPassword = txtConfirmPassword.Text;
            var fullName = txtFullName.Text.Trim();
            var role = cboRole.SelectedItem?.ToString() ?? string.Empty;
            var recoveryQuestion = txtRecoveryQuestion.Text.Trim();
            var recoveryAnswer = txtRecoveryAnswer.Text.Trim();
            var confirmRecoveryAnswer = txtConfirmRecoveryAnswer.Text.Trim();

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

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                this.DialogResult = DialogResult.None;
                lblConfirmPasswordError.Text = "Passwords do not match.";
                lblConfirmPasswordError.Visible = true;
                txtConfirmPassword.Focus();
                return;
            }

            var recoveryValidationErrors = BuildRecoveryValidationErrors(
                recoveryQuestion,
                recoveryAnswer,
                username);

            if (recoveryValidationErrors.Any())
            {
                this.DialogResult = DialogResult.None;
                ShowRecoveryError(lblQuestionError, recoveryValidationErrors, "Question");
                ShowRecoveryError(lblAnswerError, recoveryValidationErrors, "Answer");
                FocusFirstInvalidField(recoveryValidationErrors);
                return;
            }

            if (!string.Equals(recoveryAnswer, confirmRecoveryAnswer, StringComparison.Ordinal))
            {
                this.DialogResult = DialogResult.None;
                lblConfirmAnswerError.Text = "Recovery answers do not match.";
                lblConfirmAnswerError.Visible = true;
                txtConfirmRecoveryAnswer.Focus();
                return;
            }

            try
            {
                _isSaving = true;
                UserService.Create(username, password, fullName, role, recoveryQuestion, recoveryAnswer, _actorUserId);
                MessageBox.Show("User account created.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                this.DialogResult = DialogResult.None;
                if (ex.Message.Contains("Recovery ", StringComparison.OrdinalIgnoreCase))
                {
                    var serviceRecoveryErrors = BuildRecoveryValidationErrors(recoveryQuestion, recoveryAnswer, username);
                    if (serviceRecoveryErrors.Any())
                    {
                        ShowRecoveryError(lblQuestionError, serviceRecoveryErrors, "Question");
                        ShowRecoveryError(lblAnswerError, serviceRecoveryErrors, "Answer");
                    }
                    else
                    {
                        lblAnswerError.Text = ex.Message;
                        lblAnswerError.Visible = true;
                    }
                }
                else
                {
                    lblPasswordError.Text = ex.Message;
                    lblPasswordError.Visible = true;
                }
            }
            catch (InvalidOperationException ex)
            {
                this.DialogResult = DialogResult.None;
                lblUsernameError.Text = ex.Message;
                lblUsernameError.Visible = true;
                txtUsername.Focus();
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show($"Unable to create the user right now.\n{ex.Message}", "User Account",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isSaving = false;
            }
        }

        private void ClearAllErrors()
        {
            ClearError(lblFullNameError);
            ClearError(lblUsernameError);
            ClearError(lblPasswordError);
            ClearError(lblConfirmPasswordError);
            ClearError(lblRoleError);
            ClearRecoveryErrors();
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

        private void ClearRecoveryErrors()
        {
            ClearError(lblQuestionError);
            ClearError(lblAnswerError);
            ClearError(lblConfirmAnswerError);
        }

        private static void ShowRecoveryError(Label label, Dictionary<string, List<string>> errors, string fieldName)
        {
            if (errors.TryGetValue(fieldName, out var fieldErrors))
            {
                label.Text = string.Join(Environment.NewLine, fieldErrors);
                label.Visible = true;
                return;
            }

            ClearError(label);
        }

        private static Dictionary<string, List<string>> BuildRecoveryValidationErrors(string question, string answer, string username)
        {
            var errors = new Dictionary<string, List<string>>();
            var recoveryErrors = UserValidationService.ValidateRecoverySetup(question, answer, username);

            foreach (string error in recoveryErrors)
            {
                if (error.StartsWith("Recovery question", StringComparison.OrdinalIgnoreCase))
                {
                    AddError(errors, "Question", error);
                }
                else
                {
                    AddError(errors, "Answer", error);
                }
            }

            return errors;
        }

        private static void AddError(Dictionary<string, List<string>> errors, string fieldName, string message)
        {
            if (!errors.TryGetValue(fieldName, out var fieldErrors))
            {
                fieldErrors = new List<string>();
                errors[fieldName] = fieldErrors;
            }

            fieldErrors.Add(message);
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
            else if (lblConfirmPasswordError.Visible)
            {
                txtConfirmPassword.Focus();
            }
            else if (errors.ContainsKey("Role"))
            {
                cboRole.Focus();
            }
            else if (errors.ContainsKey("Question"))
            {
                txtRecoveryQuestion.Focus();
            }
            else if (errors.ContainsKey("Answer"))
            {
                txtRecoveryAnswer.Focus();
            }
            else if (lblConfirmAnswerError.Visible)
            {
                txtConfirmRecoveryAnswer.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            Close();
        }
    }
}
