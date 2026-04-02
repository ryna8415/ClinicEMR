using ClinicEMR.Data;
using MySql.Data.MySqlClient;

namespace ClinicEMR
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var connection = DatabaseHelper.GetConnection();
            if (connection == null)
            {
                MessageBox.Show("Failed to create DB connection.");
                return;
            }

            using (MySqlConnection connection2 = connection)
            {
                connection2.Open();
                MessageBox.Show("Connected!");
            }
        }
    }
}