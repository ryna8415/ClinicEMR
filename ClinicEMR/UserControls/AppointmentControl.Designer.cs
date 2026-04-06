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
            btnLoad = new Button();
            btnBook = new Button();
            cboStatus = new ComboBox();
            dgvAppointments = new DataGridView();
            btnUpdateStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(565, 25);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(121, 23);
            dtpDate.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(474, 25);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(474, 54);
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
            cboStatus.Location = new Point(565, 56);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 3;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(45, 98);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(641, 406);
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
            // AppointmentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdateStatus);
            Controls.Add(dgvAppointments);
            Controls.Add(cboStatus);
            Controls.Add(btnBook);
            Controls.Add(btnLoad);
            Controls.Add(dtpDate);
            Name = "AppointmentControl";
            Size = new Size(729, 555);
            Load += AppointmentControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btnLoad;
        private Button btnBook;
        private ComboBox cboStatus;
        private DataGridView dgvAppointments;
        private Button btnUpdateStatus;
    }
}
