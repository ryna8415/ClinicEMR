namespace ClinicEMR.Forms
{
    partial class AccountRecoveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountRecoveryForm));
            lblConfirmNewPassword = new Label();
            lblPasswordError = new Label();
            txtConfirmPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblRecoveryQuestion = new Label();
            btnLoadQuestion = new ReaLTaiizor.Controls.Button();
            txtRecoveryAnswer = new ReaLTaiizor.Controls.HopeTextBox();
            pnlContainer = new Panel();
            lblNewPassword = new Label();
            txtUsername = new ReaLTaiizor.Controls.HopeTextBox();
            txtNewPassword = new ReaLTaiizor.Controls.HopeTextBox();
            lblUsername = new Label();
            lblRecoveryAnswer = new Label();
            lblRecoveryQuestionTitle = new Label();
            lblConfirmPasswordError = new Label();
            btnCancel = new ReaLTaiizor.Controls.Button();
            lblMeta = new Label();
            lblHeader = new Label();
            picHeaderIcon = new ReaLTaiizor.Controls.Button();
            btnHeaderBackdrop = new ReaLTaiizor.Controls.Button();
            btnReset = new ReaLTaiizor.Controls.Button();
            pnlBackground = new Panel();
            pnlHeader = new Panel();
            lblError = new Label();
            pnlContainer.SuspendLayout();
            pnlBackground.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblConfirmNewPassword.ForeColor = Color.FromArgb(26, 35, 48);
            lblConfirmNewPassword.Location = new Point(24, 355);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(252, 23);
            lblConfirmNewPassword.TabIndex = 44;
            lblConfirmNewPassword.Text = "Confirm Password";
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.BackColor = Color.Transparent;
            lblPasswordError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblPasswordError.ForeColor = Color.FromArgb(153, 27, 27);
            lblPasswordError.Location = new Point(24, 329);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(0, 16);
            lblPasswordError.TabIndex = 42;
            lblPasswordError.Visible = false;
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
            txtConfirmPassword.Location = new Point(23, 381);
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
            txtConfirmPassword.TabIndex = 41;
            txtConfirmPassword.TabStop = false;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblRecoveryQuestion
            // 
            lblRecoveryQuestion.AutoSize = true;
            lblRecoveryQuestion.Font = new Font("Panton Narrow-Trial SemiBold", 10F, FontStyle.Bold);
            lblRecoveryQuestion.ForeColor = Color.FromArgb(26, 35, 48);
            lblRecoveryQuestion.Location = new Point(23, 134);
            lblRecoveryQuestion.Name = "lblRecoveryQuestion";
            lblRecoveryQuestion.Size = new Size(43, 21);
            lblRecoveryQuestion.TabIndex = 40;
            lblRecoveryQuestion.Text = "RQs";
            // 
            // btnLoadQuestion
            // 
            btnLoadQuestion.BackColor = Color.FromArgb(108, 111, 127);
            btnLoadQuestion.BorderColor = Color.FromArgb(92, 102, 114);
            btnLoadQuestion.Cursor = Cursors.Hand;
            btnLoadQuestion.EnteredBorderColor = Color.FromArgb(92, 102, 114);
            btnLoadQuestion.EnteredColor = Color.FromArgb(69, 85, 97);
            btnLoadQuestion.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnLoadQuestion.Image = null;
            btnLoadQuestion.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadQuestion.InactiveColor = Color.FromArgb(92, 102, 114);
            btnLoadQuestion.Location = new Point(428, 49);
            btnLoadQuestion.Name = "btnLoadQuestion";
            btnLoadQuestion.PressedBorderColor = Color.FromArgb(153, 27, 27);
            btnLoadQuestion.PressedColor = Color.FromArgb(153, 27, 27);
            btnLoadQuestion.Size = new Size(100, 40);
            btnLoadQuestion.TabIndex = 39;
            btnLoadQuestion.Text = "Load";
            btnLoadQuestion.TextAlignment = StringAlignment.Center;
            btnLoadQuestion.Click += btnLoadQuestion_Click;
            // 
            // txtRecoveryAnswer
            // 
            txtRecoveryAnswer.Anchor = AnchorStyles.None;
            txtRecoveryAnswer.BackColor = Color.FromArgb(197, 202, 212);
            txtRecoveryAnswer.BaseColor = Color.FromArgb(108, 111, 127);
            txtRecoveryAnswer.BorderColorA = Color.FromArgb(108, 111, 127);
            txtRecoveryAnswer.BorderColorB = Color.FromArgb(108, 111, 127);
            txtRecoveryAnswer.Cursor = Cursors.IBeam;
            txtRecoveryAnswer.Font = new Font("TT Interphases Pro Trl", 10F);
            txtRecoveryAnswer.ForeColor = Color.FromArgb(26, 35, 48);
            txtRecoveryAnswer.Hint = "Enter your answer";
            txtRecoveryAnswer.Location = new Point(23, 200);
            txtRecoveryAnswer.Margin = new Padding(3, 3, 0, 3);
            txtRecoveryAnswer.MaxLength = 64;
            txtRecoveryAnswer.Multiline = false;
            txtRecoveryAnswer.Name = "txtRecoveryAnswer";
            txtRecoveryAnswer.PasswordChar = '•';
            txtRecoveryAnswer.ScrollBars = ScrollBars.None;
            txtRecoveryAnswer.SelectedText = "";
            txtRecoveryAnswer.SelectionLength = 0;
            txtRecoveryAnswer.SelectionStart = 0;
            txtRecoveryAnswer.Size = new Size(505, 37);
            txtRecoveryAnswer.TabIndex = 37;
            txtRecoveryAnswer.TabStop = false;
            txtRecoveryAnswer.UseSystemPasswordChar = true;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(108, 111, 127);
            pnlContainer.Controls.Add(lblError);
            pnlContainer.Controls.Add(lblConfirmNewPassword);
            pnlContainer.Controls.Add(lblNewPassword);
            pnlContainer.Controls.Add(lblPasswordError);
            pnlContainer.Controls.Add(txtConfirmPassword);
            pnlContainer.Controls.Add(lblRecoveryQuestion);
            pnlContainer.Controls.Add(btnLoadQuestion);
            pnlContainer.Controls.Add(txtUsername);
            pnlContainer.Controls.Add(txtRecoveryAnswer);
            pnlContainer.Controls.Add(txtNewPassword);
            pnlContainer.Controls.Add(lblUsername);
            pnlContainer.Controls.Add(lblRecoveryAnswer);
            pnlContainer.Controls.Add(lblRecoveryQuestionTitle);
            pnlContainer.Controls.Add(lblConfirmPasswordError);
            pnlContainer.ForeColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Location = new Point(30, 149);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(550, 505);
            pnlContainer.TabIndex = 19;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblNewPassword.ForeColor = Color.FromArgb(26, 35, 48);
            lblNewPassword.Location = new Point(23, 263);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(252, 23);
            lblNewPassword.TabIndex = 43;
            lblNewPassword.Text = "New Password";
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
            txtUsername.Hint = "Enter your username";
            txtUsername.Location = new Point(23, 50);
            txtUsername.Margin = new Padding(3, 3, 0, 3);
            txtUsername.MaxLength = 100;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.Size = new Size(393, 37);
            txtUsername.TabIndex = 19;
            txtUsername.TabStop = false;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNewPassword.BackColor = Color.FromArgb(197, 202, 212);
            txtNewPassword.BaseColor = Color.FromArgb(108, 111, 127);
            txtNewPassword.BorderColorA = Color.FromArgb(108, 111, 127);
            txtNewPassword.BorderColorB = Color.FromArgb(108, 111, 127);
            txtNewPassword.Cursor = Cursors.IBeam;
            txtNewPassword.Font = new Font("TT Interphases Pro Trl", 10F);
            txtNewPassword.ForeColor = Color.FromArgb(26, 35, 48);
            txtNewPassword.Hint = "Min. 8 characters, 1 special, 1 Uppercase";
            txtNewPassword.Location = new Point(24, 289);
            txtNewPassword.Margin = new Padding(3, 3, 0, 3);
            txtNewPassword.MaxLength = 64;
            txtNewPassword.Multiline = false;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '•';
            txtNewPassword.ScrollBars = ScrollBars.None;
            txtNewPassword.SelectedText = "";
            txtNewPassword.SelectionLength = 0;
            txtNewPassword.SelectionStart = 0;
            txtNewPassword.Size = new Size(504, 37);
            txtNewPassword.TabIndex = 36;
            txtNewPassword.TabStop = false;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblUsername.ForeColor = Color.FromArgb(26, 35, 48);
            lblUsername.Location = new Point(23, 25);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(147, 21);
            lblUsername.TabIndex = 31;
            lblUsername.Text = "Username";
            // 
            // lblRecoveryAnswer
            // 
            lblRecoveryAnswer.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblRecoveryAnswer.ForeColor = Color.FromArgb(26, 35, 48);
            lblRecoveryAnswer.Location = new Point(23, 174);
            lblRecoveryAnswer.Name = "lblRecoveryAnswer";
            lblRecoveryAnswer.Size = new Size(252, 23);
            lblRecoveryAnswer.TabIndex = 26;
            lblRecoveryAnswer.Text = "Recovery Answer";
            // 
            // lblRecoveryQuestionTitle
            // 
            lblRecoveryQuestionTitle.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblRecoveryQuestionTitle.ForeColor = Color.FromArgb(26, 35, 48);
            lblRecoveryQuestionTitle.Location = new Point(23, 111);
            lblRecoveryQuestionTitle.Name = "lblRecoveryQuestionTitle";
            lblRecoveryQuestionTitle.Size = new Size(182, 23);
            lblRecoveryQuestionTitle.TabIndex = 9;
            lblRecoveryQuestionTitle.Text = "Recovery Question";
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.AutoSize = true;
            lblConfirmPasswordError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblConfirmPasswordError.ForeColor = Color.FromArgb(153, 27, 27);
            lblConfirmPasswordError.Location = new Point(23, 418);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(0, 16);
            lblConfirmPasswordError.TabIndex = 28;
            lblConfirmPasswordError.Visible = false;
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
            btnCancel.Location = new Point(368, 672);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(153, 27, 27);
            btnCancel.PressedColor = Color.FromArgb(153, 27, 27);
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMeta
            // 
            lblMeta.Anchor = AnchorStyles.Left;
            lblMeta.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblMeta.ForeColor = Color.FromArgb(92, 102, 114);
            lblMeta.Location = new Point(144, 49);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(394, 64);
            lblMeta.TabIndex = 40;
            lblMeta.Text = "Use the saved local recovery question to set a new account password.";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            lblHeader.ForeColor = SystemColors.ControlLightLight;
            lblHeader.Location = new Point(142, 16);
            lblHeader.Margin = new Padding(0, 0, 3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(284, 31);
            lblHeader.TabIndex = 39;
            lblHeader.Text = "Recover Account Access";
            // 
            // picHeaderIcon
            // 
            picHeaderIcon.BackColor = Color.Transparent;
            picHeaderIcon.BorderColor = Color.Transparent;
            picHeaderIcon.Enabled = false;
            picHeaderIcon.EnteredBorderColor = Color.Transparent;
            picHeaderIcon.EnteredColor = Color.Transparent;
            picHeaderIcon.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            picHeaderIcon.Image = (Image)resources.GetObject("picHeaderIcon.Image");
            picHeaderIcon.ImageAlign = ContentAlignment.MiddleCenter;
            picHeaderIcon.InactiveColor = Color.FromArgb(49, 62, 80);
            picHeaderIcon.Location = new Point(23, 0);
            picHeaderIcon.Margin = new Padding(3, 0, 0, 0);
            picHeaderIcon.Name = "picHeaderIcon";
            picHeaderIcon.Padding = new Padding(23, 13, 11, 13);
            picHeaderIcon.PressedBorderColor = Color.Transparent;
            picHeaderIcon.PressedColor = Color.Transparent;
            picHeaderIcon.RightToLeft = RightToLeft.Yes;
            picHeaderIcon.Size = new Size(108, 84);
            picHeaderIcon.TabIndex = 39;
            picHeaderIcon.TextAlignment = StringAlignment.Center;
            // 
            // btnHeaderBackdrop
            // 
            btnHeaderBackdrop.BackColor = Color.Transparent;
            btnHeaderBackdrop.BorderColor = Color.Transparent;
            btnHeaderBackdrop.Enabled = false;
            btnHeaderBackdrop.EnteredBorderColor = Color.Transparent;
            btnHeaderBackdrop.EnteredColor = Color.Transparent;
            btnHeaderBackdrop.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeaderBackdrop.Image = null;
            btnHeaderBackdrop.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeaderBackdrop.InactiveColor = Color.FromArgb(37, 45, 56);
            btnHeaderBackdrop.Location = new Point(30, 30);
            btnHeaderBackdrop.Margin = new Padding(3, 0, 0, 0);
            btnHeaderBackdrop.Name = "btnHeaderBackdrop";
            btnHeaderBackdrop.Padding = new Padding(23, 13, 11, 13);
            btnHeaderBackdrop.PressedBorderColor = Color.Transparent;
            btnHeaderBackdrop.PressedColor = Color.Transparent;
            btnHeaderBackdrop.RightToLeft = RightToLeft.Yes;
            btnHeaderBackdrop.Size = new Size(550, 58);
            btnHeaderBackdrop.TabIndex = 20;
            btnHeaderBackdrop.TextAlignment = StringAlignment.Center;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(49, 62, 80);
            btnReset.BorderColor = Color.FromArgb(26, 35, 48);
            btnReset.Cursor = Cursors.Hand;
            btnReset.EnteredBorderColor = Color.FromArgb(26, 35, 48);
            btnReset.EnteredColor = Color.FromArgb(69, 85, 97);
            btnReset.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnReset.Image = null;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.InactiveColor = Color.FromArgb(26, 35, 48);
            btnReset.Location = new Point(480, 672);
            btnReset.Name = "btnReset";
            btnReset.PressedBorderColor = Color.FromArgb(22, 101, 52);
            btnReset.PressedColor = Color.FromArgb(22, 101, 52);
            btnReset.Size = new Size(100, 40);
            btnReset.TabIndex = 22;
            btnReset.Text = "Reset";
            btnReset.TextAlignment = StringAlignment.Center;
            btnReset.Click += btnReset_Click;
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Controls.Add(pnlHeader);
            pnlBackground.Controls.Add(btnHeaderBackdrop);
            pnlBackground.Controls.Add(btnCancel);
            pnlBackground.Controls.Add(btnReset);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(611, 734);
            pnlBackground.TabIndex = 2;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(37, 45, 56);
            pnlHeader.Controls.Add(lblMeta);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(picHeaderIcon);
            pnlHeader.Location = new Point(30, 46);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(550, 125);
            pnlHeader.TabIndex = 38;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblError.ForeColor = Color.FromArgb(153, 27, 27);
            lblError.Location = new Point(24, 240);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 16);
            lblError.TabIndex = 45;
            lblError.Visible = false;
            // 
            // AccountRecoveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 734);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountRecoveryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recover Account Access";
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlBackground.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        private Label lblConfirmNewPassword;
        private Label lblPasswordError;
        private ReaLTaiizor.Controls.HopeTextBox txtConfirmPassword;
        private Label lblRecoveryQuestion;
        private ReaLTaiizor.Controls.Button btnLoadQuestion;
        private ReaLTaiizor.Controls.HopeTextBox txtRecoveryAnswer;
        private Panel pnlContainer;
        private Label lblNewPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtUsername;
        private ReaLTaiizor.Controls.HopeTextBox txtNewPassword;
        private Label lblUsername;
        private Label lblRecoveryAnswer;
        private Label lblRecoveryQuestionTitle;
        private Label lblConfirmPasswordError;
        private ReaLTaiizor.Controls.Button btnCancel;
        private Label lblMeta;
        private Label lblHeader;
        protected internal ReaLTaiizor.Controls.Button picHeaderIcon;
        protected internal ReaLTaiizor.Controls.Button btnHeaderBackdrop;
        private ReaLTaiizor.Controls.Button btnReset;
        private Panel pnlBackground;
        private Panel pnlHeader;
        private Label lblError;
    }
}
