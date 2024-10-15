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
    public class KhachHangDAL
    {
        // Chuỗi kết nối tới database từ file cấu hình
       // private string connectionString = ConfigurationManager.ConnectionStrings["CinemaDB"].ConnectionString;
        private string connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";

        // Lấy danh sách tất cả khách hàng
        public List<KhachHangDTO> GetAllKhachHang()
        {
            List<KhachHangDTO> customers = new List<KhachHangDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        KhachHangDTO kh = new KhachHangDTO()
                        {
                            Id = reader["id"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = (reader["NgaySinh"].ToString()),
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["EMAIL"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            DiemTichLuy = int.Parse(reader["DiemTichLuy"].ToString())
                        };
                        customers.Add(kh);
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return customers;
        }

        public int AddKhachHang(KhachHangDTO kh)
        {
            int newId = 0; // Khởi tạo biến ID mới
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KhachHang (HoTen, NgaySinh, DiaChi, SDT, EMAIL, GioiTinh, DiemTichLuy) " +
                               "VALUES (@HoTen, @NgaySinh, @DiaChi, @SDT, @Email, @GioiTinh, @DiemTichLuy); " +
                               "SELECT SCOPE_IDENTITY();"; // Lấy ID vừa được tạo

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", kh.HoTen);
                command.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = kh.NgaySinh; // Change here
                command.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                command.Parameters.AddWithValue("@SDT", kh.SDT);
                command.Parameters.AddWithValue("@Email", kh.Email);
                command.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                command.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);

                try
                {
                    connection.Open();
                    newId = Convert.ToInt32(command.ExecuteScalar()); // Lấy ID mới từ cơ sở dữ liệu
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return newId; // Trả về ID của khách hàng mới
        }

        // Thêm mới khách hàng
        //public bool AddKhachHang(KhachHangDTO kh)
        //{
        //    bool result = false;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "INSERT INTO KhachHang ( HoTen, NgaySinh, DiaChi, SDT, EMAIL, GioiTinh, DiemTichLuy) " +
        //                       "VALUES ( @HoTen, @NgaySinh, @DiaChi, @SDT, @Email, @GioiTinh, @DiemTichLuy)";

        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@HoTen", kh.HoTen);
        //        command.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
        //        command.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
        //        command.Parameters.AddWithValue("@SDT", kh.SDT);
        //        command.Parameters.AddWithValue("@Email", kh.Email);
        //        command.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
        //        command.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);

        //        try
        //        {
        //            connection.Open();
        //            int rowsAffected = command.ExecuteNonQuery();
        //            result = rowsAffected > 0;
        //        }
        //        catch (Exception ex)
        //        {
        //            // Xử lý ngoại lệ
        //            Console.WriteLine("Error: " + ex.Message);
        //        }
        //    }
        //    return result;
        //}

        // Cập nhật thông tin khách hàng
        public bool UpdateKhachHang(KhachHangDTO kh)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE KhachHang SET HoTen = @HoTen, NgaySinh = @NgaySinh, DiaChi = @DiaChi, " +
                               "SDT = @SDT, EMAIL = @Email, GioiTinh = @GioiTinh, DiemTichLuy = @DiemTichLuy " +
                               "WHERE id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", kh.Id);
                command.Parameters.AddWithValue("@HoTen", kh.HoTen);
                command.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);
                command.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                command.Parameters.AddWithValue("@SDT", kh.SDT);
                command.Parameters.AddWithValue("@Email", kh.Email);
                command.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                command.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    result = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return result;
        }

        // Xóa khách hàng
        public bool DeleteKhachHang(string id)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM KhachHang WHERE id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    result = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return result;
        }

        // Lấy thông tin khách hàng theo ID
        public string GetIdKhachHangByUserName(string username)
        {
            string kh = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT idKH FROM TaiKhoan WHERE UserName = @name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                      kh=reader["idKH"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return kh;
        }
    }

}
