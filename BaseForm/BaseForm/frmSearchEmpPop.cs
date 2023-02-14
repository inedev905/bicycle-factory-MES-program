using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2DTO;
using Team2.Services;
using System.Linq;

namespace Team2
{
    public partial class frmSearchEmpPop : frmPop
    {
        public EmployeeDTO EmployeeNameInfo { get; set; }

        List<EmployeeDTO> EmpNMList;
        EmployeeService srv = null;
        public frmSearchEmpPop()
        {
            InitializeComponent();
        }

        private void frmSearchEmpPop_Load(object sender, EventArgs e)
        { 
            DataGridViewUtil.SetDgv(dgvEmpList);

            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "직원 명", "emp_name",120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "부서", "dep_name");
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "직책", "title_name");
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "연락처", "phone2",150);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "이메일", "email", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "부서코드", "dep_code",visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "직책코드", "title_code", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvEmpList, "직원ID", "emp_id", visible: false);

            srv = new EmployeeService();
            EmpNMList = srv.SearchEmpList();
            dgvEmpList.DataSource = EmpNMList;
        }

        private void dgvEmpList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string empNM = dgvEmpList["emp_name", e.RowIndex].Value.ToString();
            EmployeeNameInfo = EmpNMList.Find((E) => E.emp_name == empNM);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                dgvEmpList.DataSource = null;
                dgvEmpList.DataSource = dgvEmpList;
            }
            else
            {
                dgvEmpList.DataSource = EmpNMList.FindAll((E) => E.emp_name.ToLower().Contains(txtKeyword.Text.ToLower()));
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

        private void ucCloseButton1_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
