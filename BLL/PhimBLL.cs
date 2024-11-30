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
<<<<<<< HEAD
        public DataTable getListMovie()
        {
            return _phimDAL.GetListMovie();
        }
     
=======
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
>>>>>>> 1a806ffb046067e01861cf97755ce9a583888bd0
    }
}
