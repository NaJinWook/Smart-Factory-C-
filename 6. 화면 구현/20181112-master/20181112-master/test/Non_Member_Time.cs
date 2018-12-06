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
    public partial class Non_Member_Time : Form
    {
        public Non_Member_Time()
        {
            InitializeComponent();
            ClientSize = new Size(1100, 570);
            BackColor = Color.DimGray;
            Non_Member_Panel_1();
            Non_Member_Panel_2();
        }
        public void Non_Member_Panel_1()
        {
            Panel Non_Member_Panel_1 = new Panel();
            Label Non_Member_Label_1 = new Label();
            Panel Non_Member_Panel_2 = new Panel();


            Non_Member_Panel_1.Location = new Point(10, 10);
            Non_Member_Panel_1.Size = new Size(1080, 180);
            Non_Member_Panel_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Non_Member_Panel_1.BackColor = Color.LightGray;
            Non_Member_Panel_1.ForeColor = Color.White;

            Non_Member_Label_1.Location = new Point(20, 20);
            Non_Member_Label_1.Size = new Size(1040, 150);
            Non_Member_Label_1.Text = "충전이 완료되었습니다.";
            Non_Member_Label_1.BackColor = Color.DimGray;
            Non_Member_Label_1.TextAlign = ContentAlignment.MiddleCenter;
            Non_Member_Label_1.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            this.Controls.Add(Non_Member_Panel_1);
            Non_Member_Panel_1.Controls.Add(Non_Member_Label_1);
            Non_Member_Panel_1.Controls.Add(Non_Member_Panel_2);

        }
        public void Non_Member_Panel_2()
        {
            Panel Non_Member_Panel_2 = new Panel();
            Button Non_Member_button_1 = new Button();
            Label Non_Member_Label_2 = new Label();


            Non_Member_Panel_2.Location = new Point(10, 180);
            Non_Member_Panel_2.Size = new Size(1080, 380);
            Non_Member_Panel_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Non_Member_Panel_2.BackColor = Color.LightGray;
            Non_Member_Panel_2.ForeColor = Color.White;

            Non_Member_Label_2.Location = new Point(20, 20);
            Non_Member_Label_2.Size = new Size(1040, 340);
            Non_Member_Label_2.Text = "";
            Non_Member_Label_2.BackColor = Color.White;
            Non_Member_Label_2.TextAlign = ContentAlignment.MiddleCenter;
            Non_Member_Label_2.Font = new Font(FontFamily.GenericSansSerif, 30.0F, FontStyle.Bold);

            Non_Member_button_1.DialogResult = DialogResult.OK;
            Non_Member_button_1.Text = "처음으로";
            Non_Member_button_1.Size = new Size(150, 100);
            Non_Member_button_1.Location = new Point(900, 250);
            Non_Member_button_1.BackColor = Color.Black;
            Non_Member_button_1.Font = new Font(FontFamily.GenericSansSerif, 15.0F, FontStyle.Bold);

            this.Controls.Add(Non_Member_Panel_2);
            Non_Member_Panel_2.Controls.Add(Non_Member_Label_2);
            Non_Member_Panel_2.Controls.Add(Non_Member_button_1);
        }
    }
}