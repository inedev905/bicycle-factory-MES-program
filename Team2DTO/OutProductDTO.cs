using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class OutProductDTO
    {
        public int loginedEmpID { get; set; }
        public string OrderID { get; set; }
        public List<ProductSet> ProductSets { get; set; }

    }

    public class ProductSet
    {
        public string ProductID { get; set; }
        public int LeftQty { get; set; }
    }
}
