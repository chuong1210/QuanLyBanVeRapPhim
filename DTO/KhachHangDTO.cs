﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public int? DiemTichLuy { get; set; } // Có thể là NULL
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        //public bool IsSelected { get; set; } = false; // Poster có thể là mảng byte



    }

}
