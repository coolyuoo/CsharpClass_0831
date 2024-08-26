using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            x.Add("123");
            x.Add("456");
            x.Add("789");
            x.Add("AAA");

            MessageBox.Show(x[0]);
            MessageBox.Show(x[1]);
            MessageBox.Show(x[2]);
            MessageBox.Show(x[3]);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            x.Add("123");
            x.Add("456");
            x.Add("789");
            x.Add("AAA");

            foreach (var item in x)
            {
                MessageBox.Show(item);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            x.Add("123");
            x.Add("456");
            x.Add("789");
            x.Add("AAA");


            x.Reverse();

            foreach (var item in x)
            {
                MessageBox.Show(item);
            }
        }
    }
}
