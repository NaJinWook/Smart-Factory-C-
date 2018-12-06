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
    public partial class Non_Member_Time : Form
    {
        Reuse re = new Reuse();
        Label Member_Label_3;
        Label Member_Label_4;
        // Label Member_Label_5;

        public Non_Member_Time()
        {
            InitializeComponent();
            ClientSize = new Size(1220, 603);
            BackColor = Color.DimGray;
            Non_Member_Panel_1();
            Non_Member_Panel_2();
            Load += Non_Member_Time_Load;
        }

        private void Non_Member_Time_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms["Member"] is Form Member) Member.Close();
            if (Application.OpenForms["Main"] is Form Main) Main.Visible = false;
            DesktopLocation = new Point(350, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }
        public void Non_Member_Panel_1()
        {
            Panel Member_Panel_1 = new Panel();
            Button Member_button_1 = new Button();
            Button Member_button_2 = new Button();
            Button Member_button_3 = new Button();
            Button Member_button_4 = new Button();
            Label Member_Label_1 = new Label();
            Label Member_Label_2 = new Label();

            Member_Panel_1.Location = new Point(20, 20);
            Member_Panel_1.Size = new Size(585, 565);
            Member_Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_1.BackColor = Color.LightGray;
            Member_Panel_1.ForeColor = Color.White;

            re.Plb(Member_Panel_1, "Member_Label_1", " 비회원 요금제 선택", 255, 50, 165, 15, Color.DimGray, Color.White, FontFamily.GenericSansSerif, 30, FontStyle.Bold);
            //Reuse_라벨

            re.Plb(Member_Panel_1, "Member_Label_2", "X 비회원님은 시간 적립 대상이 아닙니다.", 565, 80, 90, 520, Color.Transparent, Color.Red, FontFamily.GenericSansSerif, 20, FontStyle.Bold);
            //Reuse_라벨

            Member_button_1.DialogResult = DialogResult.OK;
            Member_button_1.Text = "1,000원\n(적립불가)\n충전 시간 01:00";
            Member_button_1.Size = new Size(200, 140);
            Member_button_1.Location = new Point(90, 90);
            Member_button_1.BackColor = Color.Gray;
            Member_button_1.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_1.Click += Member_button_1_Click;
            Member_button_1.TabStop = false;
            Member_button_1.FlatStyle = FlatStyle.Flat;
            Member_button_1.FlatAppearance.BorderSize = 0;

            Member_button_2.DialogResult = DialogResult.OK;
            Member_button_2.Text = "2,000원\n(적립불가)\n충전 시간 02:00";
            Member_button_2.Size = new Size(200, 140);
            Member_button_2.Location = new Point(310, 90);
            Member_button_2.BackColor = Color.Gray;
            Member_button_2.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_2.Click += Member_button_2_Click;
            Member_button_2.TabStop = false;
            Member_button_2.FlatStyle = FlatStyle.Flat;
            Member_button_2.FlatAppearance.BorderSize = 0;

            Member_button_3.DialogResult = DialogResult.OK;
            Member_button_3.Text = "3,000원\n(적립불가)\n충전 시간 03:00";
            Member_button_3.Size = new Size(200, 140);
            Member_button_3.Location = new Point(90, 250);
            Member_button_3.BackColor = Color.Gray;
            Member_button_3.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_3.Click += Member_button_3_Click;
            Member_button_3.TabStop = false;
            Member_button_3.FlatStyle = FlatStyle.Flat;
            Member_button_3.FlatAppearance.BorderSize = 0;

            Member_button_4.DialogResult = DialogResult.OK;
            Member_button_4.Text = "5,000원\n(적립불가)\n충전 시간 05:00";
            Member_button_4.Size = new Size(200, 140);
            Member_button_4.Location = new Point(310, 250);
            Member_button_4.BackColor = Color.Gray;
            Member_button_4.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);
            Member_button_4.Click += Member_button_4_Click;
            Member_button_4.TabStop = false;
            Member_button_4.FlatStyle = FlatStyle.Flat;
            Member_button_4.FlatAppearance.BorderSize = 0;


            this.Controls.Add(Member_Panel_1);
            Member_Panel_1.Controls.Add(Member_button_1);
            Member_Panel_1.Controls.Add(Member_button_2);
            Member_Panel_1.Controls.Add(Member_button_3);
            Member_Panel_1.Controls.Add(Member_button_4);
        }

        public void Non_Member_Panel_2()
        {
            Panel Member_Panel_2 = new Panel();
            Label Member_Label_2 = new Label();
            Member_Label_3 = new Label();
            Button Member_button_7 = new Button();
            Button Member_button_8 = new Button();
            Member_Label_4 = new Label();
            //Member_Label_5 = new Label();

            Member_Panel_2.Location = new Point(615, 20);
            Member_Panel_2.Size = new Size(585, 565);
            Member_Panel_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Member_Panel_2.BackColor = Color.LightGray;
            Member_Panel_2.ForeColor = Color.White;

            re.Plb(Member_Panel_2, "Member_Label_2", " 결제 정보 확인", 265, 50, 165, 15, Color.DimGray, Color.White, FontFamily.GenericSansSerif, 30, FontStyle.Bold);

            //re.Plb(Member_Panel_2, "Member_Label_3", " ", 510, 200, 40, 90, Color.White, Color.Black, FontFamily.GenericSansSerif, 30, FontStyle.Bold);
            Member_Label_3.Location = new Point(40, 90);
            Member_Label_3.Size = new Size(510, 200);
            Member_Label_3.BackColor = Color.White;
            Member_Label_3.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
            Member_Label_3.ForeColor = Color.Black;
            Member_Label_3.TextAlign = ContentAlignment.TopCenter;

            Member_Label_4.Location = new Point(40, 280);
            Member_Label_4.Size = new Size(510, 90);
            Member_Label_4.BackColor = Color.White;
            Member_Label_4.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
            Member_Label_4.ForeColor = Color.IndianRed;
            Member_Label_4.TextAlign = ContentAlignment.MiddleCenter;

            re.Plb(Member_Panel_2, "Member_Label_5", "합계금액", 180, 60, 120, 302, Color.White, Color.Black, FontFamily.GenericSansSerif, 30, FontStyle.Bold);
            //Member_Label_5.Location = new Point(120, 302);
            //Member_Label_5.Size = new Size(180, 60);
            //Member_Label_5.BackColor = Color.White;
            //Member_Label_5.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
            //Member_Label_5.ForeColor = Color.Black;



            Member_button_7.DialogResult = DialogResult.OK;
            Member_button_7.Text = "현 금";
            Member_button_7.Size = new Size(252, 130);
            Member_button_7.Location = new Point(40, 423);
            Member_button_7.BackColor = Color.SteelBlue;
            Member_button_7.Font = new Font(FontFamily.GenericSansSerif, 40.0F, FontStyle.Bold);
            Member_button_7.Click += Charge_Btn_click;
            Member_button_7.TabStop = false;
            Member_button_7.FlatStyle = FlatStyle.Flat;
            Member_button_7.FlatAppearance.BorderSize = 0;

            Member_button_8.DialogResult = DialogResult.OK;
            Member_button_8.Text = "취 소";
            Member_button_8.Size = new Size(252, 130);
            Member_button_8.Location = new Point(300, 423);
            Member_button_8.BackColor = Color.MediumSeaGreen;
            Member_button_8.Font = new Font(FontFamily.GenericSansSerif, 40.0F, FontStyle.Bold);
            Member_button_8.Click += Cancle_Btn_click;
            Member_button_8.TabStop = false;
            Member_button_8.FlatStyle = FlatStyle.Flat;
            Member_button_8.FlatAppearance.BorderSize = 0;

            this.Controls.Add(Member_Panel_2);
            Member_Panel_2.Controls.Add(Member_Label_3);
            Member_Panel_2.Controls.Add(Member_Label_4);
            //Member_Panel_2.Controls.Add(Member_Label_5);
            Member_Panel_2.Controls.Add(Member_button_7);
            Member_Panel_2.Controls.Add(Member_button_8);

        }
        public void Member_button_1_Click(object o, EventArgs a)
        {
            Member_Label_3.Name = "money1000";
            Member_Label_3.Text = "\n충전시간 01:00";
            Member_Label_4.Text = "합계금액 1,000원";
            //Member_Label_5.Text = "합계금액sadasdasdasdasdasd";
        }
        public void Member_button_2_Click(object o, EventArgs a)
        {
            Member_Label_3.Name = "money2000";
            Member_Label_3.Text = "\n충전시간 02:00";
            Member_Label_4.Text = "합계금액 2,000원";
            //Member_Label_5.Text = "합계금액";
        }
        public void Member_button_3_Click(object o, EventArgs a)
        {
            Member_Label_3.Name = "money3000";
            Member_Label_3.Text = "\n충전시간 03:00";
            Member_Label_4.Text = "합계금액 3,000원";
            //Member_Label_5.Text = "합계금액";
        }
        public void Member_button_4_Click(object o, EventArgs a)
        {
            Member_Label_3.Name = "money5000";
            Member_Label_3.Text = "\n충전시간 05:00";
            Member_Label_4.Text = "합계금액 5,000원";
            //Member_Label_5.Text = "합계금액";
        }

        private void Charge_Btn_click(object o, EventArgs a)
        {
            string input3 = "";

            if (Member_Label_3.Name == "money1000")
            {
                input3 = "충전시간 01:00";
                Non_Time_Success nts = new Non_Time_Success(input3);
                nts.Show();
                this.Close();
            }
            else if (Member_Label_3.Name == "money2000")
            {
                input3 = "충전시간 02:00";
                Non_Time_Success nts = new Non_Time_Success(input3);
                nts.Show();
                this.Close();
            }
            else if (Member_Label_3.Name == "money3000")
            {
                input3 = "충전시간 03:00";
                Non_Time_Success nts = new Non_Time_Success(input3);
                nts.Show();
                this.Close();
            }
            else if (Member_Label_3.Name == "money5000")
            {
                input3 = "충전시간 05:00";
                Non_Time_Success nts = new Non_Time_Success(input3);
                nts.Show();
                this.Close();
            }



        }   //충전 클릭 이벤트
        private void Cancle_Btn_click(object o, EventArgs e)
        {
            if (Application.OpenForms["Main"] is Form Main) Main.Visible = true;
            this.Close();

        }   //취소 클릭 이벤트
    }
}