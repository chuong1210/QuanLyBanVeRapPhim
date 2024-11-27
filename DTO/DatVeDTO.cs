using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DatVeDTO
    {
        public int Id { get; set; }
        public int loaiVP { get; set; }

        public string IdKhachHang { get; set; }
        public string IdLichChieuPhim { get; set; }

        public DateTime NgayMua { get; set; }
        public decimal TongTien { get; set; }

        public decimal GiaVePhim { get; set; }
        public string TenPhim { get; set; }

        
    }
}
