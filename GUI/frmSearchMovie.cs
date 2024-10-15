using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frmSearchMovie : Form
    {
        private PhimBLL phimBLL;
        private string _userName;
        public frmSearchMovie(string userName)
        {
            InitializeComponent();
            panelFilter.Width = 1200;
            Label lblNoMovies = new Label
            {
                Text = "Không tìm thấy phim nào.",
                ForeColor = Color.Red,
                AutoSize = true,
                Visible = false // Để ẩn label này ban đầu
            };

            _userName = userName;
            phimBLL = new PhimBLL();
        }

        private void searchPN_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Adjust the color and offsets as needed
            Color shadowColor = Color.FromArgb(100, 0, 0, 0); // Adjust opacity and color as needed
            int shadowOffset = 5;

            // Create a rectangle to draw the raised effect on.  
            Rectangle rect = new Rectangle(0, 0, panelFilter.ClientSize.Width, panelFilter.ClientSize.Height);

            // Create a path for the panel border
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rect);


            // Draw the shadow
            using (Pen shadowPen = new Pen(shadowColor, 2))
            {
                g.DrawPath(shadowPen, path);
            }

            // Adjust the color for the panel itself
            Brush panelBrush = new SolidBrush(Color.White);
            g.FillPath(panelBrush, path);

            panelFilter.Region = new Region(path);// Hiển thị bóng đổ lên panelFilter
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            string selectedGenre = cbGenre.SelectedValue.ToString();
            DateTime selectedDate = dtpNgayChieu.Value;

            // Lấy danh sách phim theo thể loại và ngày chiếu
            List<DsPhimDTO> movies = phimBLL.TimPhim(selectedGenre, selectedDate);

            flowLayoutPanelMovies.Controls.Clear();
            if (movies.Count > 0)
            {
                flowLayoutPanelMovies.Enabled = true;
                flowLayoutPanelMovies.Visible = true;
                lbPhim.Visible = true;
                flowLayoutPanelMovies.Width = 800; // Chiều rộng tổng cho 5 card phim, cộng với khoảng cách giữa chúng

                lbPhim.Text = "Danh sách phim hiện tại";

                foreach (var movie in movies)
                {
                    MovieCard movieCard = new MovieCard();

                    movieCard.TenPhim = movie.PhimDTO.TenPhim;
                    movieCard.ThoiLuong = movie.PhimDTO.ThoiLuong.ToString() + "'";
                    movieCard.DaoDien = movie.PhimDTO.DaoDien.ToString();
                    movieCard.IdPhim = movie.PhimDTO.Id.ToString();
                    string imagePath = GetImagePath(movie.PhimDTO.Poster.ToString());
                    string idLichChieu =movie.idLCP;


                    movieCard.PosterPath = imagePath;

                    // Đăng ký sự kiện DatVeClicked
                    movieCard.BookTicketClicked += (s, args) =>
                    {
                        // Mở form đặt vé và truyền các thông tin cần thiết
                        frmSeatMovie datVeForm = new frmSeatMovie();
                        datVeForm.LoadMovie(idLichChieu, movieCard.TenPhim, movieCard.PosterPath,dtpNgayChieu.Value.ToString("dd/MM/yyyy"), _userName);
                        datVeForm.ShowDialog(); // Hoặc Show nếu bạn không muốn form là modal
                    };

                    // Điều chỉnh kích thước của MovieCard nếu cần
                    //movieCard.Width = 200; // Hoặc bất kỳ kích thước nào bạn muốn
                    //movieCard.Height = 300;
                    movieCard.Margin = new Padding(10);

                    // Thêm movieCard vào FlowLayoutPanel
                    flowLayoutPanelMovies.Controls.Add(movieCard);
                }
            }

            else
            {
                lbPhim.Text = "Không có phim nào trong ngày đang chọn";
            }
        }

        private string GetImagePath(string poster)
        {
            if (string.IsNullOrEmpty(poster))
            {
                string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                return Path.Combine(projectPath, "images", "logo.png");
            }
            else
            {
                return Path.Combine(Application.StartupPath, "images", poster);
            }
        }

        private void frmSearchMovie_Load(object sender, EventArgs e)
        {
            cbGenre.DataSource = phimBLL.DanhSachTheLoai();
            cbGenre.DisplayMember = "TenTheLoai";
            cbGenre.ValueMember= "TenTheLoai";


            panelLine.Height = 2;
        }
    }
}
