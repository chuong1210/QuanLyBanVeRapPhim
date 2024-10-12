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

       

        public List<PhimDTO> GetMovies(string genre, DateTime date)
        {
            return _movieDAL.GetMoviesByGenreAndDate(genre, date);
        }
    }
}
