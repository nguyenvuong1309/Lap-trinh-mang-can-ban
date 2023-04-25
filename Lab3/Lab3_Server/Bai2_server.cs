using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace Lab4_Server
{
    public partial class Bai2_server : Form
    {
        public Bai2_server()
        {
            InitializeComponent();
        }
        private async void listen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server start");
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            server.Start();
            listen.Enabled = false;
            Console.WriteLine("Server started. Listening for incoming connections...");

            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                Console.WriteLine("Client connected.");

                NetworkStream stream = client.GetStream();

                while (client.Connected)
                {
                    byte[] buffer = new byte[client.ReceiveBufferSize];
                    int bytesRead = 0;
                    try
                    {
                        bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                        string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        this.Invoke(new Action(() => messageTextBox.Text += dataReceived));
                        //Console.WriteLine($"Data received: {dataReceived}");

                        // Handle the incoming data as desired.
                        byte[] dataToSend = Encoding.ASCII.GetBytes($"Received data: {dataReceived}");
                        await stream.WriteAsync(dataToSend, 0, dataToSend.Length);
                        Console.WriteLine($"Data sent: {Encoding.ASCII.GetString(dataToSend)}");
                    }
                    catch
                    {
                        listen.Enabled = true;
                        MessageBox.Show("telnet disconnect");
                        stream.Close();
                        client.Close();
                        server.Stop();
                        break;
                    }
                }

                stream.Close();
                client.Close();
                server.Stop();
                break;
            }
        }
    }
}
