using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Team2.Services;
using Team2DTO;
using Team2.Util;
namespace Team2
{
    public partial class frmCompanyRegistPop : Team2.frmPop
    {
        int empID = 2;  //임시 ID 
        CompanyService srv = null;
        CompanyDTO SetCompanyInfo;
        

        public CompanyDTO GetCompanyInfo 
        {
            get
            {
                
                return new CompanyDTO
                {
                    Company_id = (txtCompanyID.Text.Length > 0) ? Convert.ToInt32(txtCompanyID.Text):0,
                    Business_num = txtBusinessNum.Text,
                    Business_category = GetBusinessCategory(),
                    Company_name = txtCompanyName2.Text,
                    Phone = txtCompanyNum.Text,
                    Region_code = cboCompanyArea.SelectedValue.ToString(),
                    ZipCode = ucAddrCompany.ZipCode,
                    Address1 = ucAddrCompany.Addr1,
                    Address2 = ucAddrCompany.Addr2,
                    Contact_name = txtManagerName.Text,
                    Contact_position = cboManagerPosition.SelectedValue.ToString(),
                    Contact_phone1 = cboAgency.SelectedValue.ToString(),
                    Contact_phone2 = txtPhoneNum.Text,
                    Contact_email = txtManagerEmail.Text
                };
            }
            set
            {
                SetCompanyInfo = value;

                //if (value.Business_category == "매입처")
                //    rdoInput2.Checked = true;
                //else
                //    rdoOutput2.Checked = true;
            }
        }

        private string GetBusinessCategory()    //radio버튼 값 (거래처 구분) 메서드 
        {
            if (rdoInput2.Checked)
            {
                return rdoInput2.Text.Replace("매입처","c01");
            }
            return rdoOutput2.Text.Replace("매출처","c02");
        }

        public frmCompanyRegistPop(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Regist)
            {
                label1.Text = "거래처 정보 등록";
                
            }

            if (mode == OpenMode.Update)
            {
                label1.Text = "거래처 정보 수정";
                
            }
        }

        private void frmCompanyRegistPop_Load(object sender, EventArgs e)
        {
            string[] category = { "ADDR", "RANK", "TELE" };
            srv = new CompanyService();
            List<CommonCodeDTO> list = srv.GetCommonCode(category);
            CommonCodeUtil.ComboBinding(cboCompanyArea, list, "ADDR", true, "선택하세요.");
            CommonCodeUtil.ComboBinding(cboManagerPosition, list, "RANK", true, "선택하세요.");
            CommonCodeUtil.ComboBinding(cboAgency, list, "TELE", true, "선택하세요");

            //update 시 setInfo값
            if (SetCompanyInfo != null)
            {
                txtCompanyID.Text = SetCompanyInfo.Company_id.ToString();
                txtBusinessNum.Text = SetCompanyInfo.Business_num;
                if(GetCompanyInfo.Business_category == "c01") 
                    rdoInput2.Checked = true;
                else
                    rdoOutput2.Checked = true;
                txtCompanyName2.Text = SetCompanyInfo.Company_name;
                txtCompanyNum.Text = SetCompanyInfo.Phone;
                cboCompanyArea.SelectedValue = SetCompanyInfo.Region_code;
                ucAddrCompany.ZipCode = SetCompanyInfo.ZipCode;
                ucAddrCompany.Addr1 = SetCompanyInfo.Address1;
                ucAddrCompany.Addr2 = SetCompanyInfo.Address2;
                txtManagerName.Text = SetCompanyInfo.Contact_name;
                cboManagerPosition.SelectedValue = SetCompanyInfo.Contact_position;
                cboAgency.SelectedValue = SetCompanyInfo.Contact_phone1;
                txtPhoneNum.Text = SetCompanyInfo.Contact_phone2;
                txtManagerEmail.Text = SetCompanyInfo.Contact_email;
            }
        }

        private void ucSaveButton1_BtnClick(object sender, EventArgs e)
        {
            //유효성 체크
            if (string.IsNullOrWhiteSpace(txtCompanyNum.Text) ||  
                string.IsNullOrWhiteSpace(txtBusinessNum.Text) ||
                string.IsNullOrWhiteSpace(txtCompanyName2.Text) ||
                string.IsNullOrWhiteSpace(txtManagerEmail.Text) ||
                string.IsNullOrWhiteSpace(txtManagerName.Text) ||
                cboAgency.SelectedIndex < 1 ||
                cboCompanyArea.SelectedIndex < 1 ||
                cboManagerPosition.SelectedIndex < 1)
            {
                MessageBox.Show("모든 정보를 입력해주시기 바랍니다.");
                return;
            }

            if (! CommonCodeUtil.IsPhoneNumber(txtCompanyNum.Text) && !CommonCodeUtil.IsPhoneNumber(txtPhoneNum.Text))
            {
                MessageBox.Show("전화번호 형식이 잘못되었습니다.");
                return;
            }
            string zip = ucAddrCompany.ZipCode;
            string addr1 = ucAddrCompany.Addr1;
            string addr2 = ucAddrCompany.Addr2;

            //처리
            this.DialogResult = DialogResult.OK;
            this.Close();           
        }

        private void ucCloseButton1_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSearchCMP2_BtnClick(object sender, EventArgs e)
        {
            frmSearchCompanyPop pop = new frmSearchCompanyPop();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                txtCompanyName2.Text = pop.CompanyNameInfo.Company_name;
            }
        }
    }
}
