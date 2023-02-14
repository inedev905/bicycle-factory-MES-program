using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class ProductionOrderDTO
    {
        public string produceOrd_id { get; set; }
        public string producePlanDetail_id { get; set; }
        public string product_id { get; set; }
        public string product_name { get; set; }
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public string produceOrd_category { get; set; }
        public string orderFromDate { get; set; }
        public string orderDueDate { get; set; }
        public string orderToDate { get; set; }
        public int planQty { get; set; }
        public int curQty { get; set; }
        public string level { get; set; }
    }
}
