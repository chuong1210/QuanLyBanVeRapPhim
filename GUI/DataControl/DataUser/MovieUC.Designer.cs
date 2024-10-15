namespace GUI.DataControl.DataUser
{
    partial class MovieUC
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            dtmMovieEnd = new DateTimePicker();
            dtmMovieStart = new DateTimePicker();
            txtMovieYear = new TextBox();
            txtMovieDirector = new TextBox();
            txtMovieProductor = new TextBox();
            txtMovieLength = new TextBox();
            txtMovieDescription = new TextBox();
            txtMovieName = new TextBox();
            txtMovieID = new TextBox();
            btnUpLoadPtr = new Button();
            ptrMovie = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnShowMovie = new Button();
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            btnInsertMovie = new Button();
            dtgvMovie = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptrMovie).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvMovie).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dtmMovieEnd);
            panel1.Controls.Add(dtmMovieStart);
            panel1.Controls.Add(txtMovieYear);
            panel1.Controls.Add(txtMovieDirector);
            panel1.Controls.Add(txtMovieProductor);
            panel1.Controls.Add(txtMovieLength);
            panel1.Controls.Add(txtMovieDescription);
            panel1.Controls.Add(txtMovieName);
            panel1.Controls.Add(txtMovieID);
            panel1.Controls.Add(btnUpLoadPtr);
            panel1.Controls.Add(ptrMovie);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1404, 326);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 150);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 78);
            textBox1.TabIndex = 54;
            // 
            // dtmMovieEnd
            // 
            dtmMovieEnd.Location = new Point(617, 97);
            dtmMovieEnd.Name = "dtmMovieEnd";
            dtmMovieEnd.Size = new Size(241, 27);
            dtmMovieEnd.TabIndex = 53;
            // 
            // dtmMovieStart
            // 
            dtmMovieStart.Location = new Point(617, 49);
            dtmMovieStart.Name = "dtmMovieStart";
            dtmMovieStart.Size = new Size(241, 27);
            dtmMovieStart.TabIndex = 52;
            // 
            // txtMovieYear
            // 
            txtMovieYear.Location = new Point(617, 237);
            txtMovieYear.Name = "txtMovieYear";
            txtMovieYear.Size = new Size(241, 27);
            txtMovieYear.TabIndex = 51;
            // 
            // txtMovieDirector
            // 
            txtMovieDirector.Location = new Point(617, 190);
            txtMovieDirector.Name = "txtMovieDirector";
            txtMovieDirector.Size = new Size(241, 27);
            txtMovieDirector.TabIndex = 50;
            // 
            // txtMovieProductor
            // 
            txtMovieProductor.Location = new Point(617, 143);
            txtMovieProductor.Name = "txtMovieProductor";
            txtMovieProductor.Size = new Size(241, 27);
            txtMovieProductor.TabIndex = 49;
            // 
            // txtMovieLength
            // 
            txtMovieLength.Location = new Point(617, 5);
            txtMovieLength.Name = "txtMovieLength";
            txtMovieLength.Size = new Size(241, 27);
            txtMovieLength.TabIndex = 46;
            // 
            // txtMovieDescription
            // 
            txtMovieDescription.Location = new Point(138, 99);
            txtMovieDescription.Name = "txtMovieDescription";
            txtMovieDescription.Size = new Size(241, 27);
            txtMovieDescription.TabIndex = 44;
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(138, 55);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(241, 27);
            txtMovieName.TabIndex = 43;
            // 
            // txtMovieID
            // 
            txtMovieID.Location = new Point(138, 12);
            txtMovieID.Name = "txtMovieID";
            txtMovieID.Size = new Size(241, 27);
            txtMovieID.TabIndex = 42;
            // 
            // btnUpLoadPtr
            // 
            btnUpLoadPtr.Location = new Point(1112, 237);
            btnUpLoadPtr.Name = "btnUpLoadPtr";
            btnUpLoadPtr.Size = new Size(94, 52);
            btnUpLoadPtr.TabIndex = 41;
            btnUpLoadPtr.Text = "Chọn hình ảnh";
            btnUpLoadPtr.UseVisualStyleBackColor = true;
            // 
            // ptrMovie
            // 
            ptrMovie.Location = new Point(1036, 4);
            ptrMovie.Name = "ptrMovie";
            ptrMovie.Size = new Size(237, 213);
            ptrMovie.TabIndex = 40;
            ptrMovie.TabStop = false;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(437, 237);
            label9.Name = "label9";
            label9.Size = new Size(139, 38);
            label9.TabIndex = 39;
            label9.Text = "Năm sản xuất:";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label10.Location = new Point(437, 190);
            label10.Name = "label10";
            label10.Size = new Size(108, 38);
            label10.TabIndex = 38;
            label10.Text = "Đạo diễn:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(437, 143);
            label5.Name = "label5";
            label5.Size = new Size(122, 38);
            label5.TabIndex = 37;
            label5.Text = "Sản xuất:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(437, 96);
            label6.Name = "label6";
            label6.Size = new Size(122, 38);
            label6.TabIndex = 36;
            label6.Text = "Ngày KT:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(437, 49);
            label7.Name = "label7";
            label7.Size = new Size(122, 38);
            label7.TabIndex = 35;
            label7.Text = "Ngày KC:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(437, 4);
            label8.Name = "label8";
            label8.Size = new Size(122, 36);
            label8.TabIndex = 34;
            label8.Text = "Thời lượng:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(10, 142);
            label4.Name = "label4";
            label4.Size = new Size(122, 38);
            label4.TabIndex = 33;
            label4.Text = "Thể loại:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(10, 98);
            label3.Name = "label3";
            label3.Size = new Size(122, 38);
            label3.TabIndex = 32;
            label3.Text = "Mô tả:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(129, 38);
            label2.TabIndex = 31;
            label2.Text = "Tên phim:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 36);
            label1.TabIndex = 30;
            label1.Text = "Mã phim:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnShowMovie);
            panel2.Controls.Add(btnUpdateMovie);
            panel2.Controls.Add(btnDeleteMovie);
            panel2.Controls.Add(btnInsertMovie);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1409, 87);
            panel2.TabIndex = 1;
            // 
            // btnShowMovie
            // 
            btnShowMovie.Location = new Point(557, 1);
            btnShowMovie.Name = "btnShowMovie";
            btnShowMovie.Size = new Size(94, 63);
            btnShowMovie.TabIndex = 11;
            btnShowMovie.Text = "Xem";
            btnShowMovie.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Location = new Point(372, 1);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(94, 63);
            btnUpdateMovie.TabIndex = 10;
            btnUpdateMovie.Text = "Sửa";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(187, 1);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(94, 63);
            btnDeleteMovie.TabIndex = 9;
            btnDeleteMovie.Text = "Xoá";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // btnInsertMovie
            // 
            btnInsertMovie.Location = new Point(2, 1);
            btnInsertMovie.Name = "btnInsertMovie";
            btnInsertMovie.Size = new Size(94, 63);
            btnInsertMovie.TabIndex = 8;
            btnInsertMovie.Text = "Thêm";
            btnInsertMovie.UseVisualStyleBackColor = true;
            // 
            // dtgvMovie
            // 
            dtgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvMovie.Location = new Point(-4, 415);
            dtgvMovie.Name = "dtgvMovie";
            dtgvMovie.RowHeadersWidth = 51;
            dtgvMovie.Size = new Size(1408, 311);
            dtgvMovie.TabIndex = 2;
            // 
            // MovieUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgvMovie);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MovieUC";
            Size = new Size(1410, 726);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptrMovie).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvMovie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUpLoadPtr;
        private PictureBox ptrMovie;
        private Label label9;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnShowMovie;
        private Button btnUpdateMovie;
        private Button btnDeleteMovie;
        private Button btnInsertMovie;
        private DataGridView dtgvMovie;
        private DateTimePicker dtmMovieEnd;
        private DateTimePicker dtmMovieStart;
        private TextBox txtMovieYear;
        private TextBox txtMovieDirector;
        private TextBox txtMovieProductor;
        private TextBox txtMovieLength;
        private TextBox txtMovieDescription;
        private TextBox txtMovieName;
        private TextBox txtMovieID;
        private TextBox textBox1;
    }
}
