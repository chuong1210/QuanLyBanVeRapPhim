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
        public List<TheLoaiDTO> GetListGenreL()
        {
            return tlDAL.GetListGenreL();
        }
    }
}
