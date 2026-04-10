using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ClinicEMR.Services
{
    public static partial class PatientValidationService
    {
        public static List<string> ValidateNewPatient(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string sex,
            string contactNumber,
            string emergencyContact)
        {
            var errorsByField = ValidateNewPatientByField(
                firstName,
                lastName,
                dateOfBirth,
                sex,
                contactNumber,
                emergencyContact);

            var errors = new List<string>();
            foreach (var fieldErrors in errorsByField.Values)
            {
                errors.AddRange(fieldErrors);
            }

            return errors;
        }

        public static Dictionary<string, List<string>> ValidateNewPatientByField(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            string sex,
            string contactNumber,
            string emergencyContact)
        {
            var errors = new Dictionary<string, List<string>>();

            firstName = firstName?.Trim() ?? string.Empty;
            lastName = lastName?.Trim() ?? string.Empty;
            sex = sex?.Trim() ?? string.Empty;
            contactNumber = contactNumber?.Trim() ?? string.Empty;
            emergencyContact = emergencyContact?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(firstName))
            {
                AddError(errors, "FirstName", "First name is required.");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                AddError(errors, "LastName", "Last name is required.");
            }

            if (dateOfBirth.Date > DateTime.Today)
            {
                AddError(errors, "DateOfBirth", "Date of birth cannot be in the future.");
            }

            if (string.IsNullOrWhiteSpace(sex))
            {
                AddError(errors, "Sex", "Sex is required.");
            }

            if (string.IsNullOrWhiteSpace(contactNumber))
            {
                AddError(errors, "ContactNumber", "Contact number is required.");
            }
            else if (!TryNormalizePhilippineContactNumber(contactNumber, out _))
            {
                AddError(errors, "ContactNumber", "Contact number must be a valid Philippine mobile number (09XXXXXXXXX or +639XXXXXXXXX).");
            }

            if (!TryParseEmergencyContact(emergencyContact, out _))
            {
                AddError(errors, "EmergencyContact", "Emergency contact must contain numbers only.");
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

        public static bool TryNormalizePhilippineContactNumber(string contactNumber, out string normalizedContactNumber)
        {
            normalizedContactNumber = string.Empty;

            if (string.IsNullOrWhiteSpace(contactNumber))
            {
                return false;
            }

            var cleanedContactNumber = ContactSeparatorRegex().Replace(contactNumber.Trim(), string.Empty);
            if (!PhilippineMobileNumberRegex().IsMatch(cleanedContactNumber))
            {
                return false;
            }

            normalizedContactNumber = cleanedContactNumber.StartsWith("+63", StringComparison.Ordinal)
                ? $"0{cleanedContactNumber[3..]}"
                : cleanedContactNumber;

            return true;
        }

        public static bool TryParseEmergencyContact(string emergencyContact, out long? parsedEmergencyContact)
        {
            parsedEmergencyContact = null;

            if (string.IsNullOrWhiteSpace(emergencyContact))
            {
                return true;
            }

            var trimmedEmergencyContact = emergencyContact.Trim();
            if (!DigitsOnlyRegex().IsMatch(trimmedEmergencyContact) ||
                !long.TryParse(trimmedEmergencyContact, out var numericEmergencyContact))
            {
                return false;
            }

            parsedEmergencyContact = numericEmergencyContact;
            return true;
        }

        [GeneratedRegex(@"[\s\-\(\)]")]
        private static partial Regex ContactSeparatorRegex();

        [GeneratedRegex(@"^(?:\+63|0)9\d{9}$")]
        private static partial Regex PhilippineMobileNumberRegex();

        [GeneratedRegex(@"^\d+$")]
        private static partial Regex DigitsOnlyRegex();
    }
}
