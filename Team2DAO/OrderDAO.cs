using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using Team2DTO;

namespace Team2DAO
{
    public class OrderDAO : IDisposable
    {
        SqlConnection conn;
        public OrderDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<OrderDTO> GetOrderSearch(OrderDTO order, string fromODt, string toODt, string states, string fromOdDt, string toOdDt) //주문목록 조회
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                //sb.Append("SP_OrderList");
                sb.Append(@"SELECT A.order_id Order_id
                                , D.company_name Company_name
                                , CONVERT(VARCHAR(10), order_date, 23) Order_date
                             , CONVERT(VARCHAR(10), order_dueDate, 23) Order_dueDate           
                             , CASE WHEN deleted = 'Y' THEN '주문취소' 
		                            WHEN order_sendDate IS NULL THEN '주문완료'		    
	                                ELSE '출하완료' END AS States
                             , CONVERT(VARCHAR(10), order_sendDate, 23) Order_sendDate
                             , SUM(B.product_Qty * C.Product_price) TotAmount
                             , E.Emp_name
                                , CONVERT(VARCHAR(10), A.first_writeDate, 23) First_writeDate  
                                , A.first_writeEmp First_writeEmp
                                , CONVERT(VARCHAR(10), A.latest_writeDate, 23) Latest_writeDate
                                , A.latest_writeEmp Latest_writeEmp 
                            FROM orders A INNER JOIN orderDetail B  ON A.order_id = B.order_id            
                            INNER JOIN product C  ON B.product_id = C.product_id                     
                            INNER JOIN company D  ON A.company_id = D.company_id  
                            INNER JOIN employee E ON A.emp_id = E.emp_id
                            WHERE D.business_category = 'c02'
                            AND A.order_date >= @fromODt AND order_date < @toODt
                            AND order_dueDate >= @fromOdDt AND order_dueDate < @toOdDt");

                cmd.Parameters.AddWithValue("@fromODt", fromODt);
                cmd.Parameters.AddWithValue("@toODt", toODt);
                cmd.Parameters.AddWithValue("@fromOdDt", fromOdDt);
                cmd.Parameters.AddWithValue("@toOdDt", toOdDt);

                if (!string.IsNullOrWhiteSpace(order.Company_name))
                {
                    sb.Append(" AND D.company_name LIKE @company_name");
                    cmd.Parameters.AddWithValue("@company_name", "%" + order.Company_name + "%");
                }
                if (!string.IsNullOrWhiteSpace(order.Emp_name))
                {
                    sb.Append(" AND E.Emp_name LIKE @Emp_name");
                    cmd.Parameters.AddWithValue("@Emp_name", "%" + order.Emp_name + "%");
                }
                if (!string.IsNullOrWhiteSpace(order.Order_id))
                {
                    sb.Append(" AND A.order_id LIKE @order_id");
                    cmd.Parameters.AddWithValue("@order_id", "%" + order.Order_id + "%");
                }

                if (states == "주문완료")
                {
                    sb.Append(" AND order_sendDate IS NULL AND deleted  = 'N'");
                }
                else if (states == "출하완료")
                {
                    sb.Append(" AND order_sendDate IS NOT NULL AND deleted  = 'N'");
                }
                else if (states == "주문취소")
                {
                    sb.Append("  AND deleted  = 'Y'");
                }

                sb.Append(" GROUP BY A.order_id, D.company_name, order_date, order_dueDate, order_sendDate, E.Emp_name, A.first_writeDate, A.first_writeEmp, A.latest_writeDate, A.latest_writeEmp, deleted ORDER BY order_id");

                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                conn.Open();
                Debug.WriteLine("A " + cmd.CommandText);

                List<OrderDTO> list = Helper.DataReaderMapToList<OrderDTO>(cmd.ExecuteReader());

                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<OrderDetailDTO> GetOrderDetail(string orderID) //주문상세목록 조회
        {
            try
            {
                string sql = @"SELECT OD.Order_id, OrderDetail_id
	                            , C.name product_category                                
	                            , P.Product_name Product_name
                                , OD.Product_id
	                            , OD.product_Qty
	                            , P.Product_price product_price
	                            , (od.product_Qty * p.product_price) TotAmount
                                , CASE WHEN O.order_sendDate IS NOT NULL THEN '작업완료'
									   WHEN O.deleted = 'Y' THEN '주문취소'
		                               WHEN OD.producePlan_id IS NULL THEN '대기중'                                       
			                           ELSE '작업진행중' END AS Situation
                         FROM orderDetail OD INNER JOIN product P ON OD.product_id = P.product_id
	                                         INNER JOIN commoncode C ON P.product_category = C.code
	                                         INNER JOIN orders O ON OD.order_id = O.order_id
                         WHERE OD.order_id = @order_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@order_id", orderID);
                conn.Open();
                List<OrderDetailDTO> list = Helper.DataReaderMapToList<OrderDetailDTO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }

        }

        public List<CommonCodeDTO> GetCategory(string txt) //주문 카테고리
        {
            try
            {
                string sql = @"SELECT Code, Category, Name, Pcode
                            FROM commoncode
                            WHERE Category = @txt";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@txt", txt);
                conn.Open();
                List<CommonCodeDTO> list = Helper.DataReaderMapToList<CommonCodeDTO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }

        public List<ProductDTO> GetProductAllList() //제품목록 가져오기
        {
            try
            {
                string sql = @"SELECT product_id, C.name, product_name, product_Qty, product_QtyLimit, product_price
                             FROM product P INNER JOIN commoncode C ON P.product_category = C.code";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                List<ProductDTO> list = Helper.DataReaderMapToList<ProductDTO>(cmd.ExecuteReader());

                if (list == null)
                    throw new Exception("Helper가 NULL을 반환");
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }

        public List<MaterialDTO> GetMaterialAllList() //자재목록 가져오기
        {
            try
            {
                string sql = @"SELECT material_id, C.name, material_name, material_Qty
                             FROM Material M INNER JOIN commoncode C ON M.material_category = C.code";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                List<MaterialDTO> list = Helper.DataReaderMapToList<MaterialDTO>(cmd.ExecuteReader());

                if (list == null)
                {
                    throw new Exception("Helper가 NULL을 반환");
                }
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }

        public List<OrderDTO> UpdateOrder(string orderid) //주문수정폼 로드
        {
            try
            {
                string sql = @"SELECT O.Order_id, E.Emp_name
                                , OD.Product_id
		                        , SUM(OD.product_Qty * P.Product_price) TotAmount
		                        , C.Company_name
                                , CONVERT(VARCHAR(10), Order_date, 23) Order_date   
                                , CONVERT(VARCHAR(10), Order_dueDate, 23) Order_dueDate   
                        FROM orders O INNER JOIN orderDetail OD ON O.order_id = OD.order_id
				                        INNER JOIN product P ON OD.product_id = P.product_id
				                        INNER jOIN employee E ON O.emp_id = E.emp_id
				                        INNER JOIN company C ON O.company_id = C.company_id
                        WHERE O.order_id = @order_id
                        GROUP BY O.Order_id, E.emp_name, OD.Product_id, company_name, order_date, order_dueDate";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@order_id", orderid);
                conn.Open();

                Debug.WriteLine("A " + cmd.CommandText);
                List<OrderDTO> list = Helper.DataReaderMapToList<OrderDTO>(cmd.ExecuteReader());

                Debug.WriteLine("A " + cmd.CommandText);
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }

        public bool UpdateOrderDetail(string orderid, string txtEmpID, string dtpRequestDate, int empID, List<OrderDetailDTO> orderDetail) //주문수정 저장
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_OrderUpdate2", conn);
                cmd.CommandType = CommandType.StoredProcedure; //필수

                cmd.Parameters.AddWithValue("@order_id", orderid);
                cmd.Parameters.AddWithValue("@emp_name", txtEmpID);
                cmd.Parameters.AddWithValue("@order_dueDate", dtpRequestDate);
                cmd.Parameters.AddWithValue("@latest_writeEmp", empID);
                cmd.Transaction = trans;
                Debug.WriteLine("A " + cmd.CommandText);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                cmd.CommandText = @"INSERT INTO orderDetail(order_id, product_id, product_Qty)
				                                    VALUES (@order_id, @product_id, @product_Qty)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@order_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@Product_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@product_Qty", SqlDbType.Int));

                foreach (OrderDetailDTO item in orderDetail)
                {
                    cmd.Parameters["@Order_id"].Value = orderid;
                    cmd.Parameters["@Product_id"].Value = item.Product_id;
                    cmd.Parameters["@product_Qty"].Value = item.product_Qty;
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

        public bool AddOrder(OrderDTO order, List<OrderDetailDTO> orderDetail) //주문등록
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("dbo.SP_OrderSave", conn);
                cmd.CommandType = CommandType.StoredProcedure; //필수

                cmd.Parameters.AddWithValue("@Order_dueDate", order.Order_dueDate);    //요청일자
                cmd.Parameters.AddWithValue("@Company_name", order.Company_name);      //거래처명
                cmd.Parameters.AddWithValue("@Emp_name", order.Emp_name);             //담당자명
                cmd.Parameters.AddWithValue("@First_writeEmp", order.First_writeEmp); //등록자번호
                cmd.Transaction = trans;
                Debug.WriteLine("A " + cmd.CommandText);
                string ordersOut = cmd.ExecuteScalar().ToString();

                cmd.Parameters.Clear();
                cmd.CommandText = @"INSERT INTO orderDetail(order_id, product_id, product_Qty)
				                                    VALUES (@order_id, @product_id, @product_Qty)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@order_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@Product_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@product_Qty", SqlDbType.Int));

                foreach (OrderDetailDTO item in orderDetail)
                {
                    cmd.Parameters["@Order_id"].Value = ordersOut;
                    cmd.Parameters["@Product_id"].Value = item.Product_id;
                    cmd.Parameters["@product_Qty"].Value = item.product_Qty;
                    cmd.ExecuteNonQuery();
                }
                Debug.WriteLine("B " + cmd.CommandText);
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

        public bool DeleteOrder(string orderid) //주문삭제
        {
            conn.Open();
            try
            {
                string sql = @"UPDATE orders SET deleted = 'Y' WHERE order_id = @OrderID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderid);
                cmd.ExecuteNonQuery();
                Debug.WriteLine(cmd);
                return true;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public int Updatelimit(string orderid, int rowCnt) //주문수정 유효성
        {
            conn.Open();
            try
            {                //0보다 커야 수정삭제가능
                string sql = @"SELECT COUNT(*) AS Situation
                                FROM orderDetail OD INNER JOIN orders O ON OD.order_id = O.order_id
			                   WHERE OD.producePlan_id IS NULL
                                 AND O.order_sendDate IS NULL
					             AND O.deleted = 'N'
					             AND OD.order_id = @Order_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Order_id", orderid);

                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                Debug.WriteLine(cnt);
                return cnt;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //------------------------------------ 발주 ------------------------------------
        public List<PurchaseDTO> GetPurchaseSearch(PurchaseDTO order, string fromODt, string toODt, string fromOdDt, string toOdDt) //발주목록 조회
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                //sb.Append("SP_OrderList");
                sb.Append(@"SELECT purchase_id, C.company_name
                        , CONVERT(VARCHAR(10), purchase_date, 23) Purchase_date
                        , CONVERT(VARCHAR(10), purchase_dueDate, 23) Purchase_dueDate
                        , purchase_state
                        , CONVERT(VARCHAR(10), purchase_endDate, 23) Purchase_endDate
                        , E.emp_name
                        , P.first_writeEmp
                        , CONVERT(VARCHAR(10), P.first_writeDate, 23) First_writeDate
                        , P.latest_writeEmp
                        , CONVERT(VARCHAR(10), P.latest_writeDate, 23) Latest_writeDate
                                FROM purchase P INNER JOIN company C ON P.company_id = C.company_id
				                                INNER JOIN employee E ON P.emp_id = E.emp_id
                                WHERE C.business_category = 'c01'
                                    AND purchase_date >= @fromODt AND purchase_date < @toODt
                                    AND purchase_dueDate >= @fromOdDt AND purchase_dueDate < @toOdDt");

                cmd.Parameters.AddWithValue("@fromODt", fromODt);
                cmd.Parameters.AddWithValue("@toODt", toODt);
                cmd.Parameters.AddWithValue("@fromOdDt", fromOdDt);
                cmd.Parameters.AddWithValue("@toOdDt", toOdDt);

                if (!string.IsNullOrWhiteSpace(order.Company_name))
                {
                    sb.Append(" AND C.company_name LIKE @company_name");
                    cmd.Parameters.AddWithValue("@company_name", "%" + order.Company_name + "%");
                }
                if (!string.IsNullOrWhiteSpace(order.Emp_name))
                {
                    sb.Append(" AND E.Emp_name LIKE @Emp_name");
                    cmd.Parameters.AddWithValue("@Emp_name", "%" + order.Emp_name + "%");
                }
                if (!string.IsNullOrWhiteSpace(order.Purchase_id))
                {
                    sb.Append(" AND P.purchase_id LIKE @purchase_id");
                    cmd.Parameters.AddWithValue("@purchase_id", "%" + order.Purchase_id + "%");
                }
                if (!string.IsNullOrWhiteSpace(order.purchase_state))
                {
                    if (!order.purchase_state.Equals("전체"))
                    {
                        sb.Append(" AND purchase_state = @purchase_state");
                        cmd.Parameters.AddWithValue("@purchase_state", order.purchase_state);
                    }
                }

                sb.Append(" ORDER BY purchase_id");

                cmd.Connection = conn;
                cmd.CommandText = sb.ToString();

                conn.Open();
                Debug.WriteLine("A " + cmd.CommandText);

                List<PurchaseDTO> list = Helper.DataReaderMapToList<PurchaseDTO>(cmd.ExecuteReader());

                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<OrderDetailDTO> GetPurchaseDetail(string purchaseid) //발주상세목록 조회
        {
            try
            {
                string sql = @"SELECT purchase_id Order_id
                                , M.material_id Product_id
                                , C.name Product_category
	                            , purchaseDetail_id OrderDetail_id
	                            , M.material_name Product_name
	                            , purchaseDetail_Qty Product_Qty
                            FROM purchaseDetail PD INNER JOIN material M ON PD.material_id = M.material_id
						                           INNER JOIN commoncode C ON M.material_category = C.code
                            WHERE purchase_id = @purchase_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@purchase_id", purchaseid);
                conn.Open();
                List<OrderDetailDTO> list = Helper.DataReaderMapToList<OrderDetailDTO>(cmd.ExecuteReader());
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }

        public bool Addpurchase(PurchaseDTO order, List<OrderDetailDTO> orderDetail) //발주등록
        {
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PurchaseSave", conn);
                cmd.CommandType = CommandType.StoredProcedure; //필수

                cmd.Parameters.AddWithValue("@Purchase_dueDate", order.Purchase_dueDate);  //요청일자
                cmd.Parameters.AddWithValue("@Company_name", order.Company_name);       //거래처명
                cmd.Parameters.AddWithValue("@Emp_name", order.Emp_name);               //담당자명
                cmd.Parameters.AddWithValue("@First_writeEmp", order.First_writeEmp);   //등록자번호
                cmd.Transaction = trans;
                Debug.WriteLine("A " + cmd.CommandText);
                string ordersOut = cmd.ExecuteScalar().ToString();

                cmd.Parameters.Clear();

                cmd.CommandText = @"INSERT INTO purchaseDetail(purchase_id, material_id, purchaseDetail_Qty)
				                                    VALUES (@purchase_id, @material_id, @purchaseDetail_Qty)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@purchase_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@material_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@purchaseDetail_Qty", SqlDbType.Int));

                foreach (OrderDetailDTO item in orderDetail)
                {
                    cmd.Parameters["@purchase_id"].Value = ordersOut;
                    cmd.Parameters["@material_id"].Value = item.Product_id;
                    cmd.Parameters["@purchaseDetail_Qty"].Value = item.product_Qty;

                    Debug.WriteLine("B " + cmd.CommandText);
                    cmd.ExecuteNonQuery();
                }
                Debug.WriteLine("C " + cmd.CommandText);

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

        public List<PurchaseDTO> Updatepurchase(string purchaseid) //발주수정폼 로드
        {
            try
            {
                string sql = @"SELECT P.purchase_id, E.emp_name
		                            , C.company_name
		                            , CONVERT(VARCHAR(10), purchase_date, 23) purchase_date   
                                    , CONVERT(VARCHAR(10), purchase_dueDate, 23) purchase_dueDate 
                            FROM purchase P INNER JOIN purchaseDetail PD ON P.purchase_id = PD.purchase_id
				                            INNER JOIN material M ON PD.material_id = M.material_id
				                            INNER JOIN employee E ON P.emp_id = E.emp_id
				                            INNER JOIN company C ON P.company_id = C.company_id
                            WHERE P.purchase_id = @purchase_id
                            GROUP BY P.purchase_id, E.emp_name, company_name, P.purchase_date, P.purchase_dueDate";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@purchase_id", purchaseid);
                conn.Open();

                Debug.WriteLine("A " + cmd.CommandText);
                List<PurchaseDTO> list = Helper.DataReaderMapToList<PurchaseDTO>(cmd.ExecuteReader());

                Debug.WriteLine("A " + cmd.CommandText);
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }

        public bool UpdatePurchaseDetail(string purchaseid, string txtEmpID, string dtpRequestDate, int empID, List<OrderDetailDTO> orderDetail) //발주수정 저장
        {//string orderid, int empID, List<OrderDetailDTO> orderDetail
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_PurchaseUpdate", conn);
                cmd.CommandType = CommandType.StoredProcedure; //필수

                cmd.Parameters.AddWithValue("@purchase_id", purchaseid);
                cmd.Parameters.AddWithValue("@emp_name", txtEmpID);
                cmd.Parameters.AddWithValue("@purchase_dueDate", dtpRequestDate);
                cmd.Parameters.AddWithValue("@latest_writeEmp", empID);
                cmd.Transaction = trans;
                Debug.WriteLine("A " + cmd.CommandText);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = @"INSERT INTO purchaseDetail(purchase_id, material_id, purchaseDetail_Qty)
				                                    VALUES (@purchase_id, @material_id, @purchaseDetail_Qty)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@purchase_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@material_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@purchaseDetail_Qty", SqlDbType.Int));

                foreach (OrderDetailDTO item in orderDetail)
                {
                    cmd.Parameters["@purchase_id"].Value = purchaseid;
                    cmd.Parameters["@material_id"].Value = item.Product_id;
                    cmd.Parameters["@purchaseDetail_Qty"].Value = item.product_Qty;
                    cmd.ExecuteNonQuery();
                }
                Debug.WriteLine(cmd.CommandText);
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

        public bool DeletePurchase(string purchaseid) //발주삭제
        {
            conn.Open();
            try
            {
                string sql = @"UPDATE purchase SET deleted = 'Y', purchase_state = '발주취소' WHERE purchase_id = @purchase_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@purchase_id", purchaseid);
                cmd.ExecuteNonQuery();
                Debug.WriteLine(cmd);
                return true;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool Warehousing(string purchaseid, int empID, List<OrderDetailDTO> orderDetail) //발주 입고처리
        {
            //1. 입고처리        => 발주테이블 UPDATE SET 발주일자 WHERE purchaseid = @purchaseid
            //2. 자재재고 플러스 => 자재테이블 UPDATE SET WHERE (material_Qty + @material_Qty) WHERE material_id = @material_id (자재ID)  ==> 반복문
            conn.Open();
            SqlTransaction trans = conn.BeginTransaction();
            try
            {
                string sql = @"UPDATE purchase
                                  SET purchase_endDate = GETDATE(), purchase_state = '입고완료', latest_writeEmp = @latest_writeEmp, latest_writeDate = GETDATE()
                                WHERE purchase_id = @purchaseid";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@purchaseid", purchaseid);
                cmd.Parameters.AddWithValue("@latest_writeEmp", empID);
                cmd.Transaction = trans;
                cmd.ExecuteScalar();

                Debug.WriteLine(cmd.CommandText);
                cmd.Parameters.Clear();
                cmd.CommandText = @"UPDATE material SET material_Qty = material_Qty + @material_Qty WHERE material_id = @material_id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@material_id", SqlDbType.NVarChar));
                cmd.Parameters.Add(new SqlParameter("@material_Qty", SqlDbType.Int));

                foreach (OrderDetailDTO item in orderDetail)
                {
                    cmd.Parameters["@material_id"].Value = item.Product_id;
                    cmd.Parameters["@material_Qty"].Value = item.product_Qty;
                    cmd.ExecuteNonQuery();
                }
                Debug.WriteLine(cmd.CommandText);
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

        #region [Temp] GetPurchaseDetail
        //public List<OrderDetailDTO> GetPurchaseDetail(string purchaseid) //주문상세목록 조회
        //{
        //    string sql = @"SELECT purchase_id, purchaseDetail_id
        //                  , C.name material_category
        //                  , M.material_name Product_name		
        //                    FROM purchaseDetail PD INNER JOIN material M ON PD.material_id = M.material_id
        //                          INNER JOIN commoncode C ON M.material_category = C.code
        // WHERE purchase_id = @purchase_id";

        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    cmd.Parameters.AddWithValue("@purchase_id", purchaseid);
        //    conn.Open();
        //    List<OrderDetailDTO> list = Helper.DataReaderMapToList<OrderDetailDTO>(cmd.ExecuteReader());
        //    conn.Close();
        //    return list;
        //}
        #endregion
    }
}
