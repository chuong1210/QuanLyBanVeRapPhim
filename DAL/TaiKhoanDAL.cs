using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
  public  class TaiKhoanDAL
    {
        private string connectionString = "Data Source=LAPTOP-DTCNUEFC\\SQLEXPRESS;Initial Catalog=QLRP;Integrated Security=True;";

        public TaiKhoanDTO GetTaiKhoan(string userName, string password)
        {
            TaiKhoanDTO taiKhoan = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TaiKhoan WHERE UserName = @UserName AND PassWord = @PassWord";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@PassWord", password);

                connection.Open();

                // Sử dụng 'using' để đảm bảo rằng SqlDataReader được giải phóng sau khi sử dụng
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        taiKhoan = new TaiKhoanDTO
                        {
                            Id = (int)reader["id"],
                            UserName = reader["UserName"].ToString(),
                            PassWord = reader["PassWord"].ToString(),
                            IdRole = (int)reader["idRole"]
                        };
                    }
                }
            }

            return taiKhoan;
        }

        public bool Register(TaiKhoanDTO taiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoan (UserName, PassWord, idRole,idKH) VALUES (@UserName, @PassWord, @IdRole, @IdKH)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", taiKhoan.UserName);
                command.Parameters.AddWithValue("@PassWord", taiKhoan.PassWord);
                command.Parameters.AddWithValue("@IdRole", taiKhoan.IdRole);
                command.Parameters.AddWithValue("@IdKH", taiKhoan.IdKH);


                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0; // Trả về true nếu đăng ký thành công
            }
        }
    }
}
