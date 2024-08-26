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
            x.Add("1456");
            x.Add("789");

            string x1 = x[0];

            MessageBox.Show(x1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");

            string x1 = x[2];

            MessageBox.Show(x1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");

            string x1 = x[3];

            MessageBox.Show(x1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");

            x.Remove("123");


            string x1 = x[0];


            MessageBox.Show(x1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");

            x.RemoveAt(1);


            string x1 = x[1];


            MessageBox.Show(x1);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");




            if (x.Contains("123"))
            {
                MessageBox.Show(true.ToString());
            }
            else
            {
                MessageBox.Show(false.ToString());
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");

            int c = x.Count;

            MessageBox.Show(c.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");

            int c = x.Count;

            if (c > 0)
            {
                MessageBox.Show("陣列裡面有資料");
            }
            else
            {
                MessageBox.Show("陣列裡面沒資料");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> x = new List<string>();
            x.Add("123");
            x.Add("1456");
            x.Add("789");

            int c = x.Count;

            MessageBox.Show(c.ToString());

            x.Clear();

            c = x.Count;

            MessageBox.Show(c.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(123);
            list.Add(1456);
            list.Add(789);

            //學校教法 氣泡排序法
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        // Swap list[j] and list[j + 1]
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            int t = list[n - 1];

            MessageBox.Show(t.ToString());

        }


        private void button13_Click(object sender, EventArgs e)
        {
            List<int> x = new List<int>();
            x.Add(123);
            x.Add(1456);
            x.Add(789);

            int y = x.Max();

            MessageBox.Show(y.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<int> x = new List<int>();
            x.Add(123);
            x.Add(1456);
            x.Add(789);

            int y = x.Min();

            MessageBox.Show(y.ToString());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            List<int> x = new List<int>();
            x.Add(123);
            x.Add(1456);
            x.Add(789);

            int z = 0;

            foreach (var item in x)
            {
                z += item;
            }

            MessageBox.Show(z.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            List<int> x = new List<int>();
            x.Add(123);
            x.Add(1456);
            x.Add(789);

            int y = x.Sum();

            MessageBox.Show(y.ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            List<int> x = new List<int>();
            x.Add(123);
            x.Add(1456);
            x.Add(789);
            x.Add(9);

            x.Sort();


            foreach (var item in x)
            {
                MessageBox.Show(item.ToString());
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<int> x = new List<int>();
            x.Add(123);
            x.Add(1456);
            x.Add(789);
            x.Add(9);

            x.Sort((a, b) => b.CompareTo(a));


            foreach (var item in x)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            List<DateTime> x = new List<DateTime>();
            x.Add(new DateTime(2024, 1, 1));
            x.Add(new DateTime(2022, 1, 1));
            x.Add(new DateTime(2023, 1, 1));
            x.Add(new DateTime(2025, 1, 1));

            DateTime y = x.Max();


            MessageBox.Show(y.ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            List<DateTime> x = new List<DateTime>();
            x.Add(new DateTime(2024, 1, 1));
            x.Add(new DateTime(2022, 1, 1));
            x.Add(new DateTime(2023, 1, 1));
            x.Add(new DateTime(2025, 1, 1));


            var c = x.OrderByDescending(o => o).ToList();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<DateTime> x = new List<DateTime>();
            x.Add(new DateTime(2024, 1, 1));
            x.Add(new DateTime(2022, 1, 1));
            x.Add(new DateTime(2023, 1, 1));
            x.Add(new DateTime(2025, 1, 1));


            var c = x.OrderBy(o => o).ToList();
        }
    }
}
