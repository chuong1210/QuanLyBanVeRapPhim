using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class PhimBLL
    {
        private readonly PhimDAL _phimDAL;
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        public PhimBLL()
        {
            _phimDAL = new PhimDAL();
        }

        public List<DsPhimDTO> TimPhim(string genre, DateTime date)
        {
            if (string.IsNullOrEmpty(genre))
            {
                return _phimDAL.TimPheoTheoNgay(date); // Method to get movies for the specific date without filtering by genre
            }
            else
            {
                return _phimDAL.TimPheoTheoNgayVaTheLoai(genre, date); // Existing method to filter by genre and date
            }
        }

        public LichChieuPhimDTO LayChiTietLichChieuPhim(string idLichChieuPhim)
        {
            // Gọi tới DAL để lấy chi tiết lịch chiếu phim
            return _phimDAL.LichChieuPhimChiTiet(idLichChieuPhim);
        }
        public List<TheLoaiDTO> DanhSachTheLoai()
        {
            return _phimDAL.DanhSachTheLoai();
        }
        public (int SoHangGhe, int SoCotGhe, string TenPhong) LayThongTinPhongChieu(string idPhong)
        {
            return _phimDAL .LayThongTinPhongChieu(idPhong);
        }
        public List<string> LayGheDaDat(string idLichChieuPhim)
        {
            return _phimDAL.LayGheDaDat(idLichChieuPhim);
        }
        public HoaDonDTO DatVeXemPhim(DatVeDTO DatVeDTO, List<string> selectedSeats,string userName)
        {
          //string idKH=  khachHangDAL.GetIdKhachHangByUserName(userName);
            //DatVeDTO.IdKhachHang = idKH;
            return _phimDAL.DatVeXemPhim(DatVeDTO, selectedSeats);
        }
        public DataTable getListMovie()
        {
            return _phimDAL.GetListMovie();
        }

<<<<<<< HEAD
        public List<PhimDTO> TimPhimTheoKhoangThoiGian(DateTime startDate, DateTime endDate)
        {
            return _phimDAL.TimPhimTheoKhoangThoiGian(startDate, endDate);

        }
        public List<PhimDTO> DanhSachPhim()
        {
            return _phimDAL.DanhSachPhim();

        }
        public bool HuyGheDat(DatVeDTO DatVeDTO, List<string> selectedSeats)
        {
            return _phimDAL.HuyGheDat(DatVeDTO, selectedSeats);

        }

=======
        public List<PhimDTO> GetListMovieList()
        {
            return phimDAL.GetListMovieList(); // Gọi hàm từ DAL để lấy danh sách phim
        }
>>>>>>> ba3e5735ec50aa78d57eb9a1a4a2aefb09d84f69
        public bool AddMovie(PhimDTO phim)
        {
            return _phimDAL.AddMovie(phim); 
        }
        public bool UpdateMovie(PhimDTO phim)
        {
            try
            {
                // Gọi DAL để cập nhật phim vào cơ sở dữ liệu
                PhimDAL phimDAL = new PhimDAL();
                return phimDAL.UpdateMovie(phim); // Chỉ cập nhật thông tin phim, không bao gồm ảnh
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool DeleteMovie(int movieID)
        {
            try
            {
                // Gọi DAL để xóa phim trong cơ sở dữ liệu
                PhimDAL phimDAL = new PhimDAL();
                return phimDAL.DeleteMovie(movieID); // Truyền ID phim cần xóa
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
