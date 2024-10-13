namespace GUI
{
    partial class frmDetailMovie
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblNameMV = new Label();
            lblTime = new Label();
            lblMoTa = new Label();
            btnBookTicket = new Button();
            btnRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 255);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Bahnschrift SemiBold SemiConden", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 83);
            label1.TabIndex = 0;
            label1.Text = "Thông tin chi tiết phim";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 214);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblNameMV
            // 
            lblNameMV.AutoSize = true;
            lblNameMV.Location = new Point(43, 372);
            lblNameMV.Name = "lblNameMV";
            lblNameMV.Size = new Size(50, 20);
            lblNameMV.TabIndex = 2;
            lblNameMV.Text = "label2";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(345, 146);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(50, 20);
            lblTime.TabIndex = 4;
            lblTime.Text = "label4";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(345, 238);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(86, 20);
            lblMoTa.TabIndex = 5;
            lblMoTa.Text = "Mô tả phim";
            // 
            // btnBookTicket
            // 
            btnBookTicket.BackgroundImage = Properties.Resources.th;
            btnBookTicket.BackgroundImageLayout = ImageLayout.Stretch;
            btnBookTicket.Cursor = Cursors.Hand;
            btnBookTicket.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnBookTicket.ForeColor = Color.MediumSlateBlue;
            btnBookTicket.Location = new Point(334, 386);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(374, 42);
            btnBookTicket.TabIndex = 6;
            btnBookTicket.Text = "Đặt vé";
            btnBookTicket.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.BackgroundImage = Properties.Resources.th;
            btnRoom.BackgroundImageLayout = ImageLayout.Stretch;
            btnRoom.Cursor = Cursors.Hand;
            btnRoom.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnRoom.ForeColor = Color.MediumSlateBlue;
            btnRoom.Location = new Point(504, 133);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(180, 42);
            btnRoom.TabIndex = 7;
            btnRoom.Text = "Phòng 02";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // frmDetailMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRoom);
            Controls.Add(btnBookTicket);
            Controls.Add(lblMoTa);
            Controls.Add(lblTime);
            Controls.Add(lblNameMV);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmDetailMovie";
            Text = "frmDetailMovie";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblNameMV;
        private Label lblTime;
        private Label lblMoTa;
        private Button btnBookTicket;
        private Button btnRoom;
    }
}