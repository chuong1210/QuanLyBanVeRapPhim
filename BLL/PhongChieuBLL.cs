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
    }
}
