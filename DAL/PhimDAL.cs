using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhimDAL
    {



        private string _connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";
        public PhimDAL()
        {
                
        }
        public LichChieuPhimDTO PhimChiTiet()
        {
            return null;
        }
            public List<TheLoaiDTO> DanhSachTheLoai()
        {
            List<TheLoaiDTO> genres = new List<TheLoaiDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    
                    connection.Open();
                    string query = "SELECT * FROM TheLoai"; // Simple query to get genres

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TheLoaiDTO tl = new TheLoaiDTO();
                                tl.Id = reader["id"].ToString();
                                tl.TenTheLoai = reader["TenTheLoai"].ToString();
                                tl.MoTa = reader["MoTa"].ToString();
                                genres.Add(tl);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error retrieving genres: {ex.Message}"); // Log the error
            }
            return genres;
        }

        public List<DsPhimDTO> TimPheoTheoNgayVaTheLoai(string genre, DateTime date)
        {
            List<DsPhimDTO> movies = new List<DsPhimDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"EXEC TimPhimTheoNgayVaLoai @Date = @Date, @Genre= @Genre;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@Date", date.ToString("dd/MM/yyyy"));


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DsPhimDTO ds = new DsPhimDTO();
                                PhimDTO movie = new PhimDTO();
                                movie.Id = reader["PhimId"].ToString();
                                movie.TenPhim = reader.GetString(reader.GetOrdinal("TenPhim"));
                                movie.Poster = reader["PosterPath"].ToString();
                                

                                movie.ThoiLuong = int.Parse(reader["ThoiLuong"].ToString());
                                movie.DaoDien = reader.IsDBNull(reader.GetOrdinal("DaoDien")) ? "" : reader.GetString(reader.GetOrdinal("DaoDien"));
                                ds.PhimDTO= movie;
                                ds.idLCP= reader["LcpId"].ToString();
                                movies.Add(ds);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the error appropriately (e.g., using a logging library)
                Console.WriteLine($"Error retrieving movies: {ex.Message}");
            }
            return movies;
        }

        public HoaDonDTO DatVeXemPhim(DatVeDTO DatVeDTO, List<string> selectedSeats)
        {
            HoaDonDTO hoaDon = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Tạo hóa đơn
                        string queryHoaDon = @"
                DECLARE @idHoaDon INT; 
                INSERT INTO HoaDon (idKhachHang, NgayMua, TongTien)
                VALUES (@idKhachHang, GETDATE(), @TongTien);
                SET @idHoaDon = SCOPE_IDENTITY(); 
                SELECT @idHoaDon;";

                        int idHoaDon = 0; // Biến lưu ID hóa đơn vừa tạo
                        decimal tongTien = selectedSeats.Count * DatVeDTO.GiaVePhim;

                        using (SqlCommand command = new SqlCommand(queryHoaDon, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@idKhachHang", DatVeDTO.IdKhachHang);
                            command.Parameters.AddWithValue("@TongTien", tongTien);

                            idHoaDon = (int)command.ExecuteScalar();
                        }

                        // Cập nhật trạng thái ghế đã đặt và thêm chi tiết hóa đơn
                        foreach (var seat in selectedSeats)
                        {
                            string queryVePhim = @"
                    UPDATE VePhim 
                    SET TrangThaiVePhim = 1, idKhachHang = @idKhachHang 
                    OUTPUT INSERTED.id 
                    WHERE   MaGheNgoi = @SoGhe AND idLichChieuPhim = @idLichChieuPhim;";
                            
                            int? idVePhim = null;

                            using (SqlCommand command = new SqlCommand(queryVePhim, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@SoGhe","Ghe_"+seat);
                                command.Parameters.AddWithValue("@idKhachHang", DatVeDTO.IdKhachHang);
                                command.Parameters.AddWithValue("@idLichChieuPhim", DatVeDTO.IdLichChieuPhim);

                                var result = command.ExecuteScalar();
                                if (result != null)
                                {
                                    idVePhim = (int)result;
                                }
                            }

                            if (idVePhim.HasValue)
                            {
                                string queryChiTietHoaDon = @"
                        INSERT INTO ChiTietHoaDon (idHoaDon, idVePhim, SoLuong, GiaTien)
                        VALUES (@idHoaDon, @idVePhim, 1, @GiaVePhim);";

                                using (SqlCommand command = new SqlCommand(queryChiTietHoaDon, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                                    command.Parameters.AddWithValue("@idVePhim", idVePhim.Value);
                                    command.Parameters.AddWithValue("@GiaVePhim", DatVeDTO.GiaVePhim);

                                    command.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit(); // Hoàn tất giao dịch

                        // Sau khi hoàn tất giao dịch, tạo hóa đơn (Hóa đơn DTO)
                        hoaDon = LayThongTinHoaDon(idHoaDon);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Error in DatVeXemPhim: {ex.Message}");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error in DatVeXemPhim: {ex.Message}");
            }

            return hoaDon; // Trả về hóa đơn sau khi hoàn tất đặt vé
        }


        public LichChieuPhimDTO LichChieuPhimChiTiet(string idLichChieuPhim)
        {
            LichChieuPhimDTO lichChieuPhimChiTiet = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"EXEC LayThongTinChiTietLichChieu @idLichChieuPhim = @idLichChieuPhim";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số ID lịch chiếu phim
                        command.Parameters.AddWithValue("@idLichChieuPhim", idLichChieuPhim);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Tạo DTO để chứa thông tin chi tiết lịch chiếu
                                lichChieuPhimChiTiet = new LichChieuPhimDTO();
                                lichChieuPhimChiTiet.idPhong = reader["idPhong"].ToString();
                                lichChieuPhimChiTiet.GiaVePhim = decimal.Parse(reader["GiaVePhim"].ToString());
                                lichChieuPhimChiTiet.ThoiGianChieu = DateTime.Parse(reader["ThoiGianChieu"].ToString());

                                lichChieuPhimChiTiet.SoGheConLai = int.Parse(reader["SoGheConLai"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi kết nối cơ sở dữ liệu
                Console.WriteLine($"Lỗi khi lấy chi tiết lịch chiếu phim: {ex.Message}");
            }
            return lichChieuPhimChiTiet;
        }
        public (int SoHangGhe, int SoCotGhe, string TenPhong) LayThongTinPhongChieu(string idPhong)
        {
            int soHangGhe = 0;
            int soCotGhe = 0;
            string tenPhong = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT SoHangGhe, SoCotGhe, TenPhong FROM PhongChieu WHERE id = @idPhong";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idPhong", idPhong);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                soHangGhe = reader.GetInt32(reader.GetOrdinal("SoHangGhe"));
                                soCotGhe = reader.GetInt32(reader.GetOrdinal("SoCotGhe"));
                                tenPhong = reader["TenPhong"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi khi lấy thông tin phòng chiếu: {ex.Message}");
            }

            return (soHangGhe, soCotGhe,tenPhong);
        }

        public HoaDonDTO LayThongTinHoaDon(int idHoaDon)
        {
            HoaDonDTO hoaDon = new HoaDonDTO();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
            SELECT hd.Id, kh.TenKhachHang, phim.TenPhim, hd.NgayMua, hd.TongTien
            FROM HoaDon hd
            JOIN KhachHang kh ON hd.idKhachHang = kh.id
            JOIN ChiTietHoaDon cthd ON hd.Id = cthd.idHoaDon
            JOIN VePhim vp ON cthd.idVePhim = vp.id
            JOIN LichChieuPhim lcp ON vp.idLichChieuPhim = lcp.id
            JOIN Phim phim ON lcp.idPhim = phim.id
            WHERE hd.Id = @idHoaDon";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idHoaDon", idHoaDon);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hoaDon.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                                hoaDon.TenKH = reader["TenKhachHang"].ToString();
                                hoaDon.TenPhim = reader["TenPhim"].ToString();
                                hoaDon.NgayMua = reader.GetDateTime(reader.GetOrdinal("NgayMua"));
                                hoaDon.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error retrieving receipt information: {ex.Message}");
            }

            return hoaDon;
        }

        public List<string> LayGheDaDat(string idLichChieuPhim)
        {
            List<string> gheDaDat = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"SELECT MaGheNgoi FROM VePhim WHERE idLichChieuPhim = @idLichChieuPhim AND TrangThaiVePhim=1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idLichChieuPhim", idLichChieuPhim);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gheDaDat.Add(reader["MaGheNgoi"].ToString()); // Đọc vị trí ghế đã đặt
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log lỗi nếu có
                Console.WriteLine($"Lỗi khi lấy danh sách ghế đã đặt: {ex.Message}");
            }
            return gheDaDat;
        }





        public DataTable GetListMovie()
        {
            string query = "SELECT * FROM Phim"; // Truy vấn để lấy danh sách màn hình
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public DataTable GetListMovieById(string movieId = null)
        {
            // Khởi tạo chuỗi truy vấn
            string query = "SELECT * FROM Phim";

            // Nếu movieId không null, thêm điều kiện WHERE vào truy vấn
            if (!string.IsNullOrEmpty(movieId))
            {
                query += " WHERE id = @MovieId"; // Giả định bạn có cột Id trong bảng Phim
            }

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho truy vấn nếu cần
                    if (!string.IsNullOrEmpty(movieId))
                    {
                        command.Parameters.AddWithValue("@MovieId", movieId);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

}
}

