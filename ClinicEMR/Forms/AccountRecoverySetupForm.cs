using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
    public partial class AccountRecoverySetupForm : Form
    {
        private Control[] _enterNavigationOrder = Array.Empty<Control>();

        public string RecoveryQuestion => txtRecoveryQuestion.Text.Trim();
        public string RecoveryAnswer => txtRecoveryAnswer.Text.Trim();

        public AccountRecoverySetupForm(string fullName, string username)
        {
            InitializeComponent();

            lblHeader.Text = "Account Recovery Setup";
            lblMeta.Text = $"Create a local recovery question for {fullName} ({username}).";

            txtRecoveryQuestion.TextChanged += (_, _) => ClearAllErrors();
            txtRecoveryAnswer.TextChanged += (_, _) => ClearAllErrors();
            txtConfirmRecoveryAnswer.TextChanged += (_, _) => ClearAllErrors();

            _enterNavigationOrder =
            [
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

            var validationErrors = BuildRecoverySetupValidationErrors(
                txtRecoveryQuestion.Text,
                txtRecoveryAnswer.Text);

            if (validationErrors.Any())
            {
                ShowFieldError("lblQuestionError", validationErrors, "Question");
                ShowFieldError("lblAnswerError", validationErrors, "Answer");
                FocusFirstInvalidField(validationErrors);
                return;
            }

            if (!string.Equals(
                txtRecoveryAnswer.Text.Trim(),
                txtConfirmRecoveryAnswer.Text.Trim(),
                StringComparison.Ordinal))
            {
                ShowConfirmAnswerError("Recovery answers do not match.");
                txtConfirmRecoveryAnswer.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllErrors();
            Close();
        }

        private Dictionary<string, List<string>> BuildRecoverySetupValidationErrors(string question, string answer)
        {
            var errors = new Dictionary<string, List<string>>();
            var setupErrors = UserValidationService.ValidateRecoverySetup(question, answer);

            foreach (string error in setupErrors)
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

        private void FocusFirstInvalidField(Dictionary<string, List<string>> errors)
        {
            if (errors.ContainsKey("Question"))
            {
                txtRecoveryQuestion.Focus();
            }
            else if (errors.ContainsKey("Answer"))
            {
                txtRecoveryAnswer.Focus();
            }
            else if (TryGetErrorLabel("lblConfirmAnswerError")?.Visible == true)
            {
                txtConfirmRecoveryAnswer.Focus();
            }
        }

        private void ShowFieldError(string labelName, Dictionary<string, List<string>> errors, string fieldName)
        {
            var label = TryGetErrorLabel(labelName);
            if (label == null)
            {
                return;
            }

            if (errors.TryGetValue(fieldName, out var fieldErrors))
            {
                label.Text = string.Join(Environment.NewLine, fieldErrors);
                label.Visible = true;
                return;
            }

            ClearError(label);
        }

        private void ShowConfirmAnswerError(string message)
        {
            var label = TryGetErrorLabel("lblConfirmAnswerError");
            if (label == null)
            {
                MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            label.Text = message;
            label.Visible = true;
        }

        private void ClearAllErrors()
        {
            ClearError(TryGetErrorLabel("lblQuestionError"));
            ClearError(TryGetErrorLabel("lblAnswerError"));
            ClearError(TryGetErrorLabel("lblConfirmAnswerError"));
        }

        private Label? TryGetErrorLabel(string name)
        {
            var matches = Controls.Find(name, true);
            return matches.OfType<Label>().FirstOrDefault();
        }

        private static void ClearError(Label? label)
        {
            if (label == null)
            {
                return;
            }

            label.Text = string.Empty;
            label.Visible = false;
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
    }
}
