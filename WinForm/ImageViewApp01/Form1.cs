using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Admin\Desktop\kakaoImage.png";
            //pictureBox1.Load(path);
            pictureBox1.Image = Image.FromFile(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files (x86)\Kakao\KakaoTalk\skin\default\image\2.0\chat_illust_bg_15.9.png";
            //pictureBox1.Load(path);
            pictureBox1.Image = Image.FromFile(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files (x86)\Kakao\KakaoTalk\skin\default\image\2.0\facetalk_filter_img_sample01.png";
            //pictureBox1.Load(path);
            pictureBox1.Image = Image.FromFile(path);
        }
    }
}
