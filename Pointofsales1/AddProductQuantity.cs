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

namespace Pointofsales1
{
    public partial class AddProductQuantity : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public AddProductQuantity()
        {
            InitializeComponent();
        }

        private void btnAddqty_Click(object sender, EventArgs e)
        {
            string Addquantity1 = txtAddqty.Text;
            int Addquantity = int.Parse(Addquantity1);
            string ProductName = txtAddqtysearch.Text;

            using (SqlCommand cmd = new SqlCommand("Update inventory set qty=qty+@Addquantity,amount=price*@Addquantity+amount where productname='" + ProductName + "'", conn))
            {
                cmd.Parameters.AddWithValue("@Addquantity", Addquantity);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
            }
            }

        private void btnSearchproductqty_Click(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            string ProductName = txtAddqtysearch.Text;

            if (conn.State == ConnectionState.Closed) conn.Open();
            string query = "Select * from inventory where productname='" + ProductName + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            AddqtyTextBox.Text = dt.Rows[0][0].ToString();
                            AddqtyProductNameTextBox.Text = dt.Rows[0][1].ToString();
                            AddqtyProductCodeTextBox.Text = dt.Rows[0][2].ToString();
                            AddqtyPriceTextBox.Text = dt.Rows[0][3].ToString();
                            AddqtyAmountTextBox.Text = dt.Rows[0][4].ToString();
                        }
                    }
                }
            }

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddqtyTextBox.Text = "";
            AddqtyProductNameTextBox.Text = "";
            AddqtyProductCodeTextBox.Text = "";
            AddqtyPriceTextBox.Text = "";
            AddqtyAmountTextBox.Text = "";
            txtAddqty.Text = "";
            txtAddqtysearch.Text = "";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
