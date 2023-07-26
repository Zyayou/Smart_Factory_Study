using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            str = "당신의 연령은 " + "\n";
            if (radioButton1.Checked == true) str = str + radioButton1.Text;
            if (radioButton2.Checked == true) str += radioButton2.Text;
            if (radioButton3.Checked == true) str += radioButton3.Text;
            if (radioButton4.Checked == true) str += radioButton4.Text;
            if (radioButton5.Checked == true) str += radioButton5.Text;
            if (radioButton6.Checked == true) str += radioButton6.Text;

            str += "\n"+"\n"+"좋아하는 색은" +"\n";
            if (checkBox1.Checked == true) str += checkBox1.Text +" \n";
            if (checkBox2.Checked == true) str += checkBox2.Text + "\n";
            if (checkBox3.Checked == true) str += checkBox3.Text + "\n";
            if (checkBox4.Checked == true) str += checkBox4.Text + "\n";
            if (checkBox5.Checked == true) str += checkBox5.Text + "\n";
            if (checkBox6.Checked == true) str += checkBox6.Text + Environment.NewLine;

            str += "입니다.";
            label1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
