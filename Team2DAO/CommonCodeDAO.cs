using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Team2DTO;

namespace Team2DAO
{
    public class CommonCodeDAO : IDisposable
    {
        SqlConnection conn;

        public CommonCodeDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public List<CommonCodeDTO> GetCommonCategory(string[] category)
        {
            //select category,name,code
            //from commoncode
            //where category = '지역'
            string search = "'" + string.Join("','", category) + "'";

            string sql = @"select category,name,code
                           from commoncode
                           where category in (" + search + ")";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<CommonCodeDTO> list = Helper.DataReaderMapToList<CommonCodeDTO>(cmd.ExecuteReader());
            conn.Close();
            return list;
        }
        
    }
}
