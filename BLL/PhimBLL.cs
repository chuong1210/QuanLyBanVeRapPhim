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
    public class PhimBLL
    {
        PhimDAL phimDAL=new PhimDAL();
        public DataTable getListMovie()
        {
            return phimDAL.GetListMovie();
        }
        public bool AddMovie(PhimDTO phim)
        {
            return phimDAL.AddMovie(phim); 
        }
        public bool UpdateMovie(PhimDTO phim)
        {
            try
            {
                // Gọi DAL để cập nhật phim vào cơ sở dữ liệu
                PhimDAL phimDAL = new PhimDAL();
                return phimDAL.UpdateMovie(phim); // Chỉ cập nhật thông tin phim, không bao gồm ảnh
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteMovie(int movieID)
        {
            try
            {
                // Gọi DAL để xóa phim trong cơ sở dữ liệu
                PhimDAL phimDAL = new PhimDAL();
                return phimDAL.DeleteMovie(movieID); // Truyền ID phim cần xóa
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
