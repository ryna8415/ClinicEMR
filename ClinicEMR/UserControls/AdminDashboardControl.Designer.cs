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
            tblLayout = new TableLayoutPanel();
            tblHeader = new TableLayoutPanel();
            lblWelcome = new Label();
            tblCards = new TableLayoutPanel();
            lblTotalPatients = new Label();
            lblTotalUsers = new Label();
            lblTodayVisits = new Label();
            tblContent = new TableLayoutPanel();
            lblRecentLogins = new Label();
            dgvRecentLogins = new DataGridView();
            tblLayout.SuspendLayout();
            tblHeader.SuspendLayout();
            tblCards.SuspendLayout();
            tblContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogins).BeginInit();
            SuspendLayout();
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(tblHeader, 0, 0);
            tblLayout.Controls.Add(tblCards, 0, 1);
            tblLayout.Controls.Add(tblContent, 0, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(0, 0);
            tblLayout.Margin = new Padding(20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 4;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayout.Size = new Size(787, 522);
            tblLayout.TabIndex = 2;
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
            tblHeader.Size = new Size(747, 57);
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
            // tblCards
            // 
            tblCards.ColumnCount = 3;
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblCards.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblCards.ColumnStyles.Add(new ColumnStyle());
            tblCards.Controls.Add(lblTodayVisits, 2, 0);
            tblCards.Controls.Add(lblTotalUsers, 1, 0);
            tblCards.Controls.Add(lblTotalPatients, 0, 0);
            tblCards.Dock = DockStyle.Fill;
            tblCards.Location = new Point(20, 83);
            tblCards.Margin = new Padding(20, 3, 20, 3);
            tblCards.Name = "tblCards";
            tblCards.RowCount = 1;
            tblCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCards.Size = new Size(747, 114);
            tblCards.TabIndex = 1;
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.Anchor = AnchorStyles.Left;
            lblTotalPatients.FlatStyle = FlatStyle.System;
            lblTotalPatients.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPatients.ForeColor = SystemColors.ControlText;
            lblTotalPatients.Location = new Point(3, 12);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(100, 90);
            lblTotalPatients.TabIndex = 13;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.Anchor = AnchorStyles.Left;
            lblTotalUsers.FlatStyle = FlatStyle.System;
            lblTotalUsers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.ForeColor = SystemColors.ControlText;
            lblTotalUsers.Location = new Point(123, 12);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(100, 90);
            lblTotalUsers.TabIndex = 14;
            // 
            // lblTodayVisits
            // 
            lblTodayVisits.Anchor = AnchorStyles.Left;
            lblTodayVisits.FlatStyle = FlatStyle.System;
            lblTodayVisits.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayVisits.ForeColor = SystemColors.ControlText;
            lblTodayVisits.Location = new Point(243, 12);
            lblTodayVisits.Name = "lblTodayVisits";
            lblTodayVisits.Size = new Size(100, 90);
            lblTodayVisits.TabIndex = 15;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 1;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblContent.Controls.Add(dgvRecentLogins, 0, 1);
            tblContent.Controls.Add(lblRecentLogins, 0, 0);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(20, 203);
            tblContent.Margin = new Padding(20, 3, 20, 3);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 2;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tblContent.Size = new Size(747, 296);
            tblContent.TabIndex = 2;
            // 
            // lblRecentLogins
            // 
            lblRecentLogins.Anchor = AnchorStyles.Left;
            lblRecentLogins.AutoSize = true;
            lblRecentLogins.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentLogins.Location = new Point(3, 4);
            lblRecentLogins.Name = "lblRecentLogins";
            lblRecentLogins.Size = new Size(145, 20);
            lblRecentLogins.TabIndex = 16;
            lblRecentLogins.Text = "Recent Staff Logins";
            // 
            // dgvRecentLogins
            // 
            dgvRecentLogins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentLogins.Dock = DockStyle.Fill;
            dgvRecentLogins.Location = new Point(3, 32);
            dgvRecentLogins.Name = "dgvRecentLogins";
            dgvRecentLogins.Size = new Size(741, 261);
            dgvRecentLogins.TabIndex = 17;
            // 
            // AdminDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblLayout);
            Name = "AdminDashboardControl";
            Size = new Size(787, 522);
            Load += AdminDashboardControl_Load;
            tblLayout.ResumeLayout(false);
            tblHeader.ResumeLayout(false);
            tblCards.ResumeLayout(false);
            tblContent.ResumeLayout(false);
            tblContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogins).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblLayout;
        private TableLayoutPanel tblHeader;
        private Label lblWelcome;
        private TableLayoutPanel tblCards;
        private Label lblTotalPatients;
        private Label lblTotalUsers;
        private Label lblTodayVisits;
        private TableLayoutPanel tblContent;
        private Label lblRecentLogins;
        private DataGridView dgvRecentLogins;
    }
}
