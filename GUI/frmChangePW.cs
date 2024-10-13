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
using DAL;

namespace GUI
{
    public partial class frmChangePW : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        private string _userName;
        public frmChangePW(string username)
        {
            InitializeComponent();
            _userName=username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPW.Text;
            string newPassword = txtNewPW.Text;
            string confirmPassword = txtConfirmPW.Text;

            // Validate inputs - very important!
            if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                txtError.Text = "Vui lòng nhập đầy đủ thông tin.";
                return; // Exit the function if validation fails
            }
            if (newPassword != confirmPassword)
            {
                txtError.Text = "Mật khẩu mới và xác nhận mật khẩu không khớp.";
                return; // Exit the function if validation fails
            }
            bool oldPasswordCorrect = taiKhoanBLL.CheckOldPassword(_userName, oldPassword); // Use a separate method
            if (!oldPasswordCorrect)
            {
                txtError.Text = "Mật khẩu cũ không chính xác.";
                return; // Exit if old password is wrong
            }
            bool success = taiKhoanBLL.ChangePassword(_userName, oldPassword, newPassword);

            if (success)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công.");
            }
            else
            {
                MessageBox.Show("Thất bại khi đổi mật khẩu.");
            }
        }
    }
}
