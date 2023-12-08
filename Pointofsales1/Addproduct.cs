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
    public partial class Addproduct : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Addproduct()
        {
            InitializeComponent();
        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            string Quantity = QtyTextBox.Text;
            string ProductName = ProductNameTextBox.Text;
            string ProductCode1 = ProductCodeTextBox.Text;
            int ProductCode = int.Parse(ProductCode1);
            string Price1 = PriceTextBox.Text;
            int Price = int.Parse(Price1);
            string Amount1 = AmountTextBox.Text;
            int Amount = int.Parse(Amount1);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO inventory(qty, productname, productcode, price, amount) VALUES(@Quantity, @ProductName, @ProductCode, @Price, @Amount)",conn);
             
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                    cmd.Parameters.AddWithValue("@ProductCode", ProductCode);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Amount", Amount);

                    cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Saved");
                }

        private void button1_Click(object sender, EventArgs e)
        {
            QtyTextBox.Text = "";
            ProductNameTextBox.Text="";
            ProductCodeTextBox.Text="";
            PriceTextBox.Text="";
            AmountTextBox.Text="";
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void Addproduct_Load(object sender, EventArgs e)
        {
            Fillcombo();
        }
        private void Fillcombo()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select  catname from category", conn);
            SqlDataReader  rdr;
            rdr =cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catname",typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "catname";
            CatCb.DataSource= dt;
                conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

        
}
