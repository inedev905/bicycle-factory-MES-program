using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using Team2DTO;

namespace Team2
{
    class DataGridViewUtil
    {
        public static void SetDgv(DataGridView dgv)
        {
            //datasource 자동 바인딩 안되게
            dgv.AutoGenerateColumns = false;
            
            //마지막행 삭제
            dgv.AllowUserToAddRows = false;


            //행 전체 선택
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //헤드컬럼 스타일 지정
            dgv.EnableHeadersVisualStyles = false;

            //선택 컬럼 헤더 배경색
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;


            //첫번째 열 안보이게
            dgv.RowHeadersVisible = false;


            //헤드 컬럼 높이 조정
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 30;

            //로우 컬럼 높이 조정
            dgv.RowTemplate.Height = 30;

            //헤드 컬럼 색            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;

            // 헤드 컬럼 스타일
            //dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //열 너비 자동조정
            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb
            

        }

        public static void AddGridTextBoxColumn(
            DataGridView dgv,
            string headerText,
            string propertyName,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleCenter,
            bool visible = true, bool readOnly = true, bool frozen = false)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.Name = propertyName;
            col.DataPropertyName = propertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = align;
            col.Visible = visible;
            col.ReadOnly = readOnly;
            col.Frozen = frozen;
            

            dgv.Columns.Add(col);
        }

        public static void AddGridButtonColumn(DataGridView dgv,
            string headerText,
            string propertyName,
            string text,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleCenter,
            bool visible = true, bool readOnly = true, bool frozen = false)
        {
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            
            col.Text = text;
            col.HeaderText = headerText;
            col.Name = propertyName;
            col.DataPropertyName = propertyName;
            col.Width = colWidth;
            col.DefaultCellStyle.Alignment = align;
            col.Visible = visible;
            col.ReadOnly = readOnly;
            col.Frozen = frozen;

            dgv.Columns.Add(col);
        }

        public static void AddGridComboBoxColumn(DataGridView dgv,
            string headerText,
            string propertyName,
            string valueMember,
            string displaymember,
            List<CommonCodeDTO> dataSource ,
            int colWidth = 100,
            DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleCenter,
            bool visible = true, bool frozen = false)
        {
            DataGridViewComboBoxColumn cbm = new DataGridViewComboBoxColumn();
            
            cbm.HeaderText = headerText;
            cbm.Name = propertyName;
            cbm.DataPropertyName = propertyName;

            cbm.ValueMember = valueMember;
            cbm.DisplayMember = displaymember;
            cbm.DataSource = dataSource;

            //foreach (var i in dataSource)
            //{
            //    cbm.Items.Add(i.Name);
            //}
            
            

            cbm.Width = colWidth;
            cbm.DefaultCellStyle.Alignment = align;
            cbm.Visible = visible;
            dgv.Columns.Add(cbm);
        }
    }
}
