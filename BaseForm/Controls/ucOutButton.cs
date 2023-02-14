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
    public partial class ucOutButton : UserControl
    {
        public event EventHandler BtnClick;
        public ucOutButton()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (BtnClick != null)
            {
                BtnClick(this, e);
            }
        }
    }
}
