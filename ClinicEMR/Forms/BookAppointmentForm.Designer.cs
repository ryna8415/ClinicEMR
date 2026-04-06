namespace ClinicEMR.Forms
{
    partial class BookAppointmentForm
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
            cboPatient = new ComboBox();
            lblPatient = new Label();
            lblBookAppt = new Label();
            cboDoctor = new ComboBox();
            lblDoctor = new Label();
            dtpDate = new DateTimePicker();
            lblTime = new Label();
            txtPurpose = new TextBox();
            lblPurpose = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            label1 = new Label();
            cboTime = new ComboBox();
            SuspendLayout();
            // 
            // cboPatient
            // 
            cboPatient.FormattingEnabled = true;
            cboPatient.Location = new Point(28, 112);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(202, 23);
            cboPatient.TabIndex = 0;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(28, 94);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(90, 15);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Choose Patient:";
            // 
            // lblBookAppt
            // 
            lblBookAppt.AutoSize = true;
            lblBookAppt.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookAppt.Location = new Point(135, 27);
            lblBookAppt.Name = "lblBookAppt";
            lblBookAppt.Size = new Size(202, 30);
            lblBookAppt.TabIndex = 6;
            lblBookAppt.Text = "Book Appointment";
            lblBookAppt.TextAlign = ContentAlignment.TopCenter;
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(234, 112);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(202, 23);
            cboDoctor.TabIndex = 7;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(234, 94);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(89, 15);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "Choose Doctor:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(28, 166);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(202, 23);
            dtpDate.TabIndex = 9;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(28, 148);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(77, 15);
            lblTime.TabIndex = 10;
            lblTime.Text = "Choose Date:";
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(28, 220);
            txtPurpose.Multiline = true;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.PlaceholderText = "State Appointment Purpose...";
            txtPurpose.Size = new Size(408, 85);
            txtPurpose.TabIndex = 11;
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Location = new Point(28, 202);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(53, 15);
            lblPurpose.TabIndex = 12;
            lblPurpose.Text = "Purpose:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLightLight;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(244, 322);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(93, 31);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.DialogResult = DialogResult.OK;
            btnConfirm.Location = new Point(343, 322);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.RightToLeft = RightToLeft.No;
            btnConfirm.Size = new Size(93, 31);
            btnConfirm.TabIndex = 24;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 148);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 26;
            label1.Text = "Choose Time:";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Location = new Point(236, 166);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(200, 23);
            cboTime.TabIndex = 27;
            // 
            // BookAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 365);
            Controls.Add(cboTime);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(lblPurpose);
            Controls.Add(txtPurpose);
            Controls.Add(lblTime);
            Controls.Add(dtpDate);
            Controls.Add(lblDoctor);
            Controls.Add(cboDoctor);
            Controls.Add(lblBookAppt);
            Controls.Add(lblPatient);
            Controls.Add(cboPatient);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BookAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookAppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPatient;
        private Label lblPatient;
        private Label lblBookAppt;
        private ComboBox cboDoctor;
        private Label lblDoctor;
        private DateTimePicker dtpDate;
        private Label lblTime;
        private TextBox txtPurpose;
        private Label lblPurpose;
        private Button btnCancel;
        private Button btnConfirm;
        private Label label1;
        private ComboBox cboTime;
    }
}