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
    public partial class frmWaitAsyncPopup : Form
    {
        public Action Worker { get; set; }

        public frmWaitAsyncPopup(Action worker)
        {
            InitializeComponent();
            this.Worker = worker;
        }

        private void frmWaitAsyncPopup_Load(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(this.Worker);
            t1.ContinueWith((t) => this.Close(), TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
