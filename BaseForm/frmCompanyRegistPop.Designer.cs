
namespace Team2
{
    partial class frmCompanyRegistPop
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtBusinessNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchCMP2 = new Team2.ucSearchSmall();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucAddrCompany = new Team2.ucAddr();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoOutput2 = new System.Windows.Forms.RadioButton();
            this.rdoInput2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCompanyArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCompanyNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyName2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboManagerPosition = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtManagerEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboAgency = new System.Windows.Forms.ComboBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ucSaveButton1 = new Team2.ucSaveButton();
            this.ucCloseButton1 = new Team2.ucCloseButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(445, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Size = new System.Drawing.Size(445, 561);
            this.panel2.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucCloseButton1);
            this.panel3.Controls.Add(this.ucSaveButton1);
            this.panel3.Location = new System.Drawing.Point(0, 512);
            this.panel3.Size = new System.Drawing.Size(445, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.Text = "거래처 정보";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtCompanyID);
            this.groupBox2.Controls.Add(this.txtBusinessNum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnSearchCMP2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ucAddrCompany);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboCompanyArea);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCompanyNum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCompanyName2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(17, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(410, 315);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "회사 정보";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(338, 40);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(12, 25);
            this.txtCompanyID.TabIndex = 45;
            this.txtCompanyID.Visible = false;
            // 
            // txtBusinessNum
            // 
            this.txtBusinessNum.Location = new System.Drawing.Point(120, 33);
            this.txtBusinessNum.Name = "txtBusinessNum";
            this.txtBusinessNum.Size = new System.Drawing.Size(181, 25);
            this.txtBusinessNum.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(17, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = "사업자 번호";
            // 
            // btnSearchCMP2
            // 
            this.btnSearchCMP2.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCMP2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearchCMP2.Location = new System.Drawing.Point(305, 107);
            this.btnSearchCMP2.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchCMP2.Name = "btnSearchCMP2";
            this.btnSearchCMP2.Size = new System.Drawing.Size(25, 25);
            this.btnSearchCMP2.TabIndex = 42;
            this.btnSearchCMP2.BtnClick += new System.EventHandler(this.btnSearchCMP2_BtnClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(31, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "상세 주소";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(36, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "우편번호";
            // 
            // ucAddrCompany
            // 
            this.ucAddrCompany.Addr1 = "";
            this.ucAddrCompany.Addr2 = "";
            this.ucAddrCompany.BackColor = System.Drawing.Color.White;
            this.ucAddrCompany.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucAddrCompany.Location = new System.Drawing.Point(117, 212);
            this.ucAddrCompany.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucAddrCompany.Name = "ucAddrCompany";
            this.ucAddrCompany.Size = new System.Drawing.Size(276, 96);
            this.ucAddrCompany.TabIndex = 39;
            this.ucAddrCompany.ZipCode = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoOutput2);
            this.groupBox3.Controls.Add(this.rdoInput2);
            this.groupBox3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(120, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(181, 40);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // rdoOutput2
            // 
            this.rdoOutput2.AutoSize = true;
            this.rdoOutput2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoOutput2.Location = new System.Drawing.Point(96, 12);
            this.rdoOutput2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoOutput2.Name = "rdoOutput2";
            this.rdoOutput2.Size = new System.Drawing.Size(68, 21);
            this.rdoOutput2.TabIndex = 36;
            this.rdoOutput2.TabStop = true;
            this.rdoOutput2.Text = "매출처";
            this.rdoOutput2.UseVisualStyleBackColor = true;
            // 
            // rdoInput2
            // 
            this.rdoInput2.AutoSize = true;
            this.rdoInput2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdoInput2.Location = new System.Drawing.Point(11, 12);
            this.rdoInput2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoInput2.Name = "rdoInput2";
            this.rdoInput2.Size = new System.Drawing.Size(68, 21);
            this.rdoInput2.TabIndex = 35;
            this.rdoInput2.TabStop = true;
            this.rdoInput2.Text = "매입처";
            this.rdoInput2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "거래처 구분";
            // 
            // cboCompanyArea
            // 
            this.cboCompanyArea.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboCompanyArea.FormattingEnabled = true;
            this.cboCompanyArea.Location = new System.Drawing.Point(120, 177);
            this.cboCompanyArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCompanyArea.Name = "cboCompanyArea";
            this.cboCompanyArea.Size = new System.Drawing.Size(181, 25);
            this.cboCompanyArea.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(17, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "거래처 위치";
            // 
            // txtCompanyNum
            // 
            this.txtCompanyNum.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyNum.Location = new System.Drawing.Point(120, 142);
            this.txtCompanyNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompanyNum.Name = "txtCompanyNum";
            this.txtCompanyNum.Size = new System.Drawing.Size(181, 25);
            this.txtCompanyNum.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(36, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "전화번호";
            // 
            // txtCompanyName2
            // 
            this.txtCompanyName2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCompanyName2.Location = new System.Drawing.Point(120, 107);
            this.txtCompanyName2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompanyName2.Name = "txtCompanyName2";
            this.txtCompanyName2.Size = new System.Drawing.Size(181, 25);
            this.txtCompanyName2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "거래처 명";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboManagerPosition);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtManagerEmail);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboAgency);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtManagerName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(17, 326);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(410, 177);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "거래처 직원 정보";
            // 
            // cboManagerPosition
            // 
            this.cboManagerPosition.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboManagerPosition.FormattingEnabled = true;
            this.cboManagerPosition.Location = new System.Drawing.Point(120, 72);
            this.cboManagerPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboManagerPosition.Name = "cboManagerPosition";
            this.cboManagerPosition.Size = new System.Drawing.Size(145, 25);
            this.cboManagerPosition.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(17, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "담당자 직책";
            // 
            // txtManagerEmail
            // 
            this.txtManagerEmail.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtManagerEmail.Location = new System.Drawing.Point(120, 142);
            this.txtManagerEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtManagerEmail.Name = "txtManagerEmail";
            this.txtManagerEmail.Size = new System.Drawing.Size(230, 25);
            this.txtManagerEmail.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(3, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "담당자 이메일";
            // 
            // cboAgency
            // 
            this.cboAgency.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboAgency.FormattingEnabled = true;
            this.cboAgency.Location = new System.Drawing.Point(120, 107);
            this.cboAgency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboAgency.Name = "cboAgency";
            this.cboAgency.Size = new System.Drawing.Size(70, 25);
            this.cboAgency.TabIndex = 6;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPhoneNum.Location = new System.Drawing.Point(198, 107);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(152, 25);
            this.txtPhoneNum.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "담당자 연락처";
            // 
            // txtManagerName
            // 
            this.txtManagerName.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtManagerName.Location = new System.Drawing.Point(120, 37);
            this.txtManagerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(145, 25);
            this.txtManagerName.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(18, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "담당자 이름";
            // 
            // ucSaveButton1
            // 
            this.ucSaveButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSaveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSaveButton1.Location = new System.Drawing.Point(258, 9);
            this.ucSaveButton1.Name = "ucSaveButton1";
            this.ucSaveButton1.Size = new System.Drawing.Size(80, 32);
            this.ucSaveButton1.TabIndex = 9;
            this.ucSaveButton1.BtnClick += new System.EventHandler(this.ucSaveButton1_BtnClick);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucCloseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucCloseButton1.Location = new System.Drawing.Point(347, 9);
            this.ucCloseButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(80, 32);
            this.ucCloseButton1.TabIndex = 10;
            this.ucCloseButton1.BtnClick += new System.EventHandler(this.ucCloseButton1_BtnClick);
            // 
            // frmCompanyRegistPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(445, 613);
            this.Name = "frmCompanyRegistPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmCompanyRegistPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBusinessNum;
        private System.Windows.Forms.Label label9;
        private ucSearchSmall btnSearchCMP2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private ucAddr ucAddrCompany;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoOutput2;
        private System.Windows.Forms.RadioButton rdoInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCompanyArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCompanyNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompanyName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtManagerEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboAgency;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.Label label8;
        private ucCloseButton ucCloseButton1;
        private ucSaveButton ucSaveButton1;
        private System.Windows.Forms.ComboBox cboManagerPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCompanyID;
    }
}
