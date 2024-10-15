namespace GUI.DataControl.DataUser
{
    partial class GenreUC
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
            btnShowGenre = new Button();
            btnDeleteGenre = new Button();
            btnUpdateGenre = new Button();
            btnInsertGenre = new Button();
            panel2 = new Panel();
            txtDescriptionGenre = new TextBox();
            label3 = new Label();
            txtGenreName = new TextBox();
            txtGenreID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgtvGenre = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgtvGenre).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShowGenre);
            panel1.Controls.Add(btnDeleteGenre);
            panel1.Controls.Add(btnUpdateGenre);
            panel1.Controls.Add(btnInsertGenre);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1354, 65);
            panel1.TabIndex = 0;
            // 
            // btnShowGenre
            // 
            btnShowGenre.Location = new Point(558, 0);
            btnShowGenre.Name = "btnShowGenre";
            btnShowGenre.Size = new Size(94, 63);
            btnShowGenre.TabIndex = 7;
            btnShowGenre.Text = "Xem";
            btnShowGenre.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.Location = new Point(373, 0);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(94, 63);
            btnDeleteGenre.TabIndex = 6;
            btnDeleteGenre.Text = "Sửa";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.Location = new Point(188, 0);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(94, 63);
            btnUpdateGenre.TabIndex = 5;
            btnUpdateGenre.Text = "Xoá";
            btnUpdateGenre.UseVisualStyleBackColor = true;
            // 
            // btnInsertGenre
            // 
            btnInsertGenre.Location = new Point(3, 0);
            btnInsertGenre.Name = "btnInsertGenre";
            btnInsertGenre.Size = new Size(94, 63);
            btnInsertGenre.TabIndex = 4;
            btnInsertGenre.Text = "Thêm";
            btnInsertGenre.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDescriptionGenre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtGenreName);
            panel2.Controls.Add(txtGenreID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(866, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 640);
            panel2.TabIndex = 1;
            // 
            // txtDescriptionGenre
            // 
            txtDescriptionGenre.Location = new Point(181, 387);
            txtDescriptionGenre.Multiline = true;
            txtDescriptionGenre.Name = "txtDescriptionGenre";
            txtDescriptionGenre.Size = new Size(272, 202);
            txtDescriptionGenre.TabIndex = 18;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(15, 386);
            label3.Name = "label3";
            label3.Size = new Size(122, 38);
            label3.TabIndex = 17;
            label3.Text = "Mô tả:";
            // 
            // txtGenreName
            // 
            txtGenreName.Location = new Point(181, 230);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(275, 27);
            txtGenreName.TabIndex = 16;
            // 
            // txtGenreID
            // 
            txtGenreID.Location = new Point(181, 77);
            txtGenreID.Name = "txtGenreID";
            txtGenreID.Size = new Size(275, 27);
            txtGenreID.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(15, 230);
            label2.Name = "label2";
            label2.Size = new Size(200, 38);
            label2.TabIndex = 14;
            label2.Text = "Tên thể loại:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(15, 76);
            label1.Name = "label1";
            label1.Size = new Size(200, 36);
            label1.TabIndex = 13;
            label1.Text = "Mã thể loại:";
            // 
            // dgtvGenre
            // 
            dgtvGenre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtvGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtvGenre.Location = new Point(0, 69);
            dgtvGenre.Name = "dgtvGenre";
            dgtvGenre.RowHeadersWidth = 51;
            dgtvGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtvGenre.Size = new Size(863, 637);
            dgtvGenre.TabIndex = 2;
            // 
            // GenreUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(dgtvGenre);
            Controls.Add(panel1);
            Name = "GenreUC";
            Size = new Size(1354, 709);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgtvGenre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgtvGenre;
        private Button btnShowGenre;
        private Button btnDeleteGenre;
        private Button btnUpdateGenre;
        private Button btnInsertGenre;
        private TextBox txtGenreName;
        private TextBox txtGenreID;
        private Label label2;
        private Label label1;
        private TextBox txtDescriptionGenre;
        private Label label3;
    }
}
