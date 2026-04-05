namespace ClinicEMR.Forms
{
    partial class AddPatientForm
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
            txtFirstName = new TextBox();
            lblNewPatient = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtContact = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmergency = new Label();
            txtEmergency = new TextBox();
            lblAllergies = new Label();
            txtAllergies = new TextBox();
            dtpDOB = new DateTimePicker();
            lblDOB = new Label();
            cboSex = new ComboBox();
            lblSex = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 186);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 23);
            txtFirstName.TabIndex = 4;
            // 
            // lblNewPatient
            // 
            lblNewPatient.AutoSize = true;
            lblNewPatient.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPatient.Location = new Point(137, 33);
            lblNewPatient.Name = "lblNewPatient";
            lblNewPatient.Size = new Size(190, 30);
            lblNewPatient.TabIndex = 5;
            lblNewPatient.Text = "New Patient Form";
            lblNewPatient.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(194, 186);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(179, 23);
            txtLastName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 277);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "Contact Number:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(12, 295);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(219, 23);
            txtContact.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 222);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address:";
            lblAddress.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 240);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(219, 23);
            txtAddress.TabIndex = 11;
            // 
            // lblEmergency
            // 
            lblEmergency.AutoSize = true;
            lblEmergency.Location = new Point(237, 277);
            lblEmergency.Name = "lblEmergency";
            lblEmergency.Size = new Size(114, 15);
            lblEmergency.TabIndex = 12;
            lblEmergency.Text = "Emergency Contact:";
            lblEmergency.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtEmergency
            // 
            txtEmergency.Location = new Point(237, 295);
            txtEmergency.Name = "txtEmergency";
            txtEmergency.Size = new Size(223, 23);
            txtEmergency.TabIndex = 13;
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Location = new Point(12, 332);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(95, 15);
            lblAllergies.TabIndex = 14;
            lblAllergies.Text = "Known Allergies:";
            lblAllergies.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtAllergies
            // 
            txtAllergies.Location = new Point(12, 350);
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(448, 23);
            txtAllergies.TabIndex = 15;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(237, 240);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(223, 23);
            dtpDOB.TabIndex = 16;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(237, 222);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(76, 15);
            lblDOB.TabIndex = 17;
            lblDOB.Text = "Date of Birth:";
            lblDOB.TextAlign = ContentAlignment.TopCenter;
            // 
            // cboSex
            // 
            cboSex.FormattingEnabled = true;
            cboSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cboSex.Location = new Point(379, 186);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(81, 23);
            cboSex.TabIndex = 18;
            // 
            // lblSex
            // 
            lblSex.AutoSize = true;
            lblSex.Location = new Point(379, 168);
            lblSex.Name = "lblSex";
            lblSex.Size = new Size(27, 15);
            lblSex.TabIndex = 19;
            lblSex.Text = "Sex:";
            lblSex.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(367, 391);
            btnSave.Name = "btnSave";
            btnSave.RightToLeft = RightToLeft.No;
            btnSave.Size = new Size(93, 31);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save Patient";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLightLight;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(268, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(93, 31);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(12, 168);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 15);
            lblFirstName.TabIndex = 22;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(194, 168);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(68, 15);
            lblLastName.TabIndex = 23;
            lblLastName.Text = "Last Name:";
            // 
            // AddPatientForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(472, 434);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblSex);
            Controls.Add(cboSex);
            Controls.Add(lblDOB);
            Controls.Add(dtpDOB);
            Controls.Add(txtAllergies);
            Controls.Add(lblAllergies);
            Controls.Add(txtEmergency);
            Controls.Add(lblEmergency);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContact);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(lblNewPatient);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddPatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label lblNewPatient;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtContact;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblEmergency;
        private TextBox txtEmergency;
        private Label lblAllergies;
        private TextBox txtAllergies;
        private DateTimePicker dtpDOB;
        private Label lblDOB;
        private ComboBox cboSex;
        private Label lblSex;
        private Button btnSave;
        private Button btnCancel;
        private Label lblFirstName;
        private Label lblLastName;
    }
}