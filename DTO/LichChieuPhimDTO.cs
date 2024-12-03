using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichChieuPhimDTO
    {
<<<<<<< HEAD
        public string Id { get; set; }

        public DateTime ThoiGianChieu { get; set; }
        public string GioBatDau { get; set; }

        public string GioKetThuc { get; set; }
        public string idPhong { get; set; }
        public int SoGheConLai { get; set; }
        public int SoGheTatCa { get; set; }


=======
        public int Id { get; set; }
        public DateTime ThoiGianChieu { get; set; }
        public int IdPhong { get; set; }
>>>>>>> ba3e5735ec50aa78d57eb9a1a4a2aefb09d84f69
        public decimal GiaVePhim { get; set; }

        public int IdPhim { get; set; }
        public int TrangThaiChieu { get; set; } = 0; // Giá trị mặc định
        public string tenPhong { get; set; }=string.Empty;

    }

}
