using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool flag1 = false;
        private bool flag2 = false;
        private int elapsed = 0; // 버튼이 클릭된 후 경과한 시간

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush redBrush = new SolidBrush(Color.Red);

            
            Point[] ptt = new Point[3];
            ptt[0].X = 250; ptt[0].Y = 100;
            ptt[1].X = 100; ptt[1].Y = 250;
            ptt[2].X = 400; ptt[2].Y = 250;

            Rectangle rectf = new Rectangle(50, 50, 200, 200);


            if (flag1 == true)
            {
                g.FillPolygon(redBrush, ptt);
            }
            else if(flag2 == true)
            {
                g.FillEllipse(redBrush, rectf);
                timer1.Stop();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            elapsed = 0;
            flag1 = true;
            timer1.Start();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed += timer1.Interval; // 경과 시간 증가
            // 프로그래스 바 업데이트
            progressBar1.Value = Math.Min(elapsed, progressBar1.Maximum);

            if (elapsed >= progressBar1.Maximum)
            {
                flag1 = false;
                flag2 = true; 
                panel1.Invalidate(); // 패널을 다시 그림
                timer1.Stop(); // 타이머를 멈춤
            }

        }
    }
}
