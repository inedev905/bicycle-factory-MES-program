using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class ProductDTO
    {
        public string product_id { get; set; }
        public string product_name { get; set; }
        public int product_Qty { get; set; }
        public int product_Safety { get; set; }
        public int product_QtyLimit { get; set; }
        public string product_category { get; set; }
        public byte[] product_Img { get; set; }
        public int product_chargeEmp { get; set; }
        public int product_price { get; set; }

        public string name { get; set; } //주문등록에서 사용

    }
}
