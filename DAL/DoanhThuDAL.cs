using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
  public  class DoanhThuDAL
    {
        private string _connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";

        public DataTable LayDoanhThuTheoKhoangThoiGian(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            string query = @"
        SELECT 
            FORMAT(hd.NgayMua, 'yyyy-MM-dd') AS Ngay, 
            SUM(hd.TongTien) AS TongDoanhThu
        FROM HoaDon hd
        WHERE hd.NgayMua BETWEEN @StartDate AND @EndDate
        GROUP BY FORMAT(hd.NgayMua, 'yyyy-MM-dd')
        ORDER BY Ngay";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

    }
}
