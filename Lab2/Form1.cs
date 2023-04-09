using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
            this.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
            this.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
            this.Show();
        }

        private void bai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 b4 = new Bai4();
            b4.ShowDialog();
            this.Show();
        }

        private void bai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai5 b5 = new Bai5();
            b5.ShowDialog();
            this.Show();
        }
    }
}
