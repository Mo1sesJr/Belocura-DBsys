using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeTime
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }
        private int lineSpacing = 40;
        private int ASpacing = 50;
        private int BSpacing = 50;
        private int CSpacing = 50;

        private int A = 250;
        private int B = 250;
        private int C = 250;
        private int margin = 90;
        private void rbgcash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgcash.Checked)
            {
                tbp.Text = "Gcash";
                panel4.Visible = true;

            }
        }

        private void rbcash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbcash.Checked)
            {
                tbp.Text = "Cash";
                panel4.Visible = false;

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = Convert.ToInt32(tbquantity.Text);
            int num9 = Convert.ToInt32(tbstock.Text);
            if (CoffeeLevel.Text != "" || tbp.Text != "" || tbquantity.Text != "" || Mobile.Text != "")
            {
                if (num9 > num1)
                {

                    var res = MessageBox.Show("Are you sure you want to Buy this Item?\n" +
                " You cannoot Undo This Purchase",
                "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        int num2 = Convert.ToInt32(tbquantity.Text);
                        int num3 = Convert.ToInt32(tbstock.Text);

                        int num4 = Convert.ToInt32(tbNumber.Text);

                        tbstock.Text = (num3 - num2).ToString();

                        string conn = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";
                        SqlConnection con = new SqlConnection(conn);
                        con.Open();
                        int num11 = Convert.ToInt32(tbprice.Text);

                        string query = "INSERT INTO CoffeeBuyers (ItemNumber,Coffeeitem,Sugar,coffeeStock,coffeePrice,CoffeeQuantiy,ModeOfPayment,Mobile) VALUES ('" + tbNumber.Text + "','" + CoffeeLevel.Text + "','" + CoffeeLevel.Text + "','" + tbstock.Text + "','" + tbprice.Text + "','" + tbquantity.Text + "','" + tbp.Text + "','" + Mobile.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Success!");
                        SqlCommand command = new SqlCommand(query, con);
                        command.ExecuteNonQuery();

                        string conn1 = "Data Source=MOISESJR\\SQLEXPRESS;Initial Catalog=Coffee;Integrated Security=True;Encrypt=False";
                        SqlConnection con1 = new SqlConnection(conn1);
                        con1.Open();
                        string query1 = "UPDATE CoffeeStocks SET Coffeeitem  = '" + Coffee.Text +
                                          "',  coffeeStock    ='" + tbstock.Text +

                                             "', coffeePrice      ='" +
                                tbprice.Text +

                                  "'WHERE ItemNumber = '" + num4 + "'";
                        customer_Load(sender, e);
                        SqlCommand command1 = new SqlCommand(query1, con1);
                        command1.ExecuteNonQuery();

                        //  con.Close();
                        con1.Close();


                        dgvItem.Rows.Add(tbNumber.Text, Coffee.Text, CoffeeLevel.Text, tbstock.Text, tbprice.Text, tbquantity.Text, tbp.Text, Mobile.Text);

                        customer_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Plasee input enough stock");


                }
            }
            else 
            {


                MessageBox.Show("Plasee Fill Up The Text!");

            }
        }

        private void customer_Load(object sender, EventArgs e)
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
       

        private void dgvStocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNumber.Text = dgvStocks[0, e.RowIndex].Value.ToString();
            Coffee.Text = dgvStocks[1, e.RowIndex].Value.ToString();

            tbstock.Text = dgvStocks[2, e.RowIndex].Value.ToString();
            tbprice.Text = dgvStocks[3, e.RowIndex].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var order = MessageBox.Show("Thank you ", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getsum();
            panel1.Visible = true;
            if (order == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("My Name", 800, 1000);
                printPreviewDialog1.ShowDialog();
                getsum();
                panel1.Visible = true;
              /*  Form1 f1 = new Form1();
                f1.Show();
                this.Hide();

                */

            }
           
        }
        private void getsum()
        {
            double sum = 0;

            for (int i = 0; i < dgvItem.RowCount - 1; i++)
            {
                sum += Convert.ToDouble(dgvItem.Rows[i].Cells[4].Value);
            }
            tbrslt.Text = sum.ToString("N2");

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                e.Graphics.DrawString("Coffee Time-Reciept", new Font("Arial", 24, FontStyle.Italic), Brushes.Black, new Point(250, 10));
                e.Graphics.DrawString("Lapu lapu City", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(270, 50));
                e.Graphics.DrawString("6014,Cebu City", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(300, 85));

                e.Graphics.DrawString("092732665109", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(285, 115));

                e.Graphics.DrawString("Coffee Name", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(100, 185));
                e.Graphics.DrawString("Price", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(350, 185));
                e.Graphics.DrawString("Sugar Level", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(450, 185));

                e.Graphics.DrawString("--------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(100, 200));


                e.Graphics.DrawString("-------------------------------------------------", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(100, 800));
                e.Graphics.DrawString("Happy Coffee Day!", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(200, 850));



                for (int i = 0; i <= dgvItem.RowCount - 1; i++)
                {

                    e.Graphics.DrawString(" " + Convert.ToString(dgvItem.Rows[i].Cells[1].Value), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, A));
                    e.Graphics.DrawString(" " + Convert.ToString(dgvItem.Rows[i].Cells[4].Value), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, B));
                    e.Graphics.DrawString(" " + Convert.ToString(dgvItem.Rows[i].Cells[2].Value), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, B));


                    A += ASpacing;
                    B += BSpacing;
                    C += CSpacing;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvItem.Columns[e.ColumnIndex].Name == "btncancel" && e.RowIndex >= 0) 
            {
                dgvItem.Rows.Remove(dgvItem.Rows[e.RowIndex]);
                getsum();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Coffee_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
