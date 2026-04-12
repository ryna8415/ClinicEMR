namespace ClinicEMR.UserControls
{
    partial class NurseDashboardControl
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
            tblHeader = new TableLayoutPanel();
            lblWelcome = new Label();
            tblLayout = new TableLayoutPanel();
            dgvTodayAppts = new DataGridView();
            tblCards = new TableLayoutPanel();
            lblPatientCount = new Label();
            lblApptCount = new Label();
            tblHeader.SuspendLayout();
            tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppts).BeginInit();
            tblCards.SuspendLayout();
            SuspendLayout();
            // 
            // tblHeader
            // 
            tblHeader.ColumnCount = 1;
            tblHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.1186F));
            tblHeader.Controls.Add(lblWelcome, 0, 0);
            tblHeader.Dock = DockStyle.Fill;
            tblHeader.Location = new Point(20, 20);
            tblHeader.Margin = new Padding(20, 20, 20, 3);
            tblHeader.Name = "tblHeader";
            tblHeader.RowCount = 1;
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeader.Size = new Size(742, 57);
            tblHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Left;
            lblWelcome.FlatStyle = FlatStyle.System;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlText;
            lblWelcome.Location = new Point(3, 8);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(331, 40);
            lblWelcome.TabIndex = 5;
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(dgvTodayAppts, 0, 2);
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tblCards, 0, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 4;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.Size = new Size(782, 507);
            tblLayout.TabIndex = 1;
            // 
            // dgvTodayAppts
            // 
            dgvTodayAppts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodayAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodayAppts.Dock = DockStyle.Fill;
            dgvTodayAppts.Location = new Point(20, 203);
            dgvTodayAppts.Margin = new Padding(20, 3, 20, 3);
            dgvTodayAppts.Name = "dgvTodayAppts";
            dgvTodayAppts.ReadOnly = true;
            dgvTodayAppts.Size = new Size(742, 281);
            dgvTodayAppts.TabIndex = 7;
            // 
            // tblCards
            // 
            tblCards.ColumnCount = 3;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblCards.ColumnStyles.Add(new ColumnStyle());
            tblCards.Controls.Add(lblPatientCount, 1, 0);
            tblCards.Controls.Add(lblApptCount, 0, 0);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(20, 83);
            tblCards.Margin = new Padding(20, 3, 20, 3);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 1;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCards.Size = new Size(742, 114);
            tblCards.TabIndex = 1;
            // 
            // lblPatientCount
            // 
            lblPatientCount.Anchor = AnchorStyles.Left;
            lblPatientCount.FlatStyle = FlatStyle.System;
            lblPatientCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientCount.ForeColor = SystemColors.ControlText;
            lblPatientCount.Location = new Point(123, 12);
            lblPatientCount.Name = "lblPatientCount";
            lblPatientCount.Size = new Size(100, 90);
            lblPatientCount.TabIndex = 8;
            // 
            // lblApptCount
            // 
            lblApptCount.Anchor = AnchorStyles.Left;
            lblApptCount.FlatStyle = FlatStyle.System;
            lblApptCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApptCount.ForeColor = SystemColors.ControlText;
            lblApptCount.Location = new Point(3, 12);
            lblApptCount.Name = "lblApptCount";
            lblApptCount.Size = new Size(100, 90);
            lblApptCount.TabIndex = 6;
            // 
            // NurseDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "NurseDashboardControl";
            Size = new Size(782, 507);
            Load += NurseDashboardControl_Load;
            tblHeader.ResumeLayout(false);
            tblLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppts).EndInit();
            tblCards.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tblHeader;
        private TableLayoutPanel tblLayout;
        private Label lblWelcome;
        private TableLayoutPanel tblCards;
        private Label lblApptCount;
        private Label lblPatientCount;
        private DataGridView dgvTodayAppts;
    }
}
