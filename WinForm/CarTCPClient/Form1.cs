using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTCPClient
{
    public partial class Form1 : Form
    {
        private NetworkStream stream;
        private TcpClient cilent;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text +"+"+ textBox2.Text;
            byte[] data = Encoding.UTF8.GetBytes(text);
            stream.Write(data, 0, data.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string serverip = "127.0.0.1";
            int port = 13000;
            cilent = new TcpClient(serverip, port);
            stream = cilent.GetStream();
        }
    }
}
