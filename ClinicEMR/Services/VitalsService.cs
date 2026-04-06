using ClinicEMR.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Services
{
    internal class VitalsService
    {
        public static void Record(VitalSigns v)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {

                string sql = @"
            INSERT INTO vital_signs
            (patient_id, recorded_by, recorded_at,
             blood_pressure, heart_rate, temperature,
             height_cm, weight_kg, bmi)
            VALUES
            (@patient_id, @recorded_by, NOW(),
             @bp, @hr, @temp,
             @height, @weight, @bmi);
        ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@patient_id", v.PatientId);
                    cmd.Parameters.AddWithValue("@recorded_by", v.RecordedBy);
                    cmd.Parameters.AddWithValue("@bp", v.BloodPressure);
                    cmd.Parameters.AddWithValue("@hr", v.HeartRate);
                    cmd.Parameters.AddWithValue("@temp", v.Temperature);
                    cmd.Parameters.AddWithValue("@height", v.HeightCm);
                    cmd.Parameters.AddWithValue("@weight", v.WeightKg);
                    cmd.Parameters.AddWithValue("@bmi", v.Bmi);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<VitalSigns> GetByPatient(int pid)
        {
            var list = new List<VitalSigns>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string sql = @"
                    SELECT 
                        v.vital_id,
                        CONCAT(p.first_name, ' ', p.last_name) AS patient_name,
                        u.full_name AS recorded_by_name,
                        v.recorded_at,
                        v.blood_pressure,
                        v.heart_rate,
                        v.temperature,
                        v.height_cm,
                        v.weight_kg,
                        v.bmi
                    FROM vital_signs v
                    JOIN patients p ON v.patient_id = p.patient_id
                    JOIN users u ON v.recorded_by = u.user_id
                    WHERE v.patient_id = @pid
                    ORDER BY v.recorded_at DESC;
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@pid", pid);

                    using (var r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new VitalSigns
                            {
                                PatientName = r["patient_name"].ToString(),
                                RecordedByName = r["recorded_by_name"].ToString(),
                                RecordedAt = Convert.ToDateTime(r["recorded_at"]),
                                BloodPressure = r["blood_pressure"].ToString(),
                                HeartRate = Convert.ToInt32(r["heart_rate"]),
                                Temperature = Convert.ToDecimal(r["temperature"]),
                                HeightCm = Convert.ToDecimal(r["height_cm"]),
                                WeightKg = Convert.ToDecimal(r["weight_kg"]),
                                Bmi = Convert.ToDecimal(r["bmi"])

                            });
                        }
                    }
                }
            }

            return list;
        }

    }
}
