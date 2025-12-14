using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoNumCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = int.Parse(textNum1.Text);
            num2 = int.Parse(textNum2.Text);
            if (num1 > num2)
            {
                MessageBox.Show("ตัวเลขที่ 1 คือ :" + num1 + "\nซึ่งมีค่ามากกว่า\n"+"ตัวเลขที่ 2 คือ :"+ num2 , "ผลการเปรียบเทียบ");
            }
            else if (num1 < num2)
            {
                MessageBox.Show("ตัวเลขที่ 1 คือ :" + num1 + "\nซึ่งมีค่าน้อยกว่า\n" + "ตัวเลขที่ 2 คือ :" + num2, "ผลการเปรียบเทียบ");
            }
            else
            {
                MessageBox.Show("ตัวเลขทั้งสองมีค่าเท่ากัน ซึ่งเท่ากับ : " + num1, "ผลการเปรียบเทียบ");
            }
        }
    }
}
