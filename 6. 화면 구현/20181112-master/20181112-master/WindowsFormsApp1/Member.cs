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
    public partial class Member : Form
    {
        Reuse re = new Reuse();
        public Member()
        {

            InitializeComponent();
            ClientSize = new Size(250, 120);
            BackColor = Color.DimGray;
            Load += Member_Load;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            DesktopLocation = new Point(380, 310);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            Button Member_Btn = new Button();
            Member_Btn.Text = "회원";
            Member_Btn.Size = new Size(90, 60);
            Member_Btn.Location = new Point(30, 30);
            Controls.Add(Member_Btn);
            Member_Btn.BackColor = Color.Green;
            Member_Btn.ForeColor = Color.White;
            Member_Btn.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            Member_Btn.Click += Member_click;

            Button NonMember_Btn = new Button();
            NonMember_Btn.Text = "비회원";
            NonMember_Btn.Size = new Size(90, 60);
            NonMember_Btn.Location = new Point(130, 30);
            Controls.Add(NonMember_Btn);
            NonMember_Btn.BackColor = Color.DimGray;
            NonMember_Btn.ForeColor = Color.White;
            NonMember_Btn.Font = new Font(FontFamily.GenericSansSerif, 20.0F, FontStyle.Bold);
            NonMember_Btn.Click += NonMember_click;
        }

        private void Member_click(object o, EventArgs e)
        {
            Button Charge_Btn;
            Charge_Btn = (Button)o;

            Member_login ml = new Member_login();
            ml.Show();

        }
        private void NonMember_click(object o, EventArgs e)
        {
            Button Charge_Btn;
            Charge_Btn = (Button)o;

            Non_Member_Time nt = new Non_Member_Time();
            nt.Show();

        }
    }
}