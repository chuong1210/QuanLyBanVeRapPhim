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
    public class LoaiManHinhDAL
    {
        private static string connectionString = "Data Source=LAPTOP-DTCNUEFC\\SQLEXPRESS;Initial Catalog=QLRP;Integrated Security=True;";
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
        public bool ThemLoaiManHinh(LoaiManHinhDTO loaiManHinh)
        {
            try
            {
                // Câu lệnh SQL để thêm dữ liệu vào bảng LoaiManHinh
                string query = "INSERT INTO LoaiManHinh (TenMH, KichThuoc) VALUES (@TenMH, @KichThuoc)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@TenMH", loaiManHinh.TenMH);
                        cmd.Parameters.AddWithValue("@KichThuoc", loaiManHinh.KichThuoc);

                        // Thực thi câu lệnh SQL
                        int result = cmd.ExecuteNonQuery();

                        // Nếu ít nhất 1 dòng bị ảnh hưởng, thêm thành công
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // In lỗi ra console hoặc log nếu có ngoại lệ
                Console.WriteLine("Lỗi khi thêm LoaiManHinh: " + ex.Message);
                return false;
            }
        }
        public bool UpdateLoaiManHinh(LoaiManHinhDTO loaiManHinh)
        {
            try
            {
                // Câu lệnh SQL để sửa dữ liệu
                string query = "UPDATE LoaiManHinh SET TenMH = @TenMH, KichThuoc = @KichThuoc WHERE Id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@Id", loaiManHinh.Id);
                        cmd.Parameters.AddWithValue("@TenMH", loaiManHinh.TenMH);
                        cmd.Parameters.AddWithValue("@KichThuoc", loaiManHinh.KichThuoc);

                        // Thực thi câu lệnh SQL
                        int kq = cmd.ExecuteNonQuery();

                        // Nếu ít nhất 1 dòng bị ảnh hưởng, sửa thành công
                        return kq > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa LoaiManHinh: " + ex.Message);
                return false;
            }
        }
        public bool DeleteLoaiManHinh(int id)
        {
            try
            {
                // Câu lệnh SQL để xóa dữ liệu
                string query = "DELETE FROM LoaiManHinh WHERE Id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@Id", id);

                        // Thực thi câu lệnh SQL
                        int kq = cmd.ExecuteNonQuery();

                        // Nếu ít nhất 1 dòng bị ảnh hưởng, xóa thành công
                        return kq > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa LoaiManHinh: " + ex.Message);
                return false;
            }
        }
    }
}
