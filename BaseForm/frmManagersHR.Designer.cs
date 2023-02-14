
namespace Team2
{
    partial class frmManagersHR
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmAddr = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.ucSBUpdata = new Team2.ucSaveButton();
            this.ucAddr = new Team2.ucAddr();
            this.cbmRank = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.cbmDept = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmPhone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHR = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cbmDeptSearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.ucSearchButton1 = new Team2.ucSearchButton();
            this.ucRefreshButton1 = new Team2.ucRefreshButton();
            this.ucInsertButton21 = new Team2.ucInsertButton2();
            this.pnlSearch.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlSubTitle.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.ucRefreshButton1);
            this.pnlSearch.Controls.Add(this.ucSearchButton1);
            this.pnlSearch.Controls.Add(this.cbmDeptSearch);
            this.pnlSearch.Controls.Add(this.label10);
            this.pnlSearch.Controls.Add(this.txtNameSearch);
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txtIDSearch);
            this.pnlSearch.Controls.Add(this.label9);
            this.pnlSearch.Location = new System.Drawing.Point(0, 80);
            this.pnlSearch.Size = new System.Drawing.Size(1611, 66);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Size = new System.Drawing.Size(135, 35);
            this.lblTitle.Text = "인사 관리";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvHR);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Location = new System.Drawing.Point(0, 202);
            this.pnlMain.Size = new System.Drawing.Size(1611, 779);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubTitle.Size = new System.Drawing.Size(87, 22);
            this.lblSubTitle.Text = "직원 목록";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlTitle.Size = new System.Drawing.Size(1611, 80);
            // 
            // pnlSubTitle
            // 
            this.pnlSubTitle.Controls.Add(this.ucInsertButton21);
            this.pnlSubTitle.Location = new System.Drawing.Point(0, 146);
            this.pnlSubTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlSubTitle.Size = new System.Drawing.Size(1611, 56);
            this.pnlSubTitle.Controls.SetChildIndex(this.lblSubTitle, 0);
            this.pnlSubTitle.Controls.SetChildIndex(this.ucInsertButton21, 0);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.groupBox1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlInfo.Location = new System.Drawing.Point(1100, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(511, 779);
            this.pnlInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbmAddr);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ucSBUpdata);
            this.groupBox1.Controls.Add(this.ucAddr);
            this.groupBox1.Controls.Add(this.cbmRank);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.cbmDept);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbmPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(32, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(468, 664);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "직원 정보";
            // 
            // cbmAddr
            // 
            this.cbmAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbmAddr.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmAddr.FormattingEnabled = true;
            this.cbmAddr.Location = new System.Drawing.Point(115, 392);
            this.cbmAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmAddr.Name = "cbmAddr";
            this.cbmAddr.Size = new System.Drawing.Size(157, 30);
            this.cbmAddr.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdbF);
            this.groupBox2.Controls.Add(this.rdbM);
            this.groupBox2.Location = new System.Drawing.Point(313, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(139, 133);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // rdbF
            // 
            this.rdbF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbF.AutoSize = true;
            this.rdbF.Location = new System.Drawing.Point(15, 32);
            this.rdbF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(92, 26);
            this.rdbF.TabIndex = 1;
            this.rdbF.TabStop = true;
            this.rdbF.Tag = "F";
            this.rdbF.Text = "Female";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // rdbM
            // 
            this.rdbM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(16, 83);
            this.rdbM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(74, 26);
            this.rdbM.TabIndex = 0;
            this.rdbM.TabStop = true;
            this.rdbM.Tag = "M";
            this.rdbM.Text = "Male";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // ucSBUpdata
            // 
            this.ucSBUpdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSBUpdata.BackColor = System.Drawing.Color.Transparent;
            this.ucSBUpdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSBUpdata.Location = new System.Drawing.Point(352, 597);
            this.ucSBUpdata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucSBUpdata.Name = "ucSBUpdata";
            this.ucSBUpdata.Size = new System.Drawing.Size(98, 42);
            this.ucSBUpdata.TabIndex = 12;
            this.ucSBUpdata.BtnClick += new System.EventHandler(this.ucSBUpdata_BtnClick);
            // 
            // ucAddr
            // 
            this.ucAddr.Addr1 = "";
            this.ucAddr.Addr2 = "";
            this.ucAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAddr.BackColor = System.Drawing.Color.White;
            this.ucAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucAddr.Location = new System.Drawing.Point(111, 446);
            this.ucAddr.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.ucAddr.Name = "ucAddr";
            this.ucAddr.Size = new System.Drawing.Size(337, 143);
            this.ucAddr.TabIndex = 11;
            this.ucAddr.ZipCode = "";
            // 
            // cbmRank
            // 
            this.cbmRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbmRank.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmRank.FormattingEnabled = true;
            this.cbmRank.Location = new System.Drawing.Point(115, 219);
            this.cbmRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmRank.Name = "cbmRank";
            this.cbmRank.Size = new System.Drawing.Size(168, 30);
            this.cbmRank.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(49, 397);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "지역";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(49, 455);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "주소";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmail.Location = new System.Drawing.Point(115, 335);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 29);
            this.txtEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(32, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "이메일";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtphone
            // 
            this.txtphone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphone.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtphone.Location = new System.Drawing.Point(233, 277);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(218, 29);
            this.txtphone.TabIndex = 5;
            // 
            // cbmDept
            // 
            this.cbmDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbmDept.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmDept.FormattingEnabled = true;
            this.cbmDept.Location = new System.Drawing.Point(115, 161);
            this.cbmDept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmDept.Name = "cbmDept";
            this.cbmDept.Size = new System.Drawing.Size(168, 30);
            this.cbmDept.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(15, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "전화번호";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(49, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "직책";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbmPhone
            // 
            this.cbmPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbmPhone.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmPhone.FormattingEnabled = true;
            this.cbmPhone.Location = new System.Drawing.Point(115, 277);
            this.cbmPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmPhone.Name = "cbmPhone";
            this.cbmPhone.Size = new System.Drawing.Size(110, 30);
            this.cbmPhone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(49, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "부서";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.Location = new System.Drawing.Point(115, 103);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 29);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(115, 45);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(336, 29);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "직원 ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvHR
            // 
            this.dgvHR.BackgroundColor = System.Drawing.Color.White;
            this.dgvHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHR.Location = new System.Drawing.Point(0, 0);
            this.dgvHR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvHR.Name = "dgvHR";
            this.dgvHR.RowHeadersWidth = 51;
            this.dgvHR.RowTemplate.Height = 23;
            this.dgvHR.Size = new System.Drawing.Size(1100, 779);
            this.dgvHR.TabIndex = 1;
            this.dgvHR.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHR_CellClick);
            this.dgvHR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHR_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(21, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "바코드";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbmDeptSearch
            // 
            this.cbmDeptSearch.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmDeptSearch.FormattingEnabled = true;
            this.cbmDeptSearch.Location = new System.Drawing.Point(721, 16);
            this.cbmDeptSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmDeptSearch.Name = "cbmDeptSearch";
            this.cbmDeptSearch.Size = new System.Drawing.Size(168, 30);
            this.cbmDeptSearch.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(656, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "부서";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNameSearch.Location = new System.Drawing.Point(438, 16);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(149, 29);
            this.txtNameSearch.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(374, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "이름";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtIDSearch.Location = new System.Drawing.Point(99, 16);
            this.txtIDSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(228, 29);
            this.txtIDSearch.TabIndex = 0;
            // 
            // ucSearchButton1
            // 
            this.ucSearchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSearchButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchButton1.ForeColor = System.Drawing.Color.White;
            this.ucSearchButton1.Location = new System.Drawing.Point(1499, 11);
            this.ucSearchButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchButton1.Name = "ucSearchButton1";
            this.ucSearchButton1.Size = new System.Drawing.Size(98, 42);
            this.ucSearchButton1.TabIndex = 3;
            this.ucSearchButton1.BtnClick += new System.EventHandler(this.ucSearchButton1_BtnClick);
            // 
            // ucRefreshButton1
            // 
            this.ucRefreshButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRefreshButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucRefreshButton1.Location = new System.Drawing.Point(1457, 11);
            this.ucRefreshButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucRefreshButton1.Name = "ucRefreshButton1";
            this.ucRefreshButton1.Size = new System.Drawing.Size(37, 42);
            this.ucRefreshButton1.TabIndex = 4;
            this.ucRefreshButton1.BtnClick += new System.EventHandler(this.ucRefreshButton1_BtnClick);
            // 
            // ucInsertButton21
            // 
            this.ucInsertButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInsertButton21.BackColor = System.Drawing.Color.Transparent;
            this.ucInsertButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucInsertButton21.Location = new System.Drawing.Point(1499, 7);
            this.ucInsertButton21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucInsertButton21.Name = "ucInsertButton21";
            this.ucInsertButton21.Size = new System.Drawing.Size(98, 42);
            this.ucInsertButton21.TabIndex = 1;
            this.ucInsertButton21.BtnClick += new System.EventHandler(this.ucInsertButton21_BtnClick);
            // 
            // frmManagersHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(1611, 981);
            this.Name = "frmManagersHR";
            this.Load += new System.EventHandler(this.frmManagersHR_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSubTitle.ResumeLayout(false);
            this.pnlSubTitle.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.DataGridView dgvHR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ComboBox cbmDept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmDeptSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label9;
        private ucAddr ucAddr;
        private ucSaveButton ucSBUpdata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbM;
        private ucSearchButton ucSearchButton1;
        private ucRefreshButton ucRefreshButton1;
        private System.Windows.Forms.ComboBox cbmAddr;
        private System.Windows.Forms.Label label12;
        private ucInsertButton2 ucInsertButton21;
    }
}
