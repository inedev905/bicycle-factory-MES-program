using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2DTO;
using Team2.Util;
using System.Linq;
using System.Drawing.Imaging;
using BarcodeLib;
using System.IO;

namespace Team2
{
    public partial class frmManagersHR : frmDetail
    {
        EmployeeService empService = null;
        List<EmployeeDTO> empList = null; // 직원 정보 리스트
        EmployeeDTO loginedEmployee = null; // 로그인 직원
        List<CommonCodeDTO> empCommonList = null; //공통 코드 리스트

        EmployeeDTO selected; // DGV에서 선택된 EMP 데이터

        public frmManagersHR()
        {
            InitializeComponent();
            empService = new EmployeeService();
            empCommonList = new List<CommonCodeDTO>();
            pnlInfo.Size = new Size(400, 100);
        }

        private void frmManagersHR_Load(object sender, EventArgs e)
        {
            // login 정보 가져오기
            loginedEmployee = ((frmMain)this.MdiParent).LoginEmpInfo;

            empCommonList = empService.SetEmpCommonData();

            SetDGV();

            empService = new EmployeeService();

            ucSBUpdata.Visible = false;

            // 데이터 로드

            CommonCodeUtil.ComboBinding(cbmDept, empCommonList, "DEPT");
            CommonCodeUtil.ComboBinding(cbmDeptSearch, empCommonList, "DEPT");
            CommonCodeUtil.ComboBinding(cbmPhone, empCommonList, "TELE");
            CommonCodeUtil.ComboBinding(cbmRank, empCommonList.FindAll((emp) => emp.Code == "r01" || emp.Code == "r02"), "RANK");
            CommonCodeUtil.ComboBinding(cbmAddr, empCommonList, "ADDR");

            // 1. 서버  >  dao > 서비스 > 폼, 직원 정보 가져오기
            // 3. 1번에서 가져온 직원 정보가 없을 수 없음(로그인한 사람 정보가 있으니)
            //    >> 직원 정보 리스트를 dgvHR에 로드
            
            empList = empService.LoadEmpData().FindAll((emp) => emp.emp_deleted == "N").ToList();
            SetEmpList();
            // 퇴사 처리

            // 4. 직원 정보 Row 1줄 추가



            // 2. 메인화면에서 로그인된 사람 정보 가져오기
            //loginedEmployee = 로그인된 사람 정보 가져오기


            // 
            // 5. 아이디를 더블 클릭 하면 옆으로 상세 데이터가 나타남 >> 상세 데이터는 ?
            // 6. 검색(아이디, 이름) / 부서 검색
            //
            //
            //txtID.Clear();
            //txtName.Clear();
            //txtphone.Clear();
            //txtAddr1.Clear();
            //txtAddr2.Clear();
            //txtAddr3.Clear();
            //cbmADDR.SelectedIndex = 0;
            //cbmDept.SelectedIndex = 0;
            //cbmPhone.SelectedIndex = 0;
            //cbmRank.SelectedIndex = 0;

            // 검색

            //if (string.IsNullOrWhiteSpace(txtIDSearch.Text) && string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex == 0)
            //{
            //    MessageBox.Show("검색조건을 최소 입력해주세요");
            //    return;
            //}

        }

        public void SetEmpList()
        {
            
            for (int i = 0; i < empList.Count; i++)
            {
                dgvHR.Rows.Add();
                dgvHR["emp_id", i].Value = empList[i].emp_id;
                dgvHR["emp_name", i].Value = empList[i].emp_name;
                dgvHR["gender", i].Value = empList[i].gender;
                dgvHR["dep_name", i].Value = empList[i].dep_name;
                dgvHR["title_name", i].Value = empList[i].title_name;
                dgvHR["phone1_name", i].Value = empList[i].phone1_name;
                dgvHR["phone2", i].Value = empList[i].phone2;
                dgvHR["email", i].Value = empList[i].email;
                dgvHR["region_name", i].Value = empList[i].region_name;
                dgvHR["zipCode", i].Value = empList[i].zipCode;
                dgvHR["address1", i].Value = empList[i].address1;
                dgvHR["address2", i].Value = empList[i].address2;
                dgvHR["emp_barCode", i].Value = empList[i].emp_barCode;
            }
        }

        /// <summary>
        /// DataGridView  설정
        /// 0, 1, 13 번 > 버튼
        /// 0 등록 > 등록 버튼 누르면 ReadOnly = false
        ///   => 데이터가 있는 Row는 등록 버튼을 누를 수 없음, 데이터가 없는 마지막 Row만 클릭 가능
        ///   => *클릭으로 데이터 입력이 가능한 경우, 등록 버튼의 TEXT는 확인, 수정 버튼의 TEXT는 취소 변경
        ///   => *확인 > 데이터 검토후 DB 등록, 취소 > 작성된 데이터가 없어지고 등록 수정 기능으로 변경
        ///   => 주소 컬럼을 클릭하면 주소 검색 팝업 > 확인 후 데이터에 맞는 컬럼으로 이동
        ///   => 
        /// 1 수정 > 수정 버튼 누르면 수정 가능한 정보는 ReadOnly = false
        ///   => **비어있는 Row에서 누르면 기능 없음
        ///   => *클릭으로 데이터 수정이 가능한 경우, 등록 버튼의 TEXT는 확인, 수정 버튼의 TEXT는 취소 변경
        ///   => *확인 > 데이터 검토후 DB 등록, 취소 > 작성된 데이터가 없어지고 등록 수정 기능으로 변경
        ///   => 주소 컬럼을 클릭하면 주소 검색 팝업 > 확인 후 데이터에 맞는 컬럼으로 이동
        ///   =>
        /// 13 퇴사 > 퇴사 버튼 누르면 확인 후 데이터 삭제
        ///   => **비어있는 Row에서 누르면 기능 없음
        ///   
        /// </summary>
        public void SetDGV()
        {
            string category = null;
            List<CommonCodeDTO> list = null;
            DataGridViewUtil.SetDgv(dgvHR);
            
            DataGridViewUtil.AddGridButtonColumn(dgvHR, "수정", "modify", "수정", 50);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "직원 id", "emp_id", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "이름", "emp_name", 70);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "성별", "gender", 60);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "부서", "dep_name", 70);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "직책", "title_name", 70);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "통신사", "phone1_name", 90);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "전화번호", "phone2", 130);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "이메일", "email", 180, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "지역", "region_name", 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "우편번호", "zipCode", 100);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "주소1", "address1", 250,align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "주소2", "address2", 200, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridButtonColumn(dgvHR, "퇴사", "del", "퇴사", 50);
            DataGridViewUtil.AddGridTextBoxColumn(dgvHR, "바코드", "emp_barCode",visible: false);

        }

        private void dgvHR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ucSBUpdata.Visible = true;

            if (e.RowIndex < 0)
            {
                return;
            }
            if(e.ColumnIndex == 0)
            {
                int id = Convert.ToInt32(dgvHR["emp_id", e.RowIndex].Value);
                selected = empList.Find((s) => s.emp_id == id);

                txtID.Text = selected.emp_id.ToString();
                txtName.Text = selected.emp_name;
                Gender(selected.gender);
                cbmDept.SelectedValue = selected.dep_code;
                cbmRank.SelectedValue = selected.title_code;
                cbmPhone.SelectedValue = selected.phone1_code;
                txtphone.Text = selected.phone2;
                txtEmail.Text = selected.email;
                cbmAddr.SelectedValue = selected.region_code.ToString().Trim();
                ucAddr.ZipCode = selected.zipCode;
                ucAddr.Addr1 = selected.address1;
                ucAddr.Addr2 = selected.address2;
               
            }
            else if(e.ColumnIndex == 13)
            {
                if (dgvHR["emp_name", e.RowIndex].Value.ToString() == loginedEmployee.emp_name.ToString())
                {
                    MessageBox.Show("본인이 퇴사 처리할 수 없습니다.");
                    return;
                }
                DialogResult result = MessageBox.Show($"정말로 {dgvHR["emp_name",e.RowIndex].Value.ToString()}을 퇴사 처리 하시겠습니까?", "인사 관리", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool isDel = empService.DelEmp(Convert.ToInt32(dgvHR["emp_id", e.RowIndex].Value));

                    if (!isDel)
                    {
                        MessageBox.Show("에러");
                        return;
                    }
                    MessageBox.Show("퇴사 처리 했습니다.");
                    empList = empService.LoadEmpData().FindAll((emp) => emp.emp_deleted == "N").ToList();
                    dgvHR.DataSource = empList;
                }
            }
            
        }

        public void Gender(string gender)
        {
            if (gender == "M")
            {
                rdbM.Checked = true;
                return;
            }
            rdbF.Checked = true;
        }


        private void ucSBUpdata_BtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("수정 대상을 선택하세요 ");
                return;
            }
            string fm = null;
            if (rdbF.Checked)
            {
                fm = "F";
            }
            else
            {
                fm = "M";
            }
            EmployeeDTO updateEmp = new EmployeeDTO {
                emp_id = Convert.ToInt32(txtID.Text),
                emp_name = txtName.Text,
                dep_code = cbmDept.SelectedValue.ToString(),
                gender = fm,
                title_code = cbmRank.SelectedValue.ToString(),
                phone1_code = cbmPhone.SelectedValue.ToString(),
                phone2 = txtphone.Text,
                email = txtEmail.Text,
                region_code = cbmAddr.SelectedValue.ToString(),
                zipCode = ucAddr.ZipCode,
                address1 = ucAddr.Addr1,
                address2 = ucAddr.Addr2
            };

            bool result = empService.UpdateInfo(updateEmp);

            if (!result)
            {
                MessageBox.Show("에러");
                return;
            }
            MessageBox.Show($"{updateEmp.emp_id}의 정보를 수정하였습니다.");
            Clear();
            empList = empService.LoadEmpData().FindAll((emp) => emp.emp_deleted == "N").ToList();
            dgvHR.DataSource = empList;
        }

        private void ucRefreshButton1_BtnClick(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtID.Clear();
            txtName.Clear();
            cbmDept.SelectedIndex = 0;
            cbmRank.SelectedIndex = 0;
            rdbF.Checked = rdbM.Checked = false;
            cbmPhone.SelectedIndex = 0;
            txtphone.Clear();
            txtEmail.Clear();
            cbmAddr.SelectedIndex = 0;
            ucAddr.ZipCode = "";
            ucAddr.Addr1 = "";
            ucAddr.Addr2 = "";

        }

        private void ucInsertButton21_BtnClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("수정중에는 등록을 진행할 수 없습니다.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text)) 
            {
                MessageBox.Show("등록할 대상의 정보를 입력해주세요");
                return;
            }
            string fm = null;
            if (rdbF.Checked)
            {
                fm = "F";
            }
            else
            {
                fm = "M";
            }
            EmployeeDTO newEmp = new EmployeeDTO {
                emp_name = txtName.Text,
                dep_code = cbmDept.SelectedValue.ToString(),
                title_code = cbmRank.SelectedValue.ToString(),
                gender = fm,
                phone1_code = cbmPhone.SelectedValue.ToString(),
                phone2 = txtphone.Text,
                email = txtEmail.Text,
                region_code = cbmAddr.SelectedValue.ToString(),
                zipCode = ucAddr.ZipCode,
                address1 = ucAddr.Addr1,
                address2 = ucAddr.Addr2
            };

            string newID = empService.SetNewEmp(newEmp, loginedEmployee.emp_id);
            

            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            Image img = b.Encode(BarcodeLib.TYPE.UPCA, $"{newID}", Color.Black, Color.White, 200, 80);
            img.Save($"../../../사원증/{newID}_{txtName.Text}_{DateTime.Now.ToString("yymmddHHmmss")}.png", ImageFormat.Png);

            MessageBox.Show($"{newID} 정보가 등록되었습니다.");

            Clear();
            empList = empService.LoadEmpData().FindAll((emp) => emp.emp_deleted == "N").ToList();
            dgvHR.DataSource = empList;

        }

        private void dgvHR_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            if (e.ColumnIndex == 1)
            {
                MessageBox.Show($"바코드 번호 - {dgvHR["emp_barCode", e.RowIndex].Value.ToString()}");
                return;
            }
            else
            {
                return;
            }

        }

        private void ucSearchButton1_BtnClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIDSearch.Text) && string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex == 0) // 직원만
            {
                List<EmployeeDTO> selectedEmpList = empList.FindAll((sl) => sl.emp_barCode.Contains(txtIDSearch.Text));
                dgvHR.DataSource = selectedEmpList;
                dgvHR.Update();
            }
            else if (string.IsNullOrWhiteSpace(txtIDSearch.Text) && !string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex == 0) // 이름만
            {
                List<EmployeeDTO> selectedEmpList = empList.FindAll((sl) => sl.emp_name.Contains(txtNameSearch.Text));
                dgvHR.DataSource = selectedEmpList;
                dgvHR.Update();
            }
            else if (string.IsNullOrWhiteSpace(txtIDSearch.Text) && string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex != 0) // 부서만
            {
                List<EmployeeDTO> selectedEmpList = empList.FindAll((sl) => sl.dep_code == cbmDeptSearch.SelectedValue.ToString());
                dgvHR.DataSource = selectedEmpList;
                dgvHR.Update();
            }
            else if (!string.IsNullOrWhiteSpace(txtIDSearch.Text) && !string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex == 0) // 직원 이름
            {
                List<EmployeeDTO> selectedEmpList = empList.FindAll((sl) => sl.emp_barCode.Contains(txtIDSearch.Text) && sl.emp_name.Contains(txtNameSearch.Text));
                dgvHR.DataSource = selectedEmpList;
                dgvHR.Update();
            }
            else if (string.IsNullOrWhiteSpace(txtIDSearch.Text) && !string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex != 0) // 이름 부서
            {
                List<EmployeeDTO> selectedEmpList = empList.FindAll((sl) => sl.emp_name.Contains(txtNameSearch.Text) && sl.dep_code == cbmDeptSearch.SelectedValue.ToString());
                dgvHR.DataSource = selectedEmpList;
                dgvHR.Update();
            }
            else if (!string.IsNullOrWhiteSpace(txtIDSearch.Text) && string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex != 0) // 직원 부서
            {
                List<EmployeeDTO> selectedEmpList = empList.FindAll((sl) => sl.emp_barCode.Contains(txtIDSearch.Text) && sl.dep_code == cbmDeptSearch.SelectedValue.ToString());
                dgvHR.DataSource = selectedEmpList;
                dgvHR.Update();
            }
            else if (!string.IsNullOrWhiteSpace(txtIDSearch.Text) && !string.IsNullOrWhiteSpace(txtNameSearch.Text) && cbmDeptSearch.SelectedIndex != 0) // 직원 이름 부서
            {
                List<EmployeeDTO> selectedEmpList = empList.FindAll((sl) => sl.emp_barCode.Contains(txtIDSearch.Text) && sl.emp_name.Contains(txtNameSearch.Text) && sl.dep_code == cbmDeptSearch.SelectedValue.ToString());
                dgvHR.DataSource = selectedEmpList;
                dgvHR.Update();
            }
            else
            {
                dgvHR.DataSource = empList;
                dgvHR.Update();
            }
        }
    }
}
