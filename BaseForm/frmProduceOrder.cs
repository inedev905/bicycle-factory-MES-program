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
using Team2.Util;
using System.Text.RegularExpressions;

namespace Team2
{
    public partial class frmProduceOrder : Team2.frmListList2
    {
        ProductionOrderService srv = new ProductionOrderService();
        List<BOMDTO> materialList1 = new List<BOMDTO>();
        List<BOMDTO> materialList2 = new List<BOMDTO>();
        List<ProducePlanDTO> produceDetailList = new List<ProducePlanDTO>();
        string pid;
        bool firstLoad = true;

        public frmProduceOrder()
        {
            InitializeComponent();
        }

        private void frmProduceOrder_Load(object sender, EventArgs e)
        {
            LoadData();
            lblDate.Text = DateTime.Now.ToString("yy-MM-dd") + " 생산지시 작성";
        }

        private void LoadData()
        {
            if (firstLoad)
            {
                DataGridViewUtil.SetDgv(dgvPlanDetail);
                DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "제품코드", "product_id", 180);
                DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "제품명", "product_name", 249);
                DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "생산 계획량", "PlanQty", 160, align: DataGridViewContentAlignment.MiddleRight);
                DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "생산 가능량", "nPlanQty", 160, align: DataGridViewContentAlignment.MiddleRight);
                DataGridViewUtil.AddGridTextBoxColumn(dgvPlanDetail, "총 지시 수량", "productionOrder_Qty", 160, align: DataGridViewContentAlignment.MiddleRight);
                dgvPlanDetail.AllowUserToResizeRows = dgvPlanDetail.AllowUserToResizeColumns = false;

                DataGridViewUtil.SetDgv(dataGridView1);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "생산계획상세코드", "producePlanDetail_id", 180);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "제품코드", "product_id", 160);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "제품명", "product_name", 249);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "생산 계획량", "PlanQty", 160, align: DataGridViewContentAlignment.MiddleRight);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView1, "지시 수량 입력", "afterPlanQty", 160, align: DataGridViewContentAlignment.MiddleRight, readOnly: false);
                dataGridView1.AllowUserToResizeRows = dataGridView1.AllowUserToResizeColumns = false;

                DataGridViewUtil.SetDgv(dataGridView2);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "자재코드", "Item", 200);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "자재명", "Name", 310);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "자재 현재고", "Qty", 200, align: DataGridViewContentAlignment.MiddleRight);
                DataGridViewUtil.AddGridTextBoxColumn(dataGridView2, "자재 필요 수량", "Levels", 200, align: DataGridViewContentAlignment.MiddleRight);
                dataGridView2.AllowUserToResizeRows = dataGridView2.AllowUserToResizeColumns = false;

                DataGridViewUtil.SetDgv(dgvOrderDetail1);
                DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail1, "자재코드", "Item", 200);
                DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail1, "자재명", "Name", 310);
                DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail1, "자재 현재고", "Qty", 200, align: DataGridViewContentAlignment.MiddleRight);
                DataGridViewUtil.AddGridTextBoxColumn(dgvOrderDetail1, "자재 필요 수량", "Levels", 200, align: DataGridViewContentAlignment.MiddleRight);
                dgvPlanDetail.AllowUserToResizeRows = dgvPlanDetail.AllowUserToResizeColumns = false;
                firstLoad = false;
            }

            List<ProducePlanDTO> list1 = srv.GetProductionPlanList1();
            produceDetailList = srv.GetProductionPlanList2();

            dgvPlanDetail.DataSource = null;
            dgvPlanDetail.DataSource = list1;

            dgvOrderDetail1.DataSource = null;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e) //생산지시 생성
        {
            //유효성 검사
            if (dgvOrderDetail1.DataSource == null)
            {
                MessageBox.Show("자재 소요 확인을 먼저 진행해주세요.");
                return;
            }
            //문자 삭제, 빈 칸 자동으로 0으로 채우기
            foreach (DataGridViewRow row in dgvPlanDetail.Rows)
            {
                object val = row.Cells["productionOrder_Qty"].Value;
                if (row.Cells["productionOrder_Qty"].Value == null)
                    row.Cells["productionOrder_Qty"].Value = 0;
                try
                {
                    int.Parse(row.Cells["productionOrder_Qty"].Value.ToString());
                }
                catch
                {
                    row.Cells["productionOrder_Qty"].Value = 0;
                }

                if(Convert.ToInt32(row.Cells["productionOrder_Qty"].Value) < 0)
                    row.Cells["productionOrder_Qty"].Value = 0;
            }

            //생산가능량 < 생산량 -> error
            List<BOMDTO> overList = materialList1.FindAll((s) => s.Qty < s.Levels);
            if(overList.Count > 0)
            {
                MessageBox.Show($"지시 수량이 생산 가능 수량보다 많은 제품이 있습니다.");
                return;
            }

            if (MessageBox.Show("입력한 수량만큼 생산지시를 생성하시겠습니까?", "생산지시 생성", MessageBoxButtons.YesNo)
                == DialogResult.No)
                return;

            List<ProductionOrderDTO> list = new List<ProductionOrderDTO>();
            for (int i = 0; i < dgvPlanDetail.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvPlanDetail.Rows[i].Cells["productionOrder_Qty"].Value) == 0)
                    continue;

                list.Add(new ProductionOrderDTO
                {
                    product_id = dgvPlanDetail.Rows[i].Cells["product_id"].Value.ToString(),
                    planQty = Convert.ToInt32(dgvPlanDetail.Rows[i].Cells["productionOrder_Qty"].Value)
                });
            }

            bool result = srv.InsertProductionOrder(list, produceDetailList, materialList1.FindAll((s)=>s.Levels > 0));
            if (!result)
            {
                MessageBox.Show("생산지시 생성에 실패하였습니다.");
            }
            else
            {
                MessageBox.Show("생산지시를 정상적으로 생성하였습니다.");
                LoadData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> tmpList = new Dictionary<string, int>();
            foreach (DataGridViewRow row in dgvPlanDetail.Rows)
            {
                int planQty = Convert.ToInt32(row.Cells["PlanQty"].Value);
                int maxQty = Convert.ToInt32(row.Cells["nPlanQty"].Value);
                int temp = 0;

                if (!tmpList.ContainsKey(row.Cells["product_id"].Value.ToString()))
                {
                    temp = planQty > maxQty ? maxQty : planQty;
                    tmpList.Add(row.Cells["product_id"].Value.ToString(),
                        maxQty - temp); // 딕셔너리에 더 생산할 수 있는 양 저장
                }
                else
                {
                    temp = planQty > tmpList[row.Cells["product_id"].Value.ToString()] ? tmpList[row.Cells["product_id"].Value.ToString()] : planQty;
                    tmpList[row.Cells["product_id"].Value.ToString()] -= temp;
                }

                row.Cells["productionOrder_Qty"].Value = temp;
            }
        }

        private void dgvPlanDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlanDetail.SelectedRows.Count < 1) return;
            pid = dgvPlanDetail.SelectedRows[0].Cells["product_id"].Value.ToString();
            dataGridView1.DataSource = produceDetailList.FindAll((s) => s.product_id == pid);

            if(materialList2.Count < 1)
            {
                return;
            }
            else
            {
                dataGridView2.DataSource = materialList2.FindAll((s) => s.Category == dgvPlanDetail.SelectedRows[0].Cells["product_id"].Value.ToString());
            }

            foreach (DataGridViewRow row1 in dataGridView2.Rows)
            {
                row1.DefaultCellStyle.BackColor = Color.White;

                if (Convert.ToInt32(row1.Cells["Levels"].Value) > Convert.ToInt32(row1.Cells["Qty"].Value))
                    row1.DefaultCellStyle.BackColor = Color.IndianRed;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> tmpList = new Dictionary<string, int>();
            foreach (DataGridViewRow row in dgvPlanDetail.Rows)
            {
                if (!tmpList.ContainsKey(row.Cells["product_id"].Value.ToString()))
                {
                    tmpList.Add(row.Cells["product_id"].Value.ToString(), Convert.ToInt32(row.Cells["productionOrder_Qty"].Value));
                }
                else
                {
                    tmpList[row.Cells["product_id"].Value.ToString()] -= Convert.ToInt32(row.Cells["productionOrder_Qty"].Value);
                }

                materialList2 = srv.getMaterialList(tmpList);
                
                Dictionary<string, string> newDic = new Dictionary<string, string>();
                for (int i = 0; i < materialList2.Count; i++)
                {
                    if (!newDic.ContainsKey(materialList2[i].Item))
                    {
                        newDic.Add(materialList2[i].Item, $"{materialList2[i].Name}@{materialList2[i].Qty}@{materialList2[i].Levels}");
                    }
                    else
                    {
                        string[] tmpStrList = newDic[materialList2[i].Item].Split('@');
                        string tmplvl = (int.Parse(newDic[materialList2[i].Item].Split('@')[2]) + materialList2[i].Levels).ToString();
                        tmpStrList[2] = tmplvl;
                        newDic[materialList2[i].Item] = String.Join("@", tmpStrList);
                    }
                }

                materialList1 = new List<BOMDTO>();
                foreach (var item in newDic.Keys)
                {
                    materialList1.Add(new BOMDTO
                    {
                        Item = item,
                        Name = newDic[item].Split('@')[0],
                        Qty = int.Parse(newDic[item].Split('@')[1]),
                        Levels = int.Parse(newDic[item].Split('@')[2])
                    });
                }
                
                dgvOrderDetail1.DataSource = null;
                dgvOrderDetail1.DataSource = materialList1;

                dataGridView2.DataSource = null;

                foreach (DataGridViewRow row1 in dgvOrderDetail1.Rows)
                {
                    row1.DefaultCellStyle.BackColor = Color.White;

                    if (Convert.ToInt32(row1.Cells["Levels"].Value) > Convert.ToInt32(row1.Cells["Qty"].Value))
                        row1.DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPlanDetail.Rows)
            {
                row.Cells["productionOrder_Qty"].Value = null;
            }
            
            foreach (var item in produceDetailList)
            {
                item.afterPlanQty = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pid))
                return;
            int sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["afterPlanQty"].Value != null)
                {
                    produceDetailList.Find((s) => s.producePlanDetail_id == row.Cells["producePlanDetail_id"].Value.ToString()).nPlanQty = Convert.ToInt32(row.Cells["afterPlanQty"].Value);
                    sum += Convert.ToInt32(row.Cells["afterPlanQty"].Value);
                }
            }

            foreach (DataGridViewRow row in dgvPlanDetail.Rows)
            {
                if(row.Cells["product_id"].Value.ToString() == pid)
                {
                    row.Cells["productionOrder_Qty"].Value = sum;
                    row.DefaultCellStyle.BackColor = Color.White;

                    if (Convert.ToInt32(row.Cells["productionOrder_Qty"].Value) > Convert.ToInt32(row.Cells["nPlanQty"].Value))
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                    return;
                }
            }
        }

    }
}
