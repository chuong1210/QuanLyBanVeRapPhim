using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhThuDTO
    {
        public string Ngay { get; set; }
        public decimal TongDoanhThu { get; set; }
    }
    public class DoanhThuTheoPhimDTO
    {
        public string TenPhim { get; set; }
        public decimal TongDoanhThu { get; set; }
    }

    public class DoanhThuMuaVeDTO
    {
        public string TenPhim { get; set; }
        public DateTime NgayMua { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaVePhim { get; set; }
    }


}
