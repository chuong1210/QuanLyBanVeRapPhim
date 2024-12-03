namespace GUI.DataControl.DataUser
{
    partial class ScreenTypeUC
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
            btnUpdateScreenType = new Button();
            btnDeleteScreenType = new Button();
            btnInsertScreenType = new Button();
            panel2 = new Panel();
            txtScreenTypeName = new TextBox();
            txtScreenTypeID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtgvScreenType = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvScreenType).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdateScreenType);
            panel1.Controls.Add(btnDeleteScreenType);
            panel1.Controls.Add(btnInsertScreenType);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1328, 64);
            panel1.TabIndex = 0;
            // 
            // btnUpdateScreenType
            // 
            btnUpdateScreenType.Location = new Point(574, 3);
            btnUpdateScreenType.Name = "btnUpdateScreenType";
            btnUpdateScreenType.Size = new Size(94, 63);
            btnUpdateScreenType.TabIndex = 6;
            btnUpdateScreenType.Text = "Sửa";
            btnUpdateScreenType.UseVisualStyleBackColor = true;
            btnUpdateScreenType.Click += btnUpdateScreenType_Click;
            // 
            // btnDeleteScreenType
            // 
            btnDeleteScreenType.Location = new Point(295, 3);
            btnDeleteScreenType.Name = "btnDeleteScreenType";
            btnDeleteScreenType.Size = new Size(94, 63);
            btnDeleteScreenType.TabIndex = 5;
            btnDeleteScreenType.Text = "Xoá";
            btnDeleteScreenType.UseVisualStyleBackColor = true;
            btnDeleteScreenType.Click += btnDeleteScreenType_Click;
            // 
            // btnInsertScreenType
            // 
            btnInsertScreenType.Location = new Point(0, 0);
            btnInsertScreenType.Name = "btnInsertScreenType";
            btnInsertScreenType.Size = new Size(94, 63);
            btnInsertScreenType.TabIndex = 4;
            btnInsertScreenType.Text = "Thêm";
            btnInsertScreenType.UseVisualStyleBackColor = true;
            btnInsertScreenType.Click += btnInsertScreenType_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtScreenTypeName);
            panel2.Controls.Add(txtScreenTypeID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(708, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 608);
            panel2.TabIndex = 1;
            // 
            // txtScreenTypeName
            // 
            txtScreenTypeName.Location = new Point(281, 212);
            txtScreenTypeName.Name = "txtScreenTypeName";
            txtScreenTypeName.Size = new Size(275, 27);
            txtScreenTypeName.TabIndex = 12;
            // 
            // txtScreenTypeID
            // 
            txtScreenTypeID.Location = new Point(278, 106);
            txtScreenTypeID.Name = "txtScreenTypeID";
            txtScreenTypeID.Size = new Size(275, 27);
            txtScreenTypeID.TabIndex = 11;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(75, 212);
            label2.Name = "label2";
            label2.Size = new Size(200, 32);
            label2.TabIndex = 10;
            label2.Text = "Tên màn hình:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(75, 106);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 9;
            label1.Text = "Mã loại màn hình:";
            // 
            // dtgvScreenType
            // 
            dtgvScreenType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvScreenType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvScreenType.Location = new Point(3, 63);
            dtgvScreenType.Name = "dtgvScreenType";
            dtgvScreenType.RowHeadersWidth = 51;
            dtgvScreenType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvScreenType.Size = new Size(708, 611);
            dtgvScreenType.TabIndex = 2;
            dtgvScreenType.CellContentClick += dtgvScreenType_CellContentClick;
            // 
            // ScreenTypeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(dtgvScreenType);
            Controls.Add(panel1);
            Name = "ScreenTypeUC";
            Size = new Size(1331, 669);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvScreenType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dtgvScreenType;
        private Button btnUpdateScreenType;
        private Button btnDeleteScreenType;
        private Button btnInsertScreenType;
        private TextBox txtScreenTypeName;
        private TextBox txtScreenTypeID;
        private Label label2;
        private Label label1;
    }
}
