using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumApp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            int sumOdd = 0;
            int sumEven = 0;
            textBox2.Text = "";
            textBox3.Text = "";
            for(int i = 1; i <= input; i++)
            {
                if(i % 2 == 0)
                {
                    sumEven += i;
                    textBox3.Text += i.ToString() + " + ";
                }
                else
                {
                    sumOdd += i;
                    textBox2.Text += i.ToString() + " + ";
                }
            }
            textBox3.Text = textBox3.Text.TrimEnd('+', ' ') + " = " + sumEven.ToString();
            textBox2.Text = textBox2.Text.TrimEnd('+', ' ') +" = " + sumOdd.ToString();
        }
    }
}
