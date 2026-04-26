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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VitalsControl));
            tblLayout = new TableLayoutPanel();
            dgvHistory = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tblInfoIntro = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            nudHeight = new ReaLTaiizor.Controls.HopeTextBox();
            nudWeight = new ReaLTaiizor.Controls.HopeTextBox();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            nudTemp = new ReaLTaiizor.Controls.HopeTextBox();
            nudHR = new ReaLTaiizor.Controls.HopeTextBox();
            txtBP = new ReaLTaiizor.Controls.HopeTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tblHeader = new TableLayoutPanel();
            lblFullName = new Label();
            lblMeta = new Label();
            lblPatientName = new Label();
            label11 = new Label();
            cmbPatients = new ReaLTaiizor.Controls.HopeComboBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label10 = new Label();
            btnSave = new ReaLTaiizor.Controls.Button();
            btnBMI = new ReaLTaiizor.Controls.Button();
            pnlDiv = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label9 = new Label();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tblInfoIntro.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tblHeader.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvHistory, 0, 4);
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Controls.Add(tableLayoutPanel2, 0, 5);
            tblLayout.Controls.Add(tblInfoIntro, 0, 2);
            tblLayout.Controls.Add(tableLayoutPanel7, 0, 3);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 6;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 265F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.Size = new Size(798, 776);
            tblLayout.TabIndex = 6;
            // 
            // dgvHistory
            // 
            dgvHistory.BackgroundColor = Color.FromArgb(108, 111, 127);
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = DockStyle.Fill;
            dgvHistory.Location = new Point(23, 397);
            dgvHistory.Margin = new Padding(23, 4, 23, 4);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(752, 340);
            dgvHistory.TabIndex = 7;
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
            tableLayoutPanel1.Location = new Point(23, 31);
            tableLayoutPanel1.Margin = new Padding(23, 4, 23, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(752, 42);
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
            label1.Size = new Size(163, 31);
            label1.TabIndex = 1;
            label1.Text = "Patient Vitals";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 744);
            tableLayoutPanel2.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(758, 29);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // tblInfoIntro
            // 
            tblInfoIntro.BackColor = Color.FromArgb(37, 45, 56);
            tblInfoIntro.ColumnCount = 3;
            tblInfoIntro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfoIntro.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 3F));
            tblInfoIntro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfoIntro.Controls.Add(tableLayoutPanel4, 2, 0);
            tblInfoIntro.Controls.Add(tblHeader, 0, 0);
            tblInfoIntro.Controls.Add(pnlDiv, 1, 0);
            tblInfoIntro.Dock = DockStyle.Fill;
            tblInfoIntro.Location = new Point(20, 80);
            tblInfoIntro.Margin = new Padding(20, 3, 20, 3);
            tblInfoIntro.Name = "tblInfoIntro";
            tblInfoIntro.RowCount = 1;
            tblInfoIntro.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblInfoIntro.Size = new Size(758, 259);
            tblInfoIntro.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(390, 10);
            tableLayoutPanel4.Margin = new Padding(10);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 52.2613068F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 47.7386932F));
            tableLayoutPanel4.Size = new Size(358, 239);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(226, 230, 237);
            label6.Location = new Point(0, 9);
            label6.Margin = new Padding(0, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(355, 21);
            label6.TabIndex = 32;
            label6.Text = "Record Vitals";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(nudHeight, 1, 1);
            tableLayoutPanel5.Controls.Add(nudWeight, 0, 1);
            tableLayoutPanel5.Controls.Add(label7, 1, 0);
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Location = new Point(3, 147);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.8709679F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 66.1290359F));
            tableLayoutPanel5.Size = new Size(352, 76);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // nudHeight
            // 
            nudHeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudHeight.BackColor = Color.FromArgb(197, 202, 212);
            nudHeight.BaseColor = Color.FromArgb(37, 45, 56);
            nudHeight.BorderColorA = Color.FromArgb(108, 111, 127);
            nudHeight.BorderColorB = Color.FromArgb(108, 111, 127);
            nudHeight.Cursor = Cursors.IBeam;
            nudHeight.Font = new Font("TT Interphases Pro Trl", 10F);
            nudHeight.ForeColor = Color.FromArgb(26, 35, 48);
            nudHeight.Hint = "ex: 169";
            nudHeight.Location = new Point(179, 28);
            nudHeight.MaxLength = 100;
            nudHeight.Multiline = false;
            nudHeight.Name = "nudHeight";
            nudHeight.PasswordChar = '\0';
            nudHeight.ScrollBars = ScrollBars.None;
            nudHeight.SelectedText = "";
            nudHeight.SelectionLength = 0;
            nudHeight.SelectionStart = 0;
            nudHeight.Size = new Size(170, 37);
            nudHeight.TabIndex = 35;
            nudHeight.TabStop = false;
            nudHeight.UseSystemPasswordChar = false;
            // 
            // nudWeight
            // 
            nudWeight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudWeight.BackColor = Color.FromArgb(197, 202, 212);
            nudWeight.BaseColor = Color.FromArgb(37, 45, 56);
            nudWeight.BorderColorA = Color.FromArgb(108, 111, 127);
            nudWeight.BorderColorB = Color.FromArgb(108, 111, 127);
            nudWeight.Cursor = Cursors.IBeam;
            nudWeight.Font = new Font("TT Interphases Pro Trl", 10F);
            nudWeight.ForeColor = Color.FromArgb(26, 35, 48);
            nudWeight.Hint = "ex: 67";
            nudWeight.Location = new Point(3, 28);
            nudWeight.MaxLength = 100;
            nudWeight.Multiline = false;
            nudWeight.Name = "nudWeight";
            nudWeight.PasswordChar = '\0';
            nudWeight.ScrollBars = ScrollBars.None;
            nudWeight.SelectedText = "";
            nudWeight.SelectionLength = 0;
            nudWeight.SelectionStart = 0;
            nudWeight.Size = new Size(170, 37);
            nudWeight.TabIndex = 34;
            nudWeight.TabStop = false;
            nudWeight.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(92, 102, 114);
            label7.Location = new Point(176, 4);
            label7.Margin = new Padding(0, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(173, 21);
            label7.TabIndex = 32;
            label7.Text = "Height (cm):";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(92, 102, 114);
            label8.Location = new Point(0, 4);
            label8.Margin = new Padding(0, 0, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(173, 21);
            label8.TabIndex = 31;
            label8.Text = "Weight (kgs.):";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(nudTemp, 2, 1);
            tableLayoutPanel3.Controls.Add(nudHR, 1, 1);
            tableLayoutPanel3.Controls.Add(txtBP, 0, 1);
            tableLayoutPanel3.Controls.Add(label5, 2, 0);
            tableLayoutPanel3.Controls.Add(label4, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 43);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.8709679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.1290359F));
            tableLayoutPanel3.Size = new Size(352, 98);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // nudTemp
            // 
            nudTemp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudTemp.BackColor = Color.FromArgb(197, 202, 212);
            nudTemp.BaseColor = Color.FromArgb(37, 45, 56);
            nudTemp.BorderColorA = Color.FromArgb(108, 111, 127);
            nudTemp.BorderColorB = Color.FromArgb(108, 111, 127);
            nudTemp.Cursor = Cursors.IBeam;
            nudTemp.Font = new Font("TT Interphases Pro Trl", 10F);
            nudTemp.ForeColor = Color.FromArgb(26, 35, 48);
            nudTemp.Hint = "ex: 36.5";
            nudTemp.Location = new Point(237, 36);
            nudTemp.MaxLength = 100;
            nudTemp.Multiline = false;
            nudTemp.Name = "nudTemp";
            nudTemp.PasswordChar = '\0';
            nudTemp.ScrollBars = ScrollBars.None;
            nudTemp.SelectedText = "";
            nudTemp.SelectionLength = 0;
            nudTemp.SelectionStart = 0;
            nudTemp.Size = new Size(112, 37);
            nudTemp.TabIndex = 36;
            nudTemp.TabStop = false;
            nudTemp.UseSystemPasswordChar = false;
            // 
            // nudHR
            // 
            nudHR.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudHR.BackColor = Color.FromArgb(197, 202, 212);
            nudHR.BaseColor = Color.FromArgb(37, 45, 56);
            nudHR.BorderColorA = Color.FromArgb(108, 111, 127);
            nudHR.BorderColorB = Color.FromArgb(108, 111, 127);
            nudHR.Cursor = Cursors.IBeam;
            nudHR.Font = new Font("TT Interphases Pro Trl", 10F);
            nudHR.ForeColor = Color.FromArgb(26, 35, 48);
            nudHR.Hint = "ex: 90";
            nudHR.Location = new Point(120, 36);
            nudHR.MaxLength = 100;
            nudHR.Multiline = false;
            nudHR.Name = "nudHR";
            nudHR.PasswordChar = '\0';
            nudHR.ScrollBars = ScrollBars.None;
            nudHR.SelectedText = "";
            nudHR.SelectionLength = 0;
            nudHR.SelectionStart = 0;
            nudHR.Size = new Size(111, 37);
            nudHR.TabIndex = 35;
            nudHR.TabStop = false;
            nudHR.UseSystemPasswordChar = false;
            // 
            // txtBP
            // 
            txtBP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBP.BackColor = Color.FromArgb(197, 202, 212);
            txtBP.BaseColor = Color.FromArgb(37, 45, 56);
            txtBP.BorderColorA = Color.FromArgb(108, 111, 127);
            txtBP.BorderColorB = Color.FromArgb(108, 111, 127);
            txtBP.Cursor = Cursors.IBeam;
            txtBP.Font = new Font("TT Interphases Pro Trl", 10F);
            txtBP.ForeColor = Color.FromArgb(26, 35, 48);
            txtBP.Hint = "ex: 120/80";
            txtBP.Location = new Point(3, 36);
            txtBP.MaxLength = 100;
            txtBP.Multiline = false;
            txtBP.Name = "txtBP";
            txtBP.PasswordChar = '\0';
            txtBP.ScrollBars = ScrollBars.None;
            txtBP.SelectedText = "";
            txtBP.SelectionLength = 0;
            txtBP.SelectionStart = 0;
            txtBP.Size = new Size(111, 37);
            txtBP.TabIndex = 34;
            txtBP.TabStop = false;
            txtBP.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(92, 102, 114);
            label5.Location = new Point(234, 12);
            label5.Margin = new Padding(0, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 33;
            label5.Text = "Body Temp. (°C):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(92, 102, 114);
            label4.Location = new Point(117, 12);
            label4.Margin = new Padding(0, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 32;
            label4.Text = "Heart Rate (BPM):";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(92, 102, 114);
            label3.Location = new Point(0, 12);
            label3.Margin = new Padding(0, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 31;
            label3.Text = "Blood Pressure:";
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeader.Controls.Add(lblFullName, 1, 2);
            tblHeader.Controls.Add(lblMeta, 2, 3);
            tblHeader.Controls.Add(lblPatientName, 2, 2);
            tblHeader.Controls.Add(label11, 1, 0);
            tblHeader.Controls.Add(cmbPatients, 1, 1);
            tblHeader.Controls.Add(tableLayoutPanel8, 1, 4);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(10, 10);
            tblHeader.Margin = new Padding(10);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 5;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.Size = new Size(357, 239);
            tblHeader.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFullName.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(92, 102, 114);
            lblFullName.Location = new Point(5, 104);
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
            lblMeta.Location = new Point(98, 115);
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
            lblPatientName.Location = new Point(98, 94);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(124, 21);
            lblPatientName.TabIndex = 35;
            lblPatientName.Text = "None Selected";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblHeader.SetColumnSpan(label11, 2);
            label11.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(226, 230, 237);
            label11.Location = new Point(5, 9);
            label11.Margin = new Padding(0, 0, 3, 0);
            label11.Name = "label11";
            label11.Size = new Size(349, 21);
            label11.TabIndex = 38;
            label11.Text = "Patient";
            // 
            // cmbPatients
            // 
            cmbPatients.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblHeader.SetColumnSpan(cmbPatients, 2);
            cmbPatients.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatients.FlatStyle = FlatStyle.Flat;
            cmbPatients.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cmbPatients.ForeColor = Color.FromArgb(37, 45, 56);
            cmbPatients.FormattingEnabled = true;
            cmbPatients.ItemHeight = 30;
            cmbPatients.Location = new Point(8, 44);
            cmbPatients.Margin = new Padding(3, 3, 6, 3);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(343, 36);
            cmbPatients.TabIndex = 36;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 3;
            tblHeader.SetColumnSpan(tableLayoutPanel8, 2);
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
            tableLayoutPanel8.Controls.Add(label10, 0, 0);
            tableLayoutPanel8.Controls.Add(btnSave, 2, 0);
            tableLayoutPanel8.Controls.Add(btnBMI, 1, 0);
            tableLayoutPanel8.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel8.Location = new Point(5, 169);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(352, 46);
            tableLayoutPanel8.TabIndex = 26;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(92, 102, 114);
            label10.Location = new Point(0, 12);
            label10.Margin = new Padding(0, 0, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 43;
            label10.Text = "Auto BMI:";
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
            btnSave.Location = new Point(246, 3);
            btnSave.Margin = new Padding(3, 0, 6, 0);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnSave.PressedColor = Color.FromArgb(108, 111, 127);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.TextAlignment = StringAlignment.Center;
            // 
            // btnBMI
            // 
            btnBMI.Anchor = AnchorStyles.Left;
            btnBMI.BackColor = Color.Transparent;
            btnBMI.BorderColor = Color.Transparent;
            btnBMI.Enabled = false;
            btnBMI.EnteredBorderColor = Color.Transparent;
            btnBMI.EnteredColor = Color.Transparent;
            btnBMI.Font = new Font("TT Interphases Pro Trl Variable", 9F, FontStyle.Bold);
            btnBMI.Image = null;
            btnBMI.ImageAlign = ContentAlignment.MiddleLeft;
            btnBMI.InactiveColor = Color.Transparent;
            btnBMI.Location = new Point(94, 2);
            btnBMI.Margin = new Padding(3, 0, 0, 0);
            btnBMI.Name = "btnBMI";
            btnBMI.Padding = new Padding(23, 13, 11, 13);
            btnBMI.PressedBorderColor = Color.Transparent;
            btnBMI.PressedColor = Color.Transparent;
            btnBMI.RightToLeft = RightToLeft.Yes;
            btnBMI.Size = new Size(121, 41);
            btnBMI.TabIndex = 42;
            btnBMI.Text = "24.1 - Normal";
            btnBMI.TextAlignment = StringAlignment.Center;
            // 
            // pnlDiv
            // 
            pnlDiv.BackColor = Color.FromArgb(92, 102, 114);
            pnlDiv.Dock = DockStyle.Fill;
            pnlDiv.Location = new Point(377, 10);
            pnlDiv.Margin = new Padding(0, 10, 0, 10);
            pnlDiv.Name = "pnlDiv";
            pnlDiv.Size = new Size(3, 239);
            pnlDiv.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(label9, 0, 0);
            tableLayoutPanel7.Location = new Point(20, 346);
            tableLayoutPanel7.Margin = new Padding(20, 4, 23, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(752, 42);
            tableLayoutPanel7.TabIndex = 24;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Panton-Trial ExtraBold", 12F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(26, 35, 48);
            label9.Location = new Point(3, 8);
            label9.Name = "label9";
            label9.Size = new Size(202, 25);
            label9.TabIndex = 1;
            label9.Text = "Previous Recordings:";
            // 
            // VitalsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VitalsControl";
            Size = new Size(798, 776);
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tblInfoIntro.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private TableLayoutPanel tblLayout;
        private DataGridView dgvHistory;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tblInfoIntro;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel5;
        private ReaLTaiizor.Controls.HopeTextBox nudHeight;
        private ReaLTaiizor.Controls.HopeTextBox nudWeight;
        private Label label7;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.HopeTextBox nudTemp;
        private ReaLTaiizor.Controls.HopeTextBox nudHR;
        private ReaLTaiizor.Controls.HopeTextBox txtBP;
        private Label label5;
        private Label label4;
        private Label label3;
        private TableLayoutPanel tblHeader;
        private Label lblFullName;
        private Label lblMeta;
        private Label lblPatientName;
        private Label label11;
        private ReaLTaiizor.Controls.HopeComboBox cmbPatients;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label10;
        private ReaLTaiizor.Controls.Button btnSave;
        protected internal ReaLTaiizor.Controls.Button btnBMI;
        private Panel pnlDiv;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label9;
    }
}
