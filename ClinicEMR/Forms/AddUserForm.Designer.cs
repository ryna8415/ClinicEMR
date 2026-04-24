namespace ClinicEMR.Forms
{
    partial class AddUserForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            pnlBackground = new Panel();
            pictureBox1 = new PictureBox();
            lblNewUser = new Label();
            pnlContainer = new Panel();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblFullNameError = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblUsernameError = new Label();
            lblRole = new Label();
            cboRole = new ComboBox();
            lblRoleError = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblPasswordError = new Label();
            btnCancel = new ReaLTaiizor.Controls.Button();
            btnSave = new ReaLTaiizor.Controls.Button();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(pictureBox1);
            pnlBackground.Controls.Add(lblNewUser);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(384, 510);
            pnlBackground.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 98);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblNewUser
            // 
            lblNewUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblNewUser.BackColor = Color.FromArgb(49, 62, 80);
            lblNewUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNewUser.ForeColor = Color.White;
            lblNewUser.Location = new Point(3, 124);
            lblNewUser.Name = "lblNewUser";
            lblNewUser.Size = new Size(384, 45);
            lblNewUser.TabIndex = 0;
            lblNewUser.Text = "  Add New User";
            lblNewUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Controls.Add(lblFullName);
            pnlContainer.Controls.Add(txtFullName);
            pnlContainer.Controls.Add(lblFullNameError);
            pnlContainer.Controls.Add(lblUsername);
            pnlContainer.Controls.Add(txtUsername);
            pnlContainer.Controls.Add(lblUsernameError);
            pnlContainer.Controls.Add(lblRole);
            pnlContainer.Controls.Add(cboRole);
            pnlContainer.Controls.Add(lblRoleError);
            pnlContainer.Controls.Add(lblPassword);
            pnlContainer.Controls.Add(txtPassword);
            pnlContainer.Controls.Add(lblPasswordError);
            pnlContainer.Controls.Add(btnCancel);
            pnlContainer.Controls.Add(btnSave);
            pnlContainer.Location = new Point(12, 169);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(360, 329);
            pnlContainer.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 9F);
            lblFullName.ForeColor = Color.FromArgb(49, 62, 80);
            lblFullName.Location = new Point(10, 15);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 17);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9F);
            txtFullName.Location = new Point(10, 35);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(330, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblFullNameError
            // 
            lblFullNameError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblFullNameError.ForeColor = Color.Firebrick;
            lblFullNameError.Location = new Point(10, 60);
            lblFullNameError.Name = "lblFullNameError";
            lblFullNameError.Size = new Size(330, 30);
            lblFullNameError.TabIndex = 2;
            lblFullNameError.Visible = false;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 9F);
            lblUsername.ForeColor = Color.FromArgb(49, 62, 80);
            lblUsername.Location = new Point(10, 90);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 17);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(10, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 4;
            // 
            // lblUsernameError
            // 
            lblUsernameError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblUsernameError.ForeColor = Color.Firebrick;
            lblUsernameError.Location = new Point(10, 135);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(200, 30);
            lblUsernameError.TabIndex = 5;
            lblUsernameError.Visible = false;
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Segoe UI", 9F);
            lblRole.ForeColor = Color.FromArgb(49, 62, 80);
            lblRole.Location = new Point(220, 90);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 17);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role:";
            // 
            // cboRole
            // 
            cboRole.Font = new Font("Segoe UI", 9F);
            cboRole.Items.AddRange(new object[] { "doctor", "nurse", "admin" });
            cboRole.Location = new Point(220, 110);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(120, 23);
            cboRole.TabIndex = 7;
            // 
            // lblRoleError
            // 
            lblRoleError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblRoleError.ForeColor = Color.Firebrick;
            lblRoleError.Location = new Point(220, 135);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(120, 30);
            lblRoleError.TabIndex = 8;
            lblRoleError.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.FromArgb(49, 62, 80);
            lblPassword.Location = new Point(10, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 17);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(10, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(330, 23);
            txtPassword.TabIndex = 10;
            // 
            // lblPasswordError
            // 
            lblPasswordError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblPasswordError.ForeColor = Color.Firebrick;
            lblPasswordError.Location = new Point(10, 210);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(330, 72);
            lblPasswordError.TabIndex = 11;
            lblPasswordError.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(226, 230, 237);
            btnCancel.BorderColor = Color.FromArgb(108, 111, 127);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnCancel.EnteredColor = Color.FromArgb(69, 85, 97);
            btnCancel.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnCancel.Image = null;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.InactiveColor = Color.FromArgb(92, 102, 114);
            btnCancel.Location = new Point(140, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(226, 230, 237);
            btnSave.BorderColor = Color.FromArgb(108, 111, 127);
            btnSave.Cursor = Cursors.Hand;
            btnSave.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnSave.EnteredColor = Color.FromArgb(69, 85, 97);
            btnSave.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(26, 35, 48);
            btnSave.Location = new Point(250, 285);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSave.PressedColor = Color.FromArgb(165, 37, 37);
            btnSave.Size = new Size(90, 30);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save User";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // AddUserForm
            // 
            ClientSize = new Size(384, 510);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);


        }

        private Panel pnlBackground;
        private Panel pnlContainer;

        private Label lblNewUser;

        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblFullNameError;

        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblUsernameError;

        private Label lblRole;
        private ComboBox cboRole;
        private Label lblRoleError;

        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblPasswordError;

        private ReaLTaiizor.Controls.Button btnSave;
        private ReaLTaiizor.Controls.Button btnCancel;
        private PictureBox pictureBox1;
    }
}