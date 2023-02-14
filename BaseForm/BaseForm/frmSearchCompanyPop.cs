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
using Team2.Services;

namespace Team2
{
    public partial class frmSearchCompanyPop : frmPop
    {
        public CompanyDTO CompanyNameInfo { get; set; }

        List<CompanyDTO> CmpNMList;
        CompanyService srv = null;
        public frmSearchCompanyPop()
        {
            InitializeComponent();
        }


        private void frmSearchCompanyPop_Load(object sender, EventArgs e)
        {
            //company_id,CM.name business_category_NM, company_name ,phone,  business_category
            DataGridViewUtil.SetDgv(dgvCmpName);

            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpName, "NO", "company_id", 50);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpName, "구분", "business_category_NM", 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpName, "거래처 이름", "company_name", 170);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpName, "거래처 연락처", "phone", 170);
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpName, "거래처 구분코드", "business_category", visible:false);

            srv = new CompanyService();
            CmpNMList = srv.GetSearchCompany();
            dgvCmpName.DataSource = CmpNMList;
        }
        private void lblComment_Click(object sender, EventArgs e)
        {
            lblComment.Visible = false;
            txtKeyword.Focus();
        }

        private void dgvCmpName_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string NMcmp = dgvCmpName["company_name", e.RowIndex].Value.ToString();
            CompanyNameInfo = CmpNMList.Find((p) => p.Company_name == NMcmp);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ucBtnClose_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                dgvCmpName.DataSource = null;
                dgvCmpName.DataSource = CmpNMList;
            }
            else
            {
                dgvCmpName.DataSource = CmpNMList.FindAll((p) => p.Company_name.ToLower().Contains(txtKeyword.Text.ToLower()));
            }
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            lblComment.Visible = false;
            txtKeyword.Focus();
        }
    }
}
