using QLOTDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLOTDAL
{
    public class TienCongDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public TienCongDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<TienCongDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [MaLoaiTienCong],[TenLoaiTienCong],[TienCong]";
            query += " FROM [dbo].[LOAITIENCONG]";

            List<TienCongDTO> lsTienCong = new List<TienCongDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                TienCongDTO tc = new TienCongDTO();
                                tc.Maloaitiencong = int.Parse(reader["MaLoaiTienCong"].ToString());
                                tc.Tenloaitiencong = reader["TenLoaiTienCong"].ToString();
                                tc.Tiencong = int.Parse(reader["TienCong"].ToString());
                                lsTienCong.Add(tc);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsTienCong;
        }
        public bool them(TienCongDTO tc)
        {
            string query = string.Empty;
            query += "INSERT INTO [dbo].[LOAITIENCONG]([MaLoaiTienCong],[TenLoaiTienCong],[TienCong])";
            query += "VALUES (@MaLoaiTienCong,@TenLoaiTienCong,@TienCong)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLoaiTienCong", tc.Maloaitiencong);
                    cmd.Parameters.AddWithValue("@TenLoaiTienCong", tc.Tenloaitiencong);
                    cmd.Parameters.AddWithValue("@TienCong", tc.Tiencong);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public bool xoa(TienCongDTO tc)
        {
            string query = string.Empty;
            query += "DELETE FROM [dbo].[LOAITIENCONG] WHERE [MaLoaiTienCong] = @MaLoaiTienCong";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLoaiTienCong", tc.Maloaitiencong);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public bool sua(TienCongDTO tc)
        {
            string query = string.Empty;
            query += "UPDATE [dbo].[LOAITIENCONG] SET [TenLoaiTienCong] = @TenLoaiTienCong,[TienCong] = @TienCong WHERE [MaLoaiTienCong] = @MaLoaiTienCong";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLoaiTienCong", tc.Maloaitiencong);
                    cmd.Parameters.AddWithValue("@TenLoaiTienCong", tc.Tenloaitiencong);
                    cmd.Parameters.AddWithValue("@TienCong", tc.Tiencong);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
