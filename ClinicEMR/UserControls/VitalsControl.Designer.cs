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
            tblLayout = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            cmbPatients = new ComboBox();
            lblPatientInfo = new Label();
            lblPatientName = new Label();
            tblContent = new TableLayoutPanel();
            dgvHistory = new DataGridView();
            lblPrevReadings = new Label();
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
            lblVitals = new Label();
            tblLayout.SuspendLayout();
            tblHeader.SuspendLayout();
            tblContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            gbVitals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tblContent, 0, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(698, 582);
            tblLayout.TabIndex = 1;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.3958025F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.6041946F));
            tblHeader.Controls.Add(cmbPatients, 1, 0);
            tblHeader.Controls.Add(lblPatientInfo, 0, 0);
            tblHeader.Controls.Add(lblPatientName, 1, 1);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.Size = new Size(658, 57);
            tblHeader.TabIndex = 0;
            // 
            // cmbPatients
            // 
            cmbPatients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPatients.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPatients.Dock = DockStyle.Fill;
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(58, 3);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(597, 23);
            cmbPatients.TabIndex = 20;
            cmbPatients.SelectedIndexChanged += cmbPatients_SelectedIndexChanged;
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.Anchor = AnchorStyles.Left;
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Location = new Point(3, 6);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new Size(47, 15);
            lblPatientInfo.TabIndex = 5;
            lblPatientInfo.Text = "Patient:";
            lblPatientInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPatientName
            // 
            lblPatientName.Anchor = AnchorStyles.Left;
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(58, 35);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(0, 15);
            lblPatientName.TabIndex = 21;
            lblPatientName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(dgvHistory, 0, 3);
            tblContent.Controls.Add(lblPrevReadings, 0, 2);
            tblContent.Controls.Add(gbVitals, 0, 1);
            tblContent.Controls.Add(lblVitals, 0, 0);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(20, 83);
            tblContent.Margin = new Padding(20, 3, 20, 3);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 4;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblContent.Size = new Size(658, 416);
            tblContent.TabIndex = 1;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToResizeColumns = false;
            dgvHistory.AllowUserToResizeRows = false;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(3, 251);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(652, 162);
            dgvHistory.TabIndex = 21;
            // 
            // lblPrevReadings
            // 
            lblPrevReadings.Anchor = AnchorStyles.Left;
            lblPrevReadings.AutoSize = true;
            lblPrevReadings.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrevReadings.Location = new Point(3, 219);
            lblPrevReadings.Name = "lblPrevReadings";
            lblPrevReadings.Size = new Size(129, 16);
            lblPrevReadings.TabIndex = 20;
            lblPrevReadings.Text = "Previous Readings:";
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
            gbVitals.Dock = DockStyle.Fill;
            gbVitals.Location = new Point(3, 44);
            gbVitals.Name = "gbVitals";
            gbVitals.Size = new Size(652, 160);
            gbVitals.TabIndex = 19;
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
            // lblVitals
            // 
            lblVitals.Anchor = AnchorStyles.Left;
            lblVitals.AutoSize = true;
            lblVitals.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitals.Location = new Point(3, 12);
            lblVitals.Name = "lblVitals";
            lblVitals.Size = new Size(95, 16);
            lblVitals.TabIndex = 18;
            lblVitals.Text = "Vitals Record:";
            // 
            // VitalsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "VitalsControl";
            Size = new Size(698, 582);
            tblLayout.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblContent.ResumeLayout(false);
            tblContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            gbVitals.ResumeLayout(false);
            gbVitals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHR).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private Label lblPatientInfo;
        private ComboBox cmbPatients;
        private TableLayoutPanel tblContent;
        private Label lblVitals;
        private GroupBox gbVitals;
        private TextBox txtBP;
        private Label lblBmi;
        private Button btnSave;
        private Label lblBMIAuto;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblTemp;
        private Label lblHeartRate;
        private Label lblBloopPressure;
        private NumericUpDown nudTemp;
        private NumericUpDown nudWeight;
        private NumericUpDown nudHR;
        private NumericUpDown nudHeight;
        private Label lblPrevReadings;
        private DataGridView dgvHistory;
        private Label lblPatientName;
    }
}
