using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sigup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M561BCP\\SQLEXPRESS;Initial Catalog=mydbb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionstring);

            conn.Open();
            string uname = textBox1.Text;
            int phone = int.Parse(textBox2.Text);
            string Querry = "Insert into customer (uname,phone) values ('"+uname+"', "+phone+")";
            SqlCommand cmd = new SqlCommand(Querry, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Your dat has been saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M561BCP\\SQLEXPRESS;Initial Catalog=mydbb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionstring);

            conn.Open();
            
            int id = int.Parse(textBox3.Text);
            string Querry = "DELETE FROM customer WHERE id="+id+"";
            SqlCommand cmd = new SqlCommand(Querry, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Your data has been delete");
        }
    }
}
