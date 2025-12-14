using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeNumMaximum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, i;

            num1 = int.Parse(textNum1.Text);
            num2 = int.Parse(textNum2.Text);
            num3 = int.Parse(textNum3.Text);

            int max;
            max = num1;
            i = 1;
            if (num2 > max)
            {
                max = num2;
                i = 2;
            }
            if (num3 > max)
            {
                max = num3;
                i = 3;
            }
            MessageBox.Show(string.Format("ค่ามากที่สุดคือตัวเลขที่ {0} ซึ่งมีค่าเท่ากับ {1}",i, max),"ผลการเปรียบเทียบ");
        }
    }
}
