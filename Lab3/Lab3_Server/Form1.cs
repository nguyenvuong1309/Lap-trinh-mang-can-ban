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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1_server bai1 = new Bai1_server();
            bai1.ShowDialog();
            this.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2_server bai2 = new Bai2_server();
            bai2.ShowDialog();
            this.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3_servercs bai3 = new Bai3_servercs();
            bai3.ShowDialog();
            this.Show();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4_server bai4 = new Bai4_server();
            bai4.ShowDialog();
            this.Show();
        }
    }
}
