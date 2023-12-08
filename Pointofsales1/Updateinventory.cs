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
    public partial class Updateinventory : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true"); 
        public Updateinventory()
        {
            InitializeComponent();
        }

        private void btnUpdateinv_Click(object sender, EventArgs e)
        {
            string newqty = UpdateinvTextBox.Text;
            string newproductname = UpdateinvProductNameTextBox.Text;
            string newproductcode1 = UpdateinvProductCodeTextBox.Text;
            int newproductcode = int.Parse(newproductcode1);
            string newprice1 = UpdateinvPriceTextBox.Text;
            int newprice = int.Parse(newprice1);
            string newamount1 = UpdateinvAmountTextBox.Text;
            int newamount = int.Parse(newamount1);
            string Inventorysearch = txtUpdateinvsearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Update inventory set productname=@newproductname,price=@newprice,amount=qty*@newprice where productname='" + Inventorysearch + "'", conn))
            {
                cmd.Parameters.AddWithValue("@newproductname", newproductname);
                cmd.Parameters.AddWithValue("@newprice", newprice);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated successfully");
            }

        }

        private void btnSearchupdateinv_Click(object sender, EventArgs e)
        {
            string ProductName = txtUpdateinvsearch.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string query = "SELECT * FROM inventory WHERE productname='" + ProductName + "'";
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
                            UpdateinvTextBox.Text = dt.Rows[0][0].ToString();
                            UpdateinvProductNameTextBox.Text = dt.Rows[0][1].ToString();
                            UpdateinvProductCodeTextBox.Text = dt.Rows[0][2].ToString();
                            UpdateinvPriceTextBox.Text = dt.Rows[0][3].ToString();
                            UpdateinvAmountTextBox.Text = dt.Rows[0][4].ToString();
                        }
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void txtUpdateinvsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
