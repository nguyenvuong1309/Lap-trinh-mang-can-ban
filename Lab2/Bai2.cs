using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            
            URL.ScrollBars = ScrollBars.Both;

            message.Multiline = true;
            message.ScrollBars = ScrollBars.Both;
        }
        public int TotalCharacterCount(string file)
        {
            int totalCharacters = 0;
            using (StreamReader reader = File.OpenText(file))
            {
                string str = reader.ReadLine();
                while (str != null)
                {
                    totalCharacters += str.Length;
                    str = reader.ReadLine();
                }
            }
            return totalCharacters;
        }
        private void readFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text (*.txt)|*.txt";
            ofd.ShowDialog();
            string content = File.ReadAllText(ofd.FileName);
            message.Text = content;
            URL.Text = ofd.FileName;
            nameFile.Text = ofd.SafeFileName;
            numberRow.Text = System.IO.File.ReadAllLines(ofd.FileName).Length.ToString();
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            numberWord.Text = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            numberChar.Text = TotalCharacterCount(ofd.FileName).ToString();
        }
    }
}
