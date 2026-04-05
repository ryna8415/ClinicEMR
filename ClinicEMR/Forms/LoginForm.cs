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
        }

        private int _failCount = 0;


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Step 1: Get input
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Step 2: Validate
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // Step 3: Call service
            var user = LoginService.Authenticate(username, password);

            // Step 4: Handle result
            if (user == null)
            {
                _failCount++;
                if (_failCount >= 5)
                {
                    btnLogIn.Enabled = false;
                    lblError.Text = "Account locked. Restart app.";
                    lblError.Visible = true; return;
                }
                MessageBox.Show("Invalid username or password.");
                return;
            }

            // Open the single shell form -- Day 3 creates this
            var shell = new MainShellForm(user);
            shell.Show();
            this.Hide();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
