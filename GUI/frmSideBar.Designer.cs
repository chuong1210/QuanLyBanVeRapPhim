namespace GUI
{
    partial class frmSideBar
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
            sidebarPanel = new Panel();
            pcLogo = new PictureBox();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.White;
            sidebarPanel.BackgroundImage = Properties.Resources.wp7124690;
            sidebarPanel.BackgroundImageLayout = ImageLayout.Stretch;
            sidebarPanel.BorderStyle = BorderStyle.Fixed3D;
            sidebarPanel.Controls.Add(pcLogo);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(132, 450);
            sidebarPanel.TabIndex = 1;
            // 
            // pcLogo
            // 
            pcLogo.BackColor = Color.Transparent;
            pcLogo.BackgroundImage = Properties.Resources.logo_huit;
            pcLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pcLogo.Location = new Point(3, 27);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(114, 99);
            pcLogo.TabIndex = 0;
            pcLogo.TabStop = false;
            // 
            // frmSideBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sidebarPanel);
            Name = "frmSideBar";
            Text = "frmClient";
            FormClosing += frmClient_FormClosing;
            sidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private PictureBox pcLogo;
    }
}