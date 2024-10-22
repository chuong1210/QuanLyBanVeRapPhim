using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
  public  class LichChieuBLL
    {
        private  LichChieuDAL lichChieuDAL = new LichChieuDAL();
        public List<LichChieuPhimDTO> LayLichChieuCuaPhimTrongNgay(string idPhim, DateTime giochieu)
        {
            return lichChieuDAL.LayLichChieuCuaPhimTrongNgay(idPhim, giochieu);
        }

        }
}
