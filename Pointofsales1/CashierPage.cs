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
    public partial class CashierPage : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public CashierPage()
        {
            InitializeComponent();
        }

        private void CashierPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'possystemDataSet1.cashier' table. You can move, or remove it, as needed.
            this.cashierTableAdapter.Fill(this.possystemDataSet1.cashier);

        }

        private void addNewCashier_Click(object sender, EventArgs e)
        {
            string CashierFirstname = txtCashierfname.Text;
            string CashierLastname = txtCashierlname.Text;
            DateTime CashierDOB = dtpCashier.Value;
            string CashierContact = txtCashiercontact.Text;
            string CashierEmail = txtCashieremail.Text;
            string CashierUsername = txtCashierusername.Text;
            string CashierPassword = txtCashierpassword.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into cashier(firstname,lastname,dob,contact,email_address,username,pass_word)values(@CashierFirstname,@CashierLastname,@CashierDOB,@CashierContact,@CashierEmail,@CashierUsername,@CashierPassword)", conn);

            cmd.Parameters.AddWithValue("@CashierFirstname", txtCashierfname.Text);
            cmd.Parameters.AddWithValue("@CashierLastname", txtCashierlname.Text);
            cmd.Parameters.AddWithValue("@CashierDOB", dtpCashier.Value);
            cmd.Parameters.AddWithValue("@CashierContact", txtCashiercontact.Text);
            cmd.Parameters.AddWithValue("@CashierEmail", txtCashieremail.Text);
            cmd.Parameters.AddWithValue("@CashierUsername", txtCashierusername.Text);
            cmd.Parameters.AddWithValue("@CashierPassword", txtCashierpassword.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Saved");
            txtCashierfname.Text = "";
            txtCashierlname.Text = "";
            txtCashiercontact.Text = "";
            txtCashieremail.Text = "";
            txtCashierusername.Text = "";
            txtCashierpassword.Text = "";

        }

        private void btnCashierdisplay_Click(object sender, EventArgs e)
        {
            BindData();
        }
        public void Search()
        {
            string Firstname2 = txtCashiersearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "Select * from cashier where firstname='" + Firstname2 + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvDisplay.DataSource = dt;

                        using (DataTable dt2 = new DataTable())
                        {
                            da.Fill(dt2);
                            if (dt2.Rows.Count > 0)
                            {
                                txtCashierfname.Text = dt2.Rows[0][0].ToString();
                                txtCashierlname.Text = dt2.Rows[0][1].ToString();
                                dtpCashier.Value = Convert.ToDateTime(dt2.Rows[0][2]);
                                txtCashiercontact.Text = dt2.Rows[0][3].ToString();
                                txtCashieremail.Text = dt2.Rows[0][4].ToString();
                                txtCashierusername.Text = dt2.Rows[0][5].ToString();
                                txtCashierpassword.Text = dt2.Rows[0][6].ToString();
                            }
                        }
                    }
                }
            }

        }

        public void BindData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "Select * from cashier";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvDisplay.DataSource = dt;
                    }
                }
            }
        }

        private void txtCashiersearch_TextChanged(object sender, EventArgs e)
        {
            Search();

                    }

        private void btnCashiersearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnCashierupdate_Click(object sender, EventArgs e)
        {
            string newfirstname = txtCashierfname.Text;
            string newlastname = txtCashierlname.Text;
            DateTime newdob = dtpCashier.Value;
            string newcontact = txtCashiercontact.Text;
            string newemail = txtCashieremail.Text;
            string newusername = txtCashierusername.Text;
            string newpassword = txtCashierpassword.Text;
            string Adminsearch = txtCashiersearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Update cashier set firstname=@newfirstname,lastname=@newlastname,dob=@newdob,contact=@newcontact,email_address=@newemail,username=@newusername,pass_word=@newpassword where firstname='" + Adminsearch + "'", conn))
            {
                cmd.Parameters.AddWithValue("@newfirstname", newfirstname);
                cmd.Parameters.AddWithValue("@newlastname", newlastname);
                cmd.Parameters.AddWithValue("@newdob", newdob);
                cmd.Parameters.AddWithValue("@newcontact", newcontact);
                cmd.Parameters.AddWithValue("@newemail", newemail);
                cmd.Parameters.AddWithValue("@newusername", newusername);
                cmd.Parameters.AddWithValue("@newpassword", newpassword);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated successfully");
            }

        }

        private void btnCashierdelete_Click(object sender, EventArgs e)
        {
            string newfirstname = txtCashierfname.Text;
            string newlastname = txtCashierlname.Text;
            DateTime newdob = dtpCashier.Value;
            string newcontact = txtCashiercontact.Text;
            string newemail = txtCashieremail.Text;
            string newusername = txtCashierusername.Text;
            string newpassword = txtCashierpassword.Text;
            string Adminsearch = txtCashiersearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Delete from cashier where firstname=@newfirstname", conn))
            {
                cmd.Parameters.AddWithValue("@newfirstname", newfirstname);
                cmd.Parameters.AddWithValue("@newlastname", newlastname);
                cmd.Parameters.AddWithValue("@newdob", newdob);
                cmd.Parameters.AddWithValue("@newcontact", newcontact);
                cmd.Parameters.AddWithValue("@newemail", newemail);
                cmd.Parameters.AddWithValue("@newusername", newusername);
                cmd.Parameters.AddWithValue("@newpassword", newpassword);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                    txtCashierfname.Text = "";
                    txtCashierlname.Text = "";
                    txtCashiercontact.Text = "";
                    txtCashieremail.Text = "";
                    txtCashierusername.Text = "";
                    txtCashierpassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCashierfname.Text = "";
            txtCashierlname.Text = "";
            txtCashiercontact.Text = "";
            txtCashieremail.Text = "";
            txtCashierusername.Text = "";
            txtCashierpassword.Text = "";
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
