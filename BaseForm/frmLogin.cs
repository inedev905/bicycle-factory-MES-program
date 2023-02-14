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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();            
        }

        //private void placeholderTextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtBarcode.Text.Length >= 12)
        //    {
        //        string empBarcode = txtBarcode.Text;

        //        EmployeeService srv = new EmployeeService();
        //        EmployeeDTO empInfo = srv.GetLoginEmpInfo(empBarcode);

        //        if (empInfo == null)
        //        {
        //            MessageBox.Show("바코드가 올바르지 않습니다. 다시 시도하여 주십시오.");
        //            return;
        //        }

        //        ((frmMain)this.Owner).LoginEmpInfo = empInfo;
        //        this.DialogResult = DialogResult.OK;
        //        this.Close();
        //    }
        //}

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //txtBarcode.Text = "221222171137";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBarcode.Text.Trim().Length >= 12)
                {
                    string empBarcode = txtBarcode.Text.Trim();

                    MessageBox.Show(empBarcode);

                    EmployeeService srv = new EmployeeService();
                    EmployeeDTO empInfo = srv.GetLoginEmpInfo(empBarcode);

                    if (empInfo == null)
                    {
                        MessageBox.Show("바코드가 올바르지 않습니다. 다시 시도하여 주십시오.");
                        //return;
                    }
                    else
                    {
                        ((frmMain)this.Owner).LoginEmpInfo = empInfo;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
