namespace ClinicEMR.UserControls
{
    partial class VitalsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbVitals = new GroupBox();
            txtBP = new TextBox();
            lblBmi = new Label();
            btnSave = new Button();
            lblBMIAuto = new Label();
            lblWeight = new Label();
            lblHeight = new Label();
            lblTemp = new Label();
            lblHeartRate = new Label();
            lblBloopPressure = new Label();
            nudTemp = new NumericUpDown();
            nudWeight = new NumericUpDown();
            nudHR = new NumericUpDown();
            nudHeight = new NumericUpDown();
            lblPatient = new Label();
            dgvHistory = new DataGridView();
            lblPrevReadings = new Label();
            lblVitals = new Label();
            lblPatientName = new Label();
            cmbPatients = new ComboBox();
            gbVitals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // gbVitals
            // 
            gbVitals.Controls.Add(txtBP);
            gbVitals.Controls.Add(lblBmi);
            gbVitals.Controls.Add(btnSave);
            gbVitals.Controls.Add(lblBMIAuto);
            gbVitals.Controls.Add(lblWeight);
            gbVitals.Controls.Add(lblHeight);
            gbVitals.Controls.Add(lblTemp);
            gbVitals.Controls.Add(lblHeartRate);
            gbVitals.Controls.Add(lblBloopPressure);
            gbVitals.Controls.Add(nudTemp);
            gbVitals.Controls.Add(nudWeight);
            gbVitals.Controls.Add(nudHR);
            gbVitals.Controls.Add(nudHeight);
            gbVitals.Location = new Point(57, 93);
            gbVitals.Name = "gbVitals";
            gbVitals.Size = new Size(586, 182);
            gbVitals.TabIndex = 6;
            gbVitals.TabStop = false;
            // 
            // txtBP
            // 
            txtBP.Location = new Point(44, 37);
            txtBP.Name = "txtBP";
            txtBP.Size = new Size(120, 23);
            txtBP.TabIndex = 13;
            // 
            // lblBmi
            // 
            lblBmi.AutoSize = true;
            lblBmi.BackColor = SystemColors.ControlDark;
            lblBmi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBmi.Location = new Point(406, 96);
            lblBmi.Name = "lblBmi";
            lblBmi.Size = new Size(0, 17);
            lblBmi.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(44, 130);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 31);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Vitals";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblBMIAuto
            // 
            lblBMIAuto.AutoSize = true;
            lblBMIAuto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBMIAuto.Location = new Point(406, 72);
            lblBMIAuto.Name = "lblBMIAuto";
            lblBMIAuto.Size = new Size(66, 15);
            lblBMIAuto.TabIndex = 11;
            lblBMIAuto.Text = "BMI (auto)";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(228, 72);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(77, 15);
            lblWeight.TabIndex = 10;
            lblWeight.Text = "Weight (kgs.)";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(44, 72);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(71, 15);
            lblHeight.TabIndex = 9;
            lblHeight.Text = "Height (cm)";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(406, 19);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(94, 15);
            lblTemp.TabIndex = 8;
            lblTemp.Text = "Body Temp. (°C)";
            // 
            // lblHeartRate
            // 
            lblHeartRate.AutoSize = true;
            lblHeartRate.Location = new Point(228, 19);
            lblHeartRate.Name = "lblHeartRate";
            lblHeartRate.Size = new Size(62, 15);
            lblHeartRate.TabIndex = 7;
            lblHeartRate.Text = "Heart Rate";
            // 
            // lblBloopPressure
            // 
            lblBloopPressure.AutoSize = true;
            lblBloopPressure.Location = new Point(44, 19);
            lblBloopPressure.Name = "lblBloopPressure";
            lblBloopPressure.Size = new Size(85, 15);
            lblBloopPressure.TabIndex = 6;
            lblBloopPressure.Text = "Blood Pressure";
            // 
            // nudTemp
            // 
            nudTemp.Location = new Point(406, 37);
            nudTemp.Name = "nudTemp";
            nudTemp.Size = new Size(120, 23);
            nudTemp.TabIndex = 4;
            // 
            // nudWeight
            // 
            nudWeight.Location = new Point(228, 90);
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(120, 23);
            nudWeight.TabIndex = 3;
            // 
            // nudHR
            // 
            nudHR.Location = new Point(228, 37);
            nudHR.Name = "nudHR";
            nudHR.Size = new Size(120, 23);
            nudHR.TabIndex = 2;
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(44, 90);
            nudHeight.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(120, 23);
            nudHeight.TabIndex = 1;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatient.Location = new Point(57, 49);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(61, 17);
            lblPatient.TabIndex = 7;
            lblPatient.Text = "Patient: ";
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(57, 307);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(586, 194);
            dgvHistory.TabIndex = 8;
            // 
            // lblPrevReadings
            // 
            lblPrevReadings.AutoSize = true;
            lblPrevReadings.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrevReadings.Location = new Point(57, 288);
            lblPrevReadings.Name = "lblPrevReadings";
            lblPrevReadings.Size = new Size(129, 16);
            lblPrevReadings.TabIndex = 9;
            lblPrevReadings.Text = "Previous Readings:";
            // 
            // lblVitals
            // 
            lblVitals.AutoSize = true;
            lblVitals.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitals.Location = new Point(57, 84);
            lblVitals.Name = "lblVitals";
            lblVitals.Size = new Size(95, 16);
            lblVitals.TabIndex = 10;
            lblVitals.Text = "Vitals Record:";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(124, 51);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(0, 15);
            lblPatientName.TabIndex = 11;
            // 
            // cmbPatients
            // 
            cmbPatients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPatients.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(115, 43);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(528, 23);
            cmbPatients.TabIndex = 12;
            // 
            // VitalsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbPatients);
            Controls.Add(lblPatientName);
            Controls.Add(lblVitals);
            Controls.Add(lblPrevReadings);
            Controls.Add(dgvHistory);
            Controls.Add(lblPatient);
            Controls.Add(gbVitals);
            Name = "VitalsControl";
            Size = new Size(698, 582);
            gbVitals.ResumeLayout(false);
            gbVitals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private GroupBox gbVitals;
        private Label lblPatient;
        private DataGridView dgvHistory;
        private Label lblPrevReadings;
        private Label lblBloopPressure;
        private NumericUpDown nudTemp;
        private NumericUpDown nudWeight;
        private NumericUpDown nudHR;
        private NumericUpDown nudHeight;
        private Label lblVitals;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblTemp;
        private Label lblHeartRate;
        private Label lblBMIAuto;
        private Label lblBmi;
        private Button btnSave;
        private Label lblPatientName;
        private TextBox txtBP;
        private ComboBox cmbPatients;
    }
}
