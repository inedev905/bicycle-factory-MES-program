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
    public class ProductionOrderDAO : IDisposable
    {
        SqlConnection conn;
        public ProductionOrderDAO()
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

        public bool InsertProductionOrder(List<ProductionOrderDTO> list1, List<ProducePlanDTO> list2, List<BOMDTO> list3)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql1 = @"insert into productionOrder(produceOrd_id, product_id, emp_id, produceOrd_category, orderFromDate, planQty)
                                    values(concat('p', convert(char(6), getdate(),  12), replicate(0, 2 - Len((select cnt from vw_countpord)+1)), (select cnt from vw_countpord)+1),
                                            @product_id, (select top 1 emp_id from employee where dep_code = 'd02' and title_code = 'r02'),
                                            'PL', getDate(), @planQty);

                                SELECT top 1 produceOrd_id 
                                from productionOrder 
                                order by first_writeDate desc";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);

                string sql2 = @"update producePlanDetail 
                                set productionOrder_id = @pordID, productionOrder_Qty += @qty 
                                where producePlanDetail_id = @pdetail_id";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                cmd1.Parameters.Add(new SqlParameter("@product_id", SqlDbType.NVarChar));
                cmd1.Parameters.Add(new SqlParameter("@planQty", SqlDbType.Int));
                cmd1.Transaction = trans;

                cmd2.Parameters.Add(new SqlParameter("@pordID", SqlDbType.NVarChar));
                cmd2.Parameters.Add(new SqlParameter("@qty", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@pdetail_id", SqlDbType.NVarChar));
                cmd2.Transaction = trans;

                foreach (var item in list1)
                {
                    cmd1.Parameters["@product_id"].Value = item.product_id;
                    cmd1.Parameters["@planQty"].Value = item.planQty;

                    string id = cmd1.ExecuteScalar().ToString();

                    foreach (var list2item in list2.FindAll((s)=>s.product_id == item.product_id).FindAll((s)=>s.afterPlanQty > 0))
                    {
                        cmd2.Parameters["@pordID"].Value = id;
                        cmd2.Parameters["@qty"].Value = list2item.afterPlanQty;
                        cmd2.Parameters["@pdetail_id"].Value = list2item.producePlanDetail_id;

                        cmd2.ExecuteNonQuery();
                    }
                }

                string sql3 = @"update material 
                                set material_Qty -= @Qty 
                                where material_id = @product_id";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);

                cmd3.Parameters.Add(new SqlParameter("@Qty", SqlDbType.Int));
                cmd3.Parameters.Add(new SqlParameter("@product_id", SqlDbType.NVarChar));
                cmd3.Transaction = trans;

                foreach (var item in list3)
                {
                    cmd3.Parameters["@Qty"].Value = item.Levels;
                    cmd3.Parameters["@product_id"].Value = item.Item;

                    cmd3.ExecuteNonQuery();
                }

                trans.Commit();
                return true;
            }
            catch (Exception err)
            {
                trans.Rollback();
                string msg = err.Message;
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public List<ProducePlanDTO> GetProductionPlanList1()
        {
            string sql = @"select product_id, product_name, sum(planQty) planQty, nPlanQty 
                            from vw_productionplan 
                            group by product_id, product_name, nPlanQty order by product_id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<ProducePlanDTO> list = Helper.DataReaderMapToList<ProducePlanDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public List<ProducePlanDTO> GetProductionPlanList2()
        {
            string sql = @"select * from vw_productionplan";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<ProducePlanDTO> list = Helper.DataReaderMapToList<ProducePlanDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public List<BOMDTO> getMaterialList(Dictionary<string, int> dic)
        {
            string sql = $@"SELECT  porduct_id Category, m.material_id Item, m.material_name Name, m.material_Qty Qty, b.bom_materialRate * @num Levels
                        FROM dbo.bom AS b INNER JOIN dbo.material AS m ON b.material_id = m.material_id
                        WHERE  b.porduct_id = @pid";

            List<BOMDTO> list = new List<BOMDTO>();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.Add(new SqlParameter("@num", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@pid", SqlDbType.VarChar));

            foreach (var item in dic.Keys)
            {
                cmd.Parameters["@num"].Value = dic[item];
                cmd.Parameters["@pid"].Value = item;
                IDataReader dr = cmd.ExecuteReader();
                List<BOMDTO> tmpList = Helper.DataReaderMapToList<BOMDTO>(dr);
                dr.Close();
                list.AddRange(tmpList);
            }

            conn.Close();

            return list;
        }

        public List<ProductionOrderDTO> GetProductionOrders()
        {
            string sql = @"select produceOrd_id, p.product_id , product_name, p.emp_id, emp_name, CONVERT(nvarchar, orderFromDate, 23) orderFromDate, planQty, 
	                            case [level] when 0 then '도색' when 1 then '조립1' when 2 then '조립2' else '생산 완료' end level
                            from productionOrder p inner join employee e on p.emp_id = e.emp_id
						                        inner join product pd on p.product_id = pd.product_id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<ProductionOrderDTO> list = Helper.DataReaderMapToList<ProductionOrderDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

    }
}
