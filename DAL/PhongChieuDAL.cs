using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongChieuDAL
    {
        private static string connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";
        public  DataTable GetListCinema()
        {
            string query = "SELECT * FROM PhongChieu"; // Truy vấn SQL

            DataTable dataTable = new DataTable(); // Tạo DataTable để chứa kết quả

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable); // Điền dữ liệu từ SQL vào DataTable
                        connection.Close();
                    }
                }
            }
            return dataTable; // Trả về DataTable chứa danh sách rạp
        }

        public DataTable GetListScreen()
        {
            string query = "SELECT * FROM LoaiManHinh"; // Truy vấn để lấy danh sách màn hình
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
        public bool ThemPhongChieu(PhongChieuDTO phongChieu)
        {
            try
            {
                string query = @"INSERT INTO PhongChieu (TenPhong, idManHinh, SoGheNgoi, TrangThaiChoNgoi, SoHangGhe, SoGheMotHang) 
                         VALUES (@TenPhong, @idManHinh, @SoGheNgoi, @TrangThaiChoNgoi, @SoHangGhe, @SoGheMotHang)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenPhong", phongChieu.TenPhong);
                        cmd.Parameters.AddWithValue("@idManHinh", phongChieu.idManHinh);
                        cmd.Parameters.AddWithValue("@SoGheNgoi", phongChieu.SoGheNgoi);
                        cmd.Parameters.AddWithValue("@TrangThaiChoNgoi", phongChieu.TrangThaiChoNgoi);
                        cmd.Parameters.AddWithValue("@SoHangGhe", phongChieu.SoHangGhe);
                        cmd.Parameters.AddWithValue("@SoGheMotHang", phongChieu.SoGheMotHang);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm Phòng Chiếu: " + ex.Message);
                return false;
            }
        }
        public bool SuaPhongChieu(PhongChieuDTO phongChieu)
        {
            try
            {
                string query = @"UPDATE PhongChieu 
                         SET TenPhong = @TenPhong, 
                             idManHinh = @idManHinh, 
                             SoGheNgoi = @SoGheNgoi, 
                             TrangThaiChoNgoi = @TrangThaiChoNgoi, 
                             SoHangGhe = @SoHangGhe, 
                             SoGheMotHang = @SoGheMotHang
                         WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số
                        cmd.Parameters.AddWithValue("@id", phongChieu.id);
                        cmd.Parameters.AddWithValue("@TenPhong", phongChieu.TenPhong);
                        cmd.Parameters.AddWithValue("@idManHinh", phongChieu.idManHinh);
                        cmd.Parameters.AddWithValue("@SoGheNgoi", phongChieu.SoGheNgoi);
                        cmd.Parameters.AddWithValue("@TrangThaiChoNgoi", phongChieu.TrangThaiChoNgoi);
                        cmd.Parameters.AddWithValue("@SoHangGhe", phongChieu.SoHangGhe);
                        cmd.Parameters.AddWithValue("@SoGheMotHang", phongChieu.SoGheMotHang);

                        int kq = cmd.ExecuteNonQuery();
                        return kq > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa Phòng Chiếu: " + ex.Message);
                return false;
            }
        }
        public bool DeletePhongChieu(int id)
        {
            try
            {
                // Câu lệnh SQL để xóa phòng chiếu
                string query = "DELETE FROM PhongChieu WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@id", id);

                        // Thực thi câu lệnh SQL
                        int kq = cmd.ExecuteNonQuery();

                        // Nếu ít nhất 1 dòng bị ảnh hưởng, xóa thành công
                        return kq > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu có (có thể ném lại exception hoặc trả về false)
                throw new Exception("Lỗi khi xóa phòng chiếu.");
            }
        }
    }
}
