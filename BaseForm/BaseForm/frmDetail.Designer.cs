
namespace Team2
{
    partial class frmDetail
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSubTitle = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlSubTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlSearch.Location = new System.Drawing.Point(0, 60);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1100, 147);
            this.pnlSearch.TabIndex = 5;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(87)))), ((int)(((byte)(53)))));
            this.pnlTitle.Controls.Add(this.label2);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1100, 60);
            this.pnlTitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(181)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 32);
            this.label2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "대메뉴 제목입력";
            // 
            // pnlSubTitle
            // 
            this.pnlSubTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.pnlSubTitle.Controls.Add(this.lblSubTitle);
            this.pnlSubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlSubTitle.Location = new System.Drawing.Point(0, 207);
            this.pnlSubTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSubTitle.Name = "pnlSubTitle";
            this.pnlSubTitle.Size = new System.Drawing.Size(1100, 42);
            this.pnlSubTitle.TabIndex = 6;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubTitle.Location = new System.Drawing.Point(14, 12);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(124, 17);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "세부분류 제목입력";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 249);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1100, 351);
            this.pnlMain.TabIndex = 7;
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSubTitle);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDetail";
            this.Text = "frmDetail";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlSubTitle.ResumeLayout(false);
            this.pnlSubTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlSearch;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label lblTitle;
        protected System.Windows.Forms.Panel pnlMain;
        protected System.Windows.Forms.Label lblSubTitle;
        protected System.Windows.Forms.Panel pnlTitle;
        protected System.Windows.Forms.Panel pnlSubTitle;
    }
}