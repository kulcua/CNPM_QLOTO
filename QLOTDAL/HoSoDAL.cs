  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using QLOTDTO;


namespace QLOTDAL
{
    public class HoSoDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public HoSoDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(HoSoDTO hs)
        {
            string query = string.Empty;
            query += "INSERT INTO [HOSO] ([MaHoSo],[TenChuXe], [DiaChi], [BienSo], [DienThoai], [MaHieuXe], [NgayTiepNhan])";
            query += "VALUES (@MaHoSo,@TenChuXe,@DiaChi,@BienSo,@DienThoai,@MaHieuXe,@NgayTiepNhan)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHoSo", hs.Mahs);
                    cmd.Parameters.AddWithValue("@TenChuXe", hs.Ten);
                    cmd.Parameters.AddWithValue("@DiaChi", hs.Diachi);
                    cmd.Parameters.AddWithValue("@BienSo", hs.Bienso);
                    cmd.Parameters.AddWithValue("@DienThoai", hs.Dienthoai);
                    cmd.Parameters.AddWithValue("@MaHieuXe", hs.Hieuxe);
                    cmd.Parameters.AddWithValue("@NgayTiepNhan", hs.Ngaytiepnhan);
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
        public bool xoa(HoSoDTO hs)
        {
            string query = string.Empty;
            query += "DELETE FROM HOSO WHERE [MaHoSo] = @MaHoSo";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHoSo", hs.Mahs);
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

        public bool sua(HoSoDTO hs)
        {
            string query = string.Empty;
            query += "UPDATE HOSO SET [TenChuXe] = @TenChuXe, [DiaChi] = @DiaChi,[BienSo] = @BienSo,[DienThoai] = @DienThoai,[MaHieuXe] = @MaHieuXe,[NgayTiepNhan] = @NgayTiepNhan WHERE [MaHoSo] = @MaHoSo";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHoSo", hs.Mahs);
                    cmd.Parameters.AddWithValue("@TenChuXe", hs.Ten);
                    cmd.Parameters.AddWithValue("@DiaChi", hs.Diachi);
                    cmd.Parameters.AddWithValue("@BienSo", hs.Bienso);
                    cmd.Parameters.AddWithValue("@DienThoai", hs.Dienthoai);
                    cmd.Parameters.AddWithValue("@MaHieuXe", hs.Hieuxe);
                    cmd.Parameters.AddWithValue("@NgayTiepNhan", hs.Ngaytiepnhan);
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

        public List<HoSoDTO> select()
        {
            string query = string.Empty;
            query += "SELECT[MaHoSo],[TenChuXe],[DiaChi],[BienSo],[DienThoai],[dbo].[HOSO].MaHieuXe,[NgayTiepNhan],[dbo].HIEUXE.HieuXe";
            query += " FROM [HOSO]";
            query += " join [dbo].HIEUXE on [dbo].[HOSO].MaHieuXe = [dbo].HIEUXE.MaHieuXe";
            List<HoSoDTO> lsHoso = new List<HoSoDTO>();
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
                                HoSoDTO hs = new HoSoDTO();
                                hs.Mahs = int.Parse(reader["MaHoSo"].ToString());
                                hs.Ten = reader["TenChuXe"].ToString();
                                hs.Diachi = reader["DiaChi"].ToString();
                                hs.Bienso = reader["BienSo"].ToString();
                                hs.Dienthoai = int.Parse(reader["DienThoai"].ToString());
                                hs.Hieuxe = int.Parse(reader["Mahieuxe"].ToString());
                                hs.Tenhieuxe = reader["HieuXe"].ToString();
                                hs.Ngaytiepnhan = DateTime.Parse(reader["NgayTiepNhan"].ToString());
                                lsHoso.Add(hs);
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
            return lsHoso;
        }

        public List<HoSoDTO> selectByKeyWord(string sKwBienSo, string sKwHieuXe, string sKwChuXe, string sKwMaHoSo, string sKwDienThoai)
        {
            string query = string.Empty;
            query += "SELECT[MaHoSo],[TenChuXe],[DiaChi],[BienSo],[DienThoai],[dbo].[HOSO].MaHieuXe,[NgayTiepNhan],[dbo].HIEUXE.HieuXe";
            query += " FROM [HOSO]";
            query += " join [dbo].HIEUXE on [dbo].[HOSO].MaHieuXe = [dbo].HIEUXE.MaHieuXe";
            query += " WHERE ([BienSo] LIKE CONCAT('%',@sKwBienSo,'%'))";
            query += " AND ([HieuXe] LIKE CONCAT('%',@sKwHieuXe,'%'))";
            query += " AND ([TenChuXe] LIKE CONCAT('%',@sKwChuXe,'%'))";
            query += " AND ([MaHoSo] LIKE CONCAT('%',@sKwMaHoSo,'%'))";
            query += " AND ([DienThoai] LIKE CONCAT('%',@sKwDienThoai,'%'))";
            List<HoSoDTO> lsHoso = new List<HoSoDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKwBienSo", sKwBienSo);
                    cmd.Parameters.AddWithValue("@sKwHieuXe", sKwHieuXe);
                    cmd.Parameters.AddWithValue("@sKwChuXe", sKwChuXe);
                    cmd.Parameters.AddWithValue("@sKwMaHoSo", sKwMaHoSo);
                    cmd.Parameters.AddWithValue("@sKwDienThoai", sKwDienThoai);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HoSoDTO hs = new HoSoDTO();
                                hs.Mahs = int.Parse(reader["MaHoSo"].ToString());
                                hs.Ten = reader["TenChuXe"].ToString();
                                hs.Diachi = reader["DiaChi"].ToString();
                                hs.Bienso = reader["BienSo"].ToString();
                                hs.Dienthoai = int.Parse(reader["DienThoai"].ToString());
                                hs.Hieuxe = int.Parse(reader["Mahieuxe"].ToString());
                                hs.Tenhieuxe = reader["HieuXe"].ToString();
                                hs.Ngaytiepnhan = DateTime.Parse(reader["NgayTiepNhan"].ToString());
                                lsHoso.Add(hs);
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
            return lsHoso;
        }
    }
}
