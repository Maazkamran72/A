using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signupform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            int Phone = int.Parse(textBox3.Text);
            int Age = int.Parse(textBox4.Text);

            string cusername = "maazkamran";
            string cpassword = "123456";
            int cPhone_ = Phone;
            int cAge = Age;

            if (username==cusername && password == cpassword)
            {
                MessageBox.Show("SignUp Successfully", "success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Invalid Username & password", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
