using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DTO;
using Team2DAO;

namespace Team2.Services
{
    class CompanyService
    {
        public List<OrderDTO> GetProductCompanyInfo(int cmpID)
        {
            CompanyDAO db = new CompanyDAO();
            List<OrderDTO> list = db.GetProductCompanyInfo(cmpID);
            db.Dispose();

            return list;
        }
        public List<PurchaseDTO> GetMaterialCompanyInfo(int cmpID)
        {
            CompanyDAO db = new CompanyDAO();
            List<PurchaseDTO> list = db.GetMaterialCompanyInfo(cmpID);
            db.Dispose();

            return list;
        }
        public List<CompanyDTO> GetSearchCompany()
        {
            CompanyDAO db = new CompanyDAO();
            List<CompanyDTO> list = db.GetSearchCompany();
            db.Dispose();

            return list;
        }

        public List<CompanyDTO> GetAllCompany()
        {
            CompanyDAO db = new CompanyDAO();
            List<CompanyDTO> list = db.GetAllCompany();
            db.Dispose();

            return list;
        }
        public bool InsertCompanyInfo(CompanyDTO cmp, EmployeeDTO emp)
        {
            CompanyDAO db = new CompanyDAO();
            bool result = db.InsertCompanyInfo(cmp, emp);
            db.Dispose();

            return result;
        }

        public bool InsertCompany(CompanyDTO cmp, EmployeeDTO emp)
        {
            CompanyDAO db = new CompanyDAO();
            bool result = db.InsertCompany(cmp, emp);
            db.Dispose();

            return result;
        }
        public List<CommonCodeDTO> GetCommonCode(string[] category)
        {
            CommonCodeDAO db = new CommonCodeDAO();
            List<CommonCodeDTO> list = db.GetCommonCategory(category);
            db.Dispose();

            return list;
        }

        public bool UpdateCompanyInfo(CompanyDTO cmp, EmployeeDTO emp)
        {
            CompanyDAO db = new CompanyDAO();
            bool result = db.UpdateCompanyInfo(cmp, emp);
            db.Dispose();

            return result;
        }

        public bool DeleteCompanyInfo(int cmpID)
        {
            CompanyDAO db = new CompanyDAO();
            bool result = db.DeleteCompanyInfo(cmpID);
            db.Dispose();

            return result;
        }
    }
}
