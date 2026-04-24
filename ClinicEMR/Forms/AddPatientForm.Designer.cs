namespace ClinicEMR.Forms
{
    partial class AddPatientForm
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

        private TextBox txtFirstName, txtLastName, txtAddress, txtContact, txtEmergency, txtAllergies;
        private DateTimePicker dtpDOB;
        private ComboBox cboSex;

        private Label lblFirstName, lblLastName, lblAddress, lblContact, lblEmergency, lblAllergies, lblDOB, lblSex;
        private Label lblFirstNameError, lblLastNameError, lblSexError, lblDobError, lblContactError, lblEmergencyError;

        private ReaLTaiizor.Controls.Button btnSave, btnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            pnlBackground = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pnlContainer = new Panel();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblFirstNameError = new Label();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblLastNameError = new Label();
            lblSex = new Label();
            cboSex = new ComboBox();
            lblSexError = new Label();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            lblDobError = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblContactError = new Label();
            lblEmergency = new Label();
            txtEmergency = new TextBox();
            lblEmergencyError = new Label();
            lblAllergies = new Label();
            txtAllergies = new TextBox();
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
            pnlBackground.Controls.Add(lblTitle);
            pnlBackground.Controls.Add(pnlContainer);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(480, 550);
            pnlBackground.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 95);
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
            lblTitle.Text = "Add New Patient";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Controls.Add(lblFirstName);
            pnlContainer.Controls.Add(txtFirstName);
            pnlContainer.Controls.Add(lblFirstNameError);
            pnlContainer.Controls.Add(lblLastName);
            pnlContainer.Controls.Add(txtLastName);
            pnlContainer.Controls.Add(lblLastNameError);
            pnlContainer.Controls.Add(lblSex);
            pnlContainer.Controls.Add(cboSex);
            pnlContainer.Controls.Add(lblSexError);
            pnlContainer.Controls.Add(lblDOB);
            pnlContainer.Controls.Add(dtpDOB);
            pnlContainer.Controls.Add(lblDobError);
            pnlContainer.Controls.Add(lblAddress);
            pnlContainer.Controls.Add(txtAddress);
            pnlContainer.Controls.Add(lblContact);
            pnlContainer.Controls.Add(txtContact);
            pnlContainer.Controls.Add(lblContactError);
            pnlContainer.Controls.Add(lblEmergency);
            pnlContainer.Controls.Add(txtEmergency);
            pnlContainer.Controls.Add(lblEmergencyError);
            pnlContainer.Controls.Add(lblAllergies);
            pnlContainer.Controls.Add(txtAllergies);
            pnlContainer.Controls.Add(btnCancel);
            pnlContainer.Controls.Add(btnSave);
            pnlContainer.Location = new Point(20, 170);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(440, 360);
            pnlContainer.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Segoe UI", 9F);
            lblFirstName.ForeColor = Color.FromArgb(49, 62, 80);
            lblFirstName.Location = new Point(10, 10);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 17);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.Location = new Point(10, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblFirstNameError.ForeColor = Color.Firebrick;
            lblFirstNameError.Location = new Point(10, 55);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(200, 25);
            lblFirstNameError.TabIndex = 2;
            lblFirstNameError.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Segoe UI", 9F);
            lblLastName.ForeColor = Color.FromArgb(49, 62, 80);
            lblLastName.Location = new Point(220, 10);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 17);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.Location = new Point(220, 30);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 4;
            // 
            // lblLastNameError
            // 
            lblLastNameError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblLastNameError.ForeColor = Color.Firebrick;
            lblLastNameError.Location = new Point(220, 55);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(200, 25);
            lblLastNameError.TabIndex = 5;
            lblLastNameError.Visible = false;
            // 
            // lblSex
            // 
            lblSex.Font = new Font("Segoe UI", 9F);
            lblSex.ForeColor = Color.FromArgb(49, 62, 80);
            lblSex.Location = new Point(10, 80);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(100, 17);
            lblSex.TabIndex = 6;
            lblSex.Text = "Sex:";
            // 
            // cboSex
            // 
            cboSex.Font = new Font("Segoe UI", 9F);
            cboSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cboSex.Location = new Point(10, 100);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(120, 23);
            cboSex.TabIndex = 7;
            // 
            // lblSexError
            // 
            lblSexError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblSexError.ForeColor = Color.Firebrick;
            lblSexError.Location = new Point(10, 125);
            lblSexError.Name = "lblSexError";
            lblSexError.Size = new Size(120, 25);
            lblSexError.TabIndex = 8;
            lblSexError.Visible = false;
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Segoe UI", 9F);
            lblDOB.ForeColor = Color.FromArgb(49, 62, 80);
            lblDOB.Location = new Point(150, 80);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(100, 17);
            lblDOB.TabIndex = 9;
            lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Segoe UI", 9F);
            dtpDOB.Location = new Point(150, 100);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(270, 23);
            dtpDOB.TabIndex = 10;
            // 
            // lblDobError
            // 
            lblDobError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblDobError.ForeColor = Color.Firebrick;
            lblDobError.Location = new Point(150, 125);
            lblDobError.Name = "lblDobError";
            lblDobError.Size = new Size(270, 25);
            lblDobError.TabIndex = 11;
            lblDobError.Visible = false;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.ForeColor = Color.FromArgb(49, 62, 80);
            lblAddress.Location = new Point(10, 150);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 17);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(10, 170);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(410, 23);
            txtAddress.TabIndex = 13;
            // 
            // lblContact
            // 
            lblContact.Font = new Font("Segoe UI", 9F);
            lblContact.ForeColor = Color.FromArgb(49, 62, 80);
            lblContact.Location = new Point(10, 200);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(100, 17);
            lblContact.TabIndex = 14;
            lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 9F);
            txtContact.Location = new Point(10, 220);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 23);
            txtContact.TabIndex = 15;
            // 
            // lblContactError
            // 
            lblContactError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblContactError.ForeColor = Color.Firebrick;
            lblContactError.Location = new Point(10, 245);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(200, 25);
            lblContactError.TabIndex = 16;
            lblContactError.Visible = false;
            // 
            // lblEmergency
            // 
            lblEmergency.Font = new Font("Segoe UI", 9F);
            lblEmergency.ForeColor = Color.FromArgb(49, 62, 80);
            lblEmergency.Location = new Point(220, 200);
            lblEmergency.Name = "lblEmergency";
            lblEmergency.Size = new Size(100, 17);
            lblEmergency.TabIndex = 17;
            lblEmergency.Text = "Emergency Contact:";
            // 
            // txtEmergency
            // 
            txtEmergency.Font = new Font("Segoe UI", 9F);
            txtEmergency.Location = new Point(220, 220);
            txtEmergency.Name = "txtEmergency";
            txtEmergency.Size = new Size(200, 23);
            txtEmergency.TabIndex = 18;
            // 
            // lblEmergencyError
            // 
            lblEmergencyError.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblEmergencyError.ForeColor = Color.Firebrick;
            lblEmergencyError.Location = new Point(220, 245);
            lblEmergencyError.Name = "lblEmergencyError";
            lblEmergencyError.Size = new Size(200, 25);
            lblEmergencyError.TabIndex = 19;
            lblEmergencyError.Visible = false;
            // 
            // lblAllergies
            // 
            lblAllergies.Font = new Font("Segoe UI", 9F);
            lblAllergies.ForeColor = Color.FromArgb(49, 62, 80);
            lblAllergies.Location = new Point(10, 270);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(100, 17);
            lblAllergies.TabIndex = 20;
            lblAllergies.Text = "Known Allergies:";
            // 
            // txtAllergies
            // 
            txtAllergies.Font = new Font("Segoe UI", 9F);
            txtAllergies.Location = new Point(10, 290);
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(410, 23);
            txtAllergies.TabIndex = 21;
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
            btnCancel.Location = new Point(220, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BorderColor = Color.FromArgb(108, 111, 127);
            btnSave.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnSave.EnteredColor = Color.FromArgb(69, 85, 97);
            btnSave.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(26, 35, 48);
            btnSave.Location = new Point(330, 320);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSave.PressedColor = Color.FromArgb(165, 37, 37);
            btnSave.Size = new Size(90, 30);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save Patient";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // AddPatientForm
            // 
            ClientSize = new Size(480, 550);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddPatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Patient";
            pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }
    }
}