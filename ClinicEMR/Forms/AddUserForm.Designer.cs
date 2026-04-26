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
            panel2 = new Panel();
            lblConfirmAnswerError = new Label();
            lblAnswerError = new Label();
            lblQuestionError = new Label();
            txtRecoveryQuestion = new ReaLTaiizor.Controls.HopeTextBox();
            txtRecoveryAnswer = new ReaLTaiizor.Controls.HopeTextBox();
            txtConfirmRecoveryAnswer = new ReaLTaiizor.Controls.HopeTextBox();
            lblConfirmRecoveryAnswer = new Label();
            lblRecoveryAnswer = new Label();
            lblRecoveryQuestion = new Label();
            pnlContainer = new Panel();
            txtConfirmPassword = new ReaLTaiizor.Controls.HopeTextBox();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            txtUsername = new ReaLTaiizor.Controls.HopeTextBox();
            txtFullName = new ReaLTaiizor.Controls.HopeTextBox();
            lblConfirmPassword = new Label();
            cboRole = new ReaLTaiizor.Controls.HopeComboBox();
            lblFullName = new Label();
            lblUsername = new Label();
            lblRole = new Label();
            lblRoleError = new Label();
            lblPassword = new Label();
            lblPasswordError = new Label();
            lblConfirmPasswordError = new Label();
            lblUsernameError = new Label();
            lblFullNameError = new Label();
            panel1 = new Panel();
            lblMeta = new Label();
            label1 = new Label();
            button1 = new ReaLTaiizor.Controls.Button();
            button2 = new ReaLTaiizor.Controls.Button();
            btnCancel = new ReaLTaiizor.Controls.Button();
            btnSave = new ReaLTaiizor.Controls.Button();
            pnlBackground.SuspendLayout();
            panel2.SuspendLayout();
            pnlContainer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(panel2);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Controls.Add(panel1);
            pnlBackground.Controls.Add(button2);
            pnlBackground.Controls.Add(btnCancel);
            pnlBackground.Controls.Add(btnSave);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(611, 953);
            pnlBackground.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 111, 127);
            panel2.Controls.Add(lblConfirmAnswerError);
            panel2.Controls.Add(lblAnswerError);
            panel2.Controls.Add(lblQuestionError);
            panel2.Controls.Add(txtRecoveryQuestion);
            panel2.Controls.Add(txtRecoveryAnswer);
            panel2.Controls.Add(txtConfirmRecoveryAnswer);
            panel2.Controls.Add(lblConfirmRecoveryAnswer);
            panel2.Controls.Add(lblRecoveryAnswer);
            panel2.Controls.Add(lblRecoveryQuestion);
            panel2.ForeColor = Color.FromArgb(226, 230, 237);
            panel2.Location = new Point(30, 552);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 314);
            panel2.TabIndex = 41;
            // 
            // lblConfirmAnswerError
            // 
            lblConfirmAnswerError.AutoSize = true;
            lblConfirmAnswerError.BackColor = Color.Transparent;
            lblConfirmAnswerError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblConfirmAnswerError.ForeColor = Color.FromArgb(153, 27, 27);
            lblConfirmAnswerError.Location = new Point(23, 279);
            lblConfirmAnswerError.Name = "lblConfirmAnswerError";
            lblConfirmAnswerError.Size = new Size(0, 16);
            lblConfirmAnswerError.TabIndex = 49;
            lblConfirmAnswerError.Visible = false;
            // 
            // lblAnswerError
            // 
            lblAnswerError.AutoSize = true;
            lblAnswerError.BackColor = Color.Transparent;
            lblAnswerError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblAnswerError.ForeColor = Color.FromArgb(153, 27, 27);
            lblAnswerError.Location = new Point(23, 185);
            lblAnswerError.Name = "lblAnswerError";
            lblAnswerError.Size = new Size(0, 16);
            lblAnswerError.TabIndex = 48;
            lblAnswerError.Visible = false;
            // 
            // lblQuestionError
            // 
            lblQuestionError.AutoSize = true;
            lblQuestionError.BackColor = Color.Transparent;
            lblQuestionError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblQuestionError.ForeColor = Color.FromArgb(153, 27, 27);
            lblQuestionError.Location = new Point(23, 91);
            lblQuestionError.Name = "lblQuestionError";
            lblQuestionError.Size = new Size(0, 16);
            lblQuestionError.TabIndex = 47;
            lblQuestionError.Visible = false;
            // 
            // txtRecoveryQuestion
            // 
            txtRecoveryQuestion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRecoveryQuestion.BackColor = Color.FromArgb(197, 202, 212);
            txtRecoveryQuestion.BaseColor = Color.FromArgb(108, 111, 127);
            txtRecoveryQuestion.BorderColorA = Color.FromArgb(108, 111, 127);
            txtRecoveryQuestion.BorderColorB = Color.FromArgb(108, 111, 127);
            txtRecoveryQuestion.Cursor = Cursors.IBeam;
            txtRecoveryQuestion.Font = new Font("TT Interphases Pro Trl", 10F);
            txtRecoveryQuestion.ForeColor = Color.FromArgb(26, 35, 48);
            txtRecoveryQuestion.Hint = "Ex: What is my favorite philosopher?";
            txtRecoveryQuestion.Location = new Point(23, 49);
            txtRecoveryQuestion.Margin = new Padding(3, 3, 0, 3);
            txtRecoveryQuestion.MaxLength = 100;
            txtRecoveryQuestion.Multiline = false;
            txtRecoveryQuestion.Name = "txtRecoveryQuestion";
            txtRecoveryQuestion.PasswordChar = '\0';
            txtRecoveryQuestion.ScrollBars = ScrollBars.None;
            txtRecoveryQuestion.SelectedText = "";
            txtRecoveryQuestion.SelectionLength = 0;
            txtRecoveryQuestion.SelectionStart = 0;
            txtRecoveryQuestion.Size = new Size(505, 37);
            txtRecoveryQuestion.TabIndex = 44;
            txtRecoveryQuestion.TabStop = false;
            txtRecoveryQuestion.UseSystemPasswordChar = false;
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
            txtRecoveryAnswer.Location = new Point(23, 144);
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
            txtRecoveryAnswer.TabIndex = 46;
            txtRecoveryAnswer.TabStop = false;
            txtRecoveryAnswer.UseSystemPasswordChar = true;
            // 
            // txtConfirmRecoveryAnswer
            // 
            txtConfirmRecoveryAnswer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmRecoveryAnswer.BackColor = Color.FromArgb(197, 202, 212);
            txtConfirmRecoveryAnswer.BaseColor = Color.FromArgb(108, 111, 127);
            txtConfirmRecoveryAnswer.BorderColorA = Color.FromArgb(108, 111, 127);
            txtConfirmRecoveryAnswer.BorderColorB = Color.FromArgb(108, 111, 127);
            txtConfirmRecoveryAnswer.Cursor = Cursors.IBeam;
            txtConfirmRecoveryAnswer.Font = new Font("TT Interphases Pro Trl", 10F);
            txtConfirmRecoveryAnswer.ForeColor = Color.FromArgb(26, 35, 48);
            txtConfirmRecoveryAnswer.Hint = "Re-enter your answer";
            txtConfirmRecoveryAnswer.Location = new Point(23, 235);
            txtConfirmRecoveryAnswer.Margin = new Padding(3, 3, 0, 3);
            txtConfirmRecoveryAnswer.MaxLength = 64;
            txtConfirmRecoveryAnswer.Multiline = false;
            txtConfirmRecoveryAnswer.Name = "txtConfirmRecoveryAnswer";
            txtConfirmRecoveryAnswer.PasswordChar = '•';
            txtConfirmRecoveryAnswer.ScrollBars = ScrollBars.None;
            txtConfirmRecoveryAnswer.SelectedText = "";
            txtConfirmRecoveryAnswer.SelectionLength = 0;
            txtConfirmRecoveryAnswer.SelectionStart = 0;
            txtConfirmRecoveryAnswer.Size = new Size(505, 37);
            txtConfirmRecoveryAnswer.TabIndex = 45;
            txtConfirmRecoveryAnswer.TabStop = false;
            txtConfirmRecoveryAnswer.UseSystemPasswordChar = true;
            // 
            // lblConfirmRecoveryAnswer
            // 
            lblConfirmRecoveryAnswer.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblConfirmRecoveryAnswer.ForeColor = Color.FromArgb(26, 35, 48);
            lblConfirmRecoveryAnswer.Location = new Point(23, 213);
            lblConfirmRecoveryAnswer.Name = "lblConfirmRecoveryAnswer";
            lblConfirmRecoveryAnswer.Size = new Size(252, 23);
            lblConfirmRecoveryAnswer.TabIndex = 43;
            lblConfirmRecoveryAnswer.Text = "Re-Enter Answer";
            // 
            // lblRecoveryAnswer
            // 
            lblRecoveryAnswer.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblRecoveryAnswer.ForeColor = Color.FromArgb(26, 35, 48);
            lblRecoveryAnswer.Location = new Point(23, 119);
            lblRecoveryAnswer.Name = "lblRecoveryAnswer";
            lblRecoveryAnswer.Size = new Size(252, 23);
            lblRecoveryAnswer.TabIndex = 26;
            lblRecoveryAnswer.Text = "Recovery Answer";
            // 
            // lblRecoveryQuestion
            // 
            lblRecoveryQuestion.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblRecoveryQuestion.ForeColor = Color.FromArgb(26, 35, 48);
            lblRecoveryQuestion.Location = new Point(23, 25);
            lblRecoveryQuestion.Name = "lblRecoveryQuestion";
            lblRecoveryQuestion.Size = new Size(182, 23);
            lblRecoveryQuestion.TabIndex = 9;
            lblRecoveryQuestion.Text = "Recovery Question";
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(108, 111, 127);
            pnlContainer.Controls.Add(txtConfirmPassword);
            pnlContainer.Controls.Add(txtPassword);
            pnlContainer.Controls.Add(txtUsername);
            pnlContainer.Controls.Add(txtFullName);
            pnlContainer.Controls.Add(lblConfirmPassword);
            pnlContainer.Controls.Add(cboRole);
            pnlContainer.Controls.Add(lblFullName);
            pnlContainer.Controls.Add(lblUsername);
            pnlContainer.Controls.Add(lblRole);
            pnlContainer.Controls.Add(lblRoleError);
            pnlContainer.Controls.Add(lblPassword);
            pnlContainer.Controls.Add(lblPasswordError);
            pnlContainer.Controls.Add(lblConfirmPasswordError);
            pnlContainer.Controls.Add(lblUsernameError);
            pnlContainer.Controls.Add(lblFullNameError);
            pnlContainer.ForeColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Location = new Point(30, 149);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(550, 397);
            pnlContainer.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.BackColor = Color.FromArgb(197, 202, 212);
            txtConfirmPassword.BaseColor = Color.FromArgb(108, 111, 127);
            txtConfirmPassword.BorderColorA = Color.FromArgb(108, 111, 127);
            txtConfirmPassword.BorderColorB = Color.FromArgb(108, 111, 127);
            txtConfirmPassword.Cursor = Cursors.IBeam;
            txtConfirmPassword.Font = new Font("TT Interphases Pro Trl", 10F);
            txtConfirmPassword.ForeColor = Color.FromArgb(26, 35, 48);
            txtConfirmPassword.Hint = "Re-enter password";
            txtConfirmPassword.Location = new Point(23, 317);
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
            txtConfirmPassword.TabIndex = 34;
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
            txtPassword.Location = new Point(23, 219);
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
            txtPassword.TabIndex = 33;
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
            txtUsername.Hint = "No spaces in between";
            txtUsername.Location = new Point(23, 130);
            txtUsername.Margin = new Padding(3, 3, 0, 3);
            txtUsername.MaxLength = 30;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.Size = new Size(375, 37);
            txtUsername.TabIndex = 32;
            txtUsername.TabStop = false;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BackColor = Color.FromArgb(197, 202, 212);
            txtFullName.BaseColor = Color.FromArgb(108, 111, 127);
            txtFullName.BorderColorA = Color.FromArgb(108, 111, 127);
            txtFullName.BorderColorB = Color.FromArgb(108, 111, 127);
            txtFullName.Cursor = Cursors.IBeam;
            txtFullName.Font = new Font("TT Interphases Pro Trl", 10F);
            txtFullName.ForeColor = Color.FromArgb(26, 35, 48);
            txtFullName.Hint = "First Name Middle Initial. Last Name ";
            txtFullName.Location = new Point(23, 46);
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
            txtFullName.TabIndex = 31;
            txtFullName.TabStop = false;
            txtFullName.UseSystemPasswordChar = false;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblConfirmPassword.ForeColor = Color.FromArgb(26, 35, 48);
            lblConfirmPassword.Location = new Point(23, 293);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(228, 23);
            lblConfirmPassword.TabIndex = 26;
            lblConfirmPassword.Text = "Re-enter Password";
            // 
            // cboRole
            // 
            cboRole.DrawMode = DrawMode.OwnerDrawFixed;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FlatStyle = FlatStyle.Flat;
            cboRole.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboRole.ForeColor = Color.FromArgb(226, 230, 237);
            cboRole.FormattingEnabled = true;
            cboRole.ItemHeight = 30;
            cboRole.Items.AddRange(new object[] { "doctor", "nurse", "admin" });
            cboRole.Location = new Point(409, 131);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(119, 36);
            cboRole.TabIndex = 25;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblFullName.ForeColor = Color.FromArgb(26, 35, 48);
            lblFullName.Location = new Point(23, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(87, 17);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblUsername.ForeColor = Color.FromArgb(26, 35, 48);
            lblUsername.Location = new Point(23, 108);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 18);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblRole
            // 
            lblRole.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblRole.ForeColor = Color.FromArgb(26, 35, 48);
            lblRole.Location = new Point(409, 108);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(100, 17);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role";
            // 
            // lblRoleError
            // 
            lblRoleError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblRoleError.ForeColor = Color.FromArgb(153, 27, 27);
            lblRoleError.Location = new Point(407, 170);
            lblRoleError.Name = "lblRoleError";
            lblRoleError.Size = new Size(125, 31);
            lblRoleError.TabIndex = 8;
            lblRoleError.Visible = false;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblPassword.ForeColor = Color.FromArgb(26, 35, 48);
            lblPassword.Location = new Point(23, 197);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // lblPasswordError
            // 
            lblPasswordError.BackColor = Color.Transparent;
            lblPasswordError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblPasswordError.ForeColor = Color.FromArgb(153, 27, 27);
            lblPasswordError.Location = new Point(23, 257);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(505, 51);
            lblPasswordError.TabIndex = 11;
            lblPasswordError.Visible = false;
            // 
            // lblConfirmPasswordError
            // 
            lblConfirmPasswordError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblConfirmPasswordError.ForeColor = Color.FromArgb(153, 27, 27);
            lblConfirmPasswordError.Location = new Point(23, 357);
            lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            lblConfirmPasswordError.Size = new Size(505, 40);
            lblConfirmPasswordError.TabIndex = 28;
            lblConfirmPasswordError.Visible = false;
            // 
            // lblUsernameError
            // 
            lblUsernameError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblUsernameError.ForeColor = Color.FromArgb(153, 27, 27);
            lblUsernameError.Location = new Point(23, 168);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(378, 37);
            lblUsernameError.TabIndex = 5;
            lblUsernameError.Visible = false;
            // 
            // lblFullNameError
            // 
            lblFullNameError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblFullNameError.ForeColor = Color.FromArgb(153, 27, 27);
            lblFullNameError.Location = new Point(23, 83);
            lblFullNameError.Name = "lblFullNameError";
            lblFullNameError.Size = new Size(500, 57);
            lblFullNameError.TabIndex = 2;
            lblFullNameError.Visible = false;
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
            panel1.TabIndex = 40;
            // 
            // lblMeta
            // 
            lblMeta.Anchor = AnchorStyles.Left;
            lblMeta.AutoSize = true;
            lblMeta.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblMeta.ForeColor = Color.FromArgb(92, 102, 114);
            lblMeta.Location = new Point(144, 49);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(298, 21);
            lblMeta.TabIndex = 40;
            lblMeta.Text = "Fill the details to register new account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(197, 202, 212);
            label1.Location = new Point(142, 16);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 31);
            label1.TabIndex = 39;
            label1.Text = "Add New User Account";
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
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.Transparent;
            button2.Enabled = false;
            button2.EnteredBorderColor = Color.Transparent;
            button2.EnteredColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.FromArgb(37, 45, 56);
            button2.Location = new Point(30, 28);
            button2.Margin = new Padding(3, 0, 0, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(23, 13, 11, 13);
            button2.PressedBorderColor = Color.Transparent;
            button2.PressedColor = Color.Transparent;
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(550, 58);
            button2.TabIndex = 39;
            button2.TextAlignment = StringAlignment.Center;
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
            btnCancel.Location = new Point(370, 885);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(153, 27, 27);
            btnCancel.PressedColor = Color.FromArgb(153, 27, 27);
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 12;
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
            btnSave.Location = new Point(480, 885);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(22, 101, 52);
            btnSave.PressedColor = Color.FromArgb(22, 101, 52);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save User";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // AddUserForm
            // 
            ClientSize = new Size(611, 953);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            pnlBackground.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);


        }

        private Panel pnlBackground;
        private Panel pnlContainer;

        private Label lblFullName;
        private Label lblFullNameError;

        private Label lblUsername;
        private Label lblUsernameError;

        private Label lblRole;
        private Label lblRoleError;

        private Label lblPassword;
        private Label lblPasswordError;
        private Label lblConfirmPassword;
        private Label lblConfirmPasswordError;

        private ReaLTaiizor.Controls.Button btnSave;
        private ReaLTaiizor.Controls.Button btnCancel;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox1;
        private ReaLTaiizor.Controls.HopeComboBox cboRole;
        private Panel panel1;
        private Label lblMeta;
        private Label label1;
        protected internal ReaLTaiizor.Controls.Button button1;
        protected internal ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.HopeTextBox txtConfirmPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtUsername;
        private ReaLTaiizor.Controls.HopeTextBox txtFullName;
        private Panel panel2;
        private Label lblConfirmAnswerError;
        private Label lblAnswerError;
        private Label lblQuestionError;
        private ReaLTaiizor.Controls.HopeTextBox txtRecoveryQuestion;
        private ReaLTaiizor.Controls.HopeTextBox txtRecoveryAnswer;
        private ReaLTaiizor.Controls.HopeTextBox txtConfirmRecoveryAnswer;
        private Label lblConfirmRecoveryAnswer;
        private Label lblRecoveryAnswer;
        private Label lblRecoveryQuestion;
    }
}
