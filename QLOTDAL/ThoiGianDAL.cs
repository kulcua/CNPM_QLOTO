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
   public class ThoiGianDAL
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public ThoiGianDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<ThoiGianDTO> select()
        {
            string query = string.Empty;
            query += "SELECT [MaThoiGian],[ThangNam]";
            query += "FROM [THOIGIAN]";

            List<ThoiGianDTO> lsThoiGian = new List<ThoiGianDTO>();

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
                                ThoiGianDTO tg = new ThoiGianDTO();
                                tg.Mathoigian = int.Parse(reader["MaThoiGian"].ToString());
                                tg.Thang = int.Parse(reader["ThangNam"].ToString());
                                lsThoiGian.Add(tg);
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
            return lsThoiGian;
        }
    }
}
