
namespace Team2
{
    partial class frmProduceOrderShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.dtpSearchDate = new Team2.ucDateTimePickerSet();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ucSearchButton1 = new Team2.ucSearchButton();
            this.ucRefreshButton2 = new Team2.ucRefreshButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1834, 57);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ucRefreshButton2);
            this.panel2.Controls.Add(this.ucSearchButton1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtProduct);
            this.panel2.Controls.Add(this.dtpSearchDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Size = new System.Drawing.Size(1834, 44);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.Text = "생산지시 조회";
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1834, 42);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvOrder);
            this.panel4.Size = new System.Drawing.Size(1834, 768);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.Text = "생산지시 목록";
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrder.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrder.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.RowTemplate.Height = 30;
            this.dgvOrder.Size = new System.Drawing.Size(1834, 768);
            this.dgvOrder.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "제품명";
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProduct.Location = new System.Drawing.Point(514, 10);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(162, 25);
            this.txtProduct.TabIndex = 13;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.EndDate = new System.DateTime(2022, 12, 26, 20, 27, 35, 913);
            this.dtpSearchDate.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpSearchDate.Location = new System.Drawing.Point(104, 6);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(297, 31);
            this.dtpSearchDate.StartDate = new System.DateTime(2022, 12, 26, 20, 27, 35, 920);
            this.dtpSearchDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "지시시작일";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(954, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "완료된 생산 보이기";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ucSearchButton1
            // 
            this.ucSearchButton1.BackColor = System.Drawing.Color.Transparent;
            this.ucSearchButton1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucSearchButton1.ForeColor = System.Drawing.Color.White;
            this.ucSearchButton1.Location = new System.Drawing.Point(1742, 6);
            this.ucSearchButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ucSearchButton1.Name = "ucSearchButton1";
            this.ucSearchButton1.Size = new System.Drawing.Size(80, 30);
            this.ucSearchButton1.TabIndex = 19;
            this.ucSearchButton1.BtnClick += new System.EventHandler(this.ucSearchButton1_BtnClick);
            // 
            // ucRefreshButton2
            // 
            this.ucRefreshButton2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucRefreshButton2.Location = new System.Drawing.Point(1700, 6);
            this.ucRefreshButton2.Margin = new System.Windows.Forms.Padding(0);
            this.ucRefreshButton2.Name = "ucRefreshButton2";
            this.ucRefreshButton2.Size = new System.Drawing.Size(30, 30);
            this.ucRefreshButton2.TabIndex = 21;
            this.ucRefreshButton2.BtnClick += new System.EventHandler(this.ucRefreshButton2_BtnClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "생산단계";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(777, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // frmProduceOrderShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Name = "frmProduceOrderShow";
            this.Text = "frmProduceOrderShow";
            this.Load += new System.EventHandler(this.frmProduceOrderShow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProduct;
        private ucDateTimePickerSet dtpSearchDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private ucRefreshButton ucRefreshButton2;
        private ucSearchButton ucSearchButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}