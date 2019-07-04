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
    public class ThayDoiQuyDinhDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ThayDoiQuyDinhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool ThayDoiQD(ThayDoiQuyDinhDTO thaydoi)
        {
            string query = string.Empty;
            query += "UPDATE THAMSO SET [SoLuongHieuXe] = @SoLuongHieuXe,[SoLoaiVTPT] = @SoLoaiVTPT,[SoLuongSuaChuaToiDa] = @SoLuongSuaChuaToiDa,[SoLoaiTienCong] = @SoLoaiTienCong";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SoLuongHieuXe", thaydoi.SoLuongHieuXe1);
                    cmd.Parameters.AddWithValue("@SoLoaiVTPT", thaydoi.SoLoaiVTPT1);
                    cmd.Parameters.AddWithValue("@SoLuongSuaChuaToiDa", thaydoi.SoLuongSuaChuaToiDa1);
                    cmd.Parameters.AddWithValue("@SoLoaiTienCong", thaydoi.SoLoaiTienCong1);
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
        public ThayDoiQuyDinhDTO select()
        {
            string query = string.Empty;
            query += "SELECT *";
            query += " FROM [THAMSO]";
            ThayDoiQuyDinhDTO thaydoi = new ThayDoiQuyDinhDTO();
            //List<ThayDoiQuyDinhDTO> lsThayDoi = new List<ThayDoiQuyDinhDTO>();
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
                                thaydoi.SoLuongHieuXe1 = int.Parse(reader["SoLuongHieuXe"].ToString());
                                thaydoi.SoLuongSuaChuaToiDa1 = int.Parse(reader["SoLuongSuaChuaToiDa"].ToString());
                                thaydoi.SoLoaiVTPT1 = int.Parse(reader["SoLoaiVTPT"].ToString());
                                thaydoi.SoLoaiTienCong1 = int.Parse(reader["SoLoaiTienCong"].ToString());
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
            return thaydoi;
        }      
    }
}
