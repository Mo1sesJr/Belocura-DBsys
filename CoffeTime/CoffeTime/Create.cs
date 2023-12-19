using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeTime
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = tbuser.Text;
            string pass = tbpass.Text;

            string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";

            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "INSERT INTO Account1 (username,password1) VALUES ('" + user + "','" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
