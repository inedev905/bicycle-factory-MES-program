using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2DTO;

namespace Team2
{
    public partial class frmShippments : Team2.frmListList
    {
        List<TotCountDTO> totCountList = null;
        List<OrderDTO> totOrderList = null;
        List<OrderDetailDTO> totOrderDtList = null;
        List<OrderDetailDTO> SelectedOrderDtList = null;
        List<ProductionDTO> ProductionList = null;
        ProductionService productionService = null;
        List<OutProductDTO> LeftProduct = null;
        int loginedEmp;
        bool isShip;

        public frmShippments()
        {
            InitializeComponent();
        }

        private void frmShippments_Load(object sender, EventArgs e)
        {
            loginedEmp = ((frmMain)this.MdiParent).LoginEmpInfo.emp_id;
            LeftProduct = new List<OutProductDTO>();
            productionService = new ProductionService();
            // dgvTotCount 총 수량
            DataGridViewUtil.SetDgv(dgvTotCount);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotCount, "제품ID", "product_id");
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotCount, "제품명", "product_name", colWidth: 150,align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotCount, "보유수량", "product_Qty", colWidth: 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotCount, "주문수량", "totOrders_Qty", colWidth: 80);

            totCountList = productionService.SetTotCount();

            dgvTotCount.DataSource = totCountList;

            // dgvTotOrders 총 주문

            DataGridViewUtil.SetDgv(dgvTotOrders);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrders, "주문ID", "order_id");
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrders, "회사ID", "company_id");
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrders, "주문 날짜", "order_date", colWidth: 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrders, "마감 날짜", "order_dueDate", colWidth: 150);
            
            totOrderList = productionService.SetOrders();

            dgvTotOrders.DataSource = totOrderList;

            // dgvTotOrdersDT 총 주문 상세

            DataGridViewUtil.SetDgv(dgvTotOrdersDt);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrdersDt, "주문ID", "order_id");
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrdersDt, "제품ID", "product_id");
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrdersDt, "주문수량", "product_Qty");
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotOrdersDt, "보유수량", "product_price");

            totOrderDtList = productionService.SetOrdersDt();

            dgvTotOrdersDt.DataSource = SelectedOrderDtList;


            // dgvTotProduction 총 생산 량

            DataGridViewUtil.SetDgv(dgvTotProduction);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotProduction, "생산지시ID", "produceOrd_id",colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotProduction, "제품이름", "product_name", colWidth: 150, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotProduction, "제조수량", "planQty");
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotProduction, "상태", "productionState", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvTotProduction, "완료일", "fullProductionDate", colWidth: 120);

            ProductionList = productionService.SetProduction();

            dgvTotProduction.DataSource = ProductionList;

        }

        private void dgvTotOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedOrderDtList = totOrderDtList.FindAll((dt) => dt.Order_id == dgvTotOrders["order_id", e.RowIndex].Value.ToString());

            dgvTotOrdersDt.DataSource = SelectedOrderDtList;
            dgvTotOrdersDt.Update();
        }

       

        private void dgvTotOrdersDt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                isShip = true;
            }
            if (e.ColumnIndex == 3)
            {
                if((Convert.ToInt32(e.Value) - Convert.ToInt32(dgvTotOrdersDt["product_Qty", e.RowIndex].Value)) >= 0)
                {
                    dgvTotOrdersDt.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; 
                }
                else
                {
                    dgvTotOrdersDt.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                    isShip = false;
                }
            }

        }

        private void dgvTotProduction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (dgvTotProduction[e.ColumnIndex,e.RowIndex].Value.ToString() == "작업 완료")
                {
                    dgvTotProduction.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }


        private void ucOutBtn_BtnClick(object sender, EventArgs e)
        {
            if (isShip)
            {
                OutProductDTO outOrder = new OutProductDTO();
                List < ProductSet > products = new List<ProductSet>();

                foreach (var orderDt in SelectedOrderDtList)
                {
                    if ((orderDt.product_price - orderDt.product_Qty) < 0)
                    {
                        isShip = false;
                        return;
                    }
                    ProductSet item = new ProductSet();
                    item.ProductID = orderDt.Product_id;
                    item.LeftQty = orderDt.product_price - orderDt.product_Qty;
                    products.Add(item);
                }
                outOrder.OrderID = SelectedOrderDtList[0].Order_id;
                outOrder.loginedEmpID = loginedEmp;
                outOrder.ProductSets = products;
                LeftProduct.Add(outOrder);

                bool result = productionService.Shipment(LeftProduct);

                if (result)
                {
                    MessageBox.Show($"주문번호 - {SelectedOrderDtList[0].Order_id}, 출하 되었습니다.");
                }
                else
                {
                    //에러
                }

                totCountList = productionService.SetTotCount();
                dgvTotCount.DataSource = totCountList;
                dgvTotCount.Update();

                totOrderList = productionService.SetOrders();
                dgvTotOrders.DataSource = totOrderList;
                dgvTotOrders.Update();

                totOrderDtList = productionService.SetOrdersDt();
                dgvTotOrdersDt.DataSource = SelectedOrderDtList;
                dgvTotOrdersDt.Update();
            }
            else
            {
                MessageBox.Show("자전거가 부족합니다.");
            }
        }

        private void ucInProductedBike_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvTotProduction.SelectedRows[0].Cells[3].Value.ToString() == "작업 완료")
                {
                    OutProductDTO outOrder = new OutProductDTO();
                    List<ProductSet> products = new List<ProductSet>();

                    ProductSet item = new ProductSet();
                    item.ProductID = dgvTotProduction.SelectedRows[0].Cells[1].Value.ToString();
                    item.LeftQty = Convert.ToInt32(dgvTotProduction.SelectedRows[0].Cells[2].Value);
                    products.Add(item);

                    outOrder.OrderID = dgvTotProduction.SelectedRows[0].Cells[0].Value.ToString();
                    outOrder.loginedEmpID = loginedEmp;
                    outOrder.ProductSets = products;
                    LeftProduct.Add(outOrder);

                    bool result = productionService.TakeProduct(LeftProduct);

                    if (result)
                    {
                        MessageBox.Show($"생산번호 - {dgvTotProduction.SelectedRows[0].Cells[0].Value.ToString()}, 해당 완제품이 입고 되었습니다.");
                    }
                    else
                    {
                        //에러
                    }

                    totCountList = productionService.SetTotCount();
                    dgvTotCount.DataSource = totCountList;
                    dgvTotCount.Update();

                    ProductionList = productionService.SetProduction();
                    dgvTotProduction.DataSource = ProductionList;
                    dgvTotProduction.Update();
                }
                else
                {
                    MessageBox.Show("작업 진행 중 입니다.");
                }
            }
            catch
            {
                MessageBox.Show("선택된 데이터가 없습니다.");
            }
        }
    }
}
