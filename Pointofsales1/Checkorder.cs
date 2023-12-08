using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Pointofsales1
{
    public partial class Checkorder : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        private Sales sales;
        public Checkorder(Sales sales)
        {
            InitializeComponent();
            this.sales = sales;
        }

      
        private string connectionString = "Data source=CONFIRM;initial catalog=Possystem;integrated security=true"; 

        

        private void Checkorder_Load(object sender, EventArgs e)
        {
            txtcheckorder.Text = sales.CurrentSalesId;
            GetDataForSalesId(sales.CurrentSalesId);
            string salesid = txtcheckorder.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }


            string query = "Select * from sales where sales_id = @salesid ";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    cmd.Parameters.AddWithValue("@salesid", salesid);
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvcheckorder.DataSource = dt;
                    }
                }
            }
        }
        public DataTable GetDataForSalesId(string salesId)
        {

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = $"SELECT * FROM sales WHERE sales_id = @salesId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@salesId", salesId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        dgvcheckorder.DataSource = adapter;
                    }
                }
            }

            return dataTable;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string salesid=txtcheckorder.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Delete from sales where sales_id=@salesid", conn))
            {
                cmd.Parameters.AddWithValue("@salesid", salesid);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                    txtcheckorder.Text = "";
                    dgvcheckorder.DataSource = null;
                    dgvcheckorder.Refresh();
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
        }

        private void txtcheckorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Receiptform receipt = new Receiptform(sales);
            receipt.Show();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}