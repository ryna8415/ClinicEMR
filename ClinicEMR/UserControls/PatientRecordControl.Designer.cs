using System.Xml.Linq;
using Org.BouncyCastle.Asn1.Crmf;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint;

namespace ClinicEMR.UserControls
{
	partial class PatientRecordControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblPatientInfo = new Label();
            tblHeader = new TableLayoutPanel();
            cboPatient = new ComboBox();
            lblPatient = new Label();
            lblPatientName = new Label();
            labelMeta = new Label();
            lblMeta = new Label();
            lblAllergies = new Label();
            lblAllergy = new Label();
            btnPrint = new Button();
            tblLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tbPatientRecord = new TabControl();
            tabVitals = new TabPage();
            tabConsultations = new TabPage();
            tabPrescriptions = new TabPage();
            tabMedicalHistory = new TabPage();
            dgvVitals = new DataGridView();
            dgvConsultations = new DataGridView();
            dgvPrescriptions = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtHxMeds = new TextBox();
            lblCurrMed = new Label();
            txtHxFamily = new TextBox();
            lblFamHis = new Label();
            lblSurgery = new Label();
            lblConditions = new Label();
            txtHxAllergies = new TextBox();
            label2 = new Label();
            txtHxConditions = new TextBox();
            txtHxSurgeries = new TextBox();
            btnEditHistory = new Button();
            tblHeader.SuspendLayout();
            tblLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tbPatientRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVitals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.Anchor = AnchorStyles.Left;
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Font = new Font("Segoe UI Semibold", 9F);
            lblPatientInfo.ForeColor = Color.Black;
            lblPatientInfo.Location = new Point(3, 13);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new Size(111, 20);
            lblPatientInfo.TabIndex = 0;
            lblPatientInfo.Text = "Search Patient:";
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblHeader.Controls.Add(cboPatient, 1, 0);
            tblHeader.Controls.Add(lblPatientInfo, 0, 0);
            tblHeader.Controls.Add(lblPatient, 0, 1);
            tblHeader.Controls.Add(lblPatientName, 1, 1);
            tblHeader.Controls.Add(labelMeta, 0, 2);
            tblHeader.Controls.Add(lblMeta, 1, 2);
            tblHeader.Controls.Add(lblAllergies, 0, 3);
            tblHeader.Controls.Add(lblAllergy, 1, 3);
            tblHeader.Controls.Add(btnPrint, 2, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(23, 26);
            tblHeader.Margin = new Padding(23, 26, 23, 4);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 4;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tblHeader.Size = new Size(844, 170);
            tblHeader.TabIndex = 0;
            // 
            // cboPatient
            // 
            cboPatient.Dock = DockStyle.Fill;
            cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatient.FormattingEnabled = true;
            cboPatient.Location = new Point(121, 4);
            cboPatient.Margin = new Padding(3, 4, 3, 4);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(551, 28);
            cboPatient.TabIndex = 1;
            cboPatient.SelectedIndexChanged += cboPatient_SelectedIndexChanged;
            // 
            // lblPatient
            // 
            lblPatient.ForeColor = Color.DimGray;
            lblPatient.Location = new Point(3, 46);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(111, 30);
            lblPatient.TabIndex = 2;
            lblPatient.Text = "Patient:";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(37, 45, 56);
            lblPatientName.Location = new Point(121, 46);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(0, 26);
            lblPatientName.TabIndex = 3;
            // 
            // labelMeta
            // 
            labelMeta.ForeColor = Color.DimGray;
            labelMeta.Location = new Point(3, 86);
            labelMeta.Name = "labelMeta";
            labelMeta.Size = new Size(111, 30);
            labelMeta.TabIndex = 4;
            labelMeta.Text = "Info:";
            // 
            // lblMeta
            // 
            lblMeta.Location = new Point(121, 86);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(114, 30);
            lblMeta.TabIndex = 5;
            // 
            // lblAllergies
            // 
            lblAllergies.ForeColor = Color.DimGray;
            lblAllergies.Location = new Point(3, 120);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(111, 30);
            lblAllergies.TabIndex = 6;
            lblAllergies.Text = "Allergies:";
            // 
            // lblAllergy
            // 
            lblAllergy.AutoSize = true;
            lblAllergy.Location = new Point(121, 120);
            lblAllergy.MaximumSize = new Size(544, 0);
            lblAllergy.Name = "lblAllergy";
            lblAllergy.Size = new Size(0, 20);
            lblAllergy.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(26, 35, 48);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(697, 4);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            tblHeader.SetRowSpan(btnPrint, 2);
            btnPrint.Size = new Size(144, 46);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "PRINT RECORD";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(3, 4, 3, 4);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 2;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.Size = new Size(890, 790);
            tblLayout.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tbPatientRecord, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 204);
            tableLayoutPanel1.Margin = new Padding(23, 4, 23, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(844, 560);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tbPatientRecord
            // 
            tbPatientRecord.Controls.Add(tabVitals);
            tbPatientRecord.Controls.Add(tabConsultations);
            tbPatientRecord.Controls.Add(tabPrescriptions);
            tbPatientRecord.Controls.Add(tabMedicalHistory);
            tbPatientRecord.Dock = DockStyle.Fill;
            tbPatientRecord.Font = new Font("Segoe UI Semibold", 9F);
            tbPatientRecord.Location = new Point(3, 4);
            tbPatientRecord.Margin = new Padding(3, 4, 3, 4);
            tbPatientRecord.Name = "tbPatientRecord";
            tbPatientRecord.SelectedIndex = 0;
            tbPatientRecord.Size = new Size(838, 552);
            tbPatientRecord.TabIndex = 0;
            // 
            // tabVitals
            // 
            tabVitals.Location = new Point(4, 29);
            tabVitals.Margin = new Padding(2, 2, 2, 2);
            tabVitals.Name = "tabVitals";
            tabVitals.Size = new Size(830, 519);
            tabVitals.TabIndex = 0;
            tabVitals.Text = "Vitals";
            // 
            // tabConsultations
            // 
            tabConsultations.Location = new Point(4, 29);
            tabConsultations.Margin = new Padding(2, 2, 2, 2);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Size = new Size(830, 518);
            tabConsultations.TabIndex = 1;
            tabConsultations.Text = "Consultations";
            // 
            // tabPrescriptions
            // 
            tabPrescriptions.Location = new Point(4, 29);
            tabPrescriptions.Margin = new Padding(2, 2, 2, 2);
            tabPrescriptions.Name = "tabPrescriptions";
            tabPrescriptions.Size = new Size(830, 518);
            tabPrescriptions.TabIndex = 2;
            tabPrescriptions.Text = "Prescriptions";
            // 
            // tabMedicalHistory
            // 
            tabMedicalHistory.Location = new Point(4, 29);
            tabMedicalHistory.Margin = new Padding(2, 2, 2, 2);
            tabMedicalHistory.Name = "tabMedicalHistory";
            tabMedicalHistory.Size = new Size(830, 518);
            tabMedicalHistory.TabIndex = 3;
            tabMedicalHistory.Text = "Medical History";
            // 
            // dgvVitals
            // 
            dgvVitals.ColumnHeadersHeight = 32;
            dgvVitals.Location = new Point(0, 0);
            dgvVitals.Name = "dgvVitals";
            dgvVitals.RowHeadersWidth = 57;
            dgvVitals.Size = new Size(240, 150);
            dgvVitals.TabIndex = 0;
            // 
            // dgvConsultations
            // 
            dgvConsultations.ColumnHeadersHeight = 32;
            dgvConsultations.Location = new Point(0, 0);
            dgvConsultations.Name = "dgvConsultations";
            dgvConsultations.RowHeadersWidth = 57;
            dgvConsultations.Size = new Size(240, 150);
            dgvConsultations.TabIndex = 0;
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.ColumnHeadersHeight = 32;
            dgvPrescriptions.Location = new Point(0, 0);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.RowHeadersWidth = 57;
            dgvPrescriptions.Size = new Size(240, 150);
            dgvPrescriptions.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEditHistory, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel3.Controls.Add(txtHxMeds, 1, 4);
            tableLayoutPanel3.Controls.Add(lblCurrMed, 0, 4);
            tableLayoutPanel3.Controls.Add(txtHxFamily, 1, 3);
            tableLayoutPanel3.Controls.Add(lblFamHis, 0, 3);
            tableLayoutPanel3.Controls.Add(lblSurgery, 0, 2);
            tableLayoutPanel3.Controls.Add(lblConditions, 0, 1);
            tableLayoutPanel3.Controls.Add(txtHxAllergies, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(txtHxConditions, 1, 1);
            tableLayoutPanel3.Controls.Add(txtHxSurgeries, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(10);
            tableLayoutPanel3.Size = new Size(194, 82);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtHxMeds
            // 
            txtHxMeds.Location = new Point(56, 145);
            txtHxMeds.Name = "txtHxMeds";
            txtHxMeds.Size = new Size(100, 27);
            txtHxMeds.TabIndex = 0;
            // 
            // lblCurrMed
            // 
            lblCurrMed.ForeColor = Color.DimGray;
            lblCurrMed.Location = new Point(13, 142);
            lblCurrMed.Name = "lblCurrMed";
            lblCurrMed.Size = new Size(37, 23);
            lblCurrMed.TabIndex = 1;
            // 
            // txtHxFamily
            // 
            txtHxFamily.Location = new Point(56, 112);
            txtHxFamily.Name = "txtHxFamily";
            txtHxFamily.Size = new Size(100, 27);
            txtHxFamily.TabIndex = 2;
            // 
            // lblFamHis
            // 
            lblFamHis.ForeColor = Color.DimGray;
            lblFamHis.Location = new Point(13, 109);
            lblFamHis.Name = "lblFamHis";
            lblFamHis.Size = new Size(37, 23);
            lblFamHis.TabIndex = 3;
            // 
            // lblSurgery
            // 
            lblSurgery.ForeColor = Color.DimGray;
            lblSurgery.Location = new Point(13, 76);
            lblSurgery.Name = "lblSurgery";
            lblSurgery.Size = new Size(37, 23);
            lblSurgery.TabIndex = 4;
            // 
            // lblConditions
            // 
            lblConditions.ForeColor = Color.DimGray;
            lblConditions.Location = new Point(13, 43);
            lblConditions.Name = "lblConditions";
            lblConditions.Size = new Size(37, 23);
            lblConditions.TabIndex = 5;
            // 
            // txtHxAllergies
            // 
            txtHxAllergies.Location = new Point(56, 13);
            txtHxAllergies.Name = "txtHxAllergies";
            txtHxAllergies.Size = new Size(100, 27);
            txtHxAllergies.TabIndex = 6;
            // 
            // label2
            // 
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(37, 23);
            label2.TabIndex = 7;
            // 
            // txtHxConditions
            // 
            txtHxConditions.Location = new Point(56, 46);
            txtHxConditions.Name = "txtHxConditions";
            txtHxConditions.Size = new Size(100, 27);
            txtHxConditions.TabIndex = 8;
            // 
            // txtHxSurgeries
            // 
            txtHxSurgeries.Location = new Point(56, 79);
            txtHxSurgeries.Name = "txtHxSurgeries";
            txtHxSurgeries.Size = new Size(100, 27);
            txtHxSurgeries.TabIndex = 9;
            // 
            // btnEditHistory
            // 
            btnEditHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditHistory.BackColor = Color.FromArgb(26, 35, 48);
            btnEditHistory.FlatAppearance.BorderSize = 0;
            btnEditHistory.FlatStyle = FlatStyle.Flat;
            btnEditHistory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnEditHistory.ForeColor = Color.White;
            btnEditHistory.Location = new Point(67, 91);
            btnEditHistory.Name = "btnEditHistory";
            btnEditHistory.Size = new Size(130, 6);
            btnEditHistory.TabIndex = 1;
            btnEditHistory.Text = "EDIT HISTORY";
            btnEditHistory.UseVisualStyleBackColor = false;
            btnEditHistory.Click += btnEditHistory_Click;
            // 
            // PatientRecordControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 230, 237);
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientRecordControl";
            Size = new Size(890, 790);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblLayout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tbPatientRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVitals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        // ... private member list remains same ...


        private Label lblPatientInfo;
		private TableLayoutPanel tblHeader;
		private ComboBox cboPatient;
		private Label lblPatient;
		private Label lblPatientName;
		private Label labelMeta;
		private Label lblAllergies;
		private Label lblMeta;
		private Label lblAllergy;
		private TableLayoutPanel tblLayout;
		private TableLayoutPanel tableLayoutPanel1;
		private TabControl tbPatientRecord;
		private TabPage tabVitals;
		private DataGridView dgvVitals;
		private TabPage tabConsultations;
		private DataGridView dgvConsultations;
		private TabPage tabPrescriptions;
		private DataGridView dgvPrescriptions;
		private TabPage tabMedicalHistory;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private TextBox txtHxMeds;
		private Label lblCurrMed;
		private TextBox txtHxFamily;
		private Label lblFamHis;
		private Label lblSurgery;
		private Label lblConditions;
		private TextBox txtHxAllergies;
		private Label label2;
		private TextBox txtHxConditions;
		private TextBox txtHxSurgeries;
		private Button btnEditHistory;
		private Button btnPrint;
	}
}
