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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace Lab4_Server
{
    public partial class Bai3_servercs : Form
    {
        private Int32 portNumber = 0;
        private IPAddress address;
        public Bai3_servercs()
        {
            InitializeComponent();
        }
        private async void listen_Click(object sender, EventArgs e)
        {
            if (portTextBox.Text.Length > 0 && ipTextBox.Text.Length > 0 && Int32.TryParse(portTextBox.Text, out portNumber) && IPAddress.TryParse(ipTextBox.Text, out address))
            {
                await Task.Run(() => StartServer(portNumber, address,this));
            }
        }
        public static async void StartServer(Int32 port, IPAddress addr,Bai3_servercs form)
        {
            TcpListener server = null;
            try
            {
                server = new TcpListener(addr, port);
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;


                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();

                    MessageBox.Show("Connected!");

                    NetworkStream stream = client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    try
                    {
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            data = Encoding.ASCII.GetString(bytes, 0, i);
                            form.Invoke((MethodInvoker)(() => form.textBox.Text += "Client: " + data));

                            data = data.ToUpper();


                            byte[] msg =  Encoding.ASCII.GetBytes("SERVER : " + data + Environment.NewLine);

                            // Send back a response.
                            stream.Write(msg, 0, msg.Length);
                           
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lost connection to client, abort");
                        server.Stop();
                        client.Close();
                        break;
                    }
                }
            }
            catch (SocketException e)
            {
                MessageBox.Show("SocketException: " + e);
            }
            finally
            {
                server.Stop();
            }
        }
    }
}
