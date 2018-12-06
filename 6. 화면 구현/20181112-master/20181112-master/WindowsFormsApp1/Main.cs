using System;
using System.Collections;
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
    public partial class Main : Form
    {
        Panel panel;
        ArrayList arrayList;
        Button Seat_Btn;
        Label Seat_num;
        Reuse re = new Reuse();
        Label User_time;

        public Main()
        {
            InitializeComponent();
            Load += Main_Load;
            ClientSize = new Size(1220, 603);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            arrayList = new ArrayList();
            DesktopLocation = new Point(350, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel();

        }
        public void Panel()
        {
            panel = new Panel();
            panel.Location = new Point(10, 10);
            panel.Size = new Size(1220, 603);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.BackColor = Color.DarkGray;
            Panel1();
            Panel2();
            Panel3();
        }
        public void Panel1()
        {
            panel = new Panel();
            Button Charge_Btn = new Button();
            Button Info_Btn = new Button();
            PictureBox logo = new PictureBox();

            panel.Location = new Point(10, 10);
            panel.Size = new Size(970, 75);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.BackColor = Color.DimGray;

            Charge_Btn.DialogResult = DialogResult.OK;
            Charge_Btn.Text = "회원/비회원 충전";
            Charge_Btn.Size = new Size(150, 50);
            Charge_Btn.Location = new Point(20, 10);
            Charge_Btn.BackColor = Color.LightGray;
            Charge_Btn.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Charge_Btn.Click += Charge_Btn_click;

            Info_Btn.DialogResult = DialogResult.OK;
            Info_Btn.Text = "사용회원 검색";
            Info_Btn.Size = new Size(150, 50);
            Info_Btn.Location = new Point(190, 10);
            Info_Btn.BackColor = Color.LightGray;
            Info_Btn.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Info_Btn.Click += Info_Btn_click;


            logo.Image = (Bitmap)WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject("schubert");
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.Size = new Size(40, 40);
            logo.Location = new Point(740, 15);

            re.Plb(panel, "sbt", "Schubert PC", 200, 100, 780, 18, Color.DimGray, Color.White, FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            re.Plb(panel, "Rest_seat", "빈 자리 64좌석", 170, 40, 360, 15, Color.OrangeRed, Color.White, FontFamily.GenericSansSerif, 19, FontStyle.Bold);
            re.Plb(panel, "Time", "현재 시간 14:15", 185, 40, 545, 15, Color.Orange, Color.White, FontFamily.GenericSansSerif, 19, FontStyle.Bold);

            Controls.Add(panel);
            panel.Controls.Add(Charge_Btn);
            panel.Controls.Add(Info_Btn);
            panel.Controls.Add(logo);
        }

        private void Charge_Btn_click(object o, EventArgs a)
        {
            Button Charge_Btn;
            Charge_Btn = (Button)o;

            Member mb = new Member();
            mb.Show();
        }
        private void Info_Btn_click(object o, EventArgs a)
        {
            Button Info_Btn;
            Info_Btn = (Button)o;
            Search sc = new Search();
            sc.ShowDialog();

        }
        public void Panel2()
        {
            panel = new Panel();
            Button seat = new Button();

            panel.Location = new Point(10, 10);
            panel.Size = new Size(970, 583);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.Gray;

            Controls.Add(panel);
            Seat_Num();
            Seat();

        }
        public void Panel3()
        {
            panel = new Panel();
            PictureBox map = new PictureBox();

            panel.Location = new Point(990, 10);
            panel.Size = new Size(220, 583);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.Gray;

            map.Image = (Bitmap)WindowsFormsApp1.Properties.Resources.ResourceManager.GetObject("minimap");
            map.SizeMode = PictureBoxSizeMode.StretchImage;
            map.Size = new Size(210, 210);
            map.Location = new Point(5, 25);

            re.Plb(panel, "notice", "오늘도 저희 PC방을\n찾아오신 고객님께\n감사드립니다." +
                        "\n\nSchubert PC는\n유료 게임 시간 차감을\n별도로 하지 않습니다." +
                        "\n\n문제 발생시 카운터로\n문의해주세요.", 300, 400, 10, 273, Color.Gray, Color.White, FontFamily.GenericSansSerif, 18, FontStyle.Bold);

            Controls.Add(panel);
            panel.Controls.Add(map);
        }
        public void Seat()
        {
            int count = 1;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Seat_Btn = new Button();
                    Seat_Btn.Size = new Size(85, 60);
                    Seat_Btn.Location = new Point((94 * j) + 19, (69 * i) + 90);
                    Seat_Btn.Name = string.Format("btn{0}", count++);
                    Seat_Btn.Cursor = Cursors.Hand;
                    if (Seat_Btn.Name == "btn1" || Seat_Btn.Name == "btn2" || Seat_Btn.Name == "btn3" || Seat_Btn.Name == "btn15" || Seat_Btn.Name == "btn19" || Seat_Btn.Name == "btn34")
                    {
                        Seat_Btn.BackColor = Color.LimeGreen;
                    }
                    else Seat_Btn.BackColor = Color.DimGray;
                    //arrayList.Add(Seat_Btn);
                    if (Seat_Btn.Name == "btn1")
                    {
                        Seat_Btn.Text = "나진욱";
                    }
                    else if (Seat_Btn.Name == "btn2")
                    {
                        Seat_Btn.Text = "천호성";
                    }
                    else if (Seat_Btn.Name == "btn3")
                    {
                        Seat_Btn.Text = "김주헌";
                    }
                    else if (Seat_Btn.Name == "btn15")
                    {
                        Seat_Btn.Text = "나훈아";
                    }
                    else if (Seat_Btn.Name == "btn19")
                    {
                        Seat_Btn.Text = "천진반";
                    }
                    else if (Seat_Btn.Name == "btn34")
                    {
                        Seat_Btn.Text = "천호천";
                    }
                    Seat_Btn.Font = new Font(FontFamily.GenericSansSerif, 16.0F, FontStyle.Bold);
                    Seat_Btn.ForeColor = Color.White;
                    Seat_Btn.TextAlign = ContentAlignment.BottomRight;

                    panel.Controls.Add(Seat_Btn);
                    Seat_Btn.Click += Seat_clik;
                }
            }
        }

        private void Seat_clik(object o, EventArgs e)
        {     
            string Users = "";
            string Time = "";

            Seat_Btn = (Button)o;
            User_Info();

            if (Seat_Btn.BackColor == Color.LimeGreen)
            {
                Time = User_time.Text;
                Users = Seat_Btn.Text;  
                Member_Time mt = new Member_Time(Users, Time);

                if (Application.OpenForms["Main"] is Form Main) Main.Visible = false;
                mt.Show();
            }
        }

        public void Seat_Num()
        {
            int count = 1;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Seat_num = new Label();
                    Seat_num.Size = new Size(30, 25);
                    Seat_num.Location = new Point((94 * j) + 25, (69 * i) + 96);
                    Seat_num.Text = string.Format("{0}", count++);
                    Seat_num.ForeColor = Color.White;
                    Seat_num.BackColor = Color.Black;
                    Seat_num.TextAlign = ContentAlignment.MiddleCenter;
                    Seat_num.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
                    panel.Controls.Add(Seat_num);
                }
            }
        }

        public void User_Info()
        {
            User_time = new Label();
            if (Seat_Btn.Name == "btn1")
            {
                User_time.Text = "잔여 시간    00:34";
            }
            else if(Seat_Btn.Name == "btn2")
            {
                User_time.Text = "잔여 시간    00:27";
            }
            else if (Seat_Btn.Name == "btn3")
            {
                User_time.Text = "잔여 시간    11:23";
            }
            else if (Seat_Btn.Name == "btn15")
            {
                User_time.Text = "잔여 시간    16:37";
            }
            else if (Seat_Btn.Name == "btn19")
            {
                User_time.Text = "잔여 시간    07:03";
            }
            else if (Seat_Btn.Name == "btn34")
            {
                User_time.Text = "잔여 시간    36:47";
            }
        }
    }
}