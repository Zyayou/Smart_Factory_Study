using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 3);
            Pen bluePen = new Pen(Color.Blue, 3);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            /*
            Rectangle rectangle = new Rectangle(50, 50, 200, 100);
            g.DrawRectangle(blackPen, rectangle);

            Point pt1 = new Point(50,50);
            Point pt2 = new Point(300,300);
            g.DrawLine(redPen, pt1, pt2);

            Rectangle rectf = new Rectangle(30, 30, 170, 170);
            g.DrawEllipse(bluePen, rectf);
            */

            Rectangle rectangle = new Rectangle(100, 150, 200, 100);
            g.DrawRectangle(blackPen, rectangle);

            Point pt1 = new Point(100, 150);
            Point pt2 = new Point(300, 250);
            g.DrawLine(blackPen, pt1, pt2);

            Point pt3 = new Point(100, 250);
            Point pt4 = new Point(300, 150);
            g.DrawLine(blackPen, pt3, pt4);

            Point[] ptt = new Point[3];
            ptt[0].X = 200; ptt[0].Y = 100;
            ptt[1].X = 100; ptt[1].Y = 150;
            ptt[2].X = 300;ptt[2].Y = 150;
            g.FillPolygon(redBrush, ptt);

            Rectangle rectf = new Rectangle(100, 150, 200, 100);
            g.FillEllipse(blueBrush, rectf);


        }
    }
}
