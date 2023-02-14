using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Team2DAO;
using Team2DTO;

namespace Team2
{
    public class ProductionService
    {
        public List<TotCountDTO> SetTotCount()
        {
            ProductionDAO db = new ProductionDAO();
            List<TotCountDTO> list = db.SetTotCount();
            db.Dispose();

            return list;
        }

        public List<OrderDTO> SetOrders()
        {
            ProductionDAO db = new ProductionDAO();
            List<OrderDTO> list = db.SetAllOrders();
            db.Dispose();

            return list;
        }

        public List<OrderDetailDTO> SetOrdersDt()
        {
            ProductionDAO db = new ProductionDAO();
            List<OrderDetailDTO> list = db.SetAllOrdersDT();
            db.Dispose();

            return list;
        }

        public List<ProductionDTO> SetProduction()
        {
            ProductionDAO db = new ProductionDAO();
            List<ProductionDTO> list = db.SetProduction();
            db.Dispose();

            return list;
        }

        public bool Shipment(List<OutProductDTO> list)
        {
            ProductionDAO db = new ProductionDAO();
            bool resutl = db.Shipment(list);
            db.Dispose();

            return resutl;
        }

        public bool TakeProduct(List<OutProductDTO> list)
        {
            ProductionDAO db = new ProductionDAO();
            bool resutl = db.TakeProduct(list);
            db.Dispose();

            return resutl;
        }


    }
}
