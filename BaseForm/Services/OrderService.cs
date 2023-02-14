using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team2DAO;
using Team2DTO;

namespace Team2.Services
{
    class OrderService
    {
        public List<OrderDTO> GetOrderSearch(OrderDTO order, string fromODt, string toODt, string states, string fromOdDt, string toOdDt)
        {
            OrderDAO db = new OrderDAO();
            List<OrderDTO> list = db.GetOrderSearch(order, fromODt, toODt, states, fromOdDt, toOdDt);
            db.Dispose();
            return list;
        }

        public List<OrderDetailDTO> GetOrderDetail(string orderID)
        {
            OrderDAO db = new OrderDAO();
            List<OrderDetailDTO> list = db.GetOrderDetail(orderID);
            db.Dispose();
            return list;
        }

        public List<OrderDetailDTO> GetPurchaseDetail(string purchaseid)
        {
            OrderDAO db = new OrderDAO();
            List<OrderDetailDTO> list = db.GetPurchaseDetail(purchaseid);
            db.Dispose();
            return list;
        }

        public List<CommonCodeDTO> GetCategory(string txt)
        {
            OrderDAO db = new OrderDAO();
            List<CommonCodeDTO> list = db.GetCategory(txt);
            db.Dispose();
            return list;
        }

        public List<ProductDTO> GetProductAllList()
        {
            OrderDAO db = new OrderDAO();
            List<ProductDTO> list = db.GetProductAllList();
            db.Dispose();
            return list;
        }

        public List<MaterialDTO> GetMaterialAllList()
        {
            OrderDAO db = new OrderDAO();
            List<MaterialDTO> list = db.GetMaterialAllList();
            db.Dispose();
            return list;
        }

        public bool AddOrder(OrderDTO order, List<OrderDetailDTO> orderDetail)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.AddOrder(order, orderDetail);
            db.Dispose();
            return result;
        }

        public List<OrderDTO> UpdateOrder(string orderid)
        {
            OrderDAO db = new OrderDAO();
            List<OrderDTO> list = db.UpdateOrder(orderid);
            db.Dispose();
            return list;
        }

        public bool DeleteOrder(string orderID)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.DeleteOrder(orderID);
            db.Dispose();
            return result;
        }

        public bool DeletePurchase(string purchaseid)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.DeletePurchase(purchaseid);
            db.Dispose();
            return result;
        }
        public bool UpdateOrderDetail(string currentInfo, string txtEmpID, string dtpRequestDate, int empID, List<OrderDetailDTO> orderDetail)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.UpdateOrderDetail(currentInfo, txtEmpID, dtpRequestDate, empID, orderDetail);
            db.Dispose();
            return result;
        }

        public List<PurchaseDTO> GetPurchaseSearch(PurchaseDTO purchase, string fromODt, string toODt , string fromOdDt, string toOdDt) //발주목록 조회
        {
            OrderDAO db = new OrderDAO();
            List<PurchaseDTO> list = db.GetPurchaseSearch(purchase, fromODt, toODt, fromOdDt, toOdDt);
            db.Dispose();
            return list;
        }

        public bool Addpurchase(PurchaseDTO order, List<OrderDetailDTO> orderDetail)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.Addpurchase(order, orderDetail);
            db.Dispose();
            return result;
        }

        public List<PurchaseDTO> Updatepurchase(string currentInfo)
        {
            OrderDAO db = new OrderDAO();
            List<PurchaseDTO> list = db.Updatepurchase(currentInfo);
            db.Dispose();
            return list;
        }

        public bool UpdatePurchaseDetail(string currentInfo, string txtEmpID, string dtpRequestDate, int empID, List<OrderDetailDTO> orderDetail)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.UpdatePurchaseDetail(currentInfo, txtEmpID, dtpRequestDate, empID, orderDetail);
            db.Dispose();
            return result;
        }

        public bool Warehousing(string purchaseid, int empID, List<OrderDetailDTO> orderDetail)
        {
            OrderDAO db = new OrderDAO();
            bool result = db.Warehousing(purchaseid, empID, orderDetail);
            db.Dispose();
            return result;
        }

        public int Updatelimit(string orderid, int rowCnt)
        {
            OrderDAO db = new OrderDAO();
            int cnt = db.Updatelimit(orderid, rowCnt);
            db.Dispose();
            return cnt;
        }
    }
}
