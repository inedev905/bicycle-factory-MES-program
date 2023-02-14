using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class OrderDetailDTO
    {
        public int OrderDetail_id { get; set; } //주문상세코드
        public string Order_id { get; set; } //주문코드
        public string product_category { get; set; } //카테고리
        public string Product_id { get; set; } //제품코드
        public string product_name { get; set; } //제품명
        public int product_Qty { get; set; } //수량
        public int product_price { get; set; } //가격
        public int TotAmount { get; set; } //총가격
        public string Situation { get; set; } //상황
    }
}
