using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointofsales1
{
    public partial class Inventory : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'possystemDataSet1.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.possystemDataSet1.inventory);

        }

        private void btninvdisplay_Click(object sender, EventArgs e)
        {
            BindData();
        }
        public void BindData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "Select * from inventory";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        inventorydgv.DataSource = dt;
                    }
                }
            }
        }

        private void btninvadd_Click(object sender, EventArgs e)
        {
            Addproduct addproduct = new Addproduct();
            addproduct.Show();
        }

        private void btninvupt_Click(object sender, EventArgs e)
        {
            Updateinventory updateinventory = new Updateinventory();
            updateinventory.Show();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void inventorydgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
