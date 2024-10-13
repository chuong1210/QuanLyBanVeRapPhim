using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Utils;

namespace GUI
{
    public partial class frmSeatMovie : Form
    {
        private int rows = 10;
        private int cols = 14;
        Button[,] seats;
        private int buttonSeatSize = 60;
        List<string> selectedSeats = new List<string>();
        public frmSeatMovie()
        {
            InitializeComponent();
            this.Size = new Size(1500, 850); // Thiết lập kích thước cho form

         

            this.TopMost = false; // Đưa form lên trên cùng nếu cần
        }

        public void LoadMovie (string idPhim, string tenPhim, string posterPath)
        {
            lblThongtin.Text = tenPhim; // Gán tên phim cho label
            //pbPoster.ImageLocation = posterPath;

        }

        private void CreateSeats(int rows, int cols)
        {
            flowLayoutPanelSeats.Controls.Clear(); // Clear previous seats

            seats = new Button[rows, cols];

            for (int row = 0; row < rows; row++)
            {

              
                for (int col = 0; col < cols; col++)
                {
                    Button seatButton = new Button();
                    seatButton.Width = buttonSeatSize;
                    seatButton.Height = buttonSeatSize;
                    //seatButton.Text = $"{row + 1}-{col + 1}"; // Số hàng và số ghế
                    seatButton.Text = $"{(char)('A' + row)}{col + 1}";
                    seatButton.BackColor = Color.Green; // Màu ghế trống
                    seatButton.Margin = new Padding(5);
               
                    seatButton.Cursor = Cursors.Hand;
                    // Gán sự kiện khi người dùng bấm vào ghế
                    seatButton.Click += SeatButton_Click;
                    ApplyRoundedCorners(seatButton); // Call here

                    // Thêm ghế vào FlowLayoutPanel (hoặc Panel)
                    flowLayoutPanelSeats.Controls.Add(seatButton);


                    // Lưu ghế vào mảng để quản lý
                    seats[row, col] = seatButton;
                }
            }
        }

        private void ApplyRoundedCorners(Button seatButton)
        {
            seatButton.FlatStyle = FlatStyle.Flat;
            seatButton.FlatAppearance.BorderSize = 2;
            seatButton.FlatAppearance.BorderColor = Color.SkyBlue;
            seatButton.FlatAppearance.MouseOverBackColor = Color.LightGreen;

            //Crucially, apply rounded corners *after* other properties.
            seatButton.Region = new Region(Helpers.GetRoundedRectangle(seatButton.Width, seatButton.Height));
        }
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string seatNumber = clickedButton.Text;

            if (clickedButton.BackColor == Color.Green)
            {
                clickedButton.BackColor = Color.Red; // Ghế đã đặt
                selectedSeats.Add(seatNumber); // Thêm ghế vào danh sách đã đặt
            }
            else if (clickedButton.BackColor == Color.Red)
            {
                clickedButton.BackColor = Color.Green; // Hủy đặt ghế
                selectedSeats.Remove(seatNumber); // Xóa ghế khỏi danh sách
            }
        }




        private void AdjustFlowLayoutPanelSize()
        {
            // Đặt kích thước cho FlowLayoutPanel chiếm 2/3 kích thước của form
            //int newWidth = (int)(this.ClientSize.Width * 2.0 / 2);
            //int newHeight = (int)(this.ClientSize.Height * 2.0 / 2); ; // Giữ một khoảng trống trên và dưới

            //flowLayoutPanelSeats.Size = new Size(newWidth, newHeight);
            // Căn giữa FlowLayoutPanel trong form

            flowLayoutPanelSeats.Height = 700;
            flowLayoutPanelSeats.Location = new Point(150, 80);
            btnConfirm.Location = new Point(291, 716);
        }

    
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (selectedSeats.Count > 0)
            {
                string message = "Bạn đã chọn các ghế: " + string.Join(", ", selectedSeats);
                MessageBox.Show(message, "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void flowLayoutPanelSeats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSeatMovie_Load(object sender, EventArgs e)
        {
            seats = new Button[rows, cols];
            CreateSeats(rows, cols); // Gọi 

            //this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            //this.TopMost = true; // Đưa form lên trên cùng nếu cần
            AdjustFlowLayoutPanelSize();
            flowLayoutPanelSeats.BackColor = Color.LightGray;
        }
    }
}
