using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Load += Form3_Load;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ListView lv = lv_create();
            Controls.Add(lv);
        }

        private ListView lv_create()
        {
            ListView lv = new ListView();
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            lv.Columns.Add(columnHeader1);
            lv.Columns.Add(columnHeader3);
            lv.Columns.Add(columnHeader2);

            columnHeader1.Text = "Column 1";
            columnHeader1.Width = 100;
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            columnHeader2.Text = "Column 2";
            columnHeader2.Width = 150;
            columnHeader2.TextAlign = HorizontalAlignment.Left;

            columnHeader3.Text = "Column 3";
            columnHeader3.Width = 200;
            columnHeader3.TextAlign = HorizontalAlignment.Right;

            lv.GridLines = true;
            lv.Location = new Point(12, 12);
            lv.Name = "listView1";
            lv.Size = new Size(776, 426);
            lv.TabIndex = 0;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = View.Details;

            return lv;
        }
    }
}
