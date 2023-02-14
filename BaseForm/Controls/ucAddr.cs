using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2
{
    public partial class ucAddr : UserControl
    {
        public string ZipCode { get { return txtZip.Text; } set { txtZip.Text = value; } }
        public string Addr1 { get { return txtAddr1.Text; } set { txtAddr1.Text = value; } }
        public string Addr2 { get { return txtAddr2.Text; } set { txtAddr2.Text = value; } }

        public ucAddr()
        {
            InitializeComponent();
        }

        private void ucSearchSmall1_Load(object sender, EventArgs e)
        {
            ucSearchSmall1.BtnClick += UcSearchSmall1_BtnClick;
        }

        private void UcSearchSmall1_BtnClick(object sender, EventArgs e)
        {
            frmZipPop pop = new frmZipPop();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtZip.Text = pop.ZipCode;
                txtAddr1.Text = pop.Addr1;
                txtAddr2.Text = pop.Addr2;
            }
        }
    }
}
