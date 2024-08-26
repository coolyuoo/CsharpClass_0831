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

            string[] xx = new string[3];

            xx[0] = "123";
            xx[1] = "456";
            xx[2] = "789";


            x1 = xx[0];

            MessageBox.Show(x1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] xx = new string[3];

            xx[0] = "123";
            xx[1] = "456";
            xx[2] = "789";
            xx[3] = "999";


            string x1 = xx[0];

            MessageBox.Show(x1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> xx = new List<string>();

            xx[0] = "123";
            xx[1] = "456";
            xx[2] = "789";
            xx[3] = "999";


            string x1 = xx[0];

            MessageBox.Show(x1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> xx = new List<string>();

                xx[0] = "123";
                xx[1] = "456";
                xx[2] = "789";
                xx[3] = "999";


                string x1 = xx[0];

                MessageBox.Show(x1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
