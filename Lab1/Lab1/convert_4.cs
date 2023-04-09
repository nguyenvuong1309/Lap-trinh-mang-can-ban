using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class convert_4 : Form
    {
        private string choose;
        private string number;
        private string convert;
        private int[] fromBase = new int[3] { 10, 16, 2 };
        private int[] toBase = new int[3] { 10, 16, 2 };
        public convert_4()
        {
            InitializeComponent();
        }
        private bool isbin(string s)
        {
            foreach (var c in s)
                if (c != '0' && c != '1')
                    return false;
            return true;
        }
        private void clear()
        {
            textBox1.Text = "";
            answer.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            choose = comboBox1.SelectedIndex.ToString();
            convert = comboBox2.SelectedIndex.ToString();
            number = textBox1.Text;
            if(choose == "0")
            {
                try
                {
                    if(convert == "0")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[0]), toBase[0]);
                        answer.Text = result;
                    }
                    else if(convert == "1")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[0]), toBase[1]);
                        answer.Text = result;
                    }
                    else if(convert == "2")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[0]), toBase[2]);
                        answer.Text = result;
                    }
                }
                catch
                {
                    clear();
                    MessageBox.Show("invalid number");
                }
            }else if(choose == "1")
            {
                try
                {
                    if (convert == "0")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[1]), toBase[0]);
                        answer.Text = result;
                    }
                    else if (convert == "1")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[1]), toBase[1]);
                        answer.Text = result;
                    }
                    else if (convert == "2")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[1]), toBase[2]);
                        answer.Text = result;
                    }
                }
                catch
                {
                    clear();
                    MessageBox.Show("Invalid number");
                }
            }
            else if (choose == "2")
            {
                try
                {
                    if (convert == "0")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[2]), toBase[0]);
                        answer.Text = result;
                    }
                    else if (convert == "1")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[2]), toBase[1]);
                        answer.Text = result;
                    }
                    else if (convert == "2")
                    {
                        string result = Convert.ToString(Convert.ToInt32(number, fromBase[2]), toBase[2]);
                        answer.Text = result;
                    }
                }
                catch
                {
                    clear();
                    MessageBox.Show("Invalid number");
                }
            }

        }
    }
}
