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
    public partial class Registeradmin : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Registeradmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Firstname;
            string Lastname;
            DateTime DOB;
            string Username;
            string Password;
            Firstname = txtfname.Text;
            Lastname = txtlname.Text;
            DOB = dtpDOB.Value;
            Username = txtusername.Text;
            Password = txtpassword.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into Ad_min(firstname,lastname,dob,username,pass_word)values(@Firstname,@Lastname,@DOB,@Username,@Password)", conn);

            cmd.Parameters.AddWithValue("@Firstname", txtfname.Text);
            cmd.Parameters.AddWithValue("@Lastname", txtlname.Text);
            cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
            cmd.Parameters.AddWithValue("@Username", txtusername.Text);
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Saved");
            txtfname.Text = "";
            txtlname.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";

            this.Close();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
