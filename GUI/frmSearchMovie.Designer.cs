namespace GUI
{
    partial class frmSearchMovie
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
            panelFilter = new Panel();
            searchBtn = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            dtpNgayChieu = new DateTimePicker();
            cbGenre = new ComboBox();
            label1 = new Label();
            flowLayoutPanelMovies = new FlowLayoutPanel();
            lbPhim = new Label();
            panelLine = new Panel();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchBtn).BeginInit();
            SuspendLayout();
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.BackgroundImageLayout = ImageLayout.Stretch;
            panelFilter.BorderStyle = BorderStyle.Fixed3D;
            panelFilter.Controls.Add(searchBtn);
            panelFilter.Controls.Add(label3);
            panelFilter.Controls.Add(label2);
            panelFilter.Controls.Add(dtpNgayChieu);
            panelFilter.Controls.Add(cbGenre);
            panelFilter.Controls.Add(label1);
            panelFilter.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelFilter.Location = new Point(283, 114);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(879, 229);
            panelFilter.TabIndex = 0;
            panelFilter.Paint += searchPN_Paint;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLightLight;
            searchBtn.BackgroundImage = Properties.Resources.search_icon_png_21;
            searchBtn.BackgroundImageLayout = ImageLayout.Zoom;
            searchBtn.Cursor = Cursors.Hand;
            searchBtn.Location = new Point(639, 107);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(66, 55);
            searchBtn.TabIndex = 1;
            searchBtn.TabStop = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(454, 88);
            label3.Name = "label3";
            label3.Size = new Size(123, 36);
            label3.TabIndex = 4;
            label3.Text = "Ngày chiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(266, 88);
            label2.Name = "label2";
            label2.Size = new Size(92, 36);
            label2.TabIndex = 3;
            label2.Text = "Thể loại";
            // 
            // dtpNgayChieu
            // 
            dtpNgayChieu.Font = new Font("Bahnschrift Condensed", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayChieu.Location = new Point(438, 157);
            dtpNgayChieu.Name = "dtpNgayChieu";
            dtpNgayChieu.Size = new Size(174, 23);
            dtpNgayChieu.TabIndex = 2;
            dtpNgayChieu.Value = new DateTime(2024, 9, 1, 0, 0, 0, 0);
            // 
            // cbGenre
            // 
            cbGenre.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGenre.FormattingEnabled = true;
            cbGenre.Location = new Point(236, 144);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(151, 36);
            cbGenre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Bahnschrift Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(352, 7);
            label1.Name = "label1";
            label1.Size = new Size(176, 53);
            label1.TabIndex = 0;
            label1.Text = "Chọn phim";
            // 
            // flowLayoutPanelMovies
            // 
            flowLayoutPanelMovies.AutoScroll = true;
            flowLayoutPanelMovies.Enabled = false;
            flowLayoutPanelMovies.Location = new Point(310, 463);
            flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            flowLayoutPanelMovies.Size = new Size(781, 423);
            flowLayoutPanelMovies.TabIndex = 1;
            flowLayoutPanelMovies.Visible = false;
            // 
            // lbPhim
            // 
            lbPhim.AutoSize = true;
            lbPhim.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhim.Location = new Point(678, 402);
            lbPhim.Name = "lbPhim";
            lbPhim.Size = new Size(340, 36);
            lbPhim.TabIndex = 2;
            lbPhim.Text = "Danh sách phim hiện tại";
            lbPhim.Visible = false;
            // 
            // panelLine
            // 
            panelLine.BackColor = Color.Black;
            panelLine.Location = new Point(283, 384);
            panelLine.Name = "panelLine";
            panelLine.Size = new Size(1336, 15);
            panelLine.TabIndex = 3;
            // 
            // frmSearchMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1337, 829);
            Controls.Add(panelLine);
            Controls.Add(lbPhim);
            Controls.Add(flowLayoutPanelMovies);
            Controls.Add(panelFilter);
            Name = "frmSearchMovie";
            Text = "frmSearchMovie";
            Load += frmSearchMovie_Load;
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFilter;
        private Label label1;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayChieu;
        private ComboBox cbGenre;
        private PictureBox searchBtn;
        private FlowLayoutPanel flowLayoutPanelMovies;
        private Label lbPhim;
        private Panel panelLine;
    }
}