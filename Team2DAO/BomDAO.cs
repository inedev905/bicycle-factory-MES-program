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
    public class BomDAO : IDisposable
    {
        SqlConnection conn;
        public BomDAO()
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

        public List<BOMDTO> GetAllBom(string sp)
        {
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            List<BOMDTO> list = Helper.DataReaderMapToList<BOMDTO>(cmd.ExecuteReader());
            conn.Close();
            return list;
        }

        public List<materialListDTO> GetMaterialList()
        {
            
            string sql = @"select material_id as id, material_name as name, material_category as code, c.name as category 
                            from material m inner
                            join commoncode c on m.material_category = c.code";
                 
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<materialListDTO> list = Helper.DataReaderMapToList<materialListDTO>(cmd.ExecuteReader());
            conn.Close();
            return list;

        }

        public bool DelProduct(string txtItemID)
        {
            string sql1 = @"delete from bom where porduct_id = @product_id;
                            delete from product where product_id = @product_id";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            cmd.Parameters.AddWithValue("@product_id", txtItemID);
            
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            
            return (result>0);
        }
        public string CheckMaterial(MaterialCheckDTO materialCheck)
        {
            SqlCommand cmd = new SqlCommand("SP_CheckBOM", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categorys",materialCheck.Category);
            cmd.Parameters.AddWithValue("@brake", materialCheck.Brake);
            cmd.Parameters.AddWithValue("@frame", materialCheck.Frame);
            cmd.Parameters.AddWithValue("@gear", materialCheck.Gear);
            cmd.Parameters.AddWithValue("@handle", materialCheck.Handle);
            cmd.Parameters.AddWithValue("@seat", materialCheck.Seat);
            cmd.Parameters.AddWithValue("@wheel", materialCheck.Wheel);

            string result = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = reader[0].ToString();
            }
            conn.Close();
            
            return result;
        }

        public bool UpdateProductInfo(ProductDTO Product)
        {
            string sql = @"update product set product_name = @product_name, product_QtyLimit = @product_QtyLimit, product_price = @product_price, product_Img = @product_Img,
                                product_Safety = @product_Safety, product_chargeEmp = @product_chargeEmp
                            where product_id = @product_id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@product_name", Product.product_name);
            cmd.Parameters.AddWithValue("@product_price", Product.product_price);
            cmd.Parameters.AddWithValue("@product_QtyLimit", Product.product_QtyLimit);
            cmd.Parameters.AddWithValue("@product_Safety", Product.product_Safety);
            cmd.Parameters.AddWithValue("@product_chargeEmp", Product.product_chargeEmp);
            cmd.Parameters.AddWithValue("@product_Img", Product.product_Img);
            cmd.Parameters.AddWithValue("@product_id", Product.product_id);

            conn.Open();
            int result = cmd.ExecuteNonQuery();

            return (result > 0);

        }

        public string SetProduct(ProductDTO newProduct, MaterialCheckDTO newProductMaterials)
        {
            SqlCommand cmd = new SqlCommand("SP_SetProduct_BOM", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@product_category", newProduct.product_category);
            cmd.Parameters.AddWithValue("@product_name", newProduct.product_name);
            
            cmd.Parameters.AddWithValue("@product_Safety", newProduct.product_Safety);
            cmd.Parameters.AddWithValue("@product_QtyLimit", newProduct.product_QtyLimit);
            cmd.Parameters.AddWithValue("@product_Img", newProduct.product_Img);
            cmd.Parameters.AddWithValue("@product_price", newProduct.product_price);
            cmd.Parameters.AddWithValue("@product_chargeEmp", newProduct.product_chargeEmp);
            cmd.Parameters.AddWithValue("@brake", newProductMaterials.Brake);
            cmd.Parameters.AddWithValue("@frame", newProductMaterials.Frame);
            cmd.Parameters.AddWithValue("@gear", newProductMaterials.Gear);
            cmd.Parameters.AddWithValue("@handle", newProductMaterials.Handle);
            cmd.Parameters.AddWithValue("@seat", newProductMaterials.Seat);
            cmd.Parameters.AddWithValue("@wheel", newProductMaterials.Wheel);

            string result = null;

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result = reader[0].ToString();
            }
            conn.Close();

            return result;
        }

    }
}
