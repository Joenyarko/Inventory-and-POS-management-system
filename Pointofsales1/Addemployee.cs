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
    public partial class Addemployee : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Addemployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Firstname = empAddfname.Text;
            string Lastname = empAddlname.Text;
            string Address = empAddaddress.Text;
            string Contact = empAddcontact.Text;
            DateTime Dob = empAdddob.Value;
            string NationalID = empAddid.Text;
            string Gender = empAddgender.SelectedItem.ToString();
            string Maritalstatus = empAddmaritalstatus.SelectedItem.ToString();
            string Image = txtImage.Text;
            string Jobtitle = empAddjob.Text;
            string Shiftname = empAddshiftname.Text;
            DateTime Doc = empAdddoc.Value;
            string Salary = empAddsalary.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO add_employee (first_name, last_name, add_ress, contact, date_of_birth, national_id, gender, marital_status, photo, job_title, shift_name, date_commenced, basic_salary) VALUES (@Firstname, @Lastname, @Address, @Contact, @Dob, @NationalID, @Gender, @Maritalstatus, @Image, @Jobtitle, @Shiftname, @Doc, @Salary)", conn);

            cmd.Parameters.AddWithValue("@Firstname", Firstname);
            cmd.Parameters.AddWithValue("@Lastname", Lastname);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@Dob", Dob);
            cmd.Parameters.AddWithValue("@NationalID", NationalID);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Maritalstatus", Maritalstatus);
            cmd.Parameters.AddWithValue("@Image", Image);
            cmd.Parameters.AddWithValue("@Jobtitle", Jobtitle);
            cmd.Parameters.AddWithValue("@Shiftname", Shiftname);
            cmd.Parameters.AddWithValue("@Doc", Doc);
            cmd.Parameters.AddWithValue("@Salary", Salary);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record Successfully Saved");

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Empcode = txtAddemployeesearch.Text;
            string Name = txtAddemployeesearch.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string query = "SELECT * FROM add_employee WHERE emp_id='" + Empcode + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;

                    using (DataTable dt2 = new DataTable())
                    {
                        da.Fill(dt2);
                        if (dt2.Rows.Count > 0)
                        {
                            txtempcode.Text = dt2.Rows[0][0].ToString();
                            empAddfname.Text = dt2.Rows[0][1].ToString();
                            empAddlname.Text = dt2.Rows[0][2].ToString();
                            empAddaddress.Text = dt2.Rows[0][3].ToString();
                            empAddcontact.Text = dt2.Rows[0][4].ToString();
                            empAdddob.Value = DateTime.Parse(dt2.Rows[0][5].ToString());
                            empAddid.Text = dt2.Rows[0][6].ToString();
                            empAddgender.SelectedItem = dt2.Rows[0][7].ToString();
                            empAddmaritalstatus.SelectedItem = dt2.Rows[0][8].ToString();
                            txtImage.Text = dt2.Rows[0][9].ToString();
                            empAddjob.Text = dt2.Rows[0][10].ToString();
                            empAddshiftname.Text = dt2.Rows[0][11].ToString();
                            empAdddoc.Value = DateTime.Parse(dt2.Rows[0][12].ToString());
                            empAddsalary.Text = dt2.Rows[0][13].ToString();
                        }
                    }
                }
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

               
                    picboxImage.Image=System.Drawing.Image.FromFile(imagePath);
                
             
            }

        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
