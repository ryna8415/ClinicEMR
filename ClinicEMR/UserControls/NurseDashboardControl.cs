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
        }

        private void NurseDashboardControl_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Good day, {_user.FullName}";

            var appts = AppointmentService.GetByDate(DateTime.Today);
            lblApptCount.Text = $"{appts.Count} appointments scheduled today";
            dgvTodayAppts.DataSource = appts;

            lblApptCount.Text = "Appointments load in Week 2";

            // Hide columns users don't need to see
            HideColumn("AppointmentId");
            HideColumn("PatientId");
            HideColumn("DoctorId");
            HideColumn("CreatedBy");

            var patients = PatientService.GetAll();
            lblPatientCount.Text = $"{patients.Count} patients registered";
        }

        private void HideColumn(string name)
        {
            if (dgvTodayAppts.Columns[name] != null)
                dgvTodayAppts.Columns[name].Visible = false;
        }
    }
}
    