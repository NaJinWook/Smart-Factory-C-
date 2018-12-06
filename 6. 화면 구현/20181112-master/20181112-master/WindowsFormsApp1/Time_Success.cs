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
    public partial class Time_Success : Form
    {
        Reuse re = new Reuse();
        public Time_Success()
        {
            InitializeComponent();
            ClientSize = new Size(1200, 620);
            BackColor = Color.DimGray;
            Load += Time_Success_Load;
        }

        private void Time_Success_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(350, 200);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Time_Success_Panel_2();
            Time_Success_Panel_1();
            
        }

        public void Time_Success_Panel_1()
        {
            Panel Time_Success_Panel_1 = new Panel();
            Label Time_Success_Label_1 = new Label();
            Panel Time_Success_Panel_2 = new Panel();


            Time_Success_Panel_1.Location = new Point(10, 10);
            Time_Success_Panel_1.Size = new Size(1180, 230);
            Time_Success_Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Time_Success_Panel_1.BackColor = Color.LightGray;
            Time_Success_Panel_1.ForeColor = Color.White;

            Time_Success_Label_1.Location = new Point(20, 20);
            Time_Success_Label_1.Size = new Size(1140, 200);
            Time_Success_Label_1.Text = "충전이 완료되었습니다.";
            Time_Success_Label_1.BackColor = Color.DimGray;
            Time_Success_Label_1.TextAlign = ContentAlignment.MiddleCenter;
            Time_Success_Label_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            this.Controls.Add(Time_Success_Panel_1);
            Time_Success_Panel_1.Controls.Add(Time_Success_Label_1);
            Time_Success_Panel_1.Controls.Add(Time_Success_Panel_2);

        }
        public void Time_Success_Panel_2()
        {
            Panel Time_Success_Panel_2 = new Panel();
            Button Time_Success_button_1 = new Button();
            Label Time_Success_Label_2 = new Label();
            

            Time_Success_Panel_2.Location = new Point(10, 180);
            Time_Success_Panel_2.Size = new Size(1180, 430);
            Time_Success_Panel_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Time_Success_Panel_2.BackColor = Color.LightGray;
            Time_Success_Panel_2.ForeColor = Color.White;


            Time_Success_Label_2.Location = new Point(20, 20);
            Time_Success_Label_2.Size = new Size(1140, 390);
            Time_Success_Label_2.Text = "회원 이름(미구현)\n\n이용해주셔서 감사합니다.";
            Time_Success_Label_2.ForeColor = Color.Black;
            Time_Success_Label_2.BackColor = Color.White;
            Time_Success_Label_2.TextAlign = ContentAlignment.MiddleCenter;
            Time_Success_Label_2.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);


            Time_Success_button_1.DialogResult = DialogResult.OK;
            Time_Success_button_1.Text = "처음으로";
            Time_Success_button_1.Size = new Size(200, 100);
            Time_Success_button_1.Location = new Point(940, 290);
            Time_Success_button_1.BackColor = Color.Black;
            Time_Success_button_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);
            Time_Success_button_1.Click += Main_Btn_click;

            this.Controls.Add(Time_Success_Panel_2);
            Time_Success_Panel_2.Controls.Add(Time_Success_button_1);
            Time_Success_Panel_2.Controls.Add(Time_Success_Label_2);

        }

        public void Main_Btn_click(object o, EventArgs a)
        {
            if (Application.OpenForms["Main"] is Form Main) Main.Visible = true;
            this.Close();
        }
    }
}