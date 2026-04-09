using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClinicEMR.Services
{
    internal class ReportService
    {
        public static int GetDailyVisitCount(DateTime date)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return 0;

                var cmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM consultations WHERE DATE(consult_date) = @d", conn);
                cmd.Parameters.AddWithValue("@d", date.Date);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public static DataTable GetDailySummary(DateTime date)
        {
            var dt = new DataTable();

            using (var conn = DatabaseHelper.GetConnection())
            {
                if (conn == null) return dt;

                string sql = @"
                    SELECT
                        p.patient_code AS 'Patient Code',
                        CONCAT(p.last_name, ', ', p.first_name) AS 'Patient Name',
                        c.diagnosis AS 'Diagnosis',
                        u.full_name AS 'Doctor',
                        TIME(c.consult_date) AS 'Time'
                    FROM consultations c
                    JOIN patients p ON c.patient_id = p.patient_id
                    JOIN users u ON c.doctor_id = u.user_id
                    WHERE DATE(c.consult_date) = @d
                    ORDER BY c.consult_date";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@d", date.Date);

                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
