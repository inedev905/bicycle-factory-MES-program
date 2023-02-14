
namespace Team2
{
    partial class frmProductionPlanning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSearchDate = new Team2.ucDateTimePickerSet();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ucSearchSmall1 = new Team2.ucSearchSmall();
            this.ucDeleteButton1 = new Team2.ucDeleteButton();
            this.ucUpdateButton1 = new Team2.ucUpdateButton();
            this.ucRefreshButton1 = new Team2.ucRefreshButton();
            this.ucSearchButton1 = new Team2.ucSearchButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDate = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1183, 57);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucSearchButton1);
            this.panel2.Controls.Add(this.ucRefreshButton1);
            this.panel2.Controls.Add(this.ucSearchSmall1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtProduct);
            this.panel2.Controls.Add(this.dtpSearchDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Size = new System.Drawing.Size(1183, 47);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.Text = "생산계획 조회";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Size = new System.Drawing.Size(1183, 40);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Location = new System.Drawing.Point(0, 144);
            this.panel4.Size = new System.Drawing.Size(1183, 534);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.Text = "생산계획목록";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "생산계획일";
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.EndDate = new System.DateTime(2022, 12, 26, 20, 27, 35, 913);
            this.dtpSearchDate.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchDate.Location = new System.Drawing.Point(104, 8);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(297, 31);
            this.dtpSearchDate.StartDate = new System.DateTime(2022, 12, 26, 20, 27, 35, 920);
            this.dtpSearchDate.TabIndex = 1;
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProduct.Location = new System.Drawing.Point(490, 12);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(162, 25);
            this.txtProduct.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(438, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "품목";
            // 
            // ucSearchSmall1
            // 
            this.ucSearchSmall1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchSmall1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchSmall1.Location = new System.Drawing.Point(655, 12);
            this.ucSearchSmall1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchSmall1.Name = "ucSearchSmall1";
            this.ucSearchSmall1.Size = new System.Drawing.Size(25, 25);
            this.ucSearchSmall1.TabIndex = 6;
            this.ucSearchSmall1.BtnClick += new System.EventHandler(this.ucSearchSmall1_BtnClick);
            // 
            // ucDeleteButton1
            // 
            this.ucDeleteButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDeleteButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucDeleteButton1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucDeleteButton1.Location = new System.Drawing.Point(894, 5);
            this.ucDeleteButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucDeleteButton1.Name = "ucDeleteButton1";
            this.ucDeleteButton1.Size = new System.Drawing.Size(80, 32);
            this.ucDeleteButton1.TabIndex = 6;
            this.ucDeleteButton1.BtnClick += new System.EventHandler(this.ucDeleteButton1_BtnClick);
            // 
            // ucUpdateButton1
            // 
            this.ucUpdateButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUpdateButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucUpdateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucUpdateButton1.Location = new System.Drawing.Point(808, 5);
            this.ucUpdateButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucUpdateButton1.Name = "ucUpdateButton1";
            this.ucUpdateButton1.Size = new System.Drawing.Size(80, 32);
            this.ucUpdateButton1.TabIndex = 5;
            this.ucUpdateButton1.BtnClick += new System.EventHandler(this.ucUpdateButton1_BtnClick);
            // 
            // ucRefreshButton1
            // 
            this.ucRefreshButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRefreshButton1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucRefreshButton1.Location = new System.Drawing.Point(1052, 9);
            this.ucRefreshButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucRefreshButton1.Name = "ucRefreshButton1";
            this.ucRefreshButton1.Size = new System.Drawing.Size(30, 30);
            this.ucRefreshButton1.TabIndex = 9;
            this.ucRefreshButton1.BtnClick += new System.EventHandler(this.ucRefreshButton1_BtnClick);
            // 
            // ucSearchButton1
            // 
            this.ucSearchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSearchButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchButton1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchButton1.ForeColor = System.Drawing.Color.White;
            this.ucSearchButton1.Location = new System.Drawing.Point(1088, 9);
            this.ucSearchButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchButton1.Name = "ucSearchButton1";
            this.ucSearchButton1.Size = new System.Drawing.Size(80, 30);
            this.ucSearchButton1.TabIndex = 10;
            this.ucSearchButton1.BtnClick += new System.EventHandler(this.ucSearchButton1_BtnClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1183, 534);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvDate
            // 
            this.dgvDate.BackgroundColor = System.Drawing.Color.White;
            this.dgvDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDate.Location = new System.Drawing.Point(0, 0);
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.RowTemplate.Height = 23;
            this.dgvDate.Size = new System.Drawing.Size(190, 534);
            this.dgvDate.TabIndex = 0;
            this.dgvDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDate_CellClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvPlan);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvDetail);
            this.splitContainer2.Panel2.Controls.Add(this.panel7);
            this.splitContainer2.Size = new System.Drawing.Size(989, 534);
            this.splitContainer2.SplitterDistance = 268;
            this.splitContainer2.TabIndex = 3;
            // 
            // dgvPlan
            // 
            this.dgvPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(0, 0);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.Size = new System.Drawing.Size(989, 268);
            this.dgvPlan.TabIndex = 0;
            this.dgvPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellClick);
            // 
            // dgvDetail
            // 
            this.dgvDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(0, 42);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.Size = new System.Drawing.Size(989, 220);
            this.dgvDetail.TabIndex = 5;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel7.Controls.Add(this.ucDeleteButton1);
            this.panel7.Controls.Add(this.ucUpdateButton1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(989, 42);
            this.panel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "상세정보";
            // 
            // frmProductionPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 678);
            this.Name = "frmProductionPlanning";
            this.Text = "생산계획";
            this.Load += new System.EventHandler(this.frmProductionPlanning_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDate)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private ucDateTimePickerSet dtpSearchDate;
        private ucSearchSmall ucSearchSmall1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduct;
        private ucDeleteButton ucDeleteButton1;
        private ucUpdateButton ucUpdateButton1;
        private ucSearchButton ucSearchButton1;
        private ucRefreshButton ucRefreshButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDate;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridView dgvDetail;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label4;
    }
}