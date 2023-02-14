
namespace Team2
{
    partial class frmPlanningAddpop2
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
            this.ucSaveButton1 = new Team2.ucSaveButton();
            this.ucCloseButton1 = new Team2.ucCloseButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1193, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Size = new System.Drawing.Size(1193, 595);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.splitContainer1, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucCloseButton1);
            this.panel3.Controls.Add(this.ucSaveButton1);
            this.panel3.Location = new System.Drawing.Point(0, 546);
            this.panel3.Size = new System.Drawing.Size(1193, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.Text = "주문조회";
            // 
            // ucSaveButton1
            // 
            this.ucSaveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSaveButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSaveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSaveButton1.Location = new System.Drawing.Point(1018, 8);
            this.ucSaveButton1.Name = "ucSaveButton1";
            this.ucSaveButton1.Size = new System.Drawing.Size(80, 32);
            this.ucSaveButton1.TabIndex = 0;
            this.ucSaveButton1.BtnClick += new System.EventHandler(this.ucSaveButton1_BtnClick);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucCloseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucCloseButton1.Location = new System.Drawing.Point(1104, 8);
            this.ucCloseButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(80, 32);
            this.ucCloseButton1.TabIndex = 1;
            this.ucCloseButton1.BtnClick += new System.EventHandler(this.ucCloseButton1_BtnClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 546);
            this.splitContainer1.SplitterDistance = 680;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 23;
            this.dgvOrder.Size = new System.Drawing.Size(680, 546);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // dgvDetail
            // 
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.Size = new System.Drawing.Size(509, 546);
            this.dgvDetail.TabIndex = 0;
            // 
            // frmPlanningAddpop2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 647);
            this.Name = "frmPlanningAddpop2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주문조회";
            this.Load += new System.EventHandler(this.frmPlanningAddpop2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ucCloseButton ucCloseButton1;
        private ucSaveButton ucSaveButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridView dgvDetail;
    }
}