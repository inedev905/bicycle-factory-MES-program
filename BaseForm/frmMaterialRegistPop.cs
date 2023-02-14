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
using System.IO;

namespace Team2
{
    public partial class frmMaterialRegistPop : Team2.frmPop
    {
        MaterialService srv = new MaterialService();
        MaterialDTO SetMaterialInfo;
       
        public MaterialDTO GetMaterialInfo
        {
            get
            {
                byte[] img = null;
                if (picMtr2.Image != null)
                {
                    img = CommonCodeUtil.ImageToByte(picMtr2.Image);
                }

                return new MaterialDTO
                {
                    Material_id = txtMtrID2.Text,
                    Material_name = txtMtrName3.Text,
                    Material_Qty = Convert.ToInt32(txtMtrQty2.Text),
                    Material_safety = Convert.ToInt32(txtSafeQty2.Text),
                    Material_category = cboMtrCategory3.SelectedValue.ToString(),
                    Material_Notes = txtMtrNote2.Text,
                    Material_Min_per = Convert.ToDouble(txtTime2.Text),
                    Material_Img = img
                };
            }

            set
            {
                SetMaterialInfo = value;
            }
        }
        public frmMaterialRegistPop(OpenMode mode)
        {
            InitializeComponent();

            if (mode == OpenMode.Regist)
            {
                label1.Text = "자재 신규 등록";
            }

            if (mode == OpenMode.Update)
            {
                label1.Text = "자재 정보 수정";
                btnUpdateImg2.Text = "이미지 수정";
            }
        }

        private void btnUpdateImg2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picMtr2.ImageLocation = dlg.FileName;
            }
        }

        private void frmMaterialRegistPop_Load(object sender, EventArgs e)
        {
            string[] category = { "MATE" };
            List<CommonCodeDTO> list = srv.GetCommonCode(category);

            CommonCodeUtil.ComboBinding(cboMtrCategory3, list, "MATE", true, "선택안함");

            if (SetMaterialInfo != null)
            {
                txtMtrID2.Text = SetMaterialInfo.Material_id;
                txtMtrName3.Text = SetMaterialInfo.Material_name;
                cboMtrCategory3.SelectedValue = SetMaterialInfo.Material_category;
                txtMtrQty2.Text = SetMaterialInfo.Material_Qty.ToString();
                txtSafeQty2.Text = SetMaterialInfo.Material_safety.ToString();
                txtTime2.Text = SetMaterialInfo.Material_Min_per.ToString();
                
                //자재의 Note와 image를 조회
                MaterialDTO mat = srv.GetMaterialInfo(SetMaterialInfo.Material_id);

                txtMtrNote2.Text = mat.Material_Notes;
                if (mat.Material_Img != null)
                {
                    picMtr2.Image = CommonCodeUtil.ByteToImage(mat.Material_Img);
                }
            }
        }

        private void ucSaveButton1_BtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMtrID2.Text) ||
                string.IsNullOrWhiteSpace(txtMtrName3.Text) ||
                string.IsNullOrWhiteSpace(txtMtrQty2.Text) ||
                string.IsNullOrWhiteSpace(txtSafeQty2.Text) ||
                string.IsNullOrWhiteSpace(txtTime2.Text) || 
                cboMtrCategory3.SelectedIndex < 1)
            {
                MessageBox.Show("모든 정보를 입력해 주세요.");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void ucCloseButton1_BtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
