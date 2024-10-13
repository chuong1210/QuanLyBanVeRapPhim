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
        private string connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;User ID=sa;Password=101204";

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
                SqlDataReader reader = command.ExecuteReader();
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


        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE TaiKhoan
                    SET PassWord = @NewPassword
                    WHERE UserName = @UserName AND PassWord = @OldPassword;
                ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@OldPassword", oldPassword);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }


        // ... in your TaiKhoanBLL class
        public bool CheckOldPassword(string userName, string oldPassword)
        {
   
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM TaiKhoan WHERE UserName = @UserName AND PassWord = @OldPassword";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@OldPassword", oldPassword);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                return count > 0; //Return True if count is greater than 0
            }
        }
    }
}
