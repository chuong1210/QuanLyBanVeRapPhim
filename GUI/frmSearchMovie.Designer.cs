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
            dateTimePicker1 = new DateTimePicker();
            cbGenre = new ComboBox();
            label1 = new Label();
            listItemPhim = new FlowLayoutPanel();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchBtn).BeginInit();
            SuspendLayout();
            // 
            // panelFilter
            // 
            panelFilter.BackgroundImageLayout = ImageLayout.Stretch;
            panelFilter.BorderStyle = BorderStyle.Fixed3D;
            panelFilter.Controls.Add(searchBtn);
            panelFilter.Controls.Add(label3);
            panelFilter.Controls.Add(label2);
            panelFilter.Controls.Add(dateTimePicker1);
            panelFilter.Controls.Add(cbGenre);
            panelFilter.Controls.Add(label1);
            panelFilter.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelFilter.Location = new Point(302, 0);
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
            searchBtn.Location = new Point(636, 147);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(50, 33);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Bahnschrift Condensed", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(438, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(174, 23);
            dateTimePicker1.TabIndex = 2;
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
            // listItemPhim
            // 
            listItemPhim.AutoScroll = true;
            listItemPhim.Location = new Point(404, 252);
            listItemPhim.Name = "listItemPhim";
            listItemPhim.Size = new Size(632, 347);
            listItemPhim.TabIndex = 1;
            // 
            // frmSearchMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 817);
            Controls.Add(listItemPhim);
            Controls.Add(panelFilter);
            Name = "frmSearchMovie";
            Text = "frmSearchMovie";
            Load += frmSearchMovie_Load;
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFilter;
        private Label label1;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbGenre;
        private PictureBox searchBtn;
        private FlowLayoutPanel listItemPhim;
    }
}