
namespace Team2
{
    partial class frmPlanningAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanningAdd));
            this.dtpPlan = new Team2.ucDateTimePickerSet();
            this.label7 = new System.Windows.Forms.Label();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ucUpdateButton1 = new Team2.ucUpdateButton();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.ucInsertButton1 = new Team2.ucInsertButton();
            this.ucSaveButton1 = new Team2.ucSaveButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.dgvPlanDetail = new System.Windows.Forms.DataGridView();
            this.ucDeleteButton1 = new Team2.ucDeleteButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1219, 57);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.dtpPlan);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtempName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel2.Size = new System.Drawing.Size(1219, 91);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.Text = "생산계획 생성";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucDeleteButton1);
            this.panel3.Controls.Add(this.ucSaveButton1);
            this.panel3.Controls.Add(this.ucUpdateButton1);
            this.panel3.Controls.Add(this.btnGetOrder);
            this.panel3.Controls.Add(this.ucInsertButton1);
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Size = new System.Drawing.Size(1219, 42);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.ucInsertButton1, 0);
            this.panel3.Controls.SetChildIndex(this.btnGetOrder, 0);
            this.panel3.Controls.SetChildIndex(this.ucUpdateButton1, 0);
            this.panel3.Controls.SetChildIndex(this.ucSaveButton1, 0);
            this.panel3.Controls.SetChildIndex(this.ucDeleteButton1, 0);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Location = new System.Drawing.Point(0, 190);
            this.panel4.Size = new System.Drawing.Size(1219, 446);
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.Text = "상세정보";
            // 
            // dtpPlan
            // 
            this.dtpPlan.EndDate = new System.DateTime(2022, 12, 29, 0, 29, 12, 175);
            this.dtpPlan.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpPlan.Location = new System.Drawing.Point(616, 51);
            this.dtpPlan.Name = "dtpPlan";
            this.dtpPlan.Size = new System.Drawing.Size(297, 31);
            this.dtpPlan.StartDate = new System.DateTime(2022, 12, 29, 0, 29, 12, 177);
            this.dtpPlan.TabIndex = 23;
            this.dtpPlan.StartValueChange += new System.EventHandler(this.dtpPlan_StartValueChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "계획일자";
            // 
            // txtempName
            // 
            this.txtempName.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtempName.Location = new System.Drawing.Point(1015, 53);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(88, 25);
            this.txtempName.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(955, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "담당자";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 25);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "등록일";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(122, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 25);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "시스템 자동생성";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "생산계획번호";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1219, 42);
            this.panel7.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "생산계획정보";
            // 
            // ucUpdateButton1
            // 
            this.ucUpdateButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUpdateButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucUpdateButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucUpdateButton1.Location = new System.Drawing.Point(957, 5);
            this.ucUpdateButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucUpdateButton1.Name = "ucUpdateButton1";
            this.ucUpdateButton1.Size = new System.Drawing.Size(80, 32);
            this.ucUpdateButton1.TabIndex = 8;
            this.ucUpdateButton1.BtnClick += new System.EventHandler(this.ucUpdateButton1_BtnClick);
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetOrder.BackColor = System.Drawing.Color.White;
            this.btnGetOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetOrder.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGetOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetOrder.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOrder.ForeColor = System.Drawing.Color.Black;
            this.btnGetOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnGetOrder.Image")));
            this.btnGetOrder.Location = new System.Drawing.Point(705, 6);
            this.btnGetOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnGetOrder.Size = new System.Drawing.Size(158, 30);
            this.btnGetOrder.TabIndex = 7;
            this.btnGetOrder.Text = " 주문서 불러오기";
            this.btnGetOrder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGetOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetOrder.UseVisualStyleBackColor = false;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // ucInsertButton1
            // 
            this.ucInsertButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucInsertButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucInsertButton1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucInsertButton1.Location = new System.Drawing.Point(870, 5);
            this.ucInsertButton1.Name = "ucInsertButton1";
            this.ucInsertButton1.Size = new System.Drawing.Size(80, 32);
            this.ucInsertButton1.TabIndex = 6;
            this.ucInsertButton1.BtnClick += new System.EventHandler(this.ucInsertButton1_BtnClick);
            // 
            // ucSaveButton1
            // 
            this.ucSaveButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSaveButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSaveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSaveButton1.Location = new System.Drawing.Point(1131, 5);
            this.ucSaveButton1.Name = "ucSaveButton1";
            this.ucSaveButton1.Size = new System.Drawing.Size(80, 32);
            this.ucSaveButton1.TabIndex = 9;
            this.ucSaveButton1.BtnClick += new System.EventHandler(this.ucSaveButton1_BtnClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPlan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPlanDetail);
            this.splitContainer1.Size = new System.Drawing.Size(1219, 446);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvPlan
            // 
            this.dgvPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(0, 0);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.Size = new System.Drawing.Size(469, 446);
            this.dgvPlan.TabIndex = 0;
            this.dgvPlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellClick);
            this.dgvPlan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPlan_CellFormatting);
            // 
            // dgvPlanDetail
            // 
            this.dgvPlanDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvPlanDetail.Name = "dgvPlanDetail";
            this.dgvPlanDetail.RowTemplate.Height = 23;
            this.dgvPlanDetail.Size = new System.Drawing.Size(746, 446);
            this.dgvPlanDetail.TabIndex = 0;
            this.dgvPlanDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanDetail_CellClick);
            // 
            // ucDeleteButton1
            // 
            this.ucDeleteButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDeleteButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucDeleteButton1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucDeleteButton1.Location = new System.Drawing.Point(1044, 5);
            this.ucDeleteButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucDeleteButton1.Name = "ucDeleteButton1";
            this.ucDeleteButton1.Size = new System.Drawing.Size(80, 32);
            this.ucDeleteButton1.TabIndex = 10;
            this.ucDeleteButton1.BtnClick += new System.EventHandler(this.ucDeleteButton1_BtnClick);
            // 
            // frmPlanningAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 636);
            this.Name = "frmPlanningAdd";
            this.Text = "생산계획 생성";
            this.Load += new System.EventHandler(this.frmPlanningAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucDateTimePickerSet dtpPlan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label4;
        private ucUpdateButton ucUpdateButton1;
        private System.Windows.Forms.Button btnGetOrder;
        private ucInsertButton ucInsertButton1;
        private ucSaveButton ucSaveButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.DataGridView dgvPlanDetail;
        private ucDeleteButton ucDeleteButton1;
    }
}