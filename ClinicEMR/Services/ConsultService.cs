using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ClinicEMR.Services
{
    internal class ConsultService
    {
        // ── Save a new consultation ──────────────────────────────────────────
        // Automatically links the most recent vital signs for this patient.
        // Returns the new consultation_id so PrescriptionControl can use it.
        public static int Save(Consultation c)
        {
            int newId = 0;

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return 0;

                string sql = @"
                    INSERT INTO consultations
                        (patient_id, doctor_id, vital_id,
                         chief_complaint, findings, diagnosis, doctor_notes)
                    VALUES
                        (@pid, @did,
                         (SELECT vital_id FROM vital_signs
                          WHERE patient_id = @pid
                          ORDER BY recorded_at DESC LIMIT 1),
                         @chief, @findings, @diagnosis, @notes);
                ";

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
            }

            return newId;
        }

        // ── Get all consultations for a patient (newest first) ───────────────
        public static List<Consultation> GetByPatient(int pid)
        {
            var list = new List<Consultation>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                string sql = @"
                    SELECT
                        c.*,
                        u.full_name AS doctor_name
                    FROM consultations c
                    JOIN users u ON c.doctor_id = u.user_id
                    WHERE c.patient_id = @pid
                    ORDER BY c.consult_date DESC;
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", pid);

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Consultation
                            {
                                ConsultationId = Convert.ToInt32(r["consultation_id"]),
                                PatientId = Convert.ToInt32(r["patient_id"]),
                                DoctorId = Convert.ToInt32(r["doctor_id"]),
                                DoctorName = r["doctor_name"].ToString(),
                                VitalId = r["vital_id"] == DBNull.Value
                                                     ? 0
                                                     : Convert.ToInt32(r["vital_id"]),
                                ChiefComplaint = r["chief_complaint"].ToString(),
                                Findings = r["findings"].ToString(),
                                Diagnosis = r["diagnosis"].ToString(),
                                DoctorNotes = r["doctor_notes"].ToString(),
                                ConsultDate = Convert.ToDateTime(r["consult_date"]),
                                IsLocked = Convert.ToBoolean(r["is_locked"])
                            });
                        }
                    }
                }
            }

            return list;
        }

        // ── Get a single consultation by ID ──────────────────────────────────
        // Used by PrescriptionControl to know which patient is linked.
        public static Consultation GetById(int consultId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return null;

                string sql = @"
                    SELECT
                        c.*,
                        u.full_name AS doctor_name
                    FROM consultations c
                    LEFT JOIN users u ON c.doctor_id = u.user_id
                    WHERE c.consultation_id = @id
                    LIMIT 1;
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", consultId);

                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return new Consultation
                            {
                                ConsultationId = Convert.ToInt32(r["consultation_id"]),
                                PatientId = Convert.ToInt32(r["patient_id"]),
                                DoctorId = Convert.ToInt32(r["doctor_id"]),
                                DoctorName = r["doctor_name"].ToString(),
                                VitalId = r["vital_id"] == DBNull.Value
                                                     ? 0
                                                     : Convert.ToInt32(r["vital_id"]),
                                ChiefComplaint = r["chief_complaint"].ToString(),
                                Findings = r["findings"].ToString(),
                                Diagnosis = r["diagnosis"].ToString(),
                                DoctorNotes = r["doctor_notes"].ToString(),
                                ConsultDate = Convert.ToDateTime(r["consult_date"]),
                                IsLocked = Convert.ToBoolean(r["is_locked"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        // ── Lock all consultations from previous days for a doctor ───────────
        // Called silently when the doctor logs in or opens ConsultationControl.
        public static void LockPastConsultations(int doctorId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                string sql = @"
                    UPDATE consultations
                    SET    is_locked = 1
                    WHERE  doctor_id = @did
                    AND    DATE(consult_date) < CURDATE();
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@did", doctorId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}