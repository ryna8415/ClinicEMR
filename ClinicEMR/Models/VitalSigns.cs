using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Models
{
    public class VitalSigns
    {
        public int VitalId { get; set; }
        public int PatientId { get; set; }
        public DateTime RecordedAt { get; set; }
        public string PatientName { get; set; }
        public string RecordedByName { get; set; }
        public int RecordedBy { get; set; }
        public string BloodPressure { get; set; }
        public int HeartRate { get; set; }
        public decimal Temperature { get; set; }
        public decimal HeightCm { get; set; }
        public decimal WeightKg { get; set; }
        public decimal Bmi { get; set; }
        public string BmiCategory
        {
            get
            {
                if (Bmi <= 0) return "";
                if (Bmi < 18.5m) return "Underweight";
                if (Bmi < 25m) return "Normal";
                if (Bmi < 30m) return "Overweight";
                return "Obese";
            }
        }
    }

}
