
namespace Team2
{
    partial class ucAddr
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtAddr1 = new System.Windows.Forms.TextBox();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.ucSearchSmall1 = new Team2.ucSearchSmall();
            this.SuspendLayout();
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(3, 0);
            this.txtZip.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(128, 25);
            this.txtZip.TabIndex = 0;
            // 
            // txtAddr1
            // 
            this.txtAddr1.Location = new System.Drawing.Point(3, 34);
            this.txtAddr1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAddr1.Name = "txtAddr1";
            this.txtAddr1.Size = new System.Drawing.Size(271, 25);
            this.txtAddr1.TabIndex = 1;
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(3, 68);
            this.txtAddr2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(271, 25);
            this.txtAddr2.TabIndex = 2;
            // 
            // ucSearchSmall1
            // 
            this.ucSearchSmall1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchSmall1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchSmall1.Location = new System.Drawing.Point(137, 0);
            this.ucSearchSmall1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchSmall1.Name = "ucSearchSmall1";
            this.ucSearchSmall1.Size = new System.Drawing.Size(25, 25);
            this.ucSearchSmall1.TabIndex = 3;
            this.ucSearchSmall1.Load += new System.EventHandler(this.ucSearchSmall1_Load);
            // 
            // ucAddr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucSearchSmall1);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.txtAddr1);
            this.Controls.Add(this.txtZip);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ucAddr";
            this.Size = new System.Drawing.Size(276, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtAddr1;
        private System.Windows.Forms.TextBox txtAddr2;
        private ucSearchSmall ucSearchSmall1;
    }
}
