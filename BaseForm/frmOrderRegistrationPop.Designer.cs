
namespace Team2
{
    partial class frmOrderRegistrationPop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new Team2.ucDeleteButton();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.panMenuP = new System.Windows.Forms.Panel();
            this.btnRefresh = new Team2.ucRefreshButton();
            this.btnInsert = new Team2.ucInsertButton();
            this.lblTotAmount = new System.Windows.Forms.Label();
            this.txtTotAmount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.lblPAmount = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.nudCnt = new System.Windows.Forms.NumericUpDown();
            this.lblPCnt = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtSumAmount = new System.Windows.Forms.TextBox();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.btnClientName = new Team2.ucSearchSmall();
            this.btnEmpID = new Team2.ucSearchSmall();
            this.btnSave = new Team2.ucSaveButton();
            this.btnClose = new Team2.ucCloseButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.panMenuP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCnt)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1419, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEmpID);
            this.panel2.Controls.Add(this.btnClientName);
            this.panel2.Controls.Add(this.dtpOrderDate);
            this.panel2.Controls.Add(this.lblEmpID);
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Controls.Add(this.lblAmount);
            this.panel2.Controls.Add(this.txtSumAmount);
            this.panel2.Controls.Add(this.lblRequestDate);
            this.panel2.Controls.Add(this.dtpRequestDate);
            this.panel2.Controls.Add(this.lblOrderDate);
            this.panel2.Controls.Add(this.lblOrderNo);
            this.panel2.Controls.Add(this.txtOrderNo);
            this.panel2.Controls.Add(this.lblClientName);
            this.panel2.Controls.Add(this.txtClientName);
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Size = new System.Drawing.Size(1419, 726);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.splitContainer1, 0);
            this.panel2.Controls.SetChildIndex(this.txtClientName, 0);
            this.panel2.Controls.SetChildIndex(this.lblClientName, 0);
            this.panel2.Controls.SetChildIndex(this.txtOrderNo, 0);
            this.panel2.Controls.SetChildIndex(this.lblOrderNo, 0);
            this.panel2.Controls.SetChildIndex(this.lblOrderDate, 0);
            this.panel2.Controls.SetChildIndex(this.dtpRequestDate, 0);
            this.panel2.Controls.SetChildIndex(this.lblRequestDate, 0);
            this.panel2.Controls.SetChildIndex(this.txtSumAmount, 0);
            this.panel2.Controls.SetChildIndex(this.lblAmount, 0);
            this.panel2.Controls.SetChildIndex(this.txtEmpID, 0);
            this.panel2.Controls.SetChildIndex(this.lblEmpID, 0);
            this.panel2.Controls.SetChildIndex(this.dtpOrderDate, 0);
            this.panel2.Controls.SetChildIndex(this.btnClientName, 0);
            this.panel2.Controls.SetChildIndex(this.btnEmpID, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(0, 677);
            this.panel3.Size = new System.Drawing.Size(1419, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.Text = "신규주문 등록";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 120);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDetails);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panMenuP);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotAmount);
            this.splitContainer1.Panel2.Controls.Add(this.txtTotAmount);
            this.splitContainer1.Panel2.Controls.Add(this.txtStock);
            this.splitContainer1.Panel2.Controls.Add(this.lblStock);
            this.splitContainer1.Panel2.Controls.Add(this.cboCategory);
            this.splitContainer1.Panel2.Controls.Add(this.lblCategory);
            this.splitContainer1.Panel2.Controls.Add(this.cboProductName);
            this.splitContainer1.Panel2.Controls.Add(this.lblPAmount);
            this.splitContainer1.Panel2.Controls.Add(this.txtProductPrice);
            this.splitContainer1.Panel2.Controls.Add(this.nudCnt);
            this.splitContainer1.Panel2.Controls.Add(this.lblPCnt);
            this.splitContainer1.Panel2.Controls.Add(this.lblProductName);
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Size = new System.Drawing.Size(1419, 557);
            this.splitContainer1.SplitterDistance = 1022;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToResizeRows = false;
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetails.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(0, 42);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowTemplate.Height = 30;
            this.dgvDetails.Size = new System.Drawing.Size(1022, 515);
            this.dgvDetails.TabIndex = 65;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.lblTitle2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 42);
            this.panel4.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(936, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 133;
            this.btnDelete.BtnClick += new System.EventHandler(this.btnDelete_BtnClick);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle2.Location = new System.Drawing.Point(12, 14);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(60, 18);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "상세정보";
            // 
            // panMenuP
            // 
            this.panMenuP.Controls.Add(this.btnRefresh);
            this.panMenuP.Controls.Add(this.btnInsert);
            this.panMenuP.Location = new System.Drawing.Point(209, 398);
            this.panMenuP.Name = "panMenuP";
            this.panMenuP.Size = new System.Drawing.Size(127, 36);
            this.panMenuP.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 132;
            this.btnRefresh.BtnClick += new System.EventHandler(this.btnRefresh_BtnClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(42, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 30);
            this.btnInsert.TabIndex = 131;
            this.btnInsert.BtnClick += new System.EventHandler(this.btnInsert_BtnClick_1);
            // 
            // lblTotAmount
            // 
            this.lblTotAmount.AutoSize = true;
            this.lblTotAmount.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotAmount.Location = new System.Drawing.Point(35, 354);
            this.lblTotAmount.Name = "lblTotAmount";
            this.lblTotAmount.Size = new System.Drawing.Size(100, 17);
            this.lblTotAmount.TabIndex = 130;
            this.lblTotAmount.Text = "제품당 총 금액";
            this.lblTotAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotAmount
            // 
            this.txtTotAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotAmount.Enabled = false;
            this.txtTotAmount.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTotAmount.Location = new System.Drawing.Point(151, 350);
            this.txtTotAmount.Name = "txtTotAmount";
            this.txtTotAmount.ReadOnly = true;
            this.txtTotAmount.Size = new System.Drawing.Size(181, 25);
            this.txtTotAmount.TabIndex = 129;
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStock.Location = new System.Drawing.Point(219, 199);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(114, 25);
            this.txtStock.TabIndex = 127;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStock.Location = new System.Drawing.Point(177, 203);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 17);
            this.lblStock.TabIndex = 126;
            this.lblStock.Text = "재고";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(152, 105);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(181, 25);
            this.cboCategory.TabIndex = 125;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCategory.Location = new System.Drawing.Point(71, 108);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(64, 17);
            this.lblCategory.TabIndex = 124;
            this.lblCategory.Text = "카테고리";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProductName
            // 
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(152, 152);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(181, 25);
            this.cboProductName.TabIndex = 123;
            this.cboProductName.SelectedIndexChanged += new System.EventHandler(this.cboProductName_SelectedIndexChanged);
            // 
            // lblPAmount
            // 
            this.lblPAmount.AutoSize = true;
            this.lblPAmount.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPAmount.Location = new System.Drawing.Point(71, 303);
            this.lblPAmount.Name = "lblPAmount";
            this.lblPAmount.Size = new System.Drawing.Size(64, 17);
            this.lblPAmount.TabIndex = 122;
            this.lblPAmount.Text = "제품금액";
            this.lblPAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductPrice.Enabled = false;
            this.txtProductPrice.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProductPrice.Location = new System.Drawing.Point(152, 299);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(181, 25);
            this.txtProductPrice.TabIndex = 121;
            // 
            // nudCnt
            // 
            this.nudCnt.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudCnt.Location = new System.Drawing.Point(152, 249);
            this.nudCnt.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudCnt.Name = "nudCnt";
            this.nudCnt.Size = new System.Drawing.Size(180, 25);
            this.nudCnt.TabIndex = 120;
            this.nudCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCnt.ValueChanged += new System.EventHandler(this.nudCnt_ValueChanged);
            // 
            // lblPCnt
            // 
            this.lblPCnt.AutoSize = true;
            this.lblPCnt.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPCnt.Location = new System.Drawing.Point(71, 253);
            this.lblPCnt.Name = "lblPCnt";
            this.lblPCnt.Size = new System.Drawing.Size(64, 17);
            this.lblPCnt.TabIndex = 119;
            this.lblPCnt.Text = "제품수량";
            this.lblPCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProductName.Location = new System.Drawing.Point(85, 155);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(50, 17);
            this.lblProductName.TabIndex = 118;
            this.lblProductName.Text = "제품명";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel7.Controls.Add(this.lblTitle3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(393, 42);
            this.panel7.TabIndex = 3;
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle3.Location = new System.Drawing.Point(23, 14);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(34, 18);
            this.lblTitle3.TabIndex = 0;
            this.lblTitle3.Text = "주문";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(787, 27);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(146, 25);
            this.dtpOrderDate.TabIndex = 114;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmpID.Location = new System.Drawing.Point(338, 76);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(60, 18);
            this.lblEmpID.TabIndex = 110;
            this.lblEmpID.Text = "담당자명";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmpID
            // 
            this.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmpID.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmpID.Location = new System.Drawing.Point(409, 70);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(170, 25);
            this.txtEmpID.TabIndex = 109;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAmount.Location = new System.Drawing.Point(36, 76);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(47, 18);
            this.lblAmount.TabIndex = 104;
            this.lblAmount.Text = "총금액";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSumAmount
            // 
            this.txtSumAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumAmount.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSumAmount.Location = new System.Drawing.Point(95, 70);
            this.txtSumAmount.Name = "txtSumAmount";
            this.txtSumAmount.ReadOnly = true;
            this.txtSumAmount.Size = new System.Drawing.Size(169, 25);
            this.txtSumAmount.TabIndex = 103;
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRequestDate.Location = new System.Drawing.Point(688, 74);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(86, 18);
            this.lblRequestDate.TabIndex = 102;
            this.lblRequestDate.Text = "납기요청일자";
            this.lblRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequestDate.Location = new System.Drawing.Point(787, 70);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(146, 25);
            this.dtpRequestDate.TabIndex = 101;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderDate.Location = new System.Drawing.Point(716, 33);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(60, 18);
            this.lblOrderDate.TabIndex = 100;
            this.lblOrderDate.Text = "주문일자";
            this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderNo.Location = new System.Drawing.Point(22, 33);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(60, 18);
            this.lblOrderNo.TabIndex = 99;
            this.lblOrderNo.Text = "주문번호";
            this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNo.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderNo.Location = new System.Drawing.Point(95, 27);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.ReadOnly = true;
            this.txtOrderNo.Size = new System.Drawing.Size(170, 25);
            this.txtOrderNo.TabIndex = 98;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClientName.Location = new System.Drawing.Point(352, 33);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(47, 18);
            this.lblClientName.TabIndex = 96;
            this.lblClientName.Text = "거래처";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientName.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtClientName.Location = new System.Drawing.Point(409, 27);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(170, 25);
            this.txtClientName.TabIndex = 95;
            // 
            // btnClientName
            // 
            this.btnClientName.BackColor = System.Drawing.Color.Transparent;
            this.btnClientName.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClientName.Location = new System.Drawing.Point(588, 27);
            this.btnClientName.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientName.Name = "btnClientName";
            this.btnClientName.Size = new System.Drawing.Size(25, 25);
            this.btnClientName.TabIndex = 127;
            this.btnClientName.BtnClick += new System.EventHandler(this.btnClientName_BtnClick);
            // 
            // btnEmpID
            // 
            this.btnEmpID.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEmpID.Location = new System.Drawing.Point(588, 70);
            this.btnEmpID.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmpID.Name = "btnEmpID";
            this.btnEmpID.Size = new System.Drawing.Size(25, 25);
            this.btnEmpID.TabIndex = 128;
            this.btnEmpID.BtnClick += new System.EventHandler(this.btnEmpID_BtnClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(1235, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.BtnClick += new System.EventHandler(this.btnSave_BtnClick_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClose.Location = new System.Drawing.Point(1330, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.BtnClick += new System.EventHandler(this.btnClose_BtnClick);
            // 
            // frmOrderRegistrationPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1419, 778);
            this.Name = "frmOrderRegistrationPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOrderRegistrationPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panMenuP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCnt)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtSumAmount;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTotAmount;
        private System.Windows.Forms.TextBox txtTotAmount;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label lblPAmount;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.NumericUpDown nudCnt;
        private System.Windows.Forms.Label lblPCnt;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel panel7;
        protected System.Windows.Forms.Label lblTitle3;
        private ucSearchSmall btnEmpID;
        private ucSearchSmall btnClientName;
        private ucRefreshButton btnRefresh;
        private ucInsertButton btnInsert;
        private ucDeleteButton btnDelete;
        private ucCloseButton btnClose;
        private ucSaveButton btnSave;
        private System.Windows.Forms.Panel panMenuP;
    }
}
