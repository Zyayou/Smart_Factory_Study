using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumApp01
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
            int isum=0;
            string sum = "";
            for(int i = 1; i <= input; i++)
            {
                if(i == input)
                {
                    isum += i;
                    sum += i.ToString();
                }
                else
                {
                    isum += i;
                    sum += i.ToString() + " + ";
                }
            }
            textBox2.Text = sum + " = " + isum;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
