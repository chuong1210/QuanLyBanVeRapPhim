using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public int CMND { get; set; } // Giả sử CMND là một số nguyên duy nhất
        public int CaLam { get; set; } = 0; // Giả sử CMND là một số nguyên duy nhất=0
    }

}
