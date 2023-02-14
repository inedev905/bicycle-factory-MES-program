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
    public class CompanyDAO : IDisposable
    {
        SqlConnection conn;
        public CompanyDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<OrderDTO> GetProductCompanyInfo(int cmpID) //거래처 거래이력 (완제품 출고 Select)
        {

            string sql = @"select A.order_id Order_id,
                        	   CONVERT(VARCHAR(10), order_date, 23) Order_date, 
                        	   CONVERT(VARCHAR(10), order_sendDate, 23) Order_sendDate,
                        	   CASE WHEN order_sendDate IS NULL THEN '주문완료'                      
                               ELSE '출하완료' END AS States,
                        	   SUM(B.product_Qty * C.Product_price) TotAmount,
                        	   E.emp_id emp_id , E.emp_name emp_name
                        FROM orders A INNER JOIN orderDetail B  ON A.order_id = B.order_id            
                                      INNER JOIN product C  ON B.product_id = C.product_id                     
                                      INNER JOIN company D  ON A.company_id = D.company_id 
									  INNER JOIN employee E ON A.emp_id = E.emp_id
                        WHERE D.company_id = @company_id
                        GROUP BY A.order_id, order_date, order_sendDate, E.emp_id , E.emp_name
                        ORDER BY order_id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@company_id", cmpID);

            conn.Open();
            List<OrderDTO> list = Helper.DataReaderMapToList<OrderDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;          
        }

        public List<PurchaseDTO> GetMaterialCompanyInfo(int cmpID)
        {
            string sql = @"SELECT P.purchase_id
                           		   , CONVERT(VARCHAR(10), purchase_date, 23) purchase_date   
                                   , CONVERT(VARCHAR(10), purchase_endDate, 23) purchase_endDate  
                           		   ,purchase_state, PD.purchaseDetail_Qty product_Qty , E.emp_name
                           FROM purchase P INNER JOIN purchaseDetail PD ON P.purchase_id = PD.purchase_id
                               INNER JOIN material M ON PD.material_id = M.material_id
                               INNER JOIN employee E ON P.emp_id = E.emp_id
                               INNER JOIN company C ON P.company_id = C.company_id
                           WHERE C.company_id = @company_id
                           GROUP BY P.purchase_id, E.emp_name, company_name, P.purchase_date, P.purchase_endDate, P.purchase_state, PD.purchaseDetail_Qty";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@company_id", cmpID);

            conn.Open();
            List<PurchaseDTO> list = Helper.DataReaderMapToList<PurchaseDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }


        public List<CompanyDTO> GetSearchCompany() //거래처 검색 팝업 
        {
            string sql = @"select company_id,CM.name business_category_NM, company_name ,phone,  business_category
                            from company C inner join commoncode CM on C.business_category = CM.code
                            where company_deleted = 'N'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<CompanyDTO> list = Helper.DataReaderMapToList<CompanyDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }
        //public 
        public List<CompanyDTO> GetAllCompany() //거래처 메인 데이터 조회 Select 
        {
            string sql = @"select company_id, business_num, D.name business_category_NM, company_name, P.name region_code_NM, phone , zipCode ,address1, address2,company_deleted,
                           		contact_name, M.name contact_position_NM, O.name contact_phone1_NM, contact_phone2, contact_email,business_category, region_code, contact_position, contact_phone1,
                           		C.first_writeEmp,convert(varchar(20),C.first_writeDate, 23) first_writeDate,  
                                   C.latest_writeEmp, convert(varchar(20),C.latest_writeDate, 23) latest_writeDate
                           from company C inner join commoncode P on C.region_code = P.code 
                           				  inner join commoncode M on C.contact_position = M.code
                           				  inner join commoncode O on C.contact_phone1 = O.code
										  inner join commoncode D on C.business_category = D.code
						   where company_deleted = 'N'
                           Order by business_category desc";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<CompanyDTO> list = Helper.DataReaderMapToList<CompanyDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public bool InsertCompany(CompanyDTO cmp, EmployeeDTO emp)
        {
            SqlCommand cmd = new SqlCommand("SP_InsertCompany", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@business_num", cmp.Business_num);
            cmd.Parameters.AddWithValue("@business_category", cmp.Business_category);
            cmd.Parameters.AddWithValue("@company_name", cmp.Company_name);
            cmd.Parameters.AddWithValue("@phone", cmp.Phone);
            cmd.Parameters.AddWithValue("@region_code", cmp.Region_code);
            cmd.Parameters.AddWithValue("@zipCode", cmp.ZipCode);
            cmd.Parameters.AddWithValue("@address1", cmp.Address1);
            cmd.Parameters.AddWithValue("@address2", cmp.Address2);
            cmd.Parameters.AddWithValue("@contact_name", cmp.Contact_name);
            cmd.Parameters.AddWithValue("@contact_position", cmp.Contact_position);
            cmd.Parameters.AddWithValue("@contact_phone1", cmp.Contact_phone1);
            cmd.Parameters.AddWithValue("@contact_phone2", cmp.Contact_phone2);
            cmd.Parameters.AddWithValue("@contact_email", cmp.Contact_email);
            cmd.Parameters.AddWithValue("@First_writeEmp", emp.emp_id);
            cmd.Parameters.AddWithValue("@Latest_writeEmp", emp.emp_id);

            cmd.Parameters.Add(new SqlParameter("@company_id", SqlDbType.Int));
            cmd.Parameters["@company_id"].Direction = ParameterDirection.Output;

            conn.Open();
            int iRowAffect = cmd.ExecuteNonQuery();

            int newCmpID = Convert.ToInt32(cmd.Parameters["@company_id"].Value);
            conn.Close();

            return (iRowAffect > 0);

        }
        public bool InsertCompanyInfo(CompanyDTO cmp, EmployeeDTO emp) //거래처 신규 등록 Insert 쿼리문 
        {
            string sql = @"insert into company (business_num, business_category, company_name, phone, region_code,  zipCode, address1, address2, 
                                                contact_name, contact_position, contact_phone1, contact_phone2,　contact_email, First_writeEmp, Latest_writeEmp)
                            values (@business_num, @business_category, @company_name, @phone, @region_code,  @zipCode, @address1, @address2, 
                                    @contact_name , @contact_position, @contact_phone1, @contact_phone2, @contact_email, @First_writeEmp, @Latest_writeEmp)";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@business_num", cmp.Business_num);
                cmd.Parameters.AddWithValue("@business_category", cmp.Business_category);
                cmd.Parameters.AddWithValue("@company_name", cmp.Company_name);
                cmd.Parameters.AddWithValue("@phone", cmp.Phone);
                cmd.Parameters.AddWithValue("@region_code", cmp.Region_code);
                cmd.Parameters.AddWithValue("@zipCode", cmp.ZipCode);
                cmd.Parameters.AddWithValue("@address1", cmp.Address1);
                cmd.Parameters.AddWithValue("@address2", cmp.Address2);
                cmd.Parameters.AddWithValue("@contact_name", cmp.Contact_name);
                cmd.Parameters.AddWithValue("@contact_position", cmp.Contact_position);
                cmd.Parameters.AddWithValue("@contact_phone1", cmp.Contact_phone1);
                cmd.Parameters.AddWithValue("@contact_phone2", cmp.Contact_phone2);
                cmd.Parameters.AddWithValue("@contact_email", cmp.Contact_email);
                cmd.Parameters.AddWithValue("@First_writeEmp", emp.emp_id);
                cmd.Parameters.AddWithValue("@Latest_writeEmp", emp.emp_id);               

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch(Exception err)
            {
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }   

        public bool UpdateCompanyInfo(CompanyDTO cmp, EmployeeDTO emp)  //거래처 정보수정 Update 쿼리문 (deleted는 제외) 
        {
            string sql = @"update company
                           set business_num = @business_num, business_category= @business_category, company_name= @company_name ,region_code = @region_code, phone= @phone, 
                           	zipCode= @zipCode, address1= @address1, address2= @address2, contact_name = @contact_name, contact_position = @contact_position,
                           	contact_phone1 = @contact_phone1, contact_phone2= @contact_phone2, contact_email= @contact_email, 
                            latest_writeEmp = @latest_writeEmp, latest_writeDate = getdate()
                           where company_id = @company_id";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@business_num", cmp.Business_num);
                cmd.Parameters.AddWithValue("@business_category", cmp.Business_category);
                cmd.Parameters.AddWithValue("@company_name", cmp.Company_name);
                cmd.Parameters.AddWithValue("@region_code", cmp.Region_code);
                cmd.Parameters.AddWithValue("@phone", cmp.Phone);
                cmd.Parameters.AddWithValue("@zipCode", cmp.ZipCode);
                cmd.Parameters.AddWithValue("@address1", cmp.Address1);
                cmd.Parameters.AddWithValue("@address2", cmp.Address2);
                cmd.Parameters.AddWithValue("@contact_name", cmp.Contact_name);
                cmd.Parameters.AddWithValue("@contact_position", cmp.Contact_position);
                cmd.Parameters.AddWithValue("@contact_phone1", cmp.Contact_phone1);
                cmd.Parameters.AddWithValue("@contact_phone2", cmp.Contact_phone2);
                cmd.Parameters.AddWithValue("@contact_email", cmp.Contact_email);
                cmd.Parameters.AddWithValue("@latest_writeEmp", emp.emp_id);
                cmd.Parameters.AddWithValue("@company_id", cmp.Company_id);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                conn.Close();

                return (iRowAffect > 0);
            }
            catch(Exception err) 
            {
                string msg = err.Message;
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool DeleteCompanyInfo(int cmpID)    //거래처 정보 삭제 update 쿼리문 (삭제버튼 클릭시) 
        {
            string sql = @"update company 
                            set company_deleted = @company_deleted
                            where company_id = @company_id";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@company_deleted", 'Y');
                cmd.Parameters.AddWithValue("@company_id", cmpID);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                conn.Close();

                return (iRowAffect > 0);
            }
            catch 
            {
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
