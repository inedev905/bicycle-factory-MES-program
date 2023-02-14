using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class EmployeeDTO
    {
        public int      emp_id    { get; set; }
        public string   emp_name    { get; set; }
        public string   dep_code    { get; set; }
        public string   dep_name    { get; set; }
        public string   title_code  { get; set; }
        public string   title_name  { get; set; }
        public string   gender      { get; set; }
        public string   phone1_code { get; set; }
        public string   phone1_name { get; set; }
        public string   phone2      { get; set; }
        public string   email       { get; set; }
        public string   region_code { get; set; }
        public string   region_name { get; set; }
        public string   zipCode     { get; set; }
        public string   address1    { get; set; }
        public string   address2    { get; set; }
        public string   emp_barCode { get; set; }
        public string emp_deleted { get; set; }
    }
}
