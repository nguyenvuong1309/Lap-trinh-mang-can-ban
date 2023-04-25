using Lab4_Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab4_Client
{
    public partial class Bai4_Client : Form
    {
        private TcpClient client = new TcpClient();
        private bool isRunning = false;
        private bool isConnected = false;
        public Bai4_Client()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (isConnected == true)
            {
                receive_Click();
                if (nameTextBox.Text.Length > 0 && messageTextBox.Text.Length > 0)
                {
                    // Get message from user input
                    string message = $"{nameTextBox.Text}: {messageTextBox.Text}{Environment.NewLine}";
                    // Send message to the server
                    byte[] buffer = Encoding.ASCII.GetBytes(message);
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        stream.Write(buffer, 0, buffer.Length);
                    }
                    catch(ObjectDisposedException ex)
                    {
                        connect.Enabled = true;
                        MessageBox.Show("Disconnect with server");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter message");
                }
            }
        }

        private void receive_Click()
        {
            // Start the receive thread if it's not running
            if (!isRunning)
            {
                isRunning = true;
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessages));
                receiveThread.Start();
            }
        }

        private void ReceiveMessages()
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            StringBuilder messageBuilder = new StringBuilder();

            while (isRunning)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        // The server has disconnected
                        break;
                    }

                    // Translate the bytes into a string and append to the message builder
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    messageBuilder.Append(data);

                    // Check if the message builder contains a complete message
                    string message = messageBuilder.ToString();
                    int messageEndIndex = message.IndexOf(Environment.NewLine);
                    if (messageEndIndex >= 0)
                    {
                        // Extract the complete message and remove it from the message builder
                        message = message.Substring(0, messageEndIndex);
                        messageBuilder.Remove(0, messageEndIndex + Environment.NewLine.Length);

                        // Update the UI with the received message
                        BeginInvoke(new Action(() =>
                        {
                            textBox.AppendText(message + Environment.NewLine);
                        }));
                    }
                }
                catch
                {
                    break;
                }
            }

            // Close the connection when the receive thread exits
            client.Close();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to the server
                client.Connect("127.0.0.1", 8000);
                connect.Enabled = false;
                this.isConnected = true;
            }
            catch
            {
                MessageBox.Show("cannot connect to server");
            }
        }
    }
}

