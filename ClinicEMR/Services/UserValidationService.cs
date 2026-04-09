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
            var errors = new List<string>();

            username = username?.Trim() ?? string.Empty;
            fullName = fullName?.Trim() ?? string.Empty;
            role = role?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                errors.Add("Full name is required.");
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                errors.Add("Role is required.");
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                errors.Add("Username is required.");
            }
            else
            {
                if (username.Length < MinUsernameLength || username.Length > MaxUsernameLength)
                {
                    errors.Add($"Username must be {MinUsernameLength}-{MaxUsernameLength} characters long.");
                }

                if (username.Contains(' '))
                {
                    errors.Add("Username must not contain spaces.");
                }

                if (!UsernameRegex().IsMatch(username))
                {
                    errors.Add("Username may only contain letters, numbers, underscores, dots, and hyphens.");
                }
            }

            if (string.IsNullOrEmpty(password))
            {
                errors.Add("Password is required.");
            }
            else
            {
                if (password.Length < MinPasswordLength || password.Length > MaxPasswordLength)
                {
                    errors.Add($"Password must be {MinPasswordLength}-{MaxPasswordLength} characters long.");
                }

                if (!UppercaseRegex().IsMatch(password))
                {
                    errors.Add("Password must include at least one uppercase letter.");
                }

                if (!LowercaseRegex().IsMatch(password))
                {
                    errors.Add("Password must include at least one lowercase letter.");
                }

                if (!DigitRegex().IsMatch(password))
                {
                    errors.Add("Password must include at least one number.");
                }

                if (!SpecialCharacterRegex().IsMatch(password))
                {
                    errors.Add("Password must include at least one special character.");
                }

                if (password.Contains(' '))
                {
                    errors.Add("Password must not contain spaces.");
                }

                if (!string.IsNullOrWhiteSpace(username) &&
                    password.Contains(username, System.StringComparison.OrdinalIgnoreCase))
                {
                    errors.Add("Password must not contain the username.");
                }
            }

            return errors;
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
