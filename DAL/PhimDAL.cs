using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class PhimDAL
    {
        private static string connectionString = "Data Source=LAPTOP-DTCNUEFC\\SQLEXPRESS;Initial Catalog=QLRP;Integrated Security=True;";
        public DataTable GetListMovie()
        {
            string query = "SELECT * FROM Phim"; // Truy vấn để lấy danh sách màn hình
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
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
        public List<PhimDTO> GetListMovieList()
        {
            string query = "SELECT * FROM Phim"; // Truy vấn để lấy danh sách phim
            List<PhimDTO> listPhim = new List<PhimDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhimDTO phim = new PhimDTO
                            {
                                Id = reader.IsDBNull(reader.GetOrdinal("Id")) ? 0 : (int)reader["Id"], // Kiểm tra DBNull
                                TenPhim = reader.IsDBNull(reader.GetOrdinal("TenPhim")) ? string.Empty : reader["TenPhim"].ToString(),
                                MoTa = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? string.Empty : reader["MoTa"].ToString(),
                                ThoiLuong = reader.IsDBNull(reader.GetOrdinal("ThoiLuong")) ? 0 : Convert.ToSingle(reader["ThoiLuong"]),
                                NgayKhoiChieu = reader.IsDBNull(reader.GetOrdinal("NgayKhoiChieu")) ? DateTime.MinValue : (DateTime)reader["NgayKhoiChieu"],
                                NgayKetThuc = reader.IsDBNull(reader.GetOrdinal("NgayKetThuc")) ? DateTime.MinValue : (DateTime)reader["NgayKetThuc"],
                                SanXuat = reader.IsDBNull(reader.GetOrdinal("SanXuat")) ? string.Empty : reader["SanXuat"].ToString(),
                                DaoDien = reader.IsDBNull(reader.GetOrdinal("DaoDien")) ? string.Empty : reader["DaoDien"].ToString(),
                                DienVien = reader.IsDBNull(reader.GetOrdinal("DienVien")) ? string.Empty : reader["DienVien"].ToString(),
                                NamSX = reader.IsDBNull(reader.GetOrdinal("NamSX")) ? 0 : (int)reader["NamSX"],
                                // Kiểm tra nếu cột Poster là DBNull hoặc null
                                Poster = reader.IsDBNull(reader.GetOrdinal("PosterPath")) ? null : reader["PosterPath"] as byte[]
                            };
                            listPhim.Add(phim);
                        }
                    }
                }
            }
            return listPhim;
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

            using (SqlConnection connection = new SqlConnection(connectionString))
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
        public bool AddMovie(PhimDTO phim)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Phim 
                                 (TenPhim, MoTa, ThoiLuong, NgayKhoiChieu, NgayKetThuc, SanXuat, DaoDien, DienVien, NamSX, PosterPath)
                                 VALUES
                                 (@TenPhim, @MoTa, @ThoiLuong, @NgayKhoiChieu, @NgayKetThuc, @SanXuat, @DaoDien, @DienVien, @NamSX, @PosterPath)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TenPhim", phim.TenPhim);
                        cmd.Parameters.AddWithValue("@MoTa", phim.MoTa);
                        cmd.Parameters.AddWithValue("@ThoiLuong", phim.ThoiLuong);
                        cmd.Parameters.AddWithValue("@NgayKhoiChieu", phim.NgayKhoiChieu);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", phim.NgayKetThuc);
                        cmd.Parameters.AddWithValue("@SanXuat", phim.SanXuat);
                        cmd.Parameters.AddWithValue("@DaoDien", phim.DaoDien);
                        cmd.Parameters.AddWithValue("@DienVien", phim.DienVien);
                        cmd.Parameters.AddWithValue("@NamSX", phim.NamSX);

                        // Nếu poster có giá trị, chuyển nó thành byte[]
                        if (phim.Poster != null)
                        {
                            cmd.Parameters.AddWithValue("@PosterPath", phim.Poster);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@PosterPath", DBNull.Value);
                        }

                        connection.Open();
                        int result = cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL
                        connection.Close();

                        return result > 0; // Trả về true nếu có bản ghi được thêm vào
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool UpdateMovie(PhimDTO phim)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Câu lệnh SQL để cập nhật phim (không bao gồm ảnh)
                    string query = @"UPDATE Phim
                                     SET TenPhim = @TenPhim, MoTa = @MoTa, ThoiLuong = @ThoiLuong, 
                                         NgayKhoiChieu = @NgayKhoiChieu, NgayKetThuc = @NgayKetThuc,
                                         SanXuat = @SanXuat, DaoDien = @DaoDien, NamSX = @NamSX
                                     WHERE ID = @ID"; // Sử dụng ID phim để cập nhật

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenPhim", phim.TenPhim);
                    command.Parameters.AddWithValue("@MoTa", phim.MoTa);
                    command.Parameters.AddWithValue("@ThoiLuong", phim.ThoiLuong);
                    command.Parameters.AddWithValue("@NgayKhoiChieu", phim.NgayKhoiChieu);
                    command.Parameters.AddWithValue("@NgayKetThuc", phim.NgayKetThuc);
                    command.Parameters.AddWithValue("@SanXuat", phim.SanXuat);
                    command.Parameters.AddWithValue("@DaoDien", phim.DaoDien);
                    command.Parameters.AddWithValue("@NamSX", phim.NamSX);
                    command.Parameters.AddWithValue("@ID", phim.Id); // Giả sử phim có trường ID để xác định

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Thực thi câu lệnh SQL

                    return rowsAffected > 0; // Trả về true nếu có ít nhất 1 bản ghi bị ảnh hưởng
                }
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Câu lệnh SQL để xóa phim
                    string query = @"DELETE FROM Phim WHERE ID = @ID"; // Xóa phim theo ID

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", movieID); // Truyền ID của phim cần xóa

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery(); // Thực thi câu lệnh SQL

                    return rowsAffected > 0; // Trả về true nếu có ít nhất 1 bản ghi bị xóa
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
