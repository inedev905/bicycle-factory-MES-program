
namespace Team2
{
    partial class frmCompanyMainform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoOutput1 = new System.Windows.Forms.RadioButton();
            this.rdoInput1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCompanyName1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchCMP1 = new Team2.ucSearchSmall();
            this.btnRefresh = new Team2.ucRefreshButton();
            this.btnAllSearch = new Team2.ucSearchButton();
            this.btnInsert = new Team2.ucInsertButton2();
            this.btnUpdate = new Team2.ucUpdateButton();
            this.btnDelete = new Team2.ucDeleteButton();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.dgvCount = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAllSearch);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnSearchCMP1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCompanyName1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Size = new System.Drawing.Size(1378, 47);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1378, 57);
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 104);
            this.splitContainer1.Size = new System.Drawing.Size(1378, 565);
            this.splitContainer1.SplitterDistance = 1074;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.Text = "거래처 관리";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvCompany);
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Size = new System.Drawing.Size(1074, 525);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Size = new System.Drawing.Size(1074, 40);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.btnInsert, 0);
            this.panel3.Controls.SetChildIndex(this.btnUpdate, 0);
            this.panel3.Controls.SetChildIndex(this.btnDelete, 0);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvCount);
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Size = new System.Drawing.Size(299, 525);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(299, 40);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.Text = "거래처 목록";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.Text = "거래처 거래이력";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Controls.Add(this.rdoOutput1);
            this.groupBox1.Controls.Add(this.rdoInput1);
            this.groupBox1.Location = new System.Drawing.Point(115, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 36);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoAll.Location = new System.Drawing.Point(4, 11);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(54, 21);
            this.rdoAll.TabIndex = 6;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "전체";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoOutput1
            // 
            this.rdoOutput1.AutoSize = true;
            this.rdoOutput1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoOutput1.Location = new System.Drawing.Point(138, 11);
            this.rdoOutput1.Name = "rdoOutput1";
            this.rdoOutput1.Size = new System.Drawing.Size(68, 21);
            this.rdoOutput1.TabIndex = 5;
            this.rdoOutput1.Text = "매출처";
            this.rdoOutput1.UseVisualStyleBackColor = true;
            // 
            // rdoInput1
            // 
            this.rdoInput1.AutoSize = true;
            this.rdoInput1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoInput1.Location = new System.Drawing.Point(64, 11);
            this.rdoInput1.Name = "rdoInput1";
            this.rdoInput1.Size = new System.Drawing.Size(68, 21);
            this.rdoInput1.TabIndex = 4;
            this.rdoInput1.Text = "매입처";
            this.rdoInput1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "거래처 구분";
            // 
            // txtCompanyName1
            // 
            this.txtCompanyName1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyName1.Location = new System.Drawing.Point(439, 11);
            this.txtCompanyName1.Name = "txtCompanyName1";
            this.txtCompanyName1.Size = new System.Drawing.Size(131, 25);
            this.txtCompanyName1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(355, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "거래처 명";
            // 
            // btnSearchCMP1
            // 
            this.btnSearchCMP1.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCMP1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchCMP1.Location = new System.Drawing.Point(535, 23);
            this.btnSearchCMP1.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchCMP1.Name = "btnSearchCMP1";
            this.btnSearchCMP1.Size = new System.Drawing.Size(25, 0);
            this.btnSearchCMP1.TabIndex = 6;
            this.btnSearchCMP1.BtnClick += new System.EventHandler(this.btnSearchCMP1_BtnClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Location = new System.Drawing.Point(1254, 8);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.BtnClick += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAllSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnAllSearch.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAllSearch.ForeColor = System.Drawing.Color.White;
            this.btnAllSearch.Location = new System.Drawing.Point(1289, 8);
            this.btnAllSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(80, 30);
            this.btnAllSearch.TabIndex = 11;
            this.btnAllSearch.BtnClick += new System.EventHandler(this.btnAllSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(813, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 30);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.BtnClick += new System.EventHandler(this.btnInsert_BtnClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(900, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.BtnClick += new System.EventHandler(this.btnUpdate_BtnClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(987, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.BtnClick += new System.EventHandler(this.btnDelete_BtnClick);
            // 
            // dgvCompany
            // 
            this.dgvCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompany.Location = new System.Drawing.Point(0, 0);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.RowTemplate.Height = 23;
            this.dgvCompany.Size = new System.Drawing.Size(1074, 525);
            this.dgvCompany.TabIndex = 12;
            this.dgvCompany.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellDoubleClick);
            this.dgvCompany.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCompany_CellFormatting);
            // 
            // dgvCount
            // 
            this.dgvCount.BackgroundColor = System.Drawing.Color.White;
            this.dgvCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCount.Location = new System.Drawing.Point(0, 0);
            this.dgvCount.Name = "dgvCount";
            this.dgvCount.RowTemplate.Height = 23;
            this.dgvCount.Size = new System.Drawing.Size(299, 525);
            this.dgvCount.TabIndex = 4;
            // 
            // frmCompanyMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1378, 669);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompanyMainform";
            this.Load += new System.EventHandler(this.frmCompanyMainform_Load);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOutput1;
        private System.Windows.Forms.RadioButton rdoInput1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCompanyName1;
        private System.Windows.Forms.Label label5;
        private ucSearchSmall btnSearchCMP1;
        private ucRefreshButton btnRefresh;
        private ucSearchButton btnAllSearch;
        private ucDeleteButton btnDelete;
        private ucUpdateButton btnUpdate;
        private ucInsertButton2 btnInsert;
        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.DataGridView dgvCount;
        private System.Windows.Forms.RadioButton rdoAll;
    }
}
