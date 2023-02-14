using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class ProducePlanDTO
    {
        public string producePlan_id { get; set; }
        public string planFromDate { get; set; }
        public string planToDate { get; set; }
        public int tot_planQty { get; set; }


        public string dueDate { get; set; }



        public string producePlanDetail_id { get; set; }
        public DateTime planDate { get; set; }
        public string product_id { get; set; }
        public int product_Qty { get; set; }
        public string product_name { get; set; }
        public int planQty { get; set; }
        public int nPlanQty { get; set; }
        public int afterPlanQty { get; set; }
        public string produceCategory { get; set; }


        public int orderQty { get; set; }
        public int product_Safety { get; set; }

        public string order_id { get; set; }
        public int orderDetail_id { get; set; }

        public DateTime first_writeDate { get; set; }
        public DateTime latest_writeDate { get; set; }


        public ProducePlanDTO Clone()
        {
            return (ProducePlanDTO)this.MemberwiseClone();
        }
    }
}
