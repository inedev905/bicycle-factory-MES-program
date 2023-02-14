using System;
using System.Collections.Generic;
using Team2DAO;
using Team2DTO;

namespace Team2.Services
{
    public class ProducePlanService
    {
        public List<OrderDTO> GetOrders()
        {
            ProducePlanDAO db = new ProducePlanDAO();
            List<OrderDTO> list = db.GetOrders();
            db.Dispose();

            return list;
        }

        public List<OrderDetailDTO> GetOrderDetails()
        {
            ProducePlanDAO db = new ProducePlanDAO();
            List<OrderDetailDTO> list = db.GetOrderDetail();
            db.Dispose();

            return list;
        }

        public List<List<ProducePlanDTO>> GetPlan(List<string> orderIDs, string planfromDate)
        {
            ProducePlanDAO db = new ProducePlanDAO();
            List<List<ProducePlanDTO>> list = db.GetPlan(orderIDs, planfromDate);
            db.Dispose();

            return list;
        }

        #region 이전버전
        /*
        public List<List<ProducePlanDTO>> GetOrders(string planfromDate, int datecnt)
        {
            ProducePlanDAO db = new ProducePlanDAO();
            List<List<ProducePlanDTO>> list = db.GetOrders(planfromDate, datecnt);
            db.Dispose();

            return list;

        }
        */
        #endregion

        public bool InsertProducePlanning(ProducePlanDTO plan, List<ProducePlanDTO> planDetail, List<int> orderID, int empID)
        {
            ProducePlanDAO db = new ProducePlanDAO();
            bool result = db.InsertProducePlanning(plan, planDetail, orderID, empID);
            db.Dispose();

            return result;
        }

        public List<List<ProducePlanDTO>> GetPlan(DateTime fromDate, DateTime toDate)
        {
            ProducePlanDAO db = new ProducePlanDAO();
            List<List<ProducePlanDTO>> list = db.GetPlan(fromDate, toDate);
            db.Dispose();

            return list;
        }

        //public List<ProducePlanDTO> GetProducePlanQty(DateTime fromDate, DateTime toDate)
        //{
        //    ProducePlanDAO db = new ProducePlanDAO();
        //    List<ProducePlanDTO> list = db.GetProducePlanQty(fromDate, toDate);
        //    db.Dispose();

        //    return list;
        //}

        //public List<ProducePlanDTO> GetProducePlan(DateTime fromDate, DateTime toDate)
        //{
        //    ProducePlanDAO db = new ProducePlanDAO();
        //    List<ProducePlanDTO> list = db.GetProducePlan(fromDate, toDate);
        //    db.Dispose();

        //    return list;
        //}

        public List<ProducePlanDTO> GetProducePlanDetail(DateTime fromDate, DateTime toDate)
        {
            ProducePlanDAO db = new ProducePlanDAO();
            List<ProducePlanDTO> list = db.GetProducePlanDetail(fromDate, toDate);
            db.Dispose();

            return list;
        }

        public bool UpdatePlan(ProducePlanDTO updateInfo, int empID)
        {
            ProducePlanDAO db = new ProducePlanDAO();
            bool result = db.UpdatePlan(updateInfo, empID);
            db.Dispose();

            return result;
        }

        public bool DeletePlan(ProducePlanDTO deleteInfo, int empID)
        {
            ProducePlanDAO db = new ProducePlanDAO();
            bool result = db.DeletePlan(deleteInfo, empID);
            db.Dispose();

            return result;
        }
    }
}
