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
    public partial class Max_Min_2 : Form
    {
        private double[] num = new double[] {0,0,0};
        private double numMax = Double.MinValue;
        private double numMin = Double.MinValue;
        private bool isActive1 = false;
        private bool isActive2 = false;
        private bool isActive3 = false;
        public Max_Min_2()
        {
            InitializeComponent();
        }
        private void clear()
        {
            so1.Text = "";
            so2.Text = "";
            so3.Text = "";
            max.Text = "";
            min.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isActive1 = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            isActive2 = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            isActive3 = true;
        }
        private void find_Click(object sender, EventArgs e)
        {
            if (isActive1 == true && isActive2 == true && isActive3 == true && so1.Text.Length > 0 && so2.Text.Length > 0 && so3.Text.Length > 0)
            {
                try
                {
                    num[0] = Int32.Parse(so1.Text);
                    num[1] = Int32.Parse(so2.Text);
                    num[2] = Int32.Parse(so3.Text);
                    numMax = num[0];
                    numMin = num[0];
                    for (int i = 0; i < 3; i++)
                    {
                        if (num[i] > numMax)
                        {
                            numMax = num[i];
                        }
                        if (num[i] < numMin)
                        {
                            numMin = num[i];
                        }
                    }
                    max.Text = numMax.ToString();
                    min.Text = numMin.ToString();
                }
                catch
                {
                    clear();
                    MessageBox.Show("Invalid");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ ba số");
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            so1.Text = "";
            so2.Text = "";
            so3.Text = "";
            max.Text = "";
            min.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
