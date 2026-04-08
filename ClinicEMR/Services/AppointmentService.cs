using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Services
{
    internal class AppointmentService
    {
        public static List<Appointment> GetAll()
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                var cmd = new MySqlCommand(@"
        SELECT a.*,
               CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
               u.full_name AS doctor_name
        FROM appointments a
        JOIN patients p ON a.patient_id = p.patient_id
        JOIN users u ON a.doctor_id = u.user_id
        ORDER BY a.appt_date DESC, a.appt_time DESC", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment
                        {
                            AppointmentId = (int)reader["appointment_id"],
                            PatientId = (int)reader["patient_id"],
                            DoctorId = (int)reader["doctor_id"],
                            ApptDate = Convert.ToDateTime(reader["appt_date"]),
                            ApptTime = TimeSpan.Parse(reader["appt_time"].ToString()),
                            Purpose = reader["purpose"]?.ToString(),
                            Status = reader["status"].ToString(),
                            PatientName = reader["patient_name"].ToString(),
                            DoctorName = reader["doctor_name"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public static List<Appointment> GetByStatus(string status)
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                string sql = @"
        SELECT a.*,
               CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
               u.full_name AS doctor_name
        FROM appointments a
        JOIN patients p ON a.patient_id = p.patient_id
        JOIN users u ON a.doctor_id = u.user_id
        WHERE a.status = @status
        ORDER BY a.appt_date DESC, a.appt_time DESC";

                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment
                        {
                            AppointmentId = (int)reader["appointment_id"],
                            PatientId = (int)reader["patient_id"],
                            DoctorId = (int)reader["doctor_id"],
                            ApptDate = Convert.ToDateTime(reader["appt_date"]),
                            ApptTime = TimeSpan.Parse(reader["appt_time"].ToString()),
                            Purpose = reader["purpose"]?.ToString(),
                            Status = reader["status"].ToString(),
                            PatientName = reader["patient_name"].ToString(),
                            DoctorName = reader["doctor_name"].ToString()
                        });
                    }
                }
            }

            return list;
        }
        public static List<Appointment> GetByDate(DateTime date)
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                var cmd = new MySqlCommand(@"
            SELECT a.*,
                   CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                   u.full_name AS doctor_name
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            JOIN users u ON a.doctor_id = u.user_id
            WHERE a.appt_date = @d
            ORDER BY a.appt_time", conn);

                cmd.Parameters.AddWithValue("@d", date.Date);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment
                        {
                            AppointmentId = (int)reader["appointment_id"],
                            PatientId = (int)reader["patient_id"],
                            DoctorId = (int)reader["doctor_id"],
                            ApptDate = Convert.ToDateTime(reader["appt_date"]),
                            ApptTime = TimeSpan.Parse(reader["appt_time"].ToString()),
                            Purpose = reader["purpose"]?.ToString(),
                            Status = reader["status"].ToString(),
                            PatientName = reader["patient_name"].ToString(),
                            DoctorName = reader["doctor_name"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public static List<Appointment> GetByDateAndDoctor(DateTime date, int doctorId)
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                var cmd = new MySqlCommand(@"
            SELECT a.*,
                   CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                   u.full_name AS doctor_name
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            JOIN users u ON a.doctor_id = u.user_id
            WHERE a.appt_date = @d AND a.doctor_id = @did
            ORDER BY a.appt_time", conn);

                cmd.Parameters.AddWithValue("@d", date.Date);
                cmd.Parameters.AddWithValue("@did", doctorId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment
                        {
                            AppointmentId = (int)reader["appointment_id"],
                            PatientId = (int)reader["patient_id"],
                            DoctorId = (int)reader["doctor_id"],
                            ApptDate = Convert.ToDateTime(reader["appt_date"]),
                            ApptTime = TimeSpan.Parse(reader["appt_time"].ToString()),
                            Purpose = reader["purpose"]?.ToString(),
                            Status = reader["status"].ToString(),
                            PatientName = reader["patient_name"].ToString(),
                            DoctorName = reader["doctor_name"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public static bool Book(Appointment a)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return false;

                // 🔍 Check double booking
                var checkCmd = new MySqlCommand(@"
            SELECT COUNT(*) FROM appointments
            WHERE doctor_id=@d
            AND appt_date=@date
            AND appt_time=@t
            AND status != 'Cancelled'", conn);

                checkCmd.Parameters.AddWithValue("@d", a.DoctorId);
                checkCmd.Parameters.AddWithValue("@date", a.ApptDate.Date);
                checkCmd.Parameters.AddWithValue("@t", a.ApptTime);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                    return false;

                // ✅ Insert (MATCHES YOUR SCHEMA)
                var cmd = new MySqlCommand(@"
            INSERT INTO appointments
            (patient_id, doctor_id, appt_date, appt_time, purpose, status, created_by)
            VALUES (@p, @d, @date, @t, @purpose, @s, @cb)", conn);

                cmd.Parameters.AddWithValue("@p", a.PatientId);
                cmd.Parameters.AddWithValue("@d", a.DoctorId);
                cmd.Parameters.AddWithValue("@date", a.ApptDate.Date);
                cmd.Parameters.AddWithValue("@t", a.ApptTime);
                cmd.Parameters.AddWithValue("@purpose", a.Purpose ?? "");
                cmd.Parameters.AddWithValue("@s", a.Status ?? "Scheduled");
                cmd.Parameters.AddWithValue("@cb", a.CreatedBy); // ⚠️ REQUIRED

                cmd.ExecuteNonQuery();

                return true;
            }
        }

        public static void UpdateStatus(int apptId, string status)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return;

                var cmd = new MySqlCommand(@"
            UPDATE appointments 
            SET status=@s 
            WHERE appointment_id=@id", conn);

                cmd.Parameters.AddWithValue("@s", status);
                cmd.Parameters.AddWithValue("@id", apptId);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Appointment> GetByDateAndStatus(DateTime date, string status)
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                string sql = @"
        SELECT a.*,
               CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
               u.full_name AS doctor_name
        FROM appointments a
        JOIN patients p ON a.patient_id = p.patient_id
        JOIN users u ON a.doctor_id = u.user_id
        WHERE a.appt_date = @d
        ";

                // ✅ APPLY STATUS FILTER
                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    sql += " AND a.status = @status";
                }

                sql += " ORDER BY a.appt_time";

                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@d", date.Date);

                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    cmd.Parameters.AddWithValue("@status", status);
                }

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment
                        {
                            AppointmentId = (int)reader["appointment_id"],
                            PatientId = (int)reader["patient_id"],
                            DoctorId = (int)reader["doctor_id"],
                            ApptDate = Convert.ToDateTime(reader["appt_date"]),
                            ApptTime = TimeSpan.Parse(reader["appt_time"].ToString()),
                            Purpose = reader["purpose"]?.ToString(),
                            Status = reader["status"].ToString(),
                            PatientName = reader["patient_name"].ToString(),
                            DoctorName = reader["doctor_name"].ToString()
                        });
                    }
                }
            }

            return list;
        }
    }
}
