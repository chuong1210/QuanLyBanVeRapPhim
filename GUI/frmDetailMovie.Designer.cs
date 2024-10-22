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
            pbPoster = new PictureBox();
            lblNameMV = new Label();
            lblTime = new Label();
            btnBookTicket = new Button();
            label2 = new Label();
            txtPhongChieu = new TextBox();
            cboGioChieu = new ComboBox();
            lbGheTrong = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
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
            // pbPoster
            // 
            pbPoster.Location = new Point(43, 146);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(177, 214);
            pbPoster.TabIndex = 1;
            pbPoster.TabStop = false;
            // 
            // lblNameMV
            // 
            lblNameMV.AutoSize = true;
            lblNameMV.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblNameMV.Location = new Point(86, 373);
            lblNameMV.Name = "lblNameMV";
            lblNameMV.Size = new Size(52, 24);
            lblNameMV.TabIndex = 2;
            lblNameMV.Text = "label2";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTime.Location = new Point(344, 181);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(140, 24);
            lblTime.TabIndex = 4;
            lblTime.Text = "Chọn giờ chiếu";
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
            btnBookTicket.Click += btnBookTicket_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(344, 283);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 7;
            label2.Text = "Phòng chiếu";
            // 
            // txtPhongChieu
            // 
            txtPhongChieu.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhongChieu.Location = new Point(507, 280);
            txtPhongChieu.Name = "txtPhongChieu";
            txtPhongChieu.ReadOnly = true;
            txtPhongChieu.Size = new Size(151, 32);
            txtPhongChieu.TabIndex = 8;
            // 
            // cboGioChieu
            // 
            cboGioChieu.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboGioChieu.FormattingEnabled = true;
            cboGioChieu.Location = new Point(507, 178);
            cboGioChieu.Name = "cboGioChieu";
            cboGioChieu.Size = new Size(151, 32);
            cboGioChieu.TabIndex = 9;
            // 
            // lbGheTrong
            // 
            lbGheTrong.AutoSize = true;
            lbGheTrong.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbGheTrong.Location = new Point(468, 100);
            lbGheTrong.Name = "lbGheTrong";
            lbGheTrong.Size = new Size(52, 24);
            lbGheTrong.TabIndex = 10;
            lbGheTrong.Text = "label2";
            // 
            // frmDetailMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbGheTrong);
            Controls.Add(cboGioChieu);
            Controls.Add(txtPhongChieu);
            Controls.Add(label2);
            Controls.Add(btnBookTicket);
            Controls.Add(lblTime);
            Controls.Add(lblNameMV);
            Controls.Add(pbPoster);
            Controls.Add(label1);
            Name = "frmDetailMovie";
            Text = "Chi tiết lịch chiếu";
            Load += frmDetailMovie_Load;
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbPoster;
        private Label lblNameMV;
        private Label lblTime;
        private Button btnBookTicket;
        private Label label2;
        private TextBox txtPhongChieu;
        private ComboBox cboGioChieu;
        private Label lbGheTrong;
    }
}