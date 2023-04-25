using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Server
{
    public partial class Bai1_server : Form
    {
        public Bai1_server()
        {
            InitializeComponent();
        }
        private Int32 portNumber = 0;
        private void listen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(portTextBox.Text, out portNumber))
                {
                    UdpClient server = new UdpClient(portNumber);
                    Thread thread = new Thread(new ThreadStart(() =>
                    {
                        while (true)
                        {
                            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                            byte[] data = server.Receive(ref remoteEP);
                            string Text = Encoding.ASCII.GetString(data) + Environment.NewLine;
                            this.Invoke(new Action(() => messageTextBox.Text += Text));
                        }
                    }));
                    thread.Start();
                    listen.Enabled = false;
                    MessageBox.Show("server running");
                }
                else
                {
                    MessageBox.Show("Please enter port number or port number not valid");
                }
            }
            catch(SocketException ex)
            {
                MessageBox.Show("Server alrady running");
            }
        }
    }
}
