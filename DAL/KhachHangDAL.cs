﻿using System;
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
        private string connectionString = ConfigurationManager.ConnectionStrings["CinemaDB"].ConnectionString;

        // Lấy danh sách tất cả khách hàng
        public List<KhachHang> GetAllKhachHang()
        {
            List<KhachHang> customers = new List<KhachHang>();

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
                        KhachHang kh = new KhachHang()
                        {
                            Id = reader["id"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
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

        // Thêm mới khách hàng
        public bool AddKhachHang(KhachHang kh)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO KhachHang (id, HoTen, NgaySinh, DiaChi, SDT, EMAIL, GioiTinh, DiemTichLuy) " +
                               "VALUES (@Id, @HoTen, @NgaySinh, @DiaChi, @SDT, @Email, @GioiTinh, @DiemTichLuy)";

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

        // Cập nhật thông tin khách hàng
        public bool UpdateKhachHang(KhachHang kh)
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
        public KhachHang GetKhachHangById(string id)
        {
            KhachHang kh = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM KhachHang WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        kh = new KhachHang()
                        {
                            Id = reader["id"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString()),
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["EMAIL"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            DiemTichLuy = int.Parse(reader["DiemTichLuy"].ToString())
                        };
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
