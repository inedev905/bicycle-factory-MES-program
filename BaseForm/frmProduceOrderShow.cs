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

namespace Team2
{
    public partial class frmProduceOrderShow : frmList
    {
        ProductionOrderService srv = new ProductionOrderService();
        List<ProductionOrderDTO> originalList;
        List<ProductionOrderDTO> showList;

        public frmProduceOrderShow()
        {
            InitializeComponent();
        }

        private void frmProduceOrderShow_Load(object sender, EventArgs e)
        {
            dtpSearchDate.StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpSearchDate.EndDate = dtpSearchDate.StartDate.AddMonths(1).AddDays(-1);
            comboBox1.Items.Add("전체");
            comboBox1.Items.Add("도색");
            comboBox1.Items.Add("조립1");
            comboBox1.Items.Add("조립2");
            comboBox1.Items.Add("생산완료");
            comboBox1.SelectedIndex = 0;

            DataGridViewUtil.SetDgv(dgvOrder);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "생산지시코드", "produceOrd_id", 190);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "제품코드", "product_id", 190);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "제품명", "product_name", 400, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "담당직원코드", "emp_id", 190);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "담당직원명", "emp_name", 190);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "지시시작일", "orderFromDate", 280);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "목표생산량", "planQty", 190, align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvOrder, "생산단계", "level", 190);

            dgvOrder.AllowUserToResizeRows = dgvOrder.AllowUserToResizeColumns = false;

            originalList = srv.GetProductionOrders();
            showList = originalList;
            dgvOrder.DataSource = showList.FindAll((s) => s.level != "생산 완료");
        }

        private void ucRefreshButton2_BtnClick(object sender, EventArgs e)
        {
            showList = originalList;
            dgvOrder.DataSource = showList.FindAll((s) => s.level != "생산 완료");
            if (checkBox1.Checked) checkBox1.Checked = false;
        }

        private void ucSearchButton1_BtnClick(object sender, EventArgs e)
        {
            showList = originalList.FindAll((s) => Convert.ToDateTime(s.orderFromDate) >= dtpSearchDate.StartDate && Convert.ToDateTime(s.orderFromDate) <= dtpSearchDate.EndDate);
            
            if (!String.IsNullOrWhiteSpace(txtProduct.Text))
            {
                showList = showList.FindAll((s)=>s.product_name.Contains(txtProduct.Text));
            }
            
            if(comboBox1.SelectedIndex != 0)
            {
                showList = showList.FindAll((s) => s.level.Equals(comboBox1.Text));
            }
            
            if (!checkBox1.Checked)
            {
                showList = showList.FindAll((s) => s.level != "생산 완료");
            }
            dgvOrder.DataSource = showList;
        }
    }
}
