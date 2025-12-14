using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            string[] username = { "Noph", "6740201287", "thodsaphon"};
            string[] password = { "56", "49","54" };

            string user = textUser.Text;
            string pass = textPass.Text;
            bool login = false;

            for (int i = 0; i < username.Length; i++)
            {
                if (user == username[i] && pass == password[i])
                {
                    login = true;
                    break;
                }
            }
            if (login)
            {
                MessageBox.Show("Login สำเร็จ", "ผลการทำงาน");
            }
            else
            {
                MessageBox.Show("Username หรือ Password ไม่ถูกต้อง", "ผลการทำงาน");
            }
        }
    }
}
