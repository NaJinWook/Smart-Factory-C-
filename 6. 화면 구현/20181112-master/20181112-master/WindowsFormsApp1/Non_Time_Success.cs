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
    public partial class Non_Time_Success : Form
    {
        Reuse re = new Reuse();
        string input2;
        public Non_Time_Success(string input)
        {
            InitializeComponent();
            ClientSize = new Size(1200, 620);
            BackColor = Color.DimGray;
            Non_Time_Success_Panel_1();
            Non_Time_Success_Panel_2();
            Load += Non_Time_Success_Load;
            input2 = input;
        }

        private void Non_Time_Success_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(350, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void Non_Time_Success_Panel_1()
        {
            Panel Non_Time_Success_Panel_1 = new Panel();
            Label Non_Time_Success_Label_1 = new Label();
            Panel Non_Time_Success_Panel_2 = new Panel();


            Non_Time_Success_Panel_1.Location = new Point(10, 10);
            Non_Time_Success_Panel_1.Size = new Size(1180, 130);
            Non_Time_Success_Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Non_Time_Success_Panel_1.BackColor = Color.LightGray;
            Non_Time_Success_Panel_1.ForeColor = Color.White;

            Non_Time_Success_Label_1.Location = new Point(20, 20);
            Non_Time_Success_Label_1.Size = new Size(1140, 120);
            Non_Time_Success_Label_1.Text = "충전이 완료되었습니다.";
            Non_Time_Success_Label_1.BackColor = Color.DimGray;
            Non_Time_Success_Label_1.TextAlign = ContentAlignment.MiddleCenter;
            Non_Time_Success_Label_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            this.Controls.Add(Non_Time_Success_Panel_1);
            Non_Time_Success_Panel_1.Controls.Add(Non_Time_Success_Label_1);
            Non_Time_Success_Panel_1.Controls.Add(Non_Time_Success_Panel_2);

        }
        public void Non_Time_Success_Panel_2()
        {
            Panel Non_Time_Success_Panel_2 = new Panel();
            Button Non_Time_Success_button_1 = new Button();
            Label Non_Time_Success_Label_2 = new Label();
            Label Non_Time_Success_Label_3 = new Label();


            Non_Time_Success_Panel_2.Location = new Point(10, 100);
            Non_Time_Success_Panel_2.Size = new Size(1180, 510);
            Non_Time_Success_Panel_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Non_Time_Success_Panel_2.BackColor = Color.LightGray;
            Non_Time_Success_Panel_2.ForeColor = Color.White;

            Random r = new Random();
            int a = r.Next(1, 71);
            Non_Time_Success_Label_2.Location = new Point(20, 40);
            Non_Time_Success_Label_2.Size = new Size(1140, 180);
            Non_Time_Success_Label_2.Text = a + "번 고객님";
            Non_Time_Success_Label_2.ForeColor = Color.Black;
            Non_Time_Success_Label_2.BackColor = Color.White;
            Non_Time_Success_Label_2.TextAlign = ContentAlignment.MiddleCenter;
            Non_Time_Success_Label_2.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Non_Time_Success_Label_3.Text = "이용해주셔서 감사합니다.";
            Non_Time_Success_Label_3.Location = new Point(20, 220);
            Non_Time_Success_Label_3.Size = new Size(1140, 270);
            Non_Time_Success_Label_3.ForeColor = Color.Black;
            Non_Time_Success_Label_3.BackColor = Color.White;
            Non_Time_Success_Label_3.TextAlign = ContentAlignment.TopCenter;
            Non_Time_Success_Label_3.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);


            Non_Time_Success_button_1.DialogResult = DialogResult.OK;
            Non_Time_Success_button_1.Text = "처음으로";
            Non_Time_Success_button_1.Size = new Size(200, 100);
            Non_Time_Success_button_1.Location = new Point(940, 290);
            Non_Time_Success_button_1.BackColor = Color.Black;
            Non_Time_Success_button_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
            Non_Time_Success_button_1.Click += Main_Btn_click;
            Non_Time_Success_button_1.TabStop = false;
            Non_Time_Success_button_1.FlatStyle = FlatStyle.Flat;
            Non_Time_Success_button_1.FlatAppearance.BorderSize = 0;

            this.Controls.Add(Non_Time_Success_Panel_2);
            Non_Time_Success_Panel_2.Controls.Add(Non_Time_Success_button_1);
            Non_Time_Success_Panel_2.Controls.Add(Non_Time_Success_Label_2);
            Non_Time_Success_Panel_2.Controls.Add(Non_Time_Success_Label_3);

        }

        public void Main_Btn_click(object o, EventArgs a)
        {
            if (Application.OpenForms["Main"] is Form Main) Main.Visible = true;
            this.Close();
        }

        public void random()
        {
            Random r = new Random();
            int a = r.Next(1, 101);
            Console.Write(a);
        }

    }
}