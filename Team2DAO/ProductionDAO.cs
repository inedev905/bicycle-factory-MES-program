using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Team2DTO;

namespace Team2DAO
{
    public class ProductionDAO : IDisposable
    {
        SqlConnection conn;

        public ProductionDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<TotCountDTO> SetTotCount()
        {
            
            string sql = @"select product_id, product_name, product_Qty, isnull(totOrders, 0) totOrders_Qty
                            from product p left outer Join 
                            (select product_id as pid, sum(product_qty) as totOrders from orderDetail od inner join orders o on od.order_id = o.order_id
                                    where o.order_sendDate is null  and o.deleted = 'N' and order_dueDate > GETDATE() group by product_id) m 
                            on p.product_id = m.pid
                            order by product_id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            
            List<TotCountDTO> list = Helper.DataReaderMapToList<TotCountDTO>(cmd.ExecuteReader());

            conn.Close();

            return list;
        }

        public List<OrderDTO> SetAllOrders()
        {

            string sql = @"select order_id, company_id, CONVERT(VARCHAR(10), order_date, 23) Order_date,  CONVERT(VARCHAR(10), order_dueDate, 23) as order_dueDate 
                                from orders where order_sendDate is null and order_dueDate > GETDATE() and deleted = 'N'
                                order by order_dueDate";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<OrderDTO> list = Helper.DataReaderMapToList<OrderDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public List<OrderDetailDTO> SetAllOrdersDT()
        {

            string sql = @"select order_id, od.product_id, od.product_qty, p.product_qty as product_price
                            from orderDetail od inner join product p on od.product_id = p.product_id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<OrderDetailDTO> list = Helper.DataReaderMapToList<OrderDetailDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public List<ProductionDTO> SetProduction()
        {
            string sql = @"select produceOrd_id, p.product_name, planQty, 
                                (case when DATEADD(DAY, 3, orderFromDate) > GetDATE() then '작업 진행 중' Else '작업 완료' END) as productionState,
                                CONVERT(VARCHAR(10),  DATEADD(DAY, 3, orderFromDate), 23) as fullProductionDate 
                            from  productionOrder po inner join product p on po.product_id = p.product_id
                            where orderDueDate is Null";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<ProductionDTO> list = Helper.DataReaderMapToList<ProductionDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public bool Shipment(List<OutProductDTO> list)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql1 = @"update orders set order_sendDate = GETDATE(), latest_writeDate = GetDate(), latest_writeEmp  = @latest_writeEmp
                                 where order_id = @order_id";

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql1;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("latest_writeEmp",list[0].loginedEmpID);
                cmd.Parameters.AddWithValue("order_id", list[0].OrderID);
                cmd.Transaction = trans;
                int isOut1 = cmd.ExecuteNonQuery();

                if (isOut1 < 0)
                {
                    return false;
                }

                cmd.Parameters.Clear();
                string sql2 = @"update product set product_qty = @product_qty
                                    where product_id = @product_id";
                cmd.CommandText = sql2;
                cmd.Parameters.Add(new SqlParameter("@product_qty", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@product_id", SqlDbType.NVarChar));
                
                foreach(ProductSet item in list[0].ProductSets)
                {
                    cmd.Parameters["@product_qty"].Value = item.LeftQty;
                    cmd.Parameters["@product_id"].Value = item.ProductID;

                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                trans.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }

        }


        public bool TakeProduct(List<OutProductDTO> list)
        {
            string sql = @"update productionOrder set orderDueDate = GETDATE(), latest_writeDate = GetDate(), latest_writeEmp  = @latest_writeEmp
                                where produceOrd_id = @produceOrd_id;
                            update product set product_qty = (product_qty+@product_qty)
                                where product_id = @product_id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@latest_writeEmp",list[0].loginedEmpID);
            cmd.Parameters.AddWithValue("@produceOrd_id", list[0].OrderID);
            cmd.Parameters.AddWithValue("@product_qty",list[0].ProductSets[0].LeftQty);
            cmd.Parameters.AddWithValue("@product_id", list[0].ProductSets[0].ProductID);

            conn.Open();
            int isInsert =  cmd.ExecuteNonQuery();
            conn.Close();

            return (isInsert>0);
        }

    }
}
