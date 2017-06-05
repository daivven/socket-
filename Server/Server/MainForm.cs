using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server
{
    public partial class MainForm : Form
    {
        UdpClient myUdpClient = new UdpClient();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {  
            IPEndPoint local = new IPEndPoint(IPAddress.Parse(remoteIp.Text), int.Parse(remotePort.Text));
            myUdpClient.Send(Encoding.UTF8.GetBytes(textMsg.Text), textMsg.Text.Length, local);
        }
    }
}
