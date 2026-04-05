using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;

namespace ClinicEMR.UserControls
{
    public partial class AdminDashboardControl : UserControl
    {
        private readonly User _user;

        public AdminDashboardControl(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_user.FullName}";

            // These services exist from Day 4 onward
            // Wrap in try-catch in case tables are empty
            try
            {
                lblTotalPatients.Text = $"{PatientService.GetAll().Count} patients registered";
                // lblTotalUsers.Text = $"{UserService.GetAll().Count} staff accounts";
            }
            catch
            {
                lblTotalPatients.Text = "Stats unavailable";
            }

            // Week 3: uncomment when ReportService exists
            // lblTodayVisits.Text = $"{ReportService.GetDailyVisitCount(DateTime.Today)} visits today";
            lblTodayVisits.Text = "Visit count loads in Week 3";
        }
    }

}
