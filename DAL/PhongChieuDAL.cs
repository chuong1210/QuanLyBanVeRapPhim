﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongChieuDAL
    {
        private static string connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";
        public  DataTable GetListCinema()
        {
            string query = "SELECT * FROM PhongChieu"; // Truy vấn SQL

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
        public List<PhongChieuDTO> GetListPhongChieu()
        {
            string query = "SELECT * FROM PhongChieu"; // Query để lấy danh sách phòng chiếu
            List<PhongChieuDTO> listPhongChieu = new List<PhongChieuDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhongChieuDTO phongChieu = new PhongChieuDTO
                            {
                                id = (int)reader["Id"], // ID của phòng chiếu
                                TenPhong = reader["TenPhong"].ToString(), // Tên phòng chiếu
                                idManHinh = reader["idManHinh"].ToString(), // ID màn hình
                                SoGheNgoi = reader.IsDBNull(reader.GetOrdinal("SoGheNgoi")) ? 0 : (int)reader["SoGheNgoi"], // Số ghế ngồi
                                TrangThaiChoNgoi = reader.IsDBNull(reader.GetOrdinal("TrangThaiChoNgoi")) ? 1 : (int)reader["TrangThaiChoNgoi"], // Trạng thái chỗ ngồi
                                SoHangGhe = reader.IsDBNull(reader.GetOrdinal("SoHangGhe")) ? 0 : (int)reader["SoHangGhe"], // Số hàng ghế
                                SoGheMotHang = reader.IsDBNull(reader.GetOrdinal("SoCotGhe")) ? 0 : (int)reader["SoCotGhe"] // Số ghế mỗi hàng
                            };
                            listPhongChieu.Add(phongChieu);
                        }
                    }
                }
            }

            return listPhongChieu;
        }
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
        public bool ThemPhongChieu(PhongChieuDTO phongChieu)
        {
            try
            {
                string query = @"INSERT INTO PhongChieu (TenPhong, idManHinh, SoGheNgoi, TrangThaiChoNgoi, SoHangGhe, SoCotGhe) 
                         VALUES (@TenPhong, @idManHinh, @SoGheNgoi, @TrangThaiChoNgoi, @SoHangGhe, @SoGheMotHang)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenPhong", phongChieu.TenPhong);
                        cmd.Parameters.AddWithValue("@idManHinh", phongChieu.idManHinh);
                        cmd.Parameters.AddWithValue("@SoGheNgoi", phongChieu.SoGheNgoi);
                        cmd.Parameters.AddWithValue("@TrangThaiChoNgoi", phongChieu.TrangThaiChoNgoi);
                        cmd.Parameters.AddWithValue("@SoHangGhe", phongChieu.SoHangGhe);
                        cmd.Parameters.AddWithValue("@SoCotGhe", phongChieu.SoGheMotHang);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm Phòng Chiếu: " + ex.Message);
                return false;
            }
        }
        public bool SuaPhongChieu(PhongChieuDTO phongChieu)
        {
            try
            {
                string query = @"UPDATE PhongChieu 
                         SET TenPhong = @TenPhong, 
                             idManHinh = @idManHinh, 
                             SoGheNgoi = @SoGheNgoi, 
                             TrangThaiChoNgoi = @TrangThaiChoNgoi, 
                             SoHangGhe = @SoHangGhe, 
                             SoCotGhe = @SoGheMotHang
                         WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số
                        cmd.Parameters.AddWithValue("@id", phongChieu.id);
                        cmd.Parameters.AddWithValue("@TenPhong", phongChieu.TenPhong);
                        cmd.Parameters.AddWithValue("@idManHinh", phongChieu.idManHinh);
                        cmd.Parameters.AddWithValue("@SoGheNgoi", phongChieu.SoGheNgoi);
                        cmd.Parameters.AddWithValue("@TrangThaiChoNgoi", phongChieu.TrangThaiChoNgoi);
                        cmd.Parameters.AddWithValue("@SoHangGhe", phongChieu.SoHangGhe);
                        cmd.Parameters.AddWithValue("@SoGheMotHang", phongChieu.SoGheMotHang);

                        int kq = cmd.ExecuteNonQuery();
                        return kq > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa Phòng Chiếu: " + ex.Message);
                return false;
            }
        }
        public bool DeletePhongChieu(int id)
        {
            try
            {
                // Câu lệnh SQL để xóa phòng chiếu
                string query = "DELETE FROM PhongChieu WHERE id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@id", id);

                        // Thực thi câu lệnh SQL
                        int kq = cmd.ExecuteNonQuery();

                        // Nếu ít nhất 1 dòng bị ảnh hưởng, xóa thành công
                        return kq > 0;
                    }
                }
            }
            catch (Exception)
            {
                // Xử lý lỗi nếu có (có thể ném lại exception hoặc trả về false)
                throw new Exception("Lỗi khi xóa phòng chiếu.");
            }
        }
    }
}
