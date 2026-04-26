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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationControl));
            tblLayout = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnPrint = new ReaLTaiizor.Controls.Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tblInfoIntro = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            lblFullName = new Label();
            panel2 = new Panel();
            lblAllergy = new Label();
            label11 = new Label();
            panel1 = new Panel();
            lblMeta = new Label();
            lblPatientName = new Label();
            cmbPatients = new ReaLTaiizor.Controls.HopeComboBox();
            label2 = new Label();
            lblVtl = new Label();
            lblVitals = new Label();
            tblContent = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtFamHx = new ReaLTaiizor.Controls.HopeTextBox();
            txtSurgeries = new ReaLTaiizor.Controls.HopeTextBox();
            label7 = new Label();
            txtConditions = new ReaLTaiizor.Controls.HopeTextBox();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtCurrentMeds = new ReaLTaiizor.Controls.HopeTextBox();
            tblFooter = new TableLayoutPanel();
            btnVoidRx = new ReaLTaiizor.Controls.Button();
            btnSave = new ReaLTaiizor.Controls.Button();
            btnAddRx = new ReaLTaiizor.Controls.Button();
            lblAllergies = new Label();
            label4 = new Label();
            label5 = new Label();
            label12 = new Label();
            tblLayout.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tblInfoIntro.SuspendLayout();
            tblHeader.SuspendLayout();
            panel2.SuspendLayout();
            tblContent.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tblFooter.SuspendLayout();
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
            tblLayout.Controls.Add(tblFooter, 0, 4);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 5;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 201F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tblLayout.Size = new Size(842, 704);
            tblLayout.TabIndex = 5;
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
            tableLayoutPanel1.Location = new Point(20, 24);
            tableLayoutPanel1.Margin = new Padding(20, 4, 20, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(802, 41);
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
            btnPrint.Location = new Point(702, 0);
            btnPrint.Margin = new Padding(3, 0, 0, 0);
            btnPrint.Name = "btnPrint";
            btnPrint.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.PressedColor = Color.FromArgb(108, 111, 127);
            btnPrint.Size = new Size(100, 40);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "Print";
            btnPrint.TextAlignment = StringAlignment.Center;
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 41);
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
            label1.Size = new Size(242, 31);
            label1.TabIndex = 1;
            label1.Text = "Patient Consultation";
            // 
            // tblInfoIntro
            // 
            tblInfoIntro.BackColor = Color.FromArgb(37, 45, 56);
            tblInfoIntro.ColumnCount = 1;
            tblInfoIntro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblInfoIntro.Controls.Add(tblHeader, 0, 0);
            tblInfoIntro.Dock = DockStyle.Fill;
            tblInfoIntro.Location = new Point(20, 72);
            tblInfoIntro.Margin = new Padding(20, 3, 20, 3);
            tblInfoIntro.Name = "tblInfoIntro";
            tblInfoIntro.RowCount = 1;
            tblInfoIntro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblInfoIntro.Size = new Size(802, 195);
            tblInfoIntro.TabIndex = 22;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 3;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblHeader.Controls.Add(lblFullName, 1, 1);
            tblHeader.Controls.Add(panel2, 1, 4);
            tblHeader.Controls.Add(panel1, 0, 4);
            tblHeader.Controls.Add(lblMeta, 2, 2);
            tblHeader.Controls.Add(lblPatientName, 2, 1);
            tblHeader.Controls.Add(cmbPatients, 2, 0);
            tblHeader.Controls.Add(label2, 1, 0);
            tblHeader.Controls.Add(lblVtl, 1, 3);
            tblHeader.Controls.Add(lblVitals, 2, 3);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(10, 10);
            tblHeader.Margin = new Padding(10);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 6;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.Size = new Size(782, 175);
            tblHeader.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFullName.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(92, 102, 114);
            lblFullName.Location = new Point(5, 64);
            lblFullName.Margin = new Padding(0, 3, 3, 3);
            lblFullName.Name = "lblFullName";
            tblHeader.SetRowSpan(lblFullName, 2);
            lblFullName.Size = new Size(87, 21);
            lblFullName.TabIndex = 30;
            lblFullName.Text = "Full Name:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(244, 203, 195);
            tblHeader.SetColumnSpan(panel2, 2);
            panel2.Controls.Add(lblAllergy);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(5, 143);
            panel2.Margin = new Padding(0, 3, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 24);
            panel2.TabIndex = 22;
            // 
            // lblAllergy
            // 
            lblAllergy.Anchor = AnchorStyles.Left;
            lblAllergy.AutoSize = true;
            lblAllergy.Font = new Font("Panton Narrow-Trial SemiBold", 9F);
            lblAllergy.ForeColor = Color.FromArgb(153, 27, 27);
            lblAllergy.Location = new Point(93, 3);
            lblAllergy.Name = "lblAllergy";
            lblAllergy.Size = new Size(43, 19);
            lblAllergy.TabIndex = 39;
            lblAllergy.Text = "None";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(153, 27, 27);
            label11.Location = new Point(3, 1);
            label11.Margin = new Padding(3);
            label11.Name = "label11";
            label11.Size = new Size(84, 21);
            label11.TabIndex = 39;
            label11.Text = "Allergies:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(153, 27, 27);
            panel1.Location = new Point(0, 140);
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
            // cmbPatients
            // 
            cmbPatients.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbPatients.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatients.FlatStyle = FlatStyle.Flat;
            cmbPatients.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            cmbPatients.ForeColor = Color.FromArgb(37, 45, 56);
            cmbPatients.FormattingEnabled = true;
            cmbPatients.ItemHeight = 30;
            cmbPatients.Location = new Point(98, 4);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(681, 36);
            cmbPatients.TabIndex = 36;
            cmbPatients.SelectedIndexChanged += cmbPatients_SelectedIndexChanged;
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
            label2.Text = "Patient:";
            // 
            // lblVtl
            // 
            lblVtl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblVtl.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblVtl.ForeColor = Color.FromArgb(92, 102, 114);
            lblVtl.Location = new Point(5, 109);
            lblVtl.Margin = new Padding(0, 3, 3, 3);
            lblVtl.Name = "lblVtl";
            lblVtl.Size = new Size(87, 21);
            lblVtl.TabIndex = 38;
            lblVtl.Text = "Vitals:";
            // 
            // lblVitals
            // 
            lblVitals.Anchor = AnchorStyles.Left;
            lblVitals.AutoSize = true;
            lblVitals.Font = new Font("TT Interphases Pro Trl Variable", 9F);
            lblVitals.ForeColor = Color.FromArgb(92, 102, 114);
            lblVitals.Location = new Point(98, 110);
            lblVitals.Name = "lblVitals";
            lblVitals.Size = new Size(88, 19);
            lblVitals.TabIndex = 39;
            lblVitals.Text = "No Records";
            // 
            // tblContent
            // 
            tblContent.BackColor = Color.FromArgb(37, 45, 56);
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblContent.Controls.Add(tableLayoutPanel4, 0, 0);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(20, 277);
            tblContent.Margin = new Padding(20, 7, 20, 3);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 1;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblContent.Size = new Size(802, 366);
            tblContent.TabIndex = 27;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(txtFamHx, 1, 3);
            tableLayoutPanel4.Controls.Add(txtSurgeries, 1, 2);
            tableLayoutPanel4.Controls.Add(label7, 0, 2);
            tableLayoutPanel4.Controls.Add(txtConditions, 1, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(label8, 0, 3);
            tableLayoutPanel4.Controls.Add(label10, 0, 4);
            tableLayoutPanel4.Controls.Add(txtCurrentMeds, 1, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(10, 10);
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
            tableLayoutPanel4.Size = new Size(782, 346);
            tableLayoutPanel4.TabIndex = 2;
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
            txtFamHx.Hint = "";
            txtFamHx.Location = new Point(166, 136);
            txtFamHx.MaxLength = 100;
            txtFamHx.Multiline = false;
            txtFamHx.Name = "txtFamHx";
            txtFamHx.PasswordChar = '\0';
            txtFamHx.ScrollBars = ScrollBars.None;
            txtFamHx.SelectedText = "";
            txtFamHx.SelectionLength = 0;
            txtFamHx.SelectionStart = 0;
            txtFamHx.Size = new Size(613, 37);
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
            txtSurgeries.Hint = "";
            txtSurgeries.Location = new Point(166, 90);
            txtSurgeries.MaxLength = 100;
            txtSurgeries.Multiline = false;
            txtSurgeries.Name = "txtSurgeries";
            txtSurgeries.PasswordChar = '\0';
            txtSurgeries.ScrollBars = ScrollBars.None;
            txtSurgeries.SelectedText = "";
            txtSurgeries.SelectionLength = 0;
            txtSurgeries.SelectionStart = 0;
            txtSurgeries.Size = new Size(613, 37);
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
            label7.Size = new Size(157, 21);
            label7.TabIndex = 36;
            label7.Text = "Findings:";
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
            txtConditions.Hint = "";
            txtConditions.Location = new Point(166, 44);
            txtConditions.MaxLength = 100;
            txtConditions.Multiline = false;
            txtConditions.Name = "txtConditions";
            txtConditions.PasswordChar = '\0';
            txtConditions.ScrollBars = ScrollBars.None;
            txtConditions.SelectedText = "";
            txtConditions.SelectionLength = 0;
            txtConditions.SelectionStart = 0;
            txtConditions.Size = new Size(613, 37);
            txtConditions.TabIndex = 35;
            txtConditions.TabStop = false;
            txtConditions.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(92, 102, 114);
            label3.Location = new Point(3, 52);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(157, 21);
            label3.TabIndex = 33;
            label3.Text = "Chief Complaint:";
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
            label6.Size = new Size(779, 21);
            label6.TabIndex = 32;
            label6.Text = "Consultation Details";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(92, 102, 114);
            label8.Location = new Point(3, 142);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            label8.Size = new Size(157, 25);
            label8.TabIndex = 37;
            label8.Text = "Diagnosis:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(92, 102, 114);
            label10.Location = new Point(3, 189);
            label10.Margin = new Padding(3, 3, 0, 3);
            label10.Name = "label10";
            label10.Size = new Size(160, 24);
            label10.TabIndex = 40;
            label10.Text = "Notes:";
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
            txtCurrentMeds.Hint = "";
            txtCurrentMeds.Location = new Point(166, 182);
            txtCurrentMeds.MaxLength = 100;
            txtCurrentMeds.Multiline = false;
            txtCurrentMeds.Name = "txtCurrentMeds";
            txtCurrentMeds.PasswordChar = '\0';
            txtCurrentMeds.ScrollBars = ScrollBars.None;
            txtCurrentMeds.SelectedText = "";
            txtCurrentMeds.SelectionLength = 0;
            txtCurrentMeds.SelectionStart = 0;
            txtCurrentMeds.Size = new Size(613, 37);
            txtCurrentMeds.TabIndex = 41;
            txtCurrentMeds.TabStop = false;
            txtCurrentMeds.UseSystemPasswordChar = false;
            // 
            // tblFooter
            // 
            tblFooter.ColumnCount = 3;
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 104F));
            tblFooter.Controls.Add(btnVoidRx, 0, 0);
            tblFooter.Controls.Add(btnSave, 2, 0);
            tblFooter.Controls.Add(btnAddRx, 1, 0);
            tblFooter.Dock = DockStyle.Fill;
            tblFooter.Location = new Point(20, 650);
            tblFooter.Margin = new Padding(20, 4, 20, 4);
            tblFooter.Name = "tblFooter";
            tblFooter.RowCount = 1;
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFooter.Size = new Size(802, 50);
            tblFooter.TabIndex = 29;
            // 
            // btnVoidRx
            // 
            btnVoidRx.BackColor = Color.FromArgb(226, 230, 237);
            btnVoidRx.BorderColor = Color.FromArgb(108, 111, 127);
            btnVoidRx.Cursor = Cursors.Hand;
            btnVoidRx.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnVoidRx.EnteredColor = Color.FromArgb(69, 85, 97);
            btnVoidRx.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnVoidRx.Image = null;
            btnVoidRx.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoidRx.InactiveColor = Color.FromArgb(92, 102, 114);
            btnVoidRx.Location = new Point(0, 3);
            btnVoidRx.Margin = new Padding(0, 3, 3, 0);
            btnVoidRx.Name = "btnVoidRx";
            btnVoidRx.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnVoidRx.PressedColor = Color.FromArgb(108, 111, 127);
            btnVoidRx.Size = new Size(100, 40);
            btnVoidRx.TabIndex = 29;
            btnVoidRx.Text = "Void";
            btnVoidRx.TextAlignment = StringAlignment.Center;
            btnVoidRx.Click += BtnVoidConsultation_Click;
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
            btnSave.Location = new Point(702, 3);
            btnSave.Margin = new Padding(3, 3, 0, 0);
            btnSave.Name = "btnSave";
            btnSave.PressedBorderColor = Color.FromArgb(26, 35, 48);
            btnSave.PressedColor = Color.FromArgb(26, 35, 48);
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.TextAlignment = StringAlignment.Center;
            btnSave.Click += btnSave_Click;
            // 
            // btnAddRx
            // 
            btnAddRx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRx.BackColor = Color.FromArgb(226, 230, 237);
            btnAddRx.BorderColor = Color.FromArgb(108, 111, 127);
            btnAddRx.Cursor = Cursors.Hand;
            btnAddRx.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnAddRx.EnteredColor = Color.FromArgb(69, 85, 97);
            btnAddRx.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnAddRx.Image = null;
            btnAddRx.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRx.InactiveColor = Color.FromArgb(92, 102, 114);
            btnAddRx.Location = new Point(595, 3);
            btnAddRx.Margin = new Padding(3, 3, 3, 0);
            btnAddRx.Name = "btnAddRx";
            btnAddRx.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnAddRx.PressedColor = Color.FromArgb(108, 111, 127);
            btnAddRx.Size = new Size(100, 40);
            btnAddRx.TabIndex = 22;
            btnAddRx.Text = "Add Rx";
            btnAddRx.TextAlignment = StringAlignment.Center;
            btnAddRx.Click += btnAddRx_Click;
            // 
            // lblAllergies
            // 
            lblAllergies.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblAllergies.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblAllergies.ForeColor = Color.FromArgb(153, 27, 27);
            lblAllergies.Location = new Point(3, -38);
            lblAllergies.Margin = new Padding(3);
            lblAllergies.Name = "lblAllergies";
            lblAllergies.Size = new Size(658, 22);
            lblAllergies.TabIndex = 38;
            lblAllergies.Text = "Allergies:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("TT Interphases Pro Trl Variable", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(153, 27, 27);
            label4.Location = new Point(93, -113);
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
            label5.Location = new Point(3, -113);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(84, 22);
            label5.TabIndex = 36;
            label5.Text = "Allergies:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Panton Narrow-Trial SemiBold", 9F);
            label12.ForeColor = Color.FromArgb(153, 27, 27);
            label12.Location = new Point(93, 3);
            label12.Name = "label12";
            label12.Size = new Size(43, 19);
            label12.TabIndex = 41;
            label12.Text = "None";
            // 
            // ConsultationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultationControl";
            Size = new Size(842, 704);
            tblLayout.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tblInfoIntro.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tblContent.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tblFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Button btnPrint;
        private PictureBox pictureBox3;
        private Label label1;
        private TableLayoutPanel tblInfoIntro;
        private TableLayoutPanel tblHeader;
        private Label label9;
        private Label lblFullName;
        private Panel panel2;
        private Label lblAllergy;
        private Label lblAllergies;
        private Label label5;
        private Panel panel1;
        private Label lblMeta;
        private Label lblPatientName;
        private ReaLTaiizor.Controls.HopeComboBox cmbPatients;
        private Label label2;
        private Label lblVtl;
        private Label lblVitals;
        private TableLayoutPanel tblContent;
        private TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.HopeTextBox txtFamHx;
        private ReaLTaiizor.Controls.HopeTextBox txtSurgeries;
        private Label label7;
        private ReaLTaiizor.Controls.HopeTextBox txtConditions;
        private Label label3;
        private Label label6;
        private Label label8;
        private Label label10;
        private ReaLTaiizor.Controls.HopeTextBox txtCurrentMeds;
        private TableLayoutPanel tblFooter;
        private ReaLTaiizor.Controls.Button btnSave;
        private ReaLTaiizor.Controls.Button btnAddRx;
        private Label label11;
        private Label label12;
        private ReaLTaiizor.Controls.Button btnVoidRx;
    }
}
