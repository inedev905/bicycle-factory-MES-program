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
    public class EmployeeDAO :IDisposable
    {
        
        string conStr = null;
        SqlConnection conn;

        public EmployeeDAO()
        {
            conStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            conn = new SqlConnection(conStr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public List<EmployeeDTO> SetEmployeeData()
        {
            List<EmployeeDTO> empList = new List<EmployeeDTO>();

            SqlCommand cmd = new SqlCommand("SP_EmployeeList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                EmployeeDTO emp = new EmployeeDTO
                {
                    emp_id = Convert.ToInt32(reader["emp_id"]),
                    emp_barCode = reader["emp_barCode"].ToString(),
                    emp_name = reader["emp_name"].ToString(),
                    dep_code = reader["dep_code"].ToString(),
                    dep_name = reader["dep_name"].ToString(),
                    title_code = reader["title_code"].ToString(),
                    title_name = reader["title_name"].ToString(),
                    gender = reader["gender"].ToString().ToUpper(),
                    phone1_code = reader["phone1"].ToString(),
                    phone1_name = reader["phone1_name"].ToString(),
                    phone2 = reader["phone2"].ToString(),
                    email = reader["email"].ToString(),
                    region_code = reader["region_code"].ToString(),
                    region_name = reader["region_name"].ToString(),
                    zipCode = reader["zipCode"].ToString(),
                    address1 = reader["address1"].ToString(),
                    address2 = reader["address2"].ToString(),
                    emp_deleted = reader["emp_deleted"].ToString()
                };
                empList.Add(emp) ;
            }
            conn.Close();
            return empList;
        }

        public bool UpdateInfo(EmployeeDTO updateEmp)
        {
            string sql = @"update employee set dep_code = @dep_code, title_code = @title_code, gender = @gender, 
                                    phone1 = @phone1, phone2 = @phone2, email = @email, region_code = @region_code, 
                                    zipCode = @zipCode, address1 = @address1, address2 = @address2
	                        where emp_id = @emp_id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dep_code", updateEmp.dep_code);
            cmd.Parameters.AddWithValue("@title_code", updateEmp.title_code);
            cmd.Parameters.AddWithValue("@gender", updateEmp.gender);
            cmd.Parameters.AddWithValue("@phone1", updateEmp.phone1_code);
            cmd.Parameters.AddWithValue("@phone2", updateEmp.phone2);
            cmd.Parameters.AddWithValue("@email", updateEmp.email);
            cmd.Parameters.AddWithValue("@region_code", updateEmp.region_code);
            cmd.Parameters.AddWithValue("@zipCode", updateEmp.zipCode);
            cmd.Parameters.AddWithValue("@address1", updateEmp.address1);
            cmd.Parameters.AddWithValue("@address2", updateEmp.address2);
            cmd.Parameters.AddWithValue("@emp_id", updateEmp.emp_id);

            conn.Open();
            int isresult = cmd.ExecuteNonQuery();

            return (isresult > 0);

        }

        public EmployeeDTO GetLoginEmpInfo(string empBarcode)
        {
            string sql = @"select emp_id, emp_barCode, emp_name, dep_code, (select name from commoncode where e.dep_code = code) dep_name, 
		                            title_code, (select name from commoncode where e.title_code = code) title_name,
                                    gender, phone1, phone2, email, region_code, (select name from commoncode where e.region_code = code) region_name, 
		                            zipCode, address1, address2
                            from employee e
                            where e.emp_barCode = @emp_barCode and e.emp_deleted = 'N'";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@emp_barCode", empBarcode);
            conn.Open();
            EmployeeDTO empInfo = Helper.DataReaderMapToDTO<EmployeeDTO>(cmd.ExecuteReader());
            conn.Close();

            return empInfo;
        }

        public List<EmployeeDTO> SearchEmpList()    //직원 검색 팝업 (baseform)
        {
            string sql = @"select emp_id, emp_name, B.name dep_name ,dep_code, C.name title_name ,title_code, phone2, email
                            from employee A inner join commoncode B ON A.dep_code = B.code
                            				inner join commoncode C ON A.title_code = C.code
                            where emp_deleted = 'N'";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            List<EmployeeDTO> list = Helper.DataReaderMapToList<EmployeeDTO>(cmd.ExecuteReader());
            conn.Close();

            return list;
        }

        public List<CommonCodeDTO> SetEmpCommonDB()
        {
            List<CommonCodeDTO> commonCodeDTOs = new List<CommonCodeDTO>();
            conn.Open();
            string sql = @"select code, category, name, pcode from commoncode
                            where category in ('RANK', 'ADDR', 'TELE', 'DEPT')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@category", categories);
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CommonCodeDTO dto = new CommonCodeDTO
                {
                    Code = reader["code"].ToString(),
                    Category = reader["category"].ToString(),
                    Name = reader["name"].ToString(),
                    Pcode = reader["pcode"].ToString()
                };

                commonCodeDTOs.Add(dto);
            }
            conn.Close();
            return commonCodeDTOs;
        }

        public string SetNewEmp(EmployeeDTO newEmp,int loginedEmployee)
        {
            string newBarcode = null;
            SqlCommand cmd = new SqlCommand("SP_InsertEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empName", newEmp.emp_name);
            cmd.Parameters.AddWithValue("@empDep", newEmp.dep_code);
            cmd.Parameters.AddWithValue("@empRank", newEmp.title_code);
            //cmd.Parameters.AddWithValue("",); 이미지
            cmd.Parameters.AddWithValue("@gender", newEmp.gender);
            cmd.Parameters.AddWithValue("@phonCode", newEmp.phone1_code);
            cmd.Parameters.AddWithValue("@phonNum", newEmp.phone2);
            cmd.Parameters.AddWithValue("@email", newEmp.email);
            cmd.Parameters.AddWithValue("@addrCode", newEmp.region_code);
            cmd.Parameters.AddWithValue("@addrNum", newEmp.zipCode);
            cmd.Parameters.AddWithValue("@addr1", newEmp.address1);
            cmd.Parameters.AddWithValue("@addr2", newEmp.address2);
            cmd.Parameters.AddWithValue("@change_empID",loginedEmployee);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                newBarcode = reader[0].ToString();
            }
            return newBarcode;
        }
        public bool DelEmp(int empID)
        {
            string sql = @"update employee set emp_deleted = @emp_deleted
	                        where emp_id = @emp_id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@emp_deleted", "Y");
            cmd.Parameters.AddWithValue("@emp_id", empID);
            
            conn.Open();
            int isresult = cmd.ExecuteNonQuery();

            return (isresult > 0);
        }

    }
}
