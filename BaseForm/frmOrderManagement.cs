using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Team2.Services;
using Team2DTO;
using Team2.Util;
using System.Diagnostics;

namespace Team2
{
    public partial class frmOrderManagement : Team2.frmListList2
    {
        OrderService srv = new OrderService();
        List<OrderDTO> orderList = new List<OrderDTO>();
        List<PurchaseDTO> PurchaseList = new List<PurchaseDTO>();
        List<OrderDetailDTO> orderDetails = null;   //주문상세
        string emp_name;
        int empID;

        public frmOrderManagement()
        {
            InitializeComponent();
            panItem.Location = new Point(1401, 6);
        }

        #region 폼Load
        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            emp_name = ((frmMain)this.MdiParent).LoginEmpInfo.emp_name;
            empID = ((frmMain)this.MdiParent).LoginEmpInfo.emp_id;
            dgvOrder.ReadOnly = true;
            dgvOrderDetails.ReadOnly = true;
            cboState.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadData_Common();
            if (this.Text == "주문관리")
                LoadData_OrderA();
            else
                LoadData_OrderB(); //발주관리
        }
        #endregion

        #region 공통Load
        private void LoadData_Common()
        {
            dtpOrderDT.StartDate = DateTime.Now.AddDays(1 - DateTime.Now.Day); //주문일
            dtpOrderDT.EndDate = DateTime.Now.AddDays(1);
            dtpOrderDueDT.StartDate = DateTime.Now; //요청일
            dtpOrderDueDT.EndDate = DateTime.Now.AddMonths(1);
        }
        #endregion

        #region 주문관리Load
        private void LoadData_OrderA()
        {
            btnWarehousing.Visible = false;
            cboState.Items.Add("전체");
            cboState.Items.Add("주문완료");
            cboState.Items.Add("출하완료");
            cboState.Items.Add("주문취소");
            cboState.SelectedIndex = 0;

            DataGridViewUtil.SetDgv(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "주문번호", "Order_id", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "Company_name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "주문일자", "Order_date", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "납기 요청일자", "Order_dueDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "상태", "States", 180);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "출하일자", "Order_sendDate", 140);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "총 금액", "TotAmount", 150, align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "담당자", "Emp_name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "등록일자", "First_writeDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "등록자ID", "First_writeEmp", 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "최종 수정일자", "Latest_writeDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "수정자ID", "Latest_writeEmp", 80);
            dgvOrder.Columns["TotAmount"].DefaultCellStyle.Format = "N0";

            DataGridViewUtil.SetDgv(dgvOrderDetails);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "주문번호", "Order_id", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "상세주문번호", "OrderDetail_id", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "제품명", "product_name", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "제품수량", "product_Qty", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "제품가격", "product_price", 300, align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "총금액", "TotAmount", 300, align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "상황", "Situation", 200);
            dgvOrderDetails.Columns["product_price"].DefaultCellStyle.Format = "N0";
            dgvOrderDetails.Columns["TotAmount"].DefaultCellStyle.Format = "N0";

            btnSelect_BtnClick(this, null);
        }
        #endregion

        #region 발주관리Load
        private void LoadData_OrderB()
        {
            btnWarehousing.Visible = true; //입고
            label1.Text = "발주관리";
            label3.Text = "발주목록";
            label4.Text = "발주상세";
            lblOrderNo.Text = "발주번호";
            lblOrderDate.Text = "발주일자";
            cboState.Items.Add("전체");
            cboState.Items.Add("발주완료");
            cboState.Items.Add("입고완료");
            cboState.Items.Add("발주취소");
            cboState.SelectedIndex = 0;

            DataGridViewUtil.SetDgv(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "발주번호", "purchase_id", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "Company_name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "발주일자", "purchase_date", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "입고예정일자", "purchase_dueDate", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "발주상태", "purchase_state", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "입고일자", "purchase_endDate", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "담당자", "Emp_name", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "등록일자", "first_writeDate", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "등록자ID", "first_writeEmp", 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "최종 수정일자", "latest_writeDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "수정자ID", "latest_writeEmp", 80);

            DataGridViewUtil.SetDgv(dgvOrderDetails);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "발주번호", "Order_id", 400);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "발주상세번호", "OrderDetail_id", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "자재ID", "Product_id", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "자재명", "product_name", 400);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetails, "주문수량", "product_Qty", 300);

            btnSelect_BtnClick(this, null);
        }
        #endregion

        #region dgvOrder_CellClick
        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            List<OrderDetailDTO> list;
            string orderID = dgvOrder[0, e.RowIndex].Value.ToString();
            if (this.Text == "주문관리")
                list = srv.GetOrderDetail(orderID);
            else
                list = srv.GetPurchaseDetail(orderID);
            dgvOrderDetails.DataSource = list;
        }
        #endregion

        #region btnSelect
        private void btnSelect_BtnClick(object sender, EventArgs e)
        {
            string fromODt = dtpOrderDT.StartDate.ToString("yyyy-MM-dd");
            string toODt = dtpOrderDT.EndDate.ToString("yyyy-MM-dd");
            string fromOdDt = dtpOrderDueDT.StartDate.ToString("yyyy-MM-dd");
            string toOdDt = dtpOrderDueDT.EndDate.ToString("yyyy-MM-dd");

            if (this.Text == "주문관리")
            {
                string states = cboState.Text;
                OrderDTO order = new OrderDTO
                {
                    Company_name = txtClientName.Text,
                    Emp_name = txtEmployee.Text,
                    Order_id = txtOrderNo.Text
                };
                orderList = srv.GetOrderSearch(order, fromODt, toODt, states, fromOdDt, toOdDt);
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = orderList;
            }
            else
            {
                PurchaseDTO purchase = new PurchaseDTO
                {
                    Company_name = txtClientName.Text,
                    Emp_name = txtEmployee.Text,
                    Purchase_id = txtOrderNo.Text,
                    purchase_state = cboState.Text
                };
                PurchaseList = srv.GetPurchaseSearch(purchase, fromODt, toODt, fromOdDt, toOdDt);
                dgvOrder.DataSource = null;
                dgvOrder.DataSource = PurchaseList;
            }
        }
        #endregion

        #region btnInsert
        private void btnInsert_BtnClick_1(object sender, EventArgs e)
        {
            frmOrderRegistrationPop pop = new frmOrderRegistrationPop(OpenMode.Regist, this.Text, null, emp_name, empID);
            if (pop.ShowDialog() == DialogResult.OK) MessageBox.Show("등록이 완료되었습니다.");
            else if (DialogResult == DialogResult.Cancel) MessageBox.Show("다시 시도하여 주십시오.");
            btnSelect_BtnClick(this, null);
        }
        #endregion

        #region btnUpdate
        private void btnUpdate_BtnClick(object sender, EventArgs e)
        {
            string orderInfo = dgvOrder[0, dgvOrder.CurrentRow.Index].Value.ToString();
            string txt = dgvOrder[4, dgvOrder.CurrentRow.Index].Value.ToString();            

            if (dgvOrder.GetCellCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("수정하실 항목을 선택하여 주십시오.", "주문수정");
                return;
            }
            if (this.Text == "주문관리")
            {
                int num = 0;
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    if (dgvOrderDetails.Rows[i].Cells["Situation"].Value.ToString().Equals("작업진행중"))
                        num += 1;
                }

                if (txt != "주문완료")
                {
                    MessageBox.Show($"{txt}상태이므로 수정이 불가능합니다.", txt);
                    return;
                }
                else if (num > 0)
                {
                    MessageBox.Show("작업진행중이므로 수정이 불가능합니다.");
                    return;
                }
            }
            else
            {
                if (txt != "발주완료")
                {
                    MessageBox.Show($"{txt}상태이므로 수정이 불가능합니다.", txt);
                    return;
                }
            }
            frmOrderRegistrationPop pop = new frmOrderRegistrationPop(OpenMode.Update, this.Text, orderInfo, emp_name, empID);
            if (pop.ShowDialog() == DialogResult.OK) MessageBox.Show("수정이 완료되었습니다.");
            else if (DialogResult == DialogResult.Cancel) MessageBox.Show("다시 시도하여 주십시오.");
            btnSelect_BtnClick(this, null);
        }
        #endregion

        #region btnDelete
        private void btnDelete_BtnClick(object sender, EventArgs e)
        {
            int rIdx = dgvOrder.CurrentRow.Index;
            string curcel = dgvOrder[0, rIdx].Value.ToString();
            string txt = dgvOrder[4, dgvOrder.CurrentRow.Index].Value.ToString();
            
            if (dgvOrder.GetCellCount(DataGridViewElementStates.Selected) == 0)
            {
                MessageBox.Show("취소하실 주문을 선택하여주십시오.");
                return;
            }

            if (this.Text == "주문관리")
            {
                int num = 0;
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    if (dgvOrderDetails.Rows[i].Cells["Situation"].Value.ToString().Equals("작업진행중"))
                        num += 1;
                }

                if (txt != "주문완료")
                {
                    MessageBox.Show($"{txt}상태이므로 취소가 불가능합니다.", txt);
                    return;
                }
                else if (num > 0)
                {
                    MessageBox.Show("작업진행중이므로 취소가 불가능합니다.");
                    return;
                }
                else
                {
                    string msg = $"{dgvOrder[1, rIdx].Value}의 {curcel}번 주문을 정말 취소하시겠습니까?";
                    DialogResult dlg = MessageBox.Show(msg, "취소확인", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        bool result = srv.DeleteOrder(curcel);
                        if (result) MessageBox.Show("취소 되었습니다.");
                        else MessageBox.Show("다시 시도하여 주십시오.");
                    }
                }
            }
            else
            {
                if (txt != "발주완료")
                {
                    MessageBox.Show($"{txt}상태이므로 취소가 불가능합니다.", txt);
                    return;
                }
                string msg = $"{dgvOrder[1, rIdx].Value}의 {curcel}번 발주를 취소하시겠습니까?";
                DialogResult dlg = MessageBox.Show(msg, "삭제확인", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    bool result = srv.DeletePurchase(curcel);
                    if (result) MessageBox.Show("취소 되었습니다.");
                    else MessageBox.Show("다시 시도하여 주십시오.");
                }
            }
            btnSelect_BtnClick(this, null);
        }
        #endregion

        #region btnExcel
        private void ucExcelButton1_BtnClick(object sender, EventArgs e)
        {
            if (dgvOrderDetails.RowCount < 1)
            {
                MessageBox.Show("Export하실 주문을 선택하여 주십시오.");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                List<OrderDetailDTO> list = (List<OrderDetailDTO>)dgvOrderDetails.DataSource;
                string errMsg = ExcelUtil.ExcelExportListDTO<OrderDetailDTO>(list, dlg.FileName, "");
                if (errMsg != null) MessageBox.Show(errMsg);
                else MessageBox.Show("성공적으로 저장되었습니다.", "Excel");
            }
        }
        #endregion

        #region btnRefresh
        private void btnRefresh_BtnClick(object sender, EventArgs e)
        {
            txtClientName.Text = txtOrderNo.Text = txtEmployee.Text = "";
            cboState.SelectedIndex = 0;
            LoadData_Common();
            btnSelect_BtnClick(this, null);
        }
        #endregion

        #region 거래처조회
        private void ucSearchSmall1_BtnClick(object sender, EventArgs e)
        {
            frmSearchCompanyPop pop = new frmSearchCompanyPop();
            if (pop.ShowDialog() == DialogResult.OK) txtClientName.Text = pop.CompanyNameInfo.Company_name;
        }
        #endregion

        #region 직원조회
        private void ucSearchSmall2_BtnClick(object sender, EventArgs e)//직원조회
        {
            frmSearchEmpPop pop = new frmSearchEmpPop();
            if (pop.ShowDialog() == DialogResult.OK) txtEmployee.Text = pop.EmployeeNameInfo.emp_name;
        }

        #endregion

        #region cboState_Selected
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnSelect_BtnClick(null, null);
        }
        #endregion

        #region 입고버튼
        private void btnWarehousing_BtnClick(object sender, EventArgs e) //발주목록 셀클릭+버튼클릭 => 입고+ 자재에 재고플러스
        {
            string curInfo = dgvOrder[0, dgvOrder.CurrentRow.Index].Value.ToString();
            string txt = dgvOrder[4, dgvOrder.CurrentRow.Index].Value.ToString();
            if (txt != "발주완료")
            {
                MessageBox.Show($"{txt}상태이므로 입고처리가 불가능합니다.", txt);
                return;
            }

            orderDetails = new List<OrderDetailDTO>();
            DialogResult dlg = MessageBox.Show("입고처리 하시겠습니까?", "입고확인", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                for (int i = 0; i < dgvOrderDetails.Rows.Count; i++)
                {
                    OrderDetailDTO dto = new OrderDetailDTO
                    {
                        Product_id = dgvOrderDetails.Rows[i].Cells["Product_id"].Value.ToString(),
                        product_Qty = int.Parse(dgvOrderDetails.Rows[i].Cells["product_Qty"].Value.ToString())
                    };
                    orderDetails.Add(dto);
                }
                bool result = srv.Warehousing(curInfo, empID, orderDetails);
                if (result) MessageBox.Show("입고처리 되었습니다.");
                else MessageBox.Show("다시 시도하여 주십시오.");
            }
            btnSelect_BtnClick(null, null);
        }
        #endregion

        #region KeyPress
        private void txtClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSelect_BtnClick(null, null);
        }

        private void txtEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSelect_BtnClick(null, null);
        }

        private void txtOrderNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSelect_BtnClick(this, null);
        }


        #endregion

        private void dgvOrder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //            if (DateTime.Parse(dgvOrder["Order_dueDate", e.RowIndex].Value.ToString()) == DateTime.Now.ToString("yyyy-MM-dd"))
            ////                || DateTime.Parse(dgvOrder["Order_dueDate", e.RowIndex].Value.ToString()) < DateTime.Now.AddDays(3))
            //            {
            //                for (int c = 0; c < dgvOrder.ColumnCount; c++)
            //                {
            //                    dgvOrder[c, e.RowIndex].Style.BackColor = Color.MistyRose;
            //}
            //}
        }
    }
}
