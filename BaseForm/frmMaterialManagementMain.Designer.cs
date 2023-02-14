
namespace Team2
{
    partial class frmMaterialManagementMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMtrName1 = new System.Windows.Forms.TextBox();
            this.ucInsertButton21 = new Team2.ucInsertButton2();
            this.ucBtnDelete = new Team2.ucDeleteButton();
            this.txtCompanyName1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvCmpList = new System.Windows.Forms.DataGridView();
            this.dgvTradecmp = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ucSearchButton1 = new Team2.ucSearchButton();
            this.ucRefreshButton1 = new Team2.ucRefreshButton();
            this.ucUpdateButton1 = new Team2.ucUpdateButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmpList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradecmp)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucRefreshButton1);
            this.panel2.Controls.Add(this.ucSearchButton1);
            this.panel2.Controls.Add(this.txtCompanyName1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMtrName1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Size = new System.Drawing.Size(1381, 47);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1381, 57);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 104);
            this.splitContainer1.Size = new System.Drawing.Size(1381, 607);
            this.splitContainer1.SplitterDistance = 709;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.Text = "자재관리";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvMaterial);
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Size = new System.Drawing.Size(709, 567);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucUpdateButton1);
            this.panel3.Controls.Add(this.ucInsertButton21);
            this.panel3.Controls.Add(this.ucBtnDelete);
            this.panel3.Size = new System.Drawing.Size(709, 40);
            this.panel3.Controls.SetChildIndex(this.ucBtnDelete, 0);
            this.panel3.Controls.SetChildIndex(this.ucInsertButton21, 0);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.ucUpdateButton1, 0);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.splitContainer2);
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Size = new System.Drawing.Size(667, 567);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(667, 40);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.Text = "자재 List";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.Text = "거래처 List";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowTemplate.Height = 23;
            this.dgvMaterial.Size = new System.Drawing.Size(709, 567);
            this.dgvMaterial.TabIndex = 0;
            this.dgvMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "자재 명";
            // 
            // txtMtrName1
            // 
            this.txtMtrName1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMtrName1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtMtrName1.Location = new System.Drawing.Point(78, 12);
            this.txtMtrName1.Name = "txtMtrName1";
            this.txtMtrName1.Size = new System.Drawing.Size(174, 25);
            this.txtMtrName1.TabIndex = 1;
            // 
            // ucInsertButton21
            // 
            this.ucInsertButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInsertButton21.BackColor = System.Drawing.Color.Transparent;
            this.ucInsertButton21.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucInsertButton21.Location = new System.Drawing.Point(443, 5);
            this.ucInsertButton21.Name = "ucInsertButton21";
            this.ucInsertButton21.Size = new System.Drawing.Size(80, 30);
            this.ucInsertButton21.TabIndex = 1;
            this.ucInsertButton21.BtnClick += new System.EventHandler(this.ucBtnRegist_BtnClick);
            // 
            // ucBtnDelete
            // 
            this.ucBtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnDelete.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucBtnDelete.Location = new System.Drawing.Point(621, 5);
            this.ucBtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnDelete.Name = "ucBtnDelete";
            this.ucBtnDelete.Size = new System.Drawing.Size(80, 30);
            this.ucBtnDelete.TabIndex = 32;
            this.ucBtnDelete.BtnClick += new System.EventHandler(this.ucBtnDelete_BtnClick);
            // 
            // txtCompanyName1
            // 
            this.txtCompanyName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCompanyName1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyName1.Location = new System.Drawing.Point(348, 12);
            this.txtCompanyName1.Name = "txtCompanyName1";
            this.txtCompanyName1.Size = new System.Drawing.Size(175, 25);
            this.txtCompanyName1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(274, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "거래처 명";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvCmpList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvTradecmp);
            this.splitContainer2.Panel2.Controls.Add(this.panel7);
            this.splitContainer2.Size = new System.Drawing.Size(667, 567);
            this.splitContainer2.SplitterDistance = 259;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvCmpList
            // 
            this.dgvCmpList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCmpList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCmpList.Location = new System.Drawing.Point(0, 0);
            this.dgvCmpList.Name = "dgvCmpList";
            this.dgvCmpList.RowTemplate.Height = 23;
            this.dgvCmpList.Size = new System.Drawing.Size(667, 259);
            this.dgvCmpList.TabIndex = 0;
            this.dgvCmpList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCmpList_CellClick);
            // 
            // dgvTradecmp
            // 
            this.dgvTradecmp.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTradecmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTradecmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTradecmp.Location = new System.Drawing.Point(0, 42);
            this.dgvTradecmp.Name = "dgvTradecmp";
            this.dgvTradecmp.RowTemplate.Height = 23;
            this.dgvTradecmp.Size = new System.Drawing.Size(667, 262);
            this.dgvTradecmp.TabIndex = 3;
            this.dgvTradecmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTradecmp_CellClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(667, 42);
            this.panel7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(14, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "계약 거래처";
            // 
            // ucSearchButton1
            // 
            this.ucSearchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSearchButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchButton1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchButton1.ForeColor = System.Drawing.Color.White;
            this.ucSearchButton1.Location = new System.Drawing.Point(1292, 8);
            this.ucSearchButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchButton1.Name = "ucSearchButton1";
            this.ucSearchButton1.Size = new System.Drawing.Size(80, 30);
            this.ucSearchButton1.TabIndex = 11;
            this.ucSearchButton1.BtnClick += new System.EventHandler(this.ucSearchButton1_BtnClick);
            // 
            // ucRefreshButton1
            // 
            this.ucRefreshButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRefreshButton1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucRefreshButton1.Location = new System.Drawing.Point(1257, 8);
            this.ucRefreshButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucRefreshButton1.Name = "ucRefreshButton1";
            this.ucRefreshButton1.Size = new System.Drawing.Size(30, 30);
            this.ucRefreshButton1.TabIndex = 12;
            this.ucRefreshButton1.BtnClick += new System.EventHandler(this.ucRefreshButton2_BtnClick);
            // 
            // ucUpdateButton1
            // 
            this.ucUpdateButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUpdateButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucUpdateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucUpdateButton1.Location = new System.Drawing.Point(532, 5);
            this.ucUpdateButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucUpdateButton1.Name = "ucUpdateButton1";
            this.ucUpdateButton1.Size = new System.Drawing.Size(80, 30);
            this.ucUpdateButton1.TabIndex = 33;
            this.ucUpdateButton1.BtnClick += new System.EventHandler(this.ucBtnUpdate_BtnClick);
            // 
            // frmMaterialManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1381, 711);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaterialManagementMain";
            this.Load += new System.EventHandler(this.frmMaterialManagementMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmpList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTradecmp)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.TextBox txtMtrName1;
        private System.Windows.Forms.Label label5;
        private ucInsertButton2 ucInsertButton21;
        private ucDeleteButton ucBtnDelete;
        private System.Windows.Forms.TextBox txtCompanyName1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvCmpList;
        private System.Windows.Forms.DataGridView dgvTradecmp;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label7;
        private ucRefreshButton ucRefreshButton1;
        private ucSearchButton ucSearchButton1;
        private ucUpdateButton ucUpdateButton1;
    }
}
