using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);

            SolidBrush blueBrush = new SolidBrush(myRgbColor);

            Rectangle rectangle = new Rectangle(0, 0, 650, 200);
            g.FillRectangle(blueBrush, rectangle);
        }
    }
}
