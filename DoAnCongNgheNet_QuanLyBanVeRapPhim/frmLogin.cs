using System.Drawing.Drawing2D;
namespace DoAnCongNgheNet_QuanLyBanVeRapPhim
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.BorderStyle = BorderStyle.None;
            txtPassword.BorderStyle = BorderStyle.None;

            txtUsername.Region = new Region(CreateRoundedRectangle(txtUsername.ClientRectangle, 10));
            txtPassword.Region = new Region(CreateRoundedRectangle(txtPassword.ClientRectangle, 10));



        }




        private GraphicsPath CreateRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "chuong" && txtUsername.Text == "chuong123")
            {
                frmHome frmHome = new frmHome();
                frmHome.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc tài khoản");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}