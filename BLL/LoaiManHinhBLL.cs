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
    public class LoaiManHinhBLL
    {
        LoaiManHinhDAL lmhDAL=new LoaiManHinhDAL();
        public DataTable GetListScreen()
        {
            return lmhDAL.GetListScreen();
        }
        public bool ThemLoaiManHinh(LoaiManHinhDTO loaiManHinh)
        {
            LoaiManHinhDAL loaiManHinhDAL = new LoaiManHinhDAL();
            return loaiManHinhDAL.ThemLoaiManHinh(loaiManHinh);
        }
        public bool SuaLoaiManHinh(LoaiManHinhDTO loaiManHinh)
        {
            return lmhDAL.UpdateLoaiManHinh(loaiManHinh);
        }
        public bool XoaLoaiManHinh(int id)
        {
            return lmhDAL.DeleteLoaiManHinh(id);
        }
    }
}
