using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DTO;
using Team2DAO;

namespace Team2.Services
{
    class MaterialService
    {
        public List<MaterialDTO> GetAllMaterial()
        {
            MaterialDAO db = new MaterialDAO();
            List<MaterialDTO> list = db.GetAllMaterial();
            db.Dispose();

            return list;
        }

        public List<CompanyDTO> GetInputCompany()
        {
            MaterialDAO db = new MaterialDAO();
            List<CompanyDTO> list = db.GetInputCompany();
            db.Dispose();

            return list;
        }
        public List<TradeCompanyDTO> GetTradeCompanyInfo(string trMtr)
        {
            MaterialDAO db = new MaterialDAO();
            List<TradeCompanyDTO> list = db.GetTradeCompanyInfo(trMtr);
            db.Dispose();

            return list;
        }

        public MaterialDTO GetMaterialInfo(string mtrID)
        {
            MaterialDAO db = new MaterialDAO();
            MaterialDTO dto = db.GetMaterialInfo(mtrID);
            db.Dispose();

            return dto;
        }

        public List<CommonCodeDTO> GetCommonCode(string[] category)
        {
            CommonCodeDAO db = new CommonCodeDAO();
            List<CommonCodeDTO> list = db.GetCommonCategory(category);
            db.Dispose();

            return list;
        }

        public bool InsertMaterialInfo(MaterialDTO mtr, EmployeeDTO emp)
        {
            MaterialDAO db = new MaterialDAO();
            bool result = db.InsertMaterialInfo(mtr, emp);
            db.Dispose();

            return result;
        }

        public bool UpdateMaterialInfo(MaterialDTO mtr, EmployeeDTO emp)
        {
            MaterialDAO db = new MaterialDAO();
            bool result = db.UpdateMaterialInfo(mtr, emp);
            db.Dispose();

            return result;
        }

        public bool DeleteMaterialInfo(string mtrID)
        {
            MaterialDAO db = new MaterialDAO();
            bool result = db.DeleteMaterialInfo(mtrID);
            db.Dispose();

            return result;
        }

        public bool InsertTradeCompany(string mtrId, int cmpId, EmployeeDTO emp)
        {
            MaterialDAO db = new MaterialDAO();
            bool result = db.InsertTradeCompany(mtrId, cmpId, emp);
            db.Dispose();

            return result;
        }

        public bool UpdateTrdNoMain(int trdMain)
        {
            MaterialDAO db = new MaterialDAO();
            bool result = db.UpdateTrdNoMain(trdMain);
            db.Dispose();

            return result;
        }
        public bool UpdateTrdMain(int trdMain, string mtrName)
        {
            MaterialDAO db = new MaterialDAO();
            bool result = db.UpdateTrdMain(trdMain, mtrName);
            db.Dispose();

            return result;
        }

        public bool DeleteTradeCompanyInfo(int trdID)
        {
            MaterialDAO db = new MaterialDAO();
            bool result = db.DeleteTradeCompanyInfo(trdID);
            db.Dispose();

            return result;
        }
    }
}
