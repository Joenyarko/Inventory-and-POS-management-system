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
    public partial class Registeremployee : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Registeremployee()
        {
            InitializeComponent();
        }

        private void Registeremployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'possystemDataSet1.add_employee' table. You can move, or remove it, as needed.
            this.add_employeeTableAdapter.Fill(this.possystemDataSet1.add_employee);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addemployee addEmployeeForm = new Addemployee();
            addEmployeeForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addemployee addEmployeeForm = new Addemployee();
            addEmployeeForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addemployee addEmployeeForm = new Addemployee();
            addEmployeeForm.Show();

        }
        public void BindData()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string query = "SELECT * FROM add_employee";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        empdgv.DataSource = dt;
                    }
                }
            }
        }


        private void btnsearchempdetails_Click(object sender, EventArgs e)
        {
            string Empcode = txtsearchempdetails.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string query = "SELECT * FROM add_employee WHERE emp_id='" + Empcode + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;

                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        empdgv.DataSource = dt;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
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
