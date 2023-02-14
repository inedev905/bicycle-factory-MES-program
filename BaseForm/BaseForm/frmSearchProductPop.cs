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
    public partial class frmSearchProductPop : frmPop
    {
        public ProductDTO ProductInfo { get; set; }
        List<ProductDTO> prodList;        
        

        public frmSearchProductPop()
        {
            InitializeComponent();
        }

        private void frmSearchProductPop_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetDgv(dgvProd);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProd, "제품코드", "product_id", 150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvProd, "제품명", "product_name", 250, DataGridViewContentAlignment.MiddleLeft);

            ProductService srv = new ProductService();
            prodList = srv.GetAllProduct();
            dgvProd.DataSource = prodList;
        }

        private void dgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string prodID = dgvProd["product_id", e.RowIndex].Value.ToString();
            ProductInfo = prodList.Find((p) => p.product_id == prodID);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ucCloseButton1_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                dgvProd.DataSource = null;
                dgvProd.DataSource = prodList;
            }
            else
            {
                dgvProd.DataSource = prodList.FindAll((p) => p.product_name.ToLower().Contains(txtKeyword.Text.ToLower()));
            }                                        
        }

        private void lblComment_Click(object sender, EventArgs e)
        {
            lblComment.Visible = false;
            txtKeyword.Focus();
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            lblComment.Visible = false;
            txtKeyword.Focus();
        }
    }
}
