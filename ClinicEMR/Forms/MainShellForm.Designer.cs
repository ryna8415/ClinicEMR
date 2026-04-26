namespace ClinicEMR.Forms
{
    partial class MainShellForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainShellForm));
            pnlContentbg = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pnlContent = new TableLayoutPanel();
            panel2 = new Panel();
            lblDate = new Label();
            lblTime = new Label();
            btnHeader = new Label();
            btnBMI = new ReaLTaiizor.Controls.Button();
            lblIntro = new Label();
            Header = new ReaLTaiizor.Controls.Button();
            tblBackground = new TableLayoutPanel();
            pnlSidebar = new TableLayoutPanel();
            pnlSide = new Panel();
            tblFooter = new TableLayoutPanel();
            button2 = new ReaLTaiizor.Controls.Button();
            lblUserRole = new Label();
            lblUserName = new Label();
            btnLogout = new Button();
            button3 = new ReaLTaiizor.Controls.Button();
            btnUsers = new Button();
            btnReports = new Button();
            btnMedHistory = new Button();
            btnRx = new Button();
            btnConsult = new Button();
            btnVitals = new Button();
            btnAppts = new Button();
            btnPatients = new Button();
            btnDashboard = new Button();
            button1 = new ReaLTaiizor.Controls.Button();
            lblAppName = new Label();
            pictureBox1 = new PictureBox();
            pnlContentbg.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tblBackground.SuspendLayout();
            pnlSidebar.SuspendLayout();
            tblFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlContentbg
            // 
            pnlContentbg.BackColor = Color.FromArgb(49, 62, 80);
            pnlContentbg.Controls.Add(tableLayoutPanel1);
            pnlContentbg.Dock = DockStyle.Fill;
            pnlContentbg.Location = new Point(224, 27);
            pnlContentbg.Margin = new Padding(0);
            pnlContentbg.Name = "pnlContentbg";
            pnlContentbg.Size = new Size(934, 899);
            pnlContentbg.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlContent, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(934, 899);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 62, 80);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 70);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 10);
            panel1.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(226, 230, 237);
            pnlContent.ColumnCount = 1;
            pnlContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 80);
            pnlContent.Margin = new Padding(0);
            pnlContent.MinimumSize = new Size(298, 81);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(5, 0, 0, 0);
            pnlContent.RowCount = 1;
            pnlContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlContent.Size = new Size(934, 819);
            pnlContent.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 62, 80);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(lblTime);
            panel2.Controls.Add(btnHeader);
            panel2.Controls.Add(btnBMI);
            panel2.Controls.Add(lblIntro);
            panel2.Controls.Add(Header);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 70);
            panel2.TabIndex = 2;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.BackColor = Color.FromArgb(37, 45, 56);
            lblDate.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(92, 102, 114);
            lblDate.Location = new Point(461, 39);
            lblDate.Margin = new Padding(0, 0, 3, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(368, 21);
            lblDate.TabIndex = 45;
            lblDate.Text = "Sunday, April 26, 2026";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTime.BackColor = Color.FromArgb(37, 45, 56);
            lblTime.Font = new Font("TT Intrphss Pr Trl Cnd", 11F, FontStyle.Bold);
            lblTime.ForeColor = Color.FromArgb(92, 102, 114);
            lblTime.Location = new Point(461, 12);
            lblTime.Margin = new Padding(0, 0, 3, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(183, 26);
            lblTime.TabIndex = 44;
            lblTime.Text = "HH:MM:SS";
            // 
            // btnHeader
            // 
            btnHeader.Anchor = AnchorStyles.Left;
            btnHeader.BackColor = Color.FromArgb(37, 45, 56);
            btnHeader.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            btnHeader.ForeColor = Color.FromArgb(226, 230, 237);
            btnHeader.Location = new Point(9, 7);
            btnHeader.Name = "btnHeader";
            btnHeader.Size = new Size(326, 31);
            btnHeader.TabIndex = 2;
            btnHeader.Text = "Hello! Dr. Ryan Kurt";
            // 
            // btnBMI
            // 
            btnBMI.Anchor = AnchorStyles.Right;
            btnBMI.BackColor = Color.FromArgb(37, 45, 56);
            btnBMI.BorderColor = Color.FromArgb(91, 33, 182);
            btnBMI.Enabled = false;
            btnBMI.EnteredBorderColor = Color.Transparent;
            btnBMI.EnteredColor = Color.Transparent;
            btnBMI.Font = new Font("TT Interphases Pro Trl Variable", 9F, FontStyle.Bold);
            btnBMI.Image = null;
            btnBMI.ImageAlign = ContentAlignment.MiddleLeft;
            btnBMI.InactiveColor = Color.FromArgb(217, 189, 240);
            btnBMI.Location = new Point(838, 20);
            btnBMI.Margin = new Padding(3, 0, 0, 0);
            btnBMI.Name = "btnBMI";
            btnBMI.Padding = new Padding(23, 13, 11, 13);
            btnBMI.PressedBorderColor = Color.Transparent;
            btnBMI.PressedColor = Color.Transparent;
            btnBMI.RightToLeft = RightToLeft.Yes;
            btnBMI.Size = new Size(80, 32);
            btnBMI.TabIndex = 43;
            btnBMI.Text = "Nurse";
            btnBMI.TextAlignment = StringAlignment.Center;
            // 
            // lblIntro
            // 
            lblIntro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIntro.BackColor = Color.FromArgb(37, 45, 56);
            lblIntro.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            lblIntro.ForeColor = Color.FromArgb(92, 102, 114);
            lblIntro.Location = new Point(11, 40);
            lblIntro.Margin = new Padding(0, 0, 3, 0);
            lblIntro.Name = "lblIntro";
            lblIntro.Size = new Size(503, 21);
            lblIntro.TabIndex = 32;
            lblIntro.Text = "Sunday, April 26, 2026";
            // 
            // Header
            // 
            Header.BackColor = Color.Transparent;
            Header.BorderColor = Color.Transparent;
            Header.Dock = DockStyle.Fill;
            Header.Enabled = false;
            Header.EnteredBorderColor = Color.Transparent;
            Header.EnteredColor = Color.Transparent;
            Header.Font = new Font("Panton-Trial Thin", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header.Image = null;
            Header.ImageAlign = ContentAlignment.MiddleLeft;
            Header.InactiveColor = Color.FromArgb(37, 45, 56);
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(0);
            Header.Name = "Header";
            Header.Padding = new Padding(23, 13, 11, 13);
            Header.PressedBorderColor = Color.Transparent;
            Header.PressedColor = Color.Transparent;
            Header.RightToLeft = RightToLeft.Yes;
            Header.Size = new Size(934, 70);
            Header.TabIndex = 1;
            Header.TextAlignment = StringAlignment.Near;
            // 
            // tblBackground
            // 
            tblBackground.BackColor = Color.FromArgb(49, 62, 80);
            tblBackground.ColumnCount = 3;
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.37618F));
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.62382F));
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tblBackground.Controls.Add(pnlSidebar, 0, 0);
            tblBackground.Controls.Add(pnlContentbg, 1, 1);
            tblBackground.Dock = DockStyle.Fill;
            tblBackground.Location = new Point(0, 0);
            tblBackground.Margin = new Padding(0, 4, 3, 4);
            tblBackground.Name = "tblBackground";
            tblBackground.RowCount = 3;
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblBackground.Size = new Size(1182, 953);
            tblBackground.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Transparent;
            pnlSidebar.ColumnCount = 3;
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 6F));
            pnlSidebar.Controls.Add(pnlSide, 2, 4);
            pnlSidebar.Controls.Add(tblFooter, 0, 13);
            pnlSidebar.Controls.Add(btnUsers, 0, 12);
            pnlSidebar.Controls.Add(btnReports, 0, 11);
            pnlSidebar.Controls.Add(btnMedHistory, 0, 10);
            pnlSidebar.Controls.Add(btnRx, 0, 9);
            pnlSidebar.Controls.Add(btnConsult, 0, 8);
            pnlSidebar.Controls.Add(btnVitals, 0, 7);
            pnlSidebar.Controls.Add(btnAppts, 0, 6);
            pnlSidebar.Controls.Add(btnPatients, 0, 5);
            pnlSidebar.Controls.Add(btnDashboard, 0, 4);
            pnlSidebar.Controls.Add(button1, 0, 2);
            pnlSidebar.Controls.Add(lblAppName, 0, 1);
            pnlSidebar.Controls.Add(pictureBox1, 0, 0);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(0, 17);
            pnlSidebar.Margin = new Padding(0, 17, 0, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(10, 8, 0, 8);
            pnlSidebar.RowCount = 14;
            tblBackground.SetRowSpan(pnlSidebar, 2);
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 141F));
            pnlSidebar.Size = new Size(224, 906);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(92, 143, 204);
            pnlSide.Dock = DockStyle.Fill;
            pnlSide.ForeColor = Color.LightGray;
            pnlSide.Location = new Point(218, 153);
            pnlSide.Margin = new Padding(0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(6, 56);
            pnlSide.TabIndex = 12;
            // 
            // tblFooter
            // 
            tblFooter.ColumnCount = 1;
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFooter.Controls.Add(button2, 0, 0);
            tblFooter.Controls.Add(lblUserRole, 0, 3);
            tblFooter.Controls.Add(lblUserName, 0, 2);
            tblFooter.Controls.Add(btnLogout, 0, 6);
            tblFooter.Controls.Add(button3, 0, 5);
            tblFooter.Dock = DockStyle.Bottom;
            tblFooter.Location = new Point(13, 761);
            tblFooter.Margin = new Padding(3, 4, 0, 4);
            tblFooter.Name = "tblFooter";
            tblFooter.RowCount = 7;
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 3F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFooter.Size = new Size(196, 133);
            tblFooter.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.Transparent;
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.EnteredBorderColor = Color.Transparent;
            button2.EnteredColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.InactiveColor = Color.FromArgb(108, 111, 127);
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(11, 13, 11, 133);
            button2.PressedBorderColor = Color.Transparent;
            button2.PressedColor = Color.Transparent;
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(196, 3);
            button2.TabIndex = 14;
            button2.TextAlignment = StringAlignment.Near;
            // 
            // lblUserRole
            // 
            lblUserRole.Anchor = AnchorStyles.Top;
            lblUserRole.AutoSize = true;
            lblUserRole.ForeColor = Color.Black;
            lblUserRole.Location = new Point(98, 37);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(0, 20);
            lblUserRole.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(98, 10);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 21);
            lblUserName.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 85);
            btnLogout.Margin = new Padding(0, 3, 0, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(5, 0, 0, 0);
            btnLogout.Size = new Size(196, 45);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "    Log Out";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BorderColor = Color.Transparent;
            button3.Dock = DockStyle.Fill;
            button3.Enabled = false;
            button3.EnteredBorderColor = Color.Transparent;
            button3.EnteredColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = null;
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.InactiveColor = Color.FromArgb(108, 111, 127);
            button3.Location = new Point(0, 71);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(11, 13, 11, 133);
            button3.PressedBorderColor = Color.Transparent;
            button3.PressedColor = Color.Transparent;
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(196, 3);
            button3.TabIndex = 15;
            button3.TextAlignment = StringAlignment.Near;
            // 
            // btnUsers
            // 
            pnlSidebar.SetColumnSpan(btnUsers, 2);
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.Dock = DockStyle.Fill;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnUsers.ForeColor = Color.White;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(10, 593);
            btnUsers.Margin = new Padding(0, 6, 0, 6);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(10, 0, 0, 0);
            btnUsers.Size = new Size(208, 42);
            btnUsers.TabIndex = 10;
            btnUsers.Text = "    Users";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            pnlSidebar.SetColumnSpan(btnReports, 2);
            btnReports.Cursor = Cursors.Hand;
            btnReports.Dock = DockStyle.Fill;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(10, 539);
            btnReports.Margin = new Padding(0, 6, 0, 6);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(10, 0, 0, 0);
            btnReports.Size = new Size(208, 42);
            btnReports.TabIndex = 9;
            btnReports.Text = "    Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnMedHistory
            // 
            pnlSidebar.SetColumnSpan(btnMedHistory, 2);
            btnMedHistory.Cursor = Cursors.Hand;
            btnMedHistory.Dock = DockStyle.Fill;
            btnMedHistory.FlatAppearance.BorderSize = 0;
            btnMedHistory.FlatStyle = FlatStyle.Flat;
            btnMedHistory.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnMedHistory.ForeColor = Color.White;
            btnMedHistory.Image = (Image)resources.GetObject("btnMedHistory.Image");
            btnMedHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnMedHistory.Location = new Point(10, 485);
            btnMedHistory.Margin = new Padding(0, 6, 0, 6);
            btnMedHistory.Name = "btnMedHistory";
            btnMedHistory.Padding = new Padding(10, 0, 0, 0);
            btnMedHistory.Size = new Size(208, 42);
            btnMedHistory.TabIndex = 8;
            btnMedHistory.Text = "    Clinical Hx";
            btnMedHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMedHistory.UseVisualStyleBackColor = true;
            // 
            // btnRx
            // 
            pnlSidebar.SetColumnSpan(btnRx, 2);
            btnRx.Cursor = Cursors.Hand;
            btnRx.Dock = DockStyle.Fill;
            btnRx.FlatAppearance.BorderSize = 0;
            btnRx.FlatStyle = FlatStyle.Flat;
            btnRx.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnRx.ForeColor = Color.White;
            btnRx.Image = (Image)resources.GetObject("btnRx.Image");
            btnRx.ImageAlign = ContentAlignment.MiddleLeft;
            btnRx.Location = new Point(10, 431);
            btnRx.Margin = new Padding(0, 6, 0, 6);
            btnRx.Name = "btnRx";
            btnRx.Padding = new Padding(10, 0, 0, 0);
            btnRx.Size = new Size(208, 42);
            btnRx.TabIndex = 7;
            btnRx.Text = "    Prescription";
            btnRx.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRx.UseVisualStyleBackColor = true;
            // 
            // btnConsult
            // 
            pnlSidebar.SetColumnSpan(btnConsult, 2);
            btnConsult.Cursor = Cursors.Hand;
            btnConsult.Dock = DockStyle.Fill;
            btnConsult.FlatAppearance.BorderSize = 0;
            btnConsult.FlatStyle = FlatStyle.Flat;
            btnConsult.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnConsult.ForeColor = Color.White;
            btnConsult.Image = (Image)resources.GetObject("btnConsult.Image");
            btnConsult.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsult.Location = new Point(10, 377);
            btnConsult.Margin = new Padding(0, 6, 0, 6);
            btnConsult.Name = "btnConsult";
            btnConsult.Padding = new Padding(10, 0, 0, 0);
            btnConsult.Size = new Size(208, 42);
            btnConsult.TabIndex = 6;
            btnConsult.Text = "    Consultation";
            btnConsult.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsult.UseVisualStyleBackColor = true;
            // 
            // btnVitals
            // 
            pnlSidebar.SetColumnSpan(btnVitals, 2);
            btnVitals.Cursor = Cursors.Hand;
            btnVitals.Dock = DockStyle.Fill;
            btnVitals.FlatAppearance.BorderSize = 0;
            btnVitals.FlatStyle = FlatStyle.Flat;
            btnVitals.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnVitals.ForeColor = Color.White;
            btnVitals.Image = (Image)resources.GetObject("btnVitals.Image");
            btnVitals.ImageAlign = ContentAlignment.MiddleLeft;
            btnVitals.Location = new Point(10, 323);
            btnVitals.Margin = new Padding(0, 6, 0, 6);
            btnVitals.Name = "btnVitals";
            btnVitals.Padding = new Padding(10, 0, 0, 0);
            btnVitals.Size = new Size(208, 42);
            btnVitals.TabIndex = 5;
            btnVitals.Text = "    Vitals";
            btnVitals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVitals.UseVisualStyleBackColor = true;
            // 
            // btnAppts
            // 
            pnlSidebar.SetColumnSpan(btnAppts, 2);
            btnAppts.Cursor = Cursors.Hand;
            btnAppts.Dock = DockStyle.Fill;
            btnAppts.FlatAppearance.BorderSize = 0;
            btnAppts.FlatStyle = FlatStyle.Flat;
            btnAppts.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnAppts.ForeColor = Color.White;
            btnAppts.Image = (Image)resources.GetObject("btnAppts.Image");
            btnAppts.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppts.Location = new Point(10, 269);
            btnAppts.Margin = new Padding(0, 6, 0, 6);
            btnAppts.Name = "btnAppts";
            btnAppts.Padding = new Padding(10, 0, 0, 0);
            btnAppts.Size = new Size(208, 42);
            btnAppts.TabIndex = 4;
            btnAppts.Text = "    Appointments";
            btnAppts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAppts.UseVisualStyleBackColor = true;
            // 
            // btnPatients
            // 
            pnlSidebar.SetColumnSpan(btnPatients, 2);
            btnPatients.Cursor = Cursors.Hand;
            btnPatients.Dock = DockStyle.Fill;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnPatients.ForeColor = Color.White;
            btnPatients.Image = (Image)resources.GetObject("btnPatients.Image");
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(10, 215);
            btnPatients.Margin = new Padding(0, 6, 0, 6);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new Padding(10, 0, 0, 0);
            btnPatients.Size = new Size(208, 42);
            btnPatients.TabIndex = 3;
            btnPatients.Text = "    Patients";
            btnPatients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPatients.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            pnlSidebar.SetColumnSpan(btnDashboard, 2);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Panton-Trial", 9.75F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(10, 159);
            btnDashboard.Margin = new Padding(0, 6, 0, 6);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(208, 44);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "    Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Transparent;
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.EnteredBorderColor = Color.Transparent;
            button1.EnteredColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.InactiveColor = Color.FromArgb(108, 111, 127);
            button1.Location = new Point(10, 118);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(11, 13, 11, 13);
            button1.PressedBorderColor = Color.Transparent;
            button1.PressedColor = Color.Transparent;
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(199, 3);
            button1.TabIndex = 15;
            button1.TextAlignment = StringAlignment.Near;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Panton-Trial", 7F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(108, 111, 127);
            lblAppName.Location = new Point(13, 94);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(193, 15);
            lblAppName.TabIndex = 16;
            lblAppName.Text = "Digital MedRecords System";
            lblAppName.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Margin = new Padding(3, 3, 3, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(6);
            pictureBox1.Size = new Size(193, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // MainShellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 953);
            Controls.Add(tblBackground);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1500, 1200);
            MinimumSize = new Size(1100, 800);
            Name = "MainShellForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClinicKa";
            TransparencyKey = Color.Fuchsia;
            pnlContentbg.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tblBackground.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            tblFooter.ResumeLayout(false);
            tblFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContentbg;
        private PictureBox pcture;
        private TableLayoutPanel tblBackground;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel pnlContent;
        private Panel panel2;
        private ReaLTaiizor.Controls.Button IconHeader;
        protected internal ReaLTaiizor.Controls.Button Header;
        private Label btnHeader;
        private Label lblIntro;
        protected internal ReaLTaiizor.Controls.Button btnBMI;
        private Label lblTime;
        private TableLayoutPanel pnlSidebar;
        private Panel pnlSide;
        private TableLayoutPanel tblFooter;
        private ReaLTaiizor.Controls.Button button2;
        private Label lblUserRole;
        private Label lblUserName;
        private Button btnLogout;
        private ReaLTaiizor.Controls.Button button3;
        private Button btnUsers;
        private Button btnReports;
        private Button btnMedHistory;
        private Button btnRx;
        private Button btnConsult;
        private Button btnVitals;
        private Button btnAppts;
        private Button btnPatients;
        private Button btnDashboard;
        private ReaLTaiizor.Controls.Button button1;
        private Label lblAppName;
        private PictureBox pictureBox1;
        private Label lblDate;
    }
}
