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

namespace DigitalWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DateTime Time = new DateTime(2008, 3, 1, 7, 0, 0);
        private string DateFormet = "mm : ss";
        private bool Timeflow = false;

        private void Timmer()
        {
            label1.Text = Time.ToString(DateFormet);
            Time = Time.AddSeconds(1);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (Timeflow)
            {
                Timeflow = false;
            }
            else
            {
                Timeflow = true;
            }
            for (; ; )
            {
                button1.Text = "Pause";
                if (Timeflow == false)
                {
                    button1.Text = "Start";
                    break;
                }
                await Task.Run(() =>
                {
                    Timmer();
                    Thread.Sleep(1000);
                });
                
            }
        }
    }
}
