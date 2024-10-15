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
    }
}
