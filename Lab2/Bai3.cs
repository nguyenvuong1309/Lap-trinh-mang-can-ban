using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();

            input.Multiline = true;
            input.ScrollBars = ScrollBars.Both;

            output.Multiline = true;
            output.ScrollBars = ScrollBars.Both;
        }
        private string filename = "";
        private Boolean canCalculate = false;
        private Boolean canSave = false;
        private int Calculate(string op,int x,int y)
        {
            switch (op){
                case "+": return x + y;
                case "-": return x - y;
                case "*": return x * y;
                case "/": return x / y;
                default: throw new Exception();
            }
            return 0;
        }
        private void read_Click(object sender, EventArgs e)
        {
            input.Text = "";
            output.Text = "";
            string content = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text (*.txt)|*.txt";
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                canCalculate = true;
                content = File.ReadAllText(ofd.FileName);
            }    
            filename = ofd.FileName;
            input.Text = content;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (!canCalculate)
            {
                MessageBox.Show("Please read file first");
            }
            else
            {
                string filePath = filename;
                //MessageBox.Show(filePath);
                string result = "";
                string line = "";
                int a = 0, b = 0;
                string[] array;
                string s = "";
                try
                {
                    StreamReader sr = new StreamReader(filePath);
                    line = sr.ReadLine();
                    while (line != null)
                    {

                        array = line.Split(' ');
                        if (Int32.TryParse(array[0], out a) && Int32.TryParse(array[2], out b))
                        {
                            line += " = " + Calculate(array[1], a, b);
                            line += Environment.NewLine;
                            result += line;
                        }
                        else
                        {

                            line += Environment.NewLine;
                            result += line;
                        }
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                catch
                {
                    Console.WriteLine("Exception: ");
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
                output.Text = result;
                canSave = true;
            }
        }

        private void write_Click(object sender, EventArgs e)
        {
            if (!canCalculate)
            {
                MessageBox.Show("Please read file first");
            }
            else if (!canSave)
            {
                MessageBox.Show("Please press calculate button");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "|*.txt";
                save.RestoreDirectory = true;
                if(save.ShowDialog() == DialogResult.OK) {
                    StreamWriter write = new StreamWriter(save.FileName);
                    write.WriteLine(output.Text);
                    write.Close();  
                }
            }
        }
    }
}
