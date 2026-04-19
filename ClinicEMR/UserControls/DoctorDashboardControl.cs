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
    public partial class DoctorDashboardControl : UserControl
    {
        private readonly User _user;

        public DoctorDashboardControl(User user)
        {
            InitializeComponent();
            _user = user;
            GridViewService.MakeReadOnly(dgvMyAppts);
        }

        private void DoctorDashboardControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Good day, Dr. {_user.FullName}";

             var appts = AppointmentService.GetByDateAndDoctor(DateTime.Today, _user.UserId);
             lblMyPatients.Text = $"{appts.Count} patients scheduled for you today";
             dgvMyAppts.DataSource = appts;
             GridViewService.ShowOnly(dgvMyAppts, "ApptTime", "PatientName", "Purpose", "Status");
             GridViewService.SetHeaders(dgvMyAppts, new Dictionary<string, string>
             {
                 ["ApptTime"] = "Time",
                 ["PatientName"] = "Patient",
                 ["Purpose"] = "Purpose",
                 ["Status"] = "Status"
             });
             GridViewService.ClearSelection(dgvMyAppts);

            // Lock yesterday's consultations every time doctor logs in
            // Week 2: uncomment when ConsultService exists
             ConsultService.LockPastConsultations(_user.UserId);

        }
    }
}
