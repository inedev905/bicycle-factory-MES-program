
namespace Team2
{
    partial class ucExcelButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucExcelButton));
            this.btnExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(0, 0);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnExcel.Size = new System.Drawing.Size(80, 30);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = " 엑셀";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // ucExcelButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnExcel);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucExcelButton";
            this.Size = new System.Drawing.Size(80, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
    }
}
