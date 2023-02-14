using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2DAO;
using Team2DTO;
using Team2.Services;
using Team2.Util;
using System.Linq;

namespace Team2
{
    public partial class frmMaterialManagementMain : Team2.frmListList
    {
        MaterialService srv = new MaterialService();
        List<MaterialDTO> allMtrList = null;
        List<CompanyDTO> cmpList = null;
        List<TradeCompanyDTO> trdList = null;
        EmployeeDTO loginEmpInfo;
        public frmMaterialManagementMain()
        {
            InitializeComponent();
        }

        private void frmMaterialManagementMain_Load(object sender, EventArgs e)
        {
            loginEmpInfo = ((frmMain)this.MdiParent).LoginEmpInfo;
            //===============================================자재list===================================================
            DataGridViewUtil.SetDgv(dgvMaterial);
            
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "  자재 ID", "material_id");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "  카테고리", "material_category_NM");
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "  자재 명", "material_name",180);           
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "  공정시간", "material_Min_per",align:DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "  초기수량", "material_Qty", align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "  안전수량", "material_safety", align: DataGridViewContentAlignment.MiddleRight);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "비고", "material_Notes", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "자재이미지", "material_Img", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "최초등록자", "first_writeEmp", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "등록날짜", "first_writeDate", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "최종수정자", "latest_writeEmp", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "최종수정날짜", "latest_writeDate", visible: false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvMaterial, "자재 카테고리 코드", "material_category", visible: false);

            allMtrList = srv.GetAllMaterial();
            dgvMaterial.DataSource = allMtrList;
            //===========================================================================================================
            //===============================================거래처 list==================================================
            DataGridViewUtil.SetDgv(dgvCmpList);

            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpList, "   사업자번호", "business_num",130); //0
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpList, "  거래처 명", "company_name", 150); //1
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpList, "  거래처연락처", "phone", 150); //2
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpList, "  지역", "Region_code_NM", 50); //3
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpList, "주소", "addr", 530 ,align: DataGridViewContentAlignment.MiddleLeft); // 4
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpList, "지역코드", "region_code", visible:false); //5
            DataGridViewUtil.AddGridTextBoxColumn(dgvCmpList, "거래처ID", "company_id", visible: false); //6
            DataGridViewButtonColumn cmpbtn = new DataGridViewButtonColumn();  //7
            cmpbtn.HeaderText = "계약";
            cmpbtn.Text = "계약";
            cmpbtn.UseColumnTextForButtonValue = true;
            cmpbtn.Width = 100;
            dgvCmpList.Columns.Add(cmpbtn);

            cmpList = srv.GetInputCompany();
            dgvCmpList.DataSource = cmpList;
            //===========================================================================================================
            //==========================================계약 거래처 list==================================================
            DataGridViewUtil.SetDgv(dgvTradecmp);
            //tradeCompany_id, B.material_id, A.company_id , main,
            //B.material_name, C.company_name, C.contact_name, c.contact_phone2, D.name material_category_NM, material_category
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "주 거래처", "main",90); //0
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "  자재", "material_category_NM"); //1
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "  자재 명", "material_name",120); //2
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "  거래처 명", "company_name",130); //3
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "거래처 담당자", "contact_name",120); //4
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "담당자연락처", "contact_phone2",150); //5
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "담당자이메일", "contact_email", 200); //6
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "계약거래처코드", "TradeCompany_id",visible:false); //7
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "거래처코드", "Company_id", visible: false); //8
            DataGridViewUtil.AddGridTextBoxColumn(dgvTradecmp, "자재코드", "Material_id", visible: false); //9
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();   //10
            btnUpdate.HeaderText = "정보수정";
            btnUpdate.Text = "수정";
            btnUpdate.UseColumnTextForButtonValue = true;
            btnUpdate.Width = 100;
            dgvTradecmp.Columns.Add(btnUpdate);
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();   //11
            btnDelete.HeaderText = "계약종료";
            btnDelete.Text = "계약종료";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 100;
            dgvTradecmp.Columns.Add(btnDelete);
            //===========================================================================================================
        }
        //=================================자재관련 코드 ======================================
        private void LoadData() //자재List 및 거래처 List 검색
        {
            dgvMaterial.DataSource = null;
            dgvMaterial.DataSource = allMtrList;
            dgvCmpList.DataSource = null;
            dgvCmpList.DataSource = cmpList;
        }

        private void TrdCmpLoadData() //자재 선택시 자재별거래처 list 데이터 로드
        {
            int idx = dgvMaterial.CurrentRow.Index;
            string idMtr = dgvMaterial[0, idx].Value.ToString();

            trdList = srv.GetTradeCompanyInfo(idMtr);
            dgvTradecmp.DataSource = null;
            dgvTradecmp.DataSource = trdList;
        }

        private void ucBtnRegist_BtnClick(object sender, EventArgs e)   //자재 신규등록 버튼
        {
            frmMaterialRegistPop pop = new frmMaterialRegistPop(OpenMode.Regist);
            if (pop.ShowDialog() == DialogResult.OK)
            {
                MaterialDTO mtrDto = pop.GetMaterialInfo;

                bool result = srv.InsertMaterialInfo(mtrDto, loginEmpInfo);
                if (result)
                {
                    allMtrList = srv.GetAllMaterial();
                    dgvMaterial.DataSource = allMtrList;
                    MessageBox.Show("자재를 신규등록 하였습니다.");
                }
                else
                {
                    MessageBox.Show("자재 신규 등록에 실패하였습니다. 다시시도하여 주세요.");
                }
            }
        }   

        private void ucBtnUpdate_BtnClick(object sender, EventArgs e)   //자재 정보수정 버튼
        {
            int idx = dgvMaterial.CurrentRow.Index;
            
            MaterialDTO mtrUpdate = new MaterialDTO
            {
                Material_id = dgvMaterial[0, idx].Value.ToString(),
                Material_name = dgvMaterial[2, idx].Value.ToString(),
                Material_Qty = Convert.ToInt32(dgvMaterial[4, idx].Value),
                Material_safety = Convert.ToInt32(dgvMaterial[5, idx].Value),
                Material_category = dgvMaterial["material_category", idx].Value.ToString(),
                //Material_Notes = dgvMaterial[6, idx].Value.ToString(),
                Material_Min_per = Convert.ToDouble(dgvMaterial[3, idx].Value)
                //Material_Img = CommonCodeUtil.ByteToImage(dgvMaterial[7, idx].Value)
            };

            frmMaterialRegistPop pop = new frmMaterialRegistPop(OpenMode.Update);
            pop.GetMaterialInfo = mtrUpdate;
            if (pop.ShowDialog() == DialogResult.OK)
            {
                mtrUpdate = pop.GetMaterialInfo;

                bool result = srv.UpdateMaterialInfo(mtrUpdate, loginEmpInfo);
                if (result)
                {
                    allMtrList = srv.GetAllMaterial();
                    dgvMaterial.DataSource = allMtrList;
                    MessageBox.Show("자재 정보를 수정 하였습니다.");
                }
                else
                {
                    MessageBox.Show("자재 정보 수정에 실패하였습니다. 다시시도하여 주세요.");
                }
            }
        }

        private void ucBtnDelete_BtnClick(object sender, EventArgs e)   //자재 정보삭제 버튼
        {
            int idx = dgvMaterial.CurrentRow.Index;
            
            string msg = $"선택한 {dgvMaterial[2, idx].Value} 자재를 삭제하시겠습니까?";

            if (dgvTradecmp.Rows.Count > 0)
            {
                MessageBox.Show($"선택한 {dgvMaterial[2, idx].Value} 자재에 계약된 거래처가 있습니다. \n 현재 계약되어있는 거래처와 모두 거래종료 후 다시 시도하시기 바랍니다");
            }
            else
            {
                DialogResult dlg = MessageBox.Show(msg, "삭제", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    bool result = srv.DeleteMaterialInfo(dgvMaterial[0, idx].Value.ToString());
                    if (result)
                    {
                        allMtrList = srv.GetAllMaterial();
                        dgvMaterial.DataSource = allMtrList;
                        MessageBox.Show("자재 정보가 정상적으로 삭제되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("자재 정보 삭제에 실패하였습니다. 다시 시도하여 주세요.");
                    }
                }
            }
        }

        private void ucSearchButton1_BtnClick(object sender, EventArgs e)   //메인폼 검색 조건
        {
            string searchMtrName = txtMtrName1.Text.Trim();
            string searchCmpName = txtCompanyName1.Text.Trim();
            
            //검색 조건 
            //자재 text있고 거래처 비워있을때 각각데이터출력
            if (searchMtrName.Length > 0 && searchCmpName.Length < 1)
            {
                allMtrList = allMtrList.Where((mtr) => mtr.Material_name.Contains(searchMtrName)).ToList();
                LoadData();
            }
            //자재 비워있고 거래처 text 있을때
            else if (searchMtrName.Length < 1 && searchCmpName.Length > 0)
            {
                cmpList = cmpList.Where((cmp) => cmp.Company_name.Contains(searchCmpName)).ToList();
                LoadData();
            }
            //자재 거래처 둘다 채워져있을 때
            else if (searchMtrName.Length > 0 && searchCmpName.Length > 0)
            {
                allMtrList = allMtrList.Where((mtr) => mtr.Material_name.Contains(searchMtrName)).ToList();
                cmpList = cmpList.Where((cmp) => cmp.Company_name.Contains(searchCmpName)).ToList();
                LoadData();
            }
            //자재 거래처 둘다 비워있으면 각각 데이터 출력 
            else
            {
                LoadData();
            }
        }

        private void ucRefreshButton2_BtnClick(object sender, EventArgs e)  //초기화 조건
        {
            txtMtrName1.Text = "";
            txtCompanyName1.Text = "";

            dgvMaterial.DataSource = null;
            allMtrList = srv.GetAllMaterial();
            dgvMaterial.DataSource = allMtrList;
            dgvCmpList.DataSource = null;
            cmpList = srv.GetInputCompany();
            dgvCmpList.DataSource = cmpList;
        }

        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e) //자재 list 셀 클릭시 
        {
            TrdCmpLoadData();   //해당 자재 계약 거래처 list 데이터 바인딩
        }

        //=============================================================================================
        //====================================거래처List관련 코드 ======================================

        private void dgvCmpList_CellClick(object sender, DataGridViewCellEventArgs e) //거래처 list 셀 클릭시 
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;         

            if (e.ColumnIndex == 7) //등록버튼 눌렀을 때
            {
                int mtrIdx = dgvMaterial.CurrentRow.Index;
                int cmpIdx = dgvCmpList.CurrentRow.Index;               
                string mtrId = dgvMaterial[0, mtrIdx].Value.ToString();
                string mtrName = dgvMaterial[2, mtrIdx].Value.ToString();
                int cmpId = Convert.ToInt32(dgvCmpList[6, cmpIdx].Value);   //dgvcmpList 거래처 Id
                 //dgvtradeList 거래처 Id
                string cmpName = dgvCmpList[1, cmpIdx].Value.ToString();

                if (dgvTradecmp.Rows.Count > 0)
                {
                    //int trdIdx = dgvTradecmp.CurrentRow.Index;
                    bool find = false;
                    for (int i = 0; i < dgvTradecmp.Rows.Count; i++)
                    {
                        int trdcmpId = Convert.ToInt32(dgvTradecmp[8, i].Value);
                        if (cmpId == trdcmpId)  //이미 등록된 회사 id가 아닐때 
                        {
                            find = true;
                            break;                            
                        }
                    }
                    if (! find)
                    {
                        if (MessageBox.Show($"자재 {mtrName}에 {cmpName} 거래처와 계약하시겠습니까?", "계약 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            bool result = srv.InsertTradeCompany(mtrId, cmpId, loginEmpInfo);
                            if (result)
                            {
                                MessageBox.Show("계약이 완료되었습니다");
                                TrdCmpLoadData();
                            }
                            else
                            {
                                MessageBox.Show("시스템 오류가 발생하였습니다. 다시시도하여 주세요.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("이미 계약이 되어있는 거래처입니다.");
                        return;
                    }
                }
                else
                {
                    if (MessageBox.Show($"자재 {mtrName}에 {cmpName} 거래처와 계약하시겠습니까?", "계약 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool result = srv.InsertTradeCompany(mtrId, cmpId, loginEmpInfo);
                        if (result)
                        {
                            MessageBox.Show("계약이 완료되었습니다");
                            TrdCmpLoadData();
                        }
                        else
                        {
                            MessageBox.Show("시스템 오류가 발생하였습니다. 다시시도하여 주세요.");
                        }
                    }
                }
            }   //계약종료 버튼 클릭했을 때
            
        }

        //================================================================================================
        //====================================자재별 거래처 관련 코드 ======================================
        private void dgvTradecmp_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (e.ColumnIndex == 11) 
            {
                int trdidx = dgvTradecmp.CurrentRow.Index;
                int mtrID = Convert.ToInt32(dgvTradecmp[7, trdidx].Value);
                string cmpName = dgvTradecmp[3, trdidx].Value.ToString();
                if (MessageBox.Show($"{cmpName} 거래처와 계약을 종료하시겠습니까?", "거래처 계약여부 확인" ,MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool result = srv.DeleteTradeCompanyInfo(mtrID);
                    if (result)
                    {
                        TrdCmpLoadData();
                        MessageBox.Show($"{cmpName} 거래처와 계약이 종료되었습니다.");
                    }
                    else
                    {
                        MessageBox.Show("시스템 오류가 발생하였습니다. 다시시도하여 주세요.");
                    }
                }
            } //dgvtradecmp에서 삭제버튼 클릭시

            if (e.ColumnIndex == 10)
            {
                int mtridx = dgvTradecmp.CurrentRow.Index;
                int upIdx = dgvTradecmp.CurrentRow.Index;
                int tradeid = Convert.ToInt32(dgvTradecmp[7, upIdx].Value);
                string trdMain = dgvTradecmp[0, upIdx].Value.ToString();
                string mtrName = dgvTradecmp[9, mtridx].Value.ToString();
                string trdcmpName = dgvTradecmp[3, upIdx].Value.ToString();
                if (trdMain == "N") //주거래처가 n일때 수정버튼 클릭시 Y로 변경
                {
                    if (MessageBox.Show($"해당 {trdcmpName} 거래처를 주거래처로 변경하시겠습니까?", "변경확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool result = srv.UpdateTrdMain(tradeid, mtrName);
                        if (!result)
                        {
                            MessageBox.Show("정보 수정에 오류가 발생하였습니다. 다시 시도하여 주세요.");
                        }
                        TrdCmpLoadData();
                        MessageBox.Show($"{trdcmpName} 거래처를 주거래처로 변경하였습니다.");
                    }
                }
                else // 주거래처가 y일때 수정버튼 클릭시 n로 변경 
                {
                    if (MessageBox.Show($"해당 {trdcmpName} 주 거래처를 기본 거래처로 변경하시겠습니까?", "변경확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool result = srv.UpdateTrdNoMain(tradeid);
                        if (result)
                        {
                            TrdCmpLoadData();
                            MessageBox.Show($"{trdcmpName} 거래처를 기본 거래처로 변경하였습니다.");
                        }
                        else
                        {
                            MessageBox.Show("정보 수정에 오류가 발생하였습니다. 다시 시도하여 주세요.");
                        }
                    }
                }
            } //dgvtradecompany에서 수정버튼 클릭시 
        }
    }
}
