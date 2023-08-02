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

namespace DigitalWatchTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count;
        private bool Timeflow = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Timeflow)
            {
                Timeflow = false;
            }
            else
            {
                Timeflow = true;
            }


            var task = Task.Run(async () =>
            {
                while (true)
                {
                    button1.Text = "Pause";
                    if (Timeflow == false)
                    {
                        button1.Text = "ReStart";
                        break;
                    }
                    Invoke((Action)(() =>
                    {
                        label1.Text = count.ToString();
                        count++;

                    }));
                    await Task.Delay(1000);
                }

            });


        }
    }
}
