using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongChieuDTO
    {
        public string id { get; set; }
        public string TenPhong { get; set; }
        public string idManHinh { get; set; }
        public int SoGheNgoi { get; set; }
        public int TrangThaiChoNgoi{ get; set; } = 1; // Giá trị mặc định
        public int SoHangGhe { get; set; }
        public int SoGheMotHang { get; set; }
    }

}
