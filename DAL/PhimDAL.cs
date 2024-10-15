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
    }
}
