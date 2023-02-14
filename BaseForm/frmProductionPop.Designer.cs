
namespace Team2
{
    partial class frmProductionPop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionPop));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(530, 52);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.domainUpDown1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Size = new System.Drawing.Size(530, 434);
            this.panel2.Controls.SetChildIndex(this.label26, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.comboBox1, 0);
            this.panel2.Controls.SetChildIndex(this.label9, 0);
            this.panel2.Controls.SetChildIndex(this.dateTimePicker4, 0);
            this.panel2.Controls.SetChildIndex(this.textBox6, 0);
            this.panel2.Controls.SetChildIndex(this.label15, 0);
            this.panel2.Controls.SetChildIndex(this.button1, 0);
            this.panel2.Controls.SetChildIndex(this.textBox1, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.button2, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.domainUpDown1, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.dateTimePicker1, 0);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Size = new System.Drawing.Size(530, 49);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.Text = "작업 지시";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 30);
            this.comboBox1.TabIndex = 143;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("나눔고딕OTF", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(137, 40);
            this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 21);
            this.label26.TabIndex = 142;
            this.label26.Text = "공정";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(221, 90);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(178, 29);
            this.dateTimePicker4.TabIndex = 149;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(94, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 22);
            this.label9.TabIndex = 144;
            this.label9.Text = "지시 일자";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(98, 151);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 22);
            this.label15.TabIndex = 151;
            this.label15.Text = "담당자ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6.Location = new System.Drawing.Point(221, 149);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 29);
            this.textBox6.TabIndex = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(407, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 26);
            this.button1.TabIndex = 152;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(407, 205);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 26);
            this.button2.TabIndex = 155;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(116, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 154;
            this.label3.Text = "제품ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(221, 205);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 29);
            this.textBox1.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(135, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 156;
            this.label4.Text = "갯수";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(221, 261);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(178, 29);
            this.domainUpDown1.TabIndex = 157;
            this.domainUpDown1.Text = "0000";
            this.domainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 314);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 29);
            this.dateTimePicker1.TabIndex = 159;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(53, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 158;
            this.label5.Text = "예정 작업 시간";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProductionPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.ClientSize = new System.Drawing.Size(530, 486);
            this.Name = "frmProductionPop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label4;
    }
}
