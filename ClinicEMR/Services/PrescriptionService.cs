using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClinicEMR.Services
{
    internal class PrescriptionService
    {
        public static void Add(Prescription p, int? actorUserId = null)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return;

            using var cmd = new MySqlCommand(@"
                INSERT INTO prescriptions
                    (consultation_id, patient_id,
                     medication_name, dosage, frequency, duration, instructions, status)
                VALUES
                    (@cid, @pid, @med, @dos, @freq, @dur, @ins, 'Active')", conn);

            cmd.Parameters.AddWithValue("@cid",
                p.ConsultationId > 0 ? (object)p.ConsultationId : DBNull.Value);

            cmd.Parameters.AddWithValue("@pid", p.PatientId);
            cmd.Parameters.AddWithValue("@med", p.MedicationName ?? "");
            cmd.Parameters.AddWithValue("@dos", p.Dosage ?? "");
            cmd.Parameters.AddWithValue("@freq", p.Frequency ?? "");
            cmd.Parameters.AddWithValue("@dur", p.Duration ?? "");
            cmd.Parameters.AddWithValue("@ins", p.Instructions ?? "");

            cmd.ExecuteNonQuery();
            int prescriptionId = (int)cmd.LastInsertedId;
            AuditLogService.Log(actorUserId, $"Added prescription #{prescriptionId} for patient #{p.PatientId}.");
        }

        public static bool Update(Prescription p, int? actorUserId = null)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return false;

            using var cmd = new MySqlCommand(@"
                UPDATE prescriptions
                SET medication_name = @med,
                    dosage = @dos,
                    frequency = @freq,
                    duration = @dur,
                    instructions = @ins,
                    updated_at = NOW()
                WHERE prescription_id = @id
                  AND status = 'Active';", conn);

            cmd.Parameters.AddWithValue("@id", p.PrescriptionId);
            cmd.Parameters.AddWithValue("@med", p.MedicationName ?? "");
            cmd.Parameters.AddWithValue("@dos", p.Dosage ?? "");
            cmd.Parameters.AddWithValue("@freq", p.Frequency ?? "");
            cmd.Parameters.AddWithValue("@dur", p.Duration ?? "");
            cmd.Parameters.AddWithValue("@ins", p.Instructions ?? "");

            bool updated = cmd.ExecuteNonQuery() > 0;
            if (updated)
            {
                AuditLogService.Log(actorUserId, $"Updated prescription #{p.PrescriptionId}.");
            }

            return updated;
        }

        public static bool UpdateStatus(int prescriptionId, string status, int? actorUserId = null)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return false;

            using var cmd = new MySqlCommand(@"
                UPDATE prescriptions
                SET status = @status,
                    updated_at = NOW()
                WHERE prescription_id = @id
                  AND status = 'Active';", conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", prescriptionId);

            bool updated = cmd.ExecuteNonQuery() > 0;
            if (updated)
            {
                AuditLogService.Log(actorUserId, $"{status} prescription #{prescriptionId}.");
            }

            return updated;
        }

        public static Prescription? GetById(int prescriptionId)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return null;

            using var cmd = new MySqlCommand(@"
                SELECT *
                FROM prescriptions
                WHERE prescription_id = @id
                LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@id", prescriptionId);

            using var r = cmd.ExecuteReader();
            return r.Read() ? MapRow(r) : null;
        }

        public static List<Prescription> GetByConsultation(int consultId)
        {
            var list = new List<Prescription>();

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return list;

            using var cmd = new MySqlCommand(@"
                SELECT *
                FROM prescriptions
                WHERE consultation_id = @cid
                ORDER BY prescription_id ASC", conn);

            cmd.Parameters.AddWithValue("@cid", consultId);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(MapRow(r));
            }

            return list;
        }

        public static List<Prescription> GetByPatient(int patientId)
        {
            var list = new List<Prescription>();

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return list;

            using var cmd = new MySqlCommand(@"
                SELECT *
                FROM prescriptions
                WHERE patient_id = @pid
                ORDER BY prescription_id DESC", conn);

            cmd.Parameters.AddWithValue("@pid", patientId);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(MapRow(r));
            }

            return list;
        }

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
                Instructions = r["instructions"].ToString(),
                IssuedAt = HasColumn(r, "issued_at") && r["issued_at"] != DBNull.Value
                    ? Convert.ToDateTime(r["issued_at"])
                    : DateTime.MinValue,
                Status = HasColumn(r, "status") ? r["status"].ToString() ?? "Active" : "Active",
                UpdatedAt = HasColumn(r, "updated_at") && r["updated_at"] != DBNull.Value
                    ? Convert.ToDateTime(r["updated_at"])
                    : null
            };
        }

        private static bool HasColumn(MySqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (string.Equals(reader.GetName(i), columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
