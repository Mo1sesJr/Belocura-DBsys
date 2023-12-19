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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        private void item_SelectedIndexChanged(object sender, EventArgs e)
        {
            





                if (Coffee.Text == "Black")
            {
                int price1 = 100;
            price.Text = price1.ToString();  
            }
            if (Coffee.Text == "Latte")
            {
                int price2 = 250;
                price.Text = price2.ToString();
            }
            if (Coffee.Text == "Black")
            {
                int price3 = 199;
                price.Text = price3.ToString();
            }
            if (Coffee.Text == "Cappuccino")
            {
                int price4 = 230;
                price.Text = price4.ToString();
            }
            if (Coffee.Text == "Americano")
            {
                int price5 = 390;
                price.Text = price5.ToString();
            }
            if (Coffee.Text == "Espresso")
            {
                int price6 = 150;
                price.Text = price6.ToString();
            }
            if (Coffee.Text == "Doppio")
            {
                int price7 = 299;
                price.Text = price7.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            int num1 = Convert.ToInt32(price.Text);
            string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(conn);
            con.Open();

            string query = "INSERT INTO CoffeeStocks (itemNumber,Coffeeitem,coffeeStock ,coffeePrice) VALUES ('" + tbNumber.Text + "','" + Coffee.Text + "','" + tbstock.Text + "','" + price.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted");
            ADMIN_Load(sender, e);
        }

        private void ADMIN_Load(object sender, EventArgs e)
        {

            string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "Select * From CoffeeStocks";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            dgvStocks.DataSource = table;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(price.Text);

            int num3 = Convert.ToInt32(tbstock.Text);
            int num4 = Convert.ToInt32(tbNumber.Text);

            SqlConnection con = new SqlConnection("Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False");
            con.Open();
            string query = "UPDATE CoffeeStocks SET Coffeeitem  = '" + Coffee.Text +
                              "',  coffeeStock    ='" + num3 +

                                 "', coffeePrice      ='" +
                     num1 +




                      "'WHERE ItemNumber = '" + num4 + "'";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated!");

            ADMIN_Load(sender, e);
        }

        private void dgvStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNumber.Text = dgvStocks[0, e.RowIndex].Value.ToString();
            Coffee.Text = dgvStocks[1, e.RowIndex].Value.ToString();
            tbstock.Text = dgvStocks[2, e.RowIndex].Value.ToString();
            price.Text = dgvStocks[3, e.RowIndex].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record? ",
            "Delete Column", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int num = Convert.ToInt32(tbNumber.Text);

                string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";
                SqlConnection con = new SqlConnection(conn);
                con.Open();


                string query = "Delete from CoffeeStocks where ItemNumber = " + num + " ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted!");

                ADMIN_Load(sender, e);
            }
        }
       

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer cs = new customer();
            cs.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void price_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void dgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
