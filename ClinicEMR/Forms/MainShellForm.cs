using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClinicEMR.Models;
using ClinicEMR.UserControls;

namespace ClinicEMR.Forms
{

    public partial class MainShellForm : Form
    {
        private Dictionary<string, Button> _navButtons;

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

        private NurseDashboardControl _nurseDash;
        private DoctorDashboardControl _doctorDash;
        private AdminDashboardControl _adminDash;

        private PatientListControl _patients;
        private UserManagementControl _userMgmt;
        private AppointmentControl _appointments;
        private VitalsControl _vitals;
        private PrescriptionControl _prescription;
        private ConsultationControl _consultation;
        private MedHistoryControl _medHistory;
        private PatientRecordControl _patientRecord;
        private ReportControl _report;

        private Control _activeControl;
        private Button _activeButton;

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
            pnlSidebar.Controls.Clear();
            pnlSidebar.Width = 210;
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.BackColor = Color.FromArgb(13, 43, 69);

            var sep = new Panel
            {
                Location = new Point(16, 86),
                Height = 1,
                Margin = new Padding(10, 8, 16, 8),
                BackColor = Color.FromArgb(255, 255, 255, 20)
            };

            var sep2 = new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                Margin = new Padding(10, 8, 16, 8),
                BackColor = Color.FromArgb(255, 255, 255, 20)
            };

            var sep3 = new Panel
            {
                Dock = DockStyle.Top,
                Height = 1,
                Margin = new Padding(10, 8, 16, 8),
                BackColor = Color.FromArgb(255, 255, 255, 20)
            };

            var lblSubtitle = new Label
            {
                Text = "Small Clinic EMR",
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(100, 160, 200),
                AutoSize = false,
                Size = new Size(210, 22),
                Location = new Point(0, 56),
                Padding = new Padding(16, 0, 0, 0),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var spacer = new Panel
            {
                Dock = DockStyle.Top,
                Height = 12,
                BackColor = Color.Transparent
            };

            var spacer2 = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                BackColor = Color.Transparent
            };

            var lblTitle = new Label
            {
                Text = "ClinicEMR",
                Font = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(210, 40),
                Location = new Point(0, 16),
                Padding = new Padding(16, 16, 0, 0),
                TextAlign = ContentAlignment.MiddleLeft
            };

            pnlSidebar.Controls.AddRange(new Control[] {
                lblTitle,
                lblSubtitle,
                sep,
                spacer
            });

            var navItems = new[] {
                ("btnDashboard", "  Dashboard",    210),
                ("btnPatients",  "  Patients",     238),
                ("btnAppts",     "  Appointments", 280),
                ("btnVitals",    "  Vital Signs",  322),
                ("btnConsult",   "  Consultation", 364),
                ("btnMedHistory", "  Med History", 390),
                ("btnRx",        "  Prescription", 406),
                ("btnReports",   "  Reports",      448),
                ("btnUsers",     "  User Accounts",90),
            };

            _navButtons = new Dictionary<string, Button>();

            foreach (var (name, text, y) in navItems)
            {
                var btn = new Button
                {
                    Name = name,
                    Text = text,
                    Size = new Size(210, 40),
                    Location = new Point(0, y),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    ForeColor = Color.FromArgb(160, 190, 220),
                    Font = new Font("Segoe UI", 9.5f),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Cursor = Cursors.Hand,
                    UseVisualStyleBackColor = false,
                    Visible = false
                };
                btn.FlatAppearance.BorderSize = 0;
                btn.Click += NavButton_Click;
                _navButtons[name] = btn;
                pnlSidebar.Controls.Add(btn);
            }

            var lblUserName = new Label
            {
                Text = _currentUser.FullName,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(210, 22),
                Location = new Point(0, 290),
                Padding = new Padding(16, 0, 0, 0),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            var lblUserRole = new Label
            {
                Text = char.ToUpper(_currentUser.Role[0]) + _currentUser.Role.Substring(1),
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.FromArgb(100, 160, 200),
                AutoSize = false,
                Size = new Size(210, 20),
                Location = new Point(0, 268),
                Padding = new Padding(16, 0, 0, 0),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            var btnLogout = new Button
            {
                Text = "  Log Out",
                Size = new Size(210, 36),
                Location = new Point(0, 244),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(160, 190, 220),
                Font = new Font("Segoe UI", 9f),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                UseVisualStyleBackColor = false
            };
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Click += btnLogout_Click;

            pnlSidebar.Controls.AddRange(new Control[] {
                spacer2, sep2, lblUserName, lblUserRole, sep3, btnLogout
            });
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
                _activeButton.ForeColor = Color.FromArgb(160, 190, 220);
            }
            control.Visible = true;
            control.BringToFront();
            button.BackColor = Color.FromArgb(30, 95, 165);
            button.ForeColor = Color.White;
            _activeControl = control;
            _activeButton = button;
        }

        private void btnDashboard_Click(object s, EventArgs e)
          => ShowStartScreen();
        private void btnPatients_Click(object s, EventArgs e)
          => ShowControl(_patients, _navButtons["btnPatients"]);
        private void btnUsers_Click(object s, EventArgs e)
          => ShowControl(_userMgmt, _navButtons["btnUsers"]);

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
