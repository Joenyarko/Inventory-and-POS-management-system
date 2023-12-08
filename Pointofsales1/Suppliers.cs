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
    public partial class Suppliers : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Suppliers()
        {
            InitializeComponent();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            string SupplierID=txtsupplierid.Text;
            string SupplierFirstname = txtsupplierfname.Text;
            string SupplierLastname = txtsupplierlname.Text;
            DateTime SupplierDOB = dtpsupplier.Value;
            string SupplierContact = txtsuppliercontact.Text;
            string SupplierAddress = txtsupplieraddress.Text;
            string SupplierCompany = txtsuppliercompany.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into suppliers(firstname,lastname,dob,contact,home_address,company)values(@SupplierFirstname,@SupplierLastname,@SupplierDOB,@SupplierContact,@SupplierAddress,@SupplierCompany)", conn);

            cmd.Parameters.AddWithValue("@SupplierFirstname ", SupplierFirstname);
            cmd.Parameters.AddWithValue("@SupplierLastname", SupplierLastname);
            cmd.Parameters.AddWithValue("@SupplierDOB", SupplierDOB);
            cmd.Parameters.AddWithValue("@SupplierContact", SupplierContact);
            cmd.Parameters.AddWithValue("@SupplierAddress ", SupplierAddress);
            cmd.Parameters.AddWithValue("@SupplierCompany ", SupplierCompany);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Saved");
            txtsupplierfname.Text = "";
            txtsupplierlname.Text = "";
            txtsuppliercontact.Text = "";
            txtsupplieraddress.Text = "";
            txtsuppliercompany.Text = "";
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'possystemDataSet3.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.possystemDataSet3.suppliers);

        }

        private void btnsupplierdisplay_Click(object sender, EventArgs e)
        {
            BindData();
        }
        public void BindData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }


            string query = "Select * from suppliers";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvsupplier.DataSource = dt;
                    }
                }
            }
        }

        private void btnsupplierupdate_Click(object sender, EventArgs e)
        {
            string newfirstname = txtsupplierfname.Text;
            string newlastname = txtsupplierlname.Text;
            DateTime newdob = dtpsupplier.Value;
            string newcontact = txtsuppliercontact.Text;
            string newaddress = txtsupplieraddress.Text;
            string suppliersearch = txtsuppliersearch.Text;
            string newcompany = txtsuppliercompany.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Update suppliers set firstname=@newfirstname,lastname=@newlastname,dob=@newdob,contact=@newcontact,home_address=@newaddress,company=@newcompany where firstname=@suppliersearch", conn))
            {
                cmd.Parameters.AddWithValue("@newfirstname", newfirstname);
                cmd.Parameters.AddWithValue("@newlastname", newlastname);
                cmd.Parameters.AddWithValue("@newdob", newdob);
                cmd.Parameters.AddWithValue("@newcontact", newcontact);
                cmd.Parameters.AddWithValue("@newaddress", newaddress);
                cmd.Parameters.AddWithValue("@suppliersearch", suppliersearch);
                cmd.Parameters.AddWithValue("@newcompany", newcompany);


                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated successfully");
            }
        }

        private void btnsupplierdelete_Click(object sender, EventArgs e)
        {
            string newfirstname = txtsupplierfname.Text;
            string newlastname = txtsupplierlname.Text;
            DateTime newdob = dtpsupplier.Value;
            string newcontact = txtsuppliercontact.Text;
            string newaddress = txtsupplieraddress.Text;
            string suppliersearch = txtsuppliersearch.Text;
            string suppliercompany = txtsuppliercompany.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Delete from suppliers where firstname=@newfirstname", conn))
            {
                cmd.Parameters.AddWithValue("@newfirstname", newfirstname);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                    txtsupplierfname.Text = "";
                    txtsupplierlname.Text = "";
                    txtsuppliercontact.Text = "";
                    txtsupplieraddress.Text = "";
                    txtsuppliercompany.Text = "";
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
        }

        private void btnsupplierclear_Click(object sender, EventArgs e)
        {
            txtsupplierfname.Text = "";
            txtsupplierlname.Text = "";
            txtsuppliercontact.Text = "";
            txtsupplieraddress.Text = "";
            txtsuppliercompany.Text = "";
        }

        private void btnsupplierexit_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void btnsuppliersearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        public void Search()
        {
            string firstname2 = txtsuppliersearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "Select * from suppliers where firstname='" + firstname2 + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvsupplier.DataSource = dt;
                    }
                    using (DataTable dt2 = new DataTable())
                    {
                        da.Fill(dt2);
                        if (dt2.Rows.Count > 0)
                        {
                            txtsupplierid.Text = dt2.Rows[0][0].ToString();
                            txtsupplierfname.Text = dt2.Rows[0][1].ToString();
                            txtsupplierlname.Text = dt2.Rows[0][2].ToString();
                            dtpsupplier.Value = (DateTime)dt2.Rows[0][3];
                            txtsuppliercontact.Text = dt2.Rows[0][4].ToString();
                            txtsupplieraddress.Text = dt2.Rows[0][5].ToString();
                            txtsuppliercompany.Text = dt2.Rows[0][6].ToString();
                        }
                    }
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
