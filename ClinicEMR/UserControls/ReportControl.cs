using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class ReportControl : UserControl
    {
        private readonly User _user;

        public ReportControl(User user)
        {
            InitializeComponent();
            _user = user;
            dtpDate.Value = DateTime.Today;
            GridViewService.MakeReadOnly(dgvReport);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime d = dtpDate.Value.Date;
            int count = ReportService.GetDailyVisitCount(d);
            lblCount.Text = $"Patients seen on {d:MMMM dd, yyyy}: {count}";
            dgvReport.DataSource = ReportService.GetDailySummary(d);
            GridViewService.ShowOnly(dgvReport, "Patient Code", "Patient Name", "Diagnosis", "Doctor", "Time");
        }
    }
}
