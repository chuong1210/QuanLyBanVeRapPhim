using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using GUI.Utils;

namespace GUI
{
    public partial class frmGunaLogin : Form
    {
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        public frmGunaLogin()
        {
            InitializeComponent();

        }
        public void SetUserCredentials(string username, string password)
        {
            txtUsername.Text = username; // Tự động điền tên đăng nhập
            txtPassword.Text = password; // Tự động điền mật khẩu
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = guna2ToggleSwitch1.Checked ? '\0' : '*';

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
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
                    frmSideBar client = new frmSideBar(taiKhoan.UserName);
                    amin.Show();
                }
                else
                {
                    frmSideBar client = new frmSideBar(taiKhoan.UserName);
                    UserSession.Username = userName;
                    client.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();

            this.Hide();
        }
    }
}
