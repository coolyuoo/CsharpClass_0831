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

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> x = new List<string>();

            x.Add("123");
            x.Add("456");
            x.Add("789");
            x.Add("AAA");

            foreach (var item in x)
            {
                comboBox1.Items.Add(item);
            }

            comboBox1.SelectedIndex = 0;
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {

            List<string> x = new List<string>
            {
                "777",
                "999",
                "hi",
                "oooo"
            };


            comboBox2.DataSource = x;
        }
    }
}
