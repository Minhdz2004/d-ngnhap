using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace dangnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text; 
            string password = textBox2.Text;

            if (IsValidPassword(password,name))
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }
        }
         private bool IsValidPassword(string password ,string name)
        {
            if (password=="1234"&& name=="admin")
                return true;
                return false;
        }
    }
}
