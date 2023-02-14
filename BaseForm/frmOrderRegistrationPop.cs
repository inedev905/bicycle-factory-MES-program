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
using System.Linq;

namespace Team2
{
    public partial class frmOrderRegistrationPop : Team2.frmPop
    {
        OrderService srv = new OrderService();
        List<OrderDTO> orderInfo = new List<OrderDTO>();            //주문
        List<OrderDetailDTO> orderDetails = null;                   //주문상세
        List<ProductDTO> productList = null;                        //제품
        List<PurchaseDTO> purchaseInfo = new List<PurchaseDTO>();   //발주
        List<MaterialDTO> materialList = null;                      //자재
        List<CommonCodeDTO> CommonList = new List<CommonCodeDTO>(); //공통코드
        string text; //주문, 발주
        string mode; //등록, 수정
        string currentInfo;
        string Product_id;
        string emp_name;
        int empID;

        public frmOrderRegistrationPop(OpenMode Mode, string Text, string CurrentInfo, string Emp_name, int EmpID)
        {
            InitializeComponent();
            text = Text;
            mode = Mode.ToString();
            currentInfo = CurrentInfo; //수정버튼에서 넘겨받은 주문번호 or 발주번호
            txtOrderNo.Text = "코드 자동생성";
            emp_name = Emp_name;
            empID = EmpID;
        }

        private void frmOrderRegistrationPop_Load(object sender, EventArgs e)
        {
            dgvDetails.ReadOnly = true;

            if (text == "주문관리")
            {
                LoadOrderA();
                LoadOrderAInfo();
            }
            else //발주
            {
                LoadOrderB();
                LoadOrderBInfo();
            }
            LoadCommon();
        }


        #region LoadCommon
        private void LoadCommon()
        {
            txtOrderNo.Enabled = txtStock.Enabled = false;
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            txtSumAmount.TextAlign = txtStock.TextAlign = txtProductPrice.TextAlign = txtTotAmount.TextAlign = HorizontalAlignment.Right;
            txtEmpID.Text = emp_name;
        }
        #endregion

        #region 주문등록Load
        private void LoadOrderA()
        {
            txtSumAmount.Enabled = txtTotAmount.Enabled = txtProductPrice.Enabled = txtTotAmount.Enabled = false;
            CommonList = srv.GetCategory("PROD");
            CommonCodeUtil.ComboBinding(cboCategory, CommonList, "PROD");
            DataGridViewUtil.SetDgv(dgvDetails);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "카테고리", "product_category", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "제품ID", "Product_id", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "제품명", "product_name", 250);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "제품수량", "product_Qty", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "제품금액", "product_price", 180, align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "총 금액", "TotAmount", 180, align: DataGridViewContentAlignment.MiddleRight);
            dgvDetails.Columns["product_price"].DefaultCellStyle.Format = "N0";
            dgvDetails.Columns["TotAmount"].DefaultCellStyle.Format = "N0";
        }
        #endregion

        #region 주문- 등록, 수정
        private void LoadOrderAInfo()
        {
            if (mode == "Regist")
            {
                dtpOrderDate.Value = DateTime.Now;
                dtpRequestDate.Value = DateTime.Now.AddDays(15);
            }
            else if (mode == "Update")
            {
                string OrderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd");
                orderDetails = srv.GetOrderDetail(currentInfo);
                dgvDetails.DataSource = null;
                dgvDetails.DataSource = orderDetails;
                txtClientName.Enabled = false;
                dtpOrderDate.Enabled = false;

                int Sum = 0;
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    Sum += int.Parse(dgvDetails.Rows[i].Cells["TotAmount"].Value.ToString());
                }
                txtSumAmount.Text = Sum.ToString("#,##0.###") + "원";

                //주문번호로  담당자명, 총금액, 거래처, 주문일, 주문예정일 가져와서 text박스에 바인딩
                txtOrderNo.Text = currentInfo;
                orderInfo = srv.UpdateOrder(currentInfo);
                OrderDTO selProduct = orderInfo.FirstOrDefault((p) => p.Order_id == currentInfo);
                if (selProduct != null)
                {
                    txtOrderNo.Text = selProduct.Order_id.ToString();
                    txtEmpID.Text = selProduct.Emp_name;
                    //txtSumAmount.Text = selProduct.TotAmount.ToString("#,##0.###");
                    txtClientName.Text = selProduct.Company_name;
                    dtpOrderDate.Value = DateTime.Parse(selProduct.Order_date);
                    dtpRequestDate.Value = DateTime.Parse(selProduct.Order_dueDate);
                    Product_id = selProduct.Product_id;
                }
            }
        }
        #endregion

        #region 발주등록Load
        private void LoadOrderB()
        {
            panMenuP.Location = new Point(209, 297);
            label1.Text = "신규발주 등록";
            lblOrderNo.Text = "발주번호";
            lblOrderDate.Text = "발주일자";
            lblRequestDate.Text = "입고예정일자";
            lblAmount.Visible = txtSumAmount.Visible = lblPAmount.Visible = txtProductPrice.Visible = lblTotAmount.Visible = txtTotAmount.Visible = false;
            CommonList = srv.GetCategory("MATE");
            CommonCodeUtil.ComboBinding(cboCategory, CommonList, "MATE");
            DataGridViewUtil.SetDgv(dgvDetails);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "카테고리", "product_category", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "자재명", "product_name", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetails, "자재수량", "product_Qty", 200);
        }
        #endregion

        #region 발주- 등록수정
        private void LoadOrderBInfo()
        {
            if (mode == "Regist")
            {
                dtpOrderDate.Value = DateTime.Now;
                dtpRequestDate.Value = DateTime.Now.AddDays(7);
            }
            else if (mode == "Update")
            {
                string OrderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd");
                orderDetails = srv.GetPurchaseDetail(currentInfo);
                dgvDetails.DataSource = null;
                dgvDetails.DataSource = orderDetails;
                txtClientName.Enabled = false;
                dtpOrderDate.Enabled = false;
                txtOrderNo.Text = currentInfo;
                purchaseInfo = srv.Updatepurchase(currentInfo);
                PurchaseDTO selProduct = purchaseInfo.FirstOrDefault((p) => p.Purchase_id == currentInfo);
                if (selProduct != null)
                {
                    txtOrderNo.Text = selProduct.Purchase_id.ToString();
                    txtEmpID.Text = selProduct.Emp_name;
                    txtClientName.Text = selProduct.Company_name;
                    dtpOrderDate.Value = DateTime.Parse(selProduct.Purchase_date);
                    dtpRequestDate.Value = DateTime.Parse(selProduct.Purchase_dueDate);
                }
            }
        }
        #endregion

        #region Category_Selected
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex < 1) return;

            if (text == "주문관리")
            {
                if (productList == null) productList = srv.GetProductAllList();
                var selProdList = (from prod in productList
                                   where prod.name == cboCategory.Text
                                   select new CommonCodeDTO
                                   {
                                       Code = prod.product_id,
                                       Name = prod.product_name,
                                       Category = "product_name"
                                   }).ToList();
                CommonCodeUtil.ComboBinding(cboProductName, selProdList, "product_name");
            }
            else
            {
                if (materialList == null) materialList = srv.GetMaterialAllList();

                var selProdList = (from mate in materialList
                                   where mate.name == cboCategory.Text
                                   select new CommonCodeDTO
                                   {
                                       Code = mate.Material_id,
                                       Name = mate.Material_name,
                                       Category = "Material_name"
                                   }).ToList();
                CommonCodeUtil.ComboBinding(cboProductName, selProdList, "Material_name");
            }
            cboProductName.SelectedIndex = 0;
            nudCnt.Value = 0;
            txtStock.Text = "0";
        }
        #endregion

        #region ProductName_Selected
        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductName.SelectedIndex < 1) return;
            string selProdID = cboProductName.Text;

            if (text == "주문관리")
            {
                ProductDTO selProduct = productList.FirstOrDefault((p) => p.product_name == selProdID);
                if (selProduct != null)
                {
                    txtStock.Text = selProduct.product_Qty.ToString(); //재고
                    txtProductPrice.Text = selProduct.product_price.ToString("#,##0.###"); //제품가격
                    txtTotAmount.Text = (selProduct.product_Qty * selProduct.product_price).ToString("#,##0.###"); //제품별 주문 합산금액
                    nudCnt.Value = selProduct.product_QtyLimit; //주문단위수량
                    nudCnt.Increment = (selProduct.product_QtyLimit > 0) ? selProduct.product_QtyLimit : 1; //0이면 증가값:1씩증가 
                    Product_id = selProduct.product_id.ToString();
                }
                else
                {
                    txtStock.Text = txtTotAmount.Text = txtProductPrice.Text = "0";
                    nudCnt.Value = 0;
                }
            }
            else
            {
                MaterialDTO selProduct = materialList.FirstOrDefault((p) => p.Material_name == selProdID);
                if (selProduct != null)
                {
                    txtStock.Text = selProduct.Material_Qty.ToString(); //재고
                    Product_id = selProduct.Material_id.ToString();
                }
                else
                {
                    txtStock.Text = "0";
                    nudCnt.Value = 0;
                }
            }
        }
        #endregion

        #region nudCnt_ValueChanged
        private void nudCnt_ValueChanged(object sender, EventArgs e)
        {
            if (text == "주문관리")
            {
                txtTotAmount.Text = (int.Parse(txtProductPrice.Text.Replace(",", "")) * int.Parse(nudCnt.Value.ToString())).ToString("#,##0.###");
                if (nudCnt.Value > 1000)
                {
                    MessageBox.Show("수량을 다시 확인해주십시오.");
                    nudCnt.Value = 0;
                }
            }
        }
        #endregion

        #region btnInsert
        private void btnInsert_BtnClick_1(object sender, EventArgs e)
        {
            if (text == "주문관리")
            {
                if (cboCategory.SelectedIndex < 1 || cboProductName.SelectedIndex < 1 || nudCnt.Value < 1)
                {
                    MessageBox.Show("주문하실 제품을 선택하여 주십시오.");
                    return;
                }
                if (orderDetails == null) orderDetails = new List<OrderDetailDTO>();


                //장바구니에 담겨진 제품이면 수량변경 : 그렇지 않으면 추가
                string ProductName = cboProductName.Text;
                int idx = orderDetails.FindIndex((p) => p.product_name == ProductName);
                if (idx >= 0)
                    orderDetails[idx].product_Qty += (int)nudCnt.Value;
                else
                {
                    OrderDetailDTO newItem = new OrderDetailDTO
                    {
                        product_category = cboCategory.Text,
                        product_name = cboProductName.Text,
                        product_price = Convert.ToInt32(txtProductPrice.Text.Replace(",", "")),
                        product_Qty = (int)nudCnt.Value,
                        TotAmount = Convert.ToInt32(txtTotAmount.Text.Replace(",", "")),
                        Product_id = Product_id
                    };
                    orderDetails.Add(newItem);
                    dgvDetails.DataSource = null;
                    dgvDetails.DataSource = orderDetails;
                    dgvDetails.ClearSelection();
                }
                int total = dgvDetails.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells["TotAmount"].Value));
                txtSumAmount.Text = total.ToString("#,##0.###") + "원";
            }
            else //발주
            {
                if (cboCategory.SelectedIndex < 1 || cboProductName.SelectedIndex < 1)
                {
                    MessageBox.Show("주문하실 자재를 선택하여 주십시오.");
                    return;
                }
                else if (nudCnt.Value < 1)
                {
                    MessageBox.Show("수량을 입력하여 주십시오.");
                    return;
                }
                if (orderDetails == null) orderDetails = new List<OrderDetailDTO>();

                string ProductName = cboProductName.Text;
                int idx = orderDetails.FindIndex((p) => p.product_name == ProductName);
                if (idx >= 0) orderDetails[idx].product_Qty += (int)nudCnt.Value;
                else
                {
                    OrderDetailDTO newItem = new OrderDetailDTO
                    {
                        product_category = cboCategory.Text,
                        product_name = cboProductName.Text,
                        product_Qty = (int)nudCnt.Value,
                        Product_id = Product_id
                    };
                    orderDetails.Add(newItem);
                    dgvDetails.DataSource = null;
                    dgvDetails.DataSource = orderDetails;
                    dgvDetails.ClearSelection();
                }
            }
            dgvDetails.DataSource = null;
            dgvDetails.DataSource = orderDetails;
            btnRefresh_BtnClick(null, null);
        }
        #endregion

        #region btnSave
        private void btnSave_BtnClick_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text) || string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("기본정보를 입력하여 주십시오.");
                return;
            }

            if (text == "주문관리")
            {
                if (mode == "Regist") //주문등록
                {
                    OrderDTO order = new OrderDTO
                    {
                        Order_date = dtpOrderDate.Value.ToString("yyyy-MM-dd"),
                        Order_dueDate = dtpRequestDate.Value.ToString("yyyy-MM-dd"),
                        Company_name = txtClientName.Text,
                        Emp_name = txtEmpID.Text,
                        First_writeEmp = empID,
                        Latest_writeEmp = empID
                    };
                    bool result = srv.AddOrder(order, orderDetails);
                    if (result) this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (mode == "Update") //주문수정
                {
                    bool result = srv.UpdateOrderDetail(currentInfo, txtEmpID.Text, dtpRequestDate.Value.ToString("yyyy-MM-dd"), empID, orderDetails);
                    if (result) this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                if (mode == "Regist") //발주등록
                {
                    PurchaseDTO Purchase = new PurchaseDTO
                    {
                        Purchase_id = dtpOrderDate.Value.ToString("yyyy-MM-dd"),
                        Purchase_dueDate = dtpRequestDate.Value.ToString("yyyy-MM-dd"),
                        Company_name = txtClientName.Text,
                        Emp_name = txtEmpID.Text,
                        First_writeEmp = empID,
                        Latest_writeEmp = empID
                    };
                    bool result = srv.Addpurchase(Purchase, orderDetails);
                    if (result) this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (mode == "Update") //발주수정
                {
                    bool result = srv.UpdatePurchaseDetail(currentInfo, txtEmpID.Text, dtpRequestDate.Value.ToString("yyyy-MM-dd"), empID, orderDetails);
                    if (result) this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            this.Close();
        }
        #endregion

        #region btnRefresh
        private void btnRefresh_BtnClick(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == 0) return;
            txtStock.Text = txtTotAmount.Text = txtProductPrice.Text = "0";
            nudCnt.Value = 0;
            cboCategory.SelectedIndex = cboProductName.SelectedIndex = 0;
        }
        #endregion

        #region btnClientName
        private void btnClientName_BtnClick(object sender, EventArgs e)
        {
            frmSearchCompanyPop pop = new frmSearchCompanyPop();
            if (pop.ShowDialog() == DialogResult.OK) txtClientName.Text = pop.CompanyNameInfo.Company_name;
        }
        #endregion

        #region btnEmpID
        private void btnEmpID_BtnClick(object sender, EventArgs e)
        {
            frmSearchEmpPop pop = new frmSearchEmpPop();
            if (pop.ShowDialog() == DialogResult.OK) txtEmpID.Text = pop.EmployeeNameInfo.emp_name;
        }
        #endregion

        #region btnClose
        private void btnClose_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btnDelete
        private void btnDelete_BtnClick(object sender, EventArgs e)
        {
            if (text == "주문관리")
            {
                if (dgvDetails.GetCellCount(DataGridViewElementStates.Selected) == 0)
                {
                    MessageBox.Show("삭제하실 제품을 선택하여 주십시오.");
                    return;
                }
                string msg = $"{dgvDetails["product_name", dgvDetails.SelectedRows[0].Index].Value}제품을 장바구니에서 삭제하시겠습니까?";
                if (MessageBox.Show(msg, "장바구니삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string proNM = dgvDetails.SelectedRows[0].Cells["product_name"].Value.ToString();
                    int idx = orderDetails.FindIndex((p) => p.product_name == proNM);
                    if (idx >= 0)
                    {
                        orderDetails.RemoveAt(idx);
                        dgvDetails.DataSource = null;
                        dgvDetails.DataSource = orderDetails;
                        dgvDetails.ClearSelection();
                    }

                    txtSumAmount.Text = (int.Parse(txtSumAmount.Text.Replace(",", "").Replace("원", "")) - int.Parse(dgvDetails[5, dgvDetails.CurrentRow.Index].Value.ToString().Replace(",", ""))).ToString("#,##0.###") + "원";

                }
            }
            else
            {
                if (dgvDetails.GetCellCount(DataGridViewElementStates.Selected) == 0)
                {
                    MessageBox.Show("삭제하실 자재를 선택하여 주십시오.");
                    return;
                }
                string msg = $"{dgvDetails["product_name", dgvDetails.SelectedRows[0].Index].Value}제품을 장바구니에서 삭제하시겠습니까?";
                if (MessageBox.Show(msg, "장바구니삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string proNM = dgvDetails.SelectedRows[0].Cells["product_name"].Value.ToString();

                    int idx = orderDetails.FindIndex((p) => p.product_name == proNM);
                    if (idx >= 0)
                    {
                        orderDetails.RemoveAt(idx);
                        dgvDetails.DataSource = null;
                        dgvDetails.DataSource = orderDetails;
                        dgvDetails.ClearSelection();
                    }
                }
            }
        }
        #endregion
    }
}