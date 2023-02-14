using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team2DTO
{
    public class CompanyDTO
    {
        //company (business_num, business_category, company_name, phone, region_code,  zipCode, address1, address2, contact_name, contact_phone1, contact_phone2,contact_email)

        public int    Company_id            { get; set; }   //거래처 번호
        public string Business_num          { get; set; }   //사업자등록번호 
        public string Company_name          { get; set; }   //거래처 이름
        public string Region_code           { get; set; }   //거래처 위치(지역) Code |commoncode
        public string Region_code_NM        { get; set; }   //거래처 위치(지역) Name |commoncode
        public string Phone                 { get; set; }   //거래처 전화번호
        public string ZipCode               { get; set; }   //우편번호
        public string Addr                  { get; set; }   //거래처 주소
        public string Address1              { get; set; }   //상세주소 1
        public string Address2              { get; set; }   //상세주소 2
        public string Contact_name          { get; set; }   //거래처 담당자 명
        public string Contact_position      { get; set; }   //거래처 담당자 직급 Code |commoncode
        public string Contact_position_NM   { get; set; }   //거래처 담당자 직급 Name |commoncode
        public string Contact_phone1        { get; set; }   //거래처 담당자 통신사 Code |commoncode
        public string Contact_phone1_NM     { get; set; }   //거래처 담당자 통신사 Name |commoncode
        public string Contact_phone2        { get; set; }   //거래처 담당자 휴대전화 번호
        public string Contact_email         { get; set; }   //거래처 담당자 이메일
        public string Business_category     { get; set; }   //거래처 구분 Code  |commoncode
        public string Business_category_NM  { get; set; }   //거래처 구분 Name  |commoncode
        public int? First_writeEmp          { get; set; }   //등록자
        public string First_writeDate       { get; set; }   //등록 날짜
        public int? Latest_writeEmp         { get; set; }   //최종수정자
        public string Latest_writeDate      { get; set; }   //최종수정일자
        public string Company_deleted       { get; set; }   //거래처 계약여부
    }
}
