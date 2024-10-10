using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSeatMovie : Form
    {
        private int rows = 10;
        private int cols = 15;
        Button[,] seats;
        List<string> selectedSeats = new List<string>();
        public frmSeatMovie()
        {
            InitializeComponent();
            seats = new Button[rows, cols];
            CreateSeats(rows, cols); // Gọi 

            this.WindowState = FormWindowState.Maximized; // Phóng to toàn màn hình
            this.TopMost = true; // Đưa form lên trên cùng nếu cần
            AdjustFlowLayoutPanelSize();
            flowLayoutPanelSeats.BackColor = Color.LightGray;
        }


        private void CreateSeats(int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Button seatButton = new Button();
                    seatButton.Width = 60;
                    seatButton.Height = 60;
                    seatButton.Text = $"{row + 1}-{col + 1}"; // Số hàng và số ghế
                    seatButton.BackColor = Color.Green; // Màu ghế trống
                    seatButton.Margin = new Padding(5);

                    // Gán sự kiện khi người dùng bấm vào ghế
                    seatButton.Click += SeatButton_Click;

                    // Thêm ghế vào FlowLayoutPanel (hoặc Panel)
                    flowLayoutPanelSeats.Controls.Add(seatButton);

                    // Lưu ghế vào mảng để quản lý
                    seats[row, col] = seatButton;
                }
            }
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
            int newWidth = (int)(this.ClientSize.Width * 2.0 / 2);
            int newHeight = (int)(this.ClientSize.Height * 2.0 /2); ; // Giữ một khoảng trống trên và dưới

            flowLayoutPanelSeats.Size = new Size(newWidth, newHeight);
            // Căn giữa FlowLayoutPanel trong form
            flowLayoutPanelSeats.Location = new Point(70,70);
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
    }
}
