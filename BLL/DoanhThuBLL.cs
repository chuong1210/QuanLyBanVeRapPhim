using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class DoanhThuBLL
    {
        private DoanhThuDAL doanhThuDAL= new DoanhThuDAL();
        public List<DoanhThuDTO> LayDoanhThuTheoKhoangThoiGian(DateTime startDate, DateTime endDate)
        {
            return doanhThuDAL.LayDoanhThuTheoKhoangThoiGian(startDate, endDate);
        }
        public List<DoanhThuTheoPhimDTO> LayDoanhThuTheoPhim(int idPhim, DateTime? startDate = null, DateTime? endDate = null)
        {
            return doanhThuDAL.LayDoanhThuTheoPhim(idPhim, startDate, endDate); 
        }
        }
}
