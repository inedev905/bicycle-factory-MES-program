
namespace Team2
{
    partial class frmShippments
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
            this.dgvTotCount = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvTotProduction = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ucInProductedBike = new Team2.ucSaveButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvTotOrdersDt = new System.Windows.Forms.DataGridView();
            this.dgvTotOrders = new System.Windows.Forms.DataGridView();
            this.ucOutBtn = new Team2.ucOutButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotCount)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotProduction)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotOrdersDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Size = new System.Drawing.Size(1606, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1606, 80);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 80);
            this.splitContainer1.Size = new System.Drawing.Size(1606, 729);
            this.splitContainer1.SplitterDistance = 524;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(124, 36);
            this.label1.Text = "출하 관리";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvTotCount);
            this.panel5.Location = new System.Drawing.Point(0, 56);
            this.panel5.Size = new System.Drawing.Size(524, 673);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(524, 56);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvTotOrders);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 56);
            this.panel6.Size = new System.Drawing.Size(1077, 673);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucOutBtn);
            this.panel4.Size = new System.Drawing.Size(1077, 56);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.ucOutBtn, 0);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.Text = "완제품 수량 확인";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.Text = "주문 확인";
            // 
            // dgvTotCount
            // 
            this.dgvTotCount.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTotCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotCount.Location = new System.Drawing.Point(0, 0);
            this.dgvTotCount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTotCount.Name = "dgvTotCount";
            this.dgvTotCount.RowHeadersWidth = 51;
            this.dgvTotCount.RowTemplate.Height = 27;
            this.dgvTotCount.Size = new System.Drawing.Size(524, 673);
            this.dgvTotCount.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvTotProduction);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 355);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1077, 318);
            this.panel7.TabIndex = 0;
            // 
            // dgvTotProduction
            // 
            this.dgvTotProduction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTotProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotProduction.Location = new System.Drawing.Point(0, 56);
            this.dgvTotProduction.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTotProduction.Name = "dgvTotProduction";
            this.dgvTotProduction.RowHeadersWidth = 51;
            this.dgvTotProduction.RowTemplate.Height = 27;
            this.dgvTotProduction.Size = new System.Drawing.Size(1077, 262);
            this.dgvTotProduction.TabIndex = 3;
            this.dgvTotProduction.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTotProduction_CellFormatting);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel8.Controls.Add(this.ucInProductedBike);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1077, 56);
            this.panel8.TabIndex = 2;
            // 
            // ucInProductedBike
            // 
            this.ucInProductedBike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInProductedBike.BackColor = System.Drawing.Color.Transparent;
            this.ucInProductedBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucInProductedBike.Location = new System.Drawing.Point(966, 8);
            this.ucInProductedBike.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucInProductedBike.Name = "ucInProductedBike";
            this.ucInProductedBike.Size = new System.Drawing.Size(98, 42);
            this.ucInProductedBike.TabIndex = 6;
            this.ucInProductedBike.BtnClick += new System.EventHandler(this.ucInProductedBike_BtnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "생산 확인";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvTotOrdersDt);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(576, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(501, 355);
            this.panel9.TabIndex = 1;
            // 
            // dgvTotOrdersDt
            // 
            this.dgvTotOrdersDt.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTotOrdersDt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotOrdersDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotOrdersDt.Location = new System.Drawing.Point(0, 0);
            this.dgvTotOrdersDt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTotOrdersDt.Name = "dgvTotOrdersDt";
            this.dgvTotOrdersDt.RowHeadersWidth = 51;
            this.dgvTotOrdersDt.RowTemplate.Height = 27;
            this.dgvTotOrdersDt.Size = new System.Drawing.Size(501, 355);
            this.dgvTotOrdersDt.TabIndex = 3;
            this.dgvTotOrdersDt.DataMemberChanged += new System.EventHandler(this.frmShippments_Load);
            this.dgvTotOrdersDt.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTotOrdersDt_CellFormatting);
            // 
            // dgvTotOrders
            // 
            this.dgvTotOrders.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTotOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvTotOrders.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTotOrders.Name = "dgvTotOrders";
            this.dgvTotOrders.RowHeadersWidth = 51;
            this.dgvTotOrders.RowTemplate.Height = 27;
            this.dgvTotOrders.Size = new System.Drawing.Size(576, 355);
            this.dgvTotOrders.TabIndex = 2;
            this.dgvTotOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotOrders_CellDoubleClick);
            // 
            // ucOutBtn
            // 
            this.ucOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucOutBtn.Location = new System.Drawing.Point(99, 7);
            this.ucOutBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ucOutBtn.Name = "ucOutBtn";
            this.ucOutBtn.Size = new System.Drawing.Size(98, 42);
            this.ucOutBtn.TabIndex = 1;
            this.ucOutBtn.BtnClick += new System.EventHandler(this.ucOutBtn_BtnClick);
            // 
            // frmShippments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(1606, 809);
            this.Name = "frmShippments";
            this.Load += new System.EventHandler(this.frmShippments_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotCount)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotProduction)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotOrdersDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotCount;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTotProduction;
        private System.Windows.Forms.DataGridView dgvTotOrders;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvTotOrdersDt;
        private ucSaveButton ucInProductedBike;
        private ucOutButton ucOutBtn;
    }
}
