namespace ClinicEMR.Forms
{
    partial class MainShellForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new FlowLayoutPanel();
            pnlContent = new Panel();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Gray;
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.FlowDirection = FlowDirection.TopDown;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 641);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.ControlDark;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(200, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(884, 641);
            pnlContent.TabIndex = 0;
            // 
            // MainShellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 641);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Name = "MainShellForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainShellForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlSidebar;
        private Panel pnlContent;
    }
}