namespace ClinicEMR.Forms
{
    partial class EditAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAppointmentForm));
            button2 = new ReaLTaiizor.Controls.Button();
            lblMeta = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new ReaLTaiizor.Controls.Button();
            txtPurpose = new ReaLTaiizor.Controls.HopeTextBox();
            label5 = new Label();
            label4 = new Label();
            cboTime = new ReaLTaiizor.Controls.HopeComboBox();
            label3 = new Label();
            label2 = new Label();
            cboDoctor = new ReaLTaiizor.Controls.HopeComboBox();
            dtpEditDate = new DateTimePicker();
            lblFullName = new Label();
            pnlContainer = new Panel();
            label6 = new Label();
            cboEditStatus = new ReaLTaiizor.Controls.HopeComboBox();
            lblPatient = new Label();
            pnlBackground = new Panel();
            btnCancel = new ReaLTaiizor.Controls.Button();
            btnSave = new ReaLTaiizor.Controls.Button();
            panel1.SuspendLayout();
            pnlContainer.SuspendLayout();
            pnlBackground.SuspendLayout();
            SuspendLayout();
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
            button2.TabIndex = 41;
            button2.TextAlignment = StringAlignment.Center;
            // 
            // lblMeta
            // 
            lblMeta.Anchor = AnchorStyles.Left;
            lblMeta.AutoSize = true;
            lblMeta.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblMeta.ForeColor = Color.FromArgb(92, 102, 114);
            lblMeta.Location = new Point(144, 61);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(374, 21);
            lblMeta.TabIndex = 40;
            lblMeta.Text = "Fill the following details to book an appointment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(197, 202, 212);
            label1.Location = new Point(142, 16);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 31);
            label1.TabIndex = 39;
            label1.Text = "Book Appointment";
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
            panel1.TabIndex = 42;
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
            // txtPurpose
            // 
            txtPurpose.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPurpose.BackColor = Color.FromArgb(197, 202, 212);
            txtPurpose.BaseColor = Color.FromArgb(108, 111, 127);
            txtPurpose.BorderColorA = Color.FromArgb(108, 111, 127);
            txtPurpose.BorderColorB = Color.FromArgb(108, 111, 127);
            txtPurpose.Font = new Font("TT Interphases Pro Trl", 10F);
            txtPurpose.ForeColor = Color.FromArgb(26, 35, 48);
            txtPurpose.Hint = "Street, Barangay, Municipality, Province";
            txtPurpose.Location = new Point(23, 267);
            txtPurpose.Margin = new Padding(3, 3, 0, 3);
            txtPurpose.MaxLength = 32767;
            txtPurpose.Multiline = true;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.PasswordChar = '\0';
            txtPurpose.ScrollBars = ScrollBars.None;
            txtPurpose.SelectedText = "";
            txtPurpose.SelectionLength = 0;
            txtPurpose.SelectionStart = 0;
            txtPurpose.Size = new Size(503, 60);
            txtPurpose.TabIndex = 40;
            txtPurpose.TabStop = false;
            txtPurpose.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label5.ForeColor = Color.FromArgb(26, 35, 48);
            label5.Location = new Point(23, 242);
            label5.Name = "label5";
            label5.Size = new Size(143, 26);
            label5.TabIndex = 32;
            label5.Text = "Change Purpose:";
            // 
            // label4
            // 
            label4.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label4.ForeColor = Color.FromArgb(26, 35, 48);
            label4.Location = new Point(279, 153);
            label4.Name = "label4";
            label4.Size = new Size(143, 24);
            label4.TabIndex = 31;
            label4.Text = "Change Date:";
            // 
            // cboTime
            // 
            cboTime.DrawMode = DrawMode.OwnerDrawFixed;
            cboTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTime.FlatStyle = FlatStyle.Flat;
            cboTime.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboTime.ForeColor = Color.FromArgb(226, 230, 237);
            cboTime.FormattingEnabled = true;
            cboTime.ItemHeight = 30;
            cboTime.Location = new Point(23, 178);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(246, 36);
            cboTime.TabIndex = 30;
            // 
            // label3
            // 
            label3.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label3.ForeColor = Color.FromArgb(26, 35, 48);
            label3.Location = new Point(22, 153);
            label3.Name = "label3";
            label3.Size = new Size(143, 33);
            label3.TabIndex = 29;
            label3.Text = "Change Timeslot:";
            // 
            // label2
            // 
            label2.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label2.ForeColor = Color.FromArgb(26, 35, 48);
            label2.Location = new Point(22, 70);
            label2.Name = "label2";
            label2.Size = new Size(207, 26);
            label2.TabIndex = 28;
            label2.Text = "Change Attending Doctor: ";
            // 
            // cboDoctor
            // 
            cboDoctor.DrawMode = DrawMode.OwnerDrawFixed;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.FlatStyle = FlatStyle.Flat;
            cboDoctor.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboDoctor.ForeColor = Color.FromArgb(226, 230, 237);
            cboDoctor.FormattingEnabled = true;
            cboDoctor.ItemHeight = 30;
            cboDoctor.Location = new Point(23, 96);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(502, 36);
            cboDoctor.TabIndex = 27;
            // 
            // dtpEditDate
            // 
            dtpEditDate.Font = new Font("Segoe UI", 9F);
            dtpEditDate.Location = new Point(280, 178);
            dtpEditDate.Name = "dtpEditDate";
            dtpEditDate.Size = new Size(246, 27);
            dtpEditDate.TabIndex = 5;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblFullName.ForeColor = Color.FromArgb(26, 35, 48);
            lblFullName.Location = new Point(23, 26);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(131, 17);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Choose Patient: ";
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(108, 111, 127);
            pnlContainer.Controls.Add(label6);
            pnlContainer.Controls.Add(cboEditStatus);
            pnlContainer.Controls.Add(lblPatient);
            pnlContainer.Controls.Add(txtPurpose);
            pnlContainer.Controls.Add(label5);
            pnlContainer.Controls.Add(label4);
            pnlContainer.Controls.Add(cboTime);
            pnlContainer.Controls.Add(label3);
            pnlContainer.Controls.Add(label2);
            pnlContainer.Controls.Add(cboDoctor);
            pnlContainer.Controls.Add(dtpEditDate);
            pnlContainer.Controls.Add(lblFullName);
            pnlContainer.Location = new Point(30, 150);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(550, 450);
            pnlContainer.TabIndex = 2;
            // 
            // label6
            // 
            label6.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            label6.ForeColor = Color.FromArgb(26, 35, 48);
            label6.Location = new Point(23, 350);
            label6.Name = "label6";
            label6.Size = new Size(143, 26);
            label6.TabIndex = 43;
            label6.Text = "Update Status:";
            // 
            // cboEditStatus
            // 
            cboEditStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cboEditStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditStatus.FlatStyle = FlatStyle.Flat;
            cboEditStatus.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboEditStatus.ForeColor = Color.FromArgb(226, 230, 237);
            cboEditStatus.FormattingEnabled = true;
            cboEditStatus.ItemHeight = 30;
            cboEditStatus.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Cancelled", "No-Show" });
            cboEditStatus.Location = new Point(23, 377);
            cboEditStatus.Name = "cboEditStatus";
            cboEditStatus.Size = new Size(504, 36);
            cboEditStatus.TabIndex = 42;
            // 
            // lblPatient
            // 
            lblPatient.Anchor = AnchorStyles.Left;
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblPatient.ForeColor = Color.FromArgb(226, 230, 237);
            lblPatient.Location = new Point(147, 26);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(82, 21);
            lblPatient.TabIndex = 41;
            lblPatient.Text = "Ryan Kurt";
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.FromArgb(49, 62, 80);
            pnlBackground.Controls.Add(btnCancel);
            pnlBackground.Controls.Add(btnSave);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Controls.Add(panel1);
            pnlBackground.Controls.Add(button2);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(611, 681);
            pnlBackground.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(49, 62, 80);
            btnCancel.BorderColor = Color.FromArgb(92, 102, 114);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnCancel.EnteredColor = Color.FromArgb(69, 85, 97);
            btnCancel.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnCancel.Image = null;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.InactiveColor = Color.FromArgb(92, 102, 114);
            btnCancel.Location = new Point(370, 615);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(153, 27, 27);
            btnCancel.PressedColor = Color.FromArgb(153, 27, 27);
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(49, 62, 80);
            btnSave.BorderColor = Color.FromArgb(26, 35, 48);
            btnSave.Cursor = Cursors.Hand;
            btnSave.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnSave.EnteredColor = Color.FromArgb(69, 85, 97);
            btnSave.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(26, 35, 48);
            btnSave.Location = new Point(480, 615);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(22, 101, 52);
            btnSave.PressedColor = Color.FromArgb(22, 101, 52);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 46;
            btnSave.Text = "Confirm";
            btnSave.TextAlignment = StringAlignment.Center;
            // 
            // EditAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 681);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditAppointmentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Appointment ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlBackground.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected internal ReaLTaiizor.Controls.Button button2;
        private Label lblMeta;
        private Label label1;
        private Panel panel1;
        protected internal ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.HopeTextBox txtPurpose;
        private Label label5;
        private Label label4;
        private ReaLTaiizor.Controls.HopeComboBox cboTime;
        private Label label3;
        private Label label2;
        private ReaLTaiizor.Controls.HopeComboBox cboDoctor;
        private DateTimePicker dtpEditDate;
        private Label lblFullName;
        private Panel pnlContainer;
        private Panel pnlBackground;
        private Label lblPatient;
        private Label label6;
        private ReaLTaiizor.Controls.HopeComboBox cboEditStatus;
        private ReaLTaiizor.Controls.Button btnCancel;
        private ReaLTaiizor.Controls.Button btnSave;
    }
}