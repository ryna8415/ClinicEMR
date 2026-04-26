using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClinicEMR.Helpers;
using ClinicEMR.Models;
using ClinicEMR.Services;
using ClinicEMR.UserControls;

namespace ClinicEMR.Forms
{

    public partial class MainShellForm : Form
    {
        private static readonly TimeSpan SessionTimeout = TimeSpan.FromMinutes(15);
        private Dictionary<string, Button> _navButtons = new();
        private readonly Color _sidebarButtonColor = UITheme.SidebarText;
        private readonly Color _sidebarButtonHoverColor = UITheme.SidebarHover;
        private readonly Color _sidebarButtonActiveColor = UITheme.SidebarActive;
        private readonly SessionActivityMessageFilter _activityFilter = new();
        private readonly System.Windows.Forms.Timer _sessionTimer = new();
        private readonly System.Windows.Forms.Timer _clockTimer = new();
        private DateTime _lastActivityUtc = DateTime.UtcNow;
        private bool _isShuttingDownSession;
        private string CurrentRole => _currentUser.Role?.Trim() ?? string.Empty;

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
            BuildControls();
            BuildSidebar();
            ApplyRolePermissions();
            ShowStartScreen();
            ThemeService.ApplyRoundedCorners(pnlContent, 10);
            KeyPreview = true;
            Shown += MainShellForm_Shown;
            FormClosed += MainShellForm_FormClosed;
            ConfigureRoleBadge();
            InitializeHeaderClock();
            InitializeSessionTimeout();

        }

        private void MainShellForm_Shown(object? sender, EventArgs e)
        {
            btnLogout.TabStop = false;

            foreach (var button in _navButtons.Values)
            {
                button.TabStop = false;
            }

            ActiveControl = null;
            pnlContent.Focus();
        }

        private void InitializeSessionTimeout()
        {
            _activityFilter.ActivityDetected += SessionActivityFilter_ActivityDetected;
            Application.AddMessageFilter(_activityFilter);

            _sessionTimer.Interval = 30000;
            _sessionTimer.Tick += SessionTimer_Tick;
            _sessionTimer.Start();
            RegisterActivity();
        }

        private void SessionActivityFilter_ActivityDetected(object? sender, EventArgs e)
        {
            RegisterActivity();
        }

        private void SessionTimer_Tick(object? sender, EventArgs e)
        {
            if (_isShuttingDownSession)
            {
                return;
            }

            if (DateTime.UtcNow - _lastActivityUtc >= SessionTimeout)
            {
                Logout(true);
            }
        }

        private void RegisterActivity()
        {
            _lastActivityUtc = DateTime.UtcNow;
        }

        private void MainShellForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _sessionTimer.Stop();
            _sessionTimer.Tick -= SessionTimer_Tick;
            _clockTimer.Stop();
            _clockTimer.Tick -= ClockTimer_Tick;
            _activityFilter.ActivityDetected -= SessionActivityFilter_ActivityDetected;
            Application.RemoveMessageFilter(_activityFilter);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && (btnLogout.Focused || btnLogout.ContainsFocus || IsSidebarButtonFocused()))
            {
                if (_activeControl != null && _activeControl.CanFocus)
                {
                    _activeControl.Focus();
                }
                else
                {
                    ActiveControl = null;
                    pnlContent.Focus();
                }

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool IsSidebarButtonFocused()
        {
            foreach (var button in _navButtons.Values)
            {
                if (button.Focused || button.ContainsFocus)
                {
                    return true;
                }
            }

            return false;
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
            lblUserRole.Text = FormatRoleLabel();
            lblUserName.ForeColor = Color.White;
            lblUserRole.ForeColor = Color.FromArgb(202, 219, 233);

            ConfigureSidebarIndicator();

            foreach (var button in _navButtons.Values)
            {
                button.Visible = false;
                ThemeService.StyleSidebarButton(button);
                button.ForeColor = _sidebarButtonColor;
                button.Click -= NavButton_Click;
                button.Click += NavButton_Click;
                button.MouseEnter -= NavButton_MouseEnter;
                button.MouseEnter += NavButton_MouseEnter;
                button.MouseLeave -= NavButton_MouseLeave;
                button.MouseLeave += NavButton_MouseLeave;
            }

            ThemeService.StyleSidebarButton(btnLogout);
            btnLogout.ForeColor = _sidebarButtonColor;
            btnLogout.Click -= btnLogout_Click;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter -= LogoutButton_MouseEnter;
            btnLogout.MouseEnter += LogoutButton_MouseEnter;
            btnLogout.MouseLeave -= LogoutButton_MouseLeave;
            btnLogout.MouseLeave += LogoutButton_MouseLeave;

            pnlSide.Visible = false;
        }

        private void ConfigureSidebarIndicator()
        {
            // Keep the indicator from affecting AutoSize row measurements.
            pnlSide.Dock = DockStyle.None;
            pnlSide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlSide.Margin = new Padding(0);
            pnlSide.Size = new Size(6, ThemeService.Sizes.ButtonHeight);
            pnlSide.BringToFront();
        }

        private void BuildControls()
        {
            if (string.Equals(CurrentRole, "nurse", StringComparison.OrdinalIgnoreCase))
                _nurseDash = new NurseDashboardControl(_currentUser);
            if (string.Equals(CurrentRole, "doctor", StringComparison.OrdinalIgnoreCase))
                _doctorDash = new DoctorDashboardControl(_currentUser);
            if (string.Equals(CurrentRole, "admin", StringComparison.OrdinalIgnoreCase))
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

            string[] toShow = GetRoleButtons(nurseButtons, doctorButtons, adminButtons);

            foreach (var name in toShow)
                _navButtons[name].Visible = true;
        }

        private void ShowStartScreen()
        {
            SetHeaderContent(GetDashboardHeaderText(), btnDashboard.Image);
            switch (CurrentRole.ToLowerInvariant())
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
                _activeButton.Tag = ThemeService.SidebarButtonTag;
                _activeButton.BackColor = Color.Transparent;
                _activeButton.ForeColor = _sidebarButtonColor;
            }
            control.Visible = true;
            control.BringToFront();
            button.Tag = ThemeService.ActiveSidebarButtonTag;
            button.BackColor = _sidebarButtonActiveColor;
            button.ForeColor = Color.White;
            _activeControl = control;
            _activeButton = button;
            HighlightActiveButton(button);
            UpdateHeaderForButton(button);
        }

        private void UpdateHeaderForButton(Button button)
        {
            if (button == btnDashboard)
            {
                SetHeaderContent(GetDashboardHeaderText(), null);
                lblIntro.Text = GetHeaderDescription(button.Name);
                return;
            }

            SetHeaderContent(button.Text.Trim(), button.Image);
            lblIntro.Text = GetHeaderDescription(button.Name);
        }

        private string GetDashboardHeaderText()
        {
            return $"Hello, {_currentUser.FullName}";
        }

        private void SetHeaderContent(string headerText, Image? headerImage)
        {
            btnHeader.Text = headerText;
            Header.Text = string.Empty;
            Header.Image = null;
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
                case "consultationedit":
                    if (id.HasValue) _consultation.LoadConsultation(id.Value);
                    ShowControl(_consultation, _navButtons["btnConsult"]); break;
                case "vitals":
                    if (id.HasValue) _vitals.LoadPatient(id.Value);
                    ShowControl(_vitals, _navButtons["btnVitals"]); break;
                case "prescription":
                    if (id.HasValue) _prescription.LoadConsultation(id.Value);
                    else _prescription.ResetForStandalone();
                    ShowControl(_prescription, _navButtons["btnRx"]); break;
                case "prescriptionedit":
                    if (id.HasValue) _prescription.LoadPrescription(id.Value);
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
                Logout(false);
            }
        }

        private void Logout(bool dueToTimeout)
        {
            if (_isShuttingDownSession)
            {
                return;
            }

            _isShuttingDownSession = true;
            _sessionTimer.Stop();

            try
            {
                AuditLogService.Log(_currentUser.UserId, dueToTimeout ? "Session timed out." : "Logged out.");
            }
            catch
            {
            }

            if (dueToTimeout)
            {
                MessageBox.Show(
                    "Your session timed out due to inactivity. Please log in again.",
                    "Session Timeout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            new LoginForm().Show();
            Close();
        }

        private string[] GetRoleButtons(string[] nurseButtons, string[] doctorButtons, string[] adminButtons)
        {
            if (string.Equals(CurrentRole, "nurse", StringComparison.OrdinalIgnoreCase))
            {
                return nurseButtons;
            }

            if (string.Equals(CurrentRole, "doctor", StringComparison.OrdinalIgnoreCase))
            {
                return doctorButtons;
            }

            if (string.Equals(CurrentRole, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return adminButtons;
            }

            return Array.Empty<string>();
        }

        private string FormatRoleLabel()
        {
            if (string.IsNullOrWhiteSpace(CurrentRole))
            {
                return "Unknown";
            }

            return char.ToUpper(CurrentRole[0]) + CurrentRole.Substring(1).ToLowerInvariant();
        }

        private void InitializeHeaderClock()
        {
            _clockTimer.Interval = 1000;
            _clockTimer.Tick += ClockTimer_Tick;
            UpdateHeaderDateTime();
            _clockTimer.Start();
        }

        private void ClockTimer_Tick(object? sender, EventArgs e)
        {
            UpdateHeaderDateTime();
        }

        private void UpdateHeaderDateTime()
        {
            DateTime now = DateTime.Now;
            lblDate.Text = now.ToString("dddd, MMMM d, yyyy");
            lblTime.Text = now.ToString("HH:mm:ss");
        }

        private void ConfigureRoleBadge()
        {
            Color inactiveColor;
            Color foreColor;
            string roleText = FormatRoleLabel();

            switch (CurrentRole.ToLowerInvariant())
            {
                case "nurse":
                    inactiveColor = Color.FromArgb(192, 228, 252);
                    foreColor = Color.FromArgb(92, 143, 204);
                    roleText = "Nurse";
                    break;
                case "doctor":
                    inactiveColor = Color.FromArgb(200, 250, 202);
                    foreColor = Color.FromArgb(74, 168, 122);
                    roleText = "Doctor";
                    break;
                case "admin":
                    inactiveColor = Color.FromArgb(217, 189, 240);
                    foreColor = Color.FromArgb(91, 33, 182);
                    roleText = "Admin";
                    break;
                default:
                    inactiveColor = Color.FromArgb(226, 230, 237);
                    foreColor = Color.FromArgb(92, 102, 114);
                    break;
            }

            btnBMI.Text = roleText;
            btnBMI.BackColor = Color.FromArgb(37, 45, 56);
            btnBMI.InactiveColor = inactiveColor;
            btnBMI.ForeColor = foreColor;
            btnBMI.BorderColor = foreColor;
            btnBMI.EnteredColor = Color.Transparent;
            btnBMI.PressedColor = Color.Transparent;
            btnBMI.EnteredBorderColor = foreColor;
            btnBMI.PressedBorderColor = foreColor;
        }

        private static string GetHeaderDescription(string buttonName)
        {
            return buttonName switch
            {
                "btnDashboard" => "Overview your Clinic's records, status, and updates.",
                "btnPatients" => "Browse and open patient records.",
                "btnAppts" => "Manage daily appointments and schedules.",
                "btnVitals" => "Record and review patient vital signs.",
                "btnConsult" => "Review and update consultation details.",
                "btnRx" => "Create and manage patient prescriptions.",
                "btnMedHistory" => "View, edit and update patient records.",
                "btnReports" => "Generate and print daily clinic reports.",
                "btnUsers" => "Manage staff access and account settings.",
                _ => string.Empty
            };
        }

    }
}
