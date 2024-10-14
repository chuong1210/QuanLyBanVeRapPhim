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

        public bool DatVeXemPhim(DatVeDTO DatVeDTO, List<string> selectedSeats)
        {
            bool success = false;

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

                        // Tạo bảng tạm để lưu ID hóa đơn
                        int idHoaDon = 0; // Biến lưu ID hóa đơn vừa tạo

                        // Tính tổng tiền vé
                        decimal tongTien = selectedSeats.Count * DatVeDTO.GiaVePhim;

                        using (SqlCommand command = new SqlCommand(queryHoaDon, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@idKhachHang", DatVeDTO.IdKhachHang);
                            command.Parameters.AddWithValue("@TongTien", tongTien);

                            // Thực hiện thêm hóa đơn và lấy ID hóa đơn vừa tạo
                            idHoaDon = (int)command.ExecuteScalar();
                        }

                        // Cập nhật trạng thái ghế đã đặt
                        // Cập nhật trạng thái ghế đã đặt
                        foreach (var seat in selectedSeats)
                        {
                            string queryVePhim = @"
                            UPDATE VePhim 
                            SET TrangThaiVePhim = 1, idKhachHang = @idKhachHang 
                            OUTPUT INSERTED.id 
                            WHERE id = @MaVePhim AND idLichChieuPhim = @idLichChieuPhim;";

                            int? idVePhim = null; // Sử dụng kiểu nullable để tránh lỗi null reference

                            using (SqlCommand command = new SqlCommand(queryVePhim, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@MaVePhim", seat);
                                command.Parameters.AddWithValue("@idKhachHang", DatVeDTO.IdKhachHang);
                                command.Parameters.AddWithValue("@idLichChieuPhim", DatVeDTO.IdLichChieuPhim);

                                // Thực hiện cập nhật và lấy ID vé
                                var result = command.ExecuteScalar(); // Lấy ID vé phim vừa cập nhật
                                if (result != null)
                                {
                                    idVePhim = (int)result; 
                                }
                            }

                            // Thêm vào bảng chi tiết hóa đơn
                            string queryChiTietHoaDon = @"
                            INSERT INTO ChiTietHoaDon (idHoaDon, idVePhim, SoLuong, GiaTien)
                            VALUES (@idHoaDon, @idVePhim, 1, @GiaVePhim);";

                            using (SqlCommand command = new SqlCommand(queryChiTietHoaDon, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                                command.Parameters.AddWithValue("@idVePhim", idVePhim.Value); // Sử dụng ID vé vừa cập nhật
                                command.Parameters.AddWithValue("@GiaVePhim", DatVeDTO.GiaVePhim);

                                command.ExecuteNonQuery(); // Thêm chi tiết hóa đơn
                            }
                        }


                        transaction.Commit(); // Hoàn tất giao dịch
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Quay lại giao dịch nếu có lỗi
                        Console.WriteLine($"Error in DatVeXemPhim: {ex.Message}"); // Log lỗi
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error in DatVeXemPhim: {ex.Message}"); // Log lỗi kết nối cơ sở dữ liệu
            }

            return success;
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
        public (int SoHangGhe, int SoCotGhe) LayThongTinPhongChieu(string idPhong)
        {
            int soHangGhe = 0;
            int soCotGhe = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT SoHangGhe, SoCotGhe FROM PhongChieu WHERE id = @idPhong";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idPhong", idPhong);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                soHangGhe = reader.GetInt32(reader.GetOrdinal("SoHangGhe"));
                                soCotGhe = reader.GetInt32(reader.GetOrdinal("SoCotGhe"));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi khi lấy thông tin phòng chiếu: {ex.Message}");
            }

            return (soHangGhe, soCotGhe);
        }

        public List<string> LayGheDaDat(string idLichChieuPhim)
        {
            List<string> gheDaDat = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"SELECT id FROM VePhim WHERE idLichChieuPhim = @idLichChieuPhim AND TrangThaiVePhim=1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idLichChieuPhim", idLichChieuPhim);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                gheDaDat.Add(reader["id"].ToString()); // Đọc vị trí ghế đã đặt
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
