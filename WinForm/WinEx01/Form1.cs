using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEx01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int cnt;
        private Thread t;
        private void button1_Click(object sender, EventArgs e)
        {

            t = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        Invoke((Action)(() =>
                    label1.Text = cnt++.ToString()));
                        Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        break;
                    }
                }
            });
            t.IsBackground = true;
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Interrupt();
        }
    }
}
