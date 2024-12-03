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
using DTO;

namespace GUI
{
    public partial class frmRegister : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            //FrmLogin login = new FrmLogin();
            frmGunaLogin login = new frmGunaLogin();
            login.Show();

            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO
            {
                HoTen = txtFullName.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                DiemTichLuy = 0,
                GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                NgaySinh = dtKH.Value.ToString("dd/MM/yyyy"),

            };

            TaiKhoanDTO taiKhoan = new TaiKhoanDTO
            {
                UserName = txtUsername.Text,
                PassWord = txtPassword.Text
            };

            // Gọi BLL để xử lý đăng ký
            bool result = taiKhoanBLL.Register(khachHang, taiKhoan);
            if (result)
            {
                DialogResult dialogResult = MessageBox.Show("Đăng ký thành công! Bạn có muốn quay lại trang đăng nhập?",
              "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Mở lại màn hình đăng nhập và tự động nhập tên đăng nhập và mật khẩu
                    //FrmLogin loginForm = new FrmLogin();
                    //loginForm.SetUserCredentials(taiKhoan.UserName, taiKhoan.PassWord);
                    //loginForm.Show();   
                    frmGunaLogin loginForm = new frmGunaLogin();
                    loginForm.SetUserCredentials(taiKhoan.UserName, taiKhoan.PassWord);
                    loginForm.Show();

                    this.Hide(); // Ẩn form đăng ký
                }
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }
        private bool IsValidEmail(string email)
        {
            // Biểu thức chính quy kiểm tra định dạng email
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                lblEmailError.Visible = true; // Hiển thị thông báo lỗi
            }
            else
            {
                lblEmailError.Visible = false; // Ẩn thông báo lỗi khi email hợp lệ
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPW.Text)
            {
                lblPasswordError.Visible = true;
            }
            else
            {
                lblPasswordError.Visible = false;
            }
        }

        private void txtConfirmPW_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPW.Text)
            {
                lblPasswordError.Visible = true;
            }
            else
            {
                lblPasswordError.Visible = false;
            }
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

        private void pt2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPW.PasswordChar == '*')
            {
                txtConfirmPW.PasswordChar = '\0'; // Hiển thị mật khẩu
                pt2.BackgroundImage = Properties.Resources.show; // Đổi biểu tượng thành mắt mở
            }
            else
            {
                txtConfirmPW.PasswordChar = '*'; // Ẩn mật khẩu
                pt2.BackgroundImage = Properties.Resources.hide; // Đổi biểu tượng thành mắt đóng
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO
            {
                HoTen = txtFullName.Text,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                DiemTichLuy = 0,
                GioiTinh = rdoNam.Checked ? "Nam" : "Nữ",
                NgaySinh = dtKH.Value.ToString("dd/MM/yyyy"),

            };

            TaiKhoanDTO taiKhoan = new TaiKhoanDTO
            {
                UserName = txtUsername.Text,
                PassWord = txtPassword.Text
            };

            // Gọi BLL để xử lý đăng ký
            bool result = taiKhoanBLL.Register(khachHang, taiKhoan);
            if (result)
            {
                DialogResult dialogResult = MessageBox.Show("Đăng ký thành công! Bạn có muốn quay lại trang đăng nhập?",
              "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    // Mở lại màn hình đăng nhập và tự động nhập tên đăng nhập và mật khẩu
                    //FrmLogin loginForm = new FrmLogin();
                    //loginForm.SetUserCredentials(taiKhoan.UserName, taiKhoan.PassWord);
                    //loginForm.Show();   
                    frmGunaLogin loginForm = new frmGunaLogin();
                    loginForm.SetUserCredentials(taiKhoan.UserName, taiKhoan.PassWord);
                    loginForm.Show();

                    this.Hide(); // Ẩn form đăng ký
                }
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }
        }
    }
}

