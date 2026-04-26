namespace ClinicEMR.Forms
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            pnlBackground = new Panel();
            pnlContainer = new Panel();
            txtFullName = new ReaLTaiizor.Controls.HopeTextBox();
            txtConfirmPassword = new ReaLTaiizor.Controls.HopeTextBox();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblFullName = new Label();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            lblPasswordError = new Label();
            lblConfirmPasswordError = new Label();
            panel1 = new Panel();
            lblMeta = new Label();
            label1 = new Label();
            button1 = new ReaLTaiizor.Controls.Button();
            btnHeader = new ReaLTaiizor.Controls.Button();
            btnCancel = new ReaLTaiizor.Controls.Button();
            btnSave = new ReaLTaiizor.Controls.Button();
            pnlBackground.SuspendLayout();
            pnlContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Controls.Add(panel1);
            pnlBackground.Controls.Add(btnHeader);
            pnlBackground.Controls.Add(btnCancel);
            pnlBackground.Controls.Add(btnSave);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(611, 562);
            pnlBackground.TabIndex = 0;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(108, 111, 127);
            pnlContainer.Controls.Add(txtFullName);
            pnlContainer.Controls.Add(txtConfirmPassword);
            pnlContainer.Controls.Add(txtPassword);
            pnlContainer.Controls.Add(lblFullName);
            pnlContainer.Controls.Add(lblConfirmPassword);
            pnlContainer.Controls.Add(lblPassword);
            pnlContainer.Controls.Add(lblPasswordError);
            pnlContainer.Controls.Add(lblConfirmPasswordError);
            pnlContainer.ForeColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Location = new Point(30, 149);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(550, 330);
            pnlContainer.TabIndex = 19;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BackColor = Color.FromArgb(197, 202, 212);
            txtFullName.BaseColor = Color.FromArgb(108, 111, 127);
            txtFullName.BorderColorA = Color.FromArgb(108, 111, 127);
            txtFullName.BorderColorB = Color.FromArgb(108, 111, 127);
            txtFullName.Cursor = Cursors.IBeam;
            txtFullName.Enabled = false;
            txtFullName.Font = new Font("TT Interphases Pro Trl", 10F);
            txtFullName.ForeColor = Color.FromArgb(26, 35, 48);
            txtFullName.Hint = "First Name Middle Initial. Last Name ";
            txtFullName.Location = new Point(23, 50);
            txtFullName.Margin = new Padding(3, 3, 0, 3);
            txtFullName.MaxLength = 100;
            txtFullName.Multiline = false;
            txtFullName.Name = "txtFullName";
            txtFullName.PasswordChar = '\0';
            txtFullName.ScrollBars = ScrollBars.None;
            txtFullName.SelectedText = "";
            txtFullName.SelectionLength = 0;
            txtFullName.SelectionStart = 0;
            txtFullName.Size = new Size(505, 37);
            txtFullName.TabIndex = 19;
            txtFullName.TabStop = false;
            txtFullName.UseSystemPasswordChar = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.None;
            txtConfirmPassword.BackColor = Color.FromArgb(197, 202, 212);
            txtConfirmPassword.BaseColor = Color.FromArgb(108, 111, 127);
            txtConfirmPassword.BorderColorA = Color.FromArgb(108, 111, 127);
            txtConfirmPassword.BorderColorB = Color.FromArgb(108, 111, 127);
            txtConfirmPassword.Cursor = Cursors.IBeam;
            txtConfirmPassword.Font = new Font("TT Interphases Pro Trl", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(26, 35, 48);
            txtConfirmPassword.Hint = "Re-enter password";
            txtConfirmPassword.Location = new Point(23, 245);
            txtConfirmPassword.Margin = new Padding(3, 3, 0, 3);
            txtConfirmPassword.MaxLength = 64;
            txtConfirmPassword.Multiline = false;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.ScrollBars = ScrollBars.None;
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.SelectionLength = 0;
            txtConfirmPassword.SelectionStart = 0;
            txtConfirmPassword.Size = new Size(505, 37);
            txtConfirmPassword.TabIndex = 37;
            txtConfirmPassword.TabStop = false;
            txtConfirmPassword.UseSystemPasswordChar = false;
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
            txtPassword.Hint = "Min. 8 characters, 1 special, 1 Uppercase";
            txtPassword.Location = new Point(23, 148);
            txtPassword.Margin = new Padding(3, 3, 0, 3);
            txtPassword.MaxLength = 64;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(505, 37);
            txtPassword.TabIndex = 36;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblFullName.ForeColor = Color.FromArgb(26, 35, 48);
            lblFullName.Location = new Point(23, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(147, 21);
            lblFullName.TabIndex = 31;
            lblFullName.Text = "Account Name";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblConfirmPassword.ForeColor = Color.FromArgb(26, 35, 48);
            lblConfirmPassword.Location = new Point(23, 221);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(252, 23);
            lblConfirmPassword.TabIndex = 26;
            lblConfirmPassword.Text = "Re-enter Password";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblPassword.ForeColor = Color.FromArgb(26, 35, 48);
            lblPassword.Location = new Point(23, 122);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(132, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "New Password";
            // 
            // lblPasswordError
            // 
            lblPasswordError.BackColor = Color.Transparent;
            lblPasswordError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblPasswordError.ForeColor = Color.FromArgb(153, 27, 27);
            lblPasswordError.Location = new Point(23, 188);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(526, 50);
            lblPasswordError.TabIndex = 11;
            lblPasswordError.Visible = false;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblConfirmPasswordError.ForeColor = Color.FromArgb(153, 27, 27);
            lblConfirmPasswordError.Location = new Point(23, 286);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(424, 40);
            lblConfirmPasswordError.TabIndex = 28;
            lblConfirmPasswordError.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 45, 56);
            panel1.Controls.Add(lblMeta);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(30, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 125);
            panel1.TabIndex = 38;
            // 
            // lblMeta
            // 
            lblMeta.Anchor = AnchorStyles.Left;
            lblMeta.AutoSize = true;
            lblMeta.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblMeta.ForeColor = Color.FromArgb(92, 102, 114);
            lblMeta.Location = new Point(144, 49);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(349, 21);
            lblMeta.TabIndex = 40;
            lblMeta.Text = "Admin — set a new password for this account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            label1.Location = new Point(142, 16);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 31);
            label1.TabIndex = 39;
            label1.Text = "Reset Account Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Transparent;
            button1.Enabled = false;
            button1.EnteredBorderColor = Color.Transparent;
            button1.EnteredColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            button1.InactiveColor = Color.FromArgb(49, 62, 80);
            button1.Location = new Point(23, 0);
            button1.Margin = new Padding(3, 0, 0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(23, 13, 11, 13);
            button1.PressedBorderColor = Color.Transparent;
            button1.PressedColor = Color.Transparent;
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(108, 84);
            button1.TabIndex = 39;
            button1.TextAlignment = StringAlignment.Center;
            // 
            // btnHeader
            // 
            btnHeader.BackColor = Color.Transparent;
            btnHeader.BorderColor = Color.Transparent;
            btnHeader.Enabled = false;
            btnHeader.EnteredBorderColor = Color.Transparent;
            btnHeader.EnteredColor = Color.Transparent;
            btnHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeader.Image = null;
            btnHeader.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeader.InactiveColor = Color.FromArgb(37, 45, 56);
            btnHeader.Location = new Point(30, 30);
            btnHeader.Margin = new Padding(3, 0, 0, 0);
            btnHeader.Name = "btnHeader";
            btnHeader.Padding = new Padding(23, 13, 11, 13);
            btnHeader.PressedBorderColor = Color.Transparent;
            btnHeader.PressedColor = Color.Transparent;
            btnHeader.RightToLeft = RightToLeft.Yes;
            btnHeader.Size = new Size(550, 58);
            btnHeader.TabIndex = 20;
            btnHeader.TextAlignment = StringAlignment.Center;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(49, 62, 80);
            btnCancel.BorderColor = Color.FromArgb(92, 102, 114);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.EnteredBorderColor = Color.FromArgb(92, 102, 114);
            btnCancel.EnteredColor = Color.FromArgb(69, 85, 97);
            btnCancel.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnCancel.Image = null;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.InactiveColor = Color.FromArgb(92, 102, 114);
            btnCancel.Location = new Point(370, 496);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(153, 27, 27);
            btnCancel.PressedColor = Color.FromArgb(153, 27, 27);
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(49, 62, 80);
            btnSave.BorderColor = Color.FromArgb(26, 35, 48);
            btnSave.Cursor = Cursors.Hand;
            btnSave.EnteredBorderColor = Color.FromArgb(26, 35, 48);
            btnSave.EnteredColor = Color.FromArgb(69, 85, 97);
            btnSave.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(26, 35, 48);
            btnSave.Location = new Point(480, 496);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(22, 101, 52);
            btnSave.PressedColor = Color.FromArgb(22, 101, 52);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save User";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 62, 80);
            ClientSize = new Size(611, 562);
            Controls.Add(pnlBackground);
            ForeColor = Color.FromArgb(197, 202, 212);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            pnlBackground.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackground;
        private Panel pnlContainer;
        private ReaLTaiizor.Controls.HopeTextBox txtFullName;
        private ReaLTaiizor.Controls.HopeTextBox txtConfirmPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private Label lblFullName;
        private Label lblConfirmPassword;
        private Label lblPassword;
        private Label lblPasswordError;
        private Label lblConfirmPasswordError;
        protected internal ReaLTaiizor.Controls.Button btnHeader;
        private ReaLTaiizor.Controls.Button btnCancel;
        private ReaLTaiizor.Controls.Button btnSave;
        private Panel panel1;
        protected internal ReaLTaiizor.Controls.Button button1;
        private Label label1;
        private Label lblMeta;
    }
}
