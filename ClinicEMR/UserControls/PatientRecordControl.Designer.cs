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
            tblLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBack = new ReaLTaiizor.Controls.Button();
            btnPrint = new ReaLTaiizor.Controls.Button();
            tblSummary = new TableLayoutPanel();
            tbPatientRecord = new ReaLTaiizor.Controls.ForeverTabPage();
            tabConsultations = new TabPage();
            dgvConsultations = new DataGridView();
            tabPrescriptions = new TabPage();
            dgvPrescriptions = new DataGridView();
            tabVitals = new TabPage();
            dgvVitals = new DataGridView();
            tabMedicalHistory = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEdit = new ReaLTaiizor.Controls.Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtHxMeds = new ReaLTaiizor.Controls.HopeTextBox();
            txtHxFamilyHis = new ReaLTaiizor.Controls.HopeTextBox();
            txtHxSurgeries = new ReaLTaiizor.Controls.HopeTextBox();
            txtHxConditions = new ReaLTaiizor.Controls.HopeTextBox();
            lblCurrMed = new Label();
            lblFamHis = new Label();
            lblSurgery = new Label();
            lblConditions = new Label();
            tblInfoIntro = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            lblFullName = new Label();
            panel2 = new Panel();
            lblAllergy = new Label();
            lblAllergies = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            lblMeta = new Label();
            lblPatientName = new Label();
            cboPatient = new ReaLTaiizor.Controls.HopeComboBox();
            label2 = new Label();
            tblLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tblSummary.SuspendLayout();
            tbPatientRecord.SuspendLayout();
            tabConsultations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).BeginInit();
            tabPrescriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            tabVitals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVitals).BeginInit();
            tabMedicalHistory.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tblInfoIntro.SuspendLayout();
            tblHeader.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 0);
            tblLayout.Controls.Add(tblSummary, 0, 3);
            tblLayout.Controls.Add(tblInfoIntro, 0, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 5;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblLayout.Size = new Size(890, 789);
            tblLayout.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Controls.Add(btnBack, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPrint, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 10);
            tableLayoutPanel1.Margin = new Padding(20, 10, 20, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(850, 43);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(226, 230, 237);
            btnBack.BorderColor = Color.FromArgb(108, 111, 127);
            btnBack.Cursor = Cursors.Hand;
            btnBack.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnBack.EnteredColor = Color.FromArgb(69, 85, 97);
            btnBack.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnBack.Image = null;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.InactiveColor = Color.FromArgb(92, 102, 114);
            btnBack.Location = new Point(0, 1);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnBack.PressedColor = Color.FromArgb(108, 111, 127);
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back";
            btnBack.TextAlignment = StringAlignment.Center;
            btnBack.Click += btnBack_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(226, 230, 237);
            btnPrint.BorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.EnteredColor = Color.FromArgb(69, 85, 97);
            btnPrint.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnPrint.Image = null;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.InactiveColor = Color.FromArgb(92, 102, 114);
            btnPrint.Location = new Point(750, 1);
            btnPrint.Margin = new Padding(3, 0, 0, 0);
            btnPrint.Name = "btnPrint";
            btnPrint.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.PressedColor = Color.FromArgb(108, 111, 127);
            btnPrint.Size = new Size(100, 40);
            btnPrint.TabIndex = 27;
            btnPrint.Text = "Print";
            btnPrint.TextAlignment = StringAlignment.Center;
            btnPrint.Click += btnPrint_Click;
            // 
            // tblSummary
            // 
            tblSummary.BackColor = Color.FromArgb(37, 45, 56);
            tblSummary.ColumnCount = 1;
            tblSummary.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblSummary.Controls.Add(tbPatientRecord, 0, 0);
            tblSummary.Dock = DockStyle.Fill;
            tblSummary.Location = new Point(20, 233);
            tblSummary.Margin = new Padding(20, 3, 20, 3);
            tblSummary.Name = "tblSummary";
            tblSummary.RowCount = 1;
            tblSummary.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSummary.Size = new Size(850, 538);
            tblSummary.TabIndex = 20;
            // 
            // tbPatientRecord
            // 
            tbPatientRecord.ActiveColor = Color.FromArgb(49, 62, 80);
            tbPatientRecord.ActiveFontColor = Color.FromArgb(226, 230, 237);
            tbPatientRecord.BaseColor = Color.FromArgb(37, 45, 56);
            tbPatientRecord.BGColor = Color.FromArgb(49, 62, 80);
            tbPatientRecord.Controls.Add(tabConsultations);
            tbPatientRecord.Controls.Add(tabPrescriptions);
            tbPatientRecord.Controls.Add(tabVitals);
            tbPatientRecord.Controls.Add(tabMedicalHistory);
            tbPatientRecord.Cursor = Cursors.Hand;
            tbPatientRecord.DeactiveFontColor = Color.FromArgb(92, 102, 114);
            tbPatientRecord.Dock = DockStyle.Fill;
            tbPatientRecord.Font = new Font("Panton-Trial", 10F, FontStyle.Bold);
            tbPatientRecord.ItemSize = new Size(120, 40);
            tbPatientRecord.Location = new Point(10, 10);
            tbPatientRecord.Margin = new Padding(10);
            tbPatientRecord.Name = "tbPatientRecord";
            tbPatientRecord.SelectedIndex = 0;
            tbPatientRecord.Size = new Size(830, 518);
            tbPatientRecord.SizeMode = TabSizeMode.Fixed;
            tbPatientRecord.TabIndex = 24;
            // 
            // tabConsultations
            // 
            tabConsultations.BackColor = Color.FromArgb(49, 62, 80);
            tabConsultations.Controls.Add(dgvConsultations);
            tabConsultations.Location = new Point(4, 44);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Padding = new Padding(3);
            tabConsultations.Size = new Size(822, 470);
            tabConsultations.TabIndex = 1;
            tabConsultations.Text = "Consultations";
            // 
            // dgvConsultations
            // 
            dgvConsultations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultations.Dock = DockStyle.Fill;
            dgvConsultations.Location = new Point(3, 3);
            dgvConsultations.Name = "dgvConsultations";
            dgvConsultations.ReadOnly = true;
            dgvConsultations.RowHeadersWidth = 51;
            dgvConsultations.Size = new Size(816, 464);
            dgvConsultations.TabIndex = 0;
            // 
            // tabPrescriptions
            // 
            tabPrescriptions.BackColor = Color.FromArgb(49, 62, 80);
            tabPrescriptions.Controls.Add(dgvPrescriptions);
            tabPrescriptions.Location = new Point(4, 44);
            tabPrescriptions.Name = "tabPrescriptions";
            tabPrescriptions.Padding = new Padding(3);
            tabPrescriptions.Size = new Size(822, 470);
            tabPrescriptions.TabIndex = 2;
            tabPrescriptions.Text = "Prescriptions";
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescriptions.Dock = DockStyle.Fill;
            dgvPrescriptions.Location = new Point(3, 3);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.ReadOnly = true;
            dgvPrescriptions.RowHeadersWidth = 51;
            dgvPrescriptions.Size = new Size(816, 464);
            dgvPrescriptions.TabIndex = 0;
            // 
            // tabVitals
            // 
            tabVitals.BackColor = Color.FromArgb(49, 62, 80);
            tabVitals.Controls.Add(dgvVitals);
            tabVitals.Location = new Point(4, 44);
            tabVitals.Name = "tabVitals";
            tabVitals.Padding = new Padding(3);
            tabVitals.Size = new Size(822, 470);
            tabVitals.TabIndex = 3;
            tabVitals.Text = "Patient Vitals";
            // 
            // dgvVitals
            // 
            dgvVitals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVitals.Dock = DockStyle.Fill;
            dgvVitals.Location = new Point(3, 3);
            dgvVitals.Margin = new Padding(3, 4, 3, 4);
            dgvVitals.Name = "dgvVitals";
            dgvVitals.RowHeadersWidth = 51;
            dgvVitals.Size = new Size(816, 464);
            dgvVitals.TabIndex = 1;
            // 
            // tabMedicalHistory
            // 
            tabMedicalHistory.BackColor = Color.FromArgb(49, 62, 80);
            tabMedicalHistory.Controls.Add(tableLayoutPanel3);
            tabMedicalHistory.Location = new Point(4, 44);
            tabMedicalHistory.Name = "tabMedicalHistory";
            tabMedicalHistory.Padding = new Padding(3);
            tabMedicalHistory.Size = new Size(822, 470);
            tabMedicalHistory.TabIndex = 4;
            tabMedicalHistory.Text = "Med. History";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(49, 62, 80);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnEdit, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel3.Size = new Size(816, 464);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(49, 62, 80);
            btnEdit.BorderColor = Color.FromArgb(26, 35, 48);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.EnteredBorderColor = Color.FromArgb(26, 35, 48);
            btnEdit.EnteredColor = Color.FromArgb(69, 85, 97);
            btnEdit.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnEdit.Image = null;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.InactiveColor = Color.FromArgb(26, 35, 48);
            btnEdit.Location = new Point(713, 420);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedBorderColor = Color.FromArgb(26, 35, 48);
            btnEdit.PressedColor = Color.FromArgb(26, 35, 48);
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Edit";
            btnEdit.TextAlignment = StringAlignment.Center;
            btnEdit.Click += btnEditHistory_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.6700211F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.32998F));
            tableLayoutPanel4.Controls.Add(txtHxMeds, 1, 3);
            tableLayoutPanel4.Controls.Add(txtHxFamilyHis, 1, 2);
            tableLayoutPanel4.Controls.Add(txtHxSurgeries, 1, 1);
            tableLayoutPanel4.Controls.Add(txtHxConditions, 1, 0);
            tableLayoutPanel4.Controls.Add(lblCurrMed, 0, 3);
            tableLayoutPanel4.Controls.Add(lblFamHis, 0, 2);
            tableLayoutPanel4.Controls.Add(lblSurgery, 0, 1);
            tableLayoutPanel4.Controls.Add(lblConditions, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 4);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(810, 408);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // txtHxMeds
            // 
            txtHxMeds.BackColor = Color.FromArgb(197, 202, 212);
            txtHxMeds.BaseColor = Color.FromArgb(108, 111, 127);
            txtHxMeds.BorderColorA = Color.FromArgb(108, 111, 127);
            txtHxMeds.BorderColorB = Color.FromArgb(108, 111, 127);
            txtHxMeds.Dock = DockStyle.Fill;
            txtHxMeds.Enabled = false;
            txtHxMeds.Font = new Font("TT Interphases Pro Trl", 10F);
            txtHxMeds.ForeColor = Color.FromArgb(26, 35, 48);
            txtHxMeds.Hint = "";
            txtHxMeds.Location = new Point(186, 132);
            txtHxMeds.MaxLength = 32767;
            txtHxMeds.Multiline = false;
            txtHxMeds.Name = "txtHxMeds";
            txtHxMeds.PasswordChar = '\0';
            txtHxMeds.ScrollBars = ScrollBars.None;
            txtHxMeds.SelectedText = "";
            txtHxMeds.SelectionLength = 0;
            txtHxMeds.SelectionStart = 0;
            txtHxMeds.Size = new Size(621, 37);
            txtHxMeds.TabIndex = 27;
            txtHxMeds.TabStop = false;
            txtHxMeds.UseSystemPasswordChar = false;
            // 
            // txtHxFamilyHis
            // 
            txtHxFamilyHis.BackColor = Color.FromArgb(197, 202, 212);
            txtHxFamilyHis.BaseColor = Color.FromArgb(108, 111, 127);
            txtHxFamilyHis.BorderColorA = Color.FromArgb(108, 111, 127);
            txtHxFamilyHis.BorderColorB = Color.FromArgb(108, 111, 127);
            txtHxFamilyHis.Dock = DockStyle.Fill;
            txtHxFamilyHis.Enabled = false;
            txtHxFamilyHis.Font = new Font("TT Interphases Pro Trl", 10F);
            txtHxFamilyHis.ForeColor = Color.FromArgb(26, 35, 48);
            txtHxFamilyHis.Hint = "";
            txtHxFamilyHis.Location = new Point(186, 89);
            txtHxFamilyHis.MaxLength = 32767;
            txtHxFamilyHis.Multiline = false;
            txtHxFamilyHis.Name = "txtHxFamilyHis";
            txtHxFamilyHis.PasswordChar = '\0';
            txtHxFamilyHis.ScrollBars = ScrollBars.None;
            txtHxFamilyHis.SelectedText = "";
            txtHxFamilyHis.SelectionLength = 0;
            txtHxFamilyHis.SelectionStart = 0;
            txtHxFamilyHis.Size = new Size(621, 37);
            txtHxFamilyHis.TabIndex = 26;
            txtHxFamilyHis.TabStop = false;
            txtHxFamilyHis.UseSystemPasswordChar = false;
            // 
            // txtHxSurgeries
            // 
            txtHxSurgeries.BackColor = Color.FromArgb(197, 202, 212);
            txtHxSurgeries.BaseColor = Color.FromArgb(108, 111, 127);
            txtHxSurgeries.BorderColorA = Color.FromArgb(108, 111, 127);
            txtHxSurgeries.BorderColorB = Color.FromArgb(108, 111, 127);
            txtHxSurgeries.Dock = DockStyle.Fill;
            txtHxSurgeries.Enabled = false;
            txtHxSurgeries.Font = new Font("TT Interphases Pro Trl", 10F);
            txtHxSurgeries.ForeColor = Color.FromArgb(26, 35, 48);
            txtHxSurgeries.Hint = "";
            txtHxSurgeries.Location = new Point(186, 46);
            txtHxSurgeries.MaxLength = 32767;
            txtHxSurgeries.Multiline = false;
            txtHxSurgeries.Name = "txtHxSurgeries";
            txtHxSurgeries.PasswordChar = '\0';
            txtHxSurgeries.ScrollBars = ScrollBars.None;
            txtHxSurgeries.SelectedText = "";
            txtHxSurgeries.SelectionLength = 0;
            txtHxSurgeries.SelectionStart = 0;
            txtHxSurgeries.Size = new Size(621, 37);
            txtHxSurgeries.TabIndex = 25;
            txtHxSurgeries.TabStop = false;
            txtHxSurgeries.UseSystemPasswordChar = false;
            // 
            // txtHxConditions
            // 
            txtHxConditions.BackColor = Color.FromArgb(197, 202, 212);
            txtHxConditions.BaseColor = Color.FromArgb(108, 111, 127);
            txtHxConditions.BorderColorA = Color.FromArgb(108, 111, 127);
            txtHxConditions.BorderColorB = Color.FromArgb(108, 111, 127);
            txtHxConditions.Dock = DockStyle.Fill;
            txtHxConditions.Enabled = false;
            txtHxConditions.Font = new Font("TT Interphases Pro Trl", 10F);
            txtHxConditions.ForeColor = Color.FromArgb(26, 35, 48);
            txtHxConditions.Hint = "";
            txtHxConditions.Location = new Point(186, 3);
            txtHxConditions.MaxLength = 32767;
            txtHxConditions.Multiline = false;
            txtHxConditions.Name = "txtHxConditions";
            txtHxConditions.PasswordChar = '\0';
            txtHxConditions.ScrollBars = ScrollBars.None;
            txtHxConditions.SelectedText = "";
            txtHxConditions.SelectionLength = 0;
            txtHxConditions.SelectionStart = 0;
            txtHxConditions.Size = new Size(621, 37);
            txtHxConditions.TabIndex = 24;
            txtHxConditions.TabStop = false;
            txtHxConditions.UseSystemPasswordChar = false;
            // 
            // lblCurrMed
            // 
            lblCurrMed.Anchor = AnchorStyles.Left;
            lblCurrMed.AutoSize = true;
            lblCurrMed.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblCurrMed.ForeColor = Color.FromArgb(226, 230, 237);
            lblCurrMed.Location = new Point(3, 140);
            lblCurrMed.Name = "lblCurrMed";
            lblCurrMed.Size = new Size(168, 21);
            lblCurrMed.TabIndex = 8;
            lblCurrMed.Text = "Current Medication/s:";
            // 
            // lblFamHis
            // 
            lblFamHis.Anchor = AnchorStyles.Left;
            lblFamHis.AutoSize = true;
            lblFamHis.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblFamHis.ForeColor = Color.FromArgb(226, 230, 237);
            lblFamHis.Location = new Point(3, 97);
            lblFamHis.Name = "lblFamHis";
            lblFamHis.Size = new Size(115, 21);
            lblFamHis.TabIndex = 6;
            lblFamHis.Text = "Family History:";
            // 
            // lblSurgery
            // 
            lblSurgery.Anchor = AnchorStyles.Left;
            lblSurgery.AutoSize = true;
            lblSurgery.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblSurgery.ForeColor = Color.FromArgb(226, 230, 237);
            lblSurgery.Location = new Point(3, 54);
            lblSurgery.Name = "lblSurgery";
            lblSurgery.Size = new Size(82, 21);
            lblSurgery.TabIndex = 5;
            lblSurgery.Text = "Surgeries:";
            // 
            // lblConditions
            // 
            lblConditions.Anchor = AnchorStyles.Left;
            lblConditions.AutoSize = true;
            lblConditions.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblConditions.ForeColor = Color.FromArgb(226, 230, 237);
            lblConditions.Location = new Point(3, 11);
            lblConditions.Name = "lblConditions";
            lblConditions.Size = new Size(91, 21);
            lblConditions.TabIndex = 4;
            lblConditions.Text = "Conditions:";
            // 
            // tblInfoIntro
            // 
            tblInfoIntro.BackColor = Color.FromArgb(37, 45, 56);
            tblInfoIntro.ColumnCount = 1;
            tblInfoIntro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfoIntro.Controls.Add(tblHeader, 0, 0);
            tblInfoIntro.Dock = DockStyle.Fill;
            tblInfoIntro.Location = new Point(20, 60);
            tblInfoIntro.Margin = new Padding(20, 3, 20, 3);
            tblInfoIntro.Name = "tblInfoIntro";
            tblInfoIntro.RowCount = 1;
            tblInfoIntro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblInfoIntro.Size = new Size(850, 159);
            tblInfoIntro.TabIndex = 21;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeader.Controls.Add(lblFullName, 1, 1);
            tblHeader.Controls.Add(panel2, 1, 3);
            tblHeader.Controls.Add(panel1, 0, 3);
            tblHeader.Controls.Add(lblMeta, 2, 2);
            tblHeader.Controls.Add(lblPatientName, 2, 1);
            tblHeader.Controls.Add(cboPatient, 2, 0);
            tblHeader.Controls.Add(label2, 1, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(10, 10);
            tblHeader.Margin = new Padding(10);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 4;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tblHeader.Size = new Size(830, 139);
            tblHeader.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFullName.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(92, 102, 114);
            lblFullName.Location = new Point(5, 62);
            lblFullName.Margin = new Padding(0, 3, 3, 3);
            lblFullName.Name = "lblFullName";
            tblHeader.SetRowSpan(lblFullName, 2);
            lblFullName.Size = new Size(87, 21);
            lblFullName.TabIndex = 30;
            lblFullName.Text = "Full Name:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(244, 203, 195);
            tblHeader.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(lblAllergy);
            panel2.Controls.Add(lblAllergies);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(5, 104);
            panel2.Margin = new Padding(0, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(822, 24);
            panel2.TabIndex = 22;
            // 
            // lblAllergy
            // 
            lblAllergy.Anchor = AnchorStyles.Left;
            lblAllergy.AutoSize = true;
            lblAllergy.Font = new Font("Panton Narrow-Trial SemiBold", 9F);
            lblAllergy.ForeColor = Color.FromArgb(153, 27, 27);
            lblAllergy.Location = new Point(93, 2);
            lblAllergy.Name = "lblAllergy";
            lblAllergy.Size = new Size(43, 19);
            lblAllergy.TabIndex = 39;
            lblAllergy.Text = "None";
            // 
            // lblAllergies
            // 
            lblAllergies.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblAllergies.ForeColor = Color.FromArgb(153, 27, 27);
            lblAllergies.Location = new Point(3, 0);
            lblAllergies.Margin = new Padding(3);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(84, 22);
            lblAllergies.TabIndex = 38;
            lblAllergies.Text = "Allergies:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(153, 27, 27);
            label4.Location = new Point(93, -37);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 37;
            label4.Text = "None";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(153, 27, 27);
            label5.Location = new Point(3, -37);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(84, 22);
            label5.TabIndex = 36;
            label5.Text = "Allergies:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 27, 27);
            panel1.Location = new Point(0, 101);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 30);
            panel1.TabIndex = 33;
            // 
            // lblMeta
            // 
            lblMeta.AutoSize = true;
            lblMeta.Font = new Font("TT Interphases Pro Trl Variable", 9F);
            lblMeta.ForeColor = Color.FromArgb(92, 102, 114);
            lblMeta.Location = new Point(98, 75);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(73, 19);
            lblMeta.TabIndex = 34;
            lblMeta.Text = "Ryan Kurt";
            // 
            // lblPatientName
            // 
            lblPatientName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(226, 230, 237);
            lblPatientName.Location = new Point(98, 54);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(82, 21);
            lblPatientName.TabIndex = 35;
            lblPatientName.Text = "Ryan Kurt";
            // 
            // cboPatient
            // 
            cboPatient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboPatient.DrawMode = DrawMode.OwnerDrawFixed;
            cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatient.FlatStyle = FlatStyle.Flat;
            cboPatient.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboPatient.ForeColor = Color.FromArgb(37, 45, 56);
            cboPatient.FormattingEnabled = true;
            cboPatient.ItemHeight = 30;
            cboPatient.Location = new Point(98, 4);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(729, 36);
            cboPatient.TabIndex = 36;
            cboPatient.SelectedIndexChanged += cboPatient_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(92, 102, 114);
            label2.Location = new Point(5, 14);
            label2.Margin = new Padding(0, 3, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 37;
            label2.Text = "Patients:";
            // 
            // PatientRecordControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientRecordControl";
            Size = new Size(890, 789);
            tblLayout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tblSummary.ResumeLayout(false);
            tbPatientRecord.ResumeLayout(false);
            tabConsultations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).EndInit();
            tabPrescriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            tabVitals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVitals).EndInit();
            tabMedicalHistory.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tblInfoIntro.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private ReaLTaiizor.Controls.Button btnPrint;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblSummary;
        private ReaLTaiizor.Controls.ForeverTabPage tbPatientRecord;
        private TabPage tabConsultations;
        private DataGridView dgvConsultations;
        private TabPage tabPrescriptions;
        private DataGridView dgvPrescriptions;
        private TabPage tabVitals;
        private DataGridView dgvVitals;
        private TabPage tabMedicalHistory;
        private TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.Button btnEdit;
        private TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.HopeTextBox txtHxMeds;
        private ReaLTaiizor.Controls.HopeTextBox txtHxFamilyHis;
        private ReaLTaiizor.Controls.HopeTextBox txtHxSurgeries;
        private ReaLTaiizor.Controls.HopeTextBox txtHxConditions;
        private Label lblCurrMed;
        private Label lblFamHis;
        private Label lblSurgery;
        private Label lblConditions;
        private TableLayoutPanel tblInfoIntro;
        private TableLayoutPanel tblHeader;
        private Label lblFullName;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label lblAllergy;
        private Label lblAllergies;
        private Panel panel1;
        private Label lblMeta;
        private Label lblPatientName;
        private ReaLTaiizor.Controls.HopeComboBox cboPatient;
        private Label label2;
        private Label label6;
        private ReaLTaiizor.Controls.Button btnBack;
    }
}
