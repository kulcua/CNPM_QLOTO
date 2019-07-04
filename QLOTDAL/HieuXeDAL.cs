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
    public class HieuXeDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public HieuXeDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<HieuXeDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [MaHieuXe],[HieuXe]";
            query += "FROM [HIEUXE]";

            List<HieuXeDTO> lsHieuXe = new List<HieuXeDTO>();

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
                                HieuXeDTO hx = new HieuXeDTO();
                                hx.Mahieuxe = int.Parse(reader["MaHieuXe"].ToString());
                                hx.Tenhieuxe = reader["HieuXe"].ToString();
                                lsHieuXe.Add(hx);
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
            return lsHieuXe;
        }

        public bool them(HieuXeDTO hx)
        {
            string query = string.Empty;
            query += "INSERT INTO [dbo].[HIEUXE]([MaHieuXe],[HieuXe])";
            query += "VALUES (@MaHieuXe,@HieuXe)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHieuXe", hx.Mahieuxe);
                    cmd.Parameters.AddWithValue("@HieuXe", hx.Tenhieuxe);
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

        public bool xoa(HieuXeDTO hx)
        {
            string query = string.Empty;
            query += "DELETE FROM [dbo].[HIEUXE] WHERE [MaHieuXe] = @MaHieuXe";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHieuXe", hx.Mahieuxe);
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

        public bool sua(HieuXeDTO hx)
        {
            string query = string.Empty;
            query += "UPDATE [dbo].[HIEUXE] SET [HieuXe] = @HieuXe WHERE [MaHieuXe] = @MaHieuXe";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHieuXe", hx.Mahieuxe);
                    cmd.Parameters.AddWithValue("@HieuXe", hx.Tenhieuxe);
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

        public List<HieuXeDTO> selectByKeyWord(string sKwThoigian)
        {
            string query = string.Empty;
            query += "SELECT HieuXe, COUNT(HieuXe) AS SoLuotSua, SUM([TienCong]+[SoLuong]*[dbo].[LOAIVATTU].DonGia) AS ThanhTien";
            query += " FROM HIEUXE JOIN HOSO ON HIEUXE.MaHieuXe = HOSO.MaHieuXe";
            query += " JOIN CHITIETPHIEUXUAT ON CHITIETPHIEUXUAT.MaHoSo=HOSO.MaHoSo";
            query += " JOIN LOAIVATTU ON LOAIVATTU.MaLoaiVatTu = CHITIETPHIEUXUAT.MaLoaiVatTu";
            query += " JOIN LOAITIENCONG ON LOAITIENCONG.MaLoaiTienCong = CHITIETPHIEUXUAT.MaLoaiTienCong";
            query += " WHERE MONTH(NgayTiepNhan)=@sKwThoigian GROUP BY HieuXe";
            List<HieuXeDTO> lsHieuXe = new List<HieuXeDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKwThoigian", sKwThoigian);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HieuXeDTO hx = new HieuXeDTO();
                                hx.Tenhieuxe = reader["HieuXe"].ToString();
                                hx.Soluotsua = int.Parse(reader["SoLuotSua"].ToString());
                                hx.Thanhtien = int.Parse(reader["ThanhTien"].ToString());
                                lsHieuXe.Add(hx);
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
            return lsHieuXe;
        }
    }
}
