using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VePhimDTO
    {
        public int Id { get; set; }
        public int LoaiVePhim { get; set; } = 1; // Giá trị mặc định

        public string IdLichChieuPhim { get; set; }
        public string MaGheNgoi { get; set; }
        public string IdKhachHang { get; set; }
        public string TenPhim { get; set; }
        public int TrangThaiVePhim { get; set; } = 0; // Giá trị mặc định
        public decimal TienVePhim { get; set; } = 0; // Giá trị mặc định
    }

}
