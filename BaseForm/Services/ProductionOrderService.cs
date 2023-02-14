using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DAO;
using Team2DTO;

namespace Team2.Services
{
    class ProductionOrderService
    {
        public List<ProducePlanDTO> GetProductionPlanList1()
        {
            ProductionOrderDAO db = new ProductionOrderDAO();
            List<ProducePlanDTO> list = db.GetProductionPlanList1();
            db.Dispose();

            return list;
        }

        public List<ProducePlanDTO> GetProductionPlanList2()
        {
            ProductionOrderDAO db = new ProductionOrderDAO();
            List<ProducePlanDTO> list = db.GetProductionPlanList2();
            db.Dispose();

            return list;
        }

        public bool InsertProductionOrder(List<ProductionOrderDTO> list1, List<ProducePlanDTO> list2, List<BOMDTO> list3)
        {
            ProductionOrderDAO db = new ProductionOrderDAO();
            bool result = db.InsertProductionOrder(list1, list2, list3);
            db.Dispose();

            return result;
        }

        public List<BOMDTO> getMaterialList(Dictionary<string, int> dic)
        {
            ProductionOrderDAO db = new ProductionOrderDAO();
            List<BOMDTO> list = db.getMaterialList(dic);
            db.Dispose();

            return list;
        }

        public List<ProductionOrderDTO> GetProductionOrders()
        {
            ProductionOrderDAO db = new ProductionOrderDAO();
            List<ProductionOrderDTO> list = db.GetProductionOrders();
            db.Dispose();

            return list;
        }
    }
}
