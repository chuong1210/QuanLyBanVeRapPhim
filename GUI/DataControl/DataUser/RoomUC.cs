using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DataControl.DataUser
{
    public partial class RoomUC : UserControl
    {
        public RoomUC()
        {
            InitializeComponent();
            LoadCinema();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadCinema()
        {
            LoadGrid();
            LoadScreens();
        }
        public void LoadGrid()
        {
            PhongChieuBLL pcBLL = new PhongChieuBLL();

            DataTable pDT = pcBLL.GetListCinema();
            dtgvRoom.DataSource = pDT;
            DataBindings(pDT);
        }
        public void LoadScreens()
        {
            PhongChieuBLL pcBLL = new PhongChieuBLL();
            DataTable screenDT = pcBLL.GetListManHinh(); // Lấy danh sách màn hình

            cboScreen.DataSource = screenDT; // Thiết lập DataSource cho ComboBox
            cboScreen.DisplayMember = "TenMH"; // Tên trường hiển thị
            cboScreen.ValueMember = "id"; // Tên trường giá trị
        }
        private void DataBindings(DataTable pDT)
        {
            // Xoá các binding cũ
            txtRoomID.DataBindings.Clear();
            txtRoomName.DataBindings.Clear();
            cboScreen.DataBindings.Clear();
            txtRoomSeats.DataBindings.Clear();
            cboTrangThaiChoNgoi.DataBindings.Clear();
            txtNumberOfRows.DataBindings.Clear();
            txtSeatsPerRow.DataBindings.Clear();

            // Thiết lập binding cho các TextBox từ BindingSource
            txtRoomID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtRoomName.DataBindings.Add("Text", pDT, "TenPhong", true, DataSourceUpdateMode.OnPropertyChanged);
            cboScreen.DataBindings.Add("SelectedValue", pDT, "idManHinh", true, DataSourceUpdateMode.OnPropertyChanged); // Sửa thành SelectedValue
            txtRoomSeats.DataBindings.Add("Text", pDT, "SoGheNgoi", true, DataSourceUpdateMode.OnPropertyChanged);
            cboTrangThaiChoNgoi.DataBindings.Add("SelectedValue", pDT, "TrangThaiChoNgoi", true, DataSourceUpdateMode.OnPropertyChanged);
            txtNumberOfRows.DataBindings.Add("Text", pDT, "SoHangGhe", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSeatsPerRow.DataBindings.Add("Text", pDT, "SoGheMotHang", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void dtgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsertRoom_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox và ComboBox
                string tenPhong = txtRoomName.Text.Trim();
                string idManHinh = cboScreen.SelectedValue?.ToString(); // Lấy giá trị id từ ComboBox
                int soHangGhe = int.Parse(txtNumberOfRows.Text.Trim());
                int soGheMotHang = int.Parse(txtSeatsPerRow.Text.Trim());
                int soGheNgoi = soHangGhe * soGheMotHang;

                // Kiểm tra trạng thái ComboBox
                if (cboTrangThaiChoNgoi.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái cho phòng chiếu.");
                    return;
                }
                int trangThaiChoNgoi = (int)cboTrangThaiChoNgoi.SelectedValue; // Lấy giá trị trạng thái (0 hoặc 1)

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenPhong) || string.IsNullOrEmpty(idManHinh))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                // Tạo đối tượng PhongChieuDTO
                PhongChieuDTO phongChieu = new PhongChieuDTO
                {
                    TenPhong = tenPhong,
                    idManHinh = idManHinh,
                    SoGheNgoi = soGheNgoi,
                    TrangThaiChoNgoi = trangThaiChoNgoi,
                    SoHangGhe = soHangGhe,
                    SoGheMotHang = soGheMotHang
                };

                // Gọi hàm thêm từ BLL
                PhongChieuBLL phongChieuBLL = new PhongChieuBLL();
                bool isSuccess = phongChieuBLL.ThemPhongChieu(phongChieu);

                // Hiển thị kết quả
                if (isSuccess)
                {
                    MessageBox.Show("Thêm phòng chiếu thành công!");
                    LoadGrid(); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm phòng chiếu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        //private void btnDeleteRoom_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int id = Convert.ToInt32(txtRoomID.Text); // Hoặc TextBox tùy vào cách bạn lấy ID

        //        if (id == 0)
        //        {
        //            MessageBox.Show("Vui lòng chọn phòng chiếu để xóa.");
        //            return;
        //        }

        //        // Xác nhận xóa
        //        DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng chiếu này?", "Xóa phòng chiếu", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.No)
        //        {
        //            return;
        //        }

        //        // Gọi BLL để xóa phòng chiếu
        //        PhongChieuBLL phongChieuBLL = new PhongChieuBLL();
        //        bool isSuccess = phongChieuBLL.XoaPhongChieu(id);

        //        if (isSuccess)
        //        {
        //            MessageBox.Show("Xóa phòng chiếu thành công!");
        //            LoadGrid(); // Cập nhật lại DataGridView sau khi xóa
        //        }
        //        else
        //        {
        //            MessageBox.Show("Lỗi khi xóa phòng chiếu.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
        //    }
        //}

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox và ComboBox
                if (string.IsNullOrEmpty(txtRoomID.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng chọn phòng chiếu để sửa.");
                    return;
                }

                int idPhongChieu = int.Parse(txtRoomID.Text.Trim()); // ID không được để trống
                string tenPhong = txtRoomName.Text.Trim();
                string idManHinh = cboScreen.SelectedValue?.ToString(); // Lấy giá trị id từ ComboBox
                int soHangGhe = int.Parse(txtNumberOfRows.Text.Trim());
                int soGheMotHang = int.Parse(txtSeatsPerRow.Text.Trim());
                int soGheNgoi = soHangGhe * soGheMotHang;

                // Kiểm tra trạng thái ComboBox
                if (cboTrangThaiChoNgoi.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn trạng thái cho phòng chiếu.");
                    return;
                }
                int trangThaiChoNgoi = (int)cboTrangThaiChoNgoi.SelectedValue; // Lấy giá trị trạng thái (0 hoặc 1)

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenPhong) || string.IsNullOrEmpty(idManHinh))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return;
                }

                // Tạo đối tượng PhongChieuDTO
                PhongChieuDTO phongChieu = new PhongChieuDTO
                {
                    id = idPhongChieu,
                    TenPhong = tenPhong,
                    idManHinh = idManHinh,
                    SoGheNgoi = soGheNgoi,
                    TrangThaiChoNgoi = trangThaiChoNgoi,
                    SoHangGhe = soHangGhe,
                    SoGheMotHang = soGheMotHang
                };

                // Gọi hàm sửa từ BLL
                PhongChieuBLL phongChieuBLL = new PhongChieuBLL();
                bool isSuccess = phongChieuBLL.SuaPhongChieu(phongChieu);

                // Hiển thị kết quả
                if (isSuccess)
                {
                    MessageBox.Show("Sửa phòng chiếu thành công!");
                    LoadGrid(); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa phòng chiếu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void RoomUC_Load(object sender, EventArgs e)
        {
            var trangThai = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(0, "Trống"),
                new KeyValuePair<int, string>(1, "Đủ")
            };

            cboTrangThaiChoNgoi.DataSource = trangThai;
            cboTrangThaiChoNgoi.DisplayMember = "Value"; // Hiển thị "Trống" hoặc "Đủ"
            cboTrangThaiChoNgoi.ValueMember = "Key";    // Lưu giá trị 0 hoặc 1

        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID từ ComboBox hoặc TextBox (giả sử ID được chọn từ ComboBox hoặc TextBox)
                int id = int.Parse(txtRoomID.Text); // Hoặc TextBox tùy vào cách bạn lấy ID

                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn phòng chiếu để xóa.");
                    return;
                }

                // Xác nhận xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng chiếu này?", "Xóa phòng chiếu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                // Gọi BLL để xóa phòng chiếu
                PhongChieuBLL phongChieuBLL = new PhongChieuBLL();
                bool isSuccess = phongChieuBLL.XoaPhongChieu(id);

                if (isSuccess)
                {
                    MessageBox.Show("Xóa phòng chiếu thành công!");
                    LoadGrid(); // Cập nhật lại DataGridView sau khi xóa
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa phòng chiếu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
