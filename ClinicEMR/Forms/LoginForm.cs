using ClinicEMR.Forms;
using ClinicEMR.Services;
using MySql.Data.MySqlClient;

namespace ClinicEMR
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ThemeService.ApplyTheme(this);
        }

        private int _failCount = 0;

        private void btnLogIn_Click(object sender, EventArgs e)
        {
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
                    btnLogIn.Enabled = false;
                    lblError.Text = "Too many failed attempts. Please restart the app.";
                    lblError.Visible = true;
                    return;
                }

                lblError.Visible = false;
                MessageBox.Show("Invalid username or password.");
                return;
            }

            _failCount = 0;
            lblError.Visible = false;

            var shell = new MainShellForm(user);
            shell.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
