
namespace Team2
{
    partial class frmMaterialPop
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Size = new System.Drawing.Size(278, 49);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Size = new System.Drawing.Size(9, 28);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Size = new System.Drawing.Size(278, 386);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.lblCategory, 0);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 354);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Size = new System.Drawing.Size(278, 32);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.Text = "자재 리스트";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(19, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 316);
            this.panel4.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(53)))));
            this.lblCategory.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(33, 9);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(164, 33);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "카테고리";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMaterialPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.ClientSize = new System.Drawing.Size(278, 435);
            this.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMaterialPop";
            this.Text = "자재 리스트";
            this.Load += new System.EventHandler(this.frmMaterialPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCategory;
    }
}
