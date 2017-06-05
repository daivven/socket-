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


namespace Client
{
    public partial class MainlForm : Form
    {
        public MainlForm()
        {
            InitializeComponent();
        }
        private void MainlForm_Load(object sender, EventArgs e)
        {
            Thread myThread = new Thread(ReceiveData);
            myThread.IsBackground = true;
            myThread.Start();
        }

        private UdpClient receiveUdpClient;

        private const int port = 8008;

        IPAddress ip=IPAddress.Parse("127.0.0.1");

        private void ReceiveData()
        {
            IPEndPoint local = new IPEndPoint(ip, port);
            receiveUdpClient = new UdpClient(local);
            IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    byte[] receiveBytes = receiveUdpClient.Receive(ref remote);
                    string receiveMessage = Encoding.UTF8.GetString(receiveBytes, 0, receiveBytes.Length);
                    AddItem(lst_Receive, receiveMessage);
                    switch (receiveMessage)
                    {
                        case "startvideo":
                            AddItem(lst_Receive, "1");
                            break;
                        case "stopvideo":
                            AddItem(lst_Receive, "2");
                            break;
                        case "capturepic":
                            AddItem(lst_Receive, "3");
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    break;
                }
            }
        }
        delegate void AddItemDelegate(ListBox listbox, string text);
        private void AddItem(ListBox listbox, string text)
        {
            if (listbox.InvokeRequired)
            {
                AddItemDelegate d = AddItem;
                listbox.Invoke(d, new object[] { listbox, text });
            }
            else
            {
                listbox.Items.Add(text);
                listbox.SelectedIndex = listbox.Items.Count - 1;
                listbox.ClearSelected();
            }
        }
    }
}
