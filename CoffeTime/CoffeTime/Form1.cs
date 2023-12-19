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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbuser.Text == "Admin" && tbpass.Text == "Admin")
            {
                string user = tbuser.Text;
                string pass = tbpass.Text;
                string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Select * From Admin Where username = @firstname and password1 = @pass", con);
                cmd.Parameters.AddWithValue("@firstname", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logging in " + tbuser.Text);


                        ADMIN Admin = new ADMIN();
                    Admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Account!");



                }
                con.Open();
            }
            else if (tbuser.Text == "Crew" && tbpass.Text == "Crew")
            {
                string user = tbuser.Text;
                string pass = tbpass.Text;
                string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Select * From Crew Where username = @firstname and password1 = @pass", con);
                cmd.Parameters.AddWithValue("@firstname", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logging in " + tbuser.Text);


                    CREW crew = new CREW();
                    crew.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Account!");



                }
                con.Open();

            }
            else
            {
                string user = tbuser.Text;
                string pass = tbpass.Text;
                string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True";
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("Select * From Account1 Where username = @firstname and password1 = @pass", con);
                cmd.Parameters.AddWithValue("@firstname", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Logging in " + tbuser.Text);


                    customer customer= new customer();
                    customer.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Account!");



                }
                con.Open();



            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create c = new Create();
            c.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }


