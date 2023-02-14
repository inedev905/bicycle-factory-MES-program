
namespace Team2
{
    partial class frmMaterialRegistPop
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
            this.ucSaveButton1 = new Team2.ucSaveButton();
            this.ucCloseButton1 = new Team2.ucCloseButton();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSafeQty2 = new System.Windows.Forms.TextBox();
            this.txtMtrQty2 = new System.Windows.Forms.TextBox();
            this.cboMtrCategory3 = new System.Windows.Forms.ComboBox();
            this.txtMtrName3 = new System.Windows.Forms.TextBox();
            this.txtMtrID2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnUpdateImg2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.picMtr2 = new System.Windows.Forms.PictureBox();
            this.txtMtrNote2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMtr2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(515, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Size = new System.Drawing.Size(515, 474);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucCloseButton1);
            this.panel3.Controls.Add(this.ucSaveButton1);
            this.panel3.Location = new System.Drawing.Point(0, 425);
            this.panel3.Size = new System.Drawing.Size(515, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.Text = "자재 등록";
            // 
            // ucSaveButton1
            // 
            this.ucSaveButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSaveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSaveButton1.Location = new System.Drawing.Point(325, 8);
            this.ucSaveButton1.Name = "ucSaveButton1";
            this.ucSaveButton1.Size = new System.Drawing.Size(80, 32);
            this.ucSaveButton1.TabIndex = 7;
            this.ucSaveButton1.BtnClick += new System.EventHandler(this.ucSaveButton1_BtnClick);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucCloseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucCloseButton1.Location = new System.Drawing.Point(424, 8);
            this.ucCloseButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(80, 32);
            this.ucCloseButton1.TabIndex = 8;
            this.ucCloseButton1.BtnClick += new System.EventHandler(this.ucCloseButton1_BtnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "비고";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTime2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSafeQty2);
            this.groupBox1.Controls.Add(this.txtMtrQty2);
            this.groupBox1.Controls.Add(this.cboMtrCategory3);
            this.groupBox1.Controls.Add(this.txtMtrName3);
            this.groupBox1.Controls.Add(this.txtMtrID2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.btnUpdateImg2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.picMtr2);
            this.groupBox1.Controls.Add(this.txtMtrNote2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 413);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "자재 정보";
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(113, 281);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(113, 25);
            this.txtTime2.TabIndex = 5;
            this.txtTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(229, 285);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 17);
            this.label19.TabIndex = 58;
            this.label19.Text = "MIN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(232, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 17);
            this.label17.TabIndex = 56;
            this.label17.Text = "EA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(232, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 17);
            this.label16.TabIndex = 55;
            this.label16.Text = "EA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "공정시간";
            // 
            // txtSafeQty2
            // 
            this.txtSafeQty2.Location = new System.Drawing.Point(113, 232);
            this.txtSafeQty2.Name = "txtSafeQty2";
            this.txtSafeQty2.Size = new System.Drawing.Size(113, 25);
            this.txtSafeQty2.TabIndex = 4;
            this.txtSafeQty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMtrQty2
            // 
            this.txtMtrQty2.Location = new System.Drawing.Point(113, 183);
            this.txtMtrQty2.Name = "txtMtrQty2";
            this.txtMtrQty2.Size = new System.Drawing.Size(113, 25);
            this.txtMtrQty2.TabIndex = 3;
            this.txtMtrQty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboMtrCategory3
            // 
            this.cboMtrCategory3.FormattingEnabled = true;
            this.cboMtrCategory3.Location = new System.Drawing.Point(113, 134);
            this.cboMtrCategory3.Name = "cboMtrCategory3";
            this.cboMtrCategory3.Size = new System.Drawing.Size(147, 25);
            this.cboMtrCategory3.TabIndex = 2;
            // 
            // txtMtrName3
            // 
            this.txtMtrName3.Location = new System.Drawing.Point(113, 85);
            this.txtMtrName3.Name = "txtMtrName3";
            this.txtMtrName3.Size = new System.Drawing.Size(147, 25);
            this.txtMtrName3.TabIndex = 1;
            // 
            // txtMtrID2
            // 
            this.txtMtrID2.Location = new System.Drawing.Point(113, 36);
            this.txtMtrID2.Name = "txtMtrID2";
            this.txtMtrID2.Size = new System.Drawing.Size(147, 25);
            this.txtMtrID2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "자재코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "자재 명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "자재 안전수량";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 137);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "자재 카테고리";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 186);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 17);
            this.label21.TabIndex = 44;
            this.label21.Text = "자재 초기수량";
            // 
            // btnUpdateImg2
            // 
            this.btnUpdateImg2.Location = new System.Drawing.Point(312, 279);
            this.btnUpdateImg2.Name = "btnUpdateImg2";
            this.btnUpdateImg2.Size = new System.Drawing.Size(141, 39);
            this.btnUpdateImg2.TabIndex = 15;
            this.btnUpdateImg2.Text = "이미지 등록";
            this.btnUpdateImg2.UseVisualStyleBackColor = true;
            this.btnUpdateImg2.Click += new System.EventHandler(this.btnUpdateImg2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "자재 이미지";
            // 
            // picMtr2
            // 
            this.picMtr2.Location = new System.Drawing.Point(283, 46);
            this.picMtr2.Name = "picMtr2";
            this.picMtr2.Size = new System.Drawing.Size(203, 227);
            this.picMtr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMtr2.TabIndex = 13;
            this.picMtr2.TabStop = false;
            // 
            // txtMtrNote2
            // 
            this.txtMtrNote2.Location = new System.Drawing.Point(113, 340);
            this.txtMtrNote2.Multiline = true;
            this.txtMtrNote2.Name = "txtMtrNote2";
            this.txtMtrNote2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMtrNote2.Size = new System.Drawing.Size(363, 67);
            this.txtMtrNote2.TabIndex = 6;
            // 
            // frmMaterialRegistPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(515, 526);
            this.Name = "frmMaterialRegistPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmMaterialRegistPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMtr2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private ucCloseButton ucCloseButton1;
        private ucSaveButton ucSaveButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMtrNote2;
        private System.Windows.Forms.Button btnUpdateImg2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox picMtr2;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSafeQty2;
        private System.Windows.Forms.TextBox txtMtrQty2;
        private System.Windows.Forms.ComboBox cboMtrCategory3;
        private System.Windows.Forms.TextBox txtMtrName3;
        private System.Windows.Forms.TextBox txtMtrID2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}
