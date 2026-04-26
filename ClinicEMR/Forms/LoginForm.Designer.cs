using ClinicEMR.Services;

namespace ClinicEMR
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Panel pnlBackground;
        private RoundedPanel pnlContainer;
        private Label lblTitle;
        private PictureBox pictureBox1;

        private Label lblUsername;
        private RoundedTextBox txtUsername;
        private Label lblPassword;
        private RoundedTextBox txtPassword;
        private Label lblError;

        private ReaLTaiizor.Controls.Button btnLogin;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlBackground = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pnlContainer = new RoundedPanel();
            lblUsername = new Label();
            txtUsername = new RoundedTextBox();
            lblPassword = new Label();
            txtPassword = new RoundedTextBox();
            lblError = new Label();
            btnLogin = new ReaLTaiizor.Controls.Button();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(pictureBox1);
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(300, 363);
            pnlBackground.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 90);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 110);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ClinicEMR";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Controls.Add(lblUsername);
            pnlContainer.Controls.Add(txtUsername);
            pnlContainer.Controls.Add(lblPassword);
            pnlContainer.Controls.Add(txtPassword);
            pnlContainer.Controls.Add(lblError);
            pnlContainer.Controls.Add(btnLogin);
            pnlContainer.Location = new Point(20, 160);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(260, 184);
            pnlContainer.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.ForeColor = Color.FromArgb(49, 62, 80);
            lblUsername.Location = new Point(13, 14);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(14, 34);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(6, 4, 6, 4);
            txtUsername.Size = new Size(230, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.FromArgb(49, 62, 80);
            lblPassword.Location = new Point(13, 64);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 17);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            ((RoundedTextBox)this.txtPassword).UseSystemPasswordChar = true;
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(14, 84);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(6, 4, 6, 4);
            txtPassword.Size = new Size(230, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(10, 109);
            lblError.Name = "lblError";
            lblError.Size = new Size(230, 30);
            lblError.TabIndex = 4;
            lblError.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(32, 34, 37);
            btnLogin.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnLogin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F);
            btnLogin.Image = null;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.InactiveColor = Color.FromArgb(32, 34, 37);
            btnLogin.Location = new Point(79, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLogin.PressedColor = Color.FromArgb(165, 37, 37);
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log In";
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.Click += btnLogIn_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(300, 363);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClinicEMR Login";
            Load += LoginForm_Load;
            KeyDown += LoginForm_KeyDown;
            pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContainer.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}