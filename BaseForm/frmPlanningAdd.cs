using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2.Services;
using Team2DTO;

namespace Team2
{
    public partial class frmPlanningAdd : frmList
    {
        ProducePlanService srv = new ProducePlanService();
        List<ProducePlanDTO> planList = new List<ProducePlanDTO>();
        List<ProducePlanDTO> detailList = new List<ProducePlanDTO>();

        int updateIdx;

        public List<string> orderID { get; set; }
        

        public frmPlanningAdd()
        {
            InitializeComponent();
        }


        private void frmPlanningAdd_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetDgv(dgvPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목코드", "product_id", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "품목", "product_name", 200, DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "계획수량", "planQty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "미계획수량", "nplanQty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "비고", "produceCategory");

            DataGridViewUtil.SetDgv(dgvPlanDetail);
            DataGridViewCheckBoxColumn cbk = new DataGridViewCheckBoxColumn();
            cbk.Width = 30;
            dgvPlanDetail.Columns.Add(cbk);
            cbk.Frozen = true;

            DataGridViewUtil.SetDgv(dgvPlanDetail);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "계획일자", "planDate", 150, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "품목코드", "product_id", 120, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "품목", "product_name", 200, DataGridViewContentAlignment.MiddleLeft, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "주문수량", "orderQty", 120);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "재고", "product_Qty");
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "계획수량", "planQty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "미계획수량", "nplanQty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "계획후재고", "afterPlanQty", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "납기일", "dueDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "orderDetail_id", "orderDetail_id", visible: false);

            dtpPlan.StartDate = DateTime.Today;
            dtpPlan.EndDate = DateTime.Today.AddDays(14);
            txtempName.Text = ((frmMain)this.MdiParent).LoginEmpInfo.emp_name;
            txtempName.Enabled = false;
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            if (orderID != null)
            {
                dgvPlan.DataSource = null;
                dgvPlanDetail.DataSource = null;
            }

            frmPlanningAddpop2 pop = new frmPlanningAddpop2();

            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                orderID = pop.OrderIDs;
                frmWaitAsyncPopup asyncpop = new frmWaitAsyncPopup(GetPlanningBinding);
                asyncpop.ShowDialog();
            }
        }

        private void GetPlanningBinding()
        {
            List<List<ProducePlanDTO>> planAllInfo = srv.GetPlan(orderID, dtpPlan.StartDate.ToShortDateString());

            planList = planAllInfo[0];
            detailList = planAllInfo[1];

            if (planAllInfo[0].Count < 1)
            {
                MessageBox.Show("계획일자에 해당하는 주문이 없습니다.");
                return;
            }

            DateTime min = detailList.Min((item) => item.planDate);
            DateTime max = detailList.Max((item) => item.planDate);

            this.Invoke(new Action(() => dtpPlan.StartDate = min));
            this.Invoke(new Action(() => dtpPlan.EndDate = max));
            this.Invoke(new Action(() => dgvPlan.DataSource = null));
            this.Invoke(new Action(() => dgvPlan.DataSource = planList));

            //this.Invoke(new Action(() => dgvPlanDetail.DataSource = null));
            //this.Invoke(new Action(() => dgvPlanDetail.DataSource = detailList));
            //this.Invoke(new Action(() => dgvPlanDetail.ClearSelection()));
        }

        private int GetPlanListIdx(string prodID, string prodCategory)
        {
            if (prodCategory == "주문") //주문건
            {
                return planList.FindIndex((p) => p.product_id == prodID && p.produceCategory.Equals("주문"));
            }
            else
            {
                return planList.FindIndex((p) => p.product_id == prodID && p.produceCategory.Equals("재고"));
            }
        }

        private void ucInsertButton1_BtnClick(object sender, EventArgs e)
        {
            frmSearchProductPop pop = new frmSearchProductPop();

            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                int idx = GetPlanListIdx(pop.ProductInfo.product_id, "재고");
                if (idx > -1) //이미 재고로 등록된 제품이 있는 경우
                {
                    planList[idx].planQty++;
                }
                else
                {
                    planList.Add(new ProducePlanDTO
                    {
                        product_id = pop.ProductInfo.product_id,
                        product_name = pop.ProductInfo.product_name,
                        planQty = 1,
                        produceCategory = "재고"
                    });
                }

                int dIdx = detailList.FindIndex((p) => p.product_id == pop.ProductInfo.product_id && p.orderQty == 0 && p.planDate == DateTime.Today);
                if (dIdx > -1) //오늘날짜로 계획된 재고가 있는 경우
                {
                    detailList[dIdx].planQty++;
                    detailList[dIdx].afterPlanQty++;
                }
                else
                {
                    detailList.Add(new ProducePlanDTO
                    {
                        planDate = DateTime.Today,
                        product_id = pop.ProductInfo.product_id,
                        product_name = pop.ProductInfo.product_name,
                        planQty = 1,
                        afterPlanQty = 1,
                        orderDetail_id = 0,
                        dueDate = ""
                    });
                }

                var list = FindAllDetailList(pop.ProductInfo.product_id, "재고");
                dgvReBinding(list);
            }
        }

        private void dgvReBinding(List<ProducePlanDTO> selList)
        {
            dgvPlan.DataSource = null;
            dgvPlan.DataSource = planList;
            dgvPlan.ClearSelection();

            dgvPlanDetail.DataSource = null;
            dgvPlanDetail.DataSource = selList;

            DateTime min = detailList.Min((item) => item.planDate);
            DateTime max = detailList.Max((item) => item.planDate);

            dtpPlan.StartDate = min;
            dtpPlan.EndDate = max;
        }

        private List<ProducePlanDTO> FindAllDetailList(string prodID, string prodCategory)
        {
            if (prodCategory == "주문")
            {
                return detailList.FindAll((p) => p.product_id == prodID && p.orderQty > 0)
                                    .OrderBy((p) => p.planDate).ToList();
            }
            else
            {
                return detailList.FindAll((p) => p.product_id == prodID && p.orderQty == 0)
                                                    .OrderBy((p) => p.planDate).ToList();
            }
        }

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string prodID = dgvPlan["product_id", e.RowIndex].Value.ToString();
            string prodCategory = dgvPlan["produceCategory", e.RowIndex].Value.ToString();

            var list = FindAllDetailList(prodID, prodCategory);

            dgvPlanDetail.DataSource = null;
            dgvPlanDetail.DataSource = list;
            dgvPlanDetail.ClearSelection();
        }

        private void dgvPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPlan["produceCategory", e.RowIndex].Value.Equals("주문"))
            {
                for (int c = 0; c < dgvPlan.ColumnCount; c++)
                {
                    dgvPlan[c, e.RowIndex].Style.BackColor = Color.MistyRose;
                }

            }
        }

        private void ucDeleteButton1_BtnClick(object sender, EventArgs e)
        {
            if (dgvPlanDetail.SelectedRows.Count < 1 || !Convert.ToBoolean(dgvPlanDetail.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("삭제할 제품을 선택하여 주십시오.");
                return;
            }

            int ridx = dgvPlanDetail.CurrentRow.Index;
            int planQty = Convert.ToInt32(dgvPlanDetail["planQty", ridx].Value);

            if (planQty < 1)
            {
                MessageBox.Show("계획수량이 0인 제품은 삭제가 불가합니다.");
                return;
            }

            if (MessageBox.Show($"{dgvPlanDetail["product_name", ridx].Value}의 계획을 삭제하시겠습니까?", "삭제확인", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string prodID = dgvPlanDetail["product_id", ridx].Value.ToString();
                DateTime planDt = Convert.ToDateTime(dgvPlanDetail["planDate", ridx].Value);
                int odID = Convert.ToInt32(dgvPlanDetail["orderDetail_id", ridx].Value);

                List<ProducePlanDTO> selList = null;

                if (odID == 0) //재고
                {
                    int cnt = (from p in detailList
                               where p.product_id == prodID && p.orderQty == 0
                               select p).Count();

                    int idx = GetPlanListIdx(prodID, "재고");
                    int didx = detailList.FindIndex((p) => p.product_id == prodID && p.orderQty == 0 && p.planDate == planDt);

                    if (cnt > 1)
                    {
                        planList[idx].planQty -= detailList[didx].planQty;
                        detailList.RemoveAt(didx);
                    }
                    else
                    {
                        planList.RemoveAt(idx);
                        detailList.RemoveAt(didx);

                    }
                    selList = FindAllDetailList(prodID, "재고");
                }
                else //주문
                {
                    string dueDate = dgvPlanDetail["dueDate", ridx].Value.ToString();

                    //디테일 먼저 삭제하고
                    int didx = detailList.FindIndex((p) => p.orderDetail_id == odID);
                    detailList.RemoveAt(didx);

                    //메인 삭제
                    int idx = planList.FindIndex((p) => p.product_id == prodID && p.produceCategory == "주문");
                    if (planList[idx].planQty - planQty == 0)
                    {
                        planList.RemoveAt(idx);
                    }
                    else
                    {
                        planList[idx].planQty -= planQty;
                    }

                    selList = FindAllDetailList(prodID, "주문");
                }

                MessageBox.Show("삭제가 완료되었습니다.");
                dgvReBinding(selList);
            }
        }

        private void ucUpdateButton1_BtnClick(object sender, EventArgs e)
        {
            if (dgvPlanDetail.SelectedRows.Count < 1 || !Convert.ToBoolean(dgvPlanDetail.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("수정할 제품을 선택하여 주십시오.");
                return;
            }

            int ridx = dgvPlanDetail.CurrentRow.Index;
            int planQty = Convert.ToInt32(dgvPlanDetail["planQty", ridx].Value); //수정전 수량

            if (planQty < 1)
            {
                MessageBox.Show("계획수량이 0인 제품은 수정이 불가합니다.");
                return;
            }

            int odID = Convert.ToInt32(dgvPlanDetail["orderDetail_id", ridx].Value);
            string prodID = dgvPlanDetail["product_id", ridx].Value.ToString();
            DateTime planDate = Convert.ToDateTime(dgvPlanDetail["planDate", ridx].Value);
            string dueDate = dgvPlanDetail["dueDate", ridx].Value.ToString();

            if (odID == 0) //재고
            {
                updateIdx = detailList.FindIndex((p) => p.product_id == prodID && p.orderQty == 0 && p.planDate == planDate);
            }
            else
            {
                updateIdx = detailList.FindIndex(((p) => p.orderDetail_id == odID));
            }

            ProducePlanDTO PlanInfo = new ProducePlanDTO
            {
                orderDetail_id = odID,
                planDate = planDate,
                product_name = dgvPlanDetail["product_name", ridx].Value.ToString(),
                planQty = planQty,
                dueDate = dueDate
            };

            frmPlanningAddPop pop = new frmPlanningAddPop();
            pop.PlanInfo = PlanInfo;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                DateTime updateDt = pop.PlanInfo.planDate;
                int updateQty = pop.PlanInfo.planQty;

                List<ProducePlanDTO> selList = null;
                if (pop.PlanInfo.produceCategory.Equals("주문"))
                {
                    detailList[updateIdx].planDate = updateDt;
                    selList = detailList.FindAll((p) => p.product_id == prodID && p.orderQty > 0).OrderBy((p) => p.planDate).ToList();
                }
                else //재고
                {
                    int cnt = (from p in detailList
                               where p.product_id == prodID && p.orderQty == 0
                               select p).Count();

                    int idx = planList.FindIndex(((p) => p.product_id == prodID && p.produceCategory == "재고"));

                    if (cnt < 1)
                    {
                        planList[idx].planQty = updateQty;
                    }
                    else
                    {
                        planList[idx].planQty -= detailList[updateIdx].planQty; //기존 계획수량 빼주고
                        planList[idx].planQty += updateQty; //업데이트된 수량 다시 더해주기
                    }

                    if (planDate != updateDt &&
                        (detailList.FindIndex((p) => p.product_id == prodID && p.orderQty == 0 && p.planDate == updateDt) != -1))
                    //날짜 수정했는데, 수정한 계획일자와 같은게 있는 경우
                    {
                        int didx = detailList.FindIndex((p) => p.product_id == prodID && p.orderQty == 0 && p.planDate == updateDt);

                        detailList[didx].planQty += updateQty;
                        detailList[didx].afterPlanQty += updateQty;
                        detailList.RemoveAt(updateIdx);
                    }
                    else
                    {
                        detailList[updateIdx].planQty = updateQty;
                        detailList[updateIdx].planDate = updateDt;
                        detailList[updateIdx].afterPlanQty = updateQty;
                    }

                    selList = detailList.FindAll((p) => p.product_id == prodID && p.orderQty == 0).OrderBy((p) => p.planDate).ToList();
                }

                MessageBox.Show("수정이 완료되었습니다.");
                dgvReBinding(selList);
            }
        }


        private void dgvPlanDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            dgvPlanDetail.EndEdit();

            bool isChk = Convert.ToBoolean(dgvPlanDetail[0, e.RowIndex].Value);

            foreach (DataGridViewRow dr in dgvPlanDetail.Rows)
            {
                dr.Cells[0].Value = false;
            }

            dgvPlanDetail[0, e.RowIndex].Value = !isChk;
        }

        private void ucSaveButton1_BtnClick(object sender, EventArgs e)
        {
            ProducePlanDTO plan = new ProducePlanDTO
            {
                planFromDate = dtpPlan.StartDate.ToString(),
                planToDate = dtpPlan.EndDate.ToString(),
                tot_planQty = planList.Sum((p) => p.planQty),
            };

            List<int> orderIDs = new List<int>();
            detailList.ForEach((o) => orderIDs.Add(o.orderDetail_id));

            int empID = ((frmMain)this.MdiParent).LoginEmpInfo.emp_id;
            bool result = srv.InsertProducePlanning(plan, detailList, orderIDs, empID);

            if (result)
            {
                dgvPlan.DataSource = null;
                dgvPlanDetail.DataSource = null;
                dtpPlan.StartDate = DateTime.Today;
                dtpPlan.EndDate = DateTime.Today.AddDays(14);
                planList.Clear();
                detailList.Clear();
                orderID.Clear();

                MessageBox.Show("저장이 완료되었습니다.");

                
            }
            else
            {
                MessageBox.Show("저장 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }
        }

        private void dtpPlan_StartValueChange(object sender, EventArgs e)
        {
            dtpPlan.EndDate = dtpPlan.StartDate.AddDays(14);
        }
    }
}
