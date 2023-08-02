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

namespace ProgressBar01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar2.Maximum = 1000;
            progressBar2.Minimum = 0;
            progressBar2.Value = 0;

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Invoke(new Action(() =>
                    {
                        progressBar1.Value = i;
                        progressBar2.Value = i;
                    }));

                    Thread.Sleep(1);
                }
            });
        }
    }
}
