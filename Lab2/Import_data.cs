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
    public partial class Import_data : Form
    {
        public delegate void inputData(string name, string id, string phoneNumber, float mathSocre, float literature);
        public inputData input;
        private long phone;
        private float math = -1;
        private float litera = -1;
        public Bai4 b4;
        public Import_data()
        {
            InitializeComponent();
        }
        public Import_data(Bai4 b4)
        {
            InitializeComponent();
            this.b4 = b4;
        }
        public void clear()
        {
            phonenumber.Text = "";
            id.Text = "";
            phonenumber.Text = "";
            mathScore.Text = "";
            literatureScore.Text = "";
        }
        private async void Enter_Click(object sender, EventArgs e)
        {
            if (name.Text.Length > 0 && id.Text.Length > 0 && phonenumber.Text.Length > 0 && mathScore.Text.Length > 0 && literatureScore.Text.Length > 0) {
                if (!(long.TryParse(phonenumber.Text, out phone)) || phonenumber.Text.Length != 10)
                {
                    phonenumber.Text = "";
                    MessageBox.Show("Phone number invalid");
                }
                else if (!(float.TryParse(mathScore.Text, out math)) || !(float.Parse(mathScore.Text) >= 0 && float.Parse(mathScore.Text) <= 10))
                {
                    mathScore.Text = "";
                    MessageBox.Show("Math score invalid");
                }
                else if (!(float.TryParse(literatureScore.Text, out litera)) || !(float.Parse(literatureScore.Text) >= 0 && float.Parse(literatureScore.Text) <= 10))
                {
                    literatureScore.Text = "";
                    MessageBox.Show("literature score invalid");
                }
                else if ( float.Parse(mathScore.Text) >=0  && float.Parse(mathScore.Text) <= 10 && float.Parse(literatureScore.Text) >= 0 && float.Parse(literatureScore.Text) <= 10)
                {
                    b4.dataGrid.Rows.Add(name.Text, id.Text, phonenumber.Text, mathScore.Text, literatureScore.Text, ((math + litera) / 2).ToString());
                }
            }
            else if(name.Text.Length == 0)
            {
                MessageBox.Show("Please fill the name box");
            }
            else if (id.Text.Length == 0)
            {
                MessageBox.Show("Please fill the id box");
            }
            else if (phonenumber.Text.Length == 0)
            {
                MessageBox.Show("Please fill the phone number box");
            }
            else if (mathScore.Text.Length == 0)
            {
                MessageBox.Show("Please fill the math score box");
            }
            else if (literatureScore.Text.Length == 0)
            {
                MessageBox.Show("Please fill the literature score box");
            }
            clear();
        }
    }
}
