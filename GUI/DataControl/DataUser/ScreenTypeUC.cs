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
    public partial class ScreenTypeUC : UserControl
    {
        public ScreenTypeUC()
        {
            InitializeComponent();
            LoadScreenType();
        }
        public void LoadScreenType()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            LoaiManHinhBLL lmhBLL = new LoaiManHinhBLL();

            DataTable pDT = lmhBLL.GetListScreen();
            dtgvScreenType.DataSource = pDT;
            DataBindings(pDT);
        }
        private void DataBindings(DataTable pDT)
        {
            // Xoá các binding cũ
            txtScreenTypeID.DataBindings.Clear();
            txtScreenTypeName.DataBindings.Clear();


            // Thiết lập binding cho các TextBox từ BindingSource
            txtScreenTypeID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtScreenTypeName.DataBindings.Add("Text", pDT, "TenMH", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void dtgvScreenType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsertScreenType_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox trong form
                string tenMH = txtScreenTypeName.Text.Trim();

                // Kiểm tra dữ liệu nhập vào có hợp lệ không
                if (string.IsNullOrEmpty(tenMH))
                {
                    MessageBox.Show("Vui lòng nhập tên loại màn hình.");
                    return;
                }

                // Tạo đối tượng LoaiManHinhDTO từ dữ liệu nhập vào
                LoaiManHinhDTO loaiManHinh = new LoaiManHinhDTO
                {
                    TenMH = tenMH,
                    KichThuoc = 40, // Giá trị mặc định hoặc từ TextBox
                };

                // Gọi hàm thêm dữ liệu từ BLL
                LoaiManHinhBLL loaiManHinhBLL = new LoaiManHinhBLL();
                bool isSuccess = loaiManHinhBLL.ThemLoaiManHinh(loaiManHinh);

                // Hiển thị thông báo kết quả
                if (isSuccess)
                {
                    MessageBox.Show("Thêm loại màn hình thành công!");
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm loại màn hình.");
                }
            }
            catch (Exception ex)
            {
                // In chi tiết lỗi ra message box để dễ dàng debug
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnUpdateScreenType_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các TextBox trong form
                int id = int.Parse(txtScreenTypeID.Text.Trim());
                string tenMH = txtScreenTypeName.Text.Trim();

                // Kiểm tra dữ liệu nhập vào có hợp lệ không
                if (string.IsNullOrEmpty(tenMH))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ.");
                    return;
                }

                // Tạo đối tượng LoaiManHinhDTO từ dữ liệu nhập vào
                LoaiManHinhDTO loaiManHinh = new LoaiManHinhDTO
                {
                    Id = id,
                    TenMH = tenMH,
                    KichThuoc = 40,
                };

                // Gọi hàm sửa dữ liệu từ BLL
                LoaiManHinhBLL loaiManHinhBLL = new LoaiManHinhBLL();
                bool isSuccess = loaiManHinhBLL.SuaLoaiManHinh(loaiManHinh);

                // Hiển thị thông báo kết quả
                if (isSuccess)
                {
                    MessageBox.Show("Cập nhật loại màn hình thành công!");

                    // Cập nhật lại DataGridView
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật loại màn hình.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnDeleteScreenType_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ID loại màn hình từ DataGridView
                if (dtgvScreenType.SelectedRows.Count > 0)
                {
                    string id = dtgvScreenType.SelectedRows[0].Cells["Id"].Value.ToString();

                    // Xác nhận xóa
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa loại màn hình này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Gọi phương thức xóa từ BLL
                        LoaiManHinhBLL loaiManHinhBLL = new LoaiManHinhBLL();
                        bool isSuccess = loaiManHinhBLL.XoaLoaiManHinh(int.Parse(id));

                        // Hiển thị thông báo kết quả
                        if (isSuccess)
                        {
                            MessageBox.Show("Xóa loại màn hình thành công!");

                            // Cập nhật lại DataGridView
                            LoadGrid();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi xóa loại màn hình.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại màn hình cần xóa.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
