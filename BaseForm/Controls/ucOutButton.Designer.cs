
namespace Team2
{
    partial class ucOutButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucOutButton));
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.White;
            this.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOut.ForeColor = System.Drawing.Color.Black;
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.Location = new System.Drawing.Point(0, 0);
            this.btnOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnOut.Name = "btnOut";
            this.btnOut.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnOut.Size = new System.Drawing.Size(80, 30);
            this.btnOut.TabIndex = 4;
            this.btnOut.Text = " 출하";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // ucOutButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnOut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucOutButton";
            this.Size = new System.Drawing.Size(80, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
    }
}
