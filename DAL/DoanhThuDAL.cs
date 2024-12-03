using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
  public  class DoanhThuDAL
    {
        private string _connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";


  


        public List<DoanhThuMuaVeDTO> GetMuaVeThongKe(int customerId)
        {
            List<DoanhThuMuaVeDTO> muaVeList = new List<DoanhThuMuaVeDTO>();

            string query = @"
            SELECT phim.TenPhim, hd.NgayMua, cthd.SoLuong, vp.TienVePhim
            FROM HoaDon hd
            JOIN ChiTietHoaDon cthd ON hd.Id = cthd.idHoaDon
            JOIN VePhim vp ON cthd.idVePhim = vp.id
            JOIN LichChieuPhim lcp ON vp.idLichChieuPhim = lcp.id
            JOIN Phim phim ON lcp.idPhim = phim.id
            WHERE hd.idKhachHang = @CustomerId";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DoanhThuMuaVeDTO muaVe = new DoanhThuMuaVeDTO
                    {
                        TenPhim = reader["TenPhim"].ToString(),
                        NgayMua = Convert.ToDateTime(reader["NgayMua"]),
                        SoLuong = Convert.ToInt32(reader["SoLuong"]),
                        GiaVePhim = Convert.ToDecimal(reader["TienVePhim"])
                    };
                    muaVeList.Add(muaVe);
                }
                reader.Close();
            }

            return muaVeList;
    }

    public List<DoanhThuDTO> LayDoanhThuTheoKhoangThoiGian(DateTime startDate, DateTime endDate)
        {
            List<DoanhThuDTO> doanhThuList = new List<DoanhThuDTO>();

            string query = @"
        SELECT 
            FORMAT(hd.NgayMua, 'yyyy-MM-dd') AS Ngay, 
            SUM(hd.TongTien) AS TongDoanhThu
        FROM HoaDon hd
        WHERE hd.NgayMua BETWEEN @StartDate AND @EndDate
        GROUP BY FORMAT(hd.NgayMua, 'yyyy-MM-dd')
        ORDER BY Ngay";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DoanhThuDTO doanhThu = new DoanhThuDTO
                            {
                                Ngay = reader["Ngay"].ToString(),
                                TongDoanhThu = (decimal)reader["TongDoanhThu"]
                            };
                            doanhThuList.Add(doanhThu);
                        }
                    }
                }
            }

            return doanhThuList;
        }

        public List<DoanhThuTheoPhimDTO> LayDoanhThuTheoPhim(int idPhim, DateTime? startDate = null, DateTime? endDate = null)
        {
            List<DoanhThuTheoPhimDTO> doanhThuList = new List<DoanhThuTheoPhimDTO>();

            string query = @"
       SELECT 
 phim.TenPhim,     SUM(hd.TongTien) AS TongDoanhThu
 FROM HoaDon hd
 JOIN ChiTietHoaDon cthd ON hd.Id = cthd.idHoaDon
 JOIN VePhim vp ON cthd.idVePhim = vp.id
 JOIN LichChieuPhim lcp ON vp.idLichChieuPhim = lcp.id
 JOIN Phim phim ON lcp.idPhim = phim.id
 WHERE phim.id = @idPhim
 group by phim.TenPhim";

            // Nếu có khoảng thời gian, thêm điều kiện vào câu truy vấn
            if (startDate.HasValue && endDate.HasValue)
            {
                query += " AND hd.NgayMua BETWEEN @StartDate AND @EndDate";
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số vào câu truy vấn
                    command.Parameters.AddWithValue("@idPhim", idPhim);
                    if (startDate.HasValue && endDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate.Value);
                        command.Parameters.AddWithValue("@EndDate", endDate.Value);
                    }

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DoanhThuTheoPhimDTO doanhThu = new DoanhThuTheoPhimDTO
                            {
                                TenPhim = reader["TenPhim"].ToString(),
                                TongDoanhThu = (decimal)reader["TongDoanhThu"]
                            };
                            doanhThuList.Add(doanhThu);
                        }
                    }
                }
            }

            return doanhThuList;
        }


    }
}
