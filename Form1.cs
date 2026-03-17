using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf351
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pn = new Pen(Color.Red, 4);
            Brush br = new SolidBrush(Color.Green);
            g.Clear(SystemColors.Control);
            switch (listBox1.SelectedIndex)
            {
                case 0: g.DrawLine(pn, 150, 40, 350, 180); break;
                case 1: g.DrawRectangle(pn, 150, 30, 250, 150); break;
                case 2: g.FillRectangle(br, 150, 30, 250, 150); break;
                case 3: g.DrawEllipse(pn, 150, 30, 250, 150); break;
                case 4: g.FillEllipse(br, 150, 30, 250, 150); break;
                case 5: g.DrawPie(pn, 150, 30, 200, 200, 180, 225); break;
                case 6: g.FillPie(br, 150, 30, 150, 150, 0, 45); break;
            }
        }
    }
}