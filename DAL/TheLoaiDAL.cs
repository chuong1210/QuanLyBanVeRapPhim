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
        public List<TheLoaiDTO> GetListGenreL()
        {
            List<TheLoaiDTO> genreList = new List<TheLoaiDTO>();

            // Thay đổi chuỗi kết nối cho phù hợp với cơ sở dữ liệu của bạn
            string connectionString = "your_connection_string_here"; // Cập nhật chuỗi kết nối
            string query = "SELECT * FROM theloai";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    foreach (DataRow item in data.Rows)
                    {
                        TheLoaiDTO genre = new TheLoaiDTO(item);
                        genreList.Add(genre);
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return genreList;
        }
    }
}
