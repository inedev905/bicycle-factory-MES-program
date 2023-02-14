
namespace Team2.BaseForm
{
    partial class frmSearchMaterialPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchMaterialPop));
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.ucBtnClose = new Team2.ucCloseButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(441, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMaterial);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Size = new System.Drawing.Size(441, 470);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.dgvMaterial, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucBtnClose);
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Size = new System.Drawing.Size(441, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.Text = "자재 조회";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.Location = new System.Drawing.Point(14, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(383, 25);
            this.txtKeyword.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblComment);
            this.panel4.Controls.Add(this.txtKeyword);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 48);
            this.panel4.TabIndex = 5;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.White;
            this.lblComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblComment.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblComment.Location = new System.Drawing.Point(18, 15);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(138, 17);
            this.lblComment.TabIndex = 61;
            this.lblComment.Text = "검색어를 입력하세요";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial.Location = new System.Drawing.Point(0, 48);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowTemplate.Height = 23;
            this.dgvMaterial.Size = new System.Drawing.Size(441, 373);
            this.dgvMaterial.TabIndex = 6;
            // 
            // ucBtnClose
            // 
            this.ucBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucBtnClose.Location = new System.Drawing.Point(348, 8);
            this.ucBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnClose.Name = "ucBtnClose";
            this.ucBtnClose.Size = new System.Drawing.Size(80, 32);
            this.ucBtnClose.TabIndex = 1;
            // 
            // frmSearchMaterialPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(441, 522);
            this.Name = "frmSearchMaterialPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtKeyword;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private ucCloseButton ucBtnClose;
    }
}
