using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            int mid, final, total;
            string grade;

            mid = int.Parse(textMid.Text);
            final = int.Parse(textFinal.Text);

            total = mid + final;

            if (total >= 80 && total <= 100)
                grade = "A มึงโครตจะเก่งไอ้เหี้ยนี่!!!";
            else if (total >= 70 && total <= 79)
                grade = "B มึงเก่ง";
            else if (total >= 60 && total <= 69)
                grade = "C ก็ใช้ได้";
            else if (total >= 50 && total <= 59)
                grade = "D มึงค่อยข้างกาก";
            else if (total >= 0 && total <= 49)
                grade = "F มึงกาก";
            else
                grade = "N กรอกเลขให้ถูกไอสัส";

            MessageBox.Show("คะแนนที่ได้ " + total +" คุณได้เกรด " + grade,"ผลการคำนวณ");
        }
    }
}
