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
    public class LichChieuPhimBLL
    {
        LichChieuPhimDAL lcpDAL = new LichChieuPhimDAL();
        public DataTable GetListShowTime()
        {
            return lcpDAL.GetListShowTime();
        }
        public DataTable GetListManHinh()
        {
            return lcpDAL.GetListShowTime();
        }
        public bool InsertLichChieu(LichChieuPhimDTO lichChieu)
        {
            return lcpDAL.InsertLichChieu(lichChieu);
        }
        public bool DeleteLichChieu(int id)
        {
            LichChieuPhimDAL dal = new LichChieuPhimDAL();
            return dal.DeleteLichChieu(id);
        }
        public bool UpdateLichChieu(LichChieuPhimDTO lichChieu)
        {
            LichChieuPhimDAL dal = new LichChieuPhimDAL();
            return dal.UpdateLichChieu(lichChieu);
        }
    }
}
