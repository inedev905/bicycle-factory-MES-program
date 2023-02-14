using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class TradeCompanyDTO
    {
        //tradeCompany_id, B.material_id, A.company_id , main, A.first_writeEmp, A.first_writeDate, A.latest_writeEmp, A.latest_writeDate ,
        //B.material_name, C.company_name, C.contact_name, c.contact_phone2, D.name material_category_NM, material_category
        public int TradeCompany_id { get; set; }
        public string Material_id { get; set; }
        public int Company_id { get; set; }
        public string Main { get; set; }
        public int First_writeEmp { get; set; }
        public string First_writeDate { get; set; }
        public int Latest_writeEmp { get; set; }
        public string Latest_writeDate { get; set; }
        public string Material_name { get; set; }
        public string Company_name { get; set; }
        public string Contact_name { get; set; }
        public string Contact_phone2 { get; set; }
        public string Contact_email { get; set; }
        public string Material_category_NM { get; set; }
        public string material_category { get; set; }
    }
}
