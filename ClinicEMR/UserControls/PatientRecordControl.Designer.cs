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
			lblPatientInfo.ForeColor = Color.Black; // Explicitly set to be visible
			lblPatientInfo.Location = new Point(4, 17);
			lblPatientInfo.Margin = new Padding(4, 0, 4, 0);
			lblPatientInfo.Name = "lblPatientInfo";
			lblPatientInfo.Size = new Size(124, 23);
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
			tblHeader.Location = new Point(29, 33);
			tblHeader.Margin = new Padding(29, 33, 29, 5);
			tblHeader.Name = "tblHeader";
			tblHeader.RowCount = 4;
			tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
			tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
			tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F)); // Increased height for Allergies
			tblHeader.Size = new Size(1055, 210);
			tblHeader.TabIndex = 0;
			// 
			// cboPatient
			// 
			cboPatient.Dock = DockStyle.Fill;
			cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
			cboPatient.FormattingEnabled = true;
			cboPatient.Location = new Point(151, 5);
			cboPatient.Margin = new Padding(4, 5, 4, 5);
			cboPatient.Name = "cboPatient";
			cboPatient.Size = new Size(688, 33);
			cboPatient.TabIndex = 1;
			cboPatient.SelectedIndexChanged += cboPatient_SelectedIndexChanged;
			// 
			// lblPatient
			// 
			lblPatient.ForeColor = Color.DimGray;
			lblPatient.Location = new Point(4, 58);
			lblPatient.Margin = new Padding(4, 0, 4, 0);
			lblPatient.Name = "lblPatient";
			lblPatient.Size = new Size(139, 38);
			lblPatient.TabIndex = 2;
			lblPatient.Text = "Patient:";
			// 
			// lblPatientName
			// 
			lblPatientName.AutoSize = true;
			lblPatientName.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
			lblPatientName.ForeColor = Color.FromArgb(37, 45, 56);
			lblPatientName.Location = new Point(151, 58);
			lblPatientName.Margin = new Padding(4, 0, 4, 0);
			lblPatientName.Name = "lblPatientName";
			lblPatientName.Size = new Size(0, 29);
			lblPatientName.TabIndex = 3;
			// 
			// labelMeta
			// 
			labelMeta.ForeColor = Color.DimGray;
			labelMeta.Location = new Point(4, 108);
			labelMeta.Margin = new Padding(4, 0, 4, 0);
			labelMeta.Name = "labelMeta";
			labelMeta.Size = new Size(139, 38);
			labelMeta.TabIndex = 4;
			labelMeta.Text = "Info:";
			// 
			// lblMeta
			// 
			lblMeta.Location = new Point(151, 108);
			lblMeta.Margin = new Padding(4, 0, 4, 0);
			lblMeta.Name = "lblMeta";
			lblMeta.Size = new Size(143, 38);
			lblMeta.TabIndex = 5;
			// 
			// lblAllergies
			// 
			lblAllergies.ForeColor = Color.DimGray;
			lblAllergies.Location = new Point(4, 150);
			lblAllergies.Margin = new Padding(4, 0, 4, 0);
			lblAllergies.Name = "lblAllergies";
			lblAllergies.Size = new Size(139, 38);
			lblAllergies.TabIndex = 6;
			lblAllergies.Text = "Allergies:";
			// 
			// lblAllergy
			// 
			lblAllergy.AutoSize = true; // Enabled AutoSize to prevent cutoff
			lblAllergy.Location = new Point(151, 150);
			lblAllergy.Margin = new Padding(4, 0, 4, 0);
			lblAllergy.MaximumSize = new Size(680, 0); // Wraps text if it gets too long
			lblAllergy.Name = "lblAllergy";
			lblAllergy.Size = new Size(0, 25);
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
			btnPrint.Location = new Point(871, 5);
			btnPrint.Margin = new Padding(4, 5, 4, 5);
			btnPrint.Name = "btnPrint";
			tblHeader.SetRowSpan(btnPrint, 2);
			btnPrint.Size = new Size(180, 57);
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
			tblLayout.Margin = new Padding(4, 5, 4, 5);
			tblLayout.Name = "tblLayout";
			tblLayout.RowCount = 2;
			tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F)); // Increased header layout space
			tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tblLayout.Size = new Size(1113, 987);
			tblLayout.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tbPatientRecord, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(29, 255);
			tableLayoutPanel1.Margin = new Padding(29, 5, 29, 33);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(1055, 699);
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
			tbPatientRecord.Location = new Point(4, 5);
			tbPatientRecord.Margin = new Padding(4, 5, 4, 5);
			tbPatientRecord.Name = "tbPatientRecord";
			tbPatientRecord.SelectedIndex = 0;
			tbPatientRecord.Size = new Size(1047, 689);
			tbPatientRecord.TabIndex = 0;
			// 
			// tabVitals
			// 
			tabVitals.Text = "Vitals";
			tabVitals.Location = new Point(4, 32);
			tabVitals.Name = "tabVitals";
			tabVitals.Size = new Size(1039, 653);
			tabVitals.TabIndex = 0;
			// 
			// tabConsultations
			// 
			tabConsultations.Text = "Consultations";
			tabConsultations.Location = new Point(4, 32);
			tabConsultations.Name = "tabConsultations";
			tabConsultations.Size = new Size(1039, 653);
			tabConsultations.TabIndex = 1;
			// 
			// tabPrescriptions
			// 
			tabPrescriptions.Text = "Prescriptions";
			tabPrescriptions.Location = new Point(4, 32);
			tabPrescriptions.Name = "tabPrescriptions";
			tabPrescriptions.Size = new Size(1039, 653);
			tabPrescriptions.TabIndex = 2;
			// 
			// tabMedicalHistory
			// 
			tabMedicalHistory.Text = "Medical History";
			tabMedicalHistory.Location = new Point(4, 32);
			tabMedicalHistory.Name = "tabMedicalHistory";
			tabMedicalHistory.Size = new Size(1039, 653);
			tabMedicalHistory.TabIndex = 3;
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
			txtHxMeds.Location = new Point(56, 161);
			txtHxMeds.Name = "txtHxMeds";
			txtHxMeds.Size = new Size(100, 31);
			txtHxMeds.TabIndex = 0;
			// 
			// lblCurrMed
			// 
			lblCurrMed.ForeColor = Color.DimGray;
			lblCurrMed.Location = new Point(13, 158);
			lblCurrMed.Name = "lblCurrMed";
			lblCurrMed.Size = new Size(37, 23);
			lblCurrMed.TabIndex = 1;
			// 
			// txtHxFamily
			// 
			txtHxFamily.Location = new Point(56, 124);
			txtHxFamily.Name = "txtHxFamily";
			txtHxFamily.Size = new Size(100, 31);
			txtHxFamily.TabIndex = 2;
			// 
			// lblFamHis
			// 
			lblFamHis.ForeColor = Color.DimGray;
			lblFamHis.Location = new Point(13, 121);
			lblFamHis.Name = "lblFamHis";
			lblFamHis.Size = new Size(37, 23);
			lblFamHis.TabIndex = 3;
			// 
			// lblSurgery
			// 
			lblSurgery.ForeColor = Color.DimGray;
			lblSurgery.Location = new Point(13, 84);
			lblSurgery.Name = "lblSurgery";
			lblSurgery.Size = new Size(37, 23);
			lblSurgery.TabIndex = 4;
			// 
			// lblConditions
			// 
			lblConditions.ForeColor = Color.DimGray;
			lblConditions.Location = new Point(13, 47);
			lblConditions.Name = "lblConditions";
			lblConditions.Size = new Size(37, 23);
			lblConditions.TabIndex = 5;
			// 
			// txtHxAllergies
			// 
			txtHxAllergies.Location = new Point(56, 13);
			txtHxAllergies.Name = "txtHxAllergies";
			txtHxAllergies.Size = new Size(100, 31);
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
			txtHxConditions.Location = new Point(56, 50);
			txtHxConditions.Name = "txtHxConditions";
			txtHxConditions.Size = new Size(100, 31);
			txtHxConditions.TabIndex = 8;
			// 
			// txtHxSurgeries
			// 
			txtHxSurgeries.Location = new Point(56, 87);
			txtHxSurgeries.Name = "txtHxSurgeries";
			txtHxSurgeries.Size = new Size(100, 31);
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
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(226, 230, 237);
			Controls.Add(tblLayout);
			Margin = new Padding(4, 5, 4, 5);
			Name = "PatientRecordControl";
			Size = new Size(1113, 987);
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