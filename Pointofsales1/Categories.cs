using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointofsales1
{
    public partial class Categories : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Categories()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            string query = "Select * from category";
            using (SqlCommand cmd1 = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd1;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvcat.DataSource = dt;
                    }
                }
            }

        }

        private void btncatadd_Click(object sender, EventArgs e)
        {
            string Catname = txtcatname.Text;
            string Catdesc = txtcatdescrip.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            
            SqlCommand cmd = new SqlCommand("INSERT INTO category(catname, catdesc) VALUES(@Catname, @Catdesc)", conn);
            cmd.Parameters.AddWithValue("@Catname", Catname);
            cmd.Parameters.AddWithValue("@Catdesc", Catdesc);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Saved");



            string query = "Select * from category";
            using (SqlCommand cmd1 = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd1;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvcat.DataSource = dt;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select * from category";
            using (SqlCommand cmd1 = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd1;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvcat.DataSource = dt;
                    }
                }
            }
        }

        private void dgvcat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcatid.Text = dgvcat.SelectedRows[0].Cells[1].Value.ToString();
            txtcatname.Text = dgvcat.SelectedRows[0].Cells[2].Value.ToString();
            txtcatdescrip.Text= dgvcat.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void txtcatsearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btncatsearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            string Catname = txtcatsearch.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            

            string query = "Select * from category where catname ='" + Catname + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvcat.DataSource = dt;
                    }
                    using (DataTable dt2 = new DataTable())
                    {
                        da.Fill(dt2);
                        if (dt2.Rows.Count > 0)
                        {
                            txtcatid.Text = dt2.Rows[0][0].ToString();
                            txtcatname.Text = dt2.Rows[0][1].ToString();
                            txtcatdescrip.Text = dt2.Rows[0][2].ToString();
                          
                        }
                    }
                }
            }
        }

        private void btncatupt_Click(object sender, EventArgs e)
        {
            string newcatname = txtcatname.Text;
            string newcatdescrip= txtcatdescrip.Text;
            string catsearch=txtcatsearch.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Update category set catname=@newcatname,catdesc=@newcatdescrip where catname=@catsearch", conn))
            {
              
                cmd.Parameters.AddWithValue("@newcatname", newcatname);
                cmd.Parameters.AddWithValue("@newcatdescrip", newcatdescrip);
                cmd.Parameters.AddWithValue("@catsearch", catsearch);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated successfully");
            }
        }

        private void btncatdel_Click(object sender, EventArgs e)
        {
            string newcatid = txtcatid.Text;
            string newcatname = txtcatname.Text;
            string newcatdescrip = txtcatdescrip.Text;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            using (SqlCommand cmd = new SqlCommand("Delete from category where catname=@newcatname", conn))
            {
                cmd.Parameters.AddWithValue("@newcatname", newcatname);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully.");
                    txtcatid.Text = "";
                    txtcatname.Text = "";
                    txtcatdescrip.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }

