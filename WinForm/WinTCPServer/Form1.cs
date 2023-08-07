﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //인터넷 주소 만들기
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            //포트만들기
            int port = 13000;
            //서버 객체 만들기
            TcpListener server = new TcpListener(localAddr, port);

            //시작
            server.Start();
            //Console.WriteLine("연결 대기중...");
            richTextBox1.AppendText("연결 대기중...\n");

            while (true)
            {
                //클라이언트 연결, 수락
                TcpClient client = await server.AcceptTcpClientAsync();
                Task task = Task.Run(() => HandleClient(client));
            }
        }
        private async void HandleClient(TcpClient client)
        {
            //Console.WriteLine("연결 성공!");
            //richTextBox1.AppendText("연결 성공!");
            AppendText("연결성공\n");

            using (NetworkStream stream = client.GetStream())
            {
                byte[] data = new byte[1024];
                int bytes;

                while((bytes = await stream.ReadAsync(data, 0, data.Length)) != 0)
                {
                    AppendText(Encoding.UTF8.GetString(data, 0, bytes)+"\n");
                }
            }
            client.Close();
        }
        private void AppendText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                richTextBox1.AppendText(text);
            }
        }
    }
}
