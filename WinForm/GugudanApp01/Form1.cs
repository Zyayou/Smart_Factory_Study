using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GugudanApp01
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            for(int i = 1 ; i < 10; i += 4)
            {
                for(int j = 1 ; j < 10; j++)
                {
                    for(int  k = i ; k < i+4; k++)
                    {
                        textBox2.Text += $"{k} * {j} = {k * j}";
                        textBox2.Text += $"      ";
                    }
                    textBox2.Text += "\r\n";
                }
                textBox2.Text += "\r\n";
            }
        }
    }
}
