
namespace Team2
{
    partial class frmOrderManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblRequestDate = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.ucExcelButton1 = new Team2.ucExcelButton();
            this.btnSelect = new Team2.ucSearchButton();
            this.dtpOrderDT = new Team2.ucDateTimePickerSet();
            this.dtpOrderDueDT = new Team2.ucDateTimePickerSet();
            this.ucSearchSmall1 = new Team2.ucSearchSmall();
            this.ucSearchSmall2 = new Team2.ucSearchSmall();
            this.btnRefresh = new Team2.ucRefreshButton();
            this.panItem = new System.Windows.Forms.Panel();
            this.btnDelete = new Team2.Controls.ucCancleButton();
            this.btnWarehousing = new Team2.ucInButton();
            this.btnUpdate = new Team2.ucUpdateButton();
            this.btnInsert = new Team2.ucInsertButton2();
            this.btnExcel = new Team2.ucExcelButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.panItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.ucSearchSmall2);
            this.panel2.Controls.Add(this.ucSearchSmall1);
            this.panel2.Controls.Add(this.dtpOrderDueDT);
            this.panel2.Controls.Add(this.dtpOrderDT);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.txtClientName);
            this.panel2.Controls.Add(this.lblClientName);
            this.panel2.Controls.Add(this.lblOrderDate);
            this.panel2.Controls.Add(this.lblRequestDate);
            this.panel2.Controls.Add(this.txtOrderNo);
            this.panel2.Controls.Add(this.lblOrderNo);
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.txtEmployee);
            this.panel2.Controls.Add(this.lblEmployee);
            this.panel2.Controls.Add(this.cboState);
            this.panel2.Size = new System.Drawing.Size(1834, 124);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1834, 57);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.Text = "주문 관리";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1834, 880);
            this.splitContainer1.SplitterDistance = 537;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panItem);
            this.panel3.Size = new System.Drawing.Size(1834, 42);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.panItem, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnExcel);
            this.panel4.Controls.Add(this.ucExcelButton1);
            this.panel4.Size = new System.Drawing.Size(1834, 42);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.ucExcelButton1, 0);
            this.panel4.Controls.SetChildIndex(this.btnExcel, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvOrder);
            this.panel5.Size = new System.Drawing.Size(1834, 495);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvOrderDetails);
            this.panel6.Size = new System.Drawing.Size(1834, 296);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.Text = "주문목록";
            // 
            // label4
            // 
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.Text = "주문상세";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 30;
            this.dgvOrder.Size = new System.Drawing.Size(1834, 495);
            this.dgvOrder.TabIndex = 65;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            this.dgvOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.AutoSize = true;
            this.lblRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRequestDate.Location = new System.Drawing.Point(849, 77);
            this.lblRequestDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(86, 18);
            this.lblRequestDate.TabIndex = 119;
            this.lblRequestDate.Text = "납기요청일자";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNo.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOrderNo.Location = new System.Drawing.Point(517, 27);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(263, 25);
            this.txtOrderNo.TabIndex = 118;
            this.txtOrderNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNo_KeyPress);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderNo.Location = new System.Drawing.Point(447, 31);
            this.lblOrderNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(60, 18);
            this.lblOrderNo.TabIndex = 117;
            this.lblOrderNo.Text = "주문번호";
            // 
            // txtEmployee
            // 
            this.txtEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployee.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmployee.Location = new System.Drawing.Point(85, 73);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(253, 25);
            this.txtEmployee.TabIndex = 116;
            this.txtEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployee_KeyPress);
            // 
            // cboState
            // 
            this.cboState.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(951, 27);
            this.cboState.Margin = new System.Windows.Forms.Padding(4);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 25);
            this.cboState.TabIndex = 115;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEmployee.Location = new System.Drawing.Point(29, 77);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(47, 18);
            this.lblEmployee.TabIndex = 113;
            this.lblEmployee.Text = "담당자";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblState.Location = new System.Drawing.Point(905, 31);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(34, 18);
            this.lblState.TabIndex = 112;
            this.lblState.Text = "상태";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderDate.Location = new System.Drawing.Point(447, 77);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(60, 18);
            this.lblOrderDate.TabIndex = 108;
            this.lblOrderDate.Text = "주문일자";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClientName.Location = new System.Drawing.Point(15, 31);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(60, 18);
            this.lblClientName.TabIndex = 107;
            this.lblClientName.Text = "거래처명";
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientName.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtClientName.Location = new System.Drawing.Point(85, 27);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(253, 25);
            this.txtClientName.TabIndex = 106;
            this.txtClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClientName_KeyPress);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToResizeColumns = false;
            this.dgvOrderDetails.AllowUserToResizeRows = false;
            this.dgvOrderDetails.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDetails.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersVisible = false;
            this.dgvOrderDetails.RowTemplate.Height = 30;
            this.dgvOrderDetails.Size = new System.Drawing.Size(1834, 296);
            this.dgvOrderDetails.TabIndex = 1;
            // 
            // ucExcelButton1
            // 
            this.ucExcelButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucExcelButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucExcelButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucExcelButton1.Location = new System.Drawing.Point(4591, 5);
            this.ucExcelButton1.Name = "ucExcelButton1";
            this.ucExcelButton1.Size = new System.Drawing.Size(80, 32);
            this.ucExcelButton1.TabIndex = 137;
            this.ucExcelButton1.BtnClick += new System.EventHandler(this.ucExcelButton1_BtnClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(1745, 27);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 30);
            this.btnSelect.TabIndex = 147;
            this.btnSelect.BtnClick += new System.EventHandler(this.btnSelect_BtnClick);
            // 
            // dtpOrderDT
            // 
            this.dtpOrderDT.EndDate = new System.DateTime(2022, 12, 21, 17, 41, 24, 701);
            this.dtpOrderDT.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpOrderDT.Location = new System.Drawing.Point(518, 70);
            this.dtpOrderDT.Name = "dtpOrderDT";
            this.dtpOrderDT.Size = new System.Drawing.Size(297, 31);
            this.dtpOrderDT.StartDate = new System.DateTime(2022, 12, 21, 17, 41, 24, 704);
            this.dtpOrderDT.TabIndex = 148;
            // 
            // dtpOrderDueDT
            // 
            this.dtpOrderDueDT.EndDate = new System.DateTime(2022, 12, 21, 17, 41, 38, 512);
            this.dtpOrderDueDT.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpOrderDueDT.Location = new System.Drawing.Point(949, 70);
            this.dtpOrderDueDT.Name = "dtpOrderDueDT";
            this.dtpOrderDueDT.Size = new System.Drawing.Size(297, 31);
            this.dtpOrderDueDT.StartDate = new System.DateTime(2022, 12, 21, 17, 41, 38, 514);
            this.dtpOrderDueDT.TabIndex = 149;
            // 
            // ucSearchSmall1
            // 
            this.ucSearchSmall1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchSmall1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchSmall1.Location = new System.Drawing.Point(354, 27);
            this.ucSearchSmall1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchSmall1.Name = "ucSearchSmall1";
            this.ucSearchSmall1.Size = new System.Drawing.Size(25, 25);
            this.ucSearchSmall1.TabIndex = 150;
            this.ucSearchSmall1.BtnClick += new System.EventHandler(this.ucSearchSmall1_BtnClick);
            // 
            // ucSearchSmall2
            // 
            this.ucSearchSmall2.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchSmall2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchSmall2.Location = new System.Drawing.Point(354, 73);
            this.ucSearchSmall2.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchSmall2.Name = "ucSearchSmall2";
            this.ucSearchSmall2.Size = new System.Drawing.Size(25, 25);
            this.ucSearchSmall2.TabIndex = 151;
            this.ucSearchSmall2.BtnClick += new System.EventHandler(this.ucSearchSmall2_BtnClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Location = new System.Drawing.Point(1702, 27);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 30);
            this.btnRefresh.TabIndex = 152;
            this.btnRefresh.BtnClick += new System.EventHandler(this.btnRefresh_BtnClick);
            // 
            // panItem
            // 
            this.panItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panItem.Controls.Add(this.btnDelete);
            this.panItem.Controls.Add(this.btnWarehousing);
            this.panItem.Controls.Add(this.btnUpdate);
            this.panItem.Controls.Add(this.btnInsert);
            this.panItem.Location = new System.Drawing.Point(3734, 5);
            this.panItem.Name = "panItem";
            this.panItem.Size = new System.Drawing.Size(367, 34);
            this.panItem.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(285, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 153;
            this.btnDelete.BtnClick += new System.EventHandler(this.btnDelete_BtnClick);
            // 
            // btnWarehousing
            // 
            this.btnWarehousing.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWarehousing.Location = new System.Drawing.Point(12, 2);
            this.btnWarehousing.Name = "btnWarehousing";
            this.btnWarehousing.Size = new System.Drawing.Size(80, 30);
            this.btnWarehousing.TabIndex = 154;
            this.btnWarehousing.BtnClick += new System.EventHandler(this.btnWarehousing_BtnClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(194, 1);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 32);
            this.btnUpdate.TabIndex = 127;
            this.btnUpdate.BtnClick += new System.EventHandler(this.btnUpdate_BtnClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(103, 1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(80, 32);
            this.btnInsert.TabIndex = 128;
            this.btnInsert.BtnClick += new System.EventHandler(this.btnInsert_BtnClick_1);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.Location = new System.Drawing.Point(1965, 6);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(80, 30);
            this.btnExcel.TabIndex = 138;
            this.btnExcel.BtnClick += new System.EventHandler(this.ucExcelButton1_BtnClick);
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1834, 1061);
            this.Name = "frmOrderManagement";
            this.Load += new System.EventHandler(this.frmOrderManagement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.panItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblRequestDate;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private ucExcelButton ucExcelButton1;
        private ucSearchSmall ucSearchSmall2;
        private ucSearchSmall ucSearchSmall1;
        private ucDateTimePickerSet dtpOrderDueDT;
        private ucDateTimePickerSet dtpOrderDT;
        private ucSearchButton btnSelect;
        private ucRefreshButton btnRefresh;
        private System.Windows.Forms.Panel panItem;
        private Controls.ucCancleButton btnDelete;
        private ucInButton btnWarehousing;
        private ucUpdateButton btnUpdate;
        private ucInsertButton2 btnInsert;
        private ucExcelButton btnExcel;
    }
}
