
namespace Team2
{
    partial class frmSearchCompanyPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCompanyPop));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.dgvCmpName = new System.Windows.Forms.DataGridView();
            this.ucBtnClose = new Team2.ucCloseButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmpName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(476, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCmpName);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel2.Size = new System.Drawing.Size(476, 501);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.dgvCmpName, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucBtnClose);
            this.panel3.Location = new System.Drawing.Point(0, 452);
            this.panel3.Size = new System.Drawing.Size(476, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.Text = "거래처 조회";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblComment);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.txtKeyword);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 48);
            this.panel4.TabIndex = 1;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.White;
            this.lblComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblComment.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblComment.Location = new System.Drawing.Point(18, 15);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(138, 17);
            this.lblComment.TabIndex = 63;
            this.lblComment.Text = "검색어를 입력하세요";
            this.lblComment.Click += new System.EventHandler(this.lblComment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.Location = new System.Drawing.Point(14, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(419, 25);
            this.txtKeyword.TabIndex = 62;
            this.txtKeyword.Click += new System.EventHandler(this.txtKeyword_Click);
            // 
            // dgvCmpName
            // 
            this.dgvCmpName.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCmpName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCmpName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCmpName.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCmpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCmpName.Location = new System.Drawing.Point(0, 48);
            this.dgvCmpName.Name = "dgvCmpName";
            this.dgvCmpName.RowTemplate.Height = 23;
            this.dgvCmpName.Size = new System.Drawing.Size(476, 404);
            this.dgvCmpName.TabIndex = 2;
            this.dgvCmpName.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCmpName_CellDoubleClick);
            // 
            // ucBtnClose
            // 
            this.ucBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBtnClose.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucBtnClose.Location = new System.Drawing.Point(384, 8);
            this.ucBtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnClose.Name = "ucBtnClose";
            this.ucBtnClose.Size = new System.Drawing.Size(80, 32);
            this.ucBtnClose.TabIndex = 0;
            this.ucBtnClose.BtnClick += new System.EventHandler(this.ucBtnClose_BtnClick);
            // 
            // frmSearchCompanyPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 553);
            this.Name = "frmSearchCompanyPop";
            this.Text = "거래처 검색";
            this.Load += new System.EventHandler(this.frmSearchCompanyPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmpName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCmpName;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtKeyword;
        private ucCloseButton ucBtnClose;
    }
}