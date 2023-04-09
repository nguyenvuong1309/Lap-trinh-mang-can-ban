using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TinhToan_1 bai1 = new TinhToan_1();
            bai1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Max_Min_2 bai2 = new Max_Min_2();
            bai2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readNumber_3 bai3 = new readNumber_3();
            bai3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            convert_4 bai4 = new convert_4();
            bai4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Management bai5 = new Management();
            bai5.ShowDialog();
        }
    }
}
