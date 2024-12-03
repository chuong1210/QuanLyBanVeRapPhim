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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dtGVDH = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            lkBank = new DevExpress.XtraEditors.LookUpEdit();
            pc1 = new Guna.UI2.WinForms.Guna2PictureBox();
            txtTT = new TextBox();
            lbtongtien = new Label();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)dtGVDH).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lkBank.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            SuspendLayout();
            // 
            // dtGVDH
            // 
            dtGVDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGVDH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtGVDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtGVDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtGVDH.DefaultCellStyle = dataGridViewCellStyle2;
            dtGVDH.Dock = DockStyle.Top;
            dtGVDH.Location = new Point(373, 90);
            dtGVDH.Name = "dtGVDH";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtGVDH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtGVDH.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtGVDH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtGVDH.Size = new Size(608, 254);
            dtGVDH.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.th__2_1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.FromArgb(192, 192, 255);
            button1.Location = new Point(988, 4);
            button1.Name = "button1";
            button1.Size = new Size(241, 79);
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
            button2.Location = new Point(373, 4);
            button2.Name = "button2";
            button2.Size = new Size(608, 79);
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
            button3.Size = new Size(362, 79);
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
            tableLayoutPanel1.Controls.Add(groupControl2, 2, 1);
            tableLayoutPanel1.Controls.Add(groupControl1, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 2, 0);
            tableLayoutPanel1.Controls.Add(dtGVDH, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1233, 574);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(lkBank);
            groupControl2.Controls.Add(pc1);
            groupControl2.Controls.Add(txtTT);
            groupControl2.Controls.Add(lbtongtien);
            groupControl2.Dock = DockStyle.Top;
            groupControl2.Location = new Point(988, 90);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(241, 370);
            groupControl2.TabIndex = 9;
            groupControl2.Text = "Quét QR thanh toán(nếu có)";
            // 
            // lkBank
            // 
            lkBank.Location = new Point(85, 107);
            lkBank.Name = "lkBank";
            lkBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lkBank.Size = new Size(156, 22);
            lkBank.TabIndex = 4;
            lkBank.Visible = false;
            // 
            // pc1
            // 
            pc1.CustomizableEdges = customizableEdges1;
            pc1.ImageRotate = 0F;
            pc1.Location = new Point(-83, 110);
            pc1.Name = "pc1";
            pc1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pc1.Size = new Size(767, 580);
            pc1.TabIndex = 3;
            pc1.TabStop = false;
            // 
            // txtTT
            // 
            txtTT.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtTT.Location = new Point(112, 48);
            txtTT.Multiline = true;
            txtTT.Name = "txtTT";
            txtTT.PlaceholderText = " 0VNĐ";
            txtTT.ReadOnly = true;
            txtTT.Size = new Size(166, 28);
            txtTT.TabIndex = 2;
            // 
            // lbtongtien
            // 
            lbtongtien.AutoSize = true;
            lbtongtien.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbtongtien.Location = new Point(10, 48);
            lbtongtien.Name = "lbtongtien";
            lbtongtien.Size = new Size(96, 24);
            lbtongtien.TabIndex = 1;
            lbtongtien.Text = "Tổng tiền:";
            // 
            // groupControl1
            // 
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(4, 90);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(362, 125);
            groupControl1.TabIndex = 8;
            groupControl1.Text = "Nhập thông tin(nếu có)";
            // 
            // frmConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 574);
            Controls.Add(tableLayoutPanel1);
            Name = "frmConfirm";
            Text = "Xác nhận thanh toán";
            Load += frmConfirm_Load;
            ((System.ComponentModel.ISupportInitialize)dtGVDH).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lkBank.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtGVDH;
        private Button button1;
        private Button button2;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private Label lbtongtien;
        private TextBox txtTT;
        private Guna.UI2.WinForms.Guna2PictureBox pc1;
        private DevExpress.XtraEditors.LookUpEdit lkBank;
    }
}