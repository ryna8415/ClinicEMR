namespace ClinicEMR.UserControls
{
    partial class AdminDashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardControl));
            tblLayout = new TableLayoutPanel();
            tblCards = new TableLayoutPanel();
            card3 = new TableLayoutPanel();
            lblTodayVisitsText = new Label();
            pictureBox2 = new PictureBox();
            lblTodayVisitsCount = new ReaLTaiizor.Controls.BigLabel();
            materialDivider3 = new ReaLTaiizor.Controls.MaterialDivider();
            card2 = new TableLayoutPanel();
            lblTotalUsersText = new Label();
            pictureBox1 = new PictureBox();
            lblTotalUsersCount = new ReaLTaiizor.Controls.BigLabel();
            materialDivider2 = new ReaLTaiizor.Controls.MaterialDivider();
            card1 = new TableLayoutPanel();
            lblTotalPatientsText = new Label();
            pbPatients = new PictureBox();
            lblTotalPatientsCount = new ReaLTaiizor.Controls.BigLabel();
            materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            tblContent = new TableLayoutPanel();
            dgvRecentLogins = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tblLayout.SuspendLayout();
            tblCards.SuspendLayout();
            card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPatients).BeginInit();
            tblContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogins).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tblCards, 0, 1);
            tblLayout.Controls.Add(tblContent, 0, 3);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 5;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.Size = new Size(899, 696);
            tblLayout.TabIndex = 2;
            // 
            // tblCards
            // 
            tblCards.ColumnCount = 3;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblCards.Controls.Add(card3, 2, 0);
            tblCards.Controls.Add(card2, 1, 0);
            tblCards.Controls.Add(card1, 0, 0);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(23, 31);
            tblCards.Margin = new Padding(23, 4, 23, 4);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 1;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCards.RowStyles.Add(new RowStyle(SizeType.Absolute, 152F));
            tblCards.Size = new Size(853, 152);
            tblCards.TabIndex = 1;
            // 
            // card3
            // 
            card3.BackColor = Color.FromArgb(37, 45, 56);
            card3.ColumnCount = 4;
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card3.Controls.Add(lblTodayVisitsText, 1, 1);
            card3.Controls.Add(pictureBox2, 2, 1);
            card3.Controls.Add(lblTodayVisitsCount, 1, 0);
            card3.Controls.Add(materialDivider3, 2, 0);
            card3.Cursor = Cursors.Hand;
            card3.Dock = DockStyle.Fill;
            card3.Location = new Point(571, 4);
            card3.Margin = new Padding(3, 4, 3, 4);
            card3.Name = "card3";
            card3.RowCount = 3;
            card3.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card3.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card3.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card3.Size = new Size(279, 144);
            card3.TabIndex = 18;
            card3.MouseEnter += Card_MouseEnter;
            card3.MouseLeave += Card_MouseLeave;
            // 
            // lblTodayVisitsText
            // 
            lblTodayVisitsText.Anchor = AnchorStyles.Left;
            lblTodayVisitsText.FlatStyle = FlatStyle.System;
            lblTodayVisitsText.Font = new Font("Panton-Trial ExtraBold", 12F, FontStyle.Bold);
            lblTodayVisitsText.ForeColor = Color.FromArgb(92, 102, 114);
            lblTodayVisitsText.Location = new Point(34, 97);
            lblTodayVisitsText.Margin = new Padding(23, 4, 3, 4);
            lblTodayVisitsText.Name = "lblTodayVisitsText";
            lblTodayVisitsText.Padding = new Padding(11, 0, 0, 0);
            lblTodayVisitsText.RightToLeft = RightToLeft.No;
            lblTodayVisitsText.Size = new Size(163, 25);
            lblTodayVisitsText.TabIndex = 14;
            lblTodayVisitsText.Text = "Visits Today";
            lblTodayVisitsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(206, 87);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // lblTodayVisitsCount
            // 
            lblTodayVisitsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTodayVisitsCount.BackColor = Color.Transparent;
            lblTodayVisitsCount.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblTodayVisitsCount.ForeColor = Color.FromArgb(226, 230, 237);
            lblTodayVisitsCount.Location = new Point(11, 12);
            lblTodayVisitsCount.Margin = new Padding(0);
            lblTodayVisitsCount.Name = "lblTodayVisitsCount";
            lblTodayVisitsCount.Size = new Size(112, 71);
            lblTodayVisitsCount.TabIndex = 15;
            lblTodayVisitsCount.Text = "10";
            lblTodayVisitsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider3
            // 
            materialDivider3.Anchor = AnchorStyles.Top;
            materialDivider3.BackColor = Color.FromArgb(22, 101, 52);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(231, 0);
            materialDivider3.Margin = new Padding(3, 0, 3, 4);
            materialDivider3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(11, 59);
            materialDivider3.TabIndex = 18;
            materialDivider3.Text = "materialDivider3";
            // 
            // card2
            // 
            card2.BackColor = Color.FromArgb(37, 45, 56);
            card2.ColumnCount = 4;
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card2.Controls.Add(lblTotalUsersText, 1, 1);
            card2.Controls.Add(pictureBox1, 2, 1);
            card2.Controls.Add(lblTotalUsersCount, 1, 0);
            card2.Controls.Add(materialDivider2, 2, 0);
            card2.Cursor = Cursors.Hand;
            card2.Dock = DockStyle.Fill;
            card2.Location = new Point(287, 4);
            card2.Margin = new Padding(3, 4, 3, 4);
            card2.Name = "card2";
            card2.RowCount = 3;
            card2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card2.Size = new Size(278, 144);
            card2.TabIndex = 17;
            card2.MouseEnter += Card_MouseEnter;
            card2.MouseLeave += Card_MouseLeave;
            // 
            // lblTotalUsersText
            // 
            lblTotalUsersText.Anchor = AnchorStyles.Left;
            lblTotalUsersText.FlatStyle = FlatStyle.System;
            lblTotalUsersText.Font = new Font("Panton-Trial ExtraBold", 12F, FontStyle.Bold);
            lblTotalUsersText.ForeColor = Color.FromArgb(92, 102, 114);
            lblTotalUsersText.Location = new Point(34, 97);
            lblTotalUsersText.Margin = new Padding(23, 4, 3, 4);
            lblTotalUsersText.Name = "lblTotalUsersText";
            lblTotalUsersText.Padding = new Padding(11, 0, 0, 0);
            lblTotalUsersText.RightToLeft = RightToLeft.No;
            lblTotalUsersText.Size = new Size(163, 25);
            lblTotalUsersText.TabIndex = 14;
            lblTotalUsersText.Text = "Staff Accounts";
            lblTotalUsersText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(205, 87);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lblTotalUsersCount
            // 
            lblTotalUsersCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalUsersCount.BackColor = Color.Transparent;
            lblTotalUsersCount.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblTotalUsersCount.ForeColor = Color.FromArgb(226, 230, 237);
            lblTotalUsersCount.Location = new Point(11, 13);
            lblTotalUsersCount.Margin = new Padding(0);
            lblTotalUsersCount.Name = "lblTotalUsersCount";
            lblTotalUsersCount.Size = new Size(112, 70);
            lblTotalUsersCount.TabIndex = 15;
            lblTotalUsersCount.Text = "10";
            lblTotalUsersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider2
            // 
            materialDivider2.Anchor = AnchorStyles.Top;
            materialDivider2.BackColor = Color.FromArgb(91, 33, 182);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(230, 0);
            materialDivider2.Margin = new Padding(3, 0, 3, 4);
            materialDivider2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(11, 59);
            materialDivider2.TabIndex = 18;
            materialDivider2.Text = "materialDivider2";
            // 
            // card1
            // 
            card1.BackColor = Color.FromArgb(37, 45, 56);
            card1.ColumnCount = 4;
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card1.Controls.Add(lblTotalPatientsText, 1, 1);
            card1.Controls.Add(pbPatients, 2, 1);
            card1.Controls.Add(lblTotalPatientsCount, 1, 0);
            card1.Controls.Add(materialDivider1, 2, 0);
            card1.Cursor = Cursors.Hand;
            card1.Dock = DockStyle.Fill;
            card1.Location = new Point(3, 4);
            card1.Margin = new Padding(3, 4, 3, 4);
            card1.Name = "card1";
            card1.RowCount = 3;
            card1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card1.Size = new Size(278, 144);
            card1.TabIndex = 16;
            card1.MouseEnter += Card_MouseEnter;
            card1.MouseLeave += Card_MouseLeave;
            // 
            // lblTotalPatientsText
            // 
            lblTotalPatientsText.Anchor = AnchorStyles.Left;
            lblTotalPatientsText.FlatStyle = FlatStyle.System;
            lblTotalPatientsText.Font = new Font("Panton-Trial ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPatientsText.ForeColor = Color.FromArgb(92, 102, 114);
            lblTotalPatientsText.Location = new Point(34, 97);
            lblTotalPatientsText.Margin = new Padding(23, 4, 3, 4);
            lblTotalPatientsText.Name = "lblTotalPatientsText";
            lblTotalPatientsText.Padding = new Padding(11, 0, 0, 0);
            lblTotalPatientsText.RightToLeft = RightToLeft.No;
            lblTotalPatientsText.Size = new Size(163, 25);
            lblTotalPatientsText.TabIndex = 14;
            lblTotalPatientsText.Text = "Patients Registered";
            lblTotalPatientsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbPatients
            // 
            pbPatients.Dock = DockStyle.Fill;
            pbPatients.Image = (Image)resources.GetObject("pbPatients.Image");
            pbPatients.Location = new Point(205, 87);
            pbPatients.Margin = new Padding(3, 4, 3, 4);
            pbPatients.Name = "pbPatients";
            pbPatients.Size = new Size(61, 45);
            pbPatients.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPatients.TabIndex = 17;
            pbPatients.TabStop = false;
            // 
            // lblTotalPatientsCount
            // 
            lblTotalPatientsCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalPatientsCount.BackColor = Color.Transparent;
            lblTotalPatientsCount.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblTotalPatientsCount.ForeColor = Color.FromArgb(226, 230, 237);
            lblTotalPatientsCount.Location = new Point(11, 11);
            lblTotalPatientsCount.Margin = new Padding(0);
            lblTotalPatientsCount.Name = "lblTotalPatientsCount";
            lblTotalPatientsCount.Size = new Size(112, 72);
            lblTotalPatientsCount.TabIndex = 15;
            lblTotalPatientsCount.Text = "10";
            lblTotalPatientsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.Top;
            materialDivider1.BackColor = Color.FromArgb(92, 143, 204);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(230, 0);
            materialDivider1.Margin = new Padding(3, 0, 3, 4);
            materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(11, 59);
            materialDivider1.TabIndex = 18;
            materialDivider1.Text = "materialDivider1";
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblContent.Controls.Add(dgvRecentLogins, 0, 1);
            tblContent.Controls.Add(tableLayoutPanel1, 0, 0);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(23, 218);
            tblContent.Margin = new Padding(23, 4, 23, 4);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 2;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0952377F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 86.90476F));
            tblContent.Size = new Size(853, 447);
            tblContent.TabIndex = 2;
            // 
            // dgvRecentLogins
            // 
            dgvRecentLogins.BackgroundColor = SystemColors.ControlDarkDark;
            dgvRecentLogins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentLogins.Cursor = Cursors.Hand;
            dgvRecentLogins.Dock = DockStyle.Fill;
            dgvRecentLogins.Location = new Point(3, 62);
            dgvRecentLogins.Margin = new Padding(3, 4, 3, 4);
            dgvRecentLogins.Name = "dgvRecentLogins";
            dgvRecentLogins.RowHeadersWidth = 51;
            dgvRecentLogins.Size = new Size(847, 381);
            dgvRecentLogins.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.3184886F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.68151F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(847, 50);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 50);
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
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 31);
            label1.TabIndex = 1;
            label1.Text = "Recent Staff Logins";
            // 
            // AdminDashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboardControl";
            Size = new Size(899, 696);
            Load += AdminDashboardControl_Load;
            tblLayout.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            card3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            card2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            card1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPatients).EndInit();
            tblContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogins).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblCards;
        private TableLayoutPanel tblContent;
        private DataGridView dgvRecentLogins;
        private TableLayoutPanel card1;
        private Label lblTotalPatientsText;
        private ReaLTaiizor.Controls.BigLabel lblTotalPatientsCount;
        private PictureBox pbPatients;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private TableLayoutPanel card2;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider2;
        private Label lblTotalUsersText;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel lblTotalUsersCount;
        private TableLayoutPanel card3;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider3;
        private Label lblTodayVisitsText;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel lblTodayVisitsCount;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
    }
}
