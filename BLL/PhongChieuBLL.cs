using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhongChieuBLL
    {
        PhongChieuDAL pcDAL=new PhongChieuDAL();
        public DataTable GetListCinema()
        {
            return pcDAL.GetListCinema();
        }
        public DataTable GetListManHinh()
        {
            return pcDAL.GetListScreen();
        }
        public List<PhongChieuDTO> GetListPhongChieu()
        {
            return pcDAL.GetListPhongChieu();
        }
        public bool ThemPhongChieu(PhongChieuDTO phongChieu)
        {
            PhongChieuDAL dal = new PhongChieuDAL();
            return dal.ThemPhongChieu(phongChieu);
        }
        public bool SuaPhongChieu(PhongChieuDTO phongChieu)
        {
            PhongChieuDAL dal = new PhongChieuDAL();
            return dal.SuaPhongChieu(phongChieu);
        }
        public bool XoaPhongChieu(int id)
        {
            try
            {
                return pcDAL.DeletePhongChieu(id);
            }
            catch (Exception ex)
            {
                // Có thể ghi log hoặc ném lại ngoại lệ cho UI xử lý
                throw new Exception("Xóa phòng chiếu thất bại: " + ex.Message);
            }
        }

    }
}
