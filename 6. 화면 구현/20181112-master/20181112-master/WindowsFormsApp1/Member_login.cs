using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Member_login : Form
    {
        TextBox Content;
        Panel panel = new Panel();
        ListViewItem item1, item2, item3, item4;
        Reuse re = new Reuse();
        ListView Search_View = new ListView();
        public Member_login()
        {
            InitializeComponent();
            ClientSize = new Size(1000, 600);
            MaximizeBox = false;
            this.Search_View.Scrollable = false;
            Load += Member_login_Load;

        }

        private void Member_login_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["Member"] is Form Member) Member.Close();
            if (Application.OpenForms["Main"] is Form Main) Main.Visible = false;
            
            DesktopLocation = new Point(350, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;  
            Panel();
        }

        public void Panel()
        {
            Content = new TextBox();
            Button Main_Btn = new Button();
            //Label ID_label = new Label();
            Button Search_Btn = new Button();
            Button Remove_Btn = new Button();

            panel.Location = new Point(10, 10);
            panel.Size = new Size(980, 580);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panel.BackColor = Color.DimGray;

            Main_Btn.Text = "초기 화면";
            Main_Btn.Size = new Size(130, 40);
            Main_Btn.Location = new Point(20, 20);
            Main_Btn.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            Main_Btn.BackColor = Color.Black;
            Main_Btn.ForeColor = Color.White;
            Main_Btn.Click += Main_Btn_click;

            re.Plb(panel, "ID_label", "회원 ID / 이름", 330, 60, 30, 60, Color.DimGray, Color.White, FontFamily.GenericSansSerif, 40, FontStyle.Bold);

            Content.Text = "";
            Content.Size = new Size(385, 0);
            Content.Location = new Point(360, 60);
            Content.Font = new Font(FontFamily.GenericSansSerif, 40.0F, FontStyle.Bold);

            Search_Btn.Text = "검색";
            Search_Btn.Size = new Size(105, 73);
            Search_Btn.Location = new Point(750, 57);
            Search_Btn.Font = new Font(FontFamily.GenericSansSerif, 25.0F, FontStyle.Bold);
            Search_Btn.BackColor = Color.DimGray;
            Search_Btn.ForeColor = Color.White;
            Search_Btn.Click += Search_Btn_click;

            Remove_Btn.Text = "지우기";
            Remove_Btn.Size = new Size(105, 73);
            Remove_Btn.Location = new Point(857, 57);
            Remove_Btn.Font = new Font(FontFamily.GenericSansSerif, 25.0F, FontStyle.Bold);
            Remove_Btn.BackColor = Color.DimGray;
            Remove_Btn.ForeColor = Color.White;
            Remove_Btn.Click += Remove_Btn_click;

            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            Search_View.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            Search_View.BackColor = Color.WhiteSmoke;
            Search_View.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            columnHeader1.Text = "";
            columnHeader1.Width = 0;

            columnHeader2.Text = "순번";
            columnHeader2.Width = 315;
            columnHeader2.TextAlign = HorizontalAlignment.Center;

            columnHeader3.Text = "이름";
            columnHeader3.Width = 315;
            columnHeader3.TextAlign = HorizontalAlignment.Center;

            columnHeader4.Text = "회원 ID";
            columnHeader4.Width = 315;
            columnHeader4.TextAlign = HorizontalAlignment.Center;

            Search_View.GridLines = true;
            Search_View.Size = new Size(940, 420);
            Search_View.Location = new Point(20, 140);
            Search_View.TabIndex = 0;
            Search_View.UseCompatibleStateImageBehavior = false;
            Search_View.View = View.Details;

            item1 = new ListViewItem();
            item2 = new ListViewItem();
            item3 = new ListViewItem();
            item4 = new ListViewItem();
            Search_View.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });

            Controls.Add(panel);
            panel.Controls.Add(Main_Btn);
            panel.Controls.Add(Content);
            panel.Controls.Add(Search_Btn);
            panel.Controls.Add(Remove_Btn);
            panel.Controls.Add(Search_View);

        }
        public void Search_Btn_click(object o, EventArgs a)
        {
            foreach (Control ctr in panel.Controls)
            {
                if (Content.Text == "나진욱" || Content.Text == "나진" || Content.Text == "진욱" || Content.Text == "skwlsdnr" || Content.Text == "skwlsdnr94")
                {
                    item1.SubItems.Add("1");
                    item1.SubItems.Add("나진욱");
                    item1.SubItems.Add("skwlsdnr94");
                }
                else if (Content.Text == "나")
                {
                    item1.SubItems.Add("1");
                    item1.SubItems.Add("나윤권");
                    item1.SubItems.Add("Nana88");
                    item2.SubItems.Add("2");
                    item2.SubItems.Add("나얼");
                    item2.SubItems.Add("Navocal7");
                    item3.SubItems.Add("3");
                    item3.SubItems.Add("나진욱");
                    item3.SubItems.Add("skwlsdnr94");
                    item4.SubItems.Add("4");
                    item4.SubItems.Add("나훈아");
                    item4.SubItems.Add("huna1846");
                }
                else if (Content.Text == "천호성" || Content.Text == "호성")
                {
                    item1.SubItems.Add("1");
                    item1.SubItems.Add("천호성");
                    item1.SubItems.Add("hosung1000");
                }
                else if (Content.Text == "천호")
                {
                    item1.SubItems.Add("1");
                    item1.SubItems.Add("천호성");
                    item1.SubItems.Add("hosung1000");
                    item2.SubItems.Add("2");
                    item2.SubItems.Add("천호천");
                    item2.SubItems.Add("how0841");
                }
                else if (Content.Text == "천")
                {
                    item1.SubItems.Add("1");
                    item1.SubItems.Add("천진반");
                    item1.SubItems.Add("cjb3481");
                    item2.SubItems.Add("2");
                    item2.SubItems.Add("천청명");
                    item2.SubItems.Add("cm1035");
                    item3.SubItems.Add("3");
                    item3.SubItems.Add("천호성");
                    item3.SubItems.Add("hosung1000");
                    item4.SubItems.Add("4");
                    item4.SubItems.Add("천호천");
                    item4.SubItems.Add("how0841");
                }
                else if (Content.Text == "김" || Content.Text == "김주" || Content.Text == "주헌" || Content.Text == "김주헌")
                {
                    item1.SubItems.Add("1");
                    item1.SubItems.Add("김주헌");
                    item1.SubItems.Add("juhun450");
                }
            }
        }
        public void Main_Btn_click(object o, EventArgs a)
        {
            if (Application.OpenForms["Main"] is Form Main) Main.Visible = true;
            this.Close();
        }

        public void Remove_Btn_click(object o, EventArgs e)
        {
            item1.SubItems.Clear();
            item2.SubItems.Clear();
            item3.SubItems.Clear();
            item4.SubItems.Clear();
            Content.Text = "";
            Content.Focus();
        }
    }
}