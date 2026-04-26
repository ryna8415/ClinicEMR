using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClinicEMR.Services
{
    public static partial class UserValidationService
    {
        private const int MinUsernameLength = 4;
        private const int MaxUsernameLength = 30;
        private const int MinPasswordLength = 12;
        private const int MaxPasswordLength = 64;

        public static List<string> ValidateNewUser(string username, string password, string fullName, string role)
        {
            var errorsByField = ValidateNewUserByField(username, password, fullName, role);
            var errors = new List<string>();

            foreach (var fieldErrors in errorsByField.Values)
            {
                errors.AddRange(fieldErrors);
            }

            return errors;
        }

        public static Dictionary<string, List<string>> ValidateNewUserByField(string username, string password, string fullName, string role)
        {
            var errors = new Dictionary<string, List<string>>();

            username = username?.Trim() ?? string.Empty;
            fullName = fullName?.Trim() ?? string.Empty;
            role = role?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                AddError(errors, "FullName", "Full name is required.");
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                AddError(errors, "Role", "Role is required.");
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                AddError(errors, "Username", "Username is required.");
            }
            else
            {
                if (username.Length < MinUsernameLength || username.Length > MaxUsernameLength)
                {
                    AddError(errors, "Username", $"Username must be {MinUsernameLength}-{MaxUsernameLength} characters long.");
                }

                if (username.Contains(' '))
                {
                    AddError(errors, "Username", "Username must not contain spaces.");
                }

                if (!UsernameRegex().IsMatch(username))
                {
                    AddError(errors, "Username", "Username may only contain letters, numbers, underscores, dots, and hyphens.");
                }
            }

            if (string.IsNullOrEmpty(password))
            {
                AddError(errors, "Password", "Password is required.");
            }
            else
            {
                AddPasswordErrors(errors, password, username);
            }

            return errors;
        }

        public static List<string> ValidatePassword(string password, string username = "")
        {
            var errors = new Dictionary<string, List<string>>();
            AddPasswordErrors(errors, password, username);

            return errors.TryGetValue("Password", out var passwordErrors)
                ? passwordErrors
                : new List<string>();
        }

        public static List<string> ValidateRecoverySetup(string question, string answer, string username = "")
        {
            var errors = new List<string>();

            question = question?.Trim() ?? string.Empty;
            answer = answer?.Trim() ?? string.Empty;

            if (question.Length < 8 || question.Length > 120)
            {
                errors.Add("Recovery question must be 8-120 characters long.");
            }

            if (answer.Length < 6 || answer.Length > 120)
            {
                errors.Add("Recovery answer must be 6-120 characters long.");
            }

            if (answer.Contains(' '))
            {
                errors.Add("Recovery answer must not contain spaces.");
            }

            if (!string.IsNullOrWhiteSpace(username) &&
                answer.Contains(username, System.StringComparison.OrdinalIgnoreCase))
            {
                errors.Add("Recovery answer must not contain the username.");
            }

            return errors;
        }

        private static void AddPasswordErrors(Dictionary<string, List<string>> errors, string password, string username)
        {
            if (password.Length < MinPasswordLength || password.Length > MaxPasswordLength)
            {
                AddError(errors, "Password", $"{MinPasswordLength}-{MaxPasswordLength} characters required.");
            }

            if (!UppercaseRegex().IsMatch(password))
            {
                AddError(errors, "Password", "Add 1 uppercase letter.");
            }

            if (!LowercaseRegex().IsMatch(password))
            {
                AddError(errors, "Password", "Add 1 lowercase letter.");
            }

            if (!DigitRegex().IsMatch(password))
            {
                AddError(errors, "Password", "Add 1 number.");
            }

            if (!SpecialCharacterRegex().IsMatch(password))
            {
                AddError(errors, "Password", "Add 1 special character.");
            }

            if (password.Contains(' '))
            {
                AddError(errors, "Password", "No spaces allowed.");
            }

            if (!string.IsNullOrWhiteSpace(username) &&
                password.Contains(username, System.StringComparison.OrdinalIgnoreCase))
            {
                AddError(errors, "Password", "Must not contain the username.");
            }
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

        [GeneratedRegex("^[A-Za-z0-9._-]+$")]
        private static partial Regex UsernameRegex();

        [GeneratedRegex("[A-Z]")]
        private static partial Regex UppercaseRegex();

        [GeneratedRegex("[a-z]")]
        private static partial Regex LowercaseRegex();

        [GeneratedRegex("[0-9]")]
        private static partial Regex DigitRegex();

        [GeneratedRegex("[^A-Za-z0-9]")]
        private static partial Regex SpecialCharacterRegex();
    }
}
