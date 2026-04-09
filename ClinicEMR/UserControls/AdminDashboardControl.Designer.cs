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
            lblTotalUsers = new Label();
            lblTotalPatients = new Label();
            lblWelcome = new Label();
            lblTodayVisits = new Label();
            lblRecentLogins = new Label();
            dgvRecentLogins = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogins).BeginInit();
            SuspendLayout();
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.FlatStyle = FlatStyle.System;
            lblTotalUsers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.ForeColor = SystemColors.ControlText;
            lblTotalUsers.Location = new Point(139, 106);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(100, 90);
            lblTotalUsers.TabIndex = 7;
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.FlatStyle = FlatStyle.System;
            lblTotalPatients.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPatients.ForeColor = SystemColors.ControlText;
            lblTotalPatients.Location = new Point(22, 106);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(100, 90);
            lblTotalPatients.TabIndex = 5;
            // 
            // lblWelcome
            // 
            lblWelcome.FlatStyle = FlatStyle.System;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlText;
            lblWelcome.Location = new Point(22, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(323, 40);
            lblWelcome.TabIndex = 4;
            // 
            // lblTodayVisits
            // 
            lblTodayVisits.FlatStyle = FlatStyle.System;
            lblTodayVisits.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayVisits.ForeColor = SystemColors.ControlText;
            lblTodayVisits.Location = new Point(245, 106);
            lblTodayVisits.Name = "lblTodayVisits";
            lblTodayVisits.Size = new Size(100, 90);
            lblTodayVisits.TabIndex = 8;
            // 
            // lblRecentLogins
            // 
            lblRecentLogins.AutoSize = true;
            lblRecentLogins.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentLogins.Location = new Point(22, 217);
            lblRecentLogins.Name = "lblRecentLogins";
            lblRecentLogins.Size = new Size(145, 20);
            lblRecentLogins.TabIndex = 9;
            lblRecentLogins.Text = "Recent Staff Logins";
            // 
            // dgvRecentLogins
            // 
            dgvRecentLogins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentLogins.Location = new Point(22, 250);
            dgvRecentLogins.Name = "dgvRecentLogins";
            dgvRecentLogins.Size = new Size(743, 235);
            dgvRecentLogins.TabIndex = 10;
            // 
            // AdminDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvRecentLogins);
            Controls.Add(lblRecentLogins);
            Controls.Add(lblTodayVisits);
            Controls.Add(lblTotalUsers);
            Controls.Add(lblTotalPatients);
            Controls.Add(lblWelcome);
            Name = "AdminDashboardControl";
            Size = new Size(787, 522);
            Load += AdminDashboardControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecentLogins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalUsers;
        private Label lblTotalPatients;
        private Label lblWelcome;
        private Label lblTodayVisits;
        private Label lblRecentLogins;
        private DataGridView dgvRecentLogins;
    }
}
