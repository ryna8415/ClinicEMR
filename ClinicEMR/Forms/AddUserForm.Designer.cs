namespace ClinicEMR.Forms
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNewUser = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            cboRole = new ComboBox();
            lblRole = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNewUser
            // 
            lblNewUser.AutoSize = true;
            lblNewUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewUser.Location = new Point(142, 22);
            lblNewUser.Name = "lblNewUser";
            lblNewUser.Size = new Size(107, 30);
            lblNewUser.TabIndex = 6;
            lblNewUser.Text = "New User";
            lblNewUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 96);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Last Name, First Name, Middle Initial";
            txtFullName.Size = new Size(360, 23);
            txtFullName.TabIndex = 7;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 78);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(64, 15);
            lblFullName.TabIndex = 8;
            lblFullName.Text = "Full Name:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 131);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(237, 23);
            txtUsername.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 184);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(360, 23);
            txtPassword.TabIndex = 12;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "doctor", "nurse", "admin" });
            cboRole.Location = new Point(255, 149);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(117, 23);
            cboRole.TabIndex = 13;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(255, 131);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 14;
            lblRole.Text = "Role:";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(279, 286);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(93, 31);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save User";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLightLight;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(180, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(93, 31);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(12, 228);
            label1.Name = "label1";
            label1.Size = new Size(360, 36);
            label1.TabIndex = 23;
            label1.Text = "Password must be atleast 12 characters long, must contain atleast 1 special character and 1 uppercase letter.";
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 329);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblRole);
            Controls.Add(cboRole);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblNewUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewUser;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private ComboBox cboRole;
        private Label lblRole;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
    }
}
