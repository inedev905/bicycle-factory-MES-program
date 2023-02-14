
namespace Team2
{
    partial class frmZipPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZipPop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvZip = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunZip = new System.Windows.Forms.TextBox();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtRoadZip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "우편번호 검색";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 34);
            this.label2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.txtJibunAddr1);
            this.panel2.Controls.Add(this.txtRoadAddr1);
            this.panel2.Controls.Add(this.txtJibunAddr2);
            this.panel2.Controls.Add(this.txtJibunZip);
            this.panel2.Controls.Add(this.txtRoadAddr2);
            this.panel2.Controls.Add(this.txtRoadZip);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 578);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvZip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 335);
            this.panel3.TabIndex = 61;
            // 
            // dgvZip
            // 
            this.dgvZip.BackgroundColor = System.Drawing.Color.White;
            this.dgvZip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZip.Location = new System.Drawing.Point(0, 0);
            this.dgvZip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvZip.Name = "dgvZip";
            this.dgvZip.RowTemplate.Height = 23;
            this.dgvZip.Size = new System.Drawing.Size(735, 335);
            this.dgvZip.TabIndex = 50;
            this.dgvZip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZip_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblComment);
            this.panel4.Controls.Add(this.txtKeyword);
            this.panel4.Controls.Add(this.imgSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(735, 48);
            this.panel4.TabIndex = 60;
            // 
            // imgSearch
            // 
            this.imgSearch.Image = ((System.Drawing.Image)(resources.GetObject("imgSearch.Image")));
            this.imgSearch.Location = new System.Drawing.Point(698, 11);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(25, 24);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearch.TabIndex = 0;
            this.imgSearch.TabStop = false;
            this.imgSearch.Click += new System.EventHandler(this.imgSearch_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(29, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 27);
            this.button3.TabIndex = 58;
            this.button3.Text = "선택";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(29, 442);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 27);
            this.btnSelect.TabIndex = 59;
            this.btnSelect.Text = "선택";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr1.Location = new System.Drawing.Point(260, 485);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.Size = new System.Drawing.Size(446, 25);
            this.txtJibunAddr1.TabIndex = 56;
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr1.Location = new System.Drawing.Point(260, 409);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.Size = new System.Drawing.Size(446, 25);
            this.txtRoadAddr1.TabIndex = 57;
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunAddr2.Location = new System.Drawing.Point(138, 519);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(569, 25);
            this.txtJibunAddr2.TabIndex = 54;
            // 
            // txtJibunZip
            // 
            this.txtJibunZip.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJibunZip.Location = new System.Drawing.Point(138, 485);
            this.txtJibunZip.Name = "txtJibunZip";
            this.txtJibunZip.Size = new System.Drawing.Size(115, 25);
            this.txtJibunZip.TabIndex = 52;
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadAddr2.Location = new System.Drawing.Point(138, 443);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.Size = new System.Drawing.Size(569, 25);
            this.txtRoadAddr2.TabIndex = 55;
            // 
            // txtRoadZip
            // 
            this.txtRoadZip.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRoadZip.Location = new System.Drawing.Point(138, 409);
            this.txtRoadZip.Name = "txtRoadZip";
            this.txtRoadZip.Size = new System.Drawing.Size(115, 25);
            this.txtRoadZip.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(29, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "지번 주소";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(30, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "도로명 주소";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.Location = new System.Drawing.Point(19, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(673, 25);
            this.txtKeyword.TabIndex = 58;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyWord_KeyPress);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.White;
            this.lblComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblComment.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblComment.Location = new System.Drawing.Point(23, 15);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(138, 17);
            this.lblComment.TabIndex = 59;
            this.lblComment.Text = "검색어를 입력하세요";
            this.lblComment.Click += new System.EventHandler(this.lblComment_Click);
            // 
            // frmZipPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 630);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "frmZipPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "우편번호 찾기";
            this.Load += new System.EventHandler(this.frmZipPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZip)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunZip;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtRoadZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvZip;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtKeyword;
    }
}