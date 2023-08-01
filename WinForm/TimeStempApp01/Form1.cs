using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeStempApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Number = 0;
        private DateTime NowTime;
        public void GetNumber()
        {
            Number = Number + 1;
        }
        public void OutNumber()
        {
            textBox1.AppendText(Number.ToString() + "\r\n");
        }
        public void GetTime()
        {
            NowTime = DateTime.Now;
        }
        public void OutTime()
        {
            textBox2.AppendText(NowTime.ToString() + "\r\n");
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    GetNumber();
                    this.Invoke(new Action(() =>
                    {
                        OutNumber();
                    }));
                    GetTime();
                    this.Invoke(new Action(() =>
                    {
                        OutTime();
                    }));
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
