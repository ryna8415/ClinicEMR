using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicEMR.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }  // admin, doctor, nurse
        public bool IsActive { get; set; }
    }
}
