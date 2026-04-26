namespace ClinicEMR.UserControls
{
    partial class DoctorDashboardControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashboardControl));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            tblContent = new TableLayoutPanel();
            dgvMyAppts = new DataGridView();
            lblMyPatientsText = new Label();
            pbPatients = new PictureBox();
            lblMyPatients = new ReaLTaiizor.Controls.BigLabel();
            materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            card1 = new TableLayoutPanel();
            lblDonTodayText = new Label();
            pictureBox1 = new PictureBox();
            lblDoneToday = new ReaLTaiizor.Controls.BigLabel();
            materialDivider2 = new ReaLTaiizor.Controls.MaterialDivider();
            lblPendingTodayText = new Label();
            pictureBox2 = new PictureBox();
            lblPendingToday = new ReaLTaiizor.Controls.BigLabel();
            materialDivider3 = new ReaLTaiizor.Controls.MaterialDivider();
            card3 = new TableLayoutPanel();
            tblCards = new TableLayoutPanel();
            card2 = new TableLayoutPanel();
            tblLayout = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tblContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyAppts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPatients).BeginInit();
            card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            card3.SuspendLayout();
            tblCards.SuspendLayout();
            card2.SuspendLayout();
            tblLayout.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Panton-Trial ExtraBold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(26, 35, 48);
            label1.Location = new Point(43, 5);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 1;
            label1.Text = "My Appointments";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(853, 42);
            tableLayoutPanel1.TabIndex = 18;
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
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblContent.Controls.Add(dgvMyAppts, 0, 1);
            tblContent.Controls.Add(tableLayoutPanel1, 0, 0);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(23, 218);
            tblContent.Margin = new Padding(23, 4, 23, 4);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 2;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tblContent.Size = new Size(859, 464);
            tblContent.TabIndex = 2;
            // 
            // dgvMyAppts
            // 
            dgvMyAppts.BackgroundColor = SystemColors.ControlDarkDark;
            dgvMyAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyAppts.Cursor = Cursors.Hand;
            dgvMyAppts.Dock = DockStyle.Fill;
            dgvMyAppts.Location = new Point(3, 54);
            dgvMyAppts.Margin = new Padding(3, 4, 3, 4);
            dgvMyAppts.Name = "dgvMyAppts";
            dgvMyAppts.RowHeadersWidth = 51;
            dgvMyAppts.Size = new Size(853, 406);
            dgvMyAppts.TabIndex = 17;
            // 
            // lblMyPatientsText
            // 
            lblMyPatientsText.Anchor = AnchorStyles.Left;
            lblMyPatientsText.FlatStyle = FlatStyle.System;
            lblMyPatientsText.Font = new Font("Panton-Trial ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyPatientsText.ForeColor = Color.FromArgb(92, 102, 114);
            lblMyPatientsText.Location = new Point(34, 97);
            lblMyPatientsText.Margin = new Padding(23, 4, 3, 4);
            lblMyPatientsText.Name = "lblMyPatientsText";
            lblMyPatientsText.Padding = new Padding(11, 0, 0, 0);
            lblMyPatientsText.RightToLeft = RightToLeft.No;
            lblMyPatientsText.Size = new Size(150, 25);
            lblMyPatientsText.TabIndex = 14;
            lblMyPatientsText.Text = "My Patients";
            lblMyPatientsText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbPatients
            // 
            pbPatients.Dock = DockStyle.Fill;
            pbPatients.Image = (Image)resources.GetObject("pbPatients.Image");
            pbPatients.Location = new Point(207, 87);
            pbPatients.Margin = new Padding(3, 4, 3, 4);
            pbPatients.Name = "pbPatients";
            pbPatients.Size = new Size(61, 45);
            pbPatients.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPatients.TabIndex = 17;
            pbPatients.TabStop = false;
            // 
            // lblMyPatients
            // 
            lblMyPatients.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMyPatients.BackColor = Color.Transparent;
            lblMyPatients.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblMyPatients.ForeColor = Color.FromArgb(226, 230, 237);
            lblMyPatients.Location = new Point(11, 11);
            lblMyPatients.Margin = new Padding(0);
            lblMyPatients.Name = "lblMyPatients";
            lblMyPatients.Size = new Size(112, 72);
            lblMyPatients.TabIndex = 15;
            lblMyPatients.Text = "10";
            lblMyPatients.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.Top;
            materialDivider1.BackColor = Color.FromArgb(92, 143, 204);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(232, 0);
            materialDivider1.Margin = new Padding(3, 0, 3, 4);
            materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(11, 59);
            materialDivider1.TabIndex = 18;
            materialDivider1.Text = "materialDivider1";
            // 
            // card1
            // 
            card1.BackColor = Color.FromArgb(37, 45, 56);
            card1.ColumnCount = 4;
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card1.Controls.Add(lblMyPatientsText, 1, 1);
            card1.Controls.Add(pbPatients, 2, 1);
            card1.Controls.Add(lblMyPatients, 1, 0);
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
            card1.Size = new Size(280, 144);
            card1.TabIndex = 16;
            // 
            // lblDonTodayText
            // 
            lblDonTodayText.Anchor = AnchorStyles.Left;
            lblDonTodayText.FlatStyle = FlatStyle.System;
            lblDonTodayText.Font = new Font("Panton-Trial ExtraBold", 12F, FontStyle.Bold);
            lblDonTodayText.ForeColor = Color.FromArgb(92, 102, 114);
            lblDonTodayText.Location = new Point(34, 97);
            lblDonTodayText.Margin = new Padding(23, 4, 3, 4);
            lblDonTodayText.Name = "lblDonTodayText";
            lblDonTodayText.Padding = new Padding(11, 0, 0, 0);
            lblDonTodayText.RightToLeft = RightToLeft.No;
            lblDonTodayText.Size = new Size(150, 25);
            lblDonTodayText.TabIndex = 14;
            lblDonTodayText.Text = "Done Today";
            lblDonTodayText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 87);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lblDoneToday
            // 
            lblDoneToday.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDoneToday.BackColor = Color.Transparent;
            lblDoneToday.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblDoneToday.ForeColor = Color.FromArgb(226, 230, 237);
            lblDoneToday.Location = new Point(11, 13);
            lblDoneToday.Margin = new Padding(0);
            lblDoneToday.Name = "lblDoneToday";
            lblDoneToday.Size = new Size(112, 70);
            lblDoneToday.TabIndex = 15;
            lblDoneToday.Text = "10";
            lblDoneToday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider2
            // 
            materialDivider2.Anchor = AnchorStyles.Top;
            materialDivider2.BackColor = Color.FromArgb(74, 168, 122);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(232, 0);
            materialDivider2.Margin = new Padding(3, 0, 3, 4);
            materialDivider2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(11, 59);
            materialDivider2.TabIndex = 18;
            materialDivider2.Text = "materialDivider2";
            // 
            // lblPendingTodayText
            // 
            lblPendingTodayText.Anchor = AnchorStyles.Left;
            lblPendingTodayText.FlatStyle = FlatStyle.System;
            lblPendingTodayText.Font = new Font("Panton-Trial ExtraBold", 12F, FontStyle.Bold);
            lblPendingTodayText.ForeColor = Color.FromArgb(92, 102, 114);
            lblPendingTodayText.Location = new Point(34, 97);
            lblPendingTodayText.Margin = new Padding(23, 4, 3, 4);
            lblPendingTodayText.Name = "lblPendingTodayText";
            lblPendingTodayText.Padding = new Padding(11, 0, 0, 0);
            lblPendingTodayText.RightToLeft = RightToLeft.No;
            lblPendingTodayText.Size = new Size(151, 25);
            lblPendingTodayText.TabIndex = 14;
            lblPendingTodayText.Text = "Pending Today";
            lblPendingTodayText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(208, 87);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // lblPendingToday
            // 
            lblPendingToday.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPendingToday.BackColor = Color.Transparent;
            lblPendingToday.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblPendingToday.ForeColor = Color.FromArgb(226, 230, 237);
            lblPendingToday.Location = new Point(11, 12);
            lblPendingToday.Margin = new Padding(0);
            lblPendingToday.Name = "lblPendingToday";
            lblPendingToday.Size = new Size(112, 71);
            lblPendingToday.TabIndex = 15;
            lblPendingToday.Text = "10";
            lblPendingToday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider3
            // 
            materialDivider3.Anchor = AnchorStyles.Top;
            materialDivider3.BackColor = Color.FromArgb(146, 64, 14);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(233, 0);
            materialDivider3.Margin = new Padding(3, 0, 3, 4);
            materialDivider3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider3.Name = "materialDivider3";
            materialDivider3.Size = new Size(11, 59);
            materialDivider3.TabIndex = 18;
            materialDivider3.Text = "materialDivider3";
            // 
            // card3
            // 
            card3.BackColor = Color.FromArgb(37, 45, 56);
            card3.ColumnCount = 4;
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card3.Controls.Add(lblPendingTodayText, 1, 1);
            card3.Controls.Add(pictureBox2, 2, 1);
            card3.Controls.Add(lblPendingToday, 1, 0);
            card3.Controls.Add(materialDivider3, 2, 0);
            card3.Cursor = Cursors.Hand;
            card3.Dock = DockStyle.Fill;
            card3.Location = new Point(575, 4);
            card3.Margin = new Padding(3, 4, 3, 4);
            card3.Name = "card3";
            card3.RowCount = 3;
            card3.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card3.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card3.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card3.Size = new Size(281, 144);
            card3.TabIndex = 18;
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
            tblCards.Size = new Size(859, 152);
            tblCards.TabIndex = 1;
            // 
            // card2
            // 
            card2.BackColor = Color.FromArgb(37, 45, 56);
            card2.ColumnCount = 4;
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 67F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card2.Controls.Add(lblDonTodayText, 1, 1);
            card2.Controls.Add(pictureBox1, 2, 1);
            card2.Controls.Add(lblDoneToday, 1, 0);
            card2.Controls.Add(materialDivider2, 2, 0);
            card2.Cursor = Cursors.Hand;
            card2.Dock = DockStyle.Fill;
            card2.Location = new Point(289, 4);
            card2.Margin = new Padding(3, 4, 3, 4);
            card2.Name = "card2";
            card2.RowCount = 3;
            card2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card2.Size = new Size(280, 144);
            card2.TabIndex = 17;
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
            tblLayout.Size = new Size(905, 713);
            tblLayout.TabIndex = 4;
            // 
            // DoctorDashboardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorDashboardControl";
            Size = new Size(905, 713);
            Load += DoctorDashboardControl_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tblContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyAppts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPatients).EndInit();
            card1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            card3.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            card2.ResumeLayout(false);
            tblLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private TableLayoutPanel tblContent;
        private DataGridView dgvMyAppts;
        private Label lblMyPatientsText;
        private PictureBox pbPatients;
        private ReaLTaiizor.Controls.BigLabel lblMyPatients;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private TableLayoutPanel card1;
        private Label lblDonTodayText;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel lblDoneToday;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider2;
        private Label lblPendingTodayText;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel lblPendingToday;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider3;
        private TableLayoutPanel card3;
        private TableLayoutPanel tblCards;
        private TableLayoutPanel card2;
        private TableLayoutPanel tblLayout;
    }
}
