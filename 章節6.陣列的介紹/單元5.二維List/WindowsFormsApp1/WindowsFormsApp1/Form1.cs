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

        List<List<string>> memberList = new List<List<string>>();


        private void button1_Click(object sender, EventArgs e)
        {
            List<string> member = new List<string>();

            member.Add("編號:1");
            member.Add("小明");
            member.Add("19歲");
            member.Add("0931337938");
            member.Add("男");

            string result = string.Empty;

            foreach (string info in member)
            {
                result += info + "  ";
            }


            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //假設現在有三筆資料在資料庫 開EXCEL看 
            List<string> x = new List<string>();

            x.Add("編號:1");
            x.Add("小明");
            x.Add("19歲");
            x.Add("0931337939");
            x.Add("男");

            //簡化方式用不用沒差
            List<string> x2 = new List<string>
            {
                "編號:2",
                "小華",
                "32歲",
                "0955333222",
                "男"
            };

            List<string> x3 = new List<string>();

            x3.Add("編號:3");
            x3.Add("小應");
            x3.Add("25歲");
            x3.Add("0988333222");
            x3.Add("女");


            memberList.Add(x);
            memberList.Add(x2);
            memberList.Add(x3);


            //從資料庫(excel)讀出來的資料一定是放在陣列裡面

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (memberList.Count == 0)
            {
                MessageBox.Show("資料庫無資料");
                return;
            }

            string allResult = string.Empty;

            //類似長方形的*
            foreach (List<string> member in memberList)
            {
                string result = string.Empty;

                foreach (string info in member)
                {
                    result += info + "  ";
                }

                allResult += result + Environment.NewLine;
            }

            textBox1.Text = allResult;


        }

    
    }
}
