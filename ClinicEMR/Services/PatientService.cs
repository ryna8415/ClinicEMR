using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Services
{
    internal class PatientService
    {
        public static List<Patient> GetAll()
        {
            var list = new List<Patient>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new MySqlCommand(
                  "SELECT * FROM patients WHERE is_active=1 ORDER BY last_name", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Patient
                    {
                        PatientId = (int)reader["patient_id"],
                        PatientCode = reader["patient_code"].ToString(),
                        FirstName = reader["first_name"].ToString(),
                        LastName = reader["last_name"].ToString(),
                        DateOfBirth = (DateTime)reader["date_of_birth"],
                        Sex = reader["sex"].ToString(),
                        ContactNumber = reader["contact_number"].ToString(),
                        Address = reader["address"].ToString(),
                        EmergencyContact = reader["emergency_contact"].ToString(),
                        KnownAllergies = reader["known_allergies"].ToString(),
                        IsActive = (bool)reader["is_active"],
                        RegisteredAt = (DateTime)reader["registered_at"]
                    });
                }
            }
            return list;
        }

        public static void Add(Patient p)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new MySqlCommand(
                  "INSERT INTO patients (patient_code,first_name,last_name," +
                  "date_of_birth,sex,contact_number,address,emergency_contact,known_allergies)" +
                  " VALUES (@code,@fn,@ln,@dob,@sex,@cn,@addr,@ec,@allergy)", conn);
                cmd.Parameters.AddWithValue("@code", GenerateCode());
                cmd.Parameters.AddWithValue("@fn", p.FirstName);
                cmd.Parameters.AddWithValue("@ln", p.LastName);
                cmd.Parameters.AddWithValue("@dob", p.DateOfBirth);
                cmd.Parameters.AddWithValue("@sex", p.Sex);
                cmd.Parameters.AddWithValue("@cn", p.ContactNumber);
                cmd.Parameters.AddWithValue("@addr", p.Address);
                cmd.Parameters.AddWithValue("@ec", p.EmergencyContact);
                cmd.Parameters.AddWithValue("@allergy", p.KnownAllergies);
                cmd.ExecuteNonQuery();
            }
        }

        // Auto-generate PT-00001, PT-00002, etc.
        private static string GenerateCode()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new MySqlCommand("SELECT COUNT(*)+1 FROM patients", conn);
                int n = Convert.ToInt32(cmd.ExecuteScalar());
                return $"PT-{n:D5}";
            }
        }


    }
}
