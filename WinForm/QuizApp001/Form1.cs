using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_filetext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            using (FileStream rs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(rs, Encoding.UTF8))
                {
                    string str = sr.ReadToEnd();
                    lab_filetext.Text = str;
                } 
            }
            
        }
    }
}
