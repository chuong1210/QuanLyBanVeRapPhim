using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuPhimDTO
    {
        public int Id { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public int IdPhong { get; set; }
        public decimal GiaVePhim { get; set; }

        public int IdPhim { get; set; }
        public int TrangThaiChieu { get; set; } = 0; // Giá trị mặc định
    }

}
