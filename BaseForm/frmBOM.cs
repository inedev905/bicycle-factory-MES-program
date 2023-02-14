using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2DTO;
using Team2.Services;
using Team2.Util;

namespace Team2
{
    public partial class frmBOM : frmListDetail
    {
        ProductService productService; // 제품 서비스
        List<CommonCodeDTO> bikeCommonList; // 자전거 공통 코드
        List<BOMDTO> bomList; // bom 리스트
        List<BOMDTO> reversalBomList; // 역 리스트
        List<ProductDTO> productList; // 완제품 정보
        EmployeeDTO loginedEmp; // 로그인 정보
        MaterialCheckDTO materialCheck = null;

        public List<materialListDTO> materialAllList = null; //
        ProductDTO selectedBike = null; // 선택된 자전거 서지사항
        public string selectedMaterialCategory = null; // 검색을 위한 카테고리 tag 값
        public string selectedMaterial = null; // 검ㅅ색 된 자재 중 선택 된 값 리턴
        bool isAdd = false;
        

        public frmBOM()
        {
            InitializeComponent();
        }

        private void frmBOM_Load(object sender, EventArgs e)
        {
            //로그인 정보 가져오기
            try
            {
                loginedEmp = ((frmMain)this.MdiParent).LoginEmpInfo;
            }
            catch
            {
                MessageBox.Show("로그인 데이터가 없습니다.");
            }
            // 기본 설정
            groupBox1.Enabled = false;
            ucSBCheck.Visible = false;
            ucSaveButton1.Visible = false;

            dgvBom.BringToFront();
            dgvRBom.Visible = false;

            // 정전개 기본 설정
            rdbBom.Checked = true;
            cbmMaterial.Visible = false;
            // 콤보 박스 3개 완제품 / 자재 / 완제품 카테고리 바인딩
            string[] categorie = { "PROD","MATE", "" };
            productService = new ProductService();
            bikeCommonList = productService.GetAllProductCommonCode(categorie);

            // 데이터 로드

            CommonCodeUtil.ComboBinding(cbmItem, bikeCommonList, "PROD", blankText: "완제품");
            CommonCodeUtil.ComboBinding(cbmMaterial, bikeCommonList, "MATE", blankText: "자재");
            CommonCodeUtil.ComboBinding(cbmCategory, bikeCommonList, "PROD");

            // 재료 모든 리스트 데이터 가져오기

            materialAllList = productService.GetMaterialList();

            // 정전개 역전개 데이터 가져오기

            bomList = productService.GetAllBom("SP_BOM");

            DataGridViewUtil.SetDgv(dgvBom);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBom, "정전개", "name", colWidth: 200, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBom, "코드", "item", colWidth: 110, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBom, "수량", "qty",colWidth:80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBom, "levels", "levels", colWidth: 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBom, "구분", "category", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvBom, "tree", "sortOrder", visible: false);

            dgvBom.DataSource = bomList;

            reversalBomList = productService.GetAllBom("SP_RBOM");

            DataGridViewUtil.SetDgv(dgvRBom);
            DataGridViewUtil.AddGridTextBoxColumn(dgvRBom, "역전개", "name", colWidth: 230, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvRBom, "코드", "item", colWidth: 110, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextBoxColumn(dgvRBom, "수량", "qty", colWidth: 80,visible:false);
            DataGridViewUtil.AddGridTextBoxColumn(dgvRBom, "levels", "levels", colWidth: 80);
            DataGridViewUtil.AddGridTextBoxColumn(dgvRBom, "구분", "category", colWidth: 120);
            DataGridViewUtil.AddGridTextBoxColumn(dgvRBom, "tree", "sortOrder", visible: false);
            dgvRBom.DataSource = reversalBomList;

            // 완제품 정보 가져오기
            productService = new ProductService();
            productList = productService.GetAllProduct();
            // 자재 정보 가져오기

        }
        /// <summary>
        /// 상단 좌측의 라디오 버튼을 통해 정전개 / 역전개를 구분
        /// 구분을 통해 GDV 값 및 검색 조건 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbRBom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRBom.Checked)
            {
                cbmMaterial.BringToFront();
                cbmMaterial.Visible = true;
                cbmItem.Visible = false;
                cbmMaterial.Location = cbmItem.Location;
                lblID.Text = "자재 ID";
                dgvRBom.Visible = true;
                dgvBom.Visible = false;
                dgvRBom.BringToFront();
                return;   
            }
            cbmMaterial.Visible = false;
            cbmItem.Visible = true;
            cbmItem.BringToFront();
            lblID.Text = "완제품 ID";

            dgvBom.Visible = true;
            dgvRBom.Visible = false;
            dgvBom.BringToFront();
        }
        // 역전개 DGVRBOM 클릭 이벤트
        private void dgvRBom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            if (e.RowIndex < 0)
            {
                return;
            }

            CleanData();
            if (Convert.ToInt32(dgvRBom[3, e.RowIndex].Value) != 2)
            {
                return;
            }

            selectedBike = productList.Find((b) => b.product_id == dgvRBom["item", num].Value.ToString());

            if (!isAdd) // 복사(추가 후 데이터 가져오기) 시에는 id를 보여주지 않음
            {
                txtItemID.Text = selectedBike.product_id;
                cbmCategory.Enabled = false;
            }
            txtItemName.Text = selectedBike.product_name;
            txtPrice.Text = selectedBike.product_price.ToString();
            cbmCategory.SelectedValue = selectedBike.product_category;
            txtSafeQty.Text = selectedBike.product_Qty.ToString();
            txtLimitQty.Text = selectedBike.product_QtyLimit.ToString();
            if (selectedBike.product_Img != null)
            {
                pcbItemImage.Image = CommonCodeUtil.ByteToImage(selectedBike.product_Img);
            }

            if (dgvRBom["item", num - 1].Value.ToString() == "p06")
            {
                lblBrake.Text = dgvRBom["item", num + 1].Value.ToString();
                lblFrame.Text = dgvRBom["item", num + 2].Value.ToString();
                lblHandle.Text = dgvRBom["item", num + 3].Value.ToString();
                lblSeat.Text = dgvRBom["item", num + 4].Value.ToString();
                lblWheel.Text = dgvRBom["item", num + 5].Value.ToString();

                return;
            }

            lblBrake.Text = dgvRBom["item", num + 1].Value.ToString();
            lblFrame.Text = dgvRBom["item", num + 2].Value.ToString();
            lblDrive.Text = dgvRBom["item", num + 3].Value.ToString();
            lblHandle.Text = dgvRBom["item", num + 4].Value.ToString();
            lblSeat.Text = dgvRBom["item", num + 5].Value.ToString();
            lblWheel.Text = dgvRBom["item", num + 6].Value.ToString();
        }
        /// <summary>
        /// 정전개 DBVBOM 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CleanData();

            if (e.RowIndex < 0)
            {
                return;
            }

            if (Convert.ToInt32(dgvBom[3, e.RowIndex].Value) == 0)
            {
                return;
            }

            int num = e.RowIndex;
            if (Convert.ToInt32(dgvBom[3, num].Value) == 2) 
            {
                while (Convert.ToInt32(dgvBom[3, num].Value) == 2)
                {
                    num--;
                }
            }
            

            selectedBike = productList.Find((b) => b.product_id == dgvBom["item", num].Value.ToString());
            
            if (!isAdd)
            {
                txtItemID.Text = selectedBike.product_id;
                cbmCategory.Enabled = false;
            }
            txtItemName.Text = selectedBike.product_name;
            txtPrice.Text = selectedBike.product_price.ToString();
            cbmCategory.SelectedValue = selectedBike.product_category;
            txtSafeQty.Text = selectedBike.product_Qty.ToString();
            txtLimitQty.Text = selectedBike.product_QtyLimit.ToString();
            if (selectedBike.product_Img != null)
            {
                pcbItemImage.Image = CommonCodeUtil.ByteToImage(selectedBike.product_Img);
            }
            //dpa

            if (dgvBom["sortOrder", e.RowIndex].Value.ToString().StartsWith("p06"))
            {
                lblBrake.Text = dgvBom["item", num + 1].Value.ToString();
                lblFrame.Text = dgvBom["item", num + 2].Value.ToString();
                lblHandle.Text = dgvBom["item", num + 3].Value.ToString();
                lblSeat.Text = dgvBom["item", num + 4].Value.ToString();
                lblWheel.Text = dgvBom["item", num + 5].Value.ToString();
                
                return;
            }

            lblBrake.Text = dgvBom["item", num + 1].Value.ToString();
            lblFrame.Text = dgvBom["item", num + 2].Value.ToString();
            lblDrive.Text = dgvBom["item", num + 3].Value.ToString();
            lblHandle.Text = dgvBom["item", num + 4].Value.ToString();
            lblSeat.Text = dgvBom["item", num + 5].Value.ToString();
            lblWheel.Text = dgvBom["item", num + 6].Value.ToString();
           
        }

        private void txtLimitQty_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if (e.KeyChar >)
        }
        /// <summary>
        /// 로드 바이크의 경우 구동부 drive(gear)가 없음
        /// 이에 따라 기능 또한 제한 시킴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbmCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCategory.SelectedValue.ToString() == "p06")
            {
                lblDrive.Text = "";
                lblDrive.Enabled = false;
               
                return;
            }
            lblDrive.Enabled = true;
            
        }
        /// <summary>
        /// BOM 추가
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucInsertButton1_BtnClick(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("데이터 조회 또는 수정 중에는 추가 할 수 없습니다.");
                return;
            }
            // 기본 설정
            isAdd = true;
            groupBox1.Enabled = true;
            ucSaveButton1.Enabled = false;
            ucSBCheck.Visible = true;
            ucSaveButton1.Visible = true;

        }
        /// <summary>
        /// 입력 데이터 초기화 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucRefreshButton1_BtnClick(object sender, EventArgs e)
        {
            isAdd = false;
            groupBox1.Enabled = false;
            ucSBCheck.Visible = false;
            ucSaveButton1.Visible = false;
            cbmCategory.Enabled = true;
            panel7.Enabled = true;
            txtID.Clear();
            cbmItem.SelectedIndex = 0;
            cbmMaterial.SelectedIndex = 0;

            CleanData();
        }

        public void CleanData()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
            cbmCategory.SelectedIndex = 0;
            txtSafeQty.Clear();
            txtLimitQty.Clear();
            lblHandle.Text = "";
            lblDrive.Text = "";
            lblFrame.Text = "";
            lblBrake.Text = "";
            lblWheel.Text = "";
            lblSeat.Text = "";
            pcbItemImage.Image = null;
        }
        /// <summary>
        /// 데이터 수정 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucUpdateButton1_BtnClick(object sender, EventArgs e)
        {
           if (isAdd)
            {
                MessageBox.Show("추가 진행 중인 경우 수정 할 수 없습니다.");
                return;
            }
            // 수정할 데이터를 가져온다
            if (string.IsNullOrWhiteSpace(txtItemID.Text))
            {
                MessageBox.Show("수정할 완제품의 데이터를 가져와 주세요");
                return;
            }
            // 기본 설정
            ucSaveButton1.Enabled = false;
            groupBox1.Enabled = true;
            panel7.Enabled = false;
            ucSBCheck.Visible = true;
            ucSaveButton1.Visible = true;
        }
        /// <summary>
        /// BOM 삭제 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucDeleteButton1_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (ucSBCheck.Visible)
                {
                    MessageBox.Show("추가 또는 수정 진행 중인 데이터는 삭제 할 수 없습니다.");
                    return;
                }

                // 삭제할 데이터를 가져온다
                if (string.IsNullOrWhiteSpace(txtItemID.Text))
                {
                    MessageBox.Show("삭제할 완제품의 데이터를 가져와 주세요");
                    return;
                }

                // 데이터 삭제 >>>>

                bool delResult = productService.DelProduct(txtItemID.Text);

                if (delResult)
                {
                    MessageBox.Show("삭제 되었습니다.");
                    bomList = productService.GetAllBom("SP_BOM");
                    reversalBomList = productService.GetAllBom("SP_RBOM");
                    dgvBom.DataSource = bomList;
                    dgvRBom.DataSource = reversalBomList;
                    dgvBom.Update();
                    dgvRBom.Update();
                }
                else
                {
                    MessageBox.Show("에러");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("생산 진행 중인 자전거 입니다.");
            }
            finally
            {
                //선택된 데이터 삭제 후 클린
                CleanData();
                dgvBom.Update();
                dgvRBom.Update();
            }
            
        }
        /// <summary>
        /// 수정 및 추가 시 보여지는 저장 버튼
        /// 수정 또는 추가된 데이터를 DB에 저장 후
        /// DB  변화로 dgv 2개를 업데이트함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucSaveButton1_BtnClick(object sender, EventArgs e)
        {
            // 수정 및 추가 시 보여지는 저장 버튼 >>>>
            byte[] img = null;

            if (pcbItemImage.Image != null)
            {
                img = CommonCodeUtil.ImageToByte(pcbItemImage.Image);
            }

            if (isAdd)
            {

                ProductDTO newProduct = new ProductDTO
                {
                    product_name = txtItemName.Text,
                    product_id = "",
                    product_price = Convert.ToInt32(txtPrice.Text),
                    product_category = cbmCategory.SelectedValue.ToString(),
                    product_Qty = 0,
                    product_QtyLimit = Convert.ToInt32(txtLimitQty.Text),
                    product_Safety = Convert.ToInt32(txtSafeQty.Text),
                    product_Img = img,
                    product_chargeEmp = loginedEmp.emp_id
                };


                MaterialCheckDTO newProductMaterials = new MaterialCheckDTO
                {
                    Category = cbmCategory.SelectedValue.ToString(),
                    Brake = lblBrake.Text,
                    Frame = lblFrame.Text,
                    Gear = lblDrive.Text,
                    Handle = lblHandle.Text,
                    Seat = lblSeat.Text,
                    Wheel = lblWheel.Text
                };
            
                string isResult = productService.SetProduct(newProduct, newProductMaterials);

                if (string.IsNullOrWhiteSpace(isResult))
                {
                   MessageBox.Show("에러 발생");
                  return;
                }
                MessageBox.Show($"{isResult}가 등록되었습니다.");
            }
            else
            {
                ProductDTO newProduct = new ProductDTO
                {
                    product_name = txtItemName.Text,
                    product_id = txtItemID.Text,
                    product_price = Convert.ToInt32(txtPrice.Text),
                    product_category = cbmCategory.SelectedValue.ToString(),
                    
                    product_QtyLimit = Convert.ToInt32(txtLimitQty.Text),
                    product_Safety = Convert.ToInt32(txtSafeQty.Text),
                    product_Img = img,
                    product_chargeEmp = loginedEmp.emp_id
                };

                bool isUpdate = productService.UpdateProductInfo(newProduct);

                if (!isUpdate)
                {
                    MessageBox.Show("에러 발생");
                    return;
                }
                MessageBox.Show($"{newProduct.product_id} 정보가 수정되었습니다.");

            }
            productList = productService.GetAllProduct();
            bomList = productService.GetAllBom("SP_BOM");
            reversalBomList = productService.GetAllBom("SP_RBOM");
            dgvBom.DataSource = bomList;
            dgvRBom.DataSource = reversalBomList;
            dgvBom.Update();
            dgvRBom.Update();

            CleanData();

            dgvBom.Update();
            isAdd = false;
            ucSaveButton1.Visible = false;
            ucSBCheck.Visible = false;
            panel7.Enabled = true;
            groupBox1.Enabled = false;
            cbmCategory.Enabled = true;
        }

        private void ucSBCheck_BtnClick(object sender, EventArgs e)
        {
            //
            // 수정 상황
            // ID 값이 있음
            // 구성 품이 잠겨 있으므로, ID 여부만 확인하면 됨
            // 없으면 -1

            if(string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || 
                string.IsNullOrWhiteSpace(txtSafeQty.Text) || string.IsNullOrWhiteSpace(txtLimitQty.Text))
            {
                MessageBox.Show("모든 작성 란을 채워 주세요");
                return;
            }
                

            

            if (isAdd)
            {
                if (productList.FindIndex((p) => p.product_name == txtItemName.Text) >= 0)
                {
                    MessageBox.Show("동일한 이름이 있습니다.");
                    return;
                }


                BOMDTO newBikeBom = new BOMDTO();
                //newBikeBom.
                // ID 값이 비어있음 > 저장 시 ID를 부여
                if (cbmCategory.SelectedValue.ToString() == "p06")
                {
                    if (string.IsNullOrWhiteSpace(lblHandle.Text) || string.IsNullOrWhiteSpace(lblFrame.Text) || string.IsNullOrWhiteSpace(lblWheel.Text) ||
                        string.IsNullOrWhiteSpace(lblBrake.Text) || string.IsNullOrWhiteSpace(lblSeat.Text))
                    {
                        MessageBox.Show("기어를 제외한 모든 구성품을 선택해 주세요");
                        return;
                    }
                    // 기존 픽시 자전거들과 모든 구성품이 동일한지 비교(전부 동일하지만 않으면 됨)
                    materialCheck = new MaterialCheckDTO {
                        Category = cbmCategory.SelectedValue.ToString(),
                        Handle = lblHandle.Text,
                        Frame = lblFrame.Text,
                        Brake = lblBrake.Text,
                        Seat = lblSeat.Text,
                        Wheel = lblWheel.Text,
                        Gear = " "
                    };

                }
                else if (cbmCategory.SelectedIndex == 0)
                {
                    MessageBox.Show("자전거 종류는 필수 선택입니다.");
                    return;
                }
                else
                {
                    // 픽시 제외 자전거
                    if (string.IsNullOrWhiteSpace(lblHandle.Text) || string.IsNullOrWhiteSpace(lblFrame.Text) || string.IsNullOrWhiteSpace(lblWheel.Text) ||
                        string.IsNullOrWhiteSpace(lblBrake.Text) || string.IsNullOrWhiteSpace(lblSeat.Text) || string.IsNullOrWhiteSpace(lblDrive.Text))
                    {
                        MessageBox.Show("모든 구성품을 선택해 주세요");
                        return;
                    }
                    // 모든 자전거와의 구성품 비교 (전부 동일하지만 않으면 됨)

                    materialCheck = new MaterialCheckDTO
                    {
                        Category = cbmCategory.SelectedValue.ToString(),
                        Handle = lblHandle.Text,
                        Frame = lblFrame.Text,
                        Brake = lblBrake.Text,
                        Seat = lblSeat.Text,
                        Wheel = lblWheel.Text,
                        Gear = lblDrive.Text
                    };

                }
                // 모든 구성품이 동일하면 안됨
                string result = productService.CheckAllMaterials(materialCheck);

                if (result != "0")
                {
                    MessageBox.Show("동일한 자전거가 있습니다. 구성을 변경해주세요");
                    return;
                }
                MessageBox.Show("생성 가능합니다.");
            }
            else
            {
                MessageBox.Show("수정 가능합니다.");
            }
            // 다 통과 되면 저장 버튼이 가동
            ucSaveButton1.Enabled = true;

            return;
        }

        // 바퀴
        private void ucSSWheel_BtnClick(object sender, EventArgs e)
        {
            selectedMaterialCategory = ((ucSearchSmall)sender).Tag.ToString();
            frmMaterialPop pop = new frmMaterialPop();
            DialogResult result = pop.ShowDialog(this);

            if (result != DialogResult.OK)
            {
                MessageBox.Show("선택을 안하셨습니다.");
                lblWheel.Text = "";
            }
            lblWheel.Text = selectedMaterial;
        }
        //핸들
        private void ucSSHansdle_BtnClick(object sender, EventArgs e)
        {
            selectedMaterialCategory = ((ucSearchSmall)sender).Tag.ToString();
            frmMaterialPop pop = new frmMaterialPop();
            DialogResult result = pop.ShowDialog(this);

            if (result != DialogResult.OK)
            {
                MessageBox.Show("선택을 안하셨습니다.");
                lblHandle.Text = "";
            }
            lblHandle.Text = selectedMaterial;
        }
        //프레임
        private void ucSSFrame_BtnClick(object sender, EventArgs e)
        {
            selectedMaterialCategory = ((ucSearchSmall)sender).Tag.ToString();
            frmMaterialPop pop = new frmMaterialPop();
            DialogResult result = pop.ShowDialog(this);

            if (result != DialogResult.OK)
            {
                MessageBox.Show("선택을 안하셨습니다.");
                lblFrame.Text = "";
            }
            lblFrame.Text = selectedMaterial;
        }
        //브레이크

        private void ucSSBrake_BtnClick(object sender, EventArgs e)
        {
            selectedMaterialCategory = ((ucSearchSmall)sender).Tag.ToString();
            frmMaterialPop pop = new frmMaterialPop();
            DialogResult result = pop.ShowDialog(this);

            if (result != DialogResult.OK)
            {
                MessageBox.Show("선택을 안하셨습니다.");
                lblBrake.Text = "";
            }
            lblBrake.Text = selectedMaterial;
        }
        //기어
        private void ucSSDrive_BtnClick(object sender, EventArgs e)
        {
            selectedMaterialCategory = ((ucSearchSmall)sender).Tag.ToString();
            frmMaterialPop pop = new frmMaterialPop();
            DialogResult result = pop.ShowDialog(this);

            if (result != DialogResult.OK)
            {
                MessageBox.Show("선택을 안하셨습니다.");
                lblDrive.Text = "";
            }
            lblDrive.Text = selectedMaterial;
        }
        //안장
        private void ucSSSeat_BtnClick(object sender, EventArgs e)
        {
            selectedMaterialCategory = ((ucSearchSmall)sender).Tag.ToString();
            frmMaterialPop pop = new frmMaterialPop();
            DialogResult result = pop.ShowDialog(this);

            if (result != DialogResult.OK)
            {
                MessageBox.Show("선택을 안하셨습니다.");
                lblSeat.Text = "";
            }
            lblSeat.Text = selectedMaterial;
        }

        private void ucSearchButton1_BtnClick(object sender, EventArgs e)
        {
            if (rdbBom.Checked) // 정전개 bomList
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text) && cbmItem.SelectedIndex != 0)
                {
                    List<BOMDTO> selectedList = bomList.FindAll((sl) => sl.sortOrder.Contains(txtID.Text) && sl.sortOrder.Contains(cbmItem.SelectedValue.ToString()));
                    dgvBom.DataSource = selectedList;
                    dgvBom.Update();
                }
                else if (!string.IsNullOrWhiteSpace(txtID.Text) && cbmItem.SelectedIndex == 0)
                {
                    List<BOMDTO> selectedList = bomList.FindAll((sl) => sl.sortOrder.Contains(txtID.Text));
                    dgvBom.DataSource = selectedList;
                    dgvBom.Update();
                }
                else if (string.IsNullOrWhiteSpace(txtID.Text) && cbmItem.SelectedIndex != 0)
                {
                    List<BOMDTO> selectedList = bomList.FindAll((sl) => sl.sortOrder.Contains(cbmItem.SelectedValue.ToString()));
                    dgvBom.DataSource = selectedList;
                    dgvBom.Update();
                }
                else
                {
                    dgvBom.DataSource = bomList;
                    dgvBom.Update();
                }
            }
            else // 역전개 reversalBomList
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text) && cbmMaterial.SelectedIndex != 0)
                {
                    List<BOMDTO> selectedList = reversalBomList.FindAll((sl) => sl.sortOrder.Contains(txtID.Text) && sl.sortOrder.Contains(cbmMaterial.SelectedValue.ToString()));
                    dgvRBom.DataSource = selectedList;
                    dgvRBom.Update();
                }
                else if (!string.IsNullOrWhiteSpace(txtID.Text) && cbmMaterial.SelectedIndex == 0)
                {
                    List<BOMDTO> selectedList = reversalBomList.FindAll((sl) => sl.sortOrder.Contains(txtID.Text));
                    dgvRBom.DataSource = selectedList;
                    dgvRBom.Update();
                }
                else if (string.IsNullOrWhiteSpace(txtID.Text) && cbmMaterial.SelectedIndex != 0)
                {
                    List<BOMDTO> selectedList = reversalBomList.FindAll((sl) => sl.sortOrder.Contains(cbmMaterial.SelectedValue.ToString()));
                    dgvRBom.DataSource = selectedList;
                    dgvRBom.Update();
                }
                else
                {
                    dgvRBom.DataSource = reversalBomList;
                    dgvRBom.Update();
                }
            }
        }

        private void btnInputImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pcbItemImage.ImageLocation = dlg.FileName;
            }


        }
    }
}
