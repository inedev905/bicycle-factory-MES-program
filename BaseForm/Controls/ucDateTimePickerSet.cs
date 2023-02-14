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
    public partial class ucDateTimePickerSet : UserControl
    {
        public event EventHandler StartValueChange;
        public event EventHandler EndValueChange;

        public DateTime StartDate { get { return dtpStart.Value; } set { dtpStart.Value = value; } }
        public DateTime EndDate { get { return dtpEnd.Value; } set { dtpEnd.Value = value; } }


        public ucDateTimePickerSet()
        {
            InitializeComponent();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (StartValueChange != null)
            {
                StartValueChange(this, e);
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (EndValueChange != null)
            {
                EndValueChange(this, e);
            }
        }
    }
}
