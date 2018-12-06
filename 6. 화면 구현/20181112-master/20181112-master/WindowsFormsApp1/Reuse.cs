using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Reuse // 재사용 클래스
    {
        public void btn(Form form, string name, string text, int sX, int sY, int pX, int pY, Color bcolor, Color fcolor, FontFamily fontfamily, int size, FontStyle fontStyle)
        {                   //폼이냐 패널이냐, 이름, 내용, 가로사이즈, 세로사이즈, X좌표, Y좌표, 바탕색, 글씨색, FontFamily선언, 글씨크기, 글꼴스타일)
            Button btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Cursor = Cursors.Hand;
            btn.Name = name;
            btn.Text = text;
            btn.Size = new Size(sX, sY);
            btn.Location = new Point(pX, pY);
            btn.BackColor = bcolor;
            btn.ForeColor = fcolor;
            btn.Font = new Font(fontfamily, size, fontStyle);
            form.Controls.Add(btn);
        }

        public void Pbtn(Panel panel, string name, string text, int sX, int sY, int pX, int pY, Color bcolor, Color fcolor, FontFamily fontfamily, int size, FontStyle fontStyle)
        {                   //폼이냐 패널이냐, 이름, 내용, 가로사이즈, 세로사이즈, X좌표, Y좌표, 바탕색, 글씨색, FontFamily선언, 글씨크기, 글꼴스타일)
            Button btn = new Button();
            btn.DialogResult = DialogResult.OK;
            btn.Cursor = Cursors.Hand;
            btn.Name = name;
            btn.Text = text;
            btn.Size = new Size(sX, sY);
            btn.Location = new Point(pX, pY);
            btn.BackColor = bcolor;
            btn.ForeColor = fcolor;
            btn.Font = new Font(fontfamily, size, fontStyle);
            panel.Controls.Add(btn);
        }

        public void lb(Form form, string name, string text, int sX, int sY, int pX, int pY, Color bcolor, Color fcolor, FontFamily fontfamily, int size, FontStyle fontStyle)
        {                   //폼이냐 패널이냐, 이름, 내용, 가로사이즈, 세로사이즈, X좌표, Y좌표, 바탕색, 글씨색, FontFamily선언, 글씨크기, 글꼴스타일)
            Label lb = new Label();
            lb.Name = name;
            lb.Text = text;
            lb.Size = new Size(sX, sY);
            lb.Location = new Point(pX, pY);
            lb.BackColor = bcolor;
            lb.ForeColor = fcolor;
            lb.Font = new Font(fontfamily, size, fontStyle);
            form.Controls.Add(lb);
        }

        public void Plb(Panel panel, string name, string text, int sX, int sY, int pX, int pY, Color bcolor, Color fcolor, FontFamily fontfamily, int size, FontStyle fontStyle)
        {                   //폼이냐 패널이냐, 이름, 내용, 가로사이즈, 세로사이즈, X좌표, Y좌표, 바탕색, 글씨색, FontFamily선언, 글씨크기, 글꼴스타일)
            Label lb = new Label();
            lb.Name = name;
            lb.Text = text;
            lb.Size = new Size(sX, sY);
            lb.Location = new Point(pX, pY);
            lb.BackColor = bcolor;
            lb.ForeColor = fcolor;
            lb.Font = new Font(fontfamily, size, fontStyle);
            panel.Controls.Add(lb);
            lb.BringToFront();

        }
    }
}
