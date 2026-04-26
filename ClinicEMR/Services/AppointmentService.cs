using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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

                using var cmd = new MySqlCommand(@"
        SELECT a.*,
               CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
               u.full_name AS doctor_name
        FROM appointments a
        JOIN patients p ON a.patient_id = p.patient_id
        JOIN users u ON a.doctor_id = u.user_id
        ORDER BY a.appt_date DESC, a.appt_time DESC", conn);
                list.AddRange(ReadAppointments(cmd));
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

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                list.AddRange(ReadAppointments(cmd));
            }

            return list;
        }

        public static List<Appointment> GetByDate(DateTime date)
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                using var cmd = new MySqlCommand(@"
            SELECT a.*,
                   CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                   u.full_name AS doctor_name
            FROM appointments a
            JOIN patients p ON a.patient_id = p.patient_id
            JOIN users u ON a.doctor_id = u.user_id
            WHERE a.appt_date = @d
            ORDER BY a.appt_time", conn);

                cmd.Parameters.AddWithValue("@d", date.Date);
                list.AddRange(ReadAppointments(cmd));
            }

            return list;
        }

        public static List<Appointment> GetByDateAndDoctor(DateTime date, int doctorId)
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return list;

                using var cmd = new MySqlCommand(@"
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
                list.AddRange(ReadAppointments(cmd));
            }

            return list;
        }

        public static bool Book(Appointment a)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return false;

                DateTime appointmentDateTime = a.ApptDate.Date.Add(a.ApptTime);
                if (appointmentDateTime < DateTime.Now)
                    return false;

                var checkCmd = new MySqlCommand(@"
            SELECT COUNT(*) FROM appointments
            WHERE doctor_id=@d
            AND appt_date=@date
            AND appt_time=@t
            AND status != 'Cancelled'", conn);

                checkCmd.Parameters.AddWithValue("@d", a.DoctorId);
                checkCmd.Parameters.AddWithValue("@date", a.ApptDate.Date);
                checkCmd.Parameters.AddWithValue("@t", a.ApptTime);

                int doctorConflictCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (doctorConflictCount > 0)
                    return false;

                var patientCheckCmd = new MySqlCommand(@"
            SELECT COUNT(*) FROM appointments
            WHERE patient_id=@p
            AND appt_date=@date
            AND appt_time=@t
            AND status != 'Cancelled'", conn);

                patientCheckCmd.Parameters.AddWithValue("@p", a.PatientId);
                patientCheckCmd.Parameters.AddWithValue("@date", a.ApptDate.Date);
                patientCheckCmd.Parameters.AddWithValue("@t", a.ApptTime);

                int patientConflictCount = Convert.ToInt32(patientCheckCmd.ExecuteScalar());
                if (patientConflictCount > 0)
                    return false;

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
                cmd.Parameters.AddWithValue("@cb", a.CreatedBy);

                cmd.ExecuteNonQuery();
                AuditLogService.Log(a.CreatedBy, $"Booked appointment for patient #{a.PatientId} on {a.ApptDate:yyyy-MM-dd} at {a.ApptTime:hh\\:mm}.");

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
                AuditLogService.Log(null, $"Updated appointment #{apptId} status to {status}.");
            }
        }

        public static Appointment? GetById(int appointmentId)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return null;

                var cmd = new MySqlCommand(@"
                    SELECT a.*,
                           CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                           u.full_name AS doctor_name
                    FROM appointments a
                    JOIN patients p ON a.patient_id = p.patient_id
                    JOIN users u ON a.doctor_id = u.user_id
                    WHERE a.appointment_id = @id
                    LIMIT 1", conn);
                cmd.Parameters.AddWithValue("@id", appointmentId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return null;
                    }

                    return new Appointment
                    {
                        AppointmentId = (int)reader["appointment_id"],
                        PatientId = (int)reader["patient_id"],
                        DoctorId = (int)reader["doctor_id"],
                        ApptDate = Convert.ToDateTime(reader["appt_date"]),
                        ApptTime = TimeSpan.Parse(reader["appt_time"].ToString()),
                        Purpose = reader["purpose"]?.ToString(),
                        Status = reader["status"].ToString(),
                        PatientName = reader["patient_name"].ToString(),
                        DoctorName = reader["doctor_name"].ToString(),
                        CreatedBy = reader["created_by"] == DBNull.Value ? 0 : Convert.ToInt32(reader["created_by"])
                    };
                }
            }
        }

        public static bool UpdateAppointment(Appointment appointment, int? actorUserId = null)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return false;

                DateTime appointmentDateTime = appointment.ApptDate.Date.Add(appointment.ApptTime);
                if (appointmentDateTime < DateTime.Now)
                    return false;

                var checkDoctorCmd = new MySqlCommand(@"
                    SELECT COUNT(*)
                    FROM appointments
                    WHERE appointment_id <> @id
                      AND doctor_id = @doctorId
                      AND appt_date = @apptDate
                      AND appt_time = @apptTime
                      AND status <> 'Cancelled'", conn);
                checkDoctorCmd.Parameters.AddWithValue("@id", appointment.AppointmentId);
                checkDoctorCmd.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
                checkDoctorCmd.Parameters.AddWithValue("@apptDate", appointment.ApptDate.Date);
                checkDoctorCmd.Parameters.AddWithValue("@apptTime", appointment.ApptTime);

                if (Convert.ToInt32(checkDoctorCmd.ExecuteScalar()) > 0)
                    return false;

                var checkPatientCmd = new MySqlCommand(@"
                    SELECT COUNT(*)
                    FROM appointments
                    WHERE appointment_id <> @id
                      AND patient_id = @patientId
                      AND appt_date = @apptDate
                      AND appt_time = @apptTime
                      AND status <> 'Cancelled'", conn);
                checkPatientCmd.Parameters.AddWithValue("@id", appointment.AppointmentId);
                checkPatientCmd.Parameters.AddWithValue("@patientId", appointment.PatientId);
                checkPatientCmd.Parameters.AddWithValue("@apptDate", appointment.ApptDate.Date);
                checkPatientCmd.Parameters.AddWithValue("@apptTime", appointment.ApptTime);

                if (Convert.ToInt32(checkPatientCmd.ExecuteScalar()) > 0)
                    return false;

                var updateCmd = new MySqlCommand(@"
                    UPDATE appointments
                    SET doctor_id = @doctorId,
                        appt_date = @apptDate,
                        appt_time = @apptTime,
                        purpose = @purpose,
                        status = @status
                    WHERE appointment_id = @id", conn);

                updateCmd.Parameters.AddWithValue("@doctorId", appointment.DoctorId);
                updateCmd.Parameters.AddWithValue("@apptDate", appointment.ApptDate.Date);
                updateCmd.Parameters.AddWithValue("@apptTime", appointment.ApptTime);
                updateCmd.Parameters.AddWithValue("@purpose", appointment.Purpose ?? string.Empty);
                updateCmd.Parameters.AddWithValue("@status", appointment.Status ?? "Scheduled");
                updateCmd.Parameters.AddWithValue("@id", appointment.AppointmentId);
                updateCmd.ExecuteNonQuery();

                AuditLogService.Log(actorUserId, $"Edited appointment #{appointment.AppointmentId}.");
                return true;
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

                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    sql += " AND a.status = @status";
                }

                sql += " ORDER BY a.appt_time";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@d", date.Date);

                if (!string.IsNullOrEmpty(status) && status != "All")
                {
                    cmd.Parameters.AddWithValue("@status", status);
                }

                list.AddRange(ReadAppointments(cmd));
            }

            return list;
        }

        private static List<Appointment> ReadAppointments(MySqlCommand cmd)
        {
            var list = new List<Appointment>();

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(MapAppointment(reader));
            }

            return list;
        }

        private static Appointment MapAppointment(MySqlDataReader reader)
        {
            return new Appointment
            {
                AppointmentId = (int)reader["appointment_id"],
                PatientId = (int)reader["patient_id"],
                DoctorId = (int)reader["doctor_id"],
                ApptDate = Convert.ToDateTime(reader["appt_date"]),
                ApptTime = TimeSpan.Parse(reader["appt_time"].ToString()),
                Purpose = reader["purpose"]?.ToString(),
                Status = reader["status"].ToString(),
                PatientName = reader["patient_name"].ToString(),
                DoctorName = reader["doctor_name"].ToString(),
                CreatedBy = reader["created_by"] == DBNull.Value ? 0 : Convert.ToInt32(reader["created_by"])
            };
        }
    }
}
