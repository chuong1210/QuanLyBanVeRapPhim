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
            dtgvShowTime = new DataGridView();
            panel1.SuspendLayout();
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
            // 
            // btnDeleteShowTime
            // 
            btnDeleteShowTime.Location = new Point(174, 0);
            btnDeleteShowTime.Name = "btnDeleteShowTime";
            btnDeleteShowTime.Size = new Size(94, 69);
            btnDeleteShowTime.TabIndex = 9;
            btnDeleteShowTime.Text = "Xoá";
            btnDeleteShowTime.UseVisualStyleBackColor = true;
            // 
            // btnInsertShowTime
            // 
            btnInsertShowTime.Location = new Point(-1, 0);
            btnInsertShowTime.Name = "btnInsertShowTime";
            btnInsertShowTime.Size = new Size(94, 69);
            btnInsertShowTime.TabIndex = 8;
            btnInsertShowTime.Text = "Thêm";
            btnInsertShowTime.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(1142, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 548);
            panel2.TabIndex = 1;
            // 
            // dtgvShowTime
            // 
            dtgvShowTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvShowTime.Location = new Point(0, 72);
            dtgvShowTime.Name = "dtgvShowTime";
            dtgvShowTime.RowHeadersWidth = 51;
            dtgvShowTime.Size = new Size(1142, 547);
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
    }
}
