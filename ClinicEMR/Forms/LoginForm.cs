using ClinicEMR.Data;

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
            DatabaseHelper.GetConnection(); MessageBox.Show("Connected!");
        }
    }
}
