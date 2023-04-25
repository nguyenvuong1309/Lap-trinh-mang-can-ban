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
using Lab4_Server.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Dynamic;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Lab4_Server
{
    public partial class Bai4_server : Form
    {
        public Bai4_server()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            MainForm_Load();
            listen.Enabled = false;
        }
        private Thread serverThread;
        private TcpListener server;
        private List<TcpClient> clients = new List<TcpClient>();
        private void MainForm_Load()
        {
            serverThread = new Thread(new ThreadStart(StartServer));
            serverThread.Start();
        }
        private void StartServer()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, 8000);
                server.Start();
                MessageBox.Show("Server started.");
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    MessageBox.Show("Client connected.");
                    clients.Add(client);
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                    clientThread.Start(client);
                }
            }
            catch(SocketException ex)
            {
                MessageBox.Show("Server already started");
            }
        }
        private void HandleClient(object clientObj)
        {
            TcpClient client = (TcpClient)clientObj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesReceived;

            while (true)
            {
                try
                {
                    bytesReceived = stream.Read(buffer, 0, buffer.Length);
                    if (bytesReceived > 0)
                    {
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                        //MessageBox.Show("Server: Received message: " + message);
                        this.Invoke((MethodInvoker)delegate
                        {
                            textBox.Text += message;
                            textBox.Text += Environment.NewLine;
                        });
                        BroadcastMessage(message);
                    }
                }
                catch
                {
                    // Client disconnected
                    MessageBox.Show("Client disconnected.");
                    clients.Remove(client);
                    break;
                }
            }
        }


        private void BroadcastMessage(string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);

            foreach (TcpClient client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
