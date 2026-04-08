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
            dtpDate = new DateTimePicker();
            btnBook = new Button();
            cboStatus = new ComboBox();
            dgvAppointments = new DataGridView();
            btnUpdateStatus = new Button();
            chkAllDates = new CheckBox();
            lblFilterbyDate = new Label();
            lblFilterbyStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(438, 102);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(121, 23);
            dtpDate.TabIndex = 0;
            dtpDate.ValueChanged += cboStatus_SelectedIndexChanged;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(45, 101);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(75, 24);
            btnBook.TabIndex = 2;
            btnBook.Text = "+ Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Cancelled", "No-Show" });
            cboStatus.Location = new Point(565, 102);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 3;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(45, 135);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(641, 369);
            dgvAppointments.TabIndex = 4;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(589, 510);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(97, 23);
            btnUpdateStatus.TabIndex = 5;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // chkAllDates
            // 
            chkAllDates.AutoSize = true;
            chkAllDates.Location = new Point(141, 104);
            chkAllDates.Name = "chkAllDates";
            chkAllDates.Size = new Size(156, 19);
            chkAllDates.TabIndex = 6;
            chkAllDates.Text = "Display All Appoinments";
            chkAllDates.UseVisualStyleBackColor = true;
            chkAllDates.CheckedChanged += chkAllDates_CheckedChanged;
            // 
            // lblFilterbyDate
            // 
            lblFilterbyDate.AutoSize = true;
            lblFilterbyDate.Location = new Point(438, 84);
            lblFilterbyDate.Name = "lblFilterbyDate";
            lblFilterbyDate.Size = new Size(79, 15);
            lblFilterbyDate.TabIndex = 7;
            lblFilterbyDate.Text = "Filter by Date:";
            // 
            // lblFilterbyStatus
            // 
            lblFilterbyStatus.AutoSize = true;
            lblFilterbyStatus.Location = new Point(565, 84);
            lblFilterbyStatus.Name = "lblFilterbyStatus";
            lblFilterbyStatus.Size = new Size(87, 15);
            lblFilterbyStatus.TabIndex = 8;
            lblFilterbyStatus.Text = "Filter by Status:";
            // 
            // AppointmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFilterbyStatus);
            Controls.Add(lblFilterbyDate);
            Controls.Add(chkAllDates);
            Controls.Add(btnUpdateStatus);
            Controls.Add(dgvAppointments);
            Controls.Add(cboStatus);
            Controls.Add(btnBook);
            Controls.Add(dtpDate);
            Name = "AppointmentControl";
            Size = new Size(729, 555);
            Load += AppointmentControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btnBook;
        private ComboBox cboStatus;
        private DataGridView dgvAppointments;
        private Button btnUpdateStatus;
        private CheckBox chkAllDates;
        private Label lblFilterbyDate;
        private Label lblFilterbyStatus;
    }
}
