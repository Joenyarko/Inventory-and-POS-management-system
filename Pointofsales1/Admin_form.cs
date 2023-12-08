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
    public partial class Admin_form : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Admin_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AdminFirstname = txtAdminfname.Text;
            string AdminLastname = txtAdminlname.Text;
            DateTime AdminDOB = dtpAdmin.Value;
            string AdminUsername = txtAdminusername.Text;
            string AdminPassword = txtAdminpassword.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into ad_min(firstname,lastname,dob,username,pass_word)values(@AdminFirstname,@AdminLastname,@AdminDOB,@AdminUsername,@AdminPassword)", conn);

            cmd.Parameters.AddWithValue("@AdminFirstname", txtAdminfname.Text);
            cmd.Parameters.AddWithValue("@AdminLastname", txtAdminlname.Text);
            cmd.Parameters.AddWithValue("@AdminDOB", dtpAdmin.Value);
            cmd.Parameters.AddWithValue("@AdminUsername", txtAdminusername.Text);
            cmd.Parameters.AddWithValue("@AdminPassword", txtAdminpassword.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Saved");
            txtAdminfname.Text = "";
            txtAdminlname.Text = "";
            txtAdminusername.Text = "";
            txtAdminpassword.Text = "";
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'possystemDataSet1.ad_min' table. You can move, or remove it, as needed.
            this.ad_minTableAdapter.Fill(this.possystemDataSet1.ad_min);

        }
        public void BindData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

           
string query = "Select * from ad_min";
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

        private void btnAdminsearch_Click(object sender, EventArgs e)
        {
            Search();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newfirstname = txtAdminfname.Text;
            string newlastname = txtAdminlname.Text;
            DateTime newdob = dtpAdmin.Value;
            string newusername = txtAdminusername.Text;
            string newpassword = txtAdminpassword.Text;
            string adminsearch = txtAdminsearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Update ad_min set firstname=@newfirstname,lastname=@newlastname,dob=@newdob,username=@newusername,pass_word=@newpassword where firstname=@adminsearch", conn))
            {
                cmd.Parameters.AddWithValue("@newfirstname", newfirstname);
                cmd.Parameters.AddWithValue("@newlastname", newlastname);
                cmd.Parameters.AddWithValue("@newdob", newdob);
                cmd.Parameters.AddWithValue("@newusername", newusername);
                cmd.Parameters.AddWithValue("@newpassword", newpassword);
                cmd.Parameters.AddWithValue("@adminsearch", adminsearch);



                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated successfully");
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            string newfirstname = txtAdminfname.Text;
            string newlastname = txtAdminlname.Text;
            DateTime newdob = dtpAdmin.Value;
            string newusername = txtAdminusername.Text;
            string newpassword = txtAdminpassword.Text;
            string adminsearch = txtAdminsearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Delete from ad_min where firstname=@newfirstname", conn))
            {
                cmd.Parameters.AddWithValue("@newfirstname", newfirstname);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                    txtAdminfname.Text = "";
                    txtAdminlname.Text = "";
                    txtAdminusername.Text = "";
                    txtAdminpassword.Text = "";
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

        private void txtAdminsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        
                }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtAdminfname.Text = "";
            txtAdminlname.Text = "";
            txtAdminusername.Text = "";
            txtAdminpassword.Text = "";
        }

        public void Search()
        {
            string firstname2 = txtAdminsearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "Select * from ad_min where firstname='" + firstname2 + "'";
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
                    using (DataTable dt2 = new DataTable())
                    {
                        da.Fill(dt2);
                        if (dt2.Rows.Count > 0)
                        {
                            txtAdminfname.Text = dt2.Rows[0][0].ToString();
                            txtAdminlname.Text = dt2.Rows[0][1].ToString();
                            dtpAdmin.Value = (DateTime)dt2.Rows[0][2];
                            txtAdminusername.Text = dt2.Rows[0][3].ToString();
                            txtAdminpassword.Text = dt2.Rows[0][4].ToString();
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

        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
    
