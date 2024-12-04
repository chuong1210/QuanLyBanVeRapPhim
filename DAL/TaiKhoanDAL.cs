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

        public bool RegisterEmployee(NhanVienDTO nhanVien, TaiKhoanDTO taiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 1. Thêm nhân viên vào bảng NhanVien
                    string insertNhanVienQuery = @"INSERT INTO NhanVien 
                                           (HoTen, NgaySinh, DiaChi, idQuanLy, SDT, CMND, CaLam) 
                                           OUTPUT INSERTED.id 
                                           VALUES 
                                           (@HoTen, @NgaySinh, @DiaChi, @idQuanLy, @SDT, @CMND, @CaLam)";
                    SqlCommand cmdNhanVien = new SqlCommand(insertNhanVienQuery, connection, transaction);
                    cmdNhanVien.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                    cmdNhanVien.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                    cmdNhanVien.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi ?? (object)DBNull.Value);
                    cmdNhanVien.Parameters.AddWithValue("@idQuanLy", (object)DBNull.Value);
                    cmdNhanVien.Parameters.AddWithValue("@SDT", nhanVien.SDT ?? (object)DBNull.Value);
                    cmdNhanVien.Parameters.AddWithValue("@CMND", nhanVien.CMND);
                    cmdNhanVien.Parameters.AddWithValue("@CaLam", nhanVien.CaLam );

                    int newEmployeeId = (int)cmdNhanVien.ExecuteScalar(); // Lấy ID nhân viên vừa được thêm

                    // 2. Tạo tài khoản cho nhân viên
                    string insertTaiKhoanQuery = @"INSERT INTO TaiKhoan 
                                           (UserName, PassWord, idRole, GhiNhoTK, idNV) 
                                           VALUES 
                                           (@UserName, @PassWord, @idRole, @GhiNhoTK, @idNV)";
                    SqlCommand cmdTaiKhoan = new SqlCommand(insertTaiKhoanQuery, connection, transaction);
                    cmdTaiKhoan.Parameters.AddWithValue("@UserName", taiKhoan.UserName);
                    cmdTaiKhoan.Parameters.AddWithValue("@PassWord", taiKhoan.PassWord); // Mã hóa mật khẩu trước khi lưu
                    cmdTaiKhoan.Parameters.AddWithValue("@idRole", 2); // idRole = 2 (Nhân viên)
                    cmdTaiKhoan.Parameters.AddWithValue("@GhiNhoTK", 0);
                    cmdTaiKhoan.Parameters.AddWithValue("@idNV", newEmployeeId);

                    cmdTaiKhoan.ExecuteNonQuery();

                    // Commit transaction nếu mọi thứ thành công
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    // Rollback transaction nếu có lỗi
                    transaction.Rollback();
                    return false;
                }
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
