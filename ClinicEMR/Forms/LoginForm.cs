using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;

namespace ClinicEMR
{
    public partial class LoginForm : Form
    {
        private static readonly TimeSpan LoginCooldown = TimeSpan.FromMinutes(1);
        private readonly System.Windows.Forms.Timer _cooldownTimer = new();
        private DateTime? _lockoutEndsAt;
        private bool _isLoggingIn;

        public LoginForm()
        {
            InitializeComponent();
            WireFormActions();
            _cooldownTimer.Interval = 1000;
            _cooldownTimer.Tick += CooldownTimer_Tick;
            pictureBox2.SendToBack();
            ThemeService.ApplyRoundedCorners(tableLayoutPanel3, 5);
            ThemeService.ApplyRoundedCorners(tableLayoutPanel2, 5);
        }

        private int _failCount = 0;

        private void WireFormActions()
        {
            btnLogin.Click -= btnLogIn_Click;
            btnLogin.Click += btnLogIn_Click;

            lnkAccountRecovery.LinkClicked -= lnkAccountRecovery_LinkClicked;
            lnkAccountRecovery.LinkClicked += lnkAccountRecovery_LinkClicked;

            txtUsername.TabStop = true;
            txtPassword.TabStop = true;
        }

        private void btnLogIn_Click(object? sender, EventArgs e)
        {
            if (_isLoggingIn)
            {
                return;
            }

            _isLoggingIn = true;

            try
            {
            if (_lockoutEndsAt.HasValue && _lockoutEndsAt.Value > DateTime.Now)
            {
                UpdateCooldownMessage();
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            var user = LoginService.Authenticate(username, password);

            if (user == null)
            {
                _failCount++;
                if (_failCount >= 5)
                {
                    btnLogin.Enabled = false;
                    _lockoutEndsAt = DateTime.Now.Add(LoginCooldown);
                    UpdateCooldownMessage();
                    lblError.Visible = true;
                    _cooldownTimer.Start();
                    return;
                }

                lblError.Visible = false;
                MessageBox.Show("Invalid username or password.");
                return;
            }

            _failCount = 0;
            lblError.Visible = false;

            if (!EnsureRecoveryConfigured(user))
            {
                return;
            }

            var shell = new MainShellForm(user);
            shell.Show();
            this.Hide();
            }
            finally
            {
                _isLoggingIn = false;
            }
        }

        private void LoginForm_Load(object? sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _cooldownTimer.Stop();
            _cooldownTimer.Tick -= CooldownTimer_Tick;
            base.OnFormClosed(e);
        }

        private void LoginForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogIn_Click(sender, e);
            }
        }

        private bool EnsureRecoveryConfigured(User user)
        {
            if (UserService.HasRecoveryConfigured(user.UserId))
            {
                return true;
            }

            MessageBox.Show(
                "This account does not have a local recovery setup yet. Please add one now so it can be recovered without email.",
                "Recovery Setup Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            using var form = new AccountRecoverySetupForm(user.FullName, user.Username);
            if (form.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show(
                    "Recovery setup was cancelled. Sign-in will stay on the login screen until recovery is configured.",
                    "Recovery Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                UserService.ConfigureRecovery(user.UserId, form.RecoveryQuestion, form.RecoveryAnswer, user.UserId);
                MessageBox.Show("Account recovery has been saved.", "Recovery Ready",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Recovery", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void lnkAccountRecovery_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using var form = new AccountRecoveryForm();
            form.ShowDialog(this);
        }

        private void CooldownTimer_Tick(object? sender, EventArgs e)
        {
            if (!_lockoutEndsAt.HasValue)
            {
                _cooldownTimer.Stop();
                return;
            }

            if (_lockoutEndsAt.Value <= DateTime.Now)
            {
                _cooldownTimer.Stop();
                _lockoutEndsAt = null;
                _failCount = 0;
                btnLogin.Enabled = true;
                lblError.Visible = false;
                return;
            }

            UpdateCooldownMessage();
        }

        private void UpdateCooldownMessage()
        {
            if (!_lockoutEndsAt.HasValue)
            {
                return;
            }

            TimeSpan remaining = _lockoutEndsAt.Value - DateTime.Now;
            if (remaining < TimeSpan.Zero)
            {
                remaining = TimeSpan.Zero;
            }

            lblError.Text = $"Too many failed attempts. Try again in {remaining:mm\\:ss}.";
            lblError.Visible = true;
        }

    }
}
