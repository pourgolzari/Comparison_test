using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, num1,num2;
            num = int.Parse(textBox1.Text);
            if(textBox1.Text.Length<2 || textBox1.Text.Length > 2)
            {

                MessageBox.Show("لطفا یک عدد دو رقمی وارد کنید");
            }
            else
            {
                num1 = num / 10;
                num2 = num % 10;
                if (num1 == num2)
                {
                    MessageBox.Show("دو عدد با هم برابر است");
                }
                else if(num1>num2)
                {
                    MessageBox.Show("عدد اول بزرگتر از عدد دوم است");
                }else if (num1 < num2)
                {
                    MessageBox.Show("عدددوم بزرگتر از عدد اول است");
                }

            }
        }
    }
}
