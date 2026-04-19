using ClinicEMR.Models;
using ClinicEMR.Services;

namespace ClinicEMR.UserControls
{
    public partial class NurseDashboardControl : UserControl
    {
        private readonly User _user;

        public NurseDashboardControl(User user)
        {
            InitializeComponent();
            _user = user;
            GridViewService.MakeReadOnly(dgvTodayAppts);
        }

        private void NurseDashboardControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Good day, {_user.FullName}";

            var appts = AppointmentService.GetByDate(DateTime.Today);
            lblApptCount.Text = $"{appts.Count} appointments scheduled today";
            dgvTodayAppts.DataSource = appts;
            GridViewService.ShowOnly(dgvTodayAppts, "ApptTime", "PatientName", "DoctorName", "Purpose", "Status");
            GridViewService.SetHeaders(dgvTodayAppts, new Dictionary<string, string>
            {
                ["ApptTime"] = "Time",
                ["PatientName"] = "Patient",
                ["DoctorName"] = "Doctor",
                ["Purpose"] = "Purpose",
                ["Status"] = "Status"
            });
            GridViewService.ClearSelection(dgvTodayAppts);

            var patients = PatientService.GetAll();
            lblPatientCount.Text = $"{patients.Count} patients registered";
        }
    }
}
    
