using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2DTO;

namespace Team2
{
    public partial class frmPlanningAddPop : frmPop
    {
        public frmPlanningAddPop()
        {
            InitializeComponent();
        }

        public ProducePlanDTO PlanInfo 
        {
            get
            {
                return new ProducePlanDTO
                {
                    produceCategory = txtCategory.Text,
                    planDate = dtpPlan.Value,
                    planQty = (int)nudQty.Value,
                    orderDetail_id = Convert.ToInt32(lblodId.Text)
                };
            }
            set 
            {
                if (value.orderDetail_id == 0)
                {
                    txtCategory.Text = "재고";
                    lblodId.Text = "";
                    lbldueDate.Visible = false;
                }
                else
                {
                    txtCategory.Text = "주문";
                    lbldueDate.Text = $"[납기] {value.dueDate}";
                }
                
                txtProdName.Text = value.product_name;
                dtpPlan.Value = value.planDate;
                nudQty.Value = value.planQty;
                lblodId.Text = value.orderDetail_id.ToString();
            } 
        }

        private void ucCloseButton2_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmPlanningAddPop_Load(object sender, EventArgs e)
        {
            lblodId.Visible = false;

            if (txtCategory.Text.Equals("주문"))
            {
                nudQty.Enabled = false;
            }
            else
            {
                nudQty.Enabled = true;
            }
        }

        private void ucSaveButton2_BtnClick(object sender, EventArgs e)
        {
            if (nudQty.Value < 1)
            {
                MessageBox.Show("계획수량을 다시 입력하세요.");
                return;
            }

            if (txtCategory.Text.Equals("주문") && dtpPlan.Value >= Convert.ToDateTime(lbldueDate.Text.Substring(4)))
            {
                if (DialogResult.No == MessageBox.Show("계획일자가 주문납기 이후로 설정되었습니다. 그래도 변경하시겠습니까?", "변경확인", MessageBoxButtons.YesNo))
                    return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
