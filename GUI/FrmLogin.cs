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
namespace GUI
{
    public partial class FrmLogin : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public FrmLogin()
        {
            InitializeComponent();
            txtUsername.Region = new Region(CreateRoundedRectangle(txtUsername.ClientRectangle, 10));
            txtPassword.Region = new Region(CreateRoundedRectangle(txtPassword.ClientRectangle, 10));
            pt1.Region = new Region(CreateRoundedRectangle(pt1.ClientRectangle, 10));

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

        public void SetUserCredentials(string username, string password)
        {
            txtUsername.Text = username; // Tự động điền tên đăng nhập
            txtPassword.Text = password; // Tự động điền mật khẩu
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            var taiKhoan = taiKhoanBLL.Login(userName, password);
            if (taiKhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (taiKhoan.IdRole == 1)
                {
                    frmAdmin amin = new frmAdmin();
                    amin.Show();
                }
                else
                {
                    frmSideBar client = new frmSideBar();
                    client.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {

            frmRegister frm = new frmRegister();
            frm.Show();

            this.Hide();
        }

        private void pt1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0'; // Hiển thị mật khẩu
                pt1.BackgroundImage = Properties.Resources.show; // Đổi biểu tượng thành mắt mở
            }
            else
            {
                txtPassword.PasswordChar = '*'; // Ẩn mật khẩu
                pt1.BackgroundImage = Properties.Resources.hide; // Đổi biểu tượng thành mắt đóng
            }
        }
    }
}
