using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;


namespace ClinicEMR.UserControls

{
    public partial class PatientListControl : UserControl
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddNew = new Button();
            dgvPatients = new DataGridView();
            btnOpen = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(41, 55);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(473, 30);
            txtSearch.TabIndex = 2;
            txtSearch.Click += btnSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(520, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(622, 56);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(96, 30);
            btnAddNew.TabIndex = 5;
            btnAddNew.Text = "+ Add Patient";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(41, 102);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(677, 340);
            dgvPatients.TabIndex = 6;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(622, 461);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(96, 30);
            btnOpen.TabIndex = 7;
            btnOpen.Text = "Open Record";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpenRecord_Click;
            // 
            // PatientListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOpen);
            Controls.Add(dgvPatients);
            Controls.Add(btnAddNew);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "PatientListControl";
            Size = new Size(747, 523);
            Load += PatientListControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();

            #endregion
        }
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAddNew;
        private DataGridView dgvPatients;
        private Button btnOpen;
    }

}
