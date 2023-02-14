using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    //material_id, material_name, material_Qty, material_safety, material_QtyLimit, material_category, material_Img, first_writeEmp, first_writeDate, latest_writeEmp, latest_writeDate
    public class MaterialDTO
    {
        public  string   Material_id           { get; set; }    //자재번호
        public  string   Material_name         { get; set; }    //자재명
        public  int      Material_Qty          { get; set; }    //초기수량
        public  int      Material_safety       { get; set; }    //안전수량
        public  string   Material_category     { get; set; }    //자재 카테고리 코드
        public  string   Material_category_NM  { get; set; }    //자재 카테고리 이름
        public  string   Material_Notes        { get; set; }    //자재 비고 (설명)
        public  double   Material_Min_per      { get; set; }    //자재 공정시간
        public  byte[]   Material_Img          { get; set; }    //자재 이미지
        public  int      First_writeEmp        { get; set; }    //최초등록자
        public  string   First_writeDate       { get; set; }    //최초등록날짜
        public  int      Latest_writeEmp       { get; set; }    //최종수정자
        public  string   Latest_writeDate      { get; set; }    //최종수정날짜
        public string name { get; set; } //주문등록에서 사용
    }
}
