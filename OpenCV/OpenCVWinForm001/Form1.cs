using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCVWinForm001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "OpenCV 버전 : " + Cv2.GetVersionString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imgePath = "lenna.jpg";

            using (Mat colorImage = new Mat(imgePath, ImreadModes.Color))
            {
                Mat grayImage = new Mat(imgePath, ImreadModes.Grayscale);
                //흑백화면으로 변경
                Cv2.CvtColor(colorImage, grayImage, ColorConversionCodes.BGR2GRAY);

                Bitmap bitmap = MatToBitmap(grayImage);
                pictureBox1.Image = bitmap;
            }

        }

        private Bitmap MatToBitmap(Mat image)
        {
            using (var stream = new MemoryStream())
            {
                image.WriteToStream(stream);
                return new Bitmap(stream);
            }
        }


    }
}
