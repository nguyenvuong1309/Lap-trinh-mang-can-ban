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
    public partial class Management : Form
    {
        private string[] array;
        private float[] number;
        private bool isInput = false;
        private float max = 0;
        private float min = 10;
        private float average = 0;
        private int numberNotPassed = 0;
        private int below65 = 0;
        private int below5 = 0;
        private int below35 = 0;
        private int below2 = 0;

        public Management()
        {
            InitializeComponent();
        }
        private void clear()
        {
            inputScore.Text = "";
            panel1.Invalidate();
            average_score.Text = "";
            rank.Text = "";
            max_score.Text = "";
            min_score.Text = "";
            passed.Text = "";
            notPassed.Text = "";
        }
        private string setRank()
        {
            if (average >= 8 && below65 == 0)
            {
                return "Giỏi";
            }else if(average >= 6.5 && below5 == 0)
            {
                return "Khá";
            }else if(average >= 5 && below35 == 0)
            {
                return "Trung bình";
            }else if(average >= 3.5 && below2 == 0)
            {
                return "Yếu";
            }
            return "yếu";
        }
        private bool valid(char s)
        {
            string f = "0123456789.,";
            foreach(char c in f) {
                if (c == s) return true;
            }
            return false; ;
        }
        private bool checkValidFormat()
        {
            for (int i = 0;i < inputScore.Text.Length;i++)
            {
                if (!valid(inputScore.Text[i]))
                {
                    clear();
                    MessageBox.Show("Invalid number");
                    return false;
                }
                if(i > 0)
                {
                    if ((inputScore.Text[i] == '.' && inputScore.Text[i-1] == '.') || (inputScore.Text[i] == ',' && inputScore.Text[i - 1] == ','))
                    {
                        clear();
                        MessageBox.Show("Invalid format");
                        return false;
                    }
                }
                else
                {
                    if( !(valid(inputScore.Text[i]) && (inputScore.Text[i] != '.' || inputScore.Text[i] != ',')))
                    {
                        MessageBox.Show("Invalid format");
                        clear();
                        return false;
                    }
                }
            }
            return true;
        }
        private bool ExtractNumber()
        {
            if (checkValidFormat())
            {
                float sum = 0;
                array = inputScore.Text.Split(',');
                number = new float[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    try
                    {
                        if (float.Parse(array[i]) < 0.0 | float.Parse(array[i]) > 10.0)
                        {
                            number[i] = 0;
                            MessageBox.Show("Number out of range");
                        }
                        else if (float.Parse(array[i]) >= 0.0 && float.Parse(array[i]) <= 10.0)
                        {
                            number[i] = float.Parse(array[i]);
                            sum += number[i];
                            max = Math.Max(number[i], max);
                            min = Math.Min(number[i], min);
                            if (number[i] < 6.5)
                            {
                                below65++;
                            }
                            if (number[i] < 5.0)
                            {
                                numberNotPassed++;
                                below5++;
                            }
                            if (number[i] < 3.5)
                            {
                                below35++;
                            }
                            if (number[i] < 2.0)
                            {
                                below2++;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid number");
                        clear();
                        return false;
                    }
                }
                average = sum / array.Length;
                setRank();
                return true;
            }
            return false;
        }
        private void Print_Click(object sender, EventArgs e)
        {
            if (ExtractNumber())
            {
                if (isInput)
                {
                    panel1.AutoScroll = false;
                    panel1.HorizontalScroll.Enabled = false;
                    panel1.HorizontalScroll.Visible = false;
                    panel1.HorizontalScroll.Maximum = 0;
                    panel1.AutoScroll = true;
                    Label[] labels = new Label[number.Length];
                    int i = 0;
                    int row = 0;
                    while (i < number.Length)
                    {
                        if (i % 4 == 0) { row++; }
                        labels[i] = new Label();
                        labels[i].AutoSize = false;
                        //labels[i].Font = Microsoft Sans Serif, 10.2pt, style = Bold;
                        labels[i].Text = "Môn  " + (i + 1).ToString() + ":" + number[i].ToString() + " đ";
                        labels[i].Location = new Point(10 + (i % 4) * 130, row * 25);
                        panel1.Controls.Add(labels[i]);
                        i++;
                    }
                }
                average_score.Text = average.ToString();
                rank.Text = setRank();
                max_score.Text = max.ToString();
                min_score.Text = min.ToString();
                passed.Text = (number.Length - numberNotPassed).ToString();
                notPassed.Text = numberNotPassed.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isInput = true;
        }
    }
    
}
