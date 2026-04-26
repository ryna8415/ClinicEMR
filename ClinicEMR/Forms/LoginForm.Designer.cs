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
        private Label lblTitle;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pnlBackground = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            lblTitle = new Label();
            pictureBox5 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel16 = new Panel();
            label3 = new Label();
            btnLogin = new ReaLTaiizor.Controls.Button();
            lnkAccountRecovery = new LinkLabel();
            label4 = new Label();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            txtUsername = new ReaLTaiizor.Controls.HopeTextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblError = new Label();
            pictureBox2 = new PictureBox();
            pnlBackground.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(tableLayoutPanel2);
            pnlBackground.Controls.Add(pictureBox2);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1004, 567);
            pnlBackground.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(37, 45, 56);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Location = new Point(276, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 117F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(455, 513);
            tableLayoutPanel2.TabIndex = 43;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 336F));
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox5, 0, 0);
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(435, 97);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label5.ForeColor = Color.FromArgb(92, 102, 114);
            label5.Location = new Point(109, 56);
            label5.Margin = new Padding(10, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(300, 31);
            label5.TabIndex = 56;
            label5.Text = "Digital Medical Record System";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Panton-Trial ExtraBold", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(197, 202, 212);
            lblTitle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitle.Location = new Point(102, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(136, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ClinicKa";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            tableLayoutPanel1.SetRowSpan(pictureBox5, 2);
            pictureBox5.Size = new Size(99, 97);
            pictureBox5.TabIndex = 42;
            pictureBox5.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(49, 62, 80);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel16, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 117);
            tableLayoutPanel3.Margin = new Padding(10, 0, 10, 10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(435, 386);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.Bottom;
            panel16.BackColor = Color.FromArgb(49, 62, 80);
            panel16.Controls.Add(label3);
            panel16.Controls.Add(btnLogin);
            panel16.Controls.Add(lnkAccountRecovery);
            panel16.Controls.Add(label4);
            panel16.Controls.Add(txtPassword);
            panel16.Controls.Add(txtUsername);
            panel16.Controls.Add(pictureBox4);
            panel16.Controls.Add(pictureBox3);
            panel16.Controls.Add(label1);
            panel16.Controls.Add(label2);
            panel16.Controls.Add(lblError);
            panel16.Location = new Point(3, 13);
            panel16.Margin = new Padding(3, 3, 3, 10);
            panel16.Name = "panel16";
            panel16.Size = new Size(429, 363);
            panel16.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Panton-Trial ExtraBold", 18F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(197, 202, 212);
            label3.Location = new Point(64, -7);
            label3.Name = "label3";
            label3.Size = new Size(240, 40);
            label3.TabIndex = 54;
            label3.Text = "Welcome Back!";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.FromArgb(26, 35, 48);
            btnLogin.EnteredBorderColor = Color.FromArgb(26, 35, 48);
            btnLogin.EnteredColor = Color.FromArgb(69, 85, 97);
            btnLogin.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnLogin.Image = null;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.InactiveColor = Color.FromArgb(26, 35, 48);
            btnLogin.Location = new Point(115, 268);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedBorderColor = Color.FromArgb(22, 101, 52);
            btnLogin.PressedColor = Color.FromArgb(22, 101, 52);
            btnLogin.Size = new Size(200, 50);
            btnLogin.TabIndex = 47;
            btnLogin.Text = "Log In";
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.Click += btnLogIn_Click;
            // 
            // lnkAccountRecovery
            // 
            lnkAccountRecovery.AutoSize = true;
            lnkAccountRecovery.BackColor = Color.Transparent;
            lnkAccountRecovery.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lnkAccountRecovery.ForeColor = Color.FromArgb(26, 35, 48);
            lnkAccountRecovery.LinkColor = Color.FromArgb(92, 102, 114);
            lnkAccountRecovery.Location = new Point(150, 321);
            lnkAccountRecovery.Name = "lnkAccountRecovery";
            lnkAccountRecovery.Size = new Size(134, 21);
            lnkAccountRecovery.TabIndex = 46;
            lnkAccountRecovery.TabStop = true;
            lnkAccountRecovery.Text = "Recover Account";
            lnkAccountRecovery.LinkClicked += lnkAccountRecovery_LinkClicked;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label4.ForeColor = Color.FromArgb(92, 102, 114);
            label4.Location = new Point(70, 27);
            label4.Name = "label4";
            label4.Size = new Size(300, 31);
            label4.TabIndex = 55;
            label4.Text = "Log in to continue your work progress";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(197, 202, 212);
            txtPassword.BaseColor = Color.FromArgb(108, 111, 127);
            txtPassword.BorderColorA = Color.FromArgb(108, 111, 127);
            txtPassword.BorderColorB = Color.FromArgb(108, 111, 127);
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("TT Interphases Pro Trl", 10F);
            txtPassword.ForeColor = Color.FromArgb(26, 35, 48);
            txtPassword.Hint = "";
            txtPassword.Location = new Point(70, 184);
            txtPassword.Margin = new Padding(3, 3, 0, 3);
            txtPassword.MaxLength = 64;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(336, 37);
            txtPassword.TabIndex = 53;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.BackColor = Color.FromArgb(197, 202, 212);
            txtUsername.BaseColor = Color.FromArgb(108, 111, 127);
            txtUsername.BorderColorA = Color.FromArgb(108, 111, 127);
            txtUsername.BorderColorB = Color.FromArgb(108, 111, 127);
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("TT Interphases Pro Trl", 10F);
            txtUsername.ForeColor = Color.FromArgb(26, 35, 48);
            txtUsername.Hint = "";
            txtUsername.Location = new Point(70, 101);
            txtUsername.Margin = new Padding(3, 3, 0, 3);
            txtUsername.MaxLength = 30;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.Size = new Size(336, 37);
            txtUsername.TabIndex = 52;
            txtUsername.TabStop = false;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 183);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 100);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 50;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label1.ForeColor = Color.FromArgb(92, 102, 114);
            label1.Location = new Point(69, 74);
            label1.Name = "label1";
            label1.Size = new Size(149, 18);
            label1.TabIndex = 48;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label2.ForeColor = Color.FromArgb(92, 102, 114);
            label2.Location = new Point(69, 158);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 49;
            label2.Text = "Password";
            // 
            // lblError
            // 
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblError.ForeColor = Color.Firebrick;
            lblError.Location = new Point(70, 220);
            lblError.Name = "lblError";
            lblError.Size = new Size(333, 30);
            lblError.TabIndex = 45;
            lblError.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1004, 567);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            ClientSize = new Size(1004, 567);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClinicKa Login";
            Load += LoginForm_Load;
            KeyDown += LoginForm_KeyDown;
            pnlBackground.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private PictureBox pictureBox5;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel16;
        private Label label3;
        private ReaLTaiizor.Controls.Button btnLogin;
        private LinkLabel lnkAccountRecovery;
        private Label label4;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtUsername;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label lblError;
    }
}
