namespace GUI.DataControl.DataUser
{
    partial class RoomUC
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
            btnDeleteRoom = new Button();
            btnUpdateRoom = new Button();
            btnInsertRoom = new Button();
            panel3 = new Panel();
            cboTrangThaiChoNgoi = new ComboBox();
            cboScreen = new ComboBox();
            txtSeatsPerRow = new TextBox();
            txtNumberOfRows = new TextBox();
            txtRoomSeats = new TextBox();
            txtRoomName = new TextBox();
            txtRoomID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dtgvRoom = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvRoom).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDeleteRoom);
            panel1.Controls.Add(btnUpdateRoom);
            panel1.Controls.Add(btnInsertRoom);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1326, 62);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.Location = new Point(690, -1);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(94, 63);
            btnDeleteRoom.TabIndex = 2;
            btnDeleteRoom.Text = "Xoá";
            btnDeleteRoom.UseVisualStyleBackColor = true;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.Location = new Point(349, 0);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(94, 63);
            btnUpdateRoom.TabIndex = 1;
            btnUpdateRoom.Text = "Sửa";
            btnUpdateRoom.UseVisualStyleBackColor = true;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // btnInsertRoom
            // 
            btnInsertRoom.Location = new Point(3, 0);
            btnInsertRoom.Name = "btnInsertRoom";
            btnInsertRoom.Size = new Size(94, 63);
            btnInsertRoom.TabIndex = 0;
            btnInsertRoom.Text = "Thêm";
            btnInsertRoom.UseVisualStyleBackColor = true;
            btnInsertRoom.Click += btnInsertRoom_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cboTrangThaiChoNgoi);
            panel3.Controls.Add(cboScreen);
            panel3.Controls.Add(txtSeatsPerRow);
            panel3.Controls.Add(txtNumberOfRows);
            panel3.Controls.Add(txtRoomSeats);
            panel3.Controls.Add(txtRoomName);
            panel3.Controls.Add(txtRoomID);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(912, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(414, 562);
            panel3.TabIndex = 3;
            // 
            // cboTrangThaiChoNgoi
            // 
            cboTrangThaiChoNgoi.FormattingEnabled = true;
            cboTrangThaiChoNgoi.Location = new Point(195, 347);
            cboTrangThaiChoNgoi.Name = "cboTrangThaiChoNgoi";
            cboTrangThaiChoNgoi.Size = new Size(172, 28);
            cboTrangThaiChoNgoi.TabIndex = 15;
            // 
            // cboScreen
            // 
            cboScreen.FormattingEnabled = true;
            cboScreen.Location = new Point(196, 176);
            cboScreen.Name = "cboScreen";
            cboScreen.Size = new Size(171, 28);
            cboScreen.TabIndex = 14;
            // 
            // txtSeatsPerRow
            // 
            txtSeatsPerRow.Location = new Point(196, 501);
            txtSeatsPerRow.Name = "txtSeatsPerRow";
            txtSeatsPerRow.Size = new Size(174, 27);
            txtSeatsPerRow.TabIndex = 13;
            // 
            // txtNumberOfRows
            // 
            txtNumberOfRows.Location = new Point(196, 420);
            txtNumberOfRows.Name = "txtNumberOfRows";
            txtNumberOfRows.Size = new Size(174, 27);
            txtNumberOfRows.TabIndex = 12;
            // 
            // txtRoomSeats
            // 
            txtRoomSeats.Location = new Point(196, 258);
            txtRoomSeats.Name = "txtRoomSeats";
            txtRoomSeats.Size = new Size(174, 27);
            txtRoomSeats.TabIndex = 10;
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(196, 96);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(174, 27);
            txtRoomName.TabIndex = 8;
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(196, 15);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(174, 27);
            txtRoomID.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(39, 503);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 6;
            label7.Text = "Ghế mỗi hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(39, 422);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 5;
            label6.Text = "Số hàng ghế:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(39, 341);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 4;
            label5.Text = "Tình trạng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(39, 260);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 3;
            label4.Text = "Số chỗ ngồi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(39, 179);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 2;
            label3.Text = "Màn hình:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(39, 98);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên phòng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(39, 17);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvRoom);
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 562);
            panel2.TabIndex = 1;
            // 
            // dtgvRoom
            // 
            dtgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRoom.Location = new Point(0, 0);
            dtgvRoom.Name = "dtgvRoom";
            dtgvRoom.RowHeadersWidth = 51;
            dtgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvRoom.Size = new Size(909, 562);
            dtgvRoom.TabIndex = 0;
            dtgvRoom.CellContentClick += dtgvRoom_CellContentClick;
            // 
            // RoomUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RoomUC";
            Size = new Size(1326, 629);
            Load += RoomUC_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDeleteRoom;
        private Button btnUpdateRoom;
        private Button btnInsertRoom;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSeatsPerRow;
        private TextBox txtNumberOfRows;
        private TextBox txtRoomSeats;
        private TextBox txtRoomName;
        private TextBox txtRoomID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboScreen;
        private DataGridView dtgvRoom;
        private ComboBox cboTrangThaiChoNgoi;
    }
}
