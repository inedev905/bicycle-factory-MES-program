using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Team2DTO;
using System.Diagnostics;
using System.Globalization;

namespace Team2DAO
{
    public class ProducePlanDAO : IDisposable
    {
        SqlConnection conn;

        public ProducePlanDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        #region 이전버전
        /*
        public List<List<ProducePlanDTO>> GetOrders(string planfromDate, int datecnt)
        {
            string sql = "SP_ProdPlan";

            DataSet ds = new DataSet();
            
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@planfromDate", planfromDate);
            da.SelectCommand.Parameters.AddWithValue("@datecnt", datecnt);

            da.Fill(ds);
            da.Dispose();
            conn.Close();

            List<List<ProducePlanDTO>> list = new List<List<ProducePlanDTO>>();
            list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[0])); //dgvplan 그리드뷰용
            list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[1])); //dgvplanDetail 그리드뷰용
            list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[2])); //orderInfo
            //list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[3])); //dgvplan,detail 그리드뷰 조회원본
            //list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[4])); //afterPlanQty
            return list;

        }
        */
        #endregion

        public List<List<ProducePlanDTO>> GetPlan(List<string> orderIDs, string planfromDate)
        {
            string sql = "SP_GetProdPlan";
            int ordercnt = orderIDs.Count();
            string id = string.Join("@", orderIDs);

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@orderIDs", id);
            da.SelectCommand.Parameters.AddWithValue("@planfromDate", planfromDate);
            da.SelectCommand.Parameters.AddWithValue("@ordercnt", ordercnt);

            da.Fill(ds);
            da.Dispose();
            conn.Close();

            List<List<ProducePlanDTO>> list = new List<List<ProducePlanDTO>>();
            list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[0])); //dgvplan 그리드뷰용
            list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[1])); //dgvplanDetail 그리드뷰용
            list.Add(Helper.DataTableMapToList<ProducePlanDTO>(ds.Tables[2]));

            return list;
        }

        public List<OrderDTO> GetOrders()
        {
            string sql = @"select o.order_id, convert(varchar(10), order_dueDate, 23) order_dueDate, 
                                    c.company_name, convert(varchar(19), order_date, 20) order_date
                            from orders o left outer join company c on o.company_id = c.company_id
                            where o.order_id in (select distinct order_id from orderDetail where producePlan_id is null)
							and order_sendDate is null and deleted = 'N'
                            order by order_dueDate";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<OrderDTO> orders = Helper.DataReaderMapToList<OrderDTO>(cmd.ExecuteReader());
            conn.Close();

            return orders;
        }

        public List<OrderDetailDTO> GetOrderDetail()
        {
            string sql = @"select orderDetail_id, order_id, o.product_id, p.product_name, o.product_Qty
                            from orderDetail o inner join product p on o.product_id = p.product_id
                            where producePlan_id is null";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            List<OrderDetailDTO> orders = Helper.DataReaderMapToList<OrderDetailDTO>(cmd.ExecuteReader());
            conn.Close();

            return orders;
        }



        public bool InsertProducePlanning(ProducePlanDTO plan, List<ProducePlanDTO> planDetail, List<int> orderID, int empID)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                // 생산계획 인서트
                string sql = "SP_ProdPlanSave";
                string orderIDs = string.Join("@", orderID);

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = trans;
                 
                cmd.Parameters.AddWithValue("@planFromDate", Convert.ToDateTime(plan.planFromDate));
                cmd.Parameters.AddWithValue("@planToDate", Convert.ToDateTime(plan.planToDate));
                cmd.Parameters.AddWithValue("@tot_planQty", plan.tot_planQty);
                cmd.Parameters.AddWithValue("@first_writeEmp", empID);
                cmd.Parameters.AddWithValue("@orderDetailID", orderIDs);

                cmd.Parameters.Add(new SqlParameter("@planID", SqlDbType.VarChar, 10));
                cmd.Parameters["@planID"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                string planID = cmd.Parameters["@planID"].Value.ToString();

                //생산계획 디테일 인서트
                cmd.CommandText = "SP_ProdPlanDetailSave";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@producePlan_id", planID);
                cmd.Parameters.Add("@planDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 5);
                cmd.Parameters.Add("@orderQty", SqlDbType.Int);
                cmd.Parameters.Add("@product_Qty", SqlDbType.Int);
                cmd.Parameters.Add("@planQty", SqlDbType.Int);
                cmd.Parameters.Add("@nplanQty", SqlDbType.Int);
                cmd.Parameters.Add("@afterPlanQty", SqlDbType.Int);
                cmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@orderDetail_id", SqlDbType.Int);

                foreach (var item in planDetail)
                {
                    cmd.Parameters["@planDate"].Value = item.planDate;
                    cmd.Parameters["@product_id"].Value = item.product_id;
                    cmd.Parameters["@orderQty"].Value = item.orderQty;
                    cmd.Parameters["@product_Qty"].Value = item.product_Qty;
                    cmd.Parameters["@planQty"].Value = item.planQty;
                    cmd.Parameters["@nplanQty"].Value = item.nPlanQty;
                    cmd.Parameters["@afterPlanQty"].Value = item.afterPlanQty;
                    cmd.Parameters["@orderDetail_id"].Value = item.orderDetail_id;

                    DateTime dateValue;
                    if (DateTime.TryParse(item.dueDate, out dateValue))
                    {
                        cmd.Parameters["@dueDate"].Value = dateValue;
                    }                            
                    else
                    {
                        cmd.Parameters["@dueDate"].Value = System.Data.SqlTypes.SqlDateTime.MinValue;
                    }

                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                return true;

            }
            catch (Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        public List<List<ProducePlanDTO>> GetPlan(DateTime fromDate, DateTime toDate)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                List<ProducePlanDTO> list1 = null;
                List<ProducePlanDTO> list2 = null;
                string sql = "SP_DailyPlanQty";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = trans;
                    cmd.Parameters.AddWithValue("@fromDT", fromDate.ToShortDateString());
                    cmd.Parameters.AddWithValue("@toDT", toDate.ToShortDateString());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        list1 = Helper.DataReaderMapToList<ProducePlanDTO>(reader);
                    }

                    sql = @"select producePlan_id, convert(varchar(10),planFromDate, 23) planFromDate, 
                                        convert(varchar(10),planToDate, 23) planToDate, tot_planQty, first_writeDate, latest_writeDate
                                from producePlan
                                where planFromDate between @fromDT and @toDT and tot_planQty > 0";

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        list2 = Helper.DataReaderMapToList<ProducePlanDTO>(reader);
                    }
                }

                List<List<ProducePlanDTO>> list = new List<List<ProducePlanDTO>>();
                if (list1 != null && list2 != null)
                {
                    list.Add(list1);
                    list.Add(list2);
                }

                trans.Commit();
                return list;
            }
            catch(Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        
        public List<ProducePlanDTO> GetProducePlanDetail(DateTime fromDate, DateTime toDate)
        {
            string sql = @"select producePlanDetail_id, producePlan_id, cast(planDate as date) planDate,
                                d.product_id, p.product_name, planQty, nplanQty, 
                        		case when dueDate = '1753-01-01' then ''
                        		Else CONVERT(varchar(10), dueDate, 23) end dueDate,
                                case when dueDate = '1753-01-01' then '재고'
			                    Else '주문' end produceCategory, orderDetail_id
                          from producePlanDetail d inner join product p on d.product_id = p.product_id
                          where producePlan_id in (select producePlan_id
                        							from producePlan
                        							where planFromDate between @fromDate and @toDate) and planQty > 0";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@fromDate", fromDate);
            cmd.Parameters.AddWithValue("@toDate", toDate);

            conn.Open();
            List<ProducePlanDTO> list = Helper.DataReaderMapToList<ProducePlanDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;

        }

        public bool UpdatePlan(ProducePlanDTO updateInfo, int empID)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"update producePlanDetail
                            set planDate = @planDate, planQty = @planQty, afterPlanQty = @afterPlanQty
                            where producePlanDetail_id = @producePlanDetail_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Transaction = trans;
                cmd.Parameters.AddWithValue("@planDate", updateInfo.planDate);
                cmd.Parameters.AddWithValue("@planQty", updateInfo.planQty);
                cmd.Parameters.AddWithValue("@afterPlanQty", updateInfo.afterPlanQty);
                cmd.Parameters.AddWithValue("@producePlanDetail_id", updateInfo.producePlanDetail_id);
                cmd.ExecuteNonQuery();

                sql = @"update producePlan
                        set tot_planQty = (select sum(planQty)
					                       from producePlanDetail
					                       where producePlan_id = @producePlan_id),
                            planFromDate = (select min(planDate)
                                            from producePlanDetail
                                            where producePlan_id = @producePlan_id),
                            planTodate = (select max(planDate)
                                            from producePlanDetail
                                            where producePlan_id = @producePlan_id),
                            latest_writeDate = getdate(), 
                            latest_writeEmp = @latest_writeEmp
                        where producePlan_id = @producePlan_id";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@producePlan_id", updateInfo.producePlan_id);
                cmd.Parameters.AddWithValue("@latest_writeEmp", empID);
                cmd.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch(Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        public bool DeletePlan(ProducePlanDTO deleteInfo, int empID)
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                string sql = @"delete producePlanDetail
                        where producePlanDetail_id = @producePlanDetail_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@producePlanDetail_id", deleteInfo.producePlanDetail_id);
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();


                cmd.CommandText = @"update orderDetail
                                 set producePlan_id = null
                                 where orderDetail_id = @orderDetail_id";

                cmd.Parameters.AddWithValue("@orderDetail_id", deleteInfo.orderDetail_id);
                cmd.ExecuteNonQuery();


                cmd.CommandText = @"update producePlan
                                    set tot_planQty = (select sum(planQty)
					                                   from producePlanDetail
					                                   where producePlan_id = @producePlan_id),
                                        planFromDate = (select min(planDate)
                                                        from producePlanDetail
                                                        where producePlan_id = @producePlan_id),
                                        planTodate = (select max(planDate)
                                                        from producePlanDetail
                                                        where producePlan_id = @producePlan_id),
                                        latest_writeDate = getdate(), 
                                        latest_writeEmp = @latest_writeEmp
                                    where producePlan_id = @producePlan_id";
                cmd.Parameters.AddWithValue("@producePlan_id", deleteInfo.producePlan_id);
                cmd.Parameters.AddWithValue("@latest_writeEmp", empID);
                cmd.ExecuteNonQuery();

                trans.Commit();
                return true;
            }
            catch(Exception err)
            {
                trans.Rollback();
                Debug.WriteLine(err.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
