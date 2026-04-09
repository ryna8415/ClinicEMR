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
            dtpDate = new DateTimePicker();
            btnGenerate = new Button();
            lblCount = new Label();
            dgvReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            dtpDate.Location = new Point(32, 28);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(240, 23);
            dtpDate.TabIndex = 0;
            btnGenerate.Location = new Point(288, 27);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(104, 25);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(32, 68);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 19);
            lblCount.TabIndex = 2;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(32, 103);
            dgvReport.Name = "dgvReport";
            dgvReport.Size = new Size(709, 362);
            dgvReport.TabIndex = 3;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvReport);
            Controls.Add(lblCount);
            Controls.Add(btnGenerate);
            Controls.Add(dtpDate);
            Name = "ReportControl";
            Size = new Size(779, 592);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btnGenerate;
        private Label lblCount;
        private DataGridView dgvReport;
    }
}
