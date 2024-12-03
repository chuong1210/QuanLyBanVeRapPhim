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
    public class LichChieuPhimDAL
    {
        private static string connectionString = "Data Source=LAPTOP-DTCNUEFC\\SQLEXPRESS;Initial Catalog=QLRP;Integrated Security=True;";
        public DataTable GetListShowTime()
        {
            string query = "SELECT * FROM LichChieuPhim"; // Truy vấn để lấy danh sách màn hình
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
        public bool InsertLichChieu(LichChieuPhimDTO lichChieu)
        {
            try
            {
                string query = "INSERT INTO LichChieuPhim (ThoiGianChieu, IdPhong, GiaVePhim, idPhim, TrangThaiChieu) " +
                               "VALUES (@ThoiGianChieu, @IdPhong, @GiaVePhim, @idPhim, @TrangThaiChieu)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ThoiGianChieu", lichChieu.ThoiGianChieu);
                        command.Parameters.AddWithValue("@IdPhong", lichChieu.IdPhong);
                        command.Parameters.AddWithValue("@GiaVePhim", lichChieu.GiaVePhim);
                        command.Parameters.AddWithValue("@idPhim", lichChieu.IdPhim);
                        command.Parameters.AddWithValue("@TrangThaiChieu", lichChieu.TrangThaiChieu);

                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi
                Console.WriteLine($"Lỗi khi chèn dữ liệu: {ex.Message}");
                return false;
            }
        }
        public bool DeleteLichChieu(int id)
        {
            string query = "DELETE FROM LichChieuPhim WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        // Log lỗi nếu cần thiết
                        Console.WriteLine($"SQL Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }
        public bool UpdateLichChieu(LichChieuPhimDTO lichChieu)
        {
            string query = "UPDATE LichChieuPhim SET " +
                           "ThoiGianChieu = @ThoiGianChieu, " +
                           "IdPhong = @IdPhong, " +
                           "GiaVePhim = @GiaVePhim, " +
                           "idPhim = @idPhim, " +
                           "TrangThaiChieu = @TrangThaiChieu " +
                           "WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", lichChieu.Id);
                    command.Parameters.AddWithValue("@ThoiGianChieu", lichChieu.ThoiGianChieu);
                    command.Parameters.AddWithValue("@IdPhong", lichChieu.IdPhong);
                    command.Parameters.AddWithValue("@GiaVePhim", lichChieu.GiaVePhim);
                    command.Parameters.AddWithValue("@idPhim", lichChieu.IdPhim);
                    command.Parameters.AddWithValue("@TrangThaiChieu", lichChieu.TrangThaiChieu);

                    try
                    {
                        connection.Open();
                        return command.ExecuteNonQuery() > 0;
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"SQL Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }


    }
}
