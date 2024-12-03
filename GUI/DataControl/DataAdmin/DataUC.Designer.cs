namespace GUI.DataControl.DataAdmin
{
    partial class DataUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataUC));
            panel1 = new Panel();
            btnTicket = new Button();
            btnDate = new Button();
            btnFilm = new Button();
            btnGenre = new Button();
            btnRoom = new Button();
            btnScreen = new Button();
            pnDataUC = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnTicket);
            panel1.Controls.Add(btnDate);
            panel1.Controls.Add(btnFilm);
            panel1.Controls.Add(btnGenre);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnScreen);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 608);
            panel1.TabIndex = 0;
            // 
            // btnTicket
            // 
            btnTicket.BackColor = Color.Black;
            btnTicket.FlatStyle = FlatStyle.Flat;
            btnTicket.Font = new Font("Calibri", 10.8F);
            btnTicket.ForeColor = SystemColors.Control;
            btnTicket.Image = (Image)resources.GetObject("btnTicket.Image");
            btnTicket.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicket.Location = new Point(43, 517);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(194, 59);
            btnTicket.TabIndex = 6;
            btnTicket.Text = "     Vé";
            btnTicket.UseVisualStyleBackColor = false;
            // 
            // btnDate
            // 
            btnDate.BackColor = Color.Black;
            btnDate.FlatStyle = FlatStyle.Flat;
            btnDate.Font = new Font("Calibri", 10.8F);
            btnDate.ForeColor = SystemColors.Control;
            btnDate.Image = (Image)resources.GetObject("btnDate.Image");
            btnDate.ImageAlign = ContentAlignment.MiddleLeft;
            btnDate.Location = new Point(43, 419);
            btnDate.Name = "btnDate";
            btnDate.Size = new Size(194, 59);
            btnDate.TabIndex = 5;
            btnDate.Text = "     Lịch chiếu";
            btnDate.UseVisualStyleBackColor = false;
            btnDate.Click += btnDate_Click;
            // 
            // btnFilm
            // 
            btnFilm.BackColor = Color.Black;
            btnFilm.FlatStyle = FlatStyle.Flat;
            btnFilm.Font = new Font("Calibri", 10.8F);
            btnFilm.ForeColor = SystemColors.Control;
            btnFilm.Image = (Image)resources.GetObject("btnFilm.Image");
            btnFilm.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilm.Location = new Point(43, 321);
            btnFilm.Name = "btnFilm";
            btnFilm.Size = new Size(194, 59);
            btnFilm.TabIndex = 3;
            btnFilm.Text = "     Phim";
            btnFilm.UseVisualStyleBackColor = false;
            btnFilm.Click += btnFilm_Click;
            // 
            // btnGenre
            // 
            btnGenre.BackColor = Color.Black;
            btnGenre.FlatStyle = FlatStyle.Flat;
            btnGenre.Font = new Font("Calibri", 10.8F);
            btnGenre.ForeColor = SystemColors.Control;
            btnGenre.Image = (Image)resources.GetObject("btnGenre.Image");
            btnGenre.ImageAlign = ContentAlignment.MiddleLeft;
            btnGenre.Location = new Point(43, 223);
            btnGenre.Name = "btnGenre";
            btnGenre.Size = new Size(194, 59);
            btnGenre.TabIndex = 2;
            btnGenre.Text = "      Thể loại";
            btnGenre.UseVisualStyleBackColor = false;
            btnGenre.Click += btnGenre_Click;
            // 
            // btnRoom
            // 
            btnRoom.BackColor = Color.Black;
            btnRoom.FlatStyle = FlatStyle.Flat;
            btnRoom.Font = new Font("Calibri", 10.8F);
            btnRoom.ForeColor = SystemColors.Control;
            btnRoom.Image = (Image)resources.GetObject("btnRoom.Image");
            btnRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoom.Location = new Point(43, 125);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(194, 59);
            btnRoom.TabIndex = 1;
            btnRoom.Text = "     Phòng chiếu";
            btnRoom.UseVisualStyleBackColor = false;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnScreen
            // 
            btnScreen.BackColor = Color.Black;
            btnScreen.FlatStyle = FlatStyle.Flat;
            btnScreen.Font = new Font("Calibri", 10.8F);
            btnScreen.ForeColor = SystemColors.Control;
            btnScreen.Image = Properties.Resources.Untitled_2_0001_Layer_8;
            btnScreen.ImageAlign = ContentAlignment.MiddleLeft;
            btnScreen.Location = new Point(43, 27);
            btnScreen.Name = "btnScreen";
            btnScreen.Size = new Size(194, 59);
            btnScreen.TabIndex = 0;
            btnScreen.Text = "     Loại màn hình";
            btnScreen.UseVisualStyleBackColor = false;
            btnScreen.Click += btnScreen_Click;
            // 
            // pnDataUC
            // 
            pnDataUC.Location = new Point(291, 3);
            pnDataUC.Name = "pnDataUC";
            pnDataUC.Size = new Size(1267, 608);
            pnDataUC.TabIndex = 1;
            // 
            // DataUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnDataUC);
            Controls.Add(panel1);
            Name = "DataUC";
            Size = new Size(1560, 616);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTicket;
        private Button btnDate;
        private Button btnFilm;
        private Button btnGenre;
        private Button btnRoom;
        private Button btnScreen;
        private Panel pnDataUC;
    }
}
