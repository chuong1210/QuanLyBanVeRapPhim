using System;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class LichChieuDAL
    {
        private string _connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";

        public List<LichChieuPhimDTO> LayLichChieuCuaPhimTrongNgay(string idPhim, DateTime giochieu)
        {
            List<LichChieuPhimDTO> danhSachLichChieu = new List<LichChieuPhimDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"EXEC LayLichChieuCuaPhimTrongNgay @MovieId = @idPhim, @Date = @GioChieu";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idPhim", idPhim);
                        command.Parameters.AddWithValue("@GioChieu", giochieu);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LichChieuPhimDTO lichChieuPhim = new LichChieuPhimDTO
                                {
                                    Id = reader["idLCP"].ToString(),
                                    idPhong = reader["idPhong"].ToString(),
                                    tenPhong = reader["TenPhong"].ToString(),
                                    GioBatDau = reader["GioChieu"].ToString(),
                                    GioKetThuc = reader["GioKetThuc"].ToString(),
                                    SoGheConLai = int.Parse(reader["SoGheConTrong"].ToString()),
                                    SoGheTatCa = int.Parse(reader["SoGheNgoi"].ToString())


                                };

                                danhSachLichChieu.Add(lichChieuPhim);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi khi lấy chi tiết lịch chiếu phim: {ex.Message}");
            }
            return danhSachLichChieu;
        }

    }
}
