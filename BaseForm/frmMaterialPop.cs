using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team2DTO;

namespace Team2
{
    public partial class frmMaterialPop : frmPop
    {
        List<materialListDTO> materialAllList;
        string category = null;

        public List<MaterialDTO> materialList { get; set; }

        public frmMaterialPop()
        {
            InitializeComponent();
        }

        private void frmMaterialPop_Load(object sender, EventArgs e)
        {
            category = ((frmBOM)((frmMain)Owner).MdiChildren[0]).selectedMaterialCategory;
            materialAllList = ((frmBOM)((frmMain)Owner).MdiChildren[0]).materialAllList.FindAll((m) => m.Code == category);

            lblCategory.Text = "카테고리(" + materialAllList[0].Category + ")";

            for (int i = 0; i < materialAllList.Count; i++)
            {
                Button btn = new Button();
                btn.Name = materialAllList[i].Code;
                btn.Location = new Point(15, 35 * (1 + i) + (i * 10));
                btn.Text = $"{materialAllList[i].ID} - {materialAllList[i].Name}";
                btn.Size = new Size(200, 35);
                btn.Click += Btn_Click;

                panel4.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ((frmBOM)((frmMain)Owner).ActiveMdiChild).selectedMaterial = ((Button)sender).Text.Split('-')[0].Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
