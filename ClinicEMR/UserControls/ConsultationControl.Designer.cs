namespace ClinicEMR.UserControls
{
    partial class ConsultationControl
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
            lblPatientInfo = new Label();
            tblHeader = new TableLayoutPanel();
            cmbPatients = new ComboBox();
            tblLayout = new TableLayoutPanel();
            gbPatientInfo = new GroupBox();
            lblMeta = new Label();
            btnSave = new Button();
            btnAddRx = new Button();
            txtNotes = new TextBox();
            lblNotes = new Label();
            txtDiagnosis = new TextBox();
            lblDiagnosis = new Label();
            txtFindings = new TextBox();
            lblFindings = new Label();
            txtChief = new TextBox();
            lblChiefComp = new Label();
            label2 = new Label();
            lblVitals = new Label();
            lblVtl = new Label();
            label1 = new Label();
            lblAllergy = new Label();
            lblAllergies = new Label();
            lblPatient = new Label();
            lblPatientName = new Label();
            lblConsultation = new Label();
            btnPrint = new Button();
            tblHeader.SuspendLayout();
            tblLayout.SuspendLayout();
            gbPatientInfo.SuspendLayout();
            SuspendLayout();
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
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.3958025F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.6041946F));
            tblHeader.Controls.Add(cmbPatients, 1, 0);
            tblHeader.Controls.Add(lblPatientInfo, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.Size = new Size(697, 57);
            tblHeader.TabIndex = 0;
            // 
            // cmbPatients
            // 
            cmbPatients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPatients.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPatients.Dock = DockStyle.Fill;
            cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(61, 3);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(633, 23);
            cmbPatients.TabIndex = 10;
            cmbPatients.SelectedIndexChanged += cmbPatients_SelectedIndexChanged;
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(gbPatientInfo, 0, 1);
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(737, 676);
            tblLayout.TabIndex = 1;
            // 
            // gbPatientInfo
            // 
            gbPatientInfo.Controls.Add(lblMeta);
            gbPatientInfo.Controls.Add(btnSave);
            gbPatientInfo.Controls.Add(btnAddRx);
            gbPatientInfo.Controls.Add(txtNotes);
            gbPatientInfo.Controls.Add(lblNotes);
            gbPatientInfo.Controls.Add(txtDiagnosis);
            gbPatientInfo.Controls.Add(lblDiagnosis);
            gbPatientInfo.Controls.Add(txtFindings);
            gbPatientInfo.Controls.Add(lblFindings);
            gbPatientInfo.Controls.Add(txtChief);
            gbPatientInfo.Controls.Add(lblChiefComp);
            gbPatientInfo.Controls.Add(label2);
            gbPatientInfo.Controls.Add(lblVitals);
            gbPatientInfo.Controls.Add(lblVtl);
            gbPatientInfo.Controls.Add(label1);
            gbPatientInfo.Controls.Add(lblAllergy);
            gbPatientInfo.Controls.Add(lblAllergies);
            gbPatientInfo.Controls.Add(lblPatient);
            gbPatientInfo.Controls.Add(lblPatientName);
            gbPatientInfo.Controls.Add(lblConsultation);
            gbPatientInfo.Controls.Add(btnPrint);
            gbPatientInfo.Dock = DockStyle.Fill;
            gbPatientInfo.Location = new Point(20, 83);
            gbPatientInfo.Margin = new Padding(20, 3, 20, 3);
            gbPatientInfo.Name = "gbPatientInfo";
            gbPatientInfo.Size = new Size(697, 510);
            gbPatientInfo.TabIndex = 9;
            gbPatientInfo.TabStop = false;
            // 
            // lblMeta
            // 
            lblMeta.AutoSize = true;
            lblMeta.Location = new Point(354, 61);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(0, 15);
            lblMeta.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(489, 444);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 34);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAddRx
            // 
            btnAddRx.Enabled = false;
            btnAddRx.Location = new Point(596, 444);
            btnAddRx.Name = "btnAddRx";
            btnAddRx.Size = new Size(92, 34);
            btnAddRx.TabIndex = 18;
            btnAddRx.Text = "Add Rx";
            btnAddRx.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(20, 383);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(668, 45);
            txtNotes.TabIndex = 17;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(20, 365);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(43, 15);
            lblNotes.TabIndex = 16;
            lblNotes.Text = "Notes:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(20, 317);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(668, 45);
            txtDiagnosis.TabIndex = 15;
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiagnosis.Location = new Point(20, 299);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(62, 15);
            lblDiagnosis.TabIndex = 14;
            lblDiagnosis.Text = "Diagnosis:";
            // 
            // txtFindings
            // 
            txtFindings.Location = new Point(20, 251);
            txtFindings.Multiline = true;
            txtFindings.Name = "txtFindings";
            txtFindings.ScrollBars = ScrollBars.Vertical;
            txtFindings.Size = new Size(668, 45);
            txtFindings.TabIndex = 13;
            // 
            // lblFindings
            // 
            lblFindings.AutoSize = true;
            lblFindings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFindings.Location = new Point(20, 233);
            lblFindings.Name = "lblFindings";
            lblFindings.Size = new Size(55, 15);
            lblFindings.TabIndex = 12;
            lblFindings.Text = "Findings:";
            // 
            // txtChief
            // 
            txtChief.Location = new Point(124, 201);
            txtChief.Name = "txtChief";
            txtChief.Size = new Size(564, 23);
            txtChief.TabIndex = 11;
            // 
            // lblChiefComp
            // 
            lblChiefComp.AutoSize = true;
            lblChiefComp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChiefComp.Location = new Point(20, 204);
            lblChiefComp.Name = "lblChiefComp";
            lblChiefComp.Size = new Size(98, 15);
            lblChiefComp.TabIndex = 10;
            lblChiefComp.Text = "Chief Complaint:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 169);
            label2.Name = "label2";
            label2.Size = new Size(682, 15);
            label2.TabIndex = 8;
            label2.Text = "---------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // lblVitals
            // 
            lblVitals.AutoSize = true;
            lblVitals.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVitals.Location = new Point(70, 144);
            lblVitals.Name = "lblVitals";
            lblVitals.Size = new Size(0, 15);
            lblVitals.TabIndex = 7;
            // 
            // lblVtl
            // 
            lblVtl.AutoSize = true;
            lblVtl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVtl.Location = new Point(20, 144);
            lblVtl.Name = "lblVtl";
            lblVtl.Size = new Size(40, 15);
            lblVtl.TabIndex = 6;
            lblVtl.Text = "Vitals:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 116);
            label1.Name = "label1";
            label1.Size = new Size(682, 15);
            label1.TabIndex = 5;
            label1.Text = "---------------------------------------------------------------------------------------------------------------------------------------";
            // 
            // lblAllergy
            // 
            lblAllergy.AutoSize = true;
            lblAllergy.Location = new Point(95, 90);
            lblAllergy.Name = "lblAllergy";
            lblAllergy.Size = new Size(0, 15);
            lblAllergy.TabIndex = 4;
            // 
            // lblAllergies
            // 
            lblAllergies.AutoSize = true;
            lblAllergies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAllergies.Location = new Point(20, 90);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(69, 15);
            lblAllergies.TabIndex = 3;
            lblAllergies.Text = "Allergy/ies:";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatient.Location = new Point(20, 61);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(50, 15);
            lblPatient.TabIndex = 2;
            lblPatient.Text = "Patient:";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Location = new Point(67, 61);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(51, 15);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "Example";
            // 
            // lblConsultation
            // 
            lblConsultation.AutoSize = true;
            lblConsultation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultation.Location = new Point(6, 24);
            lblConsultation.Name = "lblConsultation";
            lblConsultation.Size = new Size(152, 21);
            lblConsultation.TabIndex = 0;
            lblConsultation.Text = "Patient Information";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(382, 444);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(92, 34);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // ConsultationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tblLayout);
            Name = "ConsultationControl";
            Size = new Size(737, 676);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblLayout.ResumeLayout(false);
            gbPatientInfo.ResumeLayout(false);
            gbPatientInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label lblPatientInfo;
        private TableLayoutPanel tblHeader;
        private TableLayoutPanel tblLayout;
        private ComboBox cmbPatients;
        private GroupBox gbPatientInfo;
        private Label lblMeta;
        private Button btnSave;
        private Button btnAddRx;
        private TextBox txtNotes;
        private Label lblNotes;
        private TextBox txtDiagnosis;
        private Label lblDiagnosis;
        private TextBox txtFindings;
        private Label lblFindings;
        private TextBox txtChief;
        private Label lblChiefComp;
        private Label label2;
        private Label lblVitals;
        private Label lblVtl;
        private Label label1;
        private Label lblAllergy;
        private Label lblAllergies;
        private Label lblPatient;
        private Label lblPatientName;
        private Label lblConsultation;
        private Button btnPrint;
    }
}
