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
            DisplayMovies(movies); // Display movies in the UI
        }

        private string GetImagePath(string poster)
        {
            if (string.IsNullOrEmpty(poster))
            {
                string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
                return Path.Combine(projectPath, "images", "culao.png");
            }
            else
            {
                return Path.Combine(Application.StartupPath, "images", poster);
            }
        }
        private void DisplayMovies(List<DsPhimDTO> movies)
        {
            flowLayoutPanelMovies.Controls.Clear(); // Clear previous controls

            if (movies.Count > 0)
            {
                flowLayoutPanelMovies.Enabled = true;
                flowLayoutPanelMovies.Visible = true;
                lbPhim.Visible = true;
                flowLayoutPanelMovies.Width = 800; // Width for displaying the movie cards

                lbPhim.Text = "Danh sách phim hiện tại"; // Set label text

                foreach (var movie in movies)
                {
                    MovieCard movieCard = new MovieCard
                    {
                        TenPhim = movie.PhimDTO.TenPhim,
                        ThoiLuong = movie.PhimDTO.ThoiLuong.ToString() + "'",
                        DaoDien = movie.PhimDTO.DaoDien.ToString(),
                        IdPhim = movie.PhimDTO.Id.ToString(),
                        PosterPath = GetImagePath(movie.PhimDTO.Poster.ToString())
                    };

                    // Register the click event
                    movieCard.BookTicketClicked += (s, args) =>
                    {
                        frmDetailMovie movieDetail = new frmDetailMovie();
                        movieDetail.LoadMovie(movie.PhimDTO.Id.ToString(), movieCard.TenPhim, movieCard.PosterPath, dtpNgayChieu.Value.ToString(), _userName);
                        movieDetail.ShowDialog(); // Show movie details
                    };

                    movieCard.Margin = new Padding(10); // Set margin for the movie card

                    flowLayoutPanelMovies.Controls.Add(movieCard); // Add movie card to the flow layout panel
                }
            }
            else
            {
                lbPhim.Visible = true;
                lbPhim.Text = "Không có phim nào trong ngày hôm nay"; // No movies found
            }
        }

        private void frmSearchMovie_Load(object sender, EventArgs e)
        {
            cbGenre.DataSource = phimBLL.DanhSachTheLoai();
            cbGenre.DisplayMember = "TenTheLoai";
            cbGenre.ValueMember= "TenTheLoai";

            DateTime today = DateTime.Today; // Get today's date
            List<DsPhimDTO> movies = phimBLL.TimPhim(null, dtpNgayChieu.Value); // You may need to adjust the method signature to accept null for genre

            DisplayMovies(movies); 

            panelLine.Height = 2;
        }



    }
}
