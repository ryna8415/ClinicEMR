namespace ClinicEMR.Forms
{
    partial class placeholder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placeholder));
            tblBackground = new TableLayoutPanel();
            pnlSidebar = new TableLayoutPanel();
            tblFooter = new TableLayoutPanel();
            btnLogout = new Button();
            lblUserRole = new Label();
            lblUserName = new Label();
            btnUsers = new Button();
            btnReports = new Button();
            btnMedHistory = new Button();
            btnRx = new Button();
            btnConsult = new Button();
            btnVitals = new Button();
            btnAppts = new Button();
            btnPatients = new Button();
            pcture = new PictureBox();
            btnDashboard = new Button();
            pnlContent = new FlowLayoutPanel();
            pnlSide = new Panel();
            tblBackground.SuspendLayout();
            pnlSidebar.SuspendLayout();
            tblFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcture).BeginInit();
            SuspendLayout();
            // 
            // tblBackground
            // 
            tblBackground.BackColor = Color.SteelBlue;
            tblBackground.ColumnCount = 3;
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1428566F));
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.85714F));
            tblBackground.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblBackground.Controls.Add(pnlSidebar, 0, 1);
            tblBackground.Controls.Add(pnlContent, 1, 1);
            tblBackground.Dock = DockStyle.Fill;
            tblBackground.Location = new Point(0, 0);
            tblBackground.Name = "tblBackground";
            tblBackground.RowCount = 3;
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblBackground.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblBackground.Size = new Size(1084, 641);
            tblBackground.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.SteelBlue;
            pnlSidebar.ColumnCount = 2;
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            pnlSidebar.Controls.Add(pnlSide, 1, 1);
            pnlSidebar.Controls.Add(tblFooter, 0, 10);
            pnlSidebar.Controls.Add(btnUsers, 0, 9);
            pnlSidebar.Controls.Add(btnReports, 0, 8);
            pnlSidebar.Controls.Add(btnMedHistory, 0, 7);
            pnlSidebar.Controls.Add(btnRx, 0, 6);
            pnlSidebar.Controls.Add(btnConsult, 0, 5);
            pnlSidebar.Controls.Add(btnVitals, 0, 4);
            pnlSidebar.Controls.Add(btnAppts, 0, 3);
            pnlSidebar.Controls.Add(btnPatients, 0, 2);
            pnlSidebar.Controls.Add(pcture, 0, 0);
            pnlSidebar.Controls.Add(btnDashboard, 0, 1);
            pnlSidebar.Dock = DockStyle.Fill;
            pnlSidebar.Location = new Point(3, 23);
            pnlSidebar.Margin = new Padding(3, 3, 0, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.RowCount = 11;
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle());
            pnlSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            pnlSidebar.Size = new Size(179, 595);
            pnlSidebar.TabIndex = 0;
            // 
            // tblFooter
            // 
            tblFooter.ColumnCount = 1;
            tblFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFooter.Controls.Add(btnLogout, 0, 2);
            tblFooter.Controls.Add(lblUserRole, 0, 1);
            tblFooter.Controls.Add(lblUserName, 0, 0);
            tblFooter.Dock = DockStyle.Bottom;
            tblFooter.Location = new Point(3, 492);
            tblFooter.Name = "tblFooter";
            tblFooter.RowCount = 3;
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFooter.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblFooter.Size = new Size(163, 100);
            tblFooter.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 63);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(157, 34);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblUserRole
            // 
            lblUserRole.Anchor = AnchorStyles.Top;
            lblUserRole.AutoSize = true;
            lblUserRole.ForeColor = Color.Black;
            lblUserRole.Location = new Point(81, 20);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(0, 15);
            lblUserRole.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(81, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 17);
            lblUserName.TabIndex = 0;
            // 
            // btnUsers
            // 
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(3, 431);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(160, 35);
            btnUsers.TabIndex = 10;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(3, 390);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(160, 35);
            btnReports.TabIndex = 9;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnMedHistory
            // 
            btnMedHistory.FlatAppearance.BorderSize = 0;
            btnMedHistory.FlatStyle = FlatStyle.Flat;
            btnMedHistory.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnMedHistory.Image = (Image)resources.GetObject("btnMedHistory.Image");
            btnMedHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnMedHistory.Location = new Point(3, 349);
            btnMedHistory.Name = "btnMedHistory";
            btnMedHistory.Size = new Size(160, 35);
            btnMedHistory.TabIndex = 8;
            btnMedHistory.Text = "Medical History";
            btnMedHistory.UseVisualStyleBackColor = true;
            // 
            // btnRx
            // 
            btnRx.FlatAppearance.BorderSize = 0;
            btnRx.FlatStyle = FlatStyle.Flat;
            btnRx.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnRx.Image = (Image)resources.GetObject("btnRx.Image");
            btnRx.ImageAlign = ContentAlignment.MiddleLeft;
            btnRx.Location = new Point(3, 308);
            btnRx.Name = "btnRx";
            btnRx.Size = new Size(160, 35);
            btnRx.TabIndex = 7;
            btnRx.Text = "Prescription";
            btnRx.UseVisualStyleBackColor = true;
            // 
            // btnConsult
            // 
            btnConsult.FlatAppearance.BorderSize = 0;
            btnConsult.FlatStyle = FlatStyle.Flat;
            btnConsult.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnConsult.Image = (Image)resources.GetObject("btnConsult.Image");
            btnConsult.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsult.Location = new Point(3, 267);
            btnConsult.Name = "btnConsult";
            btnConsult.Size = new Size(160, 35);
            btnConsult.TabIndex = 6;
            btnConsult.Text = "Consultation";
            btnConsult.UseVisualStyleBackColor = true;
            // 
            // btnVitals
            // 
            btnVitals.FlatAppearance.BorderSize = 0;
            btnVitals.FlatStyle = FlatStyle.Flat;
            btnVitals.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnVitals.Image = (Image)resources.GetObject("btnVitals.Image");
            btnVitals.ImageAlign = ContentAlignment.MiddleLeft;
            btnVitals.Location = new Point(3, 226);
            btnVitals.Name = "btnVitals";
            btnVitals.Size = new Size(160, 35);
            btnVitals.TabIndex = 5;
            btnVitals.Text = "Vitals";
            btnVitals.UseVisualStyleBackColor = true;
            // 
            // btnAppts
            // 
            btnAppts.FlatAppearance.BorderSize = 0;
            btnAppts.FlatStyle = FlatStyle.Flat;
            btnAppts.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnAppts.Image = (Image)resources.GetObject("btnAppts.Image");
            btnAppts.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppts.Location = new Point(3, 185);
            btnAppts.Name = "btnAppts";
            btnAppts.Size = new Size(160, 35);
            btnAppts.TabIndex = 4;
            btnAppts.Text = "Appointments";
            btnAppts.UseVisualStyleBackColor = true;
            // 
            // btnPatients
            // 
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnPatients.Image = (Image)resources.GetObject("btnPatients.Image");
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(3, 144);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(160, 35);
            btnPatients.TabIndex = 3;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = true;
            // 
            // pcture
            // 
            pcture.Dock = DockStyle.Fill;
            pcture.Image = (Image)resources.GetObject("pcture.Image");
            pcture.Location = new Point(3, 3);
            pcture.Name = "pcture";
            pcture.Size = new Size(163, 94);
            pcture.SizeMode = PictureBoxSizeMode.Zoom;
            pcture.TabIndex = 1;
            pcture.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Franklin Gothic Medium", 9.75F);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 103);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 35);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.LightGray;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(182, 20);
            pnlContent.Margin = new Padding(0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(881, 601);
            pnlContent.TabIndex = 1;
            // 
            // pnlSide
            // 
            pnlSide.BackColor = Color.LightGray;
            pnlSide.Dock = DockStyle.Fill;
            pnlSide.ForeColor = Color.LightGray;
            pnlSide.Location = new Point(169, 100);
            pnlSide.Margin = new Padding(0);
            pnlSide.Name = "pnlSide";
            pnlSide.Size = new Size(10, 41);
            pnlSide.TabIndex = 12;
            // 
            // placeholder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 641);
            Controls.Add(tblBackground);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "placeholder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "placeholder";
            tblBackground.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            tblFooter.ResumeLayout(false);
            tblFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblBackground;
        private TableLayoutPanel pnlSidebar;
        private PictureBox pcture;
        private FlowLayoutPanel pnlContent;
        private Button btnDashboard;
        private Button btnMedHistory;
        private Button btnRx;
        private Button btnConsult;
        private Button btnVitals;
        private Button btnAppts;
        private Button btnPatients;
        private Button btnUsers;
        private Button btnReports;
        private TableLayoutPanel tblFooter;
        private Label lblUserName;
        private Label lblUserRole;
        private Button btnLogout;
        private Panel pnlSide;
    }
}