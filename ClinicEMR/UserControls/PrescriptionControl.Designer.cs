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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionControl));
            tblLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPrint = new ReaLTaiizor.Controls.Button();
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnEdit = new ReaLTaiizor.Controls.Button();
            btnDone = new ReaLTaiizor.Controls.Button();
            btnVoid = new ReaLTaiizor.Controls.Button();
            lblDate = new Label();
            lstDrugs = new ListBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label12 = new Label();
            label9 = new Label();
            txtMedication = new ReaLTaiizor.Controls.HopeTextBox();
            txtDosage = new ReaLTaiizor.Controls.HopeTextBox();
            label13 = new Label();
            label14 = new Label();
            label11 = new Label();
            txtDuration = new ReaLTaiizor.Controls.HopeTextBox();
            txtFrequency = new ReaLTaiizor.Controls.HopeTextBox();
            label4 = new Label();
            txtInstructions = new ReaLTaiizor.Controls.HopeTextBox();
            btnSave = new ReaLTaiizor.Controls.Button();
            pnlDiv = new Panel();
            tblLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tblInfoIntro.SuspendLayout();
            tblHeader.SuspendLayout();
            tblContent.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tblLayout.Size = new Size(839, 763);
            tblLayout.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Controls.Add(btnPrint, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 31);
            tableLayoutPanel1.Margin = new Padding(20, 4, 20, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(799, 42);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(226, 230, 237);
            btnPrint.BorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.EnteredColor = Color.FromArgb(69, 85, 97);
            btnPrint.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnPrint.Image = null;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.InactiveColor = Color.FromArgb(92, 102, 114);
            btnPrint.Location = new Point(699, 0);
            btnPrint.Margin = new Padding(3, 0, 0, 0);
            btnPrint.Name = "btnPrint";
            btnPrint.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.PressedColor = Color.FromArgb(108, 111, 127);
            btnPrint.Size = new Size(100, 40);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "Print";
            btnPrint.TextAlignment = StringAlignment.Center;
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
            label1.Size = new Size(296, 31);
            label1.TabIndex = 1;
            label1.Text = "Prescription Management";
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
            tblInfoIntro.Size = new Size(799, 123);
            tblInfoIntro.TabIndex = 25;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 2;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
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
            tblHeader.Size = new Size(779, 103);
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
            cboPatient.DrawMode = DrawMode.OwnerDrawFixed;
            cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatient.FlatStyle = FlatStyle.Flat;
            cboPatient.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cboPatient.ForeColor = Color.FromArgb(37, 45, 56);
            cboPatient.FormattingEnabled = true;
            cboPatient.ItemHeight = 30;
            cboPatient.Location = new Point(93, 4);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(683, 36);
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
            tblContent.Size = new Size(799, 475);
            tblContent.TabIndex = 26;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel4.Controls.Add(btnVoid, 0, 8);
            tableLayoutPanel4.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel4.Controls.Add(lstDrugs, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(411, 10);
            tableLayoutPanel4.Margin = new Padding(10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 10;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel4.Size = new Size(378, 455);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnEdit, 0, 0);
            tableLayoutPanel2.Controls.Add(btnDone, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 310);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(378, 49);
            tableLayoutPanel2.TabIndex = 44;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Left;
            btnEdit.BackColor = Color.FromArgb(37, 45, 56);
            btnEdit.BorderColor = Color.FromArgb(108, 111, 127);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnEdit.EnteredColor = Color.FromArgb(69, 85, 97);
            btnEdit.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnEdit.Image = null;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.InactiveColor = Color.FromArgb(92, 102, 114);
            btnEdit.Location = new Point(3, 4);
            btnEdit.Margin = new Padding(3, 0, 3, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnEdit.PressedColor = Color.FromArgb(108, 111, 127);
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 49;
            btnEdit.Text = "Edit";
            btnEdit.TextAlignment = StringAlignment.Center;
            // 
            // btnDone
            // 
            btnDone.Anchor = AnchorStyles.Right;
            btnDone.BackColor = Color.FromArgb(37, 45, 56);
            btnDone.BorderColor = Color.FromArgb(197, 202, 212);
            btnDone.Cursor = Cursors.Hand;
            btnDone.EnteredBorderColor = Color.FromArgb(197, 202, 212);
            btnDone.EnteredColor = Color.FromArgb(69, 85, 97);
            btnDone.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnDone.Image = null;
            btnDone.ImageAlign = ContentAlignment.MiddleLeft;
            btnDone.InactiveColor = Color.FromArgb(26, 35, 48);
            btnDone.Location = new Point(275, 4);
            btnDone.Margin = new Padding(3, 0, 3, 0);
            btnDone.Name = "btnDone";
            btnDone.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnDone.PressedColor = Color.FromArgb(108, 111, 127);
            btnDone.Size = new Size(100, 40);
            btnDone.TabIndex = 41;
            btnDone.Text = "Done";
            btnDone.TextAlignment = StringAlignment.Center;
            // 
            // btnVoid
            // 
            btnVoid.Anchor = AnchorStyles.Right;
            btnVoid.BackColor = Color.FromArgb(37, 45, 56);
            btnVoid.BorderColor = Color.FromArgb(108, 111, 127);
            btnVoid.Cursor = Cursors.Hand;
            btnVoid.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnVoid.EnteredColor = Color.FromArgb(69, 85, 97);
            btnVoid.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnVoid.Image = null;
            btnVoid.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoid.InactiveColor = Color.FromArgb(92, 102, 114);
            btnVoid.Location = new Point(275, 368);
            btnVoid.Margin = new Padding(3, 0, 3, 0);
            btnVoid.Name = "btnVoid";
            btnVoid.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnVoid.PressedColor = Color.FromArgb(108, 111, 127);
            btnVoid.Size = new Size(100, 40);
            btnVoid.TabIndex = 50;
            btnVoid.Text = "Void";
            btnVoid.TextAlignment = StringAlignment.Center;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDate.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(92, 102, 114);
            lblDate.Location = new Point(3, 8);
            lblDate.Margin = new Padding(3, 3, 0, 3);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(375, 23);
            lblDate.TabIndex = 42;
            lblDate.Text = "Date";
            // 
            // lstDrugs
            // 
            lstDrugs.Dock = DockStyle.Fill;
            lstDrugs.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lstDrugs.ForeColor = Color.FromArgb(92, 102, 114);
            lstDrugs.FormattingEnabled = true;
            lstDrugs.Location = new Point(3, 46);
            lstDrugs.Margin = new Padding(3, 6, 3, 3);
            lstDrugs.Name = "lstDrugs";
            tableLayoutPanel4.SetRowSpan(lstDrugs, 6);
            lstDrugs.Size = new Size(372, 261);
            lstDrugs.TabIndex = 51;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label12, 0, 0);
            tableLayoutPanel7.Controls.Add(label9, 0, 1);
            tableLayoutPanel7.Controls.Add(txtMedication, 1, 1);
            tableLayoutPanel7.Controls.Add(txtDosage, 1, 2);
            tableLayoutPanel7.Controls.Add(label13, 0, 2);
            tableLayoutPanel7.Controls.Add(label14, 0, 5);
            tableLayoutPanel7.Controls.Add(label11, 0, 4);
            tableLayoutPanel7.Controls.Add(txtDuration, 1, 4);
            tableLayoutPanel7.Controls.Add(txtFrequency, 1, 3);
            tableLayoutPanel7.Controls.Add(label4, 0, 3);
            tableLayoutPanel7.Controls.Add(txtInstructions, 1, 5);
            tableLayoutPanel7.Controls.Add(btnSave, 1, 7);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(10, 10);
            tableLayoutPanel7.Margin = new Padding(10);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 9;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(378, 455);
            tableLayoutPanel7.TabIndex = 1;
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
            label12.Size = new Size(375, 21);
            label12.TabIndex = 38;
            label12.Text = "Prescription";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(92, 102, 114);
            label9.Location = new Point(3, 52);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(99, 21);
            label9.TabIndex = 30;
            label9.Text = "Medication:";
            // 
            // txtMedication
            // 
            txtMedication.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMedication.BackColor = Color.FromArgb(197, 202, 212);
            txtMedication.BaseColor = Color.FromArgb(37, 45, 56);
            txtMedication.BorderColorA = Color.FromArgb(108, 111, 127);
            txtMedication.BorderColorB = Color.FromArgb(108, 111, 127);
            txtMedication.Cursor = Cursors.IBeam;
            txtMedication.Font = new Font("TT Interphases Pro Trl", 10F);
            txtMedication.ForeColor = Color.FromArgb(26, 35, 48);
            txtMedication.Hint = "ex: Losartan";
            txtMedication.Location = new Point(108, 44);
            txtMedication.MaxLength = 1000;
            txtMedication.Multiline = false;
            txtMedication.Name = "txtMedication";
            txtMedication.PasswordChar = '\0';
            txtMedication.ScrollBars = ScrollBars.None;
            txtMedication.SelectedText = "";
            txtMedication.SelectionLength = 0;
            txtMedication.SelectionStart = 0;
            txtMedication.Size = new Size(267, 37);
            txtMedication.TabIndex = 34;
            txtMedication.TabStop = false;
            txtMedication.UseSystemPasswordChar = false;
            // 
            // txtDosage
            // 
            txtDosage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDosage.BackColor = Color.FromArgb(197, 202, 212);
            txtDosage.BaseColor = Color.FromArgb(37, 45, 56);
            txtDosage.BorderColorA = Color.FromArgb(108, 111, 127);
            txtDosage.BorderColorB = Color.FromArgb(108, 111, 127);
            txtDosage.Cursor = Cursors.IBeam;
            txtDosage.Font = new Font("TT Interphases Pro Trl", 10F);
            txtDosage.ForeColor = Color.FromArgb(26, 35, 48);
            txtDosage.Hint = "ex: 400mg";
            txtDosage.Location = new Point(108, 90);
            txtDosage.MaxLength = 1000;
            txtDosage.Multiline = false;
            txtDosage.Name = "txtDosage";
            txtDosage.PasswordChar = '\0';
            txtDosage.ScrollBars = ScrollBars.None;
            txtDosage.SelectedText = "";
            txtDosage.SelectionLength = 0;
            txtDosage.SelectionStart = 0;
            txtDosage.Size = new Size(267, 37);
            txtDosage.TabIndex = 40;
            txtDosage.TabStop = false;
            txtDosage.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(92, 102, 114);
            label13.Location = new Point(3, 98);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(99, 21);
            label13.TabIndex = 41;
            label13.Text = "Dosage:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(92, 102, 114);
            label14.Location = new Point(3, 235);
            label14.Margin = new Padding(3);
            label14.Name = "label14";
            label14.Size = new Size(99, 24);
            label14.TabIndex = 43;
            label14.Text = "Instructions:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(92, 102, 114);
            label11.Location = new Point(3, 190);
            label11.Margin = new Padding(3);
            label11.Name = "label11";
            label11.Size = new Size(99, 21);
            label11.TabIndex = 39;
            label11.Text = "Duration:";
            // 
            // txtDuration
            // 
            txtDuration.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDuration.BackColor = Color.FromArgb(197, 202, 212);
            txtDuration.BaseColor = Color.FromArgb(37, 45, 56);
            txtDuration.BorderColorA = Color.FromArgb(108, 111, 127);
            txtDuration.BorderColorB = Color.FromArgb(108, 111, 127);
            txtDuration.Cursor = Cursors.IBeam;
            txtDuration.Font = new Font("TT Interphases Pro Trl", 10F);
            txtDuration.ForeColor = Color.FromArgb(26, 35, 48);
            txtDuration.Hint = "ex: 30 days";
            txtDuration.Location = new Point(108, 182);
            txtDuration.MaxLength = 1000;
            txtDuration.Multiline = false;
            txtDuration.Name = "txtDuration";
            txtDuration.PasswordChar = '\0';
            txtDuration.ScrollBars = ScrollBars.None;
            txtDuration.SelectedText = "";
            txtDuration.SelectionLength = 0;
            txtDuration.SelectionStart = 0;
            txtDuration.Size = new Size(267, 37);
            txtDuration.TabIndex = 42;
            txtDuration.TabStop = false;
            txtDuration.UseSystemPasswordChar = false;
            // 
            // txtFrequency
            // 
            txtFrequency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFrequency.BackColor = Color.FromArgb(197, 202, 212);
            txtFrequency.BaseColor = Color.FromArgb(37, 45, 56);
            txtFrequency.BorderColorA = Color.FromArgb(108, 111, 127);
            txtFrequency.BorderColorB = Color.FromArgb(108, 111, 127);
            txtFrequency.Cursor = Cursors.IBeam;
            txtFrequency.Font = new Font("TT Interphases Pro Trl", 10F);
            txtFrequency.ForeColor = Color.FromArgb(26, 35, 48);
            txtFrequency.Hint = "ex: 3x a day";
            txtFrequency.Location = new Point(108, 136);
            txtFrequency.MaxLength = 1000;
            txtFrequency.Multiline = false;
            txtFrequency.Name = "txtFrequency";
            txtFrequency.PasswordChar = '\0';
            txtFrequency.ScrollBars = ScrollBars.None;
            txtFrequency.SelectedText = "";
            txtFrequency.SelectionLength = 0;
            txtFrequency.SelectionStart = 0;
            txtFrequency.Size = new Size(267, 37);
            txtFrequency.TabIndex = 44;
            txtFrequency.TabStop = false;
            txtFrequency.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(92, 102, 114);
            label4.Location = new Point(3, 144);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 46;
            label4.Text = "Frequency:";
            // 
            // txtInstructions
            // 
            txtInstructions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtInstructions.BackColor = Color.FromArgb(197, 202, 212);
            txtInstructions.BaseColor = Color.FromArgb(37, 45, 56);
            txtInstructions.BorderColorA = Color.FromArgb(108, 111, 127);
            txtInstructions.BorderColorB = Color.FromArgb(108, 111, 127);
            txtInstructions.Cursor = Cursors.IBeam;
            txtInstructions.Font = new Font("TT Interphases Pro Trl", 10F);
            txtInstructions.ForeColor = Color.FromArgb(26, 35, 48);
            txtInstructions.Hint = "";
            txtInstructions.Location = new Point(108, 230);
            txtInstructions.MaxLength = 1000;
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.PasswordChar = '\0';
            tableLayoutPanel7.SetRowSpan(txtInstructions, 2);
            txtInstructions.ScrollBars = ScrollBars.None;
            txtInstructions.SelectedText = "";
            txtInstructions.SelectionLength = 0;
            txtInstructions.SelectionStart = 0;
            txtInstructions.Size = new Size(267, 74);
            txtInstructions.TabIndex = 47;
            txtInstructions.TabStop = false;
            txtInstructions.UseSystemPasswordChar = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(37, 45, 56);
            btnSave.BorderColor = Color.FromArgb(108, 111, 127);
            btnSave.Cursor = Cursors.Hand;
            btnSave.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnSave.EnteredColor = Color.FromArgb(69, 85, 97);
            btnSave.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnSave.Image = null;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.InactiveColor = Color.FromArgb(92, 102, 114);
            btnSave.Location = new Point(275, 313);
            btnSave.Margin = new Padding(3, 0, 3, 0);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnSave.PressedColor = Color.FromArgb(108, 111, 127);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 48;
            btnSave.Text = "Add Drug";
            btnSave.TextAlignment = StringAlignment.Center;
            // 
            // pnlDiv
            // 
            pnlDiv.BackColor = Color.FromArgb(92, 102, 114);
            pnlDiv.Dock = DockStyle.Fill;
            pnlDiv.Location = new Point(398, 10);
            pnlDiv.Margin = new Padding(0, 10, 0, 10);
            pnlDiv.Name = "pnlDiv";
            pnlDiv.Size = new Size(3, 455);
            pnlDiv.TabIndex = 3;
            // 
            // PrescriptionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrescriptionControl";
            Size = new Size(839, 763);
            tblLayout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tblInfoIntro.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tblContent.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblDate;
        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Button btnPrint;
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
        private Label label10;
        private ReaLTaiizor.Controls.Button btnDone;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label12;
        private Label label9;
        private ReaLTaiizor.Controls.HopeTextBox txtMedication;
        private ReaLTaiizor.Controls.HopeTextBox txtDosage;
        private Label label13;
        private Label label14;
        private Label label11;
        private ReaLTaiizor.Controls.HopeTextBox txtDuration;
        private ReaLTaiizor.Controls.HopeTextBox txtFrequency;
        private Label label4;
        private ReaLTaiizor.Controls.HopeTextBox txtInstructions;
        private ReaLTaiizor.Controls.Button btnSave;
        private Panel pnlDiv;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.Button btnEdit;
        private ReaLTaiizor.Controls.Button btnVoid;
        private ListBox lstDrugs;
    }
}
