using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicEMR.Models;


namespace ClinicEMR.Forms
{
    public partial class NurseDashboard : Form
    {
        public NurseDashboard(User user)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + user.FullName;
        }
    }
}
