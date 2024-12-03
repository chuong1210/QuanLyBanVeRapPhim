namespace GUI.DataControl.DataUser
{
    partial class ShowTimeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTimeUC));
            panel1 = new Panel();
            button1 = new Button();
            txtSearchShowTime = new TextBox();
            btnShowShowTime = new Button();
            btnUpdateShowTime = new Button();
            btnDeleteShowTime = new Button();
            btnInsertShowTime = new Button();
            panel2 = new Panel();
            txtTrangThaiChoNgoi = new TextBox();
            cboPhim = new ComboBox();
            txtGiaVe = new TextBox();
            label4 = new Label();
            cboPhong = new ComboBox();
            dtmThoiGianChieu = new DateTimePicker();
            txtMaLichChieu = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgvShowTime = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowTime).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSearchShowTime);
            panel1.Controls.Add(btnShowShowTime);
            panel1.Controls.Add(btnUpdateShowTime);
            panel1.Controls.Add(btnDeleteShowTime);
            panel1.Controls.Add(btnInsertShowTime);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1562, 69);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(963, 15);
            button1.Name = "button1";
            button1.Size = new Size(33, 29);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            // 
            // txtSearchShowTime
            // 
            txtSearchShowTime.Location = new Point(749, 17);
            txtSearchShowTime.Name = "txtSearchShowTime";
            txtSearchShowTime.Size = new Size(196, 27);
            txtSearchShowTime.TabIndex = 12;
            txtSearchShowTime.Text = "Tìm theo tên phim ...";
            // 
            // btnShowShowTime
            // 
            btnShowShowTime.Location = new Point(530, 0);
            btnShowShowTime.Name = "btnShowShowTime";
            btnShowShowTime.Size = new Size(94, 69);
            btnShowShowTime.TabIndex = 11;
            btnShowShowTime.Text = "Xem";
            btnShowShowTime.UseVisualStyleBackColor = true;
            // 
            // btnUpdateShowTime
            // 
            btnUpdateShowTime.Location = new Point(349, 0);
            btnUpdateShowTime.Name = "btnUpdateShowTime";
            btnUpdateShowTime.Size = new Size(94, 69);
            btnUpdateShowTime.TabIndex = 10;
            btnUpdateShowTime.Text = "Sửa";
            btnUpdateShowTime.UseVisualStyleBackColor = true;
            btnUpdateShowTime.Click += btnUpdateShowTime_Click;
            // 
            // btnDeleteShowTime
            // 
            btnDeleteShowTime.Location = new Point(174, 0);
            btnDeleteShowTime.Name = "btnDeleteShowTime";
            btnDeleteShowTime.Size = new Size(94, 69);
            btnDeleteShowTime.TabIndex = 9;
            btnDeleteShowTime.Text = "Xoá";
            btnDeleteShowTime.UseVisualStyleBackColor = true;
            btnDeleteShowTime.Click += btnDeleteShowTime_Click;
            // 
            // btnInsertShowTime
            // 
            btnInsertShowTime.Location = new Point(-1, 0);
            btnInsertShowTime.Name = "btnInsertShowTime";
            btnInsertShowTime.Size = new Size(94, 69);
            btnInsertShowTime.TabIndex = 8;
            btnInsertShowTime.Text = "Thêm";
            btnInsertShowTime.UseVisualStyleBackColor = true;
            btnInsertShowTime.Click += btnInsertShowTime_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTrangThaiChoNgoi);
            panel2.Controls.Add(cboPhim);
            panel2.Controls.Add(txtGiaVe);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cboPhong);
            panel2.Controls.Add(dtmThoiGianChieu);
            panel2.Controls.Add(txtMaLichChieu);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(890, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 538);
            panel2.TabIndex = 1;
            // 
            // txtTrangThaiChoNgoi
            // 
            txtTrangThaiChoNgoi.Location = new Point(192, 352);
            txtTrangThaiChoNgoi.Name = "txtTrangThaiChoNgoi";
            txtTrangThaiChoNgoi.Size = new Size(176, 27);
            txtTrangThaiChoNgoi.TabIndex = 11;
            // 
            // cboPhim
            // 
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(191, 294);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(177, 28);
            cboPhim.TabIndex = 10;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Location = new Point(192, 236);
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(176, 27);
            txtGiaVe.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 243);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Giá vé :";
            // 
            // cboPhong
            // 
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(194, 176);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(174, 28);
            cboPhong.TabIndex = 8;
            // 
            // dtmThoiGianChieu
            // 
            dtmThoiGianChieu.Location = new Point(194, 118);
            dtmThoiGianChieu.Name = "dtmThoiGianChieu";
            dtmThoiGianChieu.Size = new Size(174, 27);
            dtmThoiGianChieu.TabIndex = 7;
            // 
            // txtMaLichChieu
            // 
            txtMaLichChieu.Location = new Point(194, 59);
            txtMaLichChieu.Name = "txtMaLichChieu";
            txtMaLichChieu.Size = new Size(174, 27);
            txtMaLichChieu.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 359);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái chiếu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 302);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Phim :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 184);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Phòng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 125);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Thời gian chiếu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 66);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã lịch chiếu :";
            // 
            // dtgvShowTime
            // 
            dtgvShowTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvShowTime.Location = new Point(0, 72);
            dtgvShowTime.Name = "dtgvShowTime";
            dtgvShowTime.RowHeadersWidth = 51;
            dtgvShowTime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvShowTime.Size = new Size(884, 547);
            dtgvShowTime.TabIndex = 2;
            dtgvShowTime.CellContentClick += dtgvShowTime_CellContentClick;
            // 
            // ShowTimeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgvShowTime);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ShowTimeUC";
            Size = new Size(1568, 619);
            Load += ShowTimeUC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvShowTime).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnShowShowTime;
        private Button btnUpdateShowTime;
        private Button btnDeleteShowTime;
        private Button btnInsertShowTime;
        private Panel panel2;
        private DataGridView dtgvShowTime;
        private Button button1;
        private TextBox txtSearchShowTime;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTrangThaiChoNgoi;
        private ComboBox cboPhim;
        private TextBox txtGiaVe;
        private ComboBox cboPhong;
        private DateTimePicker dtmThoiGianChieu;
        private TextBox txtMaLichChieu;
    }
}
