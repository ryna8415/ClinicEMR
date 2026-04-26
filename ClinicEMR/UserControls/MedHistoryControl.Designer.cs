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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedHistoryControl));
            tblLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tblInfoIntro = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            lblFullName = new Label();
            lblMeta = new Label();
            lblPatientName = new Label();
            cboPatient = new ReaLTaiizor.Controls.HopeComboBox();
            label2 = new Label();
            tblContent = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtCurrentMeds = new ReaLTaiizor.Controls.HopeTextBox();
            txtFamHx = new ReaLTaiizor.Controls.HopeTextBox();
            txtSurgeries = new ReaLTaiizor.Controls.HopeTextBox();
            label7 = new Label();
            txtConditions = new ReaLTaiizor.Controls.HopeTextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label10 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtEmergency = new ReaLTaiizor.Controls.HopeTextBox();
            label12 = new Label();
            label9 = new Label();
            txtAge = new ReaLTaiizor.Controls.HopeTextBox();
            label3 = new Label();
            cboSex = new ReaLTaiizor.Controls.HopeComboBox();
            txtAddress = new ReaLTaiizor.Controls.HopeTextBox();
            label13 = new Label();
            label14 = new Label();
            label11 = new Label();
            txtContactNumber = new ReaLTaiizor.Controls.HopeTextBox();
            txtAllergies = new ReaLTaiizor.Controls.HopeTextBox();
            label4 = new Label();
            pnlDiv = new Panel();
            btnSave = new ReaLTaiizor.Controls.Button();
            tblLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tblInfoIntro.SuspendLayout();
            tblHeader.SuspendLayout();
            tblContent.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Controls.Add(tblInfoIntro, 0, 2);
            tblLayout.Controls.Add(tblContent, 0, 3);
            tblLayout.Controls.Add(btnSave, 0, 4);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 5;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 129F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tblLayout.Size = new Size(808, 744);
            tblLayout.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 31);
            tableLayoutPanel1.Margin = new Padding(20, 4, 20, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(768, 42);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(26, 35, 48);
            label1.Location = new Point(43, 5);
            label1.Name = "label1";
            label1.Size = new Size(184, 31);
            label1.TabIndex = 1;
            label1.Text = "Medical History";
            // 
            // tblInfoIntro
            // 
            tblInfoIntro.BackColor = Color.FromArgb(37, 45, 56);
            tblInfoIntro.ColumnCount = 1;
            tblInfoIntro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfoIntro.Controls.Add(tblHeader, 0, 0);
            tblInfoIntro.Dock = DockStyle.Fill;
            tblInfoIntro.Location = new Point(20, 80);
            tblInfoIntro.Margin = new Padding(20, 3, 20, 3);
            tblInfoIntro.Name = "tblInfoIntro";
            tblInfoIntro.RowCount = 1;
            tblInfoIntro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblInfoIntro.Size = new Size(768, 123);
            tblInfoIntro.TabIndex = 25;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblHeader.Controls.Add(lblFullName, 0, 1);
            tblHeader.Controls.Add(lblMeta, 1, 2);
            tblHeader.Controls.Add(lblPatientName, 1, 1);
            tblHeader.Controls.Add(cboPatient, 1, 0);
            tblHeader.Controls.Add(label2, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(10, 10);
            tblHeader.Margin = new Padding(10);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 4;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tblHeader.Size = new Size(748, 103);
            tblHeader.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFullName.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(92, 102, 114);
            lblFullName.Location = new Point(0, 64);
            lblFullName.Margin = new Padding(0, 3, 3, 3);
            lblFullName.Name = "lblFullName";
            tblHeader.SetRowSpan(lblFullName, 2);
            lblFullName.Size = new Size(87, 21);
            lblFullName.TabIndex = 30;
            lblFullName.Text = "Full Name:";
            // 
            // lblMeta
            // 
            lblMeta.AutoSize = true;
            lblMeta.Font = new Font("TT Interphases Pro Trl Variable", 9F);
            lblMeta.ForeColor = Color.FromArgb(92, 102, 114);
            lblMeta.Location = new Point(93, 75);
            lblMeta.Name = "lblMeta";
            lblMeta.Size = new Size(190, 19);
            lblMeta.TabIndex = 34;
            lblMeta.Text = "Select a patient from the list";
            // 
            // lblPatientName
            // 
            lblPatientName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(226, 230, 237);
            lblPatientName.Location = new Point(93, 54);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(124, 21);
            lblPatientName.TabIndex = 35;
            lblPatientName.Text = "None Selected";
            // 
            // cboPatient
            // 
            cboPatient.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblHeader.SetColumnSpan(cboPatient, 2);
            cboPatient.DrawMode = DrawMode.OwnerDrawFixed;
            cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatient.FlatStyle = FlatStyle.Flat;
            cboPatient.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboPatient.ForeColor = Color.FromArgb(37, 45, 56);
            cboPatient.FormattingEnabled = true;
            cboPatient.ItemHeight = 30;
            cboPatient.Location = new Point(93, 4);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(652, 36);
            cboPatient.TabIndex = 36;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(92, 102, 114);
            label2.Location = new Point(0, 14);
            label2.Margin = new Padding(0, 3, 3, 3);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 37;
            label2.Text = "Patients:";
            // 
            // tblContent
            // 
            tblContent.BackColor = Color.FromArgb(37, 45, 56);
            tblContent.ColumnCount = 3;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblContent.Controls.Add(tableLayoutPanel4, 2, 0);
            tblContent.Controls.Add(tableLayoutPanel7, 0, 0);
            tblContent.Controls.Add(pnlDiv, 1, 0);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(20, 213);
            tblContent.Margin = new Padding(20, 7, 20, 3);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 1;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblContent.Size = new Size(768, 456);
            tblContent.TabIndex = 26;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(txtCurrentMeds, 1, 5);
            tableLayoutPanel4.Controls.Add(txtFamHx, 1, 3);
            tableLayoutPanel4.Controls.Add(txtSurgeries, 1, 2);
            tableLayoutPanel4.Controls.Add(label7, 0, 2);
            tableLayoutPanel4.Controls.Add(txtConditions, 1, 1);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(label8, 0, 3);
            tableLayoutPanel4.Controls.Add(label10, 0, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(395, 10);
            tableLayoutPanel4.Margin = new Padding(10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 7;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(363, 436);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // txtCurrentMeds
            // 
            txtCurrentMeds.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCurrentMeds.BackColor = Color.FromArgb(197, 202, 212);
            txtCurrentMeds.BaseColor = Color.FromArgb(37, 45, 56);
            txtCurrentMeds.BorderColorA = Color.FromArgb(108, 111, 127);
            txtCurrentMeds.BorderColorB = Color.FromArgb(108, 111, 127);
            txtCurrentMeds.Cursor = Cursors.IBeam;
            txtCurrentMeds.Font = new Font("TT Interphases Pro Trl", 10F);
            txtCurrentMeds.ForeColor = Color.FromArgb(26, 35, 48);
            txtCurrentMeds.Hint = "Include dosage";
            txtCurrentMeds.Location = new Point(103, 231);
            txtCurrentMeds.MaxLength = 1000;
            txtCurrentMeds.Multiline = false;
            txtCurrentMeds.Name = "txtCurrentMeds";
            txtCurrentMeds.PasswordChar = '\0';
            txtCurrentMeds.ScrollBars = ScrollBars.None;
            txtCurrentMeds.SelectedText = "";
            txtCurrentMeds.SelectionLength = 0;
            txtCurrentMeds.SelectionStart = 0;
            txtCurrentMeds.Size = new Size(257, 37);
            txtCurrentMeds.TabIndex = 41;
            txtCurrentMeds.TabStop = false;
            txtCurrentMeds.UseSystemPasswordChar = false;
            // 
            // txtFamHx
            // 
            txtFamHx.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFamHx.BackColor = Color.FromArgb(197, 202, 212);
            txtFamHx.BaseColor = Color.FromArgb(37, 45, 56);
            txtFamHx.BorderColorA = Color.FromArgb(108, 111, 127);
            txtFamHx.BorderColorB = Color.FromArgb(108, 111, 127);
            txtFamHx.Cursor = Cursors.IBeam;
            txtFamHx.Font = new Font("TT Interphases Pro Trl", 10F);
            txtFamHx.ForeColor = Color.FromArgb(26, 35, 48);
            txtFamHx.Hint = "Relevant family medical history...";
            txtFamHx.Location = new Point(103, 141);
            txtFamHx.MaxLength = 1000;
            txtFamHx.Multiline = true;
            txtFamHx.Name = "txtFamHx";
            txtFamHx.PasswordChar = '\0';
            tableLayoutPanel4.SetRowSpan(txtFamHx, 2);
            txtFamHx.ScrollBars = ScrollBars.None;
            txtFamHx.SelectedText = "";
            txtFamHx.SelectionLength = 0;
            txtFamHx.SelectionStart = 0;
            txtFamHx.Size = new Size(257, 74);
            txtFamHx.TabIndex = 39;
            txtFamHx.TabStop = false;
            txtFamHx.UseSystemPasswordChar = false;
            // 
            // txtSurgeries
            // 
            txtSurgeries.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSurgeries.BackColor = Color.FromArgb(197, 202, 212);
            txtSurgeries.BaseColor = Color.FromArgb(37, 45, 56);
            txtSurgeries.BorderColorA = Color.FromArgb(108, 111, 127);
            txtSurgeries.BorderColorB = Color.FromArgb(108, 111, 127);
            txtSurgeries.Cursor = Cursors.IBeam;
            txtSurgeries.Font = new Font("TT Interphases Pro Trl", 10F);
            txtSurgeries.ForeColor = Color.FromArgb(26, 35, 48);
            txtSurgeries.Hint = "Past surgical procedures...";
            txtSurgeries.Location = new Point(103, 90);
            txtSurgeries.MaxLength = 1000;
            txtSurgeries.Multiline = false;
            txtSurgeries.Name = "txtSurgeries";
            txtSurgeries.PasswordChar = '\0';
            txtSurgeries.ScrollBars = ScrollBars.None;
            txtSurgeries.SelectedText = "";
            txtSurgeries.SelectionLength = 0;
            txtSurgeries.SelectionStart = 0;
            txtSurgeries.Size = new Size(257, 37);
            txtSurgeries.TabIndex = 38;
            txtSurgeries.TabStop = false;
            txtSurgeries.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(92, 102, 114);
            label7.Location = new Point(3, 98);
            label7.Margin = new Padding(3);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 36;
            label7.Text = "Surgeries:";
            // 
            // txtConditions
            // 
            txtConditions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtConditions.BackColor = Color.FromArgb(197, 202, 212);
            txtConditions.BaseColor = Color.FromArgb(37, 45, 56);
            txtConditions.BorderColorA = Color.FromArgb(108, 111, 127);
            txtConditions.BorderColorB = Color.FromArgb(108, 111, 127);
            txtConditions.Cursor = Cursors.IBeam;
            txtConditions.Font = new Font("TT Interphases Pro Trl", 10F);
            txtConditions.ForeColor = Color.FromArgb(26, 35, 48);
            txtConditions.Hint = "Chronic conditions ...";
            txtConditions.Location = new Point(103, 44);
            txtConditions.MaxLength = 1000;
            txtConditions.Multiline = false;
            txtConditions.Name = "txtConditions";
            txtConditions.PasswordChar = '\0';
            txtConditions.ScrollBars = ScrollBars.None;
            txtConditions.SelectedText = "";
            txtConditions.SelectionLength = 0;
            txtConditions.SelectionStart = 0;
            txtConditions.Size = new Size(257, 37);
            txtConditions.TabIndex = 35;
            txtConditions.TabStop = false;
            txtConditions.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(92, 102, 114);
            label5.Location = new Point(3, 52);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 33;
            label5.Text = "Conditions:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.SetColumnSpan(label6, 2);
            label6.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(226, 230, 237);
            label6.Location = new Point(0, 9);
            label6.Margin = new Padding(0, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(360, 21);
            label6.TabIndex = 32;
            label6.Text = "Medical History";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(92, 102, 114);
            label8.Location = new Point(3, 156);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            tableLayoutPanel4.SetRowSpan(label8, 2);
            label8.Size = new Size(94, 43);
            label8.TabIndex = 37;
            label8.Text = "Family History:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(92, 102, 114);
            label10.Location = new Point(3, 227);
            label10.Margin = new Padding(3, 3, 0, 3);
            label10.Name = "label10";
            label10.Size = new Size(97, 46);
            label10.TabIndex = 40;
            label10.Text = "Current Meds.:";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 4;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(txtEmergency, 1, 5);
            tableLayoutPanel7.Controls.Add(label12, 0, 0);
            tableLayoutPanel7.Controls.Add(label9, 0, 1);
            tableLayoutPanel7.Controls.Add(txtAge, 1, 1);
            tableLayoutPanel7.Controls.Add(label3, 2, 1);
            tableLayoutPanel7.Controls.Add(cboSex, 3, 1);
            tableLayoutPanel7.Controls.Add(txtAddress, 1, 2);
            tableLayoutPanel7.Controls.Add(label13, 0, 2);
            tableLayoutPanel7.Controls.Add(label14, 0, 5);
            tableLayoutPanel7.Controls.Add(label11, 0, 4);
            tableLayoutPanel7.Controls.Add(txtContactNumber, 1, 4);
            tableLayoutPanel7.Controls.Add(txtAllergies, 1, 3);
            tableLayoutPanel7.Controls.Add(label4, 0, 3);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(10, 10);
            tableLayoutPanel7.Margin = new Padding(10);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 7;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(362, 436);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // txtEmergency
            // 
            txtEmergency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmergency.BackColor = Color.FromArgb(197, 202, 212);
            txtEmergency.BaseColor = Color.FromArgb(37, 45, 56);
            txtEmergency.BorderColorA = Color.FromArgb(108, 111, 127);
            txtEmergency.BorderColorB = Color.FromArgb(108, 111, 127);
            tableLayoutPanel7.SetColumnSpan(txtEmergency, 3);
            txtEmergency.Cursor = Cursors.IBeam;
            txtEmergency.Font = new Font("TT Interphases Pro Trl", 10F);
            txtEmergency.ForeColor = Color.FromArgb(26, 35, 48);
            txtEmergency.Hint = "";
            txtEmergency.Location = new Point(103, 231);
            txtEmergency.MaxLength = 100;
            txtEmergency.Multiline = false;
            txtEmergency.Name = "txtEmergency";
            txtEmergency.PasswordChar = '\0';
            txtEmergency.ScrollBars = ScrollBars.None;
            txtEmergency.SelectedText = "";
            txtEmergency.SelectionLength = 0;
            txtEmergency.SelectionStart = 0;
            txtEmergency.Size = new Size(256, 37);
            txtEmergency.TabIndex = 47;
            txtEmergency.TabStop = false;
            txtEmergency.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.SetColumnSpan(label12, 2);
            label12.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(226, 230, 237);
            label12.Location = new Point(0, 9);
            label12.Margin = new Padding(0, 0, 3, 0);
            label12.Name = "label12";
            label12.Size = new Size(178, 21);
            label12.TabIndex = 38;
            label12.Text = "Personal Information";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(92, 102, 114);
            label9.Location = new Point(3, 52);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(94, 21);
            label9.TabIndex = 30;
            label9.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAge.BackColor = Color.FromArgb(197, 202, 212);
            txtAge.BaseColor = Color.FromArgb(37, 45, 56);
            txtAge.BorderColorA = Color.FromArgb(108, 111, 127);
            txtAge.BorderColorB = Color.FromArgb(108, 111, 127);
            txtAge.Cursor = Cursors.IBeam;
            txtAge.Font = new Font("TT Interphases Pro Trl", 10F);
            txtAge.ForeColor = Color.FromArgb(26, 35, 48);
            txtAge.Hint = "";
            txtAge.Location = new Point(103, 44);
            txtAge.MaxLength = 100;
            txtAge.Multiline = false;
            txtAge.Name = "txtAge";
            txtAge.PasswordChar = '\0';
            txtAge.ScrollBars = ScrollBars.None;
            txtAge.SelectedText = "";
            txtAge.SelectionLength = 0;
            txtAge.SelectionStart = 0;
            txtAge.Size = new Size(75, 37);
            txtAge.TabIndex = 34;
            txtAge.TabStop = false;
            txtAge.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(92, 102, 114);
            label3.Location = new Point(184, 52);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 31;
            label3.Text = "Sex:";
            // 
            // cboSex
            // 
            cboSex.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboSex.DrawMode = DrawMode.OwnerDrawFixed;
            cboSex.FlatStyle = FlatStyle.Flat;
            cboSex.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboSex.ForeColor = Color.FromArgb(92, 102, 114);
            cboSex.FormattingEnabled = true;
            cboSex.ItemHeight = 30;
            cboSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cboSex.Location = new Point(284, 45);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(75, 36);
            cboSex.TabIndex = 29;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BackColor = Color.FromArgb(197, 202, 212);
            txtAddress.BaseColor = Color.FromArgb(37, 45, 56);
            txtAddress.BorderColorA = Color.FromArgb(108, 111, 127);
            txtAddress.BorderColorB = Color.FromArgb(108, 111, 127);
            tableLayoutPanel7.SetColumnSpan(txtAddress, 3);
            txtAddress.Cursor = Cursors.IBeam;
            txtAddress.Font = new Font("TT Interphases Pro Trl", 10F);
            txtAddress.ForeColor = Color.FromArgb(26, 35, 48);
            txtAddress.Hint = "";
            txtAddress.Location = new Point(103, 90);
            txtAddress.MaxLength = 100;
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.ScrollBars = ScrollBars.None;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.Size = new Size(256, 37);
            txtAddress.TabIndex = 40;
            txtAddress.TabStop = false;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(92, 102, 114);
            label13.Location = new Point(3, 98);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(94, 21);
            label13.TabIndex = 41;
            label13.Text = "Address:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(92, 102, 114);
            label14.Location = new Point(3, 227);
            label14.Margin = new Padding(3);
            label14.Name = "label14";
            label14.Size = new Size(94, 46);
            label14.TabIndex = 43;
            label14.Text = "EmergencyContact No:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(92, 102, 114);
            label11.Location = new Point(3, 190);
            label11.Margin = new Padding(3);
            label11.Name = "label11";
            label11.Size = new Size(94, 21);
            label11.TabIndex = 39;
            label11.Text = "Contact No:";
            // 
            // txtContactNumber
            // 
            txtContactNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtContactNumber.BackColor = Color.FromArgb(197, 202, 212);
            txtContactNumber.BaseColor = Color.FromArgb(37, 45, 56);
            txtContactNumber.BorderColorA = Color.FromArgb(108, 111, 127);
            txtContactNumber.BorderColorB = Color.FromArgb(108, 111, 127);
            tableLayoutPanel7.SetColumnSpan(txtContactNumber, 3);
            txtContactNumber.Cursor = Cursors.IBeam;
            txtContactNumber.Font = new Font("TT Interphases Pro Trl", 10F);
            txtContactNumber.ForeColor = Color.FromArgb(26, 35, 48);
            txtContactNumber.Hint = "";
            txtContactNumber.Location = new Point(103, 182);
            txtContactNumber.MaxLength = 100;
            txtContactNumber.Multiline = false;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.PasswordChar = '\0';
            txtContactNumber.ScrollBars = ScrollBars.None;
            txtContactNumber.SelectedText = "";
            txtContactNumber.SelectionLength = 0;
            txtContactNumber.SelectionStart = 0;
            txtContactNumber.Size = new Size(256, 37);
            txtContactNumber.TabIndex = 42;
            txtContactNumber.TabStop = false;
            txtContactNumber.UseSystemPasswordChar = false;
            // 
            // txtAllergies
            // 
            txtAllergies.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAllergies.BackColor = Color.FromArgb(197, 202, 212);
            txtAllergies.BaseColor = Color.FromArgb(37, 45, 56);
            txtAllergies.BorderColorA = Color.FromArgb(108, 111, 127);
            txtAllergies.BorderColorB = Color.FromArgb(108, 111, 127);
            tableLayoutPanel7.SetColumnSpan(txtAllergies, 3);
            txtAllergies.Cursor = Cursors.IBeam;
            txtAllergies.Font = new Font("TT Interphases Pro Trl", 10F);
            txtAllergies.ForeColor = Color.FromArgb(26, 35, 48);
            txtAllergies.Hint = "";
            txtAllergies.Location = new Point(103, 136);
            txtAllergies.MaxLength = 100;
            txtAllergies.Multiline = false;
            txtAllergies.Name = "txtAllergies";
            txtAllergies.PasswordChar = '\0';
            txtAllergies.ScrollBars = ScrollBars.None;
            txtAllergies.SelectedText = "";
            txtAllergies.SelectionLength = 0;
            txtAllergies.SelectionStart = 0;
            txtAllergies.Size = new Size(256, 37);
            txtAllergies.TabIndex = 44;
            txtAllergies.TabStop = false;
            txtAllergies.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(92, 102, 114);
            label4.Location = new Point(3, 144);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 46;
            label4.Text = "Allergies:";
            // 
            // pnlDiv
            // 
            pnlDiv.BackColor = Color.FromArgb(92, 102, 114);
            pnlDiv.Dock = DockStyle.Fill;
            pnlDiv.Location = new Point(382, 10);
            pnlDiv.Margin = new Padding(0, 10, 0, 10);
            pnlDiv.Name = "pnlDiv";
            pnlDiv.Size = new Size(3, 436);
            pnlDiv.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(226, 230, 237);
            btnSave.BorderColor = Color.FromArgb(26, 35, 48);
            btnSave.Cursor = Cursors.Hand;
            btnSave.EnteredBorderColor = Color.FromArgb(26, 35, 48);
            btnSave.EnteredColor = Color.FromArgb(69, 85, 97);
            btnSave.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(26, 35, 48);
            btnSave.Location = new Point(688, 679);
            btnSave.Margin = new Padding(3, 7, 20, 4);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(26, 35, 48);
            btnSave.PressedColor = Color.FromArgb(26, 35, 48);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.TextAlignment = StringAlignment.Center;
            // 
            // MedHistoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MedHistoryControl";
            Size = new Size(808, 744);
            tblLayout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tblInfoIntro.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblContent.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private TableLayoutPanel tblInfoIntro;
        private TableLayoutPanel tblHeader;
        private Label lblFullName;
        private Label lblMeta;
        private Label lblPatientName;
        private ReaLTaiizor.Controls.HopeComboBox cboPatient;
        private Label label2;
        private TableLayoutPanel tblContent;
        private TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.HopeTextBox txtCurrentMeds;
        private ReaLTaiizor.Controls.HopeTextBox txtFamHx;
        private ReaLTaiizor.Controls.HopeTextBox txtSurgeries;
        private Label label7;
        private ReaLTaiizor.Controls.HopeTextBox txtConditions;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel7;
        private ReaLTaiizor.Controls.HopeTextBox txtEmergency;
        private Label label12;
        private Label label9;
        private ReaLTaiizor.Controls.HopeTextBox txtAge;
        private Label label3;
        private ReaLTaiizor.Controls.HopeComboBox cboSex;
        private ReaLTaiizor.Controls.HopeTextBox txtAddress;
        private Label label13;
        private Label label14;
        private Label label11;
        private ReaLTaiizor.Controls.HopeTextBox txtContactNumber;
        private ReaLTaiizor.Controls.HopeTextBox txtAllergies;
        private Label label4;
        private Panel pnlDiv;
        private ReaLTaiizor.Controls.Button btnSave;
    }
}
