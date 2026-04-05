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
            dgvMyAppts = new DataGridView();
            lblMyPatients = new Label();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMyAppts).BeginInit();
            SuspendLayout();
            // 
            // dgvMyAppts
            // 
            dgvMyAppts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyAppts.Location = new Point(25, 205);
            dgvMyAppts.Name = "dgvMyAppts";
            dgvMyAppts.ReadOnly = true;
            dgvMyAppts.Size = new Size(742, 296);
            dgvMyAppts.TabIndex = 6;
            // 
            // lblMyPatients
            // 
            lblMyPatients.FlatStyle = FlatStyle.System;
            lblMyPatients.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyPatients.ForeColor = SystemColors.ControlText;
            lblMyPatients.Location = new Point(25, 112);
            lblMyPatients.Name = "lblMyPatients";
            lblMyPatients.Size = new Size(100, 90);
            lblMyPatients.TabIndex = 5;
            // 
            // lblWelcome
            // 
            lblWelcome.FlatStyle = FlatStyle.System;
            lblWelcome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ControlText;
            lblWelcome.Location = new Point(25, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(317, 40);
            lblWelcome.TabIndex = 4;
            // 
            // DoctorDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvMyAppts);
            Controls.Add(lblMyPatients);
            Controls.Add(lblWelcome);
            Name = "DoctorDashboardControl";
            Size = new Size(792, 535);
            Load += DoctorDashboardControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyAppts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMyAppts;
        private Label lblMyPatients;
        private Label lblWelcome;
    }
}
