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
    public partial class readNumber_3 : Form
    {
        private int number = -1;
        private bool isActive = false;
        
        private string[] array = new string[10] { "không","một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        public readNumber_3()
        {
            InitializeComponent();
        }
        private void clear()
        {
            input.Text = "";
            output.Text = "";
        }
        private void read_Click(object sender, EventArgs e)
        {
            if (isActive == true && input.Text.Length > 0)
            {
                try
                {
                    number = int.Parse(input.Text);
                    if (number > -1 && number < 10)
                    {
                        output.Text = array[number].ToString();
                    }
                    else
                    {
                        clear();
                        MessageBox.Show("out of range");
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
                MessageBox.Show("Please enter number");
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            input.Text = "";
            output.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
