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
using CrystalDecisions.ReportAppServer.DataDefModel;
using CrystalDecisions.CrystalReports.Engine;

namespace Pointofsales1
{
    public partial class Report : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "SELECT TOP 10 * FROM sales ORDER BY time_ DESC";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvreports.DataSource = dt;
                    }

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.salesTableAdapter.FillBy(this.possystemDataSet3.sales);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbreports_SelectedIndexChanged(object sender, EventArgs e)

        {
            /*
            string selectedSalesId = cmbreports.SelectedItem.ToString();
            SearchAndDisplayData("SalesID", selectedSalesId);
            */
            if (cmbreports.SelectedItem != null)
            {
                // Convert the selected item to string and then parse it as an integer
                if (int.TryParse(cmbreports.SelectedItem.ToString(), out int selectedSalesId))
                {
                    SearchAndDisplayData("SalesID", selectedSalesId.ToString());
                }
               
            }
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            string selectedOption = cmbreports.SelectedItem.ToString();
            string searchText = txtreports.Text.Trim();

            if (selectedOption == "SalesID")
            {
                SearchAndDisplayData("SalesID", searchText);
            }
            else if (selectedOption == "Date")
            {
                SearchAndDisplayData("Date", searchText);
            }
        }
        private void SearchAndDisplayData(string searchType, string searchValue)
        {
            // Clear previous data in the DataGridView
            dgvreports.DataSource = null;

            // Build the SQL query based on the selected search type
            string query = string.Empty;
            if (searchType == "SalesID")
            {
                query = "SELECT * FROM sales WHERE sales_id = @SearchValue";
            }
            else if (searchType == "Date")
            {
                if (DateTime.TryParse(searchValue, out DateTime dateValue))
                {
                    query = "SELECT * FROM sales WHERE date_ = @SearchValue";
                }
                else
                {
                    MessageBox.Show("Invalid date format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (searchType == "SalesID")
                {
                    cmd.Parameters.AddWithValue("@SearchValue", int.Parse(searchValue));
                }
                else if (searchType == "Date")
                {
                    // Assuming DateColumn is of type datetime, adjust the format accordingly
                    if (DateTime.TryParse(searchValue, out DateTime dateValue))
                    {
                        cmd.Parameters.AddWithValue("@SearchValue", dateValue);
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Data found, display it in the DataGridView
                    dgvreports.DataSource = dataTable;
                }
                else
                {
                    // No data found, show a message
                    MessageBox.Show("Record not found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            string query = "SELECT TOP 10 * FROM sales ORDER BY time_ DESC";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dgvreports.DataSource = dt;
                    }

                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }
