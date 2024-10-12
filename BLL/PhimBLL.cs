using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhimBLL
    {
        private readonly PhimDAL _movieDAL;

        public PhimBLL()
        {
                _movieDAL = new PhimDAL();
        }

        public List<PhimDTO> TimPhim(string genre, DateTime date)
        {
            return _movieDAL.TimPheoTheoNgayVaTheLoai(genre, date);
        }

        public List<TheLoaiDTO> DanhSachTheLoai()
        {
            return _movieDAL.DanhSachTheLoai();
        }
        }
}
