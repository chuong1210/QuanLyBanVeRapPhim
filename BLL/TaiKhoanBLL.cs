using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
        private KhachHangDAL khachHangDAL = new KhachHangDAL();


        public TaiKhoanDTO Login(string userName, string password)
        {
            return taiKhoanDAL.GetTaiKhoan(userName, password);
        }

        public bool Register(KhachHangDTO khachHang, TaiKhoanDTO taiKhoan)
        {


            int newCustomerId = khachHangDAL.AddKhachHang(khachHang);
            if (newCustomerId > 0)
            {
                // Nếu thêm khách hàng thành công, tạo tài khoản
                taiKhoan.IdRole = 2;
                taiKhoan.IdKH=newCustomerId;
                return taiKhoanDAL.Register(taiKhoan);
            }
            return false;
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            return taiKhoanDAL.ChangePassword(userName, oldPassword, newPassword);
        }
        public bool CheckOldPassword(string userName, string oldPassword)
        {
            return taiKhoanDAL.CheckOldPassword(userName, oldPassword);
        }


        }

}
