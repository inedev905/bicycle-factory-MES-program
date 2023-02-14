
namespace Team2
{
    partial class frmSearchProductPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchProductPop));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.ucCloseButton1 = new Team2.ucCloseButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(441, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProd);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Size = new System.Drawing.Size(441, 470);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.panel4, 0);
            this.panel2.Controls.SetChildIndex(this.dgvProd, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucCloseButton1);
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Size = new System.Drawing.Size(441, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.Text = "제품 조회";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblComment);
            this.panel4.Controls.Add(this.txtKeyword);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(441, 48);
            this.panel4.TabIndex = 4;
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
            this.lblComment.TabIndex = 61;
            this.lblComment.Text = "검색어를 입력하세요";
            this.lblComment.Click += new System.EventHandler(this.lblComment_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.Location = new System.Drawing.Point(14, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(383, 25);
            this.txtKeyword.TabIndex = 60;
            this.txtKeyword.Click += new System.EventHandler(this.txtKeyword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(403, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.BackgroundColor = System.Drawing.Color.White;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProd.Location = new System.Drawing.Point(0, 48);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.RowTemplate.Height = 23;
            this.dgvProd.Size = new System.Drawing.Size(441, 373);
            this.dgvProd.TabIndex = 5;
            this.dgvProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellDoubleClick);
            // 
            // ucCloseButton1
            // 
            this.ucCloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucCloseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucCloseButton1.Location = new System.Drawing.Point(348, 8);
            this.ucCloseButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucCloseButton1.Name = "ucCloseButton1";
            this.ucCloseButton1.Size = new System.Drawing.Size(80, 32);
            this.ucCloseButton1.TabIndex = 0;
            this.ucCloseButton1.BtnClick += new System.EventHandler(this.ucCloseButton1_BtnClick);
            // 
            // frmSearchProductPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 522);
            this.Name = "frmSearchProductPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "제품 검색";
            this.Load += new System.EventHandler(this.frmSearchProductPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtKeyword;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProd;
        private ucCloseButton ucCloseButton1;
    }
}