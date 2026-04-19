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
            btnHeader = new ReaLTaiizor.Controls.Button();
            pnlSide = new Panel();
            tblFooter = new TableLayoutPanel();
            button2 = new ReaLTaiizor.Controls.Button();
            lblUserRole = new Label();
            lblUserName = new Label();
            btnLogout = new Button();
            button3 = new ReaLTaiizor.Controls.Button();
            btnUsers = new Button();
            btnReports = new Button();
            pnlSidebar = new TableLayoutPanel();
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
            tblBackground = new TableLayoutPanel();
            pnlContentbg.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tblFooter.SuspendLayout();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tblBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentbg
            // 
            pnlContentbg.BackColor = Color.FromArgb(49, 62, 80);
            pnlContentbg.Controls.Add(tableLayoutPanel1);
            pnlContentbg.Dock = DockStyle.Fill;
            pnlContentbg.Location = new Point(179, 20);
            pnlContentbg.Margin = new Padding(0);
            pnlContentbg.Name = "pnlContentbg";
            pnlContentbg.Size = new Size(801, 640);
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(801, 640);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 62, 80);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 45);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 10);
            panel1.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(226, 230, 237);
            pnlContent.ColumnCount = 1;
            pnlContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 55);
            pnlContent.Margin = new Padding(0);
            pnlContent.MinimumSize = new Size(261, 61);
            pnlContent.Name = "pnlContent";
            pnlContent.RowCount = 1;
            pnlContent.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnlContent.Size = new Size(801, 585);
            pnlContent.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 62, 80);
            panel2.Controls.Add(btnHeader);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 45);
            panel2.TabIndex = 2;
            // 
            // btnHeader
            // 
            btnHeader.BackColor = Color.Transparent;
            btnHeader.BorderColor = Color.Transparent;
            btnHeader.Dock = DockStyle.Fill;
            btnHeader.Enabled = false;
            btnHeader.EnteredBorderColor = Color.Transparent;
            btnHeader.EnteredColor = Color.Transparent;
            btnHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHeader.Image = null;
            btnHeader.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeader.InactiveColor = Color.FromArgb(13, 43, 69);
            btnHeader.Location = new Point(0, 0);
            btnHeader.Margin = new Padding(3, 0, 0, 0);
            btnHeader.Name = "btnHeader";
            btnHeader.Padding = new Padding(20, 10, 10, 10);
            btnHeader.PressedBorderColor = Color.Transparent;
            btnHeader.PressedColor = Color.Transparent;
            btnHeader.RightToLeft = RightToLeft.Yes;
            btnHeader.Size = new Size(801, 45);
            btnHeader.TabIndex = 1;
            btnHeader.Text = "  Hello!";
            btnHeader.TextAlignment = StringAlignment.Near;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.FromArgb(92, 143, 204);
            pnlSide.Dock = DockStyle.Fill;
            pnlSide.ForeColor = Color.LightGray;
            pnlSide.Location = new Point(169, 92);
            pnlSide.Margin = new Padding(0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(5, 41);
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
            tblFooter.Location = new Point(3, 508);
            tblFooter.Name = "tblFooter";
            tblFooter.RowCount = 7;
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFooter.Size = new Size(155, 123);
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
            button2.Padding = new Padding(10, 10, 10, 100);
            button2.PressedBorderColor = Color.Transparent;
            button2.PressedColor = Color.Transparent;
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(155, 2);
            button2.TabIndex = 14;
            button2.TextAlignment = StringAlignment.Near;
            // 
            // lblUserRole
            // 
            lblUserRole.Anchor = AnchorStyles.Top;
            lblUserRole.AutoSize = true;
            lblUserRole.ForeColor = Color.Black;
            lblUserRole.Location = new Point(77, 27);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(0, 15);
            lblUserRole.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(77, 7);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 17);
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
            btnLogout.Location = new Point(0, 86);
            btnLogout.Margin = new Padding(0, 3, 0, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(3, 0, 0, 0);
            btnLogout.Size = new Size(155, 34);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "     Log Out";
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
            button3.Location = new Point(0, 52);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 10, 10, 100);
            button3.PressedBorderColor = Color.Transparent;
            button3.PressedColor = Color.Transparent;
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(155, 2);
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
            btnUsers.Location = new Point(0, 423);
            btnUsers.Margin = new Padding(0, 3, 0, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(3, 0, 0, 0);
            btnUsers.Size = new Size(169, 35);
            btnUsers.TabIndex = 10;
            btnUsers.Text = "     Users";
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
            btnReports.Location = new Point(0, 382);
            btnReports.Margin = new Padding(0, 3, 0, 3);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(3, 0, 0, 0);
            btnReports.Size = new Size(169, 35);
            btnReports.TabIndex = 9;
            btnReports.Text = "     Reports";
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Transparent;
            pnlSidebar.ColumnCount = 3;
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
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
            pnlSidebar.Location = new Point(5, 23);
            pnlSidebar.Margin = new Padding(5, 3, 0, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.RowCount = 14;
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            pnlSidebar.Size = new Size(174, 634);
            pnlSidebar.TabIndex = 0;
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
            btnMedHistory.Location = new Point(0, 341);
            btnMedHistory.Margin = new Padding(0, 3, 0, 3);
            btnMedHistory.Name = "btnMedHistory";
            btnMedHistory.Padding = new Padding(3, 0, 0, 0);
            btnMedHistory.Size = new Size(169, 35);
            btnMedHistory.TabIndex = 8;
            btnMedHistory.Text = "     Clinical Hx";
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
            btnRx.Location = new Point(0, 300);
            btnRx.Margin = new Padding(0, 3, 0, 3);
            btnRx.Name = "btnRx";
            btnRx.Padding = new Padding(3, 0, 0, 0);
            btnRx.Size = new Size(169, 35);
            btnRx.TabIndex = 7;
            btnRx.Text = "     Prescription";
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
            btnConsult.Location = new Point(0, 259);
            btnConsult.Margin = new Padding(0, 3, 0, 3);
            btnConsult.Name = "btnConsult";
            btnConsult.Padding = new Padding(3, 0, 0, 0);
            btnConsult.Size = new Size(169, 35);
            btnConsult.TabIndex = 6;
            btnConsult.Text = "     Consultation";
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
            btnVitals.Location = new Point(0, 218);
            btnVitals.Margin = new Padding(0, 3, 0, 3);
            btnVitals.Name = "btnVitals";
            btnVitals.Padding = new Padding(3, 0, 0, 0);
            btnVitals.Size = new Size(169, 35);
            btnVitals.TabIndex = 5;
            btnVitals.Text = "     Vitals";
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
            btnAppts.Location = new Point(0, 177);
            btnAppts.Margin = new Padding(0, 3, 0, 3);
            btnAppts.Name = "btnAppts";
            btnAppts.Padding = new Padding(3, 0, 0, 0);
            btnAppts.Size = new Size(169, 35);
            btnAppts.TabIndex = 4;
            btnAppts.Text = "     Appointments";
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
            btnPatients.Location = new Point(0, 136);
            btnPatients.Margin = new Padding(0, 3, 0, 3);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new Padding(3, 0, 0, 0);
            btnPatients.Size = new Size(169, 35);
            btnPatients.TabIndex = 3;
            btnPatients.Text = "     Patients";
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
            btnDashboard.Location = new Point(0, 95);
            btnDashboard.Margin = new Padding(0, 3, 0, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(3, 0, 0, 0);
            btnDashboard.Size = new Size(169, 35);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "     Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Transparent;
            button1.Enabled = false;
            button1.EnteredBorderColor = Color.Transparent;
            button1.EnteredColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.InactiveColor = Color.FromArgb(108, 111, 127);
            button1.Location = new Point(0, 70);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.PressedBorderColor = Color.Transparent;
            button1.PressedColor = Color.Transparent;
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(161, 2);
            button1.TabIndex = 15;
            button1.TextAlignment = StringAlignment.Near;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Dock = DockStyle.Fill;
            lblAppName.Font = new Font("Panton-Trial", 8.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.FromArgb(108, 111, 127);
            lblAppName.Location = new Point(3, 50);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(155, 20);
            lblAppName.TabIndex = 16;
            lblAppName.Text = "Digital MedRecords System";
            lblAppName.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // tblBackground
            // 
            tblBackground.BackColor = Color.FromArgb(49, 62, 80);
            tblBackground.ColumnCount = 3;
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2653065F));
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.7346954F));
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblBackground.Controls.Add(pnlSidebar, 0, 1);
            tblBackground.Controls.Add(pnlContentbg, 1, 1);
            tblBackground.Dock = DockStyle.Fill;
            tblBackground.Location = new Point(0, 0);
            tblBackground.Margin = new Padding(0, 3, 3, 3);
            tblBackground.Name = "tblBackground";
            tblBackground.RowCount = 3;
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblBackground.Size = new Size(1000, 680);
            tblBackground.TabIndex = 1;
            // 
            // MainShellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 680);
            Controls.Add(tblBackground);
            MinimumSize = new Size(1000, 680);
            Name = "MainShellForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            TransparencyKey = Color.Fuchsia;
            pnlContentbg.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tblFooter.ResumeLayout(false);
            tblFooter.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tblBackground.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContentbg;
        private Panel pnlSide;
        private TableLayoutPanel tblFooter;
        private Button btnLogout;
        private Label lblUserRole;
        private Label lblUserName;
        private Button btnUsers;
        private Button btnReports;
        private TableLayoutPanel pnlSidebar;
        private Button btnMedHistory;
        private Button btnRx;
        private Button btnConsult;
        private Button btnVitals;
        private Button btnAppts;
        private Button btnPatients;
        private PictureBox pcture;
        private Button btnDashboard;
        private TableLayoutPanel tblBackground;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel pnlContent;
        private Panel panel2;
        private ReaLTaiizor.Controls.Button IconHeader;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button3;
        private Label lblAppName;
        private PictureBox pictureBox1;
        protected internal ReaLTaiizor.Controls.Button btnHeader;
    }
}
