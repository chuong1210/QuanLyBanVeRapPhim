﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
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
        PhimBLL phimBll = new PhimBLL();
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        private int rows = 0;
        private int cols = 0;
        private int gaps = 7;

        private string tenPh = "";
        Button[,] seats;
        private int buttonSeatSize = 60;
        LichChieuPhimDTO lc;
        List<string> selectedSeats = new List<string>();
        List<string> gheDaDat = new List<string>();
        private string idLichCP;
        private string _userName;
        Dictionary<string, int> seatMapping = new Dictionary<string, int>();
        private int totalPrice = 0;
        private string _idKH = "";
        private Dictionary<string, int> ticketPrices = new Dictionary<string, int>
{
    { "Trẻ em", 45000 },
    { "Sinh viên", 65000 },
    { "Người lớn", 80000 }
};
        private string selectedTicketType = "Người lớn"; // Loại vé mặc định


        public frmSeatMovie()
        {
            InitializeComponent();
            this.Size = new Size(1500, 850); // Thiết lập kích thước cho form


            //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        public void LoadMovie(string idLichChieu, string tenPhim, string posterPath, string ngayChieu, string userName)
        {
            lblThongtin.Text = tenPhim;
            //pbPoster.ImageLocation = posterPath;
            idLichCP = idLichChieu;
            lc = phimBll.LayChiTietLichChieuPhim(idLichCP);
            lblLich.Text = lc.ThoiGianChieu.ToString();
            gheDaDat = phimBll.LayGheDaDat(idLichCP);
            (rows, cols, tenPh) = phimBll.LayThongTinPhongChieu(lc.idPhong);
            CreateSeats(rows, cols); // Gọi 
            _userName = userName;
            lbPhong.Text = tenPh;


        }

        private void CreateSeats(int rows, int cols)
        {
            flowLayoutPanelSeats.Controls.Clear(); // Clear previous seats

            seats = new Button[rows, cols];
            //    flowLayoutPanelSeats.Size = new Size((buttonSeatSize + 20 + gaps) * cols, (buttonSeatSize + gaps) * rows);
            for (int row = 0; row < rows; row++)
            {


                for (int col = 0; col < cols; col++)
                {
                    Button seatButton = new Button();
                    seatButton.Width = buttonSeatSize;
                    seatButton.Height = buttonSeatSize;
                    //seatButton.Text = $"{row + 1}-{col + 1}"; // Số hàng và số ghế
                    string seatLabel = $"{(char)('A' + row)}{col + 1}";
                    seatButton.Text = seatLabel;

                    int seatId = row * cols + col + 1; // Assuming IDs are numeric and start from 0
                    seatMapping[seatLabel] = seatId;

                    bool val = false;
                    foreach (var item in gheDaDat)
                    {
                        if (item.Equals("Ghe_"+seatId.ToString()))
                        {
                            // Vô hiệu hóa ghế đã đặt
                            val = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (val)
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
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int ticketPrice = ticketPrices[selectedTicketType]; // Lấy giá vé từ Dictionary

            totalPrice = selectedSeats.Count * ticketPrice; // Tính tổng tiền
            lblTongTien.Text = $"Tổng tiền: {totalPrice:N0} VND"; // Cập nhật label hiển thị tổng tiền
        }


        private void AdjustFlowLayoutPanelSize()
        {
            // Đặt kích thước cho FlowLayoutPanel chiếm 2/3 kích thước của form
            //int newWidth = (int)(this.ClientSize.Width * 2.0 / 2);
            //int newHeight = (int)(this.ClientSize.Height * 2.0 / 2); ; // Giữ một khoảng trống trên và dưới

            //flowLayoutPanelSeats.Size = new Size(newWidth, newHeight);
            // Căn giữa FlowLayoutPanel trong form

            flowLayoutPanelSeats.Height = 700;
            flowLayoutPanelSeats.Location = new Point(250, 80);
            btnConfirm.Location = new Point(381, 716);
            pcPoster.Location = new Point(5, 250);
            lblThongtin.Location = new Point(65, 390);
            lblThongtin.TextAlign = ContentAlignment.MiddleCenter;
            pnSelect.Location = new Point(10, 80);
            lblTongTien.Text = $"Tổng tiền: {totalPrice} VND";
            lblTongTien.Location = new Point(30, 430);
            lbIhKH.Location = new Point(30, 500);
            lbIhKH.Text = "Chọn Id Khách Hàng";
            cboIdKH.Location = new Point(30, 550);


            // RadioButtons cho các loại vé
            rbtnChild.Location = new Point(30, 600);

          rbtnStudent.Location = new Point(30, 630);
            rbtnAdult.Location = new Point(30, 660);

            // Thêm sự kiện CheckedChanged để cập nhật loại vé
            rbtnChild.CheckedChanged += (s, e) =>
            {
                if (rbtnChild.Checked)
                    selectedTicketType = "Trẻ em";
                UpdateTotalPrice();
            };

            rbtnStudent.CheckedChanged += (s, e) =>
            {
                if (rbtnStudent.Checked)
                    selectedTicketType = "Sinh viên";
                UpdateTotalPrice();
            };

            rbtnAdult.CheckedChanged += (s, e) =>
            {
                if (rbtnAdult.Checked)
                    selectedTicketType = "Người lớn";
                UpdateTotalPrice();
            };

        


        }

        private int GetTicketType()
        {
            switch (selectedTicketType)
            {
                case "Trẻ em":
                    return 1;  // Loại vé Trẻ em
                case "Sinh viên":
                    return 2;  // Loại vé Sinh viên
                case "Người lớn":
                    return 3;  // Loại vé Người lớn
                default:
                    return 3;  // Mặc định là Người lớn
            }
        }
        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            if (selectedSeats.Count > 0)
            {
                frmConfirm cf= new frmConfirm();
                DatVeDTO datVeDTO;
                // Tạo đối tượng DatVeDTO với thông tin cần thiết
                if (cboIdKH.SelectedIndex > 0)
                {
                    _idKH = cboIdKH.SelectedValue.ToString();
                    datVeDTO = new DatVeDTO
                    {
                        //IdKhachHang = _userName, 
                        IdLichChieuPhim = idLichCP,
                        GiaVePhim = lc.GiaVePhim,
                        TongTien = totalPrice,
                        IdKhachHang = cboIdKH.SelectedValue.ToString(),
                        loaiVP = GetTicketType()


                    };

                    cf.dt = datVeDTO;



                }
                else
                {
                    datVeDTO = new DatVeDTO
                    {
                        //IdKhachHang = _userName, 
                        IdLichChieuPhim = idLichCP,
                        GiaVePhim = lc.GiaVePhim,
                        TongTien = totalPrice,
                        loaiVP = GetTicketType()


                    };
                    cf.dt = datVeDTO;

                }

                List<string> seatIds = selectedSeats.Select(seat => seatMapping[seat].ToString()).ToList();
                cf.seats = seatIds;
                this.Hide();
                cf.ShowDialog();

                //string message = "Bạn đã chọn các ghế: " + string.Join(", ", selectedSeats);
                //HoaDonDTO result = phimBll.DatVeXemPhim(datVeDTO, seatIds,_userName); // Pass the list of IDs

                //if (result != null)
                //{
                //    // Đặt màu xanh cho các ghế đã chọn
                //    foreach (string seat in selectedSeats)
                //    {
                //        // Find the corresponding button for the seat
                //        Button seatButton = flowLayoutPanelSeats.Controls
                //            .OfType<Button>()
                //            .FirstOrDefault(b => b.Text == seat);

                //        if (seatButton != null)
                //        {
                //            seatButton.BackColor = Color.Blue; // Change color to blue for booked seats
                //        }
                //    }
                //    this.Close();
                //    printPreviewDialog1.Document = printDocument1;
                //    printPreviewDialog1.ShowDialog();

                //    //   MessageBox.Show(message, "Xác nhận đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Đặt vé không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
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
            List<KhachHangDTO> khs= khachHangBLL.GetAllKhachHang();
            cboIdKH.DataSource= khs;
            cboIdKH.ValueMember = "Id";
            cboIdKH.DisplayMember = "Id";
            cboIdKH.SelectedIndex = -1;
        }

    }


}

