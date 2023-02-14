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
    public class MaterialDAO : IDisposable
    {
        SqlConnection conn;

        public MaterialDAO()
        {
            string connstr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(connstr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<MaterialDTO> GetAllMaterial()
        {
            string sql = @"select material_id, material_name, material_Qty, material_safety, 
                       		      material_Min_per, B.name material_category_NM, material_category,
                       		      A.first_writeEmp, convert(nvarchar(10),A.first_writeDate, 23) first_writeDate,
                       		      A.latest_writeEmp, convert(nvarchar(10),A.latest_writeDate, 23) latest_writeDate
                           from material A inner join commoncode B on A.material_category = B.code 
                           order by material_id";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<MaterialDTO> list = Helper.DataReaderMapToList<MaterialDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;        
        }  //모든 자재 정보 Select 

        public List<CompanyDTO> GetInputCompany()
        {
            string sql = @"select company_id,business_num, company_name, phone ,B.name region_code_NM,concat(address1,' ' ,address2) addr,region_code,company_deleted
                           from company A INNER JOIN commoncode B ON A.region_code = B.code
                           where business_category = 'c01'  and company_deleted = 'N'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<CompanyDTO> list = Helper.DataReaderMapToList<CompanyDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }       // 매입처 거래처 select 

        public List<TradeCompanyDTO> GetTradeCompanyInfo(string trMtr)  //자재별 계약 거래처 select
        {
            string sql = @"select tradeCompany_id, B.material_id, A.company_id , main, A.first_writeEmp, A.latest_writeEmp,
		                          convert(nvarchar(10),A.first_writeDate,23) first_writeDate , 
                                  convert(nvarchar(10),A.latest_writeDate,23) latest_writeDate,
                            	  B.material_name, C.company_name, C.contact_name, c.contact_phone2,C.contact_email, D.name material_category_NM, material_category
                            from tradeCompany A inner join material B on A.material_id = B.material_id
                            					inner join company C on A.company_id = C.company_id 
                            					inner join commoncode D on B.material_category = D.code
                            where B.material_id = @material_id and C.company_deleted = 'N'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@material_id", trMtr);

            conn.Open();
            List<TradeCompanyDTO> list = Helper.DataReaderMapToList<TradeCompanyDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public MaterialDTO GetMaterialInfo(string mtrID)
        {
            string sql = @"select material_id, material_name, material_Qty, material_safety, material_Min_per, 
                           	      B.name material_category_NM, material_category,material_Img,material_Notes
                           from material A inner join commoncode B on A.material_category = B.code 
                           where material_id = @material_id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@material_id", mtrID);

            conn.Open();
            MaterialDTO dto = Helper.DataReaderMapToDTO<MaterialDTO>(cmd.ExecuteReader());
            conn.Close();

            return dto;
        }   //자재 정보 수정시 수정 페이지에 해당 값 select 

        public bool InsertMaterialInfo(MaterialDTO mtr, EmployeeDTO emp)
        {
            string sql = @"insert into material (material_id, material_name, material_Qty, material_safety, material_category, 
                                                     material_Img, material_Min_per, material_Notes, first_writeEmp, latest_writeEmp)
                                values (@material_id ,@material_name, @material_Qty, @material_safety, @material_category, 
                                        @material_Img, @material_Min_per, @material_Notes, @first_writeEmp, @latest_writeEmp)";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@material_id", mtr.Material_id);
                cmd.Parameters.AddWithValue("@material_name", mtr.Material_name);
                cmd.Parameters.AddWithValue("@material_Qty", mtr.Material_Qty);
                cmd.Parameters.AddWithValue("@material_safety", mtr.Material_safety);
                cmd.Parameters.AddWithValue("@material_category", mtr.Material_category);
                cmd.Parameters.AddWithValue("@material_Img", mtr.Material_Img);
                cmd.Parameters.AddWithValue("@material_Min_per", mtr.Material_Min_per);
                cmd.Parameters.AddWithValue("@material_Notes", mtr.Material_Notes);
                cmd.Parameters.AddWithValue("@first_writeEmp", emp.emp_id);
                cmd.Parameters.AddWithValue("@latest_writeEmp", emp.emp_id);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch (Exception err)
            {
                string msg = err.Message;
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }  //자재 등록

        public bool UpdateMaterialInfo(MaterialDTO mtr, EmployeeDTO emp)
        {
            string sql = @"update material 
                           set material_name = @material_name, material_Qty = @material_Qty, material_safety = @material_safety, material_category = @material_category, 
                           	material_Img = @material_Img, material_Min_per = @material_Min_per, material_Notes = @material_Notes, latest_writeEmp = @latest_writeEmp, latest_writeDate=getdate()
                           where material_id = @material_id";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@material_name", mtr.Material_name);
                cmd.Parameters.AddWithValue("@material_Qty", mtr.Material_Qty);
                cmd.Parameters.AddWithValue("@material_safety", mtr.Material_safety);
                cmd.Parameters.AddWithValue("@material_category", mtr.Material_category);
                cmd.Parameters.AddWithValue("@material_Img", mtr.Material_Img);
                cmd.Parameters.AddWithValue("@material_Min_per", mtr.Material_Min_per);
                cmd.Parameters.AddWithValue("@material_Notes", mtr.Material_Notes);
                cmd.Parameters.AddWithValue("@latest_writeEmp", emp.emp_id);
                cmd.Parameters.AddWithValue("@material_id", mtr.Material_id);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                return (iRowAffect > 0);
            }
            catch (Exception err)
            {
                string msg = err.Message;
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }  //자재 수정

        public bool DeleteMaterialInfo(string mtrID)
        {
            string sql = @"delete from material where material_id = @material_id";
            try
            {              
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@material_id", mtrID);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                conn.Close();


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
        }   //자재 삭제

        public bool DeleteTradeCompanyInfo(int trdID)    //계약된 거래처 삭제
        {
            string sql = @"delete from tradeCompany where tradeCompany_id = @tradeCompany_id";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tradeCompany_id", trdID);

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

        public bool InsertTradeCompany(string mtrId, int cmpId, EmployeeDTO emp)    //계약 거래처 1개씩 등록 insert
        {
            string sql = @"insert into tradeCompany (material_id,company_id, first_writeEmp, latest_writeEmp) 
	                       values(@material_id, @company_id, @first_writeEmp, @latest_writeEmp)";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@material_id", mtrId);
                cmd.Parameters.AddWithValue("@company_id", cmpId);
                cmd.Parameters.AddWithValue("@first_writeEmp", emp.emp_id);
                cmd.Parameters.AddWithValue("@latest_writeEmp", emp.emp_id);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
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

        public bool UpdateTrdNoMain(int trdMain)
        {
            string sql = @"update tradeCompany
                           set main = @main
                           where tradeCompany_id = @tradeCompany_id";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@main", 'N');
                cmd.Parameters.AddWithValue("@tradeCompany_id", trdMain);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                conn.Close();

                return (iRowAffect > 0);
            }
            catch (Exception err)
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
        public bool UpdateTrdMain(int trdMain, string mtrName)
        {
            string sql = @"update tradeCompany set main='N' where material_id = @material_id;  
                           update tradeCompany set main = 'Y' where tradeCompany_id = @tradeCompany_id";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@material_id", mtrName);
                cmd.Parameters.AddWithValue("@tradeCompany_id", trdMain);

                conn.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                conn.Close();

                return (iRowAffect > 0);
            }
            catch (Exception err)
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
    }
}
