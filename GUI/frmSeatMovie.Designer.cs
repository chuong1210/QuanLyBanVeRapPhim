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
            btnConfirm = new Button();
            linkLabel2 = new LinkLabel();
            flowLayoutPanelSeats = new FlowLayoutPanel();
            lblThongtin = new Label();
            pcPoster = new PictureBox();
            lblLich = new Label();
            ((System.ComponentModel.ISupportInitialize)pcPoster).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackgroundImage = Properties.Resources.th;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnConfirm.ForeColor = Color.FromArgb(128, 128, 255);
            btnConfirm.ImageAlign = ContentAlignment.TopCenter;
            btnConfirm.Location = new Point(251, 667);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(845, 42);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Đặt vé";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Symbol", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Fuchsia;
            linkLabel2.Location = new Point(162, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(327, 60);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Chọn chỗ ngồi";
            // 
            // flowLayoutPanelSeats
            // 
            flowLayoutPanelSeats.Location = new Point(0, 72);
            flowLayoutPanelSeats.Name = "flowLayoutPanelSeats";
            flowLayoutPanelSeats.Size = new Size(1192, 329);
            flowLayoutPanelSeats.TabIndex = 0;
            flowLayoutPanelSeats.Paint += flowLayoutPanelSeats_Paint;
            // 
            // lblThongtin
            // 
            lblThongtin.AutoSize = true;
            lblThongtin.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblThongtin.Location = new Point(662, 9);
            lblThongtin.Name = "lblThongtin";
            lblThongtin.Size = new Size(92, 24);
            lblThongtin.TabIndex = 4;
            lblThongtin.Text = "Thông tin";
            // 
            // pcPoster
            // 
            pcPoster.BackgroundImage = Properties.Resources._0f1a56151393071_630b7f719ad62;
            pcPoster.BackgroundImageLayout = ImageLayout.Zoom;
            pcPoster.Location = new Point(64, 451);
            pcPoster.Name = "pcPoster";
            pcPoster.Size = new Size(78, 118);
            pcPoster.TabIndex = 5;
            pcPoster.TabStop = false;
            // 
            // lblLich
            // 
            lblLich.AutoSize = true;
            lblLich.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblLich.Location = new Point(683, 33);
            lblLich.Name = "lblLich";
            lblLich.Size = new Size(53, 24);
            lblLich.TabIndex = 6;
            lblLich.Text = "label1";
            // 
            // frmSeatMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblLich);
            Controls.Add(pcPoster);
            Controls.Add(btnConfirm);
            Controls.Add(linkLabel2);
            Controls.Add(lblThongtin);
            Controls.Add(flowLayoutPanelSeats);
            Name = "frmSeatMovie";
            Text = "frmSeatMovie";
            Load += frmSeatMovie_Load;
            ((System.ComponentModel.ISupportInitialize)pcPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConfirm;
        private LinkLabel linkLabel2;
        private FlowLayoutPanel flowLayoutPanelSeats;
        private Label lblThongtin;
        private PictureBox pcPoster;
        private Label lblLich;
    }
}