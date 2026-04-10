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
            lblCount = new Label();
            tblLayout = new TableLayoutPanel();
            dgvReport = new DataGridView();
            tblHeader = new TableLayoutPanel();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            btnGenerate = new Button();
            btnPrint = new Button();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            tblHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(32, 68);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 19);
            lblCount.TabIndex = 2;
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvReport, 0, 1);
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.Size = new Size(779, 592);
            tblLayout.TabIndex = 3;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(20, 83);
            dgvReport.Margin = new Padding(20, 3, 20, 3);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(739, 426);
            dgvReport.TabIndex = 7;
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 4;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8552094F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.939106F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1028423F));
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1028423F));
            tblHeader.Controls.Add(dtpDate, 1, 1);
            tblHeader.Controls.Add(lblDate, 0, 1);
            tblHeader.Controls.Add(btnGenerate, 2, 1);
            tblHeader.Controls.Add(btnPrint, 3, 1);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 2;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.Size = new Size(739, 57);
            tblHeader.TabIndex = 0;
            // 
            // dtpDate
            // 
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Location = new Point(98, 31);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(392, 23);
            dtpDate.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 35);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(77, 15);
            lblDate.TabIndex = 6;
            lblDate.Text = "Choose Date:";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Right;
            btnGenerate.Location = new Point(620, 28);
            btnGenerate.Margin = new Padding(0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(119, 29);
            btnGenerate.TabIndex = 7;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Right;
            btnPrint.Location = new Point(620, 28);
            btnPrint.Margin = new Padding(0);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(119, 29);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Controls.Add(lblCount);
            Name = "ReportControl";
            Size = new Size(779, 592);
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            tblHeader.ResumeLayout(false);
            tblHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCount;
        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private Button btnGenerate;
        private DataGridView dgvReport;
        private Button btnPrint;
    }
}
