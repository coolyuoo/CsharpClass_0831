using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            x.Add("123");
            x.Add("456");
            x.Add("789");
            x.Add("AAA");

            string r = string.Empty;

            foreach (var item in x)
            {
                r += item + "\r\n";
            }

            textBox1.Text = r;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>
            {
                "123",
                "456",
                "789",
                "AAA"
            };

            textBox1.Lines = x.ToArray();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            List<string> slist = textBox1.Lines.ToList();

            string s = textBox1.Text;

            //會失敗
            //s.Split("\r\n");

            string y = s.Replace("\r\n", ",");

            List<string> s2 = y.Split(',').ToList();



            if (slist.SequenceEqual(s2))
            {
                MessageBox.Show("一樣");
            }
            else
            {
                MessageBox.Show("no");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string g = textBox2.Text;

            List<char> S = g.ToCharArray().ToList();

            foreach (char c in S)
            {
                MessageBox.Show(c.ToString());
            }
        }
    }
}
