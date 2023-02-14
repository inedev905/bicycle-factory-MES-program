using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2DAO;
using Team2DTO;
using Team2.Services;
using Team2.Util;
using System.Linq;

namespace Team2
{
    public partial class frmCompanyMainform : Team2.frmListList
    {
        CompanyService srv = null;
        List<CompanyDTO> companyAllList = null;
        List<OrderDTO> orderProductList = new List<OrderDTO>();
        EmployeeDTO loginEmpInfo;
        
        //List<CommonCodeDTO> cpyCommonList = null;

        public frmCompanyMainform()
        {
            InitializeComponent();
        }

        private void frmCompanyMainform_Load(object sender, EventArgs e)
        {
            //======================================거래처 목록==================================================
            loginEmpInfo = ((frmMain)this.MdiParent).LoginEmpInfo;

            srv = new CompanyService();
            //cpyCommonList = new List<CommonCodeDTO>();

            //cpyCommonList = srv.SetCommonCodeName();
            DataGridViewUtil.SetDgv(dgvCompany);
            dgvCompany.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "NO", "company_id", 50, visible :false);      //0
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "사업자 등록번호", "business_num", 150); //1
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "거래처 구분", "business_category_NM", 100);   //2
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "거래처 명", "company_name", 100);    //3
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "거래처 지역", "region_code_NM", 90);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "거래처 연락처", "phone", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "도로명 주소", "address1", 430, align : DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "상세 주소", "address2", 200 , align : DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "담당자 이름", "contact_name", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "담당자 직책", "contact_position_NM", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "통신사", "contact_phone1_NM", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "담당자 연락처", "contact_phone2", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "담당자 이메일", "contact_email", 180);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "등록자 ID", "first_writeEmp", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "등록날짜", "first_writeDate", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "수정자 ID", "latest_writeEmp", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "수정날짜", "latest_writeDate", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "거래처 주소", "zipCode", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "거래처구분코드", "business_category", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "지역코드", "region_code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "직책코드", "contact_position", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCompany, "통신사코드", "contact_phone1", visible: false);

            companyAllList = srv.GetAllCompany();
            dgvCompany.DataSource = companyAllList;
        }

        private void btnInsert_BtnClick(object sender, EventArgs e)
        {
            int empid = ((frmMain)this.MdiParent).LoginEmpInfo.emp_id;
            frmCompanyRegistPop pop = new frmCompanyRegistPop(OpenMode.Regist);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                CompanyDTO cmp = pop.GetCompanyInfo;

                srv = new CompanyService();
                bool result = srv.InsertCompanyInfo(cmp, loginEmpInfo);

                if (result)
                {
                    rdoAll.Checked = true;
                    companyAllList = srv.GetAllCompany();
                    dgvCompany.DataSource = companyAllList;
                    MessageBox.Show("거래처 신규등록이 완료되었습니다.");
                }
                else
                {
                    MessageBox.Show("거레처 신규등록에 실패하였습니다. 다시 시도하여 주십시오.");
                }
            }
        }

        private void btnUpdate_BtnClick(object sender, EventArgs e)
        {
            int idx = dgvCompany.CurrentRow.Index;
            CompanyDTO cmp = new CompanyDTO
            {
                Company_id = Convert.ToInt32(dgvCompany[0, idx].Value),
                Business_num = dgvCompany[1, idx].Value.ToString(),
                Business_category = dgvCompany["business_category", idx].Value.ToString(),
                Company_name = dgvCompany[3,idx].Value.ToString(),
                Region_code = dgvCompany["region_code", idx].Value.ToString(),
                Phone = dgvCompany[5,idx].Value.ToString(),
                ZipCode = dgvCompany[17, idx].Value.ToString(),
                Address1 = dgvCompany[6,idx].Value.ToString(),
                Address2 = dgvCompany[7,idx].Value.ToString(),
                Contact_name = dgvCompany[8,idx].Value.ToString(),
                Contact_position = dgvCompany["contact_position", idx].Value.ToString(),
                Contact_phone1 = dgvCompany["contact_phone1", idx].Value.ToString(),
                Contact_phone2 = dgvCompany[11,idx].Value.ToString(),
                Contact_email = dgvCompany[12,idx].Value.ToString()
            };
            frmCompanyRegistPop pop = new frmCompanyRegistPop(OpenMode.Update);
            pop.GetCompanyInfo = cmp;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                cmp = pop.GetCompanyInfo;

                srv = new CompanyService();
                bool result = srv.UpdateCompanyInfo(cmp, loginEmpInfo);
                if (result)
                {
                    rdoAll.Checked = true;
                    companyAllList = srv.GetAllCompany();
                    dgvCompany.DataSource = companyAllList;
                    MessageBox.Show("거래처 정보가 수정되었습니다");
                }
                else
                {
                    MessageBox.Show("거래처 정보 수정에 실패하였습니다. 다시 시도하여 주세요.");
                }
            }
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtCompanyName1.Text.Trim(); //거래처명 공백
            List<CompanyDTO> list = null;
            // 검색어 없으면서 
            if (searchName.Length < 1 )
            {                
                if (rdoInput1.Checked)  // 매입처 체크시
                {
                    list = companyAllList.FindAll((cmp) => cmp.Business_category.Equals("c01"));
                }
                else if (rdoOutput1.Checked) // 매출처 체크시 
                {
                    list = companyAllList.FindAll((cmp) => cmp.Business_category.Equals("c02"));
                }
                else //전체 체크일 시
                {
                    list = companyAllList;
                }                
            }
            // 검색어 있으면서
            else
            {
                if (rdoInput1.Checked) //매입처 체크시
                {
                    list = (from cmp in companyAllList
                            where cmp.Business_category.Equals("c01")  && cmp.Company_name.Contains(searchName)
                            select cmp).ToList();
                }
                else if (rdoOutput1.Checked) //매출처 체크시
                {
                    list = (from cmp in companyAllList
                            where cmp.Business_category.Equals("c02") && cmp.Company_name.Contains(searchName)
                            select cmp).ToList();
                }
                else //전체 체크시 
                {
                    list = companyAllList.Where((cmp) => cmp.Company_name.Contains(searchName)).ToList();
                }
            }

            dgvCompany.DataSource = null;
            dgvCompany.DataSource = list;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCompanyName1.Text = "";
            rdoAll.Checked = true;
            rdoInput1.Checked = false;
            rdoOutput1.Checked = false;
            dgvCompany.DataSource = null;
            dgvCompany.DataSource = companyAllList;
        }

        private void btnDelete_BtnClick(object sender, EventArgs e)
        {
            int idx = dgvCompany.CurrentRow.Index;

            string msg = $"{dgvCompany["business_category", idx].Value} 회사명: {dgvCompany[3, idx].Value}의 정보를 삭제하시겠습니까?";
            DialogResult dlg = MessageBox.Show(msg, "삭제" ,MessageBoxButtons.YesNo);

            if (dlg == DialogResult.Yes)
            {
                srv = new CompanyService();
                bool result = srv.DeleteCompanyInfo(Convert.ToInt32(dgvCompany[0, idx].Value));
                if (result)
                {
                    //rdoAll.Checked = true;
                    companyAllList = srv.GetAllCompany();
                    dgvCompany.DataSource = companyAllList;
                    MessageBox.Show("거래처 정보가 정상적으로 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("거래처 정보 삭제에 실패하였습니다. 다시 시도하여 주세요.");
                }
            }
        }

        private void btnSearchCMP1_BtnClick(object sender, EventArgs e)
        {
            frmSearchCompanyPop pop = new frmSearchCompanyPop();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtCompanyName1.Text = pop.CompanyNameInfo.Company_name;
            }   
        }

        private void OrderDataGridview()
        {
            DataGridViewUtil.SetDgv(dgvCount);
            //Order_id Order_date Order_sendDate States TotAmount Emp_id
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "주문번호", "Order_id", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "주문일자", "Order_date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "출하일자", "Order_sendDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "상태", "States", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "총 금액", "TotAmount", 100, align :DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "담당자", "Emp_name", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "담당자", "Emp_id", visible: false);
        }
        private void PurchaseDataGridView()
        {
            DataGridViewUtil.SetDgv(dgvCount);

            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "발주번호", "Purchase_id", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "주문일자", "Purchase_date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "납기일자", "Purchase_endDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "상태", "purchase_state", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "총 수량", "product_Qty", 100, align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "담당자", "Emp_name", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCount, "담당자 ID", "Emp_id", visible: false); 
        }
        private void dgvCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ) return;
            string business = dgvCompany["business_category", e.RowIndex].Value.ToString();

            if (business == "c02")
            {
                dgvCount.Columns.Clear();
                OrderDataGridview();

                int cmpID = Convert.ToInt32(dgvCompany[0, e.RowIndex].Value);
                List<OrderDTO> list = srv.GetProductCompanyInfo(cmpID);
                dgvCount.DataSource = null;
                dgvCount.DataSource = list;
            }
            else if (business == "c01")
            {
                dgvCount.Columns.Clear();
                PurchaseDataGridView();

                int cmpID = Convert.ToInt32(dgvCompany[0, e.RowIndex].Value);
                List<PurchaseDTO> list2 = srv.GetMaterialCompanyInfo(cmpID);
                dgvCount.DataSource = null;
                dgvCount.DataSource = list2;
            }
        }

        private void dgvCompany_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCompany.Rows[e.RowIndex].Cells[2].Value.ToString() == "매출처")
            {
                e.CellStyle.BackColor = Color.Ivory;
            }
        }
    }
}
