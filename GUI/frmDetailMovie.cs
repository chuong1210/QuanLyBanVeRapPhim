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

namespace GUI
{
    public partial class frmDetailMovie : Form
    {
        private LichChieuBLL _lichChieuBLL = new LichChieuBLL();
        private string _userName = "";
        private string _idLC = "";
        private string _pbPosterPath = "";
        private string _GioChieu = "";
        public frmDetailMovie()
        {
            InitializeComponent();
        }
        public void LoadMovie(string idPhim,string tenPhim, string posterPath, string ngayChieu, string userName)
        {
            lblNameMV.Text = tenPhim;
            pbPoster.ImageLocation = posterPath;
            _userName = userName;
            pbPoster.SizeMode = PictureBoxSizeMode.Zoom; // Thiết lập chế độ hiển thị hình ảnh là Zoom
            _pbPosterPath = posterPath;
            // Gọi BLL để lấy danh sách lịch chiếu theo ngày
            DateTime date = DateTime.Parse(ngayChieu);
            List<LichChieuPhimDTO> danhSachLichChieu = _lichChieuBLL.LayLichChieuCuaPhimTrongNgay(idPhim, date);

            // Nạp giờ bắt đầu vào ComboBox
            foreach (var lichChieu in danhSachLichChieu)
            {
                _GioChieu = $"{lichChieu.GioBatDau} - {lichChieu.GioKetThuc}";
                cboGioChieu.Items.Add(_GioChieu);
                lbGheTrong.Text = $"Số ghế còn lại: {lichChieu.SoGheConLai}/{lichChieu.SoGheTatCa}";
            }

            // Gán sự kiện chọn giờ chiếu
            cboGioChieu.SelectedIndexChanged += (s, e) =>
            {
                // Khi chọn giờ chiếu, cập nhật TextBox với thông tin phòng chiếu
                int selectedIndex = cboGioChieu.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < danhSachLichChieu.Count)
                {
                    LichChieuPhimDTO lichChieuDuocChon = danhSachLichChieu[selectedIndex];
                    txtPhongChieu.Text = lichChieuDuocChon.tenPhong; // Hiển thị phòng chiếu tương ứng
                    _idLC = lichChieuDuocChon.Id;
                }
            };
            if (cboGioChieu.Items.Count > 0)
            {
                cboGioChieu.SelectedIndex = 0;  
                _idLC = danhSachLichChieu[0].Id;


            }

        }
        private void frmDetailMovie_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            string selectedTime = cboGioChieu.SelectedItem.ToString();
            string tenPhim = lblNameMV.Text;
            string ngayChieu = "20/10/2024"; // Giả sử là ngày chiếu đã được truyền vào trước đó (hoặc lấy từ dữ liệu của bạn)

            frmSeatMovie seatMovieForm = new frmSeatMovie();

            seatMovieForm.LoadMovie(_idLC, tenPhim, _pbPosterPath, _GioChieu, _userName);

            seatMovieForm.ShowDialog();
            this.Close();
        }
    }
}
