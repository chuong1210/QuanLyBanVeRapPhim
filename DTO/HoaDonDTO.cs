using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int Id { get; set; }
        public string IdKhachHang { get; set; }
        public DateTime NgayMua { get; set; }
        public decimal TongTien { get; set; }
    }

}
