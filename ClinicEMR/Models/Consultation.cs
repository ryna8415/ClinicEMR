using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Models
{
    public class Consultation
    {
        public int ConsultationId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int DoctorId { get; set; }
        public int? VitalId { get; set; }
        public string DoctorName { get; set; }
        public string ChiefComplaint { get; set; }
        public string Findings { get; set; }
        public string Diagnosis { get; set; }
        public string DoctorNotes { get; set; }
        public DateTime ConsultDate { get; set; }
        public bool IsLocked { get; set; }
    }

}
