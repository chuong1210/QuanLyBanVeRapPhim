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
    public class TheLoaiDAL
    {
        private static string connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204;";
        public DataTable GetListGenre()
        {
            string query = "SELECT * FROM TheLoai"; // Truy vấn SQL

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
        public List<TheLoaiDTO> GetListGenreList()
        {
            List<TheLoaiDTO> theLoaiList = new List<TheLoaiDTO>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Câu truy vấn SQL để lấy danh sách thể loại
                    string query = "SELECT id, TenTheLoai, MoTa FROM TheLoai"; // Thay đổi tên bảng nếu cần

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Đọc dữ liệu và chuyển sang danh sách các đối tượng DTO
                        while (reader.Read())
                        {
                            TheLoaiDTO theLoai = new TheLoaiDTO
                            {
                                Id = reader["id"] != DBNull.Value ? int.Parse(reader["id"].ToString()) : 0, // Kiểm tra null trước khi ép kiểu
                                TenTheLoai = reader["TenTheLoai"].ToString(),
                                MoTa = reader["MoTa"].ToString() ?? string.Empty  // Kiểm tra null
                            };

                            theLoaiList.Add(theLoai);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách thể loại: " + ex.Message);
            }

            return theLoaiList;
        }
        public bool ThemTheLoai(TheLoaiDTO theLoai)
        {
            try
            {
                string query = "INSERT INTO TheLoai (TenTheLoai, MoTa) VALUES (@TenTheLoai, @MoTa)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenTheLoai", theLoai.TenTheLoai);
                        cmd.Parameters.AddWithValue("@MoTa", theLoai.MoTa);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu có
                return false;
            }
        }
        public bool SuaTheLoai(TheLoaiDTO theLoai)
        {
            try
            {
                string query = "UPDATE TheLoai SET TenTheLoai = @TenTheLoai, MoTa = @MoTa WHERE id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenTheLoai", theLoai.TenTheLoai);
                        cmd.Parameters.AddWithValue("@MoTa", theLoai.MoTa);
                        cmd.Parameters.AddWithValue("@Id", theLoai.Id);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu có
                return false;
            }
        }
        public bool XoaTheLoai(string id)
        {
            try
            {
                string query = "DELETE FROM TheLoai WHERE id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu có
                return false;
            }
        }
    }
}
