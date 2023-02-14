using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2.Controls
{
    public partial class ucCancleButton : UserControl
    {
        public event EventHandler BtnClick;

        public ucCancleButton()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (BtnClick != null)
            {
                BtnClick(this, e);
            }
        }
    }
}
