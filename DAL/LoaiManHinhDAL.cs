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
        private static string connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";
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
    }
}
