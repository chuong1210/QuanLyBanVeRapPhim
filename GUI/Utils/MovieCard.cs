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

namespace GUI.Utils
{
    public partial class MovieCard : UserControl
    {
        private Color borderColor = Color.FromArgb(100, 0, 0, 0); // Màu viền mờ
        private int borderWidth = 2; // Độ rộng của viền
        public event EventHandler BookTicketClicked;
        public MovieCard()
        {
            InitializeComponent();

            // this.BackColor = Color.Transparent; // Để không che khuất hình nền

            pbPoster.SizeMode = PictureBoxSizeMode.Zoom; // Thiết lập chế độ hiển thị hình ảnh là Zoom

            btnBookTicket.Click += (s, e) => DatVe_Click();

        }

        public void DatVe_Click()
        {
            // Sự kiện nhấn nút "Đặt vé"
            // Gọi một sự kiện hoặc phương thức mà bạn sẽ đăng ký từ frmSearchMovie
            BookTicketClicked?.Invoke(this, EventArgs.Empty);
        }
        public string TenPhim
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
        public string IdPhim { get; set; } // ID phim


        public string ThoiLuong
        {
            get { return lbDuration.Text; }
            set { lbDuration.Text = value; }
        }

        public string DaoDien
        {
            get { return lbDirector.Text; }
            set { lbDirector.Text = value; }
        }


        public string PosterPath
        {
            get { return pbPoster.ImageLocation; }
            set { pbPoster.ImageLocation = value; } // Đường dẫn đến hình ảnh

        }

        private void SetBackgroundImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
                this.BackgroundImageLayout = ImageLayout.Stretch; // Thiết lập cách hiển thị hình nền
            }
        }
        public void SetPosterFromResource()
        {
            this.BackgroundImage = Properties.Resources._739671; // Sử dụng hình ảnh từ tài nguyên
            this.BackgroundImageLayout = ImageLayout.Stretch; // Thiết lập cách hiển thị hình nền
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Vẽ viền xung quanh MovieCard
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Làm mịn viền
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - borderWidth, this.Height - borderWidth);
            }
        }


    }
}
