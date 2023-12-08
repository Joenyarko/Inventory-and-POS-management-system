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
    public partial class Adlogin : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Adlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Open database connection
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Get the entered username and password
                string adminFirstName = string.Empty;
                string enteredUsername = txtuserlogin.Text;
                string enteredPassword = txtpasslogin.Text;

                // Create a SQL command to check if the entered credentials are valid
                SqlCommand cmd = new SqlCommand("SELECT firstname FROM ad_min WHERE username=@username AND pass_word=@pass_word", conn);
                cmd.Parameters.AddWithValue("@username", enteredUsername);
                cmd.Parameters.AddWithValue("@pass_word", enteredPassword);

                // Execute the SQL command and get the result
                object result = cmd.ExecuteScalar();

                // Check if the entered credentials are valid
                if (result != null)
                {
                    // Show admin Panel when credentials are valid
                    adminFirstName=result.ToString();
                    AdminPage adminPage = new AdminPage(adminFirstName);
                    adminPage.AdminFirstName=adminFirstName;
                    adminPage.Show();

                    this.Hide();

                }
                else
                {
                    // Show any error message when credentials are invalid
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                // Handles any error that occurs when connecting to the database
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
            finally
            {
                // Closes the database connection
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registeradmin registeradmin = new Registeradmin();
            registeradmin.Show();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void txtuserlogin_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void txtuserlogin_Click(object sender, EventArgs e)
        {
            
        }

       

        private void txtpasslogin_Click(object sender, EventArgs e)
        {
           
        }

        private void txtpasslogin_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked)
            {
                txtpasslogin.UseSystemPasswordChar = true;
            }
            else
            {
                txtpasslogin.UseSystemPasswordChar = false;
            }


        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtpasslogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
