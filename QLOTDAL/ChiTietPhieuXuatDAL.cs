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
    public class ChiTietPhieuXuatDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ChiTietPhieuXuatDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool them(ChiTietPhieuXuatDTO ctpx)
        {
            string query = string.Empty;
            query += "INSERT INTO [dbo].[CHITIETPHIEUXUAT]([MaChiTietPhieuXuat],[MaHoSo],[MaLoaiVatTu],[NoiDung],[SoLuong],[MaLoaiTienCong],[BienSo],[NgaySuaChua],[ThanhTien])";
            query += " VALUES (@MaChiTietPhieuXuat,@MaHoSo,@MaLoaiVatTu,@NoiDung,@SoLuong,@MaLoaiTienCong,@BienSo,@NgaySuaChua,@ThanhTien)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChiTietPhieuXuat", ctpx.Mactpx);
                    cmd.Parameters.AddWithValue("@MaHoSo", ctpx.Mahs);
                    cmd.Parameters.AddWithValue("@MaLoaiVatTu", ctpx.Mavtpt);
                    cmd.Parameters.AddWithValue("@NoiDung", ctpx.Nd);
                    cmd.Parameters.AddWithValue("@SoLuong", ctpx.Soluong);
                    cmd.Parameters.AddWithValue("@MaLoaiTienCong", ctpx.Maloaitc);
                    cmd.Parameters.AddWithValue("@BienSo", ctpx.Bienso);
                    cmd.Parameters.AddWithValue("@NgaySuaChua", ctpx.Ngaysuachua);                 
                    cmd.Parameters.AddWithValue("@ThanhTien", ctpx.Thanhtien);
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
        public bool xoa(ChiTietPhieuXuatDTO ctpx)
        {
            string query = string.Empty;
            query += "DELETE FROM CHITIETPHIEUXUAT WHERE [MaChiTietPhieuXuat] = @MaChiTietPhieuXuat";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChiTietPhieuXuat", ctpx.Mactpx);
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
        public bool sua(ChiTietPhieuXuatDTO ctpx)
        {
            string query = string.Empty;
            query += "UPDATE CHITIETPHIEUXUAT SET [MaLoaiVatTu] = @MaLoaiVatTu, [NoiDung] = @NoiDung,[SoLuong] = @SoLuong,[MaLoaiTienCong] = @MaLoaiTienCong,[BienSo] = @BienSo,[NgaySuaChua] = @NgaySuaChua,[ThanhTien]=@ThanhTien";
             query +=" WHERE [MaChiTietPhieuXuat] = @MaChiTietPhieuXuat";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaChiTietPhieuXuat", ctpx.Mactpx);
                    cmd.Parameters.AddWithValue("@MaLoaiVatTu", ctpx.Mavtpt);
                    cmd.Parameters.AddWithValue("@NoiDung", ctpx.Nd);
                    cmd.Parameters.AddWithValue("@SoLuong", ctpx.Soluong);
                    cmd.Parameters.AddWithValue("@MaLoaiTienCong", ctpx.Maloaitc);               
                    cmd.Parameters.AddWithValue("@BienSo", ctpx.Bienso);
                    cmd.Parameters.AddWithValue("@NgaySuaChua", ctpx.Ngaysuachua);
                    cmd.Parameters.AddWithValue("@ThanhTien", ctpx.Thanhtien);
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

        public List<ChiTietPhieuXuatDTO> select(string sKmahs)
        {
            string query = string.Empty;         
            query += "SELECT [MaHoSo],[dbo].[CHITIETPHIEUXUAT].MaChiTietPhieuXuat,[SoLuong],[TenLoaiVatTu],[dbo].[LOAIVATTU].DonGia,[TienCong],[ThanhTien],[BienSo],[NgaySuaChua],[NoiDung],[TenLoaiTienCong]";
            query += ",[dbo].[LOAITIENCONG].MaLoaiTienCong,[dbo].[CHITIETPHIEUXUAT].MaLoaiVatTu";//, SUM(ThanhTien) AS TongTien";
            query += " FROM [dbo].[CHITIETPHIEUXUAT]";
            query += " join [dbo].LOAIVATTU on [dbo].[CHITIETPHIEUXUAT].MaLoaiVatTu = [dbo].[LOAIVATTU].MaLoaiVatTu";
            query += " join [dbo].LOAITIENCONG on [dbo].[CHITIETPHIEUXUAT].MaLoaiTienCong = [dbo].[LOAITIENCONG].MaLoaiTienCong";
            query += " WHERE [MaHoSo] = @MaHoSo";
            List<ChiTietPhieuXuatDTO> lsCtpx = new List<ChiTietPhieuXuatDTO>();
            
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaHoSo", sKmahs);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                ChiTietPhieuXuatDTO ctpx = new ChiTietPhieuXuatDTO();
                                //HoSoDTO hs = new HoSoDTO();
                                ctpx.Mactpx = int.Parse(reader["MaChiTietPhieuXuat"].ToString());
                                ctpx.Mahs = int.Parse(reader["MaHoSo"].ToString());
                                ctpx.Tiencong = int.Parse(reader["TienCong"].ToString());
                                ctpx.Tenloaitc = reader["TenLoaiTienCong"].ToString();
                                ctpx.Vtpt = reader["TenLoaiVatTu"].ToString();
                                ctpx.Soluong = int.Parse(reader["SoLuong"].ToString());
                                ctpx.Dongia = (int)float.Parse(reader["DonGia"].ToString());
                                ctpx.Ngaysuachua = DateTime.Parse(reader["NgaySuaChua"].ToString());
                                ctpx.Nd = reader["NoiDung"].ToString(); 
                                ctpx.Bienso = reader["BienSo"].ToString();
                                ctpx.Mavtpt = int.Parse(reader["MaLoaiVatTu"].ToString());
                                ctpx.Maloaitc = int.Parse(reader["MaLoaiTienCong"].ToString());
                                ctpx.Mahs = int.Parse(reader["MaHoSo"].ToString());
                                ctpx.Thanhtien = int.Parse(reader["ThanhTien"].ToString());
                                //hs.Tongtien = int.Parse(reader["TongTien"].ToString());
                                lsCtpx.Add(ctpx);                              
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
            return lsCtpx;
        }

    }
}
