namespace GUI
{
    partial class frmLoading
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22.2F, FontStyle.Bold);
            label1.Location = new Point(63, 231);
            label1.Name = "label1";
            label1.Size = new Size(215, 45);
            label1.TabIndex = 1;
            label1.Text = "Loading....";
            // 
            // guna2ProgressIndicator1
            // 
            guna2ProgressIndicator1.Location = new Point(395, 176);
            guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            guna2ProgressIndicator1.ProgressColor = SystemColors.Menu;
            guna2ProgressIndicator1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressIndicator1.Size = new Size(185, 171);
            guna2ProgressIndicator1.TabIndex = 2;
            // 
            // frmLoading
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(739, 450);
            ControlBox = false;
            Controls.Add(guna2ProgressIndicator1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoading";
            Text = "frmLoading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
    }
}