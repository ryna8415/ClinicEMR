namespace ClinicEMR.UserControls
{
    partial class PrescriptionControl
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
            cboPatient = new ComboBox();
            lblModeInfo = new Label();
            lblConsultDate = new Label();
            lblPatientInfo = new Label();
            tblContent = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtInstructions = new TextBox();
            lblInstructions = new Label();
            lblDuration = new Label();
            lblFrequency = new Label();
            lblMedication = new Label();
            txtMedication = new TextBox();
            txtDosage = new TextBox();
            lblDosage = new Label();
            txtFrequency = new TextBox();
            txtDuration = new TextBox();
            btnAddDrug = new Button();
            lstDrugs = new ListBox();
            lblPrescription = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDone = new Button();
            tblLayout.SuspendLayout();
            tblHeader.SuspendLayout();
            tblContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tblContent, 0, 1);
            tblLayout.Controls.Add(tableLayoutPanel2, 0, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(734, 572);
            tblLayout.TabIndex = 0;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.213257F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.61383F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblHeader.Controls.Add(cboPatient, 1, 0);
            tblHeader.Controls.Add(lblModeInfo, 1, 1);
            tblHeader.Controls.Add(lblConsultDate, 2, 0);
            tblHeader.Controls.Add(lblPatientInfo, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 10);
            tblHeader.Margin = new Padding(20, 10, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.Size = new Size(694, 47);
            tblHeader.TabIndex = 0;
            // 
            // cboPatient
            // 
            cboPatient.Dock = DockStyle.Fill;
            cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatient.FormattingEnabled = true;
            cboPatient.Location = new Point(60, 3);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(491, 23);
            cboPatient.TabIndex = 5;
            cboPatient.SelectedIndexChanged += cboPatient_SelectedIndexChanged;
            // 
            // lblModeInfo
            // 
            lblModeInfo.AutoSize = true;
            lblModeInfo.Location = new Point(60, 27);
            lblModeInfo.Name = "lblModeInfo";
            lblModeInfo.Size = new Size(0, 15);
            lblModeInfo.TabIndex = 3;
            // 
            // lblConsultDate
            // 
            lblConsultDate.AutoSize = true;
            lblConsultDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultDate.Location = new Point(557, 0);
            lblConsultDate.Name = "lblConsultDate";
            lblConsultDate.Padding = new Padding(3);
            lblConsultDate.RightToLeft = RightToLeft.No;
            lblConsultDate.Size = new Size(6, 27);
            lblConsultDate.TabIndex = 1;
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.Anchor = AnchorStyles.Right;
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Location = new Point(7, 6);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new Size(47, 15);
            lblPatientInfo.TabIndex = 4;
            lblPatientInfo.Text = "Patient:";
            lblPatientInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(tableLayoutPanel1, 0, 0);
            tblContent.Controls.Add(lstDrugs, 0, 2);
            tblContent.Controls.Add(lblPrescription, 0, 1);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(20, 63);
            tblContent.Margin = new Padding(20, 3, 20, 3);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 3;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 58.246376F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 41.753624F));
            tblContent.Size = new Size(694, 426);
            tblContent.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.29917F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.70083F));
            tableLayoutPanel1.Controls.Add(txtInstructions, 1, 4);
            tableLayoutPanel1.Controls.Add(lblInstructions, 0, 4);
            tableLayoutPanel1.Controls.Add(lblDuration, 0, 3);
            tableLayoutPanel1.Controls.Add(lblFrequency, 0, 2);
            tableLayoutPanel1.Controls.Add(lblMedication, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMedication, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDosage, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDosage, 0, 1);
            tableLayoutPanel1.Controls.Add(txtFrequency, 1, 2);
            tableLayoutPanel1.Controls.Add(txtDuration, 1, 3);
            tableLayoutPanel1.Controls.Add(btnAddDrug, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(688, 228);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtInstructions
            // 
            txtInstructions.Dock = DockStyle.Fill;
            txtInstructions.Location = new Point(156, 119);
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(529, 60);
            txtInstructions.TabIndex = 9;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(3, 116);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(72, 15);
            lblInstructions.TabIndex = 8;
            lblInstructions.Text = "Instructions:";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(3, 87);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(56, 15);
            lblDuration.TabIndex = 7;
            lblDuration.Text = "Duration:";
            // 
            // lblFrequency
            // 
            lblFrequency.AutoSize = true;
            lblFrequency.Location = new Point(3, 58);
            lblFrequency.Name = "lblFrequency";
            lblFrequency.Size = new Size(65, 15);
            lblFrequency.TabIndex = 6;
            lblFrequency.Text = "Frequency:";
            // 
            // lblMedication
            // 
            lblMedication.AutoSize = true;
            lblMedication.Location = new Point(3, 0);
            lblMedication.Name = "lblMedication";
            lblMedication.Size = new Size(70, 15);
            lblMedication.TabIndex = 0;
            lblMedication.Text = "Medication:";
            // 
            // txtMedication
            // 
            txtMedication.Dock = DockStyle.Fill;
            txtMedication.Location = new Point(156, 3);
            txtMedication.Name = "txtMedication";
            txtMedication.Size = new Size(529, 23);
            txtMedication.TabIndex = 2;
            // 
            // txtDosage
            // 
            txtDosage.Dock = DockStyle.Fill;
            txtDosage.Location = new Point(156, 32);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(529, 23);
            txtDosage.TabIndex = 3;
            // 
            // lblDosage
            // 
            lblDosage.AutoSize = true;
            lblDosage.Location = new Point(3, 29);
            lblDosage.Name = "lblDosage";
            lblDosage.Size = new Size(49, 15);
            lblDosage.TabIndex = 1;
            lblDosage.Text = "Dosage:";
            // 
            // txtFrequency
            // 
            txtFrequency.Dock = DockStyle.Fill;
            txtFrequency.Location = new Point(156, 61);
            txtFrequency.Name = "txtFrequency";
            txtFrequency.Size = new Size(529, 23);
            txtFrequency.TabIndex = 4;
            // 
            // txtDuration
            // 
            txtDuration.Dock = DockStyle.Fill;
            txtDuration.Location = new Point(156, 90);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(529, 23);
            txtDuration.TabIndex = 5;
            // 
            // btnAddDrug
            // 
            btnAddDrug.Anchor = AnchorStyles.Right;
            btnAddDrug.Location = new Point(565, 185);
            btnAddDrug.Name = "btnAddDrug";
            btnAddDrug.Size = new Size(120, 40);
            btnAddDrug.TabIndex = 10;
            btnAddDrug.Text = "Add Drug";
            btnAddDrug.UseVisualStyleBackColor = true;
            btnAddDrug.Click += btnAddDrug_Click;
            // 
            // lstDrugs
            // 
            lstDrugs.Dock = DockStyle.Fill;
            lstDrugs.FormattingEnabled = true;
            lstDrugs.Location = new Point(3, 261);
            lstDrugs.Name = "lstDrugs";
            lstDrugs.Size = new Size(688, 162);
            lstDrugs.TabIndex = 1;
            // 
            // lblPrescription
            // 
            lblPrescription.AutoSize = true;
            lblPrescription.Location = new Point(3, 234);
            lblPrescription.Name = "lblPrescription";
            lblPrescription.Size = new Size(73, 15);
            lblPrescription.TabIndex = 2;
            lblPrescription.Text = "Prescription:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.Controls.Add(btnDone, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 495);
            tableLayoutPanel2.Margin = new Padding(20, 3, 20, 20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(694, 57);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Right;
            btnDone.Location = new Point(571, 8);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(120, 40);
            btnDone.TabIndex = 0;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // PrescriptionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "PrescriptionControl";
            Size = new Size(734, 572);
            tblLayout.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblContent.ResumeLayout(false);
            tblContent.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private Label lblConsultDate;
        private TableLayoutPanel tblContent;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblMedication;
        private Label lblDosage;
        private TextBox txtMedication;
        private TextBox txtDosage;
        private TextBox txtFrequency;
        private TextBox txtDuration;
        private Label lblDuration;
        private Label lblFrequency;
        private TextBox txtInstructions;
        private Label lblInstructions;
        private Button btnAddDrug;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnDone;
        private ListBox lstDrugs;
        private Label lblPrescription;
        private Label lblModeInfo;
        private Label lblDate;
        private Label lblPatientInfo;
        private ComboBox cboPatient;
    }
}
