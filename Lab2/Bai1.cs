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
using static System.Net.Mime.MediaTypeNames;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            message.Multiline = true;
            message.ScrollBars = ScrollBars.Both;
        }

        private void read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text (*.txt)|*.txt";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                message.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        private void write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt";
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                DialogResult res = MessageBox.Show("Bạn có muốn chuyển sang chữ hoa hay không", "", MessageBoxButtons.YesNo);
                byte[] ct;
                if (res == DialogResult.No)
                {
                    ct = Encoding.UTF8.GetBytes(message.Text.Trim());
                }
                else
                {
                    ct = Encoding.UTF8.GetBytes(message.Text.ToUpper().Trim());
                }
                fs.Write(ct, 0, ct.Length);
                message.Text = "";
                fs.Close();
            }
        }
    }
}
