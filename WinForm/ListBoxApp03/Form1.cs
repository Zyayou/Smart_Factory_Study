using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListBoxApp03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str;
            str = textBox1.Text + "님은";

            if(radioButton1.Checked == true)
            {
                str += radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                str += radioButton2.Text;
            }

            str += " 이고" + "\r\n" + "연령은 " + listBox1.Text + " 이고" + "\r\n" + "거주지는 " +
                comboBox1.Text + " 이고" + "\r\n" + "좋아하는 동물은 " + Environment.NewLine;

            if(checkBox1.Checked == true)
            {
                str += checkBox1.Text + "\r\n";
            }
            if (checkBox2.Checked == true)
            {
                str += checkBox2.Text + "\r\n";
            }
            if (checkBox3.Checked == true)
            {
                str += checkBox3.Text + "\r\n";
            }
            if (checkBox4.Checked == true)
            {
                str += checkBox4.Text + "\r\n";
            }
            if (checkBox5.Checked == true)
            {
                str += checkBox5.Text + "\r\n";
            }
            if (checkBox6.Checked == true)
            {
                str += checkBox6.Text + "\r\n";
            }
            if (checkBox7.Checked == true)
            {
                str += checkBox7.Text + "\r\n";
            }
            if (checkBox8.Checked == true)
            {
                str += checkBox8.Text + "\r\n";
            }
            if (checkBox9.Checked == true)
            {
                str += checkBox9.Text + "\r\n";
            }

            label4.Text = str + "입니다.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("10 대");
            listBox1.Items.Add("20 대");
            listBox1.Items.Add("30 대");
            listBox1.Items.Add("40 대");
            listBox1.Items.Add("50 대");
            listBox1.Items.Add("60 대");

            comboBox1.Items.Add("서울특별시");
            comboBox1.Items.Add("인천광역시");
            comboBox1.Items.Add("대전광역시");
            comboBox1.Items.Add("대구광역시");
            comboBox1.Items.Add("부산광역시");
            comboBox1.Items.Add("광주광역시");
            comboBox1.Items.Add("울산광역시");
            comboBox1.Items.Add("경기도");
            comboBox1.Items.Add("충청도");
            comboBox1.Items.Add("강원도");
            comboBox1.Items.Add("경상도");
            comboBox1.Items.Add("전라도");
            comboBox1.Items.Add("제주도");
            comboBox1.SelectedIndex = 0;
        }
    }
}
