using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClinicEMR.Services
{
    internal class PrescriptionService
    {
        // ── Add a single drug to a prescription ──────────────────────────────
        // consultation_id is allowed to be NULL (standalone prescription).
        // Pass ConsultationId = 0 from PrescriptionControl for standalone mode.
        public static void Add(Prescription p)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                var cmd = new MySqlCommand(@"
                    INSERT INTO prescriptions
                        (consultation_id, patient_id,
                         medication_name, dosage, frequency, duration, instructions)
                    VALUES
                        (@cid, @pid, @med, @dos, @freq, @dur, @ins)", conn);

                // Send NULL when there is no linked consultation
                cmd.Parameters.AddWithValue("@cid",
                    p.ConsultationId > 0 ? (object)p.ConsultationId : DBNull.Value);

                cmd.Parameters.AddWithValue("@pid", p.PatientId);
                cmd.Parameters.AddWithValue("@med", p.MedicationName ?? "");
                cmd.Parameters.AddWithValue("@dos", p.Dosage ?? "");
                cmd.Parameters.AddWithValue("@freq", p.Frequency ?? "");
                cmd.Parameters.AddWithValue("@dur", p.Duration ?? "");
                cmd.Parameters.AddWithValue("@ins", p.Instructions ?? "");

                cmd.ExecuteNonQuery();
            }
        }

        // ── Get all prescriptions for a specific consultation ────────────────
        // Used by PrescriptionControl.LoadConsultation() to pre-load
        // any drugs already saved under this consultation.
        public static List<Prescription> GetByConsultation(int consultId)
        {
            var list = new List<Prescription>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                var cmd = new MySqlCommand(@"
                    SELECT *
                    FROM   prescriptions
                    WHERE  consultation_id = @cid
                    ORDER  BY prescription_id ASC", conn);

                cmd.Parameters.AddWithValue("@cid", consultId);

                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        list.Add(MapRow(r));
                }
            }

            return list;
        }

        // ── Get all prescriptions for a patient (newest first) ───────────────
        // Used by PatientRecordControl prescriptions tab.
        public static List<Prescription> GetByPatient(int patientId)
        {
            var list = new List<Prescription>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                var cmd = new MySqlCommand(@"
                    SELECT *
                    FROM   prescriptions
                    WHERE  patient_id = @pid
                    ORDER  BY prescription_id DESC", conn);

                cmd.Parameters.AddWithValue("@pid", patientId);

                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        list.Add(MapRow(r));
                }
            }

            return list;
        }

        // ── Private helper: map a data reader row to a Prescription object ───
        private static Prescription MapRow(MySqlDataReader r)
        {
            return new Prescription
            {
                PrescriptionId = Convert.ToInt32(r["prescription_id"]),
                ConsultationId = r["consultation_id"] == DBNull.Value
                                     ? 0
                                     : Convert.ToInt32(r["consultation_id"]),
                PatientId = Convert.ToInt32(r["patient_id"]),
                MedicationName = r["medication_name"].ToString(),
                Dosage = r["dosage"].ToString(),
                Frequency = r["frequency"].ToString(),
                Duration = r["duration"].ToString(),
                Instructions = r["instructions"].ToString()
            };
        }
    }
}