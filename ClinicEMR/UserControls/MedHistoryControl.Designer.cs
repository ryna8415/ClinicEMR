namespace ClinicEMR.UserControls
{
    partial class MedHistoryControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtCurrentMeds = new TextBox();
            lblCurrMed = new Label();
            txtFamilyHx = new TextBox();
            lblFamHis = new Label();
            lblSurgery = new Label();
            lblConditions = new Label();
            lblPatient = new Label();
            txtAllergies = new TextBox();
            lblAllergies = new Label();
            txtConditions = new TextBox();
            txtSurgeries = new TextBox();
            lblPatientName = new Label();
            tblHeader = new TableLayoutPanel();
            cboPatient = new ComboBox();
            lblPatientInfo = new Label();
            btnSave = new Button();
            tblLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(707, 558);
            tblLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.29917F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.70083F));
            tableLayoutPanel1.Controls.Add(txtCurrentMeds, 1, 5);
            tableLayoutPanel1.Controls.Add(lblCurrMed, 0, 5);
            tableLayoutPanel1.Controls.Add(txtFamilyHx, 1, 4);
            tableLayoutPanel1.Controls.Add(lblFamHis, 0, 4);
            tableLayoutPanel1.Controls.Add(lblSurgery, 0, 3);
            tableLayoutPanel1.Controls.Add(lblConditions, 0, 2);
            tableLayoutPanel1.Controls.Add(lblPatient, 0, 0);
            tableLayoutPanel1.Controls.Add(txtAllergies, 1, 1);
            tableLayoutPanel1.Controls.Add(lblAllergies, 0, 1);
            tableLayoutPanel1.Controls.Add(txtConditions, 1, 2);
            tableLayoutPanel1.Controls.Add(txtSurgeries, 1, 3);
            tableLayoutPanel1.Controls.Add(lblPatientName, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 83);
            tableLayoutPanel1.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(667, 392);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtCurrentMeds
            // 
            txtCurrentMeds.Dock = DockStyle.Fill;
            txtCurrentMeds.Location = new Point(151, 134);
            txtCurrentMeds.Name = "txtCurrentMeds";
            txtCurrentMeds.Size = new Size(513, 23);
            txtCurrentMeds.TabIndex = 13;
            // 
            // lblCurrMed
            // 
            lblCurrMed.AutoSize = true;
            lblCurrMed.Location = new Point(3, 131);
            lblCurrMed.Name = "lblCurrMed";
            lblCurrMed.Size = new Size(123, 15);
            lblCurrMed.TabIndex = 12;
            lblCurrMed.Text = "Current Medication/s:";
            // 
            // txtFamilyHx
            // 
            txtFamilyHx.Dock = DockStyle.Fill;
            txtFamilyHx.Location = new Point(151, 105);
            txtFamilyHx.Name = "txtFamilyHx";
            txtFamilyHx.Size = new Size(513, 23);
            txtFamilyHx.TabIndex = 9;
            // 
            // lblFamHis
            // 
            lblFamHis.AutoSize = true;
            lblFamHis.Location = new Point(3, 102);
            lblFamHis.Name = "lblFamHis";
            lblFamHis.Size = new Size(89, 15);
            lblFamHis.TabIndex = 8;
            lblFamHis.Text = "Family History: ";
            // 
            // lblSurgery
            // 
            lblSurgery.AutoSize = true;
            lblSurgery.Location = new Point(3, 73);
            lblSurgery.Name = "lblSurgery";
            lblSurgery.Size = new Size(58, 15);
            lblSurgery.TabIndex = 7;
            lblSurgery.Text = "Surgeries:";
            // 
            // lblConditions
            // 
            lblConditions.AutoSize = true;
            lblConditions.Location = new Point(3, 44);
            lblConditions.Name = "lblConditions";
            lblConditions.Size = new Size(68, 15);
            lblConditions.TabIndex = 6;
            lblConditions.Text = "Conditions:";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(3, 0);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(64, 15);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "Full Name:";
            // 
            // txtAllergies
            // 
            txtAllergies.Dock = DockStyle.Fill;
            txtAllergies.Location = new Point(151, 18);
            txtAllergies.Name = "txtAllergies";
            txtAllergies.Size = new Size(513, 23);
            txtAllergies.TabIndex = 3;
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Location = new Point(3, 15);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(66, 15);
            lblAllergies.TabIndex = 1;
            lblAllergies.Text = "Allergy/ies:";
            // 
            // txtConditions
            // 
            txtConditions.Dock = DockStyle.Fill;
            txtConditions.Location = new Point(151, 47);
            txtConditions.Name = "txtConditions";
            txtConditions.Size = new Size(513, 23);
            txtConditions.TabIndex = 4;
            // 
            // txtSurgeries
            // 
            txtSurgeries.Dock = DockStyle.Fill;
            txtSurgeries.Location = new Point(151, 76);
            txtSurgeries.Name = "txtSurgeries";
            txtSurgeries.Size = new Size(513, 23);
            txtSurgeries.TabIndex = 5;
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(151, 0);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(0, 15);
            lblPatientName.TabIndex = 11;
            lblPatientName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.3958025F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.6041946F));
            tblHeader.Controls.Add(cboPatient, 1, 0);
            tblHeader.Controls.Add(lblPatientInfo, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.Size = new Size(667, 57);
            tblHeader.TabIndex = 0;
            // 
            // cboPatient
            // 
            cboPatient.Dock = DockStyle.Fill;
            cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatient.FormattingEnabled = true;
            cboPatient.Location = new Point(59, 3);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(605, 23);
            cboPatient.TabIndex = 4;
            cboPatient.SelectedIndexChanged += cboPatient_SelectedIndexChanged;
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.Anchor = AnchorStyles.Right;
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Location = new Point(6, 6);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new Size(47, 15);
            lblPatientInfo.TabIndex = 5;
            lblPatientInfo.Text = "Patient:";
            lblPatientInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(544, 163);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save History";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MedHistoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "MedHistoryControl";
            Size = new Size(707, 558);
            tblLayout.ResumeLayout(false);
            tblLayout.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private ComboBox cboPatient;
        private Label lblPatientInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtFamilyHx;
        private Label lblFamHis;
        private Label lblSurgery;
        private Label lblConditions;
        private Label lblPatient;
        private TextBox txtAllergies;
        private Label lblAllergies;
        private TextBox txtConditions;
        private TextBox txtSurgeries;
        private Label lblPatientName;
        private Label lblCurrMed;
        private TextBox txtCurrentMeds;
        private Button btnSave;
    }
}
