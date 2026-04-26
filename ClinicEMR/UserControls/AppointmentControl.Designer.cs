namespace ClinicEMR.Forms
{
    partial class AppointmentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentControl));
            pbPatients = new PictureBox();
            card4 = new TableLayoutPanel();
            pictureBox6 = new PictureBox();
            lblCancelledCount = new ReaLTaiizor.Controls.BigLabel();
            materialDivider6 = new ReaLTaiizor.Controls.MaterialDivider();
            lblCancelled = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            cboStatus = new ComboBox();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            chkAllDates = new CheckBox();
            lblTodayTotalCount = new ReaLTaiizor.Controls.BigLabel();
            btnBook = new ReaLTaiizor.Controls.Button();
            materialDivider1 = new ReaLTaiizor.Controls.MaterialDivider();
            tblLayout = new TableLayoutPanel();
            dgvAppointments = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnUpdateStatus = new ReaLTaiizor.Controls.Button();
            tblCards = new TableLayoutPanel();
            card3 = new TableLayoutPanel();
            lblRemaining = new Label();
            pictureBox2 = new PictureBox();
            lblRemainingCount = new ReaLTaiizor.Controls.BigLabel();
            materialDivider3 = new ReaLTaiizor.Controls.MaterialDivider();
            card2 = new TableLayoutPanel();
            lblCompleted = new Label();
            lblDoneTodayCount = new ReaLTaiizor.Controls.BigLabel();
            materialDivider2 = new ReaLTaiizor.Controls.MaterialDivider();
            card1 = new TableLayoutPanel();
            lblTodayTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPatients).BeginInit();
            card4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tblCards.SuspendLayout();
            card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            card2.SuspendLayout();
            card1.SuspendLayout();
            SuspendLayout();
            // 
            // pbPatients
            // 
            pbPatients.Dock = DockStyle.Fill;
            pbPatients.Image = (Image)resources.GetObject("pbPatients.Image");
            pbPatients.Location = new Point(134, 87);
            pbPatients.Margin = new Padding(3, 4, 3, 4);
            pbPatients.Name = "pbPatients";
            pbPatients.Size = new Size(44, 45);
            pbPatients.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPatients.TabIndex = 17;
            pbPatients.TabStop = false;
            // 
            // card4
            // 
            card4.BackColor = Color.FromArgb(37, 45, 56);
            card4.ColumnCount = 3;
            card4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            card4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card4.Controls.Add(pictureBox6, 1, 1);
            card4.Controls.Add(lblCancelledCount, 0, 0);
            card4.Controls.Add(materialDivider6, 1, 0);
            card4.Controls.Add(lblCancelled, 0, 1);
            card4.Cursor = Cursors.Hand;
            card4.Dock = DockStyle.Fill;
            card4.Location = new Point(591, 4);
            card4.Margin = new Padding(3, 4, 3, 4);
            card4.Name = "card4";
            card4.RowCount = 3;
            card4.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card4.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card4.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card4.Size = new Size(193, 144);
            card4.TabIndex = 19;
            card4.MouseEnter += Card_MouseEnter;
            card4.MouseLeave += Card_MouseLeave;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(137, 87);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(44, 45);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // lblCancelledCount
            // 
            lblCancelledCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCancelledCount.BackColor = Color.Transparent;
            lblCancelledCount.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblCancelledCount.ForeColor = Color.FromArgb(226, 230, 237);
            lblCancelledCount.Location = new Point(0, 12);
            lblCancelledCount.Margin = new Padding(0);
            lblCancelledCount.Name = "lblCancelledCount";
            lblCancelledCount.Size = new Size(109, 71);
            lblCancelledCount.TabIndex = 15;
            lblCancelledCount.Text = "10";
            lblCancelledCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider6
            // 
            materialDivider6.Anchor = AnchorStyles.Top;
            materialDivider6.BackColor = Color.FromArgb(153, 27, 27);
            materialDivider6.Depth = 0;
            materialDivider6.Location = new Point(153, 0);
            materialDivider6.Margin = new Padding(3, 0, 3, 4);
            materialDivider6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider6.Name = "materialDivider6";
            materialDivider6.Size = new Size(11, 59);
            materialDivider6.TabIndex = 18;
            materialDivider6.Text = "materialDivider6";
            // 
            // lblCancelled
            // 
            lblCancelled.Anchor = AnchorStyles.Left;
            lblCancelled.FlatStyle = FlatStyle.System;
            lblCancelled.Font = new Font("Panton-Trial ExtraBold", 10F, FontStyle.Bold);
            lblCancelled.ForeColor = Color.FromArgb(92, 102, 114);
            lblCancelled.Location = new Point(20, 85);
            lblCancelled.Margin = new Padding(20, 0, 0, 0);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Padding = new Padding(11, 0, 0, 0);
            lblCancelled.RightToLeft = RightToLeft.No;
            lblCancelled.Size = new Size(114, 49);
            lblCancelled.TabIndex = 19;
            lblCancelled.Text = "No-Show and Cancels Today";
            lblCancelled.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 87);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 160F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 241F));
            tableLayoutPanel6.Controls.Add(cboStatus, 2, 0);
            tableLayoutPanel6.Controls.Add(dtpDate, 1, 0);
            tableLayoutPanel6.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel6.Controls.Add(chkAllDates, 4, 0);
            tableLayoutPanel6.Location = new Point(23, 240);
            tableLayoutPanel6.Margin = new Padding(23, 4, 23, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(787, 41);
            tableLayoutPanel6.TabIndex = 22;
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            cboStatus.ForeColor = Color.FromArgb(92, 102, 114);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Cancelled", "No-Show" });
            cboStatus.Location = new Point(224, 6);
            cboStatus.Margin = new Padding(3, 4, 3, 4);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(154, 29);
            cboStatus.TabIndex = 18;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(64, 7);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(154, 27);
            dtpDate.TabIndex = 17;
            dtpDate.ValueChanged += btnLoad_Click;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(92, 102, 114);
            lblDate.Location = new Point(3, 10);
            lblDate.Margin = new Padding(3, 0, 0, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(51, 21);
            lblDate.TabIndex = 7;
            lblDate.Text = "Filter:";
            // 
            // chkAllDates
            // 
            chkAllDates.Anchor = AnchorStyles.Right;
            chkAllDates.AutoSize = true;
            chkAllDates.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold);
            chkAllDates.ForeColor = Color.FromArgb(92, 102, 114);
            chkAllDates.Location = new Point(580, 8);
            chkAllDates.Margin = new Padding(3, 4, 3, 4);
            chkAllDates.Name = "chkAllDates";
            chkAllDates.Size = new Size(204, 25);
            chkAllDates.TabIndex = 19;
            chkAllDates.Text = "Display All Appoinments";
            chkAllDates.UseVisualStyleBackColor = true;
            chkAllDates.CheckedChanged += chkAllDates_CheckedChanged;
            // 
            // lblTodayTotalCount
            // 
            lblTodayTotalCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTodayTotalCount.BackColor = Color.Transparent;
            lblTodayTotalCount.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblTodayTotalCount.ForeColor = Color.FromArgb(226, 230, 237);
            lblTodayTotalCount.Location = new Point(0, 11);
            lblTodayTotalCount.Margin = new Padding(0);
            lblTodayTotalCount.Name = "lblTodayTotalCount";
            lblTodayTotalCount.Size = new Size(112, 72);
            lblTodayTotalCount.TabIndex = 15;
            lblTodayTotalCount.Text = "10";
            lblTodayTotalCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBook
            // 
            btnBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBook.BackColor = Color.FromArgb(226, 230, 237);
            btnBook.BorderColor = Color.FromArgb(108, 111, 127);
            btnBook.Cursor = Cursors.Hand;
            btnBook.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnBook.EnteredColor = Color.FromArgb(69, 85, 97);
            btnBook.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnBook.Image = null;
            btnBook.ImageAlign = ContentAlignment.MiddleLeft;
            btnBook.InactiveColor = Color.FromArgb(26, 35, 48);
            btnBook.Location = new Point(684, 0);
            btnBook.Margin = new Padding(3, 0, 3, 0);
            btnBook.Name = "btnBook";
            btnBook.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnBook.PressedColor = Color.FromArgb(108, 111, 127);
            btnBook.Size = new Size(100, 40);
            btnBook.TabIndex = 23;
            btnBook.Text = "Book";
            btnBook.TextAlignment = StringAlignment.Center;
            btnBook.Click += btnBook_Click;
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.Top;
            materialDivider1.BackColor = Color.FromArgb(92, 143, 204);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(150, 0);
            materialDivider1.Margin = new Padding(3, 0, 3, 4);
            materialDivider1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(11, 59);
            materialDivider1.TabIndex = 18;
            materialDivider1.Text = "materialDivider1";
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvAppointments, 0, 4);
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Controls.Add(tableLayoutPanel2, 0, 5);
            tblLayout.Controls.Add(tblCards, 0, 2);
            tblLayout.Controls.Add(tableLayoutPanel6, 0, 3);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 6;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 160F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tblLayout.Size = new Size(833, 740);
            tblLayout.TabIndex = 6;
            // 
            // dgvAppointments
            // 
            dgvAppointments.BackgroundColor = Color.FromArgb(108, 111, 127);
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(23, 290);
            dgvAppointments.Margin = new Padding(23, 4, 23, 4);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.Size = new Size(787, 383);
            dgvAppointments.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel1.Controls.Add(btnBook, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 31);
            tableLayoutPanel1.Margin = new Padding(23, 4, 23, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(787, 41);
            tableLayoutPanel1.TabIndex = 19;
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
            label1.Size = new Size(168, 31);
            label1.TabIndex = 1;
            label1.Text = "Appointments";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tableLayoutPanel2.Controls.Add(btnUpdateStatus, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(20, 680);
            tableLayoutPanel2.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(793, 57);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateStatus.BackColor = Color.FromArgb(226, 230, 237);
            btnUpdateStatus.BorderColor = Color.FromArgb(108, 111, 127);
            btnUpdateStatus.Cursor = Cursors.Hand;
            btnUpdateStatus.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnUpdateStatus.EnteredColor = Color.FromArgb(69, 85, 97);
            btnUpdateStatus.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnUpdateStatus.Image = null;
            btnUpdateStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateStatus.InactiveColor = Color.FromArgb(92, 102, 114);
            btnUpdateStatus.Location = new Point(690, 0);
            btnUpdateStatus.Margin = new Padding(3, 0, 3, 0);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnUpdateStatus.PressedColor = Color.FromArgb(108, 111, 127);
            btnUpdateStatus.Size = new Size(100, 40);
            btnUpdateStatus.TabIndex = 22;
            btnUpdateStatus.Text = "Update Info";
            btnUpdateStatus.TextAlignment = StringAlignment.Center;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // tblCards
            // 
            tblCards.ColumnCount = 4;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblCards.Controls.Add(card4, 3, 0);
            tblCards.Controls.Add(card3, 2, 0);
            tblCards.Controls.Add(card2, 1, 0);
            tblCards.Controls.Add(card1, 0, 0);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(23, 80);
            tblCards.Margin = new Padding(23, 4, 23, 4);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 1;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCards.Size = new Size(787, 152);
            tblCards.TabIndex = 21;
            // 
            // card3
            // 
            card3.BackColor = Color.FromArgb(37, 45, 56);
            card3.ColumnCount = 3;
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            card3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card3.Controls.Add(lblRemaining, 0, 1);
            card3.Controls.Add(pictureBox2, 1, 1);
            card3.Controls.Add(lblRemainingCount, 0, 0);
            card3.Controls.Add(materialDivider3, 1, 0);
            card3.Cursor = Cursors.Hand;
            card3.Dock = DockStyle.Fill;
            card3.Location = new Point(395, 4);
            card3.Margin = new Padding(3, 4, 3, 4);
            card3.Name = "card3";
            card3.RowCount = 3;
            card3.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card3.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card3.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card3.Size = new Size(190, 144);
            card3.TabIndex = 18;
            card3.MouseEnter += Card_MouseEnter;
            card3.MouseLeave += Card_MouseLeave;
            // 
            // lblRemaining
            // 
            lblRemaining.Anchor = AnchorStyles.Left;
            lblRemaining.FlatStyle = FlatStyle.System;
            lblRemaining.Font = new Font("Panton-Trial ExtraBold", 10F, FontStyle.Bold);
            lblRemaining.ForeColor = Color.FromArgb(92, 102, 114);
            lblRemaining.Location = new Point(23, 85);
            lblRemaining.Margin = new Padding(23, 0, 3, 0);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Padding = new Padding(11, 0, 0, 0);
            lblRemaining.RightToLeft = RightToLeft.No;
            lblRemaining.Size = new Size(87, 48);
            lblRemaining.TabIndex = 14;
            lblRemaining.Text = "Remaining Today";
            lblRemaining.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(134, 87);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // lblRemainingCount
            // 
            lblRemainingCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblRemainingCount.BackColor = Color.Transparent;
            lblRemainingCount.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblRemainingCount.ForeColor = Color.FromArgb(226, 230, 237);
            lblRemainingCount.Location = new Point(0, 12);
            lblRemainingCount.Margin = new Padding(0);
            lblRemainingCount.Name = "lblRemainingCount";
            lblRemainingCount.Size = new Size(112, 71);
            lblRemainingCount.TabIndex = 15;
            lblRemainingCount.Text = "10";
            lblRemainingCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider3
            // 
            materialDivider3.Anchor = AnchorStyles.Top;
            materialDivider3.BackColor = Color.FromArgb(146, 64, 14);
            materialDivider3.Depth = 0;
            materialDivider3.Location = new Point(150, 0);
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
            card2.ColumnCount = 3;
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            card2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card2.Controls.Add(lblCompleted, 0, 1);
            card2.Controls.Add(lblDoneTodayCount, 0, 0);
            card2.Controls.Add(materialDivider2, 1, 0);
            card2.Controls.Add(pictureBox1, 1, 1);
            card2.Cursor = Cursors.Hand;
            card2.Dock = DockStyle.Fill;
            card2.Location = new Point(199, 4);
            card2.Margin = new Padding(3, 4, 3, 4);
            card2.Name = "card2";
            card2.RowCount = 3;
            card2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card2.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card2.Size = new Size(190, 144);
            card2.TabIndex = 17;
            card2.MouseEnter += Card_MouseEnter;
            card2.MouseLeave += Card_MouseLeave;
            // 
            // lblCompleted
            // 
            lblCompleted.Anchor = AnchorStyles.Left;
            lblCompleted.FlatStyle = FlatStyle.System;
            lblCompleted.Font = new Font("Panton-Trial ExtraBold", 10F, FontStyle.Bold);
            lblCompleted.ForeColor = Color.FromArgb(92, 102, 114);
            lblCompleted.Location = new Point(23, 87);
            lblCompleted.Margin = new Padding(23, 4, 3, 4);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Padding = new Padding(11, 0, 0, 0);
            lblCompleted.RightToLeft = RightToLeft.No;
            lblCompleted.Size = new Size(87, 45);
            lblCompleted.TabIndex = 14;
            lblCompleted.Text = "Completed Today";
            lblCompleted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDoneTodayCount
            // 
            lblDoneTodayCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDoneTodayCount.BackColor = Color.Transparent;
            lblDoneTodayCount.Font = new Font("TT Interphases Pro Trl XBd", 60F, FontStyle.Bold, GraphicsUnit.World, 0);
            lblDoneTodayCount.ForeColor = Color.FromArgb(226, 230, 237);
            lblDoneTodayCount.Location = new Point(0, 13);
            lblDoneTodayCount.Margin = new Padding(0);
            lblDoneTodayCount.Name = "lblDoneTodayCount";
            lblDoneTodayCount.Size = new Size(112, 70);
            lblDoneTodayCount.TabIndex = 15;
            lblDoneTodayCount.Text = "10";
            lblDoneTodayCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialDivider2
            // 
            materialDivider2.Anchor = AnchorStyles.Top;
            materialDivider2.BackColor = Color.FromArgb(74, 168, 122);
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(150, 0);
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
            card1.ColumnCount = 3;
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            card1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            card1.Controls.Add(pbPatients, 1, 1);
            card1.Controls.Add(lblTodayTotalCount, 0, 0);
            card1.Controls.Add(materialDivider1, 1, 0);
            card1.Controls.Add(lblTodayTotal, 0, 1);
            card1.Cursor = Cursors.Hand;
            card1.Dock = DockStyle.Fill;
            card1.Location = new Point(3, 4);
            card1.Margin = new Padding(3, 4, 3, 4);
            card1.Name = "card1";
            card1.RowCount = 3;
            card1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.11111F));
            card1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.88889F));
            card1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            card1.Size = new Size(190, 144);
            card1.TabIndex = 16;
            card1.MouseEnter += Card_MouseEnter;
            card1.MouseLeave += Card_MouseLeave;
            // 
            // lblTodayTotal
            // 
            lblTodayTotal.Anchor = AnchorStyles.Left;
            lblTodayTotal.FlatStyle = FlatStyle.System;
            lblTodayTotal.Font = new Font("Panton-Trial ExtraBold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTotal.ForeColor = Color.FromArgb(92, 102, 114);
            lblTodayTotal.Location = new Point(23, 95);
            lblTodayTotal.Margin = new Padding(23, 0, 3, 0);
            lblTodayTotal.Name = "lblTodayTotal";
            lblTodayTotal.Padding = new Padding(11, 0, 0, 0);
            lblTodayTotal.RightToLeft = RightToLeft.No;
            lblTodayTotal.Size = new Size(87, 28);
            lblTodayTotal.TabIndex = 14;
            lblTodayTotal.Text = "Today Total";
            lblTodayTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AppointmentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AppointmentControl";
            Size = new Size(833, 740);
            Load += AppointmentControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbPatients).EndInit();
            card4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            card3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            card2.ResumeLayout(false);
            card1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private PictureBox pbPatients;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider4;
        private TableLayoutPanel card4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label3;
        private PictureBox pictureBox5;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider5;
        private Label label4;
        private PictureBox pictureBox6;
        private ReaLTaiizor.Controls.BigLabel lblCancelledCount;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider6;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel6;
        private ComboBox cboStatus;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private CheckBox chkAllDates;
        private ReaLTaiizor.Controls.BigLabel lblTodayTotalCount;
        private ReaLTaiizor.Controls.Button btnBook;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider1;
        private TableLayoutPanel tblLayout;
        private DataGridView dgvAppointments;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.Button btnUpdateStatus;
        private TableLayoutPanel tblCards;
        private TableLayoutPanel card3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblRemaining;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel lblRemainingCount;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider3;
        private TableLayoutPanel card2;
        private Label lblCompleted;
        private ReaLTaiizor.Controls.BigLabel lblDoneTodayCount;
        private ReaLTaiizor.Controls.MaterialDivider materialDivider2;
        private TableLayoutPanel card1;
        private Label lblTodayTotal;
        private Label lblCancelled;
    }
}
