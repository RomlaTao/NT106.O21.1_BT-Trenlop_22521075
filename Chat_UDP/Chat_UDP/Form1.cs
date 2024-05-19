using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chat_UDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Send() 
        {
            try
            {
                if (tboxMessage == null) {
                    MessageBox.Show("Vui lòng nhập tin nhắn");
                }
                else
                {
                    UdpClient udpClient = new UdpClient();
                    Byte[] sendBytes = Encoding.ASCII.GetBytes($"{tboxName.Text} : {tboxMessage.Text}");
                    udpClient.Send(sendBytes, sendBytes.Length, tboxIPB.Text, int.Parse(tboxPortB.Text));
                    richTextBox1.Text += $"Me : {tboxMessage.Text}\n";
                    tboxMessage.Text = null;
                }
            }
            catch 
            {
                MessageBox.Show("Gửi tin nhắn không thành công");
            }
        }


        public void Receive() 
        {
            try
            {
                UdpClient udpClient = new UdpClient(int.Parse(tboxPortA.Text));
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    richTextBox1.Text += $"{returnData}\n";
                }
            }
            catch
            {
                MessageBox.Show("Không thể lắng nghe kết nối");
            }
        }

        private void btdListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(Receive));
            thdUDPServer.IsBackground = true;
            thdUDPServer.Start();
        }

        private void btdSend_Click(object sender, EventArgs e)
        {
            Send();
        }
    }
}
