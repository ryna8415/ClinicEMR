using System;
using System.Collections.Generic;
using ClinicEMR.Models;
using MySql.Data.MySqlClient;

namespace ClinicEMR.Services
{
    public class PatientService
    {

        public static List<Patient> GetAll()
        {
            var list = new List<Patient>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;
                var cmd = new MySqlCommand(
                  "SELECT * FROM patients WHERE is_active=1 ORDER BY last_name", conn);
                var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapRow(r));
            }
            return list;
        }

        public static List<Patient> Search(string keyword)
        {
            var list = new List<Patient>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;
                var cmd = new MySqlCommand(
                  "SELECT * FROM patients WHERE is_active=1 AND " +
                  "(first_name LIKE @k OR last_name LIKE @k OR patient_code LIKE @k)", conn);
                cmd.Parameters.AddWithValue("@k", "%" + keyword + "%");
                var r = cmd.ExecuteReader();
                while (r.Read()) list.Add(MapRow(r));
            }
            return list;
        }

        public static Patient GetById(int id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return null;
                var cmd = new MySqlCommand(
                  "SELECT * FROM patients WHERE patient_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                var r = cmd.ExecuteReader();
                if (r.Read()) return MapRow(r);
            }
            return null;
        }

        public static void Add(Patient p)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;
                var cmd = new MySqlCommand(
                  "INSERT INTO patients (patient_code,first_name,last_name,date_of_birth," +
                  "sex,contact_number,address,emergency_contact,known_allergies) " +
                  "VALUES (@code,@fn,@ln,@dob,@sex,@cn,@addr,@ec,@al)", conn);
                cmd.Parameters.AddWithValue("@code", GenerateCode());
                cmd.Parameters.AddWithValue("@fn", p.FirstName);
                cmd.Parameters.AddWithValue("@ln", p.LastName);
                cmd.Parameters.AddWithValue("@dob", p.DateOfBirth);
                cmd.Parameters.AddWithValue("@sex", p.Sex ?? "");
                cmd.Parameters.AddWithValue("@cn", p.ContactNumber ?? "");
                cmd.Parameters.AddWithValue("@addr", p.Address ?? "");
                cmd.Parameters.AddWithValue("@ec", p.EmergencyContact ?? "");
                cmd.Parameters.AddWithValue("@al", p.KnownAllergies ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateHistory(Patient p)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null || p == null || p.PatientId <= 0) return;

                var cmd = new MySqlCommand(
                  "UPDATE patients SET " +
                  "known_allergies=@allergies, " +
                  "chronic_conditions=@conditions, " +
                  "past_surgeries=@surgeries, " +
                  "family_history=@familyHistory, " +
                  "current_medications=@currentMeds " +
                  "WHERE patient_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", p.PatientId);
                cmd.Parameters.AddWithValue("@allergies", p.KnownAllergies ?? "");
                cmd.Parameters.AddWithValue("@conditions", p.ChronicConditions ?? "");
                cmd.Parameters.AddWithValue("@surgeries", p.PastSurgeries ?? "");
                cmd.Parameters.AddWithValue("@familyHistory", p.FamilyHistory ?? "");
                cmd.Parameters.AddWithValue("@currentMeds", p.CurrentMedications ?? "");
                cmd.ExecuteNonQuery();
            }
        }

        private static string GenerateCode()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return "PT-00001";
                var cmd = new MySqlCommand(
                  "SELECT COUNT(*)+1 FROM patients", conn);
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return $"PT-{n:D5}";
            }
        }

        private static Patient MapRow(MySqlDataReader r) => new Patient
        {
            PatientId = (int)r["patient_id"],
            PatientCode = r["patient_code"].ToString(),
            FirstName = r["first_name"].ToString(),
            LastName = r["last_name"].ToString(),
            DateOfBirth = (DateTime)r["date_of_birth"],
            Sex = r["sex"].ToString(),
            ContactNumber = r["contact_number"].ToString(),
            Address = r["address"].ToString(),
            EmergencyContact = r["emergency_contact"].ToString(),
            KnownAllergies = r["known_allergies"].ToString(),
            ChronicConditions = HasColumn(r, "chronic_conditions") ? r["chronic_conditions"]?.ToString() : "",
            PastSurgeries = HasColumn(r, "past_surgeries") ? r["past_surgeries"]?.ToString() : "",
            FamilyHistory = HasColumn(r, "family_history") ? r["family_history"]?.ToString() : "",
            CurrentMedications = HasColumn(r, "current_medications") ? r["current_medications"]?.ToString() : "",
            IsActive = Convert.ToBoolean(r["is_active"])
        };

        private static bool HasColumn(MySqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (string.Equals(reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

    }
}
