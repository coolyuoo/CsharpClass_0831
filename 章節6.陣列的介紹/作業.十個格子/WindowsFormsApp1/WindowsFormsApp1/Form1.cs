using System;
using System.Collections;
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

            if (!int.TryParse(textBox1.Text, out int t1))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int t2))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int t3))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox4.Text, out int t4))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int t5))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox6.Text, out int t6))
            {
                MessageBox.Show("要數字");
                return;
            }


            List<int> list = new List<int>()
            {
                t1,t2,t3,t4,t5,t6
            };

            //會噴錯 因為陣列執行中
            //foreach (int i in list)
            //{
            //    if (i == 0)
            //    {
            //        list.Remove(i);
            //    }
            //}




            for (int i = 0; i < list.Count;)
            {
                int t = list[i];

                if (t == 0)
                {
                    list.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            list = list.OrderBy(y => y).ToList();


            int zeroCount = 6 - list.Count;


            for (int i = 0; i < zeroCount; i++)
            {
                list.Add(0);
            }

            var r = string.Join(",", list);

            MessageBox.Show(r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int t1))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int t2))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int t3))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox4.Text, out int t4))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int t5))
            {
                MessageBox.Show("要數字");
                return;
            }

            if (!int.TryParse(textBox6.Text, out int t6))
            {
                MessageBox.Show("要數字");
                return;
            }


            List<int> list = new List<int>()
            {
                t1,t2,t3,t4,t5,t6
            };


            list.RemoveAll(x => x == 0);


            list = list.OrderBy(y => y).ToList();

            int zeroCount = 6 - list.Count;


            for (int i = 0; i < zeroCount; i++)
            {
                list.Add(0);
            }

            var r = string.Join(",", list);

            MessageBox.Show(r);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox1.Text, out int t1))
            {
                MessageBox.Show("要數字");
                return;
            }
            else
            {
                if (t1 == 0)
                {
                    t1 = 999;
                }
            }

            if (!int.TryParse(textBox2.Text, out int t2))
            {
                MessageBox.Show("要數字");
                return;
            }
            else
            {
                if (t2 == 0)
                {
                    t2 = 999;
                }
            }

            if (!int.TryParse(textBox3.Text, out int t3))
            {
                MessageBox.Show("要數字");
                return;
            }
            else
            {
                if (t3 == 0)
                {
                    t3 = 999;
                }
            }

            if (!int.TryParse(textBox4.Text, out int t4))
            {
                MessageBox.Show("要數字");
                return;
            }
            else
            {
                if (t4 == 0)
                {
                    t4 = 999;
                }
            }

            if (!int.TryParse(textBox5.Text, out int t5))
            {
                MessageBox.Show("要數字");
                return;
            }
            else
            {
                if (t5 == 0)
                {
                    t5 = 999;
                }
            }

            if (!int.TryParse(textBox6.Text, out int t6))
            {
                MessageBox.Show("要數字");
                return;
            }
            else
            {
                if (t6 == 0)
                {
                    t6 = 999;
                }
            }



            List<int> list = new List<int>()
            {
                t1,t2,t3,t4,t5,t6
            };


            list = list.OrderBy(y => y).ToList();

            var r = string.Join(",", list);

            var r2 = r.Replace("999", "0");


            MessageBox.Show(r2);
        }
    }
}
