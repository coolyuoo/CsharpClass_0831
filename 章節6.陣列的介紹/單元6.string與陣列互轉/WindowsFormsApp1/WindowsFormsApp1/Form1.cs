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

            textBox1.Text = "123,456,aaa,bbb,yyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;

            List<string> s = x.Split(',').ToList();


            foreach (string item in s)
            {
                MessageBox.Show(item);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> sList = new List<string>
            {
                "aaa",
                "bbb",
                "cccc",
                "985"
            };


            string x = string.Join("|", sList);

            MessageBox.Show(x);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;

            List<string> s = x.Split('|').ToList();


            foreach (string item in s)
            {
                MessageBox.Show(item);
            }
        }
    }
}
