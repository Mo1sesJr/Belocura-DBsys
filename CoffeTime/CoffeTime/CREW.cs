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
    public partial class CREW : Form
    {
        public CREW()
        {
            InitializeComponent();
        }

        private void CREW_Load(object sender, EventArgs e)
        {
            string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(conn);
            con.Open(); 
            string query = "Select * From CoffeeBuyers  ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dgvCoffee.DataSource = table;
           
            string conn1 = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";
            SqlConnection con1 = new SqlConnection(conn1);
            con1.Open();
            string query1 = "Select * From Account1";
            SqlCommand command1 = new SqlCommand(query1, con1);
            SqlDataReader reader1 = command1.ExecuteReader();
            DataTable table1 = new DataTable();
            table1.Load(reader1);

            dgvStocks.DataSource = table1;
            con.Close();
            con1.Close();

        }

        private void dgvStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer cs = new customer();
            cs.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
