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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeatMovie));
            btnConfirm = new Button();
            linkLabel2 = new LinkLabel();
            flowLayoutPanelSeats = new FlowLayoutPanel();
            lblThongtin = new Label();
            pcPoster = new PictureBox();
            lblLich = new Label();
            lbPhong = new Label();
            pnSelect = new Panel();
            label3 = new Label();
            button3 = new Button();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)pcPoster).BeginInit();
            pnSelect.SuspendLayout();
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
            linkLabel2.Font = new Font("Bahnschrift SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            linkLabel2.LinkColor = Color.BlueViolet;
            linkLabel2.Location = new Point(162, 12);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(316, 48);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "CHỌN CHỖ NGỒI";
            linkLabel2.TextAlign = ContentAlignment.TopCenter;
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
            pcPoster.BackColor = Color.Transparent;
            pcPoster.BackgroundImage = Properties.Resources._0f1a56151393071_630b7f719ad62;
            pcPoster.BackgroundImageLayout = ImageLayout.Zoom;
            pcPoster.Location = new Point(30, 483);
            pcPoster.Name = "pcPoster";
            pcPoster.Size = new Size(196, 138);
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
            // lbPhong
            // 
            lbPhong.AutoSize = true;
            lbPhong.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbPhong.Location = new Point(683, 9);
            lbPhong.Name = "lbPhong";
            lbPhong.Size = new Size(53, 24);
            lbPhong.TabIndex = 7;
            lbPhong.Text = "label1";
            // 
            // pnSelect
            // 
            pnSelect.BorderStyle = BorderStyle.FixedSingle;
            pnSelect.Controls.Add(label3);
            pnSelect.Controls.Add(button3);
            pnSelect.Controls.Add(label2);
            pnSelect.Controls.Add(button2);
            pnSelect.Controls.Add(label1);
            pnSelect.Controls.Add(button1);
            pnSelect.Location = new Point(413, 451);
            pnSelect.Name = "pnSelect";
            pnSelect.Size = new Size(211, 139);
            pnSelect.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(64, 90);
            label3.Name = "label3";
            label3.Size = new Size(143, 22);
            label3.TabIndex = 5;
            label3.Text = "Ghế đã được đặt";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Red;
            button3.Location = new Point(25, 88);
            button3.Name = "button3";
            button3.Size = new Size(33, 29);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(64, 57);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 3;
            label2.Text = "Ghế trống";
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(25, 55);
            button2.Name = "button2";
            button2.Size = new Size(33, 29);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(64, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 22);
            label1.TabIndex = 1;
            label1.Text = "Ghế đang chọn";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(25, 18);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Bahnschrift SemiBold SemiConden", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTongTien.Location = new Point(648, 348);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(53, 24);
            lblTongTien.TabIndex = 9;
            lblTongTien.Text = "label1";
            // 
            // frmSeatMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblTongTien);
            Controls.Add(pnSelect);
            Controls.Add(lbPhong);
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
            pnSelect.ResumeLayout(false);
            pnSelect.PerformLayout();
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
        private Label lbPhong;
        private Panel pnSelect;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label1;
        private Label label3;
        private Button button3;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label lblTongTien;
    }
}