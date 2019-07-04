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
    public class VatTuPhuTungDAL
    {

        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public VatTuPhuTungDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<VatTuPhuTungDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [MaLoaiVatTu],[TenLoaiVatTu],[SoLuongTon],[DonGia]";
            query += " FROM [LOAIVATTU]";

            List<VatTuPhuTungDTO> lsVatTuPhuTung = new List<VatTuPhuTungDTO>();

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
                                VatTuPhuTungDTO vtpt = new VatTuPhuTungDTO();
                                vtpt.Maloaivattu = int.Parse(reader["MaLoaiVatTu"].ToString());
                                vtpt.Tenloaivattu = reader["TenLoaiVatTu"].ToString();
                                vtpt.Soluongton = int.Parse(reader["SoLuongTon"].ToString());
                                vtpt.Dongia = int.Parse(reader["DonGia"].ToString());
                                lsVatTuPhuTung.Add(vtpt);
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
            return lsVatTuPhuTung;
        }

        public bool them(VatTuPhuTungDTO vtpt)
        {
            string query = string.Empty;
            query += "INSERT INTO [dbo].[LOAIVATTU]([MaLoaiVatTu],[TenLoaiVatTu],[SoLuongTon],[DonGia])";
            query += " VALUES (@MaLoaiVatTu,@TenLoaiVatTu,@SoLuongTon,@DonGia)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLoaiVatTu", vtpt.Maloaivattu);
                    cmd.Parameters.AddWithValue("@TenLoaiVatTu", vtpt.Tenloaivattu);
                    cmd.Parameters.AddWithValue("@SoLuongTon", vtpt.Soluongton);
                    cmd.Parameters.AddWithValue("@DonGia", vtpt.Dongia);
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

        public bool xoa(VatTuPhuTungDTO vtpt)
        {
            string query = string.Empty;
            query += "DELETE FROM [dbo].[LOAIVATTU] WHERE [MaLoaiVatTu] = @MaLoaiVatTu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLoaiVatTu", vtpt.Maloaivattu);
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

        public bool sua(VatTuPhuTungDTO vtpt)
        {
            string query = string.Empty;
            query += "UPDATE [dbo].[LOAIVATTU] SET [TenLoaiVatTu] = @TenLoaiVatTu,[SoLuongTon]=@SoLuongTon,[DonGia]=@DonGia WHERE [MaLoaiVatTu] = @MaLoaiVatTu";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaLoaiVatTu", vtpt.Maloaivattu);
                    cmd.Parameters.AddWithValue("@TenLoaiVatTu", vtpt.Tenloaivattu);
                    cmd.Parameters.AddWithValue("@SoLuongTon", vtpt.Soluongton);
                    cmd.Parameters.AddWithValue("@DonGia", vtpt.Dongia);
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

        public List<VatTuPhuTungDTO> select_ton()
        {
            string query = string.Empty;
            query += "SELECT [MaLoaiVatTu],[TenLoaiVatTu],[SoLuongTon]";
            query += " FROM [LOAIVATTU]";
            query += " WHERE [SoLuongTon] > 10";

            List<VatTuPhuTungDTO> lsVatTuPhuTung = new List<VatTuPhuTungDTO>();

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
                                VatTuPhuTungDTO vtpt = new VatTuPhuTungDTO();
                                vtpt.Maloaivattu = int.Parse(reader["MaLoaiVatTu"].ToString());
                                vtpt.Tenloaivattu = reader["TenLoaiVatTu"].ToString();
                                vtpt.Soluongton = int.Parse(reader["SoLuongTon"].ToString());
                                //vtpt.Dongia = int.Parse(reader["DonGia"].ToString());
                                lsVatTuPhuTung.Add(vtpt);
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
            return lsVatTuPhuTung;
        }

        public List<VatTuPhuTungDTO> select_het()
        {
            string query = string.Empty;
            query += "SELECT [MaLoaiVatTu],[TenLoaiVatTu],[SoLuongTon]";
            query += " FROM [LOAIVATTU]";
            query += " WHERE [SoLuongTon] < 100";

            List<VatTuPhuTungDTO> lsVatTuPhuTung = new List<VatTuPhuTungDTO>();

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
                                VatTuPhuTungDTO vtpt = new VatTuPhuTungDTO();
                                vtpt.Maloaivattu = int.Parse(reader["MaLoaiVatTu"].ToString());
                                vtpt.Tenloaivattu = reader["TenLoaiVatTu"].ToString();
                                vtpt.Soluongton = int.Parse(reader["SoLuongTon"].ToString());
                               // vtpt.Dongia = int.Parse(reader["DonGia"].ToString());
                                lsVatTuPhuTung.Add(vtpt);
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
            return lsVatTuPhuTung;
        }

        //public bool rangbuoc(VatTuPhuTungDTO vtpt)
        //{
        //    string query = string.Empty;
        //    query += "ALTER TABLE [dbo].[LOAIVATTU] ADD CONSTRAINT CheckSL_vtpt(Count(MaLoaiVatTu)<10)";
        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;
        //            try
        //            {
        //                con.Open();
        //                cmd.ExecuteNonQuery();
        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
