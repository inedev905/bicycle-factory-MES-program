
namespace Team2
{
    partial class frmPlanningAddPop
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpPlan = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ucCloseButton2 = new Team2.ucCloseButton();
            this.ucSaveButton2 = new Team2.ucSaveButton();
            this.lblodId = new System.Windows.Forms.Label();
            this.lbldueDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(411, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbldueDate);
            this.panel2.Controls.Add(this.lblodId);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.txtProdName);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtpPlan);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.nudQty);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Size = new System.Drawing.Size(411, 257);
            this.panel2.Controls.SetChildIndex(this.label11, 0);
            this.panel2.Controls.SetChildIndex(this.nudQty, 0);
            this.panel2.Controls.SetChildIndex(this.label12, 0);
            this.panel2.Controls.SetChildIndex(this.dtpPlan, 0);
            this.panel2.Controls.SetChildIndex(this.label13, 0);
            this.panel2.Controls.SetChildIndex(this.label14, 0);
            this.panel2.Controls.SetChildIndex(this.txtProdName, 0);
            this.panel2.Controls.SetChildIndex(this.txtCategory, 0);
            this.panel2.Controls.SetChildIndex(this.label15, 0);
            this.panel2.Controls.SetChildIndex(this.lblodId, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.lbldueDate, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucCloseButton2);
            this.panel3.Controls.Add(this.ucSaveButton2);
            this.panel3.Location = new System.Drawing.Point(0, 208);
            this.panel3.Size = new System.Drawing.Size(411, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.Text = "계획수정";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(204, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "단, 주문건의 경우 계획수량 변경 불가";
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(118, 19);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(80, 25);
            this.txtCategory.TabIndex = 19;
            // 
            // txtProdName
            // 
            this.txtProdName.Enabled = false;
            this.txtProdName.Location = new System.Drawing.Point(118, 64);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(219, 25);
            this.txtProdName.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "제품명";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "생산구분";
            // 
            // dtpPlan
            // 
            this.dtpPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlan.Location = new System.Drawing.Point(118, 109);
            this.dtpPlan.Name = "dtpPlan";
            this.dtpPlan.Size = new System.Drawing.Size(123, 25);
            this.dtpPlan.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "계획일자";
            // 
            // nudQty
            // 
            this.nudQty.Location = new System.Drawing.Point(118, 154);
            this.nudQty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(80, 25);
            this.nudQty.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "계획수량";
            // 
            // ucCloseButton2
            // 
            this.ucCloseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucCloseButton2.BackColor = System.Drawing.Color.Transparent;
            this.ucCloseButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucCloseButton2.Location = new System.Drawing.Point(322, 8);
            this.ucCloseButton2.Margin = new System.Windows.Forms.Padding(0);
            this.ucCloseButton2.Name = "ucCloseButton2";
            this.ucCloseButton2.Size = new System.Drawing.Size(80, 32);
            this.ucCloseButton2.TabIndex = 5;
            this.ucCloseButton2.BtnClick += new System.EventHandler(this.ucCloseButton2_BtnClick);
            // 
            // ucSaveButton2
            // 
            this.ucSaveButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSaveButton2.BackColor = System.Drawing.Color.Transparent;
            this.ucSaveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSaveButton2.Location = new System.Drawing.Point(234, 8);
            this.ucSaveButton2.Name = "ucSaveButton2";
            this.ucSaveButton2.Size = new System.Drawing.Size(80, 32);
            this.ucSaveButton2.TabIndex = 4;
            this.ucSaveButton2.BtnClick += new System.EventHandler(this.ucSaveButton2_BtnClick);
            // 
            // lblodId
            // 
            this.lblodId.AutoSize = true;
            this.lblodId.Location = new System.Drawing.Point(223, 23);
            this.lblodId.Name = "lblodId";
            this.lblodId.Size = new System.Drawing.Size(0, 17);
            this.lblodId.TabIndex = 21;
            // 
            // lbldueDate
            // 
            this.lbldueDate.AutoSize = true;
            this.lbldueDate.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbldueDate.Location = new System.Drawing.Point(247, 117);
            this.lbldueDate.Name = "lbldueDate";
            this.lbldueDate.Size = new System.Drawing.Size(102, 13);
            this.lbldueDate.TabIndex = 23;
            this.lbldueDate.Text = "[납기] 2023-01-01";
            // 
            // frmPlanningAddPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 309);
            this.Name = "frmPlanningAddPop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "생산계획 수정";
            this.Load += new System.EventHandler(this.frmPlanningAddPop_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpPlan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Label label11;
        private ucCloseButton ucCloseButton2;
        private ucSaveButton ucSaveButton2;
        private System.Windows.Forms.Label lblodId;
        private System.Windows.Forms.Label lbldueDate;
    }
}