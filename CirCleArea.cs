using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirCleArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const float PI = 3.14f;
        private void button1_Click(object sender, EventArgs e)
        {
            float Radius;
            float Area;
            float Perimeter; 
            Radius = float.Parse(txtRadius.Text);
            Area = PI * (Radius * Radius);
            Perimeter = 2 * PI * Radius; 
            MessageBox.Show("พื้นที่เท่ากับ : " + Area + "\nเส้นรอบรูปเท่ากับ : " + Perimeter, "ผลการคำนวณ"); 
        }
    }
}
