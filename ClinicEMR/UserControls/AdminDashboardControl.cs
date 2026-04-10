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
            GridViewService.MakeReadOnly(dgvRecentLogins);
        }

        private void AdminDashboardControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_user.FullName}";

            try
            {
                lblTotalPatients.Text = $"{PatientService.GetAll().Count} patients registered";
                lblTotalUsers.Text = $"{UserService.GetAll().Count} staff accounts";
                lblTodayVisits.Text = $"{ReportService.GetDailyVisitCount(DateTime.Today)} visits today";

                dgvRecentLogins.DataSource = UserService.GetRecentLogins();
                GridViewService.ShowOnly(dgvRecentLogins, "Full Name", "Role", "Last Login");
            }
            catch
            {
                lblTotalPatients.Text = "Stats unavailable";
                lblTotalUsers.Text = "Stats unavailable";
                lblTodayVisits.Text = "Stats unavailable";
                dgvRecentLogins.DataSource = null;
            }
        }
    }

}
