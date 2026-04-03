using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicEMR.Forms;
using ClinicEMR.Models;

namespace ClinicEMR.Forms
{
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard(User user)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + user.FullName;
        }
    }
}
