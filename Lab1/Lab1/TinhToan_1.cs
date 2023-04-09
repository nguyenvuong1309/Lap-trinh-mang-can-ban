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
    public partial class TinhToan_1 : Form
    {
        private int so1 = 0;
        private int so2 = 0;
        private double ketQua = 0;
        private bool isActive1 = false;
        private bool isActive2 = false;
        public TinhToan_1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isActive1 = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            isActive2 = true;
        }
        private void clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.label5.Text = "";
        }
        private void button1_Click(object sender, EventArgs e) // phép cộng
        {
            if(isActive1 == true && isActive2 == true && textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                try
                {
                    so1 = Int32.Parse(textBox1.Text);
                    so2 = Int32.Parse(textBox2.Text);
                    ketQua = 0;
                    ketQua = so1 + so2;
                    label5.Text = ketQua.ToString();
                }
                catch
                {
                    clear();
                    MessageBox.Show("Invalid");
                }
            }
            else
            {
                MessageBox.Show("Please enter both number");
            }
        }

        private void button2_Click(object sender, EventArgs e) // phép trừ
        {
            if (isActive1 == true && isActive2 == true && textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                try
                {
                    so1 = Int32.Parse(textBox1.Text);
                    so2 = Int32.Parse(textBox2.Text);
                    ketQua = 0;
                    ketQua = so1 - so2;
                    label5.Text = ketQua.ToString();
                }
                catch
                {
                    clear();
                    MessageBox.Show("Invalid");
                }
            }
            else
            {
                MessageBox.Show("Please enter both number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isActive1 == true && isActive2 == true && textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                try
                {
                    so1 = Int32.Parse(textBox1.Text);
                    so2 = Int32.Parse(textBox2.Text);
                    ketQua = 0;
                    ketQua = so1 * so2;
                    label5.Text = ketQua.ToString();
                }
                catch
                {
                    clear();
                    MessageBox.Show("Invalid");
                }
            }
            else
            {
                MessageBox.Show("Please enter both number");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isActive1 == true && isActive2 == true && textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                try
                {
                    so1 = Int32.Parse(textBox1.Text);
                    so2 = Int32.Parse(textBox2.Text);
                    ketQua = 0;
                    if (so2 == 0)
                    {
                        MessageBox.Show("Số chia không thể là số 0");
                        label5.Text = "";
                    }
                    else
                    {
                        ketQua = (double)Math.Round(so1 * 1.0 / so2, 2);
                        label5.Text = ketQua.ToString();
                    }
                }
                catch
                {
                    clear();
                    MessageBox.Show("Invalid");
                }
            }
            else
            {
                MessageBox.Show("Please enter both number");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }
    }
}
