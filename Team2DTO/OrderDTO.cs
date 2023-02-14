namespace Team2DTO
{
    public class OrderDTO //주문테이블
    {
        public string Order_id { get; set; } //주문코드
        public string Order_date { get; set; } //주문일자
        public string Order_dueDate { get; set; } //납기예정일자
        public string Order_sendDate { get; set; } //납기일자
        public int Company_id { get; set; } //거래처번호
        public string Company_name { get; set; } //거래처명
        public int Emp_id { get; set; } //담당자번호
        public string Emp_name { get; set; } //담당자명
        public int First_writeEmp { get; set; } //등록자
        public string First_writeDate { get; set; } //등록일자
        public int Latest_writeEmp { get; set; } //최종수정자
        public string Latest_writeDate { get; set; } //최종수정일자
        public int TotAmount { get; set; }
        public string States { get; set; }
        public string Product_id { get; set; }
        public string qty { get; set; }
    }


    public class PurchaseDTO //발주테이블
    {
        public string Purchase_id { get; set; } //발주코드
        public string Company_name { get; set; } //거래처명
        public string Purchase_date { get; set; } //발주일자
        public string Purchase_dueDate { get; set; } //요청일자
        public string Purchase_endDate { get; set; } //입고일자
        public int Emp_id { get; set; } //담당자번호
        public string Emp_name { get; set; } //담당자
        public int Company_id { get; set; } //거래처번호
        public int First_writeEmp { get; set; } //등록자
        public string First_writeDate { get; set; } //등록일자
        public int Latest_writeEmp { get; set; } //최종수정자
        public string Latest_writeDate { get; set; } //최종수정일자
        public int product_Qty { get; set; }
        public int TotAmount { get; set; }
        public string purchase_state { get; set; }
    }
}
