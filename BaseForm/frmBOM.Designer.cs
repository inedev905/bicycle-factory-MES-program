
namespace Team2
{
    partial class frmBOM
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
            this.dgvBom = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ucSBCheck = new Team2.ucSearchButton();
            this.txtLimitQty = new System.Windows.Forms.TextBox();
            this.ucSaveButton1 = new Team2.ucSaveButton();
            this.txtSafeQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pcbItemImage = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ucSSSeat = new Team2.ucSearchSmall();
            this.ucSSDrive = new Team2.ucSearchSmall();
            this.ucSSBrake = new Team2.ucSearchSmall();
            this.ucSSWheel = new Team2.ucSearchSmall();
            this.ucSSFrame = new Team2.ucSearchSmall();
            this.ucSSHansdle = new Team2.ucSearchSmall();
            this.pnlSeat = new System.Windows.Forms.Panel();
            this.lblSeat = new System.Windows.Forms.Label();
            this.pnlWheel = new System.Windows.Forms.Panel();
            this.lblWheel = new System.Windows.Forms.Label();
            this.pnlDrive = new System.Windows.Forms.Panel();
            this.lblDrive = new System.Windows.Forms.Label();
            this.pnlBrake = new System.Windows.Forms.Panel();
            this.lblBrake = new System.Windows.Forms.Label();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.lblFrame = new System.Windows.Forms.Label();
            this.pnlHandle = new System.Windows.Forms.Panel();
            this.lblHandle = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelDrive = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnInputImage = new System.Windows.Forms.Button();
            this.cbmCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEmployeeSignUp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cbmItem = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdbRBom = new System.Windows.Forms.RadioButton();
            this.rdbBom = new System.Windows.Forms.RadioButton();
            this.cbmMaterial = new System.Windows.Forms.ComboBox();
            this.dgvRBom = new System.Windows.Forms.DataGridView();
            this.ucDeleteButton1 = new Team2.ucDeleteButton();
            this.ucInsertButton1 = new Team2.ucInsertButton();
            this.ucSearchButton1 = new Team2.ucSearchButton();
            this.ucUpdateButton1 = new Team2.ucUpdateButton();
            this.ucRefreshButton1 = new Team2.ucRefreshButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemImage)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlSeat.SuspendLayout();
            this.pnlWheel.SuspendLayout();
            this.pnlDrive.SuspendLayout();
            this.pnlBrake.SuspendLayout();
            this.pnlFrame.SuspendLayout();
            this.pnlHandle.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBom)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 135);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(1808, 839);
            this.splitContainer1.SplitterDistance = 1121;
            this.splitContainer1.SplitterWidth = 6;
            // 
            // label1
            // 
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.Text = "BOM 관리";
            // 
            // label3
            // 
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.Text = "제품 목록";
            // 
            // label4
            // 
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.Text = "제품 상세 정보";
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1808, 74);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucRefreshButton1);
            this.panel2.Controls.Add(this.ucSearchButton1);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.cbmMaterial);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.cbmItem);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1808, 61);
            // 
            // panel3
            // 
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(1121, 52);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ucUpdateButton1);
            this.panel4.Controls.Add(this.ucInsertButton1);
            this.panel4.Controls.Add(this.ucDeleteButton1);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Size = new System.Drawing.Size(681, 52);
            this.panel4.Controls.SetChildIndex(this.label4, 0);
            this.panel4.Controls.SetChildIndex(this.ucDeleteButton1, 0);
            this.panel4.Controls.SetChildIndex(this.ucInsertButton1, 0);
            this.panel4.Controls.SetChildIndex(this.ucUpdateButton1, 0);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvRBom);
            this.panel5.Controls.Add(this.dgvBom);
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Size = new System.Drawing.Size(1121, 787);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.btnEmployeeSignUp);
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Location = new System.Drawing.Point(0, 52);
            this.panel6.Margin = new System.Windows.Forms.Padding(6);
            this.panel6.Size = new System.Drawing.Size(681, 787);
            // 
            // dgvBom
            // 
            this.dgvBom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBom.Location = new System.Drawing.Point(0, 0);
            this.dgvBom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBom.Name = "dgvBom";
            this.dgvBom.RowHeadersWidth = 51;
            this.dgvBom.RowTemplate.Height = 23;
            this.dgvBom.Size = new System.Drawing.Size(1121, 787);
            this.dgvBom.TabIndex = 0;
            this.dgvBom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBom_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ucSBCheck);
            this.groupBox1.Controls.Add(this.txtLimitQty);
            this.groupBox1.Controls.Add(this.ucSaveButton1);
            this.groupBox1.Controls.Add(this.txtSafeQty);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.pcbItemImage);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnInputImage);
            this.groupBox1.Controls.Add(this.cbmCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtItemID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("나눔고딕OTF ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(610, 655);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세 정보";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("나눔고딕OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(262, 357);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 39);
            this.label19.TabIndex = 38;
            this.label19.Text = "개";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("나눔고딕OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(262, 292);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 39);
            this.label17.TabIndex = 37;
            this.label17.Text = "개";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("나눔고딕OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(262, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 39);
            this.label8.TabIndex = 36;
            this.label8.Text = "만원";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucSBCheck
            // 
            this.ucSBCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSBCheck.BackColor = System.Drawing.Color.Transparent;
            this.ucSBCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSBCheck.ForeColor = System.Drawing.Color.White;
            this.ucSBCheck.Location = new System.Drawing.Point(403, 27);
            this.ucSBCheck.Margin = new System.Windows.Forms.Padding(0);
            this.ucSBCheck.Name = "ucSBCheck";
            this.ucSBCheck.Size = new System.Drawing.Size(98, 39);
            this.ucSBCheck.TabIndex = 8;
            this.ucSBCheck.BtnClick += new System.EventHandler(this.ucSBCheck_BtnClick);
            // 
            // txtLimitQty
            // 
            this.txtLimitQty.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLimitQty.Location = new System.Drawing.Point(143, 362);
            this.txtLimitQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtLimitQty.Name = "txtLimitQty";
            this.txtLimitQty.Size = new System.Drawing.Size(109, 29);
            this.txtLimitQty.TabIndex = 5;
            this.txtLimitQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimitQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimitQty_KeyPress);
            // 
            // ucSaveButton1
            // 
            this.ucSaveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSaveButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSaveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSaveButton1.Location = new System.Drawing.Point(503, 27);
            this.ucSaveButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucSaveButton1.Name = "ucSaveButton1";
            this.ucSaveButton1.Size = new System.Drawing.Size(98, 39);
            this.ucSaveButton1.TabIndex = 7;
            this.ucSaveButton1.BtnClick += new System.EventHandler(this.ucSaveButton1_BtnClick);
            // 
            // txtSafeQty
            // 
            this.txtSafeQty.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSafeQty.Location = new System.Drawing.Point(143, 296);
            this.txtSafeQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtSafeQty.Name = "txtSafeQty";
            this.txtSafeQty.Size = new System.Drawing.Size(109, 29);
            this.txtSafeQty.TabIndex = 4;
            this.txtSafeQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSafeQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimitQty_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPrice.Location = new System.Drawing.Point(143, 167);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(109, 29);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimitQty_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(32, 365);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "최소 판매";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcbItemImage
            // 
            this.pcbItemImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbItemImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbItemImage.Location = new System.Drawing.Point(342, 96);
            this.pcbItemImage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pcbItemImage.Name = "pcbItemImage";
            this.pcbItemImage.Size = new System.Drawing.Size(241, 247);
            this.pcbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbItemImage.TabIndex = 27;
            this.pcbItemImage.TabStop = false;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(32, 435);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(207, 32);
            this.label18.TabIndex = 26;
            this.label18.Text = "자 전 거   구 성 표";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.ucSSSeat);
            this.panel7.Controls.Add(this.ucSSDrive);
            this.panel7.Controls.Add(this.ucSSBrake);
            this.panel7.Controls.Add(this.ucSSWheel);
            this.panel7.Controls.Add(this.ucSSFrame);
            this.panel7.Controls.Add(this.ucSSHansdle);
            this.panel7.Controls.Add(this.pnlSeat);
            this.panel7.Controls.Add(this.pnlWheel);
            this.panel7.Controls.Add(this.pnlDrive);
            this.panel7.Controls.Add(this.pnlBrake);
            this.panel7.Controls.Add(this.pnlFrame);
            this.panel7.Controls.Add(this.pnlHandle);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.labelDrive);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(9, 450);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(584, 189);
            this.panel7.TabIndex = 25;
            // 
            // ucSSSeat
            // 
            this.ucSSSeat.BackColor = System.Drawing.Color.Transparent;
            this.ucSSSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSSSeat.Location = new System.Drawing.Point(689, 138);
            this.ucSSSeat.Margin = new System.Windows.Forms.Padding(0);
            this.ucSSSeat.Name = "ucSSSeat";
            this.ucSSSeat.Size = new System.Drawing.Size(35, 38);
            this.ucSSSeat.TabIndex = 1;
            this.ucSSSeat.Tag = "m07";
            this.ucSSSeat.BtnClick += new System.EventHandler(this.ucSSSeat_BtnClick);
            // 
            // ucSSDrive
            // 
            this.ucSSDrive.BackColor = System.Drawing.Color.Transparent;
            this.ucSSDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSSDrive.Location = new System.Drawing.Point(689, 83);
            this.ucSSDrive.Margin = new System.Windows.Forms.Padding(0);
            this.ucSSDrive.Name = "ucSSDrive";
            this.ucSSDrive.Size = new System.Drawing.Size(35, 38);
            this.ucSSDrive.TabIndex = 1;
            this.ucSSDrive.Tag = "m06";
            this.ucSSDrive.BtnClick += new System.EventHandler(this.ucSSDrive_BtnClick);
            // 
            // ucSSBrake
            // 
            this.ucSSBrake.BackColor = System.Drawing.Color.Transparent;
            this.ucSSBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSSBrake.Location = new System.Drawing.Point(689, 25);
            this.ucSSBrake.Margin = new System.Windows.Forms.Padding(0);
            this.ucSSBrake.Name = "ucSSBrake";
            this.ucSSBrake.Size = new System.Drawing.Size(35, 38);
            this.ucSSBrake.TabIndex = 1;
            this.ucSSBrake.Tag = "m04";
            this.ucSSBrake.BtnClick += new System.EventHandler(this.ucSSBrake_BtnClick);
            // 
            // ucSSWheel
            // 
            this.ucSSWheel.BackColor = System.Drawing.Color.Transparent;
            this.ucSSWheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSSWheel.Location = new System.Drawing.Point(265, 140);
            this.ucSSWheel.Margin = new System.Windows.Forms.Padding(0);
            this.ucSSWheel.Name = "ucSSWheel";
            this.ucSSWheel.Size = new System.Drawing.Size(35, 38);
            this.ucSSWheel.TabIndex = 1;
            this.ucSSWheel.Tag = "m03";
            this.ucSSWheel.BtnClick += new System.EventHandler(this.ucSSWheel_BtnClick);
            // 
            // ucSSFrame
            // 
            this.ucSSFrame.BackColor = System.Drawing.Color.Transparent;
            this.ucSSFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSSFrame.Location = new System.Drawing.Point(265, 84);
            this.ucSSFrame.Margin = new System.Windows.Forms.Padding(0);
            this.ucSSFrame.Name = "ucSSFrame";
            this.ucSSFrame.Size = new System.Drawing.Size(35, 38);
            this.ucSSFrame.TabIndex = 1;
            this.ucSSFrame.Tag = "m02";
            this.ucSSFrame.BtnClick += new System.EventHandler(this.ucSSFrame_BtnClick);
            // 
            // ucSSHansdle
            // 
            this.ucSSHansdle.BackColor = System.Drawing.Color.Transparent;
            this.ucSSHansdle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSSHansdle.Location = new System.Drawing.Point(265, 27);
            this.ucSSHansdle.Margin = new System.Windows.Forms.Padding(0);
            this.ucSSHansdle.Name = "ucSSHansdle";
            this.ucSSHansdle.Size = new System.Drawing.Size(35, 38);
            this.ucSSHansdle.TabIndex = 1;
            this.ucSSHansdle.Tag = "m05";
            this.ucSSHansdle.BtnClick += new System.EventHandler(this.ucSSHansdle_BtnClick);
            // 
            // pnlSeat
            // 
            this.pnlSeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeat.Controls.Add(this.lblSeat);
            this.pnlSeat.Location = new System.Drawing.Point(361, 138);
            this.pnlSeat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(175, 38);
            this.pnlSeat.TabIndex = 40;
            // 
            // lblSeat
            // 
            this.lblSeat.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSeat.Location = new System.Drawing.Point(4, 3);
            this.lblSeat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(100, 30);
            this.lblSeat.TabIndex = 0;
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWheel
            // 
            this.pnlWheel.Controls.Add(this.lblWheel);
            this.pnlWheel.Location = new System.Drawing.Point(86, 140);
            this.pnlWheel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlWheel.Name = "pnlWheel";
            this.pnlWheel.Size = new System.Drawing.Size(175, 38);
            this.pnlWheel.TabIndex = 37;
            // 
            // lblWheel
            // 
            this.lblWheel.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblWheel.Location = new System.Drawing.Point(4, 3);
            this.lblWheel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWheel.Name = "lblWheel";
            this.lblWheel.Size = new System.Drawing.Size(100, 30);
            this.lblWheel.TabIndex = 0;
            this.lblWheel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDrive
            // 
            this.pnlDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrive.Controls.Add(this.lblDrive);
            this.pnlDrive.Location = new System.Drawing.Point(361, 83);
            this.pnlDrive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlDrive.Name = "pnlDrive";
            this.pnlDrive.Size = new System.Drawing.Size(175, 38);
            this.pnlDrive.TabIndex = 39;
            // 
            // lblDrive
            // 
            this.lblDrive.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDrive.Location = new System.Drawing.Point(4, 3);
            this.lblDrive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(100, 30);
            this.lblDrive.TabIndex = 0;
            this.lblDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBrake
            // 
            this.pnlBrake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBrake.Controls.Add(this.lblBrake);
            this.pnlBrake.Location = new System.Drawing.Point(361, 25);
            this.pnlBrake.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlBrake.Name = "pnlBrake";
            this.pnlBrake.Size = new System.Drawing.Size(175, 38);
            this.pnlBrake.TabIndex = 38;
            // 
            // lblBrake
            // 
            this.lblBrake.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBrake.Location = new System.Drawing.Point(4, 3);
            this.lblBrake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrake.Name = "lblBrake";
            this.lblBrake.Size = new System.Drawing.Size(100, 30);
            this.lblBrake.TabIndex = 0;
            this.lblBrake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFrame
            // 
            this.pnlFrame.Controls.Add(this.lblFrame);
            this.pnlFrame.Location = new System.Drawing.Point(86, 85);
            this.pnlFrame.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(175, 38);
            this.pnlFrame.TabIndex = 37;
            // 
            // lblFrame
            // 
            this.lblFrame.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFrame.Location = new System.Drawing.Point(4, 3);
            this.lblFrame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(100, 30);
            this.lblFrame.TabIndex = 0;
            this.lblFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHandle
            // 
            this.pnlHandle.Controls.Add(this.lblHandle);
            this.pnlHandle.Location = new System.Drawing.Point(86, 27);
            this.pnlHandle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHandle.Name = "pnlHandle";
            this.pnlHandle.Size = new System.Drawing.Size(175, 38);
            this.pnlHandle.TabIndex = 36;
            // 
            // lblHandle
            // 
            this.lblHandle.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHandle.Location = new System.Drawing.Point(4, 3);
            this.lblHandle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(100, 30);
            this.lblHandle.TabIndex = 0;
            this.lblHandle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(289, 148);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 22);
            this.label15.TabIndex = 35;
            this.label15.Text = "안장부";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Location = new System.Drawing.Point(13, 148);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 22);
            this.label16.TabIndex = 33;
            this.label16.Text = "바퀴부";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDrive
            // 
            this.labelDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDrive.AutoSize = true;
            this.labelDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelDrive.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDrive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDrive.Location = new System.Drawing.Point(289, 91);
            this.labelDrive.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(64, 22);
            this.labelDrive.TabIndex = 31;
            this.labelDrive.Text = "구동부";
            this.labelDrive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(13, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 22);
            this.label14.TabIndex = 29;
            this.label14.Text = "몸통부";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(289, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 27;
            this.label7.Text = "제어부";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "핸들부";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(20, 292);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 39);
            this.label13.TabIndex = 23;
            this.label13.Text = "안전수량";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInputImage
            // 
            this.btnInputImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputImage.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInputImage.Location = new System.Drawing.Point(342, 353);
            this.btnInputImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnInputImage.Name = "btnInputImage";
            this.btnInputImage.Size = new System.Drawing.Size(241, 44);
            this.btnInputImage.TabIndex = 9;
            this.btnInputImage.Text = "이미지 넣기";
            this.btnInputImage.UseVisualStyleBackColor = true;
            this.btnInputImage.Click += new System.EventHandler(this.btnInputImage_Click);
            // 
            // cbmCategory
            // 
            this.cbmCategory.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmCategory.FormattingEnabled = true;
            this.cbmCategory.Location = new System.Drawing.Point(143, 232);
            this.cbmCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbmCategory.Name = "cbmCategory";
            this.cbmCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbmCategory.Size = new System.Drawing.Size(184, 30);
            this.cbmCategory.TabIndex = 3;
            this.cbmCategory.SelectedIndexChanged += new System.EventHandler(this.cbmCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(20, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "종류";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(20, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 39);
            this.label9.TabIndex = 4;
            this.label9.Text = "가격";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemName.Location = new System.Drawing.Point(143, 102);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(184, 29);
            this.txtItemName.TabIndex = 1;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(20, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 39);
            this.label10.TabIndex = 2;
            this.label10.Text = "제품 이름";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemID
            // 
            this.txtItemID.Enabled = false;
            this.txtItemID.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtItemID.Location = new System.Drawing.Point(143, 38);
            this.txtItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(184, 29);
            this.txtItemID.TabIndex = 0;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(20, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "제품 ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(511, 13657);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "등록";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeSignUp
            // 
            this.btnEmployeeSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeSignUp.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEmployeeSignUp.Location = new System.Drawing.Point(382, 13657);
            this.btnEmployeeSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployeeSignUp.Name = "btnEmployeeSignUp";
            this.btnEmployeeSignUp.Size = new System.Drawing.Size(122, 39);
            this.btnEmployeeSignUp.TabIndex = 21;
            this.btnEmployeeSignUp.Text = "수정";
            this.btnEmployeeSignUp.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(252, 13657);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "복사";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.White;
            this.lblCategory.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCategory.Location = new System.Drawing.Point(754, 10);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 39);
            this.lblCategory.TabIndex = 25;
            this.lblCategory.Text = "구분";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.Location = new System.Drawing.Point(419, 14);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(286, 29);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblID.Location = new System.Drawing.Point(312, 10);
            this.lblID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(98, 39);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "완제품 ID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbmItem
            // 
            this.cbmItem.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmItem.FormattingEnabled = true;
            this.cbmItem.Location = new System.Drawing.Point(860, 14);
            this.cbmItem.Margin = new System.Windows.Forms.Padding(4);
            this.cbmItem.Name = "cbmItem";
            this.cbmItem.Size = new System.Drawing.Size(168, 30);
            this.cbmItem.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(513, 12390);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 30);
            this.button5.TabIndex = 30;
            this.button5.Text = "등록";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rdbRBom);
            this.panel8.Controls.Add(this.rdbBom);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(20, 9);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 41);
            this.panel8.TabIndex = 0;
            // 
            // rdbRBom
            // 
            this.rdbRBom.AutoSize = true;
            this.rdbRBom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdbRBom.Location = new System.Drawing.Point(126, 8);
            this.rdbRBom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbRBom.Name = "rdbRBom";
            this.rdbRBom.Size = new System.Drawing.Size(76, 28);
            this.rdbRBom.TabIndex = 1;
            this.rdbRBom.TabStop = true;
            this.rdbRBom.Text = "역전개";
            this.rdbRBom.UseVisualStyleBackColor = true;
            this.rdbRBom.CheckedChanged += new System.EventHandler(this.rdbRBom_CheckedChanged);
            // 
            // rdbBom
            // 
            this.rdbBom.AutoSize = true;
            this.rdbBom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdbBom.Location = new System.Drawing.Point(7, 8);
            this.rdbBom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbBom.Name = "rdbBom";
            this.rdbBom.Size = new System.Drawing.Size(76, 28);
            this.rdbBom.TabIndex = 0;
            this.rdbBom.TabStop = true;
            this.rdbBom.Text = "정전개";
            this.rdbBom.UseVisualStyleBackColor = true;
            // 
            // cbmMaterial
            // 
            this.cbmMaterial.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbmMaterial.FormattingEnabled = true;
            this.cbmMaterial.Location = new System.Drawing.Point(1036, 14);
            this.cbmMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cbmMaterial.Name = "cbmMaterial";
            this.cbmMaterial.Size = new System.Drawing.Size(168, 30);
            this.cbmMaterial.TabIndex = 3;
            // 
            // dgvRBom
            // 
            this.dgvRBom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRBom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRBom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRBom.GridColor = System.Drawing.Color.White;
            this.dgvRBom.Location = new System.Drawing.Point(0, 0);
            this.dgvRBom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvRBom.Name = "dgvRBom";
            this.dgvRBom.RowHeadersWidth = 51;
            this.dgvRBom.RowTemplate.Height = 27;
            this.dgvRBom.Size = new System.Drawing.Size(1121, 787);
            this.dgvRBom.TabIndex = 1;
            this.dgvRBom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRBom_CellDoubleClick);
            // 
            // ucDeleteButton1
            // 
            this.ucDeleteButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDeleteButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucDeleteButton1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucDeleteButton1.Location = new System.Drawing.Point(564, 6);
            this.ucDeleteButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucDeleteButton1.Name = "ucDeleteButton1";
            this.ucDeleteButton1.Size = new System.Drawing.Size(98, 39);
            this.ucDeleteButton1.TabIndex = 2;
            this.ucDeleteButton1.BtnClick += new System.EventHandler(this.ucDeleteButton1_BtnClick);
            // 
            // ucInsertButton1
            // 
            this.ucInsertButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInsertButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucInsertButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucInsertButton1.Location = new System.Drawing.Point(360, 6);
            this.ucInsertButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucInsertButton1.Name = "ucInsertButton1";
            this.ucInsertButton1.Size = new System.Drawing.Size(98, 39);
            this.ucInsertButton1.TabIndex = 4;
            this.ucInsertButton1.BtnClick += new System.EventHandler(this.ucInsertButton1_BtnClick);
            // 
            // ucSearchButton1
            // 
            this.ucSearchButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSearchButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchButton1.ForeColor = System.Drawing.Color.White;
            this.ucSearchButton1.Location = new System.Drawing.Point(1696, 9);
            this.ucSearchButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchButton1.Name = "ucSearchButton1";
            this.ucSearchButton1.Size = new System.Drawing.Size(98, 39);
            this.ucSearchButton1.TabIndex = 4;
            this.ucSearchButton1.BtnClick += new System.EventHandler(this.ucSearchButton1_BtnClick);
            // 
            // ucUpdateButton1
            // 
            this.ucUpdateButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUpdateButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucUpdateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucUpdateButton1.Location = new System.Drawing.Point(463, 6);
            this.ucUpdateButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucUpdateButton1.Name = "ucUpdateButton1";
            this.ucUpdateButton1.Size = new System.Drawing.Size(98, 39);
            this.ucUpdateButton1.TabIndex = 34;
            this.ucUpdateButton1.BtnClick += new System.EventHandler(this.ucUpdateButton1_BtnClick);
            // 
            // ucRefreshButton1
            // 
            this.ucRefreshButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRefreshButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucRefreshButton1.Location = new System.Drawing.Point(1654, 9);
            this.ucRefreshButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucRefreshButton1.Name = "ucRefreshButton1";
            this.ucRefreshButton1.Size = new System.Drawing.Size(37, 39);
            this.ucRefreshButton1.TabIndex = 5;
            this.ucRefreshButton1.BtnClick += new System.EventHandler(this.ucRefreshButton1_BtnClick);
            // 
            // frmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.ClientSize = new System.Drawing.Size(1808, 974);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBOM";
            this.Load += new System.EventHandler(this.frmBOM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbItemImage)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlSeat.ResumeLayout(false);
            this.pnlWheel.ResumeLayout(false);
            this.pnlDrive.ResumeLayout(false);
            this.pnlBrake.ResumeLayout(false);
            this.pnlFrame.ResumeLayout(false);
            this.pnlHandle.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInputImage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEmployeeSignUp;
        private System.Windows.Forms.ComboBox cbmItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbmMaterial;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rdbRBom;
        private System.Windows.Forms.RadioButton rdbBom;
        private System.Windows.Forms.PictureBox pcbItemImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvRBom;
        private System.Windows.Forms.TextBox txtLimitQty;
        private System.Windows.Forms.TextBox txtSafeQty;
        private System.Windows.Forms.TextBox txtPrice;
        private ucSearchButton ucSearchButton1;
        private ucUpdateButton ucUpdateButton1;
        private ucInsertButton ucInsertButton1;
        private ucDeleteButton ucDeleteButton1;
        private ucSaveButton ucSaveButton1;
        private ucRefreshButton ucRefreshButton1;
        private ucSearchButton ucSBCheck;
        private System.Windows.Forms.Panel pnlSeat;
        private ucSearchSmall ucSSSeat;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Panel pnlWheel;
        private ucSearchSmall ucSSWheel;
        private System.Windows.Forms.Label lblWheel;
        private System.Windows.Forms.Panel pnlDrive;
        private ucSearchSmall ucSSDrive;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Panel pnlBrake;
        private ucSearchSmall ucSSBrake;
        private System.Windows.Forms.Label lblBrake;
        private System.Windows.Forms.Panel pnlFrame;
        private ucSearchSmall ucSSFrame;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.Panel pnlHandle;
        private ucSearchSmall ucSSHansdle;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
    }
}
