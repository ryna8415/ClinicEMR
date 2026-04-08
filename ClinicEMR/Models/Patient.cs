using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string ContactNumber { get; set; }
        public string KnownAllergies { get; set; }
        public bool IsActive { get; set; }
        public string Address { get; set; }
        public string EmergencyContact { get; set; }
        public DateTime RegisteredAt { get; set; }
        public string ChronicConditions { get; set; }
        public string PastSurgeries { get; set; }
        public string FamilyHistory { get; set; }
        public string CurrentMedications { get; set; }
        public string FullName => $"{LastName}, {FirstName}";
        public string DisplayInfo => $"{FullName} ({PatientCode})";
    }
}
