using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string Id { get; set; }
        public string TenKH { get; set; }
        public string TenPhim { get; set; }


        public DateTime NgayMua { get; set; }
        public decimal TongTien { get; set; }
    }

}
