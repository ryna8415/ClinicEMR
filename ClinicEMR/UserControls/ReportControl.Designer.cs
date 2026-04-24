namespace ClinicEMR.UserControls
{
    partial class ReportControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportControl));
            lblCount = new Label();
            tblLayout = new TableLayoutPanel();
            dgvReport = new DataGridView();
            tblHeader = new TableLayoutPanel();
            btnPrint = new ReaLTaiizor.Controls.Button();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            btnGenerate = new ReaLTaiizor.Controls.Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            tblHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(37, 91);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 23);
            lblCount.TabIndex = 2;
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(226, 230, 237);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvReport, 0, 3);
            tblLayout.Controls.Add(tblHeader, 0, 2);
            tblLayout.Controls.Add(tableLayoutPanel1, 0, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(23, 27, 23, 27);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 5;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tblLayout.Size = new Size(890, 789);
            tblLayout.TabIndex = 3;
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = Color.FromArgb(108, 111, 127);
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(23, 156);
            dgvReport.Margin = new Padding(23, 4, 23, 4);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(844, 522);
            dgvReport.TabIndex = 7;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 4;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.6777248F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.85782F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.772666F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.6021652F));
            tblHeader.Controls.Add(btnPrint, 3, 0);
            tblHeader.Controls.Add(dtpDate, 1, 0);
            tblHeader.Controls.Add(lblDate, 0, 0);
            tblHeader.Controls.Add(btnGenerate, 2, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(23, 80);
            tblHeader.Margin = new Padding(23, 4, 23, 4);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tblHeader.Size = new Size(844, 68);
            tblHeader.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(226, 230, 237);
            btnPrint.BorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.EnteredColor = Color.FromArgb(69, 85, 97);
            btnPrint.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnPrint.Image = null;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.InactiveColor = Color.FromArgb(92, 102, 114);
            btnPrint.Location = new Point(750, 14);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnPrint.PressedColor = Color.FromArgb(108, 111, 127);
            btnPrint.Size = new Size(91, 40);
            btnPrint.TabIndex = 21;
            btnPrint.Text = "Print";
            btnPrint.TextAlignment = StringAlignment.Center;
            btnPrint.Click += btnPrint_Click;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Left;
            dtpDate.CalendarForeColor = Color.FromArgb(92, 102, 114);
            dtpDate.CalendarMonthBackground = Color.FromArgb(49, 62, 80);
            dtpDate.CalendarTitleBackColor = Color.FromArgb(58, 67, 94);
            dtpDate.CalendarTitleForeColor = Color.FromArgb(226, 230, 237);
            dtpDate.CalendarTrailingForeColor = Color.FromArgb(69, 85, 97);
            dtpDate.Cursor = Cursors.Hand;
            dtpDate.Location = new Point(110, 20);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.MaximumSize = new Size(434, 30);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(246, 27);
            dtpDate.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("TT Intrphss Pr Trl Cnd", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(92, 102, 114);
            lblDate.Location = new Point(3, 23);
            lblDate.Margin = new Padding(3, 0, 0, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(99, 21);
            lblDate.TabIndex = 6;
            lblDate.Text = "Report Date:";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Left;
            btnGenerate.BackColor = Color.FromArgb(226, 230, 237);
            btnGenerate.BorderColor = Color.FromArgb(108, 111, 127);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.EnteredBorderColor = Color.FromArgb(108, 111, 127);
            btnGenerate.EnteredColor = Color.FromArgb(69, 85, 97);
            btnGenerate.Font = new Font("Panton Narrow-Trial SemiBold", 10F);
            btnGenerate.Image = null;
            btnGenerate.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenerate.InactiveColor = Color.FromArgb(26, 35, 48);
            btnGenerate.Location = new Point(362, 14);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.PressedBorderColor = Color.FromArgb(108, 111, 127);
            btnGenerate.PressedColor = Color.FromArgb(108, 111, 127);
            btnGenerate.Size = new Size(91, 40);
            btnGenerate.TabIndex = 20;
            btnGenerate.Text = "Generate";
            btnGenerate.TextAlignment = StringAlignment.Center;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.3184886F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.68151F));
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(23, 31);
            tableLayoutPanel1.Margin = new Padding(23, 4, 23, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(844, 41);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 41);
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
            label1.Location = new Point(39, 5);
            label1.Name = "label1";
            label1.Size = new Size(392, 31);
            label1.TabIndex = 1;
            label1.Text = "Generate Patient Report Summary";
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Controls.Add(lblCount);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportControl";
            Size = new Size(890, 789);
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCount;
        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private DataGridView dgvReport;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox3;
        private Label label1;
        private ReaLTaiizor.Controls.Button btnGenerate;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private ReaLTaiizor.Controls.Button btnPrint;
    }
}
