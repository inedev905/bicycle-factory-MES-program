using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DTO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Team2DAO
{
    public class ProductDAO : IDisposable
    {
        SqlConnection conn;

        public ProductDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<ProductDTO> GetAllProduct()
        {
            string sql = @"select product_id, product_name, product_Qty, product_Safety, product_QtyLimit,
                                    product_category, product_chargeEmp, product_price
                            from product";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<ProductDTO> list = Helper.DataReaderMapToList<ProductDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }
    
    }
}
