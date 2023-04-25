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

namespace Lab4_Client
{
    public partial class Bai3_Client : Form
    {
        private TcpClient client = null;
        private NetworkStream stream = null;
        private Int32 portNumber = 0;
        private IPAddress ipAddress;
        public Bai3_Client()
        {
            InitializeComponent();
        }
        /*private async void send_Click(object sender, EventArgs e)
        {
            try
            {
                if(client != null && client.Connected)
                {
                    stream = client.GetStream();

                    // Send a message to the server
                    if (sendTextBox.Text.Length > 0)
                    {
                        string message = sendTextBox.Text + Environment.NewLine;
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        stream.Write(data, 0, data.Length);
                        
                        // Receive the response from the server
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        receiveRextBox.Text += response + Environment.NewLine;
                        

                        // Clean up
                        *//*if (client.Connected)
                        {
                            stream.Dispose();
                            client.Close();
                        }*//*
                    }
                    else
                    {
                        MessageBox.Show("Please enter message");
                    }
                }
                else
                {
                    MessageBox.Show("you have not initiated the connection");
                }
            }
            catch(IOException ex) {
                MessageBox.Show("Connection closed abruptly: " + ex.Message);
            }
        }*/

        private async void send_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    stream = client.GetStream();

                    // Send a message to the server
                    if (sendTextBox.Text.Length > 0)
                    {
                        string message = sendTextBox.Text + Environment.NewLine;
                        byte[] data = Encoding.ASCII.GetBytes(message);
                        await stream.WriteAsync(data, 0, data.Length);

                        // Receive the response from the server
                        byte[] buffer = new byte[1024];
                        int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                        string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        receiveRextBox.Text += response + Environment.NewLine;
                    }
                    else
                    {
                        MessageBox.Show("Please enter message");
                    }
                }
                else
                {
                    MessageBox.Show("you have not initiated the connection");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Connection closed abruptly: " + ex.Message);
            }
        }


        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (ipTextBox.Text.Length > 0 && portTextBox.Text.Length > 0 && Int32.TryParse(portTextBox.Text,out portNumber) && (IPAddress.TryParse(ipTextBox.Text,out ipAddress))) {
                    client = new TcpClient();
                    client.Connect(ipAddress, portNumber);
                    MessageBox.Show("success connect to server");
                }
                else
                {
                    MessageBox.Show("Please enter ip and port or ip and port not valid");
                }
            }
            catch
            {
                MessageBox.Show("Cannot connect to server");
            }
        }
    }
}
