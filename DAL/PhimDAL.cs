using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhimDAL
    {
        // DAL (Data Access Layer)


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
                    string query = @"EXEC TimPhimTheoNgayVaLoaiDistinct @Date = @Date, @Genre= @Genre;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));


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
        public List<DsPhimDTO> TimPheoTheoNgay(DateTime date)
        {
            List<DsPhimDTO> movies = new List<DsPhimDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                                SELECT 
                                   DISTINCT
                                   p.id AS PhimId,
                                    p.TenPhim,
                                    p.PosterPath,
                                    p.ThoiLuong,
                                    p.DaoDien,
		                            p.MoTa,
		                            p.NamSX,
		                            p.DienVien,
		                            p.NgayKhoiChieu,
		                            p.NgayKetThuc
                                FROM 
                                    Phim p
                                INNER JOIN 
                                    LichChieuPhim lc ON p.Id = lc.IdPhim
                                WHERE 
                                   CONVERT(VARCHAR(10), lc.ThoiGianChieu, 126) = @Date";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));

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
                                ds.PhimDTO = movie;
                                movies.Add(ds);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error retrieving movies: {ex.Message}");
            }
            return movies;
        }

        public List<PhimDTO> DanhSachPhim()
        {
            List<PhimDTO> movies = new List<PhimDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                          SELECT 
                              DISTINCT
                              p.id AS PhimId,
                              p.TenPhim,
                              p.PosterPath,
                              p.ThoiLuong,
                              p.DaoDien,
                              p.MoTa,
                              p.NamSX,
                              p.DienVien,
                              p.NgayKhoiChieu,
                              p.NgayKetThuc
                          FROM 
                              Phim p
                         ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho khoảng thời gian bắt đầu và kết thúc
             

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PhimDTO movie = new PhimDTO();

                                movie.Id = reader["PhimId"].ToString();
                                movie.TenPhim = reader.GetString(reader.GetOrdinal("TenPhim"));
                                movie.Poster = reader["PosterPath"].ToString();
                                movie.ThoiLuong = int.Parse(reader["ThoiLuong"].ToString());
                                movie.DaoDien = reader.IsDBNull(reader.GetOrdinal("DaoDien")) ? "" : reader.GetString(reader.GetOrdinal("DaoDien"));
                                movie.MoTa = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? "" : reader.GetString(reader.GetOrdinal("MoTa"));
                                movie.NamSX = reader.IsDBNull(reader.GetOrdinal("NamSX")) ? 0 : reader.GetInt32(reader.GetOrdinal("NamSX"));
                                movie.DienVien = reader.IsDBNull(reader.GetOrdinal("DienVien")) ? "" : reader.GetString(reader.GetOrdinal("DienVien"));
                                movie.NgayKhoiChieu = reader.IsDBNull(reader.GetOrdinal("NgayKhoiChieu"))
                                 ? DateTime.MinValue  // Giá trị mặc định nếu NULL
                                 : reader.GetDateTime(reader.GetOrdinal("NgayKhoiChieu"));

                                movie.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc"))
                                    ? DateTime.MinValue  // Giá trị mặc định nếu NULL
                                    : reader.GetDateTime(reader.GetOrdinal("NgayKetThuc"));


                                movies.Add(movie);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error retrieving movies: {ex.Message}");
            }
            return movies;
        }

        public List<PhimDTO> TimPhimTheoKhoangThoiGian(DateTime startDate, DateTime endDate)
        {
            List<PhimDTO> movies = new List<PhimDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"
                          SELECT 
                              DISTINCT
                              p.id AS PhimId,
                              p.TenPhim,
                              p.PosterPath,
                              p.ThoiLuong,
                              p.DaoDien,
                              p.MoTa,
                              p.NamSX,
                              p.DienVien,
                              p.NgayKhoiChieu,
                              p.NgayKetThuc
                          FROM 
                              Phim p
                          INNER JOIN 
                              LichChieuPhim lc ON p.Id = lc.IdPhim
                          WHERE 
                              lc.ThoiGianChieu >= @StartDate AND lc.ThoiGianChieu <= @EndDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho khoảng thời gian bắt đầu và kết thúc
                        command.Parameters.AddWithValue("@StartDate", startDate.ToUniversalTime());
                        command.Parameters.AddWithValue("@EndDate", endDate.ToUniversalTime());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PhimDTO movie = new PhimDTO();

                                movie.Id = reader["PhimId"].ToString();
                                movie.TenPhim = reader.GetString(reader.GetOrdinal("TenPhim"));
                                movie.Poster = reader["PosterPath"].ToString();
                                movie.ThoiLuong = int.Parse(reader["ThoiLuong"].ToString());
                                movie.DaoDien = reader.IsDBNull(reader.GetOrdinal("DaoDien")) ? "" : reader.GetString(reader.GetOrdinal("DaoDien"));
                                movie.MoTa = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? "" : reader.GetString(reader.GetOrdinal("MoTa"));
                                movie.NamSX = reader.IsDBNull(reader.GetOrdinal("NamSX")) ? 0 : reader.GetInt32(reader.GetOrdinal("NamSX"));
                                movie.DienVien = reader.IsDBNull(reader.GetOrdinal("DienVien")) ? "" : reader.GetString(reader.GetOrdinal("DienVien"));
                                movie.NgayKhoiChieu = reader.IsDBNull(reader.GetOrdinal("NgayKhoiChieu"))
                                 ? DateTime.MinValue  // Giá trị mặc định nếu NULL
                                 : reader.GetDateTime(reader.GetOrdinal("NgayKhoiChieu"));

                                movie.NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc"))
                                    ? DateTime.MinValue  // Giá trị mặc định nếu NULL
                                    : reader.GetDateTime(reader.GetOrdinal("NgayKetThuc"));


                                movies.Add(movie);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
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
                        string queryHoaDon = "";
                        int idHoaDon = 0; // Variable to store the ID of the created invoice
                        decimal tongTien = selectedSeats.Count * DatVeDTO.GiaVePhim;

                        // Insert the invoice (HoaDon) depending on whether there is a customer ID
                        if (!String.IsNullOrEmpty(DatVeDTO.IdKhachHang))
                        {
                            // If a customer ID exists, include it in the invoice
                            queryHoaDon = @"
                        DECLARE @idHoaDon INT; 
                        INSERT INTO HoaDon (idKhachHang, NgayMua, TongTien)
                        VALUES (@idKhachHang, GETDATE(), @TongTien);
                        SET @idHoaDon = SCOPE_IDENTITY(); 
                        SELECT @idHoaDon;";
                        }
                        else
                        {
                            // If no customer ID exists, create the invoice without a customer reference
                            queryHoaDon = @"
                        DECLARE @idHoaDon INT; 
                        INSERT INTO HoaDon (NgayMua, TongTien)
                        VALUES (GETDATE(), @TongTien);
                        SET @idHoaDon = SCOPE_IDENTITY(); 
                        SELECT @idHoaDon;";
                        }

                        // Execute the query to create the invoice and get the invoice ID
                        using (SqlCommand command = new SqlCommand(queryHoaDon, connection, transaction))
                        {
                            if (!String.IsNullOrEmpty(DatVeDTO.IdKhachHang))
                            {
                                command.Parameters.AddWithValue("@idKhachHang", DatVeDTO.IdKhachHang);
                            }
                            command.Parameters.AddWithValue("@TongTien", tongTien);

                            idHoaDon = (int)command.ExecuteScalar();
                        }

                        // Update ticket status and insert order details
                        foreach (var seat in selectedSeats)
                        {
                            string queryVePhim = @"
                        UPDATE VePhim 
                        SET TrangThaiVePhim = 1, idKhachHang = @idKhachHang ,LoaiVePhim=@LoaiVePhim
                        OUTPUT INSERTED.id 
                        WHERE MaGheNgoi = @SoGhe AND idLichChieuPhim = @idLichChieuPhim;";

                            int? idVePhim = null;

                            using (SqlCommand command = new SqlCommand(queryVePhim, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@SoGhe", "Ghe_" + seat);
                                command.Parameters.AddWithValue("@idKhachHang", DatVeDTO.IdKhachHang ?? (object)DBNull.Value);
                                command.Parameters.AddWithValue("@idLichChieuPhim", DatVeDTO.IdLichChieuPhim);
                                command.Parameters.AddWithValue("@LoaiVePhim", DatVeDTO.loaiVP);


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

                        transaction.Commit(); // Commit the transaction after everything is successful

                        // Retrieve the completed invoice details
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

            return hoaDon; // Return the completed invoice
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
            SELECT hd.Id, kh.HoTen, phim.TenPhim, hd.NgayMua, hd.TongTien
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

        public bool HuyGheDat(DatVeDTO DatVeDTO, List<string> selectedSeats)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Xóa các chi tiết hóa đơn liên quan đến vé
                        foreach (var seat in selectedSeats)
                        {
                            // Lấy ID của Vé Phim đã đặt
                            string queryChiTietHoaDon = @"
                    SELECT cthd.idVePhim 
                    FROM ChiTietHoaDon cthd
                    JOIN VePhim vp ON cthd.idVePhim = vp.id
                    WHERE vp.MaGheNgoi = @SoGhe AND vp.idLichChieuPhim = @idLichChieuPhim";

                            int? idVePhim = null;
                            using (SqlCommand command = new SqlCommand(queryChiTietHoaDon, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@SoGhe", "Ghe_" + seat);
                                command.Parameters.AddWithValue("@idLichChieuPhim", DatVeDTO.IdLichChieuPhim);
                                var result = command.ExecuteScalar();

                                if (result != null)
                                {
                                    idVePhim = (int)result;
                                }
                            }

                            // Xóa chi tiết hóa đơn nếu tìm thấy ID Vé Phim
                            if (idVePhim.HasValue)
                            {
                                string queryDeleteChiTietHoaDon = @"
                        DELETE FROM ChiTietHoaDon
                        WHERE idVePhim = @idVePhim";

                                using (SqlCommand command = new SqlCommand(queryDeleteChiTietHoaDon, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@idVePhim", idVePhim.Value);
                                    command.ExecuteNonQuery();
                                }
                            }

                            // Cập nhật lại trạng thái Vé Phim
                            string queryVePhim = @"
                    UPDATE VePhim 
                    SET TrangThaiVePhim = 0, idKhachHang = NULL 
                    WHERE MaGheNgoi = @SoGhe AND idLichChieuPhim = @idLichChieuPhim";

                            using (SqlCommand command = new SqlCommand(queryVePhim, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@SoGhe", "Ghe_" + seat);
                                command.Parameters.AddWithValue("@idLichChieuPhim", DatVeDTO.IdLichChieuPhim);
                                command.ExecuteNonQuery();
                            }
                        }

                        // Commit giao dịch
                        transaction.Commit();
                        isSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        // Nếu có lỗi, rollback lại giao dịch
                        transaction.Rollback();
                        Console.WriteLine($"Error during seat cancellation: {ex.Message}");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error during seat cancellation: {ex.Message}");
            }

            return isSuccess;
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


    }



}
