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

namespace Lab4_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            /*if (ipTextBox.Text.Length > 0 && portTextBox.Text.Length > 0)
            {
                UdpClient udpClient = new UdpClient();
                //Lấy địa chỉ IP từ textbox và chuyển thành kiểu IPAddress
                IPAddress ipadd = IPAddress.Parse(ipTextBox.Text);
                int port = Convert.ToInt32(portTextBox.Text);
                IPEndPoint ipend = new IPEndPoint(ipadd, port);
                //Chuyển chuỗi dữ liệu nhập sang kiểu byte
                Byte[] sendBytes = Encoding.UTF8.GetBytes(textBox.Text);
                //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
                udpClient.Send(sendBytes, sendBytes.Length, ipend);
                //Xóa dữ liệu vừa gửi ở ô nhập
                //richTextBox1.Text = "";
            }
            else
            {
                if (ipTextBox.Text.Length > 0 && portTextBox.Text.Length > 0)
                {
                    MessageBox.Show("Please enter ip and port");
                }
                else if (ipTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please enter ip");
                }
                else
                {
                    MessageBox.Show("Please enter port");
                }
            }*/
        }
        private void bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1_Client bai1 = new Bai1_Client();
            bai1.ShowDialog();
            this.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3_Client bai3 = new Bai3_Client();
            bai3.ShowDialog();
            this.Show();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4_Client bai4 = new Bai4_Client();
            Bai4_Client1 bai4_1 = new Bai4_Client1();
            //bai4_1.ShowDialog();
            bai4.ShowDialog();
            this.Show();
        }
    }
}
