namespace ClinicEMR.Forms
{
    partial class BookAppointmentForm
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
        private Panel pnlContainer;
        private Label lblTitle;
        private PictureBox pictureBox1;

        private ComboBox cboPatient, cboDoctor, cboTime;
        private DateTimePicker dtpDate;
        private TextBox txtPurpose;

        private Label lblPatient, lblDoctor, lblDate, lblTime, lblPurpose;

        private ReaLTaiizor.Controls.Button btnConfirm, btnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAppointmentForm));
            pnlBackground = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pnlContainer = new Panel();
            lblPatient = new Label();
            cboPatient = new ComboBox();
            lblDoctor = new Label();
            cboDoctor = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblTime = new Label();
            cboTime = new ComboBox();
            lblPurpose = new Label();
            txtPurpose = new TextBox();
            btnCancel = new ReaLTaiizor.Controls.Button();
            btnConfirm = new ReaLTaiizor.Controls.Button();
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
            pnlBackground.Size = new Size(474, 502);
            pnlBackground.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(186, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 120);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(480, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Book Appointment";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Controls.Add(lblPatient);
            pnlContainer.Controls.Add(cboPatient);
            pnlContainer.Controls.Add(lblDoctor);
            pnlContainer.Controls.Add(cboDoctor);
            pnlContainer.Controls.Add(lblDate);
            pnlContainer.Controls.Add(dtpDate);
            pnlContainer.Controls.Add(lblTime);
            pnlContainer.Controls.Add(cboTime);
            pnlContainer.Controls.Add(lblPurpose);
            pnlContainer.Controls.Add(txtPurpose);
            pnlContainer.Controls.Add(btnCancel);
            pnlContainer.Controls.Add(btnConfirm);
            pnlContainer.Location = new Point(20, 170);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(435, 306);
            pnlContainer.TabIndex = 2;
            // 
            // lblPatient
            // 
            lblPatient.Font = new Font("Segoe UI", 9F);
            lblPatient.ForeColor = Color.FromArgb(49, 62, 80);
            lblPatient.Location = new Point(10, 10);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(100, 17);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "Choose Patient:";
            // 
            // cboPatient
            // 
            cboPatient.Font = new Font("Segoe UI", 9F);
            cboPatient.Location = new Point(10, 30);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(200, 23);
            cboPatient.TabIndex = 1;
            // 
            // lblDoctor
            // 
            lblDoctor.Font = new Font("Segoe UI", 9F);
            lblDoctor.ForeColor = Color.FromArgb(49, 62, 80);
            lblDoctor.Location = new Point(220, 10);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(100, 17);
            lblDoctor.TabIndex = 2;
            lblDoctor.Text = "Choose Doctor:";
            // 
            // cboDoctor
            // 
            cboDoctor.Font = new Font("Segoe UI", 9F);
            cboDoctor.Location = new Point(220, 30);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(200, 23);
            cboDoctor.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 9F);
            lblDate.ForeColor = Color.FromArgb(49, 62, 80);
            lblDate.Location = new Point(10, 70);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 17);
            lblDate.TabIndex = 4;
            lblDate.Text = "Choose Date:";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 9F);
            dtpDate.Location = new Point(10, 90);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 9F);
            lblTime.ForeColor = Color.FromArgb(49, 62, 80);
            lblTime.Location = new Point(220, 70);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 17);
            lblTime.TabIndex = 6;
            lblTime.Text = "Choose Time:";
            // 
            // cboTime
            // 
            cboTime.Font = new Font("Segoe UI", 9F);
            cboTime.Location = new Point(220, 90);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(200, 23);
            cboTime.TabIndex = 7;
            // 
            // lblPurpose
            // 
            lblPurpose.Font = new Font("Segoe UI", 9F);
            lblPurpose.ForeColor = Color.FromArgb(49, 62, 80);
            lblPurpose.Location = new Point(10, 130);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(100, 14);
            lblPurpose.TabIndex = 8;
            lblPurpose.Text = "Purpose:";
            // 
            // txtPurpose
            // 
            txtPurpose.Font = new Font("Segoe UI", 9F);
            txtPurpose.Location = new Point(10, 147);
            txtPurpose.Multiline = true;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(410, 80);
            txtPurpose.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(108, 111, 127);
            btnCancel.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnCancel.EnteredColor = Color.FromArgb(69, 85, 97);
            btnCancel.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnCancel.Image = null;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.InactiveColor = Color.FromArgb(92, 102, 114);
            btnCancel.Location = new Point(220, 255);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.BorderColor = Color.FromArgb(32, 34, 37);
            btnConfirm.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnConfirm.EnteredColor = Color.FromArgb(32, 34, 37);
            btnConfirm.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnConfirm.Image = null;
            btnConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirm.InactiveColor = Color.FromArgb(32, 34, 37);
            btnConfirm.Location = new Point(330, 255);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnConfirm.PressedColor = Color.FromArgb(165, 37, 37);
            btnConfirm.Size = new Size(90, 30);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextAlignment = StringAlignment.Center;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // BookAppointmentForm
            // 
            ClientSize = new Size(474, 502);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BookAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Appointment";
            pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }
    }
}