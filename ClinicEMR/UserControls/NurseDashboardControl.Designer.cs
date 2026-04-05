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
            lblWelcome = new Label();
            lblApptCount = new Label();
            dgvTodayAppts = new DataGridView();
            lblPatientCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppts).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.FlatStyle = FlatStyle.System;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlText;
            lblWelcome.Location = new Point(21, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(331, 40);
            lblWelcome.TabIndex = 0;
            // 
            // lblApptCount
            // 
            lblApptCount.FlatStyle = FlatStyle.System;
            lblApptCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApptCount.ForeColor = SystemColors.ControlText;
            lblApptCount.Location = new Point(21, 99);
            lblApptCount.Name = "lblApptCount";
            lblApptCount.Size = new Size(100, 90);
            lblApptCount.TabIndex = 1;
            // 
            // dgvTodayAppts
            // 
            dgvTodayAppts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodayAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodayAppts.Location = new Point(21, 192);
            dgvTodayAppts.Name = "dgvTodayAppts";
            dgvTodayAppts.ReadOnly = true;
            dgvTodayAppts.Size = new Size(742, 296);
            dgvTodayAppts.TabIndex = 2;
            // 
            // lblPatientCount
            // 
            lblPatientCount.FlatStyle = FlatStyle.System;
            lblPatientCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientCount.ForeColor = SystemColors.ControlText;
            lblPatientCount.Location = new Point(138, 99);
            lblPatientCount.Name = "lblPatientCount";
            lblPatientCount.Size = new Size(100, 90);
            lblPatientCount.TabIndex = 3;
            // 
            // NurseDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPatientCount);
            Controls.Add(dgvTodayAppts);
            Controls.Add(lblApptCount);
            Controls.Add(lblWelcome);
            Name = "NurseDashboardControl";
            Size = new Size(782, 507);
            Load += NurseDashboardControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Label lblApptCount;
        private DataGridView dgvTodayAppts;
        private Label lblPatientCount;
    }
}
