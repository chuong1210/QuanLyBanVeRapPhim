using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuPhimDTO
    {
        public string Id { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public string idPhong { get; set; }
        public int SoGheConLai { get; set; }

        public decimal GiaVePhim { get; set; }
        public int TrangThaiChieu { get; set; } = 0; // Giá trị mặc định
    }

}
