using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClinicEMR.Models;
using ClinicEMR.UserControls;

namespace ClinicEMR.Forms
{

    public partial class MainShellForm : Form
    {
        private Dictionary<string, Button> _navButtons = new();
        private readonly Color _sidebarButtonColor = Color.FromArgb(225, 238, 248);
        private readonly Color _sidebarButtonHoverColor = Color.FromArgb(82, 124, 164);
        private readonly Color _sidebarButtonActiveColor = Color.FromArgb(64, 109, 151);

        private void NavButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnDashboard": ShowStartScreen(); break;
                case "btnPatients": ShowControl(_patients, btn); break;
                case "btnAppts": ShowControl(_appointments, btn); break;
                case "btnVitals": ShowControl(_vitals, btn); break;
                case "btnConsult": ShowControl(_consultation, btn); break;
                case "btnRx": _prescription.ResetForStandalone(); ShowControl(_prescription, btn); break;
                case "btnMedHistory": ShowControl(_medHistory, btn); break;
                case "btnReports": ShowControl(_report, btn); break;
                case "btnUsers": ShowControl(_userMgmt, btn); break;
            }
        }

        private readonly User _currentUser;

        private NurseDashboardControl? _nurseDash;
        private DoctorDashboardControl? _doctorDash;
        private AdminDashboardControl? _adminDash;

        private PatientListControl? _patients;
        private UserManagementControl? _userMgmt;
        private AppointmentControl? _appointments;
        private VitalsControl? _vitals;
        private PrescriptionControl? _prescription;
        private ConsultationControl? _consultation;
        private MedHistoryControl? _medHistory;
        private PatientRecordControl? _patientRecord;
        private ReportControl? _report;

        private Control? _activeControl;
        private Button? _activeButton;

        public MainShellForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            BuildSidebar();
            BuildControls();
            ApplyRolePermissions();
            ShowStartScreen();
        }

        private void BuildSidebar()
        {
            _navButtons = new Dictionary<string, Button>
            {
                ["btnDashboard"] = btnDashboard,
                ["btnPatients"] = btnPatients,
                ["btnAppts"] = btnAppts,
                ["btnVitals"] = btnVitals,
                ["btnConsult"] = btnConsult,
                ["btnRx"] = btnRx,
                ["btnMedHistory"] = btnMedHistory,
                ["btnReports"] = btnReports,
                ["btnUsers"] = btnUsers
            };

            lblUserName.Text = _currentUser.FullName;
            lblUserRole.Text = char.ToUpper(_currentUser.Role[0]) + _currentUser.Role.Substring(1);

            foreach (var button in _navButtons.Values)
            {
                button.Visible = false;
                button.BackColor = Color.Transparent;
                button.ForeColor = _sidebarButtonColor;
                button.Click -= NavButton_Click;
                button.Click += NavButton_Click;
                button.MouseEnter -= NavButton_MouseEnter;
                button.MouseEnter += NavButton_MouseEnter;
                button.MouseLeave -= NavButton_MouseLeave;
                button.MouseLeave += NavButton_MouseLeave;
            }

            btnLogout.BackColor = Color.Transparent;
            btnLogout.ForeColor = _sidebarButtonColor;
            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter -= LogoutButton_MouseEnter;
            btnLogout.MouseEnter += LogoutButton_MouseEnter;
            btnLogout.MouseLeave -= LogoutButton_MouseLeave;
            btnLogout.MouseLeave += LogoutButton_MouseLeave;

            pnlSide.Visible = false;
        }

        private void BuildControls()
        {
            if (_currentUser.Role == "nurse")
                _nurseDash = new NurseDashboardControl(_currentUser);
            if (_currentUser.Role == "doctor")
                _doctorDash = new DoctorDashboardControl(_currentUser);
            if (_currentUser.Role == "admin")
                _adminDash = new AdminDashboardControl(_currentUser);

            _patients = new PatientListControl(_currentUser, this);
            _userMgmt = new UserManagementControl(_currentUser);
            _appointments = new AppointmentControl(_currentUser, this);
                _appointments.Dock = DockStyle.Fill;
                _appointments.Visible = false;
                pnlContent.Controls.Add(_appointments);
            _vitals = new VitalsControl(_currentUser, this);
                _vitals.Dock = DockStyle.Fill;
                _vitals.Visible = false;
                pnlContent.Controls.Add(_vitals);
            _consultation = new ConsultationControl(_currentUser, this);
            _consultation.Dock = DockStyle.Fill;
            _consultation.Visible = false;
            pnlContent.Controls.Add(_consultation);
            _prescription = new PrescriptionControl(_currentUser, this);
            _prescription.Dock = DockStyle.Fill;
            _prescription.Visible = false;
            pnlContent.Controls.Add(_prescription);
            _medHistory = new MedHistoryControl(_currentUser, this);
            _medHistory.Dock = DockStyle.Fill;
            _medHistory.Visible = false;
            pnlContent.Controls.Add(_medHistory);
            _patientRecord = new PatientRecordControl(_currentUser, this);
            _patientRecord.Dock = DockStyle.Fill;
            _patientRecord.Visible = false;
            pnlContent.Controls.Add(_patientRecord);
            _report = new ReportControl(_currentUser);
            _report.Dock = DockStyle.Fill;
            _report.Visible = false;
            pnlContent.Controls.Add(_report);

            Control[] all = {
                _nurseDash, _doctorDash, _adminDash,
                _patients, _userMgmt
            };
            foreach (var c in all)
            {
                if (c == null) continue;
                c.Dock = DockStyle.Fill;
                c.Visible = false;
                pnlContent.Controls.Add(c);
            }
        }

        private void ApplyRolePermissions()
        {
            _navButtons["btnDashboard"].Visible = true;

            string[] nurseButtons = { "btnPatients", "btnAppts", "btnVitals", "btnMedHistory" };
            string[] doctorButtons = { "btnPatients", "btnConsult", "btnRx", "btnMedHistory", "btnReports" };
            string[] adminButtons = { "btnUsers", "btnReports" };

            string[] toShow = _currentUser.Role switch
            {
                "nurse" => nurseButtons,
                "doctor" => doctorButtons,
                "admin" => adminButtons,
                _ => Array.Empty<string>()
            };

            foreach (var name in toShow)
                _navButtons[name].Visible = true;
        }

        private void ShowStartScreen()
        {
            switch (_currentUser.Role)
            {
                case "nurse": ShowControl(_nurseDash, _navButtons["btnDashboard"]); break;
                case "doctor": ShowControl(_doctorDash, _navButtons["btnDashboard"]); break;
                case "admin": ShowControl(_adminDash, _navButtons["btnDashboard"]); break;
            }
        }

        private void ShowControl(Control control, Button button)
        {
            if (control == null) return;
            if (_activeControl != null) _activeControl.Visible = false;
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.Transparent;
                _activeButton.ForeColor = _sidebarButtonColor;
            }
            control.Visible = true;
            control.BringToFront();
            button.BackColor = _sidebarButtonActiveColor;
            button.ForeColor = Color.White;
            _activeControl = control;
            _activeButton = button;
            HighlightActiveButton(button);
        }

        private void btnDashboard_Click(object s, EventArgs e)
          => ShowStartScreen();
        private void btnPatients_Click(object s, EventArgs e)
          => ShowControl(_patients, _navButtons["btnPatients"]);
        private void btnUsers_Click(object s, EventArgs e)
          => ShowControl(_userMgmt, _navButtons["btnUsers"]);

        private void NavButton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is not Button button) return;
            if (button == _activeButton) return;
            button.BackColor = _sidebarButtonHoverColor;
        }

        private void NavButton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is not Button button) return;
            if (button == _activeButton) return;
            button.BackColor = Color.Transparent;
        }

        private void LogoutButton_MouseEnter(object? sender, EventArgs e)
            => btnLogout.BackColor = _sidebarButtonHoverColor;

        private void LogoutButton_MouseLeave(object? sender, EventArgs e)
            => btnLogout.BackColor = Color.Transparent;

        private void HighlightActiveButton(Button button)
        {
            pnlSide.Visible = true;
            pnlSidebar.SetRow(pnlSide, pnlSidebar.GetRow(button));
            pnlSide.BringToFront();
        }

        public void NavigateTo(string screen, int? id = null)
        {
            switch (screen)
            {
                case "patients":
                    ShowControl(_patients, _navButtons["btnPatients"]); break;
                case "patientrecord":
                    if (id.HasValue) _patientRecord.LoadPatient(id.Value);
                    ShowControl(_patientRecord, _navButtons["btnPatients"]); break;
                case "consultation":
                    if (id.HasValue) _consultation.LoadPatient(id.Value);
                    ShowControl(_consultation, _navButtons["btnConsult"]); break;
                case "vitals":
                    if (id.HasValue) _vitals.LoadPatient(id.Value);
                    ShowControl(_vitals, _navButtons["btnVitals"]); break;
                case "prescription":
                    if (id.HasValue) _prescription.LoadConsultation(id.Value);
                    else _prescription.ResetForStandalone();
                    ShowControl(_prescription, _navButtons["btnRx"]); break;
                case "medhistory":
                    if (id.HasValue) _medHistory.LoadPatient(id.Value);
                    ShowControl(_medHistory, _navButtons["btnMedHistory"]); break;
                case "reports":
                    ShowControl(_report, _navButtons["btnReports"]); break;
            }
        }

        public void RefreshPatientViews(int? selectedPatientId = null)
        {
            _patients?.LoadPatients();
            _patientRecord?.RefreshPatients(selectedPatientId);
            _vitals?.RefreshPatients(selectedPatientId);
            _medHistory?.RefreshPatients(selectedPatientId);
            _consultation?.RefreshPatients(selectedPatientId);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
              "Are you sure you want to log out?",
              "Log Out", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Close();
            }
        }
    }
}
