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
using DTO;
using DAL;
using Microsoft.VisualBasic.Devices;
using static Azure.Core.HttpHeader;
using System.IO;
namespace GUI.DataControl.DataUser
{
    public partial class MovieUC : UserControl
    {
        public MovieUC()
        {
            InitializeComponent();
            LoadMovie();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadMovie()
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            PhimBLL phimBLL = new PhimBLL();
            DataTable pDT = phimBLL.getListMovie();
            dtgvMovie.DataSource = pDT;

            // Thiết lập ràng buộc dữ liệu
            DataBindings(pDT);
        }

        private void DataBindings(DataTable pDT)
        {
            txtMovieID.DataBindings.Clear();
            txtMovieName.DataBindings.Clear();
            txtMovieDescription.DataBindings.Clear();
            txtMovieLength.DataBindings.Clear();
            dtmMovieStart.DataBindings.Clear();
            dtmMovieEnd.DataBindings.Clear();
            txtMovieProductor.DataBindings.Clear();
            txtMovieDirector.DataBindings.Clear();
            txtMovieYear.DataBindings.Clear();
            txtGenre.DataBindings.Clear();
            txtActor.DataBindings.Clear();


            // Thiết lập binding cho các TextBox từ BindingSource
            txtMovieID.DataBindings.Add("Text", pDT, "id", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieName.DataBindings.Add("Text", pDT, "TenPhim", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieDescription.DataBindings.Add("Text", pDT, "MoTa", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieLength.DataBindings.Add("Text", pDT, "ThoiLuong", true, DataSourceUpdateMode.OnPropertyChanged);
            dtmMovieStart.DataBindings.Add("Value", pDT, "NgayKetThuc", true, DataSourceUpdateMode.OnPropertyChanged);
            dtmMovieEnd.DataBindings.Add("Value", pDT, "SanXuat", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieProductor.DataBindings.Add("Text", pDT, "DaoDien", true, DataSourceUpdateMode.OnPropertyChanged);
            txtActor.DataBindings.Add("Text", pDT, "DienVien", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieYear.DataBindings.Add("Text", pDT, "NamSX", true, DataSourceUpdateMode.OnPropertyChanged);
            txtMovieDirector.DataBindings.Add("Text", pDT, "SanXuat", true, DataSourceUpdateMode.OnPropertyChanged);

            var bindingSource = new BindingSource();
            bindingSource.DataSource = pDT;

            // Lấy dữ liệu thể loại từ cột MoTa
            string movieDescription = pDT.Rows[0]["MoTa"].ToString();

            if (!string.IsNullOrEmpty(movieDescription))
            {
                // Tách chuỗi MoTa thành các thể loại (giả sử các thể loại cách nhau bằng dấu phẩy)
                string[] genres = movieDescription.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Lấy tối đa 3 thể loại đầu tiên nếu có nhiều hơn 3 thể loại
                var selectedGenres = genres.Take(3);

                // Ghép các thể loại lại thành chuỗi (có thể thêm dấu phẩy giữa các thể loại)
                string genreText = string.Join(", ", selectedGenres);

                // Thiết lập binding cho TextBox thể loại
                txtGenre.DataBindings.Add("Text", pDT, "MoTa", true, DataSourceUpdateMode.OnPropertyChanged);

                // Cập nhật TextBox thể loại với các thể loại lấy từ mô tả
                txtGenre.Text = genreText;  // Cập nhật TextBox ngay lập tức với chuỗi thể loại
            }
        }


        private void MovieUC_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường hợp input rỗng hoặc không hợp lệ
            if (string.IsNullOrEmpty(txtMovieName.Text) || string.IsNullOrEmpty(txtMovieDescription.Text) ||
                string.IsNullOrEmpty(txtMovieLength.Text) || string.IsNullOrEmpty(txtMovieYear.Text) ||
                string.IsNullOrEmpty(txtMovieProductor.Text) || string.IsNullOrEmpty(txtMovieDirector.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return; // Dừng hàm nếu có trường rỗng
            }

            // Kiểm tra xem ThoiLuong và NamSX có phải là số hợp lệ không
            if (!float.TryParse(txtMovieLength.Text, out float thoiLuong))
            {
                MessageBox.Show("Thời lượng phim phải là một số hợp lệ.");
                return;
            }

            //if (!int.TryParse(txtMovieYear.Text, out int namSX))
            //{
            //    MessageBox.Show("Năm sản xuất phải là một số hợp lệ.");
            //    return;
            //}

            //// Kiểm tra NgayKhoiChieu và NgayKetThuc
            //if (dtmMovieStart.Value >= dtmMovieEnd.Value)
            //{
            //    MessageBox.Show("Ngày kết thúc phải sau ngày khởi chiếu.");
            //    return;
            //}

            // Tạo đối tượng PhimDTO
            PhimDTO phim = new PhimDTO()
            {
                TenPhim = txtMovieName.Text,
                MoTa = txtMovieDescription.Text,
                ThoiLuong = int.TryParse(txtMovieLength.Text, out int length) ? length : 0,
                NgayKhoiChieu = dtmMovieStart.Value,
                NgayKetThuc = dtmMovieEnd.Value,
                SanXuat = txtMovieProductor.Text,
                DaoDien = txtMovieDirector.Text,
                DienVien = txtActor.Text,
                NamSX = int.TryParse(txtMovieYear.Text, out int year) ? year : 0,
                Poster = ptrMovie.Image.ToString()
            };

            PhimDAL phimDAL = new PhimDAL();
            bool result = phimDAL.AddMovie(phim);

            if (result)
            {
                MessageBox.Show("Thêm phim thành công!");
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại!");
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);  // Lưu ảnh vào MemoryStream
                return ms.ToArray();  // Chuyển đổi thành byte[]
            }
        }
        private void btnUpLoadPtr_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đặt ảnh lên PictureBox
                ptrMovie.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            PhimDTO phim = new PhimDTO()
            {
                Id =txtMovieID.Text, // Giả sử có trường ID phim để tìm kiếm
                TenPhim = txtMovieName.Text,
                MoTa = txtMovieDescription.Text,
                ThoiLuong = float.Parse(txtMovieLength.Text),
                NgayKhoiChieu = dtmMovieStart.Value,
                NgayKetThuc = dtmMovieEnd.Value,
                SanXuat = txtMovieProductor.Text,
                DaoDien = txtMovieDirector.Text,
                NamSX = int.Parse(txtMovieYear.Text),
            };

            PhimBLL phimBLL = new PhimBLL();
            // Gọi phương thức cập nhật phim từ BLL
            bool result = phimBLL.UpdateMovie(phim);

            // Thông báo kết quả
            if (result)
            {
                MessageBox.Show("Cập nhật phim thành công!");
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Cập nhật phim thất bại!");
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            int movieID = int.Parse(txtMovieID.Text); // Giả sử có TextBox chứa ID phim cần xóa

            PhimBLL phimBLL = new PhimBLL();
            // Gọi phương thức xóa phim từ BLL
            bool result = phimBLL.DeleteMovie(movieID);

            // Thông báo kết quả
            if (result)
            {
                MessageBox.Show("Xóa phim thành công!");
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Xóa phim thất bại!");
            }
        }
    }
}
