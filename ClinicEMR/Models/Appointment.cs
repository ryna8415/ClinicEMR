using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public DateTime ApptDate { get; set; }
        public TimeSpan ApptTime { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
    }

}
