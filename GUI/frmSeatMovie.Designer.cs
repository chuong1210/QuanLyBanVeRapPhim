namespace GUI
{
    partial class frmSeatMovie
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
            flowLayoutPanelSeats = new FlowLayoutPanel();
            btnConfirm = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // flowLayoutPanelSeats
            // 
            flowLayoutPanelSeats.Location = new Point(97, 12);
            flowLayoutPanelSeats.Name = "flowLayoutPanelSeats";
            flowLayoutPanelSeats.Size = new Size(523, 362);
            flowLayoutPanelSeats.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnConfirm.ForeColor = Color.FromArgb(128, 128, 255);
            btnConfirm.Image = Properties.Resources._739671;
            btnConfirm.Location = new Point(365, 686);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(845, 42);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Đặt vé";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Symbol", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Fuchsia;
            linkLabel1.Location = new Point(330, -8);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(327, 60);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Chọn chỗ ngồi";
            // 
            // frmSeatMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(linkLabel1);
            Controls.Add(btnConfirm);
            Controls.Add(flowLayoutPanelSeats);
            Name = "frmSeatMovie";
            Text = "frmSeatMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelSeats;
        private Button btnConfirm;
        private LinkLabel linkLabel1;
    }
}