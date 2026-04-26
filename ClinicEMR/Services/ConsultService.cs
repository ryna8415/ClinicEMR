using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClinicEMR.Services
{
    internal class ConsultService
    {
        public static int Save(Consultation c)
        {
            int newId = 0;

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return 0;

            string sql = @"
                INSERT INTO consultations
                    (patient_id, doctor_id, vital_id,
                     chief_complaint, findings, diagnosis, doctor_notes, status)
                VALUES
                    (@pid, @did,
                     (SELECT vital_id FROM vital_signs
                      WHERE patient_id = @pid
                      ORDER BY recorded_at DESC LIMIT 1),
                     @chief, @findings, @diagnosis, @notes, 'Active');";

            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@pid", c.PatientId);
                cmd.Parameters.AddWithValue("@did", c.DoctorId);
                cmd.Parameters.AddWithValue("@chief", c.ChiefComplaint ?? "");
                cmd.Parameters.AddWithValue("@findings", c.Findings ?? "");
                cmd.Parameters.AddWithValue("@diagnosis", c.Diagnosis ?? "");
                cmd.Parameters.AddWithValue("@notes", c.DoctorNotes ?? "");

                cmd.ExecuteNonQuery();
                newId = (int)cmd.LastInsertedId;
            }

            AuditLogService.Log(c.DoctorId, $"Saved consultation #{newId} for patient #{c.PatientId}.");
            return newId;
        }

        public static bool Update(Consultation c)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return false;

            using var cmd = new MySqlCommand(@"
                UPDATE consultations
                SET chief_complaint = @chief,
                    findings = @findings,
                    diagnosis = @diagnosis,
                    doctor_notes = @notes,
                    updated_at = NOW()
                WHERE consultation_id = @id
                  AND status = 'Active'
                  AND is_locked = 0;", conn);

            cmd.Parameters.AddWithValue("@id", c.ConsultationId);
            cmd.Parameters.AddWithValue("@chief", c.ChiefComplaint ?? "");
            cmd.Parameters.AddWithValue("@findings", c.Findings ?? "");
            cmd.Parameters.AddWithValue("@diagnosis", c.Diagnosis ?? "");
            cmd.Parameters.AddWithValue("@notes", c.DoctorNotes ?? "");

            bool updated = cmd.ExecuteNonQuery() > 0;
            if (updated)
            {
                AuditLogService.Log(c.DoctorId, $"Updated consultation #{c.ConsultationId}.");
            }

            return updated;
        }

        public static bool UpdateStatus(int consultationId, int actorUserId, string status)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return false;

            using var cmd = new MySqlCommand(@"
                UPDATE consultations
                SET status = @status,
                    updated_at = NOW()
                WHERE consultation_id = @id
                  AND status = 'Active';", conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", consultationId);

            bool updated = cmd.ExecuteNonQuery() > 0;
            if (updated)
            {
                AuditLogService.Log(actorUserId, $"{status} consultation #{consultationId}.");
            }

            return updated;
        }

        public static List<Consultation> GetByPatient(int pid)
        {
            var list = new List<Consultation>();

            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return list;

            string sql = @"
                SELECT
                    c.*,
                    u.full_name AS doctor_name
                FROM consultations c
                JOIN users u ON c.doctor_id = u.user_id
                WHERE c.patient_id = @pid
                ORDER BY c.consult_date DESC;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", pid);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(MapConsultation(r));
            }

            return list;
        }

        public static Consultation? GetById(int consultId)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return null;

            string sql = @"
                SELECT
                    c.*,
                    u.full_name AS doctor_name
                FROM consultations c
                LEFT JOIN users u ON c.doctor_id = u.user_id
                WHERE c.consultation_id = @id
                LIMIT 1;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", consultId);

            using var r = cmd.ExecuteReader();
            return r.Read() ? MapConsultation(r) : null;
        }

        public static void LockPastConsultations(int doctorId)
        {
            using var conn = DatabaseHelper.GetConnection();
            if (conn == null) return;

            string sql = @"
                UPDATE consultations
                SET    is_locked = 1
                WHERE  doctor_id = @did
                AND    DATE(consult_date) < CURDATE();";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@did", doctorId);
            cmd.ExecuteNonQuery();
        }

        private static Consultation MapConsultation(MySqlDataReader r)
        {
            return new Consultation
            {
                ConsultationId = Convert.ToInt32(r["consultation_id"]),
                PatientId = Convert.ToInt32(r["patient_id"]),
                DoctorId = Convert.ToInt32(r["doctor_id"]),
                DoctorName = r["doctor_name"].ToString(),
                VitalId = r["vital_id"] == DBNull.Value ? 0 : Convert.ToInt32(r["vital_id"]),
                ChiefComplaint = r["chief_complaint"].ToString(),
                Findings = r["findings"].ToString(),
                Diagnosis = r["diagnosis"].ToString(),
                DoctorNotes = r["doctor_notes"].ToString(),
                ConsultDate = Convert.ToDateTime(r["consult_date"]),
                IsLocked = Convert.ToBoolean(r["is_locked"]),
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
