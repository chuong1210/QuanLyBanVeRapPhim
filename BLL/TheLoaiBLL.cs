using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class TheLoaiBLL
    {
        TheLoaiDAL tlDAL=new TheLoaiDAL();
        public DataTable getListGenre()
        {
            return tlDAL.GetListGenre();
        }
        public List<TheLoaiDTO> GetListGenreList()
        {
            // Gọi phương thức từ DAL để lấy dữ liệu
            return tlDAL.GetListGenreList();
        }
        public bool ThemTheLoai(TheLoaiDTO theLoai)
        {
            return tlDAL.ThemTheLoai(theLoai);
        }
        public bool SuaTheLoai(TheLoaiDTO theLoai)
        {
            return tlDAL.SuaTheLoai(theLoai);
        }
        public bool XoaTheLoai(string id)
        {
            return tlDAL.XoaTheLoai(id);
        }
    }
}
