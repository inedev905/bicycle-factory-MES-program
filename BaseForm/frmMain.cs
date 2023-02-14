using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team2DTO;
using Team2.Services;
using System.Reflection;

namespace Team2
{    
    public partial class frmMain : Form
    {
        public EmployeeDTO LoginEmpInfo { get; set; }
        public int curP_MenuID { get; set; }

        MenuService srv;
        List<MenuDTO> menuList;
        Panel pnlChildMenu = new Panel();

        const int MaxWidth = 210;
        const int MinWidth = 85;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!Login())
                Application.Exit();

        }

        private bool Login()
        {
            this.Visible = false;

            frmLogin login = new frmLogin();
            if (login.ShowDialog(this) != DialogResult.OK)
            {
                this.Close();
                return false;
            }

            this.Visible = true;
            try
            {
                menuStrip1.Visible = false;
                tabControl1.Visible = false;
                pnlChildMenu.Visible = false;

                //로그인 성공하면 메뉴스트립에 이름 보여주고, 부서코드 넘겨주고 접근가능한 메뉴를 받아온다.
                tslblName.Text = LoginEmpInfo.emp_name;
                tslblDept.Text = $"{LoginEmpInfo.dep_name}({LoginEmpInfo.title_name})";
                tslblEmpID.Text = LoginEmpInfo.emp_id.ToString();

                srv = new MenuService();
                menuList = srv.GetUserMenu(LoginEmpInfo.dep_code, LoginEmpInfo.title_code);


                //화면 그리기            
                DrawMenu();
                chkHide.Checked = true;

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked)
            {
                panel1.Width = MinWidth;
                pnlMenu.Width = MinWidth;
                pnlChildMenu.Visible = false;
                chkHide.Text = ">";
            }
            else
            {
                panel1.Width = MaxWidth;
                pnlMenu.Width = MaxWidth;
                pnlChildMenu.Visible = false;
                chkHide.Text = "<";
            }

        }

        #region 대메뉴버튼
        private void DrawMenu()
        {
            List<MenuDTO> menu1List = menuList.FindAll((m) => m.Menu_level == 1)
                                                .OrderBy((m) => m.Menu_sort).ToList();
            //대메뉴 버튼 생성
            for (int i = 0; i < menu1List.Count; i++)
            {
                Button button = new Button();
                button.Name = menu1List[i].Menu_id.ToString();
                button.Location = new Point(0, (i * 60));
                button.AutoSize = true;
                button.Size = new Size(MaxWidth, 60);
                button.Margin = new Padding(0);
                button.Padding = new Padding(20, 0, 0, 0);
                button.Dock = DockStyle.Top;

                button.UseVisualStyleBackColor = false;
                button.BackColor = Color.Transparent;

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);

                button.Font = new Font("나눔고딕 ExtraBold", 13F, FontStyle.Bold, GraphicsUnit.Point, 129);
                button.ForeColor = Color.Black;
                
                button.ImageList = imageList1;
                button.ImageIndex = Convert.ToInt32(menu1List[i].Menu_Img);
                button.ImageAlign = ContentAlignment.MiddleLeft;

                button.Text = menu1List[i].Menu_name.PadLeft(menu1List[i].Menu_name.Length + 6);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.Tag = i;

                pnlMenu.Controls.Add(button);

                button.Click += Button_Click;
                button.MouseEnter += Button_MouseEnter;
                //button.MouseLeave += Button_MouseLeave;

                pnlChildMenu.Size = new Size(MaxWidth, 200);
                pnlChildMenu.Dock = DockStyle.Top;
                pnlMenu.Controls.Add(pnlChildMenu);
                pnlChildMenu.Visible = false;


            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (chkHide.Checked) return;

            panel1.Width = MaxWidth;
            pnlMenu.Width = MaxWidth;
            //pnlChildMenu.Visible = false;
        }

        //대메뉴 버튼 클릭 => 중메뉴 버튼 생성
        private void Button_Click(object sender, EventArgs e)
        {
            chkHide.Checked = false;

            //중메뉴 버튼 생성
            Button btn = (Button)sender;
            int menuid = Convert.ToInt32(btn.Name);
            int pnlIndex = Convert.ToInt32(btn.Tag) + 1;

            var menu2List = menuList.FindAll((m) => m.Pnt_menu_id == menuid
                                                    && m.Menu_level == 2)
                                    .OrderBy((m) => m.Menu_sort).ToList();

            pnlChildMenu.Controls.Clear();

            for (int i = 0; i < menu2List.Count; i++)
            {
                Button button = new Button();
                button.Location = new Point(0, (i * 50));
                button.AutoSize = true;
                button.Size = new Size(MaxWidth, 50);
                button.Margin = new Padding(0);
                button.Dock = DockStyle.Bottom;
                button.Name = menuid.ToString();

                button.UseVisualStyleBackColor = false;
                button.BackColor = Color.FromArgb(235, 239, 214);

                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 210, 142);
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 210, 142);

                button.Font = new Font("나눔고딕 ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
                button.ForeColor = Color.Black;

                button.Text = menu2List[i].Menu_name.PadLeft(menu2List[i].Menu_name.Length + 20);
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.Tag = menu2List[i].Program_name;

                button.MouseLeave += Button_MouseLeave1;
                button.MouseEnter += Button_MouseEnter1;
                button.Click += Button_Click1;
                

                pnlChildMenu.Controls.Add(button);
            }
            
            pnlMenu.Controls.SetChildIndex(pnlChildMenu, pnlIndex);
            pnlChildMenu.Size = new Size(MaxWidth, 50 * menu2List.Count);
            pnlChildMenu.Visible = true;

        }
        #endregion

        #region 중메뉴버튼
        private void Button_MouseLeave1(object sender, EventArgs e)
        {
            if (!chkHide.Checked) return;

            panel1.Width = MinWidth;
            pnlMenu.Width = MinWidth;            
        }

        private void Button_MouseEnter1(object sender, EventArgs e)
        {
            panel1.Width = MaxWidth;
            pnlMenu.Width = MaxWidth;
            pnlChildMenu.Visible = true;
        }

        private void Button_Click1(object sender, EventArgs e)
        {            
            Button btn = (Button)sender;
            //MessageBox.Show(btn.Name);
            curP_MenuID = Convert.ToInt32(btn.Name);

            string appName = Assembly.GetEntryAssembly().GetName().Name;
            Type frmType = Type.GetType($"{appName}.{btn.Tag.ToString()}");

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == frmType  && form.Text.Trim() == btn.Text.Trim())
                {
                    form.Activate();
                    form.BringToFront();
                    chkHide.Checked = true;
                    return;
                }
            }

            if (frmType == null)
            {
                MessageBox.Show("미생성 화면");
                chkHide.Checked = true;
                return;
            }

            Form frm = (Form)Activator.CreateInstance(frmType);
            
            frm.MdiParent = this;
            frm.Text = btn.Text.Trim();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();


            chkHide.Checked = true;

        }
        #endregion


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            //child 폼이 신규로 show()되거나, Activate() 할때 발생하는 이벤트
            //신규인 경우는 TabPage를 추가하고, 기존폼인 경우는 TabPage를 찾아서 선택

            if (this.ActiveMdiChild == null)
            {
                tabControl1.Visible = false;
            }
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

                if (this.ActiveMdiChild.Tag == null) //신규로 탭을 생성하는 경우
                {
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text + "    ");
                    tabControl1.TabPages.Add(tp);

                    //tp.Tag = this.ActiveMdiChild;
                    tp.Tag = new TabTag { ActiveOpenForm = this.ActiveMdiChild, MenuID = curP_MenuID };
                    this.ActiveMdiChild.Tag = tp;

                    tabControl1.SelectedTab = tp;

                    //자식폼이 닫힐때 탭페이지도 같이 삭제
                    this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
                }
                else //기존에 탭이 있는 경우
                {
                    tabControl1.SelectedTab = (TabPage)this.ActiveMdiChild.Tag;
                }

                if (!tabControl1.Visible)
                {
                    tabControl1.Visible = true;
                }
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            ((TabPage)frm.Tag).Dispose();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                Form frm = ((TabTag)tabControl1.SelectedTab.Tag).ActiveOpenForm;
                frm.Select();
            }
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                var r = tabControl1.GetTabRect(i);
                var closeImage = Properties.Resources.tabclose;
                var closeRect = new Rectangle((r.Right - closeImage.Width), r.Top + (r.Height - closeImage.Height) / 2,
                    closeImage.Width, closeImage.Height);

                if (closeRect.Contains(e.Location))
                {
                    this.ActiveMdiChild.Close();
                    break;
                }
            }
        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            //MDI메뉴와 Child메뉴가 합쳐질때 발생하는 이벤트
            //최소화(&N) 이전 크기로(&R)  닫기(&C) ""
            if (e.Item.Text == "" ||
                e.Item.Text == "최소화(&N)" ||
                e.Item.Text == "이전 크기로(&R)" ||
                e.Item.Text == "닫기(&C)")
                e.Item.Visible = false;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                this.ActiveMdiChild.Close();
            }

            this.LoginEmpInfo = null;
            pnlMenu.Controls.Clear();
            pnlChildMenu.Controls.Clear();
            if (!Login())
                Application.Exit();
        }
    }

    class TabTag
    {
        public Form ActiveOpenForm { get; set; }
        public int MenuID { get; set; }
    }
}
