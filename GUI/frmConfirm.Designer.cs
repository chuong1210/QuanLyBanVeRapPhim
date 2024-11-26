namespace GUI
{
    partial class frmConfirm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            dataGridView1 = new DataGridView();
            TT = new DataGridViewTextBoxColumn();
            DG = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            TenPhim = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(4, 72);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(232, 125);
            groupControl1.TabIndex = 7;
            groupControl1.Text = "Nhập thông tin(nếu có)";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TenPhim, SL, DG, TT });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(243, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(392, 188);
            dataGridView1.TabIndex = 6;
            // 
            // TT
            // 
            TT.HeaderText = "Thành tiền";
            TT.MinimumWidth = 6;
            TT.Name = "TT";
            // 
            // DG
            // 
            DG.HeaderText = "Đơn giá";
            DG.MinimumWidth = 6;
            DG.Name = "DG";
            // 
            // SL
            // 
            SL.HeaderText = "Số Lượng";
            SL.MinimumWidth = 6;
            SL.Name = "SL";
            // 
            // TenPhim
            // 
            TenPhim.HeaderText = "Tên Phim";
            TenPhim.MinimumWidth = 6;
            TenPhim.Name = "TenPhim";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.th__2_1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(642, 4);
            button1.Name = "button1";
            button1.Size = new Size(154, 61);
            button1.TabIndex = 3;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkViolet;
            button2.BackgroundImage = Properties.Resources.th__2_1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Dock = DockStyle.Fill;
            button2.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button2.ForeColor = Color.FromArgb(192, 192, 255);
            button2.Location = new Point(243, 4);
            button2.Name = "button2";
            button2.Size = new Size(392, 61);
            button2.TabIndex = 4;
            button2.Text = "Đơn hàng";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.th__2_1;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Dock = DockStyle.Fill;
            button3.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button3.ForeColor = Color.FromArgb(192, 192, 255);
            button3.Location = new Point(4, 4);
            button3.Name = "button3";
            button3.Size = new Size(232, 61);
            button3.TabIndex = 5;
            button3.Text = "Thông tin của khách hàng";
            button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 2, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Controls.Add(groupControl1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // frmConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmConfirm";
            Text = "Xác nhận thanh toán";
            Load += frmConfirm_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TenPhim;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn DG;
        private DataGridViewTextBoxColumn TT;
        private Button button1;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}