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

		#region Windows Form Designer generated code

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
			btnSave = new ReaLTaiizor.Controls.Button();
			btnCancel = new ReaLTaiizor.Controls.Button();
			lblFirstName = new Label();
			lblLastName = new Label();
			lblFirstNameError = new Label();
			lblLastNameError = new Label();
			lblSexError = new Label();
			lblDobError = new Label();
			lblContactError = new Label();
			lblEmergencyError = new Label();
			SuspendLayout();
			// 
			// txtFirstName
			// 
			txtFirstName.BackColor = Color.White;
			txtFirstName.BorderStyle = BorderStyle.FixedSingle;
			txtFirstName.Font = new Font("Segoe UI", 9.5F);
			txtFirstName.Location = new Point(17, 138);
			txtFirstName.Margin = new Padding(4, 5, 4, 5);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(251, 31);
			txtFirstName.TabIndex = 4;
			// 
			// lblNewPatient
			// 
			lblNewPatient.BackColor = Color.FromArgb(37, 45, 56);
			lblNewPatient.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			lblNewPatient.ForeColor = Color.FromArgb(226, 230, 237);
			lblNewPatient.Location = new Point(0, 0);
			lblNewPatient.Margin = new Padding(4, 0, 4, 0);
			lblNewPatient.Name = "lblNewPatient";
			lblNewPatient.Size = new Size(674, 83);
			lblNewPatient.TabIndex = 5;
			lblNewPatient.Text = "New Patient Form";
			lblNewPatient.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtLastName
			// 
			txtLastName.BackColor = Color.White;
			txtLastName.BorderStyle = BorderStyle.FixedSingle;
			txtLastName.Font = new Font("Segoe UI", 9.5F);
			txtLastName.Location = new Point(277, 138);
			txtLastName.Margin = new Padding(4, 5, 4, 5);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(255, 31);
			txtLastName.TabIndex = 6;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			label1.ForeColor = Color.FromArgb(92, 102, 114);
			label1.Location = new Point(17, 325);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(151, 20);
			label1.TabIndex = 8;
			label1.Text = "Contact Number:";
			// 
			// txtContact
			// 
			txtContact.BackColor = Color.White;
			txtContact.BorderStyle = BorderStyle.FixedSingle;
			txtContact.Font = new Font("Segoe UI", 9.5F);
			txtContact.Location = new Point(17, 355);
			txtContact.Margin = new Padding(4, 5, 4, 5);
			txtContact.Name = "txtContact";
			txtContact.Size = new Size(312, 31);
			txtContact.TabIndex = 9;
			// 
			// lblAddress
			// 
			lblAddress.AutoSize = true;
			lblAddress.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			lblAddress.ForeColor = Color.FromArgb(92, 102, 114);
			lblAddress.Location = new Point(17, 217);
			lblAddress.Margin = new Padding(4, 0, 4, 0);
			lblAddress.Name = "lblAddress";
			lblAddress.Size = new Size(84, 20);
			lblAddress.TabIndex = 10;
			lblAddress.Text = "Address:";
			// 
			// txtAddress
			// 
			txtAddress.BackColor = Color.White;
			txtAddress.BorderStyle = BorderStyle.FixedSingle;
			txtAddress.Font = new Font("Segoe UI", 9.5F);
			txtAddress.Location = new Point(17, 247);
			txtAddress.Margin = new Padding(4, 5, 4, 5);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(312, 31);
			txtAddress.TabIndex = 11;
			// 
			// lblEmergency
			// 
			lblEmergency.AutoSize = true;
			lblEmergency.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			lblEmergency.ForeColor = Color.FromArgb(92, 102, 114);
			lblEmergency.Location = new Point(339, 325);
			lblEmergency.Margin = new Padding(4, 0, 4, 0);
			lblEmergency.Name = "lblEmergency";
			lblEmergency.Size = new Size(179, 20);
			lblEmergency.TabIndex = 12;
			lblEmergency.Text = "Emergency Contact:";
			// 
			// txtEmergency
			// 
			txtEmergency.BackColor = Color.White;
			txtEmergency.BorderStyle = BorderStyle.FixedSingle;
			txtEmergency.Font = new Font("Segoe UI", 9.5F);
			txtEmergency.Location = new Point(339, 355);
			txtEmergency.Margin = new Padding(4, 5, 4, 5);
			txtEmergency.Name = "txtEmergency";
			txtEmergency.Size = new Size(318, 31);
			txtEmergency.TabIndex = 13;
			// 
			// lblAllergies
			// 
			lblAllergies.AutoSize = true;
			lblAllergies.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			lblAllergies.ForeColor = Color.FromArgb(92, 102, 114);
			lblAllergies.Location = new Point(17, 433);
			lblAllergies.Margin = new Padding(4, 0, 4, 0);
			lblAllergies.Name = "lblAllergies";
			lblAllergies.Size = new Size(150, 20);
			lblAllergies.TabIndex = 14;
			lblAllergies.Text = "Known Allergies:";
			// 
			// txtAllergies
			// 
			txtAllergies.BackColor = Color.White;
			txtAllergies.BorderStyle = BorderStyle.FixedSingle;
			txtAllergies.Font = new Font("Segoe UI", 9.5F);
			txtAllergies.Location = new Point(17, 463);
			txtAllergies.Margin = new Padding(4, 5, 4, 5);
			txtAllergies.Name = "txtAllergies";
			txtAllergies.Size = new Size(639, 31);
			txtAllergies.TabIndex = 15;
			// 
			// dtpDOB
			// 
			dtpDOB.Font = new Font("Segoe UI", 9.5F);
			dtpDOB.Location = new Point(339, 247);
			dtpDOB.Margin = new Padding(4, 5, 4, 5);
			dtpDOB.Name = "dtpDOB";
			dtpDOB.Size = new Size(317, 31);
			dtpDOB.TabIndex = 16;
			// 
			// lblDOB
			// 
			lblDOB.AutoSize = true;
			lblDOB.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			lblDOB.ForeColor = Color.FromArgb(92, 102, 114);
			lblDOB.Location = new Point(339, 217);
			lblDOB.Margin = new Padding(4, 0, 4, 0);
			lblDOB.Name = "lblDOB";
			lblDOB.Size = new Size(124, 20);
			lblDOB.TabIndex = 17;
			lblDOB.Text = "Date of Birth:";
			// 
			// cboSex
			// 
			cboSex.BackColor = Color.White;
			cboSex.FlatStyle = FlatStyle.Flat;
			cboSex.Font = new Font("Segoe UI", 9.5F);
			cboSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
			cboSex.Location = new Point(541, 138);
			cboSex.Margin = new Padding(4, 5, 4, 5);
			cboSex.Name = "cboSex";
			cboSex.Size = new Size(114, 33);
			cboSex.TabIndex = 18;
			// 
			// lblSex
			// 
			lblSex.AutoSize = true;
			lblSex.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			lblSex.ForeColor = Color.FromArgb(92, 102, 114);
			lblSex.Location = new Point(541, 108);
			lblSex.Margin = new Padding(4, 0, 4, 0);
			lblSex.Name = "lblSex";
			lblSex.Size = new Size(46, 20);
			lblSex.TabIndex = 19;
			lblSex.Text = "Sex:";
			// 
			// btnSave
			// 
			btnSave.BackColor = Color.Transparent;
			btnSave.BorderColor = Color.FromArgb(37, 45, 56);
			btnSave.Cursor = Cursors.Hand;
			btnSave.EnteredBorderColor = Color.FromArgb(37, 45, 56);
			btnSave.EnteredColor = Color.FromArgb(57, 65, 76);
			btnSave.Font = new Font("Microsoft Sans Serif", 10F);
			btnSave.Image = null;
			btnSave.ImageAlign = ContentAlignment.MiddleLeft;
			btnSave.InactiveColor = Color.FromArgb(37, 45, 56);
			btnSave.Location = new Point(486, 542);
			btnSave.Margin = new Padding(4, 5, 4, 5);
			btnSave.Name = "btnSave";
			btnSave.PressedBorderColor = Color.Black;
			btnSave.PressedColor = Color.Black;
			btnSave.Size = new Size(171, 53);
			btnSave.TabIndex = 20;
			btnSave.Text = "Save Patient";
			btnSave.TextAlignment = StringAlignment.Center;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.Transparent;
			btnCancel.BorderColor = Color.FromArgb(108, 111, 127);
			btnCancel.Cursor = Cursors.Hand;
			btnCancel.EnteredBorderColor = Color.FromArgb(108, 111, 127);
			btnCancel.EnteredColor = Color.FromArgb(200, 205, 215);
			btnCancel.Font = new Font("Microsoft Sans Serif", 10F);
			btnCancel.ForeColor = Color.FromArgb(26, 35, 48); // Dark text for light button
			btnCancel.Image = null;
			btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
			btnCancel.InactiveColor = Color.FromArgb(226, 230, 237);
			btnCancel.Location = new Point(329, 542);
			btnCancel.Margin = new Padding(4, 5, 4, 5);
			btnCancel.Name = "btnCancel";
			btnCancel.PressedBorderColor = Color.FromArgb(108, 111, 127);
			btnCancel.PressedColor = Color.FromArgb(180, 185, 195);
			btnCancel.Size = new Size(143, 53);
			btnCancel.TabIndex = 21;
			btnCancel.Text = "Cancel";
			btnCancel.TextAlignment = StringAlignment.Center;
			btnCancel.Click += btnCancel_Click;
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			lblFirstName.ForeColor = Color.FromArgb(92, 102, 114);
			lblFirstName.Location = new Point(17, 108);
			lblFirstName.Margin = new Padding(4, 0, 4, 0);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(108, 20);
			lblFirstName.TabIndex = 22;
			lblFirstName.Text = "First Name:";
			// 
			// lblLastName
			// 
			lblLastName.AutoSize = true;
			lblLastName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
			lblLastName.ForeColor = Color.FromArgb(92, 102, 114);
			lblLastName.Location = new Point(277, 108);
			lblLastName.Margin = new Padding(4, 0, 4, 0);
			lblLastName.Name = "lblLastName";
			lblLastName.Size = new Size(106, 20);
			lblLastName.TabIndex = 23;
			lblLastName.Text = "Last Name:";
			// 
			// lblFirstNameError
			// 
			lblFirstNameError.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);
			lblFirstNameError.ForeColor = Color.Firebrick;
			lblFirstNameError.Location = new Point(17, 180);
			lblFirstNameError.Margin = new Padding(4, 0, 4, 0);
			lblFirstNameError.Name = "lblFirstNameError";
			lblFirstNameError.Size = new Size(251, 30);
			lblFirstNameError.TabIndex = 5;
			lblFirstNameError.Visible = false;
			// 
			// lblLastNameError
			// 
			lblLastNameError.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);
			lblLastNameError.ForeColor = Color.Firebrick;
			lblLastNameError.Location = new Point(277, 180);
			lblLastNameError.Margin = new Padding(4, 0, 4, 0);
			lblLastNameError.Name = "lblLastNameError";
			lblLastNameError.Size = new Size(256, 30);
			lblLastNameError.TabIndex = 4;
			lblLastNameError.Visible = false;
			// 
			// lblSexError
			// 
			lblSexError.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);
			lblSexError.ForeColor = Color.Firebrick;
			lblSexError.Location = new Point(541, 180);
			lblSexError.Margin = new Padding(4, 0, 4, 0);
			lblSexError.Name = "lblSexError";
			lblSexError.Size = new Size(116, 30);
			lblSexError.TabIndex = 3;
			lblSexError.Visible = false;
			// 
			// lblDobError
			// 
			lblDobError.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);
			lblDobError.ForeColor = Color.Firebrick;
			lblDobError.Location = new Point(339, 288);
			lblDobError.Margin = new Padding(4, 0, 4, 0);
			lblDobError.Name = "lblDobError";
			lblDobError.Size = new Size(319, 30);
			lblDobError.TabIndex = 2;
			lblDobError.Visible = false;
			// 
			// lblContactError
			// 
			lblContactError.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);
			lblContactError.ForeColor = Color.Firebrick;
			lblContactError.Location = new Point(17, 397);
			lblContactError.Margin = new Padding(4, 0, 4, 0);
			lblContactError.Name = "lblContactError";
			lblContactError.Size = new Size(313, 30);
			lblContactError.TabIndex = 1;
			lblContactError.Visible = false;
			// 
			// lblEmergencyError
			// 
			lblEmergencyError.Font = new Font("Segoe UI", 7.5F, FontStyle.Italic);
			lblEmergencyError.ForeColor = Color.Firebrick;
			lblEmergencyError.Location = new Point(339, 397);
			lblEmergencyError.Margin = new Padding(4, 0, 4, 0);
			lblEmergencyError.Name = "lblEmergencyError";
			lblEmergencyError.Size = new Size(319, 30);
			lblEmergencyError.TabIndex = 0;
			lblEmergencyError.Visible = false;
			// 
			// AddPatientForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(226, 230, 237);
			ClientSize = new Size(674, 633);
			Controls.Add(lblEmergencyError);
			Controls.Add(lblContactError);
			Controls.Add(lblDobError);
			Controls.Add(lblSexError);
			Controls.Add(lblLastNameError);
			Controls.Add(lblFirstNameError);
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
			Margin = new Padding(4, 5, 4, 5);
			MaximizeBox = false;
			Name = "AddPatientForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add New Patient";
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
		private ReaLTaiizor.Controls.Button btnSave;
		private ReaLTaiizor.Controls.Button btnCancel;
		private Label lblFirstName;
		private Label lblLastName;
		private Label lblFirstNameError;
		private Label lblLastNameError;
		private Label lblSexError;
		private Label lblDobError;
		private Label lblContactError;
		private Label lblEmergencyError;
	}
}