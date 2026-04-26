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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            pnlBackground = new Panel();
            pnlContainer = new Panel();
            dtpDOB = new DateTimePicker();
            lblDobError = new Label();
            txtAllergies = new ReaLTaiizor.Controls.HopeTextBox();
            lblAllergy = new Label();
            lblEmergencyError = new Label();
            lblContactError = new Label();
            txtAddress = new ReaLTaiizor.Controls.HopeTextBox();
            lblAddress = new Label();
            txtEmergency = new ReaLTaiizor.Controls.HopeTextBox();
            lblEmergency = new Label();
            txtContact = new ReaLTaiizor.Controls.HopeTextBox();
            lblContact = new Label();
            lblDOB = new Label();
            lblSexError = new Label();
            lblFirstNameError = new Label();
            lblLastNameError = new Label();
            cboSex = new ReaLTaiizor.Controls.HopeComboBox();
            lblSex = new Label();
            txtLastName = new ReaLTaiizor.Controls.HopeTextBox();
            lblLastName = new Label();
            txtFirstName = new ReaLTaiizor.Controls.HopeTextBox();
            lblFirstName = new Label();
            panel1 = new Panel();
            lblMeta = new Label();
            label1 = new Label();
            button1 = new ReaLTaiizor.Controls.Button();
            button2 = new ReaLTaiizor.Controls.Button();
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
            pnlBackground.Controls.Add(button2);
            pnlBackground.Controls.Add(btnCancel);
            pnlBackground.Controls.Add(btnSave);
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(611, 693);
            pnlBackground.TabIndex = 2;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.FromArgb(108, 111, 127);
            pnlContainer.Controls.Add(dtpDOB);
            pnlContainer.Controls.Add(lblDobError);
            pnlContainer.Controls.Add(txtAllergies);
            pnlContainer.Controls.Add(lblAllergy);
            pnlContainer.Controls.Add(lblEmergencyError);
            pnlContainer.Controls.Add(lblContactError);
            pnlContainer.Controls.Add(txtAddress);
            pnlContainer.Controls.Add(lblAddress);
            pnlContainer.Controls.Add(txtEmergency);
            pnlContainer.Controls.Add(lblEmergency);
            pnlContainer.Controls.Add(txtContact);
            pnlContainer.Controls.Add(lblContact);
            pnlContainer.Controls.Add(lblDOB);
            pnlContainer.Controls.Add(lblSexError);
            pnlContainer.Controls.Add(lblFirstNameError);
            pnlContainer.Controls.Add(lblLastNameError);
            pnlContainer.Controls.Add(cboSex);
            pnlContainer.Controls.Add(lblSex);
            pnlContainer.Controls.Add(txtLastName);
            pnlContainer.Controls.Add(lblLastName);
            pnlContainer.Controls.Add(txtFirstName);
            pnlContainer.Controls.Add(lblFirstName);
            pnlContainer.ForeColor = Color.FromArgb(226, 230, 237);
            pnlContainer.Location = new Point(30, 149);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(550, 467);
            pnlContainer.TabIndex = 1;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(22, 131);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(505, 27);
            dtpDOB.TabIndex = 45;
            // 
            // lblDobError
            // 
            lblDobError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblDobError.ForeColor = Color.FromArgb(153, 27, 27);
            lblDobError.Location = new Point(10, 161);
            lblDobError.Name = "lblDobError";
            lblDobError.Size = new Size(247, 25);
            lblDobError.TabIndex = 44;
            lblDobError.Visible = false;
            // 
            // txtAllergies
            // 
            txtAllergies.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAllergies.BackColor = Color.FromArgb(197, 202, 212);
            txtAllergies.BaseColor = Color.FromArgb(108, 111, 127);
            txtAllergies.BorderColorA = Color.FromArgb(108, 111, 127);
            txtAllergies.BorderColorB = Color.FromArgb(108, 111, 127);
            txtAllergies.Font = new Font("TT Interphases Pro Trl", 10F);
            txtAllergies.ForeColor = Color.FromArgb(26, 35, 48);
            txtAllergies.Hint = "Ex: Peanuts";
            txtAllergies.Location = new Point(22, 388);
            txtAllergies.Margin = new Padding(3, 3, 0, 3);
            txtAllergies.MaxLength = 32767;
            txtAllergies.Multiline = false;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.PasswordChar = '\0';
            txtAllergies.ScrollBars = ScrollBars.None;
            txtAllergies.SelectedText = "";
            txtAllergies.SelectionLength = 0;
            txtAllergies.SelectionStart = 0;
            txtAllergies.Size = new Size(505, 37);
            txtAllergies.TabIndex = 43;
            txtAllergies.TabStop = false;
            txtAllergies.UseSystemPasswordChar = false;
            txtAllergies.KeyDown += AddPatientForm_KeyDown;
            // 
            // lblAllergy
            // 
            lblAllergy.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblAllergy.ForeColor = Color.FromArgb(26, 35, 48);
            lblAllergy.Location = new Point(22, 365);
            lblAllergy.Name = "lblAllergy";
            lblAllergy.Size = new Size(134, 26);
            lblAllergy.TabIndex = 42;
            lblAllergy.Text = "Known Allergies";
            // 
            // lblEmergencyError
            // 
            lblEmergencyError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblEmergencyError.ForeColor = Color.FromArgb(153, 27, 27);
            lblEmergencyError.Location = new Point(283, 334);
            lblEmergencyError.Name = "lblEmergencyError";
            lblEmergencyError.Size = new Size(188, 25);
            lblEmergencyError.TabIndex = 41;
            lblEmergencyError.Visible = false;
            // 
            // lblContactError
            // 
            lblContactError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblContactError.ForeColor = Color.FromArgb(153, 27, 27);
            lblContactError.Location = new Point(22, 334);
            lblContactError.Name = "lblContactError";
            lblContactError.Size = new Size(188, 25);
            lblContactError.TabIndex = 40;
            lblContactError.Visible = false;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BackColor = Color.FromArgb(197, 202, 212);
            txtAddress.BaseColor = Color.FromArgb(108, 111, 127);
            txtAddress.BorderColorA = Color.FromArgb(108, 111, 127);
            txtAddress.BorderColorB = Color.FromArgb(108, 111, 127);
            txtAddress.Font = new Font("TT Interphases Pro Trl", 10F);
            txtAddress.ForeColor = Color.FromArgb(26, 35, 48);
            txtAddress.Hint = "Street, Barangay, Municipality, Province";
            txtAddress.Location = new Point(22, 211);
            txtAddress.Margin = new Padding(3, 3, 0, 3);
            txtAddress.MaxLength = 32767;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.ScrollBars = ScrollBars.None;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.Size = new Size(505, 37);
            txtAddress.TabIndex = 39;
            txtAddress.TabStop = false;
            txtAddress.UseSystemPasswordChar = false;
            txtAddress.KeyDown += AddPatientForm_KeyDown;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblAddress.ForeColor = Color.FromArgb(26, 35, 48);
            lblAddress.Location = new Point(22, 189);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 17);
            lblAddress.TabIndex = 38;
            lblAddress.Text = "Address";
            // 
            // txtEmergency
            // 
            txtEmergency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmergency.BackColor = Color.FromArgb(197, 202, 212);
            txtEmergency.BaseColor = Color.FromArgb(108, 111, 127);
            txtEmergency.BorderColorA = Color.FromArgb(108, 111, 127);
            txtEmergency.BorderColorB = Color.FromArgb(108, 111, 127);
            txtEmergency.Font = new Font("TT Interphases Pro Trl", 10F);
            txtEmergency.ForeColor = Color.FromArgb(26, 35, 48);
            txtEmergency.Hint = "09xxxxxxxxx";
            txtEmergency.Location = new Point(279, 297);
            txtEmergency.Margin = new Padding(3, 3, 0, 3);
            txtEmergency.MaxLength = 32767;
            txtEmergency.Multiline = false;
            txtEmergency.Name = "txtEmergency";
            txtEmergency.PasswordChar = '\0';
            txtEmergency.ScrollBars = ScrollBars.None;
            txtEmergency.SelectedText = "";
            txtEmergency.SelectionLength = 0;
            txtEmergency.SelectionStart = 0;
            txtEmergency.Size = new Size(246, 37);
            txtEmergency.TabIndex = 37;
            txtEmergency.TabStop = false;
            txtEmergency.UseSystemPasswordChar = false;
            txtEmergency.KeyDown += AddPatientForm_KeyDown;
            // 
            // lblEmergency
            // 
            lblEmergency.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblEmergency.ForeColor = Color.FromArgb(26, 35, 48);
            lblEmergency.Location = new Point(279, 276);
            lblEmergency.Name = "lblEmergency";
            lblEmergency.Size = new Size(175, 26);
            lblEmergency.TabIndex = 36;
            lblEmergency.Text = "Emergency Contact No.";
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtContact.BackColor = Color.FromArgb(197, 202, 212);
            txtContact.BaseColor = Color.FromArgb(108, 111, 127);
            txtContact.BorderColorA = Color.FromArgb(108, 111, 127);
            txtContact.BorderColorB = Color.FromArgb(108, 111, 127);
            txtContact.Font = new Font("TT Interphases Pro Trl", 10F);
            txtContact.ForeColor = Color.FromArgb(26, 35, 48);
            txtContact.Hint = "09xxxxxxxxx";
            txtContact.Location = new Point(22, 297);
            txtContact.Margin = new Padding(3, 3, 0, 3);
            txtContact.MaxLength = 32767;
            txtContact.Multiline = false;
            txtContact.Name = "txtContact";
            txtContact.PasswordChar = '\0';
            txtContact.ScrollBars = ScrollBars.None;
            txtContact.SelectedText = "";
            txtContact.SelectionLength = 0;
            txtContact.SelectionStart = 0;
            txtContact.Size = new Size(246, 37);
            txtContact.TabIndex = 35;
            txtContact.TabStop = false;
            txtContact.UseSystemPasswordChar = false;
            txtContact.KeyDown += AddPatientForm_KeyDown;
            // 
            // lblContact
            // 
            lblContact.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblContact.ForeColor = Color.FromArgb(26, 35, 48);
            lblContact.Location = new Point(22, 276);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(88, 17);
            lblContact.TabIndex = 34;
            lblContact.Text = "Contact No.";
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblDOB.ForeColor = Color.FromArgb(26, 35, 48);
            lblDOB.Location = new Point(22, 108);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(122, 25);
            lblDOB.TabIndex = 33;
            lblDOB.Text = "Date of Birth";
            // 
            // lblSexError
            // 
            lblSexError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblSexError.ForeColor = Color.FromArgb(153, 27, 27);
            lblSexError.Location = new Point(429, 82);
            lblSexError.Name = "lblSexError";
            lblSexError.Size = new Size(109, 25);
            lblSexError.TabIndex = 31;
            lblSexError.Visible = false;
            // 
            // lblFirstNameError
            // 
            lblFirstNameError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblFirstNameError.ForeColor = Color.FromArgb(153, 27, 27);
            lblFirstNameError.Location = new Point(22, 81);
            lblFirstNameError.Name = "lblFirstNameError";
            lblFirstNameError.Size = new Size(188, 25);
            lblFirstNameError.TabIndex = 29;
            lblFirstNameError.Visible = false;
            // 
            // lblLastNameError
            // 
            lblLastNameError.Font = new Font("Panton Narrow-Trial SemiBold", 7.5F);
            lblLastNameError.ForeColor = Color.FromArgb(153, 27, 27);
            lblLastNameError.Location = new Point(223, 81);
            lblLastNameError.Name = "lblLastNameError";
            lblLastNameError.Size = new Size(188, 25);
            lblLastNameError.TabIndex = 30;
            lblLastNameError.Visible = false;
            // 
            // cboSex
            // 
            cboSex.DrawMode = DrawMode.OwnerDrawFixed;
            cboSex.FlatStyle = FlatStyle.Flat;
            cboSex.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboSex.ForeColor = Color.FromArgb(226, 230, 237);
            cboSex.FormattingEnabled = true;
            cboSex.ItemHeight = 30;
            cboSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cboSex.Location = new Point(425, 44);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(102, 36);
            cboSex.TabIndex = 28;
            // 
            // lblSex
            // 
            lblSex.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblSex.ForeColor = Color.FromArgb(26, 35, 48);
            lblSex.Location = new Point(425, 24);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(100, 17);
            lblSex.TabIndex = 27;
            lblSex.Text = "Sex";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BackColor = Color.FromArgb(197, 202, 212);
            txtLastName.BaseColor = Color.FromArgb(108, 111, 127);
            txtLastName.BorderColorA = Color.FromArgb(108, 111, 127);
            txtLastName.BorderColorB = Color.FromArgb(108, 111, 127);
            txtLastName.Font = new Font("TT Interphases Pro Trl", 10F);
            txtLastName.ForeColor = Color.FromArgb(26, 35, 48);
            txtLastName.Hint = "ex: Doe";
            txtLastName.Location = new Point(223, 44);
            txtLastName.Margin = new Padding(3, 3, 0, 3);
            txtLastName.MaxLength = 32767;
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.PasswordChar = '\0';
            txtLastName.ScrollBars = ScrollBars.None;
            txtLastName.SelectedText = "";
            txtLastName.SelectionLength = 0;
            txtLastName.SelectionStart = 0;
            txtLastName.Size = new Size(190, 37);
            txtLastName.TabIndex = 26;
            txtLastName.TabStop = false;
            txtLastName.UseSystemPasswordChar = false;
            txtLastName.KeyDown += AddPatientForm_KeyDown;
            // 
            // lblLastName
            // 
            lblLastName.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblLastName.ForeColor = Color.FromArgb(26, 35, 48);
            lblLastName.Location = new Point(223, 24);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 17);
            lblLastName.TabIndex = 25;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.BackColor = Color.FromArgb(197, 202, 212);
            txtFirstName.BaseColor = Color.FromArgb(108, 111, 127);
            txtFirstName.BorderColorA = Color.FromArgb(108, 111, 127);
            txtFirstName.BorderColorB = Color.FromArgb(108, 111, 127);
            txtFirstName.Font = new Font("TT Interphases Pro Trl", 10F);
            txtFirstName.ForeColor = Color.FromArgb(26, 35, 48);
            txtFirstName.Hint = "ex: John";
            txtFirstName.Location = new Point(22, 44);
            txtFirstName.Margin = new Padding(3, 3, 0, 3);
            txtFirstName.MaxLength = 32767;
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PasswordChar = '\0';
            txtFirstName.ScrollBars = ScrollBars.None;
            txtFirstName.SelectedText = "";
            txtFirstName.SelectionLength = 0;
            txtFirstName.SelectionStart = 0;
            txtFirstName.Size = new Size(190, 37);
            txtFirstName.TabIndex = 24;
            txtFirstName.TabStop = false;
            txtFirstName.UseSystemPasswordChar = false;
            txtFirstName.KeyDown += AddPatientForm_KeyDown;
            // 
            // lblFirstName
            // 
            lblFirstName.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            lblFirstName.ForeColor = Color.FromArgb(26, 35, 48);
            lblFirstName.Location = new Point(22, 24);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 17);
            lblFirstName.TabIndex = 23;
            lblFirstName.Text = "First Name";
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
            // lblMeta
            // 
            lblMeta.Anchor = AnchorStyles.Left;
            lblMeta.AutoSize = true;
            lblMeta.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblMeta.ForeColor = Color.FromArgb(92, 102, 114);
            lblMeta.Location = new Point(144, 49);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(290, 21);
            lblMeta.TabIndex = 40;
            lblMeta.Text = "Fill the details to register new patient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(197, 202, 212);
            label1.Location = new Point(142, 16);
            label1.Margin = new Padding(0, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 39;
            label1.Text = "Add New Patient";
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
            button2.TabIndex = 41;
            button2.TextAlignment = StringAlignment.Center;
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
            btnCancel.Location = new Point(372, 631);
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
            btnSave.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnSave.EnteredColor = Color.FromArgb(69, 85, 97);
            btnSave.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(26, 35, 48);
            btnSave.Location = new Point(482, 631);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(22, 101, 52);
            btnSave.PressedColor = Color.FromArgb(22, 101, 52);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save User";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // AddPatientForm
            // 
            ClientSize = new Size(611, 693);
            Controls.Add(pnlBackground);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddPatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Patient";
            pnlBackground.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlBackground;
        private ReaLTaiizor.Controls.Button btnCancel;
        private ReaLTaiizor.Controls.Button btnSave;
        private Panel pnlContainer;
        private Label lblFirstNameError;
        private Label lblLastNameError;
        private ReaLTaiizor.Controls.HopeComboBox cboSex;
        private Label lblSex;
        private ReaLTaiizor.Controls.HopeTextBox txtLastName;
        private Label lblLastName;
        private ReaLTaiizor.Controls.HopeTextBox txtFirstName;
        private Label lblFirstName;
        private Label lblSexError;
        private Label lblDOB;
        private ReaLTaiizor.Controls.HopeTextBox txtEmergency;
        private Label lblEmergency;
        private ReaLTaiizor.Controls.HopeTextBox txtContact;
        private Label lblContact;
        private Label lblContactError;
        private ReaLTaiizor.Controls.HopeTextBox txtAddress;
        private Label lblAddress;
        private Label lblEmergencyError;
        private ReaLTaiizor.Controls.HopeTextBox txtAllergies;
        private Label lblAllergy;
        private Label lblDobError;
        private DateTimePicker dtpDOB;
        private Panel panel1;
        private Label lblMeta;
        private Label label1;
        protected internal ReaLTaiizor.Controls.Button button1;
        protected internal ReaLTaiizor.Controls.Button button2;
    }
}