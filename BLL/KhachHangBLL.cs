using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        public List<KhachHangDTO> GetAllKhachHang()
        {
            return khachHangDAL.GetAllKhachHang();
        }
        public KhachHangDTO GetChiTietKhachHang(string id)
        {
            return khachHangDAL.GetChiTietKhachHang(id);

        }
    }
}
