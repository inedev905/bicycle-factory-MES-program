using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2.Services;
using Team2DTO;

namespace Team2
{
    public partial class frmProductionPlanning : frmList
    {
        ProducePlanService srv = new ProducePlanService();
        List<ProducePlanDTO> detailList;
        int empID;

        public frmProductionPlanning()
        {
            InitializeComponent();            
        }

        private void frmProductionPlanning_Load(object sender, EventArgs e)
        {
            empID = ((frmMain)this.MdiParent).LoginEmpInfo.emp_id;
            dtpSearchDate.StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSearchDate.EndDate = dtpSearchDate.StartDate.AddMonths(1).AddDays(-1);

            DataGridViewUtil.SetDgv(dgvPlan);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "생산계획번호", "producePlan_id", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "계획시작일", "planFromDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "계획종료일", "planToDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "총계획수량", "tot_planQty", 150);
            //DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "상태", "state", 130);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "등록일", "first_writeDate", 300);
            DataGridViewUtil.AddGridTextBoxColumn(dgvPlan, "수정일", "latest_writeDate", 300);

            
            DataGridViewCheckBoxColumn cbk = new DataGridViewCheckBoxColumn();
            cbk.Width = 30;
            dgvDetail.Columns.Add(cbk);
            cbk.Frozen = true;

            DataGridViewUtil.SetDgv(dgvDetail);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "계획일자", "planDate", 150, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "생산계획번호", "producePlan_id", 200, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "계획상세번호", "producePlanDetail_id", 200, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "품목코드", "product_id", 150, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "품목", "product_name", 250, DataGridViewContentAlignment.MiddleLeft, frozen: true);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "계획수량", "planQty", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "미작지수량", "nplanQty", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "납기일", "dueDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "생산구분", "produceCategory");
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "orderDetail_id", "orderDetail_id", visible: true);

            DataGridViewUtil.SetDgv(dgvDate);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDate, "계획일자", "planDate", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDate, "계획수량", "planQty", 120);

            LoadData();
        }

        private void LoadData()
        {
            List<List<ProducePlanDTO>> list = srv.GetPlan(dtpSearchDate.StartDate, dtpSearchDate.EndDate.AddDays(1));
            dgvDate.DataSource = list[0];
            dgvPlan.DataSource = list[1];

            detailList = null;
        }

        //품목 조회버튼
        private void ucSearchSmall1_BtnClick(object sender, EventArgs e)
        {
            frmSearchProductPop pop = new frmSearchProductPop();
            if (pop.ShowDialog(this) == DialogResult.OK)
            {
                txtProduct.Text = pop.ProductInfo.product_name;
            }
        }

        private void ucRefreshButton1_BtnClick(object sender, EventArgs e)
        {
            txtProduct.Text = "";
            dtpSearchDate.StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSearchDate.EndDate = dtpSearchDate.StartDate.AddMonths(1).AddDays(-1);
        }

        private void dgvPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (detailList == null)
            {
                detailList = new List<ProducePlanDTO>();
                detailList = srv.GetProducePlanDetail(dtpSearchDate.StartDate, dtpSearchDate.EndDate.AddDays(1));
            }

            string planID = dgvPlan["producePlan_id", e.RowIndex].Value.ToString();
            var list = detailList.FindAll((p) => p.producePlan_id == planID);

            dgvDetail.DataSource = null;
            dgvDetail.DataSource = list;
            dgvDate.ClearSelection();
        }

        private void dgvDate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (detailList == null)
            {
                detailList = new List<ProducePlanDTO>();
                detailList = srv.GetProducePlanDetail(dtpSearchDate.StartDate, dtpSearchDate.EndDate.AddDays(1));
            }

            DateTime planDate = Convert.ToDateTime(dgvDate["planDate", e.RowIndex].Value);
            var list = detailList.FindAll((p) => p.planDate == planDate);

            dgvDetail.DataSource = null;
            dgvDetail.DataSource = list;
            dgvPlan.ClearSelection();
        }

        private void ucUpdateButton1_BtnClick(object sender, EventArgs e)
        {
            if (dgvDetail.SelectedRows.Count < 1 || !Convert.ToBoolean(dgvDetail.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("수정할 제품을 선택하여 주십시오.");
                return;
            }

            int ridx = dgvDetail.CurrentRow.Index;
            string planDetailID = dgvDetail["producePlanDetail_id", ridx].Value.ToString();
            ProducePlanDTO planInfo = new ProducePlanDTO
            {
                orderDetail_id = Convert.ToInt32(dgvDetail["orderDetail_id", ridx].Value),
                planDate = Convert.ToDateTime(dgvDetail["planDate", ridx].Value),
                product_name = dgvDetail["product_name", ridx].Value.ToString(),
                planQty = Convert.ToInt32(dgvDetail["planQty", ridx].Value),
                dueDate = dgvDetail["dueDate", ridx].Value.ToString()
            };

            frmPlanningAddPop pop = new frmPlanningAddPop();
            pop.PlanInfo = planInfo;

            if (pop.ShowDialog() == DialogResult.OK)
            {
                int updateQty = pop.PlanInfo.planQty;
                DateTime updateDt = pop.PlanInfo.planDate;

                int idx = detailList.FindIndex((p) => p.producePlanDetail_id == planDetailID);
                if (pop.PlanInfo.produceCategory == "재고") //재고인 경우에만 수량 변경 가능함
                {
                    detailList[idx].planQty = updateQty;
                    detailList[idx].afterPlanQty = updateQty;
                }
                detailList[idx].planDate = updateDt;

                bool result = srv.UpdatePlan(detailList[idx], empID);
                if(result)
                {                    
                    dgvDate.DataSource = null;
                    dgvPlan.DataSource = null;
                    dgvDetail.DataSource = null;

                    LoadData();

                    MessageBox.Show("수정이 완료되었습니다.");                    
                }
                else
                {
                    MessageBox.Show("수정 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
                }
                
            }
        }

        private void ucDeleteButton1_BtnClick(object sender, EventArgs e)
        {
            if (dgvDetail.SelectedRows.Count < 1 || !Convert.ToBoolean(dgvDetail.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("삭제할 제품을 선택하여 주십시오.");
                return;
            }

            int ridx = dgvDetail.CurrentRow.Index;
            string planDetailID = dgvDetail["producePlanDetail_id", ridx].Value.ToString();
            int idx = detailList.FindIndex((p) => p.producePlanDetail_id == planDetailID);

            bool result = srv.DeletePlan(detailList[idx], empID);
            if (result)
            {
                dgvDate.DataSource = null;
                dgvPlan.DataSource = null;
                dgvDetail.DataSource = null;

                LoadData();

                MessageBox.Show("삭제가 완료되었습니다.");                
            }
            else
            {
                MessageBox.Show("삭제 중 오류가 발생하였습니다. 다시 시도하여 주십시오.");
            }                     
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            dgvDetail.EndEdit();

            bool isChk = Convert.ToBoolean(dgvDetail[0, e.RowIndex].Value);

            foreach (DataGridViewRow dr in dgvDetail.Rows)
            {
                dr.Cells[0].Value = false;
            }

            dgvDetail[0, e.RowIndex].Value = !isChk;
        }

        private void ucSearchButton1_BtnClick(object sender, EventArgs e)
        {
            DateTime startDt = dtpSearchDate.StartDate;
            DateTime endDt = dtpSearchDate.EndDate;
            TimeSpan ts = endDt - startDt;

            //생산계획일 유효성 체크
            if (startDt > endDt)
            {
                MessageBox.Show("조회기간이 유효하지 않습니다.");
                return;
            }

            if (ts.Days > 31)
            {
                MessageBox.Show("조회기간은 최대 한달까지 가능합니다.");
                return;
            }

            LoadData();

            string prodName = txtProduct.Text;
            if (!string.IsNullOrWhiteSpace(prodName)) //제품명 입력된 상태
            {
                detailList = srv.GetProducePlanDetail(startDt, endDt.AddDays(1));
                var selList = detailList.FindAll((p) => p.product_name == prodName);
                if (selList.Count < 1)
                {
                    dgvDate.DataSource = null;
                    dgvPlan.DataSource = null;
                    dgvDetail.DataSource = null;

                    MessageBox.Show("조회조건에 해당하는 데이터가 없습니다.");
                    return;
                }
                else
                {
                    dgvDetail.DataSource = selList;
                    dgvDate.ClearSelection();
                    dgvPlan.ClearSelection();
                }
            }

        }
    }
    
}
