using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            for (int i = 0; i < 4; i++)
            {
                string s = x[i];

                MessageBox.Show(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            x.Add("123");
            x.Add("456");
            x.Add("789");
            x.Add("AAA");

            int c = x.Count;

            for (int i = 0; i < c; i++)
            {
                string s = x[i];

                MessageBox.Show(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();

            x.Add("123");
            x.Add("456");
            x.Add("789");
            x.Add("AAA");

            int c = x.Count;

            for (int i = 0; i < 5; i++)
            {
                string s = x[i];

                MessageBox.Show(s);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            List<int> x = new List<int>();

            MessageBox.Show(x.Count.ToString());

            for (int i = 0; i < 5; i++)
            {
                x.Add(i);
            }


            MessageBox.Show(x.Count.ToString());


        }
    }
}
