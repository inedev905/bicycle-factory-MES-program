
namespace Team2.Controls
{
    partial class ucCancleButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCancleButton));
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.White;
            this.btnCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancle.ForeColor = System.Drawing.Color.Black;
            this.btnCancle.Image = ((System.Drawing.Image)(resources.GetObject("btnCancle.Image")));
            this.btnCancle.Location = new System.Drawing.Point(0, 0);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancle.Size = new System.Drawing.Size(80, 30);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = " 취소";
            this.btnCancle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // ucCancleButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancle);
            this.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucCancleButton";
            this.Size = new System.Drawing.Size(80, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
    }
}
