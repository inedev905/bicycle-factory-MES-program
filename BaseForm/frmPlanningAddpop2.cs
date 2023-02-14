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
    public partial class frmPlanningAddpop2 : frmPop
    {
        ProducePlanService srv = new ProducePlanService();
        List<OrderDetailDTO> detailList;
        public List<string> OrderIDs { get; private set; }

        public frmPlanningAddpop2()
        {
            InitializeComponent();
        }

        private void frmPlanningAddpop2_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetDgv(dgvOrder);
            DataGridViewCheckBoxColumn cbk = new DataGridViewCheckBoxColumn();
            cbk.Width = 30;
            dgvOrder.Columns.Add(cbk);

            DataGridViewUtil.SetDgv(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "주문번호", "Order_id", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "납기 요청일자", "Order_dueDate", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "거래처명", "Company_name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "주문일자", "Order_date", 200);

            DataGridViewUtil.SetDgv(dgvDetail);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "상세주문번호", "OrderDetail_id", 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "제품명", "product_name", 200);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "제품수량", "product_Qty", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvDetail, "Order_id", "Order_id", visible: false);

            List<OrderDTO> orders = srv.GetOrders();
            dgvOrder.DataSource = orders;
            
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string orderID = dgvOrder["Order_id", e.RowIndex].Value.ToString();
            
            if (detailList == null)
            {
                detailList = new List<OrderDetailDTO>();
                detailList = srv.GetOrderDetails();

                var list = detailList.FindAll((o) => o.Order_id == orderID);
                dgvDetail.DataSource = list;                
            }
            else
            {
                var list = detailList.FindAll((o) => o.Order_id == orderID);
                dgvDetail.DataSource = list;
            }
        }

        private void ucCloseButton1_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ucSaveButton1_BtnClick(object sender, EventArgs e)
        {
            List<string> orderIDs = new List<string>();

            foreach (DataGridViewRow dr in dgvOrder.Rows)
            {                
                if (Convert.ToBoolean(dr.Cells[0].Value))
                {
                    orderIDs.Add(dr.Cells["Order_id"].Value.ToString());
                }
            }

            if (orderIDs.Count < 1)
            {
                MessageBox.Show("주문서를 선택해주세요.");
                return;
            }

            OrderIDs = orderIDs;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
