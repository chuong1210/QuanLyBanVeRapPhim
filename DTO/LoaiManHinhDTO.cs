using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiManHinhDTO
    {
        public int Id { get; set; }
        public string TenMH { get; set; }
        public int KichThuoc { get; set; } = 20; // Giá trị mặc định
    }

}
