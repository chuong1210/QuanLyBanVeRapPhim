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
    public partial class GenreUC : UserControl
    {
        public GenreUC()
        {
            InitializeComponent();
            LoadGenre();
        }

        public void LoadGenre()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            TheLoaiBLL tlBLL = new TheLoaiBLL();

            DataTable pDT = tlBLL.getListGenre();
            dgtvGenre.DataSource = pDT;
            DataBindings(pDT);
        }
        private void DataBindings(DataTable pDT)
        {
            // Xoá các binding cũ

            txtGenreID.DataBindings.Clear();
            txtGenreName.DataBindings.Clear();
            txtDescriptionGenre.DataBindings.Clear();

            // Thiết lập binding cho các TextBox từ BindingSource
            txtGenreID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged); // 
            txtGenreName.DataBindings.Add("Text", pDT, "TenTheLoai", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDescriptionGenre.DataBindings.Add("Text", pDT, "MoTa", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnInsertGenre_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTheLoai = txtGenreName.Text.Trim();
                string moTa = txtDescriptionGenre.Text.Trim();

                if (string.IsNullOrEmpty(tenTheLoai))
                {
                    MessageBox.Show("Vui lòng nhập tên thể loại.");
                    return;
                }

                TheLoaiDTO newTheLoai = new TheLoaiDTO
                {
                    TenTheLoai = tenTheLoai,
                    MoTa = moTa
                };

                TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
                bool result = theLoaiBLL.ThemTheLoai(newTheLoai);

                if (result)
                {
                    MessageBox.Show("Thêm thể loại thành công!");
                    LoadGrid(); // Cập nhật lại dữ liệu sau khi thêm
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm thể loại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtGenreID.Text.Trim(); // Lấy ID từ TextBox hoặc ComboBox

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn thể loại để xóa.");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này?", "Xóa thể loại", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
                bool result = theLoaiBLL.XoaTheLoai(id);

                if (result)
                {
                    MessageBox.Show("Xóa thể loại thành công!");
                    LoadGrid(); // Cập nhật lại dữ liệu sau khi xóa
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa thể loại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            try
            {
                int id =int.Parse(txtGenreID.Text.Trim());
                string tenTheLoai =txtGenreName.Text.Trim();
                string moTa = txtDescriptionGenre.Text.Trim();

                if (string.IsNullOrEmpty(tenTheLoai))
                {
                    MessageBox.Show("Vui lòng nhập tên thể loại.");
                    return;
                }

                TheLoaiDTO updatedTheLoai = new TheLoaiDTO
                {
                    Id = id,
                    TenTheLoai = tenTheLoai,
                    MoTa = moTa
                };

                TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
                bool result = theLoaiBLL.SuaTheLoai(updatedTheLoai);

                if (result)
                {
                    MessageBox.Show("Sửa thể loại thành công!");
                    LoadGrid(); // Cập nhật lại dữ liệu sau khi sửa
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa thể loại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
