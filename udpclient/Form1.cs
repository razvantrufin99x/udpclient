using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace udpclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(tbHost.Text, 8080);
            Byte[] sendBytes = Encoding.ASCII.GetBytes("Hello World?");
            udpClient.Send(sendBytes, sendBytes.Length);

        }
    }
}
