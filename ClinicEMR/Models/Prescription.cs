using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Models
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public int ConsultationId { get; set; }
        public int PatientId { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string Duration { get; set; }
        public string Instructions { get; set; }
        public DateTime IssuedAt { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedAt { get; set; }

        private int _patientId = 0;
        public string Summary =>
          $"{MedicationName} {Dosage} - {Frequency} for {Duration}" +
          (string.Equals(NormalizedStatus, "Active", StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(NormalizedStatus)
              ? string.Empty
              : $" [{NormalizedStatus}]");

        public string NormalizedStatus =>
            string.Equals(Status, "Cancelled", StringComparison.OrdinalIgnoreCase)
                ? "Voided"
                : Status;

        public override string ToString()
        {
            return Summary;
        }
    }

}
