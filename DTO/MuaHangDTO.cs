using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class MuaHangDTO
    {
        // Mã vé phim
        [Display(Name = "Loại vé phim", Description = "Loại vé của khách hàng (ví dụ: Người lớn, Trẻ em)", Order = 1)]
        public string LoaiVePhimSTR { get; set; } = "Người lớn"; // Giá trị mặc định

        // Mã ghế ngồi
        [Display(Name = "Mã ghế ngồi", Description = "Mã ghế mà khách hàng chọn để xem phim", Order = 2)]
        public string MaGheNgoi { get; set; }

        // Tên phim
        [Display(Name = "Tên phim", Description = "Tên của bộ phim mà khách hàng chọn", Order = 3)]
        public string TenPhim { get; set; }

        [Display(Name = "Mã phòng", Description = "Mã phòng của bộ phim mà khách hàng chọn", Order = 4)]
        public string MaPhong { get; set; }
        [Display(Name = "Suất chiếu", Description = "Thời gian chiếu của bộ phim mà khách hàng chọn", Order = 5)]

        public DateTime SuatChieu { get; set; }

        // Tiền vé phim
        [Display(Name = "Tiền vé phim", Description = "Giá trị của vé phim mà khách hàng mua", Order = 6)]
        [Range(0, double.MaxValue, ErrorMessage = "Tiền vé phải lớn hơn hoặc bằng 0.")]
        public decimal TienVePhim { get; set; } = 0; // Giá trị mặc định
    }
}
