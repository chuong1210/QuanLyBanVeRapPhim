using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhimDTO
    {
        public string Id { get; set; }
        public string TenPhim { get; set; }
        public string MoTa { get; set; }
        public float ThoiLuong { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string SanXuat { get; set; }
        public string DaoDien { get; set; }
        public string DienVien { get; set; }
        public int NamSX { get; set; }
        public byte[] Poster { get; set; } // Poster có thể là mảng byte
    }

}
