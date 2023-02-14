using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DAO;
using Team2DTO;

namespace Team2
{
    public class EmployeeService
    {
        public List<CommonCodeDTO> SetEmpCommonData()
        {
            EmployeeDAO db = new EmployeeDAO();
            List<CommonCodeDTO> commonCodeDTO = db.SetEmpCommonDB();
            db.Dispose();

            return commonCodeDTO;
        }

        // 로그인
        public EmployeeDTO GetLoginEmpInfo(string empBarcode)
        {
            EmployeeDAO db = new EmployeeDAO();
            EmployeeDTO empInfo = db.GetLoginEmpInfo(empBarcode);
            db.Dispose();

            return empInfo;
        }

        public List<EmployeeDTO> SearchEmpList()
        {
            EmployeeDAO db = new EmployeeDAO();
            List<EmployeeDTO> list = db.SearchEmpList();
            db.Dispose();

            return list;
        }

        public List<EmployeeDTO> LoadEmpData()
        {
            EmployeeDAO db = new EmployeeDAO();
            List<EmployeeDTO> empList = db.SetEmployeeData();
            db.Dispose();

            return empList;
        }

        public bool UpdateInfo(EmployeeDTO updateEmp)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.UpdateInfo(updateEmp);
            db.Dispose();

            return result;
        }

        public string SetNewEmp(EmployeeDTO newEmp, int loginedEmployee)
        {
            EmployeeDAO db = new EmployeeDAO();
            string result = db.SetNewEmp(newEmp, loginedEmployee);
            db.Dispose();

            return result;
        }
        
        public bool DelEmp(int empID)
        {
            EmployeeDAO db = new EmployeeDAO();
            bool result = db.DelEmp(empID);
            db.Dispose();

            return result;
        }

    }
}
