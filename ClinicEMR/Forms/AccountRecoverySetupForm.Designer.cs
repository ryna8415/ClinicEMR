namespace ClinicEMR.Forms
{
    partial class AccountRecoverySetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountRecoverySetupForm));
            panel1 = new Panel();
            lblMeta = new Label();
            lblHeader = new Label();
            picHeaderIcon = new ReaLTaiizor.Controls.Button();
            btnHeaderBackdrop = new ReaLTaiizor.Controls.Button();
            btnCancel = new ReaLTaiizor.Controls.Button();
            btnSave = new ReaLTaiizor.Controls.Button();
            pnlContainer = new Panel();
            lblConfirmAnswerError = new Label();
            lblAnswerError = new Label();
            lblQuestionError = new Label();
            txtRecoveryQuestion = new ReaLTaiizor.Controls.HopeTextBox();
            txtRecoveryAnswer = new ReaLTaiizor.Controls.HopeTextBox();
            txtConfirmRecoveryAnswer = new ReaLTaiizor.Controls.HopeTextBox();
            lblConfirmAnswer = new Label();
            lblRecoveryAnswer = new Label();
            lblRecoveryQuestion = new Label();
            pnlBackground = new Panel();
            panel1.SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 45, 56);
            panel1.Controls.Add(lblMeta);
            panel1.Controls.Add(lblHeader);
            panel1.Controls.Add(picHeaderIcon);
            panel1.Location = new Point(30, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 125);
            panel1.TabIndex = 38;
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
            lblMeta.Text = "Fill up the following details to setup Account Recovery";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            lblHeader.ForeColor = SystemColors.ControlLightLight;
            lblHeader.Location = new Point(142, 16);
            lblHeader.Margin = new Padding(0, 0, 3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(287, 31);
            lblHeader.TabIndex = 39;
            lblHeader.Text = "Account Recovery Setup";
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
            btnCancel.Location = new Point(368, 482);
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
            btnSave.Location = new Point(480, 482);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(22, 101, 52);
            btnSave.PressedColor = Color.FromArgb(22, 101, 52);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(108, 111, 127);
            pnlContainer.Controls.Add(lblConfirmAnswerError);
            pnlContainer.Controls.Add(lblAnswerError);
            pnlContainer.Controls.Add(lblQuestionError);
            pnlContainer.Controls.Add(txtRecoveryQuestion);
            pnlContainer.Controls.Add(txtRecoveryAnswer);
            pnlContainer.Controls.Add(txtConfirmRecoveryAnswer);
            pnlContainer.Controls.Add(lblConfirmAnswer);
            pnlContainer.Controls.Add(lblRecoveryAnswer);
            pnlContainer.Controls.Add(lblRecoveryQuestion);
            pnlContainer.ForeColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Location = new Point(30, 149);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(550, 314);
            pnlContainer.TabIndex = 19;
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
            txtRecoveryQuestion.Location = new Point(23, 51);
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
            txtRecoveryAnswer.Location = new Point(23, 145);
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
            txtConfirmRecoveryAnswer.Location = new Point(23, 239);
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
            // lblConfirmAnswer
            // 
            lblConfirmAnswer.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblConfirmAnswer.ForeColor = Color.FromArgb(26, 35, 48);
            lblConfirmAnswer.Location = new Point(23, 213);
            lblConfirmAnswer.Name = "lblConfirmAnswer";
            lblConfirmAnswer.Size = new Size(252, 23);
            lblConfirmAnswer.TabIndex = 43;
            lblConfirmAnswer.Text = "Re-Enter Answer";
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
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Controls.Add(panel1);
            pnlBackground.Controls.Add(btnHeaderBackdrop);
            pnlBackground.Controls.Add(btnCancel);
            pnlBackground.Controls.Add(btnSave);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(611, 548);
            pnlBackground.TabIndex = 2;
            // 
            // AccountRecoverySetupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 548);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AccountRecoverySetupForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Account Recovery Setup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlBackground.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblMeta;
        private Label lblHeader;
        protected internal ReaLTaiizor.Controls.Button picHeaderIcon;
        protected internal ReaLTaiizor.Controls.Button btnHeaderBackdrop;
        private ReaLTaiizor.Controls.Button btnCancel;
        private ReaLTaiizor.Controls.Button btnSave;
        private Panel pnlContainer;
        private ReaLTaiizor.Controls.HopeTextBox txtRecoveryQuestion;
        private ReaLTaiizor.Controls.HopeTextBox txtRecoveryAnswer;
        private ReaLTaiizor.Controls.HopeTextBox txtConfirmRecoveryAnswer;
        private Label lblConfirmAnswer;
        private Label lblRecoveryAnswer;
        private Label lblRecoveryQuestion;
        private Panel pnlBackground;
        private Label lblQuestionError;
        private Label lblAnswerError;
        private Label lblConfirmAnswerError;
    }
}
