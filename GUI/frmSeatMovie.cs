using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Utils;

namespace GUI
{
    public partial class frmSeatMovie : Form
    {
        PhimBLL phimBll= new PhimBLL();
        private int rows = 0;
        private int cols = 0;
        Button[,] seats;
        private int buttonSeatSize = 60;
        LichChieuPhimDTO lc;
        List<string> selectedSeats = new List<string>();
        List<string> gheDaDat = new List<string>();
        private string idLichCP;
        private string _idKh;
        Dictionary<string, int> seatMapping = new Dictionary<string, int>();

        public frmSeatMovie()
        {
            InitializeComponent();
            this.Size = new Size(1500, 850); // Thiết lập kích thước cho form

         

            this.TopMost = false; // Đưa form lên trên cùng nếu cần
        }

        public void LoadMovie (string idLichChieu, string tenPhim, string posterPath,string ngayChieu,string idKh)
        {
            lblThongtin.Text = tenPhim;
            //pbPoster.ImageLocation = posterPath;
            idLichCP= idLichChieu;
             lc =   phimBll.LayChiTietLichChieuPhim(idLichCP);
            lblLich.Text = lc.ThoiGianChieu.ToString();
            gheDaDat = phimBll.LayGheDaDat(idLichCP);
            (rows, cols) = phimBll.LayThongTinPhongChieu(lc.idPhong);
            CreateSeats(rows, cols); // Gọi 
            _idKh=idKh;


        }

        private void CreateSeats(int rows, int cols)
        {
            flowLayoutPanelSeats.Controls.Clear(); // Clear previous seats

            seats = new Button[rows, cols];

            for (int row =0; row < rows; row++)
            {

              
                for (int col = 0; col < cols; col++)
                {
                    Button seatButton = new Button();
                    seatButton.Width = buttonSeatSize;
                    seatButton.Height = buttonSeatSize;
                    //seatButton.Text = $"{row + 1}-{col + 1}"; // Số hàng và số ghế
                    string seatLabel = $"{(char)('A' + row)}{col + 1}";
                    seatButton.Text = seatLabel;

                    int seatId = row * cols + col+1; // Assuming IDs are numeric and start from 0
                    seatMapping[seatLabel] = seatId;

                    bool val = false;
                    foreach (var item in gheDaDat)
                    {
                        if (item.Equals(seatId.ToString()))
                        {
                            // Vô hiệu hóa ghế đã đặt
                            val=true; 
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if(val)
                    {
                        seatButton.BackColor = Color.Red; // Ghế đã được đặt
                        seatButton.Enabled = false;
                    }
                   
                    else
                    {
                        seatButton.BackColor = Color.Green; // Ghế chưa đặt
                        seatButton.Click += SeatButton_Click;
                    }

                    seatButton.Margin = new Padding(5);
               
                    seatButton.Cursor = Cursors.Hand;
                    // Gán sự kiện khi người dùng bấm vào ghế
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
                clickedButton.BackColor = Color.Yellow; // Ghế đã đặt
                selectedSeats.Add(seatNumber);  // Thêm ghế vào danh sách đã đặt
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
            pcPoster.Location = new Point(50, 80);
            lblThongtin.Location = new Point(50, 220);
        }

    
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (selectedSeats.Count > 0)
            {
                // Tạo đối tượng DatVeDTO với thông tin cần thiết
                DatVeDTO datVeDTO = new DatVeDTO
                {
                    IdKhachHang =_idKh , // Thay thế bằng ID khách hàng thực tế
                    IdLichChieuPhim = idLichCP,
                    GiaVePhim = lc.GiaVePhim,
                    TongTien=65000,

                };

                List<string> seatIds = selectedSeats.Select(seat => seatMapping[seat].ToString()).ToList();

                string message = "Bạn đã chọn các ghế: " + string.Join(", ", selectedSeats);
                bool result = phimBll.DatVeXemPhim(datVeDTO, seatIds); // Pass the list of IDs

                if (result)
                {
                    // Đặt màu xanh cho các ghế đã chọn
                    foreach (string seat in selectedSeats)
                    {
                        // Find the corresponding button for the seat
                        Button seatButton = flowLayoutPanelSeats.Controls
                            .OfType<Button>()
                            .FirstOrDefault(b => b.Text == seat);

                        if (seatButton != null)
                        {
                            seatButton.BackColor = Color.Blue; // Change color to blue for booked seats
                        }
                    }

                    MessageBox.Show(message, "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đặt vé không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            AdjustFlowLayoutPanelSize();
            flowLayoutPanelSeats.BackColor = Color.LightGray;
        }
    }
}
