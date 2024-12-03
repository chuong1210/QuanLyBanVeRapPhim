using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI.DataControl.DataUser
{
    public partial class ShowTimeUC : UserControl
    {
        public ShowTimeUC()
        {
            InitializeComponent();
            LoadShowTime();
        }

        private void dtgvShowTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadShowTime()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            LichChieuPhimBLL lmhBLL = new LichChieuPhimBLL();

            DataTable pDT = lmhBLL.GetListShowTime();
            dtgvShowTime.DataSource = pDT;
            DataBindings(pDT);
        }

        private void DataBindings(DataTable pDT)
        {
            // Xóa các binding cũ trước khi thêm mới
            txtMaLichChieu.DataBindings.Clear();
            txtGiaVe.DataBindings.Clear();
            cboPhim.DataBindings.Clear();
            cboPhong.DataBindings.Clear();
            dtmThoiGianChieu.DataBindings.Clear();
            txtTrangThaiChoNgoi.DataBindings.Clear();

            // Thiết lập binding cho các TextBox từ DataTable
            txtMaLichChieu.DataBindings.Add("Text", pDT, "Id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtGiaVe.DataBindings.Add("Text", pDT, "GiaVePhim", true, DataSourceUpdateMode.OnPropertyChanged);

            // Thiết lập binding cho ComboBox (Phim)
            cboPhim.DataBindings.Add("SelectedValue", pDT, "IdPhong", true, DataSourceUpdateMode.OnPropertyChanged);

            // Thiết lập binding cho ComboBox (Phòng Chiếu)
            cboPhong.DataBindings.Add("SelectedValue", pDT, "IdPhong", true, DataSourceUpdateMode.OnPropertyChanged);

            // Thiết lập binding cho DateTimePicker (Thời Gian Chiếu)
            dtmThoiGianChieu.DataBindings.Add("Value", pDT, "ThoiGianChieu", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTrangThaiChoNgoi.DataBindings.Add("Text", pDT, "TrangThaiChieu", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void LoadCBPhim()
        {
            try
            {
                PhimBLL p = new PhimBLL();
                List<PhimDTO> movies = p.GetListMovieList();

                if (movies != null && movies.Count > 0)
                {
                    cboPhim.DataSource = movies;
                    cboPhim.DisplayMember = "TenPhim";
                    cboPhim.ValueMember = "Id";
                }
                else
                {
                    cboPhim.DataSource = null;
                    MessageBox.Show("Không có dữ liệu phim để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách phim: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadCbPhong()
        {
            PhongChieuBLL phongChieuBLL = new PhongChieuBLL();
            List<PhongChieuDTO> phongChieuList = phongChieuBLL.GetListPhongChieu();

            cboPhong.DataSource = phongChieuList;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "id";
        }
        private void ShowTimeUC_Load(object sender, EventArgs e)
        {
            LoadCBPhim();
            LoadCbPhong();
        }

        private void btnInsertShowTime_Click(object sender, EventArgs e)
        {
            LichChieuPhimDTO lichChieu = new LichChieuPhimDTO
            {
                ThoiGianChieu = dtmThoiGianChieu.Value,
                IdPhim = int.Parse(cboPhim.SelectedValue.ToString()),
                IdPhong = int.Parse(cboPhong.SelectedValue.ToString()),
                GiaVePhim = decimal.Parse(txtGiaVe.Text),
                TrangThaiChieu = int.Parse(txtTrangThaiChoNgoi.Text)
            };

            LichChieuPhimBLL lichChieuBLL = new LichChieuPhimBLL();
            if (lichChieuBLL.InsertLichChieu(lichChieu))
            {
                MessageBox.Show("Thêm lịch chiếu thành công!", "Thông báo");
                LoadGrid(); // Refresh lại DataGridView
            }
            else
            {
                MessageBox.Show("Thêm lịch chiếu thất bại!", "Thông báo");
            }
        }

        private void btnDeleteShowTime_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedId = int.Parse(txtMaLichChieu.Text); // Lấy ID từ TextBox hoặc GridView

                LichChieuPhimBLL lichChieuBLL = new LichChieuPhimBLL();
                if (lichChieuBLL.DeleteLichChieu(selectedId))
                {
                    MessageBox.Show("Xóa lịch chiếu thành công!", "Thông báo");
                    LoadGrid(); // Refresh lại DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa lịch chiếu thất bại! Kiểm tra lại ID.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Thông báo lỗi");
            }
        }

        private void btnUpdateShowTime_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin lịch chiếu từ các điều khiển trên form
                LichChieuPhimDTO lichChieu = new LichChieuPhimDTO
                {
                    Id = int.Parse(txtMaLichChieu.Text),  // ID lịch chiếu cần sửa
                    ThoiGianChieu = dtmThoiGianChieu.Value,  // Thời gian chiếu mới
                    IdPhong = int.Parse(cboPhong.SelectedValue.ToString()),  // Phòng chiếu
                    GiaVePhim = decimal.Parse(txtGiaVe.Text),  // Giá vé
                    IdPhim = int.Parse(cboPhim.SelectedValue.ToString()),  // Phim
                    TrangThaiChieu = int.Parse(txtTrangThaiChoNgoi.Text)  // Trạng thái chiếu
                };

                LichChieuPhimBLL lichChieuBLL = new LichChieuPhimBLL();
                if (lichChieuBLL.UpdateLichChieu(lichChieu))
                {
                    MessageBox.Show("Cập nhật lịch chiếu thành công!", "Thông báo");
                    LoadGrid(); // Refresh lại DataGridView hoặc danh sách hiển thị
                }
                else
                {
                    MessageBox.Show("Cập nhật lịch chiếu thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Thông báo lỗi");
            }
        }
    }
}
