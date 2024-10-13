using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhimDAL
    {
        // DAL (Data Access Layer)


        private string _connectionString = "Data Source=USER\\MSSQLSERVER01;Initial Catalog=QLRP;Persist Security Info=True;User ID=sa;Password=101204";

        public PhimDAL()
        {
                
        }
        public LichChieuPhimDTO PhimChiTiet()
        {
            return null;
        }
            public List<TheLoaiDTO> DanhSachTheLoai()
        {
            List<TheLoaiDTO> genres = new List<TheLoaiDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    
                    connection.Open();
                    string query = "SELECT * FROM TheLoai"; // Simple query to get genres

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TheLoaiDTO tl = new TheLoaiDTO();
                                tl.Id = reader["id"].ToString();
                                tl.TenTheLoai = reader["TenTheLoai"].ToString();
                                tl.MoTa = reader["MoTa"].ToString();
                                genres.Add(tl);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error retrieving genres: {ex.Message}"); // Log the error
            }
            return genres;
        }

        public List<PhimDTO> TimPheoTheoNgayVaTheLoai(string genre, DateTime date)
        {
            List<PhimDTO> movies = new List<PhimDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"EXEC TimPhimTheoNgayVaLoai @Date = @Date, @Genre= @Genre;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@Date", date.ToString("dd/MM/yyyy"));


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PhimDTO movie = new PhimDTO();
                                movie.Id = reader["id"].ToString();
                                movie.TenPhim = reader.GetString(reader.GetOrdinal("TenPhim"));
                                movie.Poster = reader["PosterPath"].ToString();
                                

                                movie.ThoiLuong = int.Parse(reader["ThoiLuong"].ToString());
                                movie.DaoDien = reader.IsDBNull(reader.GetOrdinal("DaoDien")) ? "" : reader.GetString(reader.GetOrdinal("DaoDien"));
                                movies.Add(movie);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the error appropriately (e.g., using a logging library)
                Console.WriteLine($"Error retrieving movies: {ex.Message}");
            }
            return movies;
        }

        public bool DatVeXemPhim(HoaDonDTO hoaDonDTO)
        {
            return true;
        }
        //Other methods for other operations, like retrieving genres, etc.
    }



}
