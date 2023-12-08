using CrystalDecisions.ReportAppServer.DataDefModel;
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
    public partial class Sales : Form
    {
        private string currentSalesId;
        private string currentSalesCash;
        private string currentSalesCashier;
        private string currentSalesChange;
        public string CashierFirstName { get; set; }
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        public Sales(string cashierFirstName)
        {
            InitializeComponent();
            currentSalesCashier = gunaLabel3.Text;
            gunaLabel3.Text= $"Welcome,  {cashierFirstName}!";
            currentSalesCashier = $" {cashierFirstName}!";
        
        }

        private void txtsalesid_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(100, 1000000001);
            currentSalesId = randomNumber.ToString();
            txtsalesid.Text = currentSalesId;
            txtsalestotal.Text = "";
            txtsalessearch.Text = "";
            txtsalesproduct.Text = "";
            txtsalesqty.Text = "";
            txtsalesprice.Text = "";
            txtsalesamount.Text = "";
            txtsalescash.Text = "";
            txtsaleschange.Text = "";
            txtsalesvat.Text = "";

            saleslistview.Items.Clear();
         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTextBox1.Text = DateTime.Now.ToShortDateString();
            TimeTextBox1.Text = DateTime.Now.ToLongTimeString();

        }
        public void sales()
        {
            string Salesid = txtsalesid.Text;
            string Productname = txtsalesproduct.Text;
            string Price = txtsalesprice.Text;
            string Totals = txtsalestotal.Text;
            string Quantiti = txtsalesqty.Text;
            string Date = DateTime.Now.ToShortDateString();
            string Time= DateTime.Now.ToString("HH:mm:ss");
            decimal amounttotal = Convert.ToDecimal(Price) * Convert.ToDecimal(Quantiti);
       
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("Insert into sales(sales_id,qty,productname,price,amount,date_,time_)values(@Salesid,@Quantiti,@Productname,@Price,@amounttotal,@Date,@Time)", conn);
            cmd.Parameters.AddWithValue("Salesid", Salesid);
            cmd.Parameters.AddWithValue("Quantiti", Quantiti);
            cmd.Parameters.AddWithValue("Productname", Productname);
            cmd.Parameters.AddWithValue("Price", Price);
            cmd.Parameters.AddWithValue("amounttotal", amounttotal);
            cmd.Parameters.AddWithValue("Date", DateTime.Now);
            cmd.Parameters.AddWithValue("Time", DateTime.Now.ToString("HH:mm:ss"));
            cmd.ExecuteNonQuery();
            conn.Close();

            string query = "Select * from sales where sales_id ='" + Salesid + "'";

            using (SqlCommand cmd1 = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd1;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        saleslistview.Items.Clear();

                        foreach (DataRow drow in dt.Rows)
                        {
                            saleslistview.Items.Add(drow[1].ToString());
                            saleslistview.Items[saleslistview.Items.Count - 1].SubItems.Add(drow[2].ToString());
                            saleslistview.Items[saleslistview.Items.Count - 1].SubItems.Add(drow[3].ToString());
                            saleslistview.Items[saleslistview.Items.Count - 1].SubItems.Add(drow[4].ToString());
                        }
                    }
                }
            }

            decimal total = 0;
            foreach (ListViewItem item in saleslistview.Items)
            {
                total += Convert.ToDecimal(item.SubItems[3].Text);
            }
            txtsalestotal.Text = total.ToString();

            decimal vat = total * 0.12M;
            txtsalesvat.Text = vat.ToString();
            txtsalestotal.Text = (total ).ToString();
   
             
            /*
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd2 = new SqlCommand("UPDATE inventory SET qty = qty - @Quantiti , amount= (qty-@Quantiti)  * price WHERE Productname = @Productname",conn);
                cmd2.Parameters.AddWithValue("@Productname", Productname);
                cmd2.Parameters.AddWithValue("@Quantiti", Quantiti);
            

                cmd2.ExecuteNonQuery();
            conn.Close();
            */
        }
        public void barcode()
        {
            string Barcode = txtbarcode.Text;
            string price = txtsalestotal.Text;
            if (conn.State == ConnectionState.Closed) conn.Open();
            string query = "Select * from inventory where productcode ='" + Barcode + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    // Using dt As New DataTable()
                    //da.Fill(dt)
                    //salesdgv.DataSource = dt
                    //End Using
                    using (DataTable dt2 = new DataTable())
                    {
                        da.Fill(dt2);
                        if (dt2.Rows.Count > 0)
                        {
                            txtsalesproduct.Text = dt2.Rows[0][1].ToString();
                            txtsalesprice.Text = dt2.Rows[0][3].ToString();
                            txtsalesamount.Text = dt2.Rows[0][4].ToString();
                        }
                    }
                }
            }
            if (Barcode == "")
            {
                txtsalestotal.Text = "";
            }

        }
        public void searchcode()
        {
            string Itemsearch = txtsalessearch.Text;
            string Productname = txtsalesproduct.Text;
            string Price = txtsalesprice.Text;
            string Amount = txtsalesamount.Text;
            string Quantity = txtsalesqty.Text;

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string query = "Select * from inventory where productname ='" + Itemsearch + "'";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    using (DataTable dt3 = new DataTable())
                    {
                        da.Fill(dt3);
                        if (dt3.Rows.Count > 0)
                        {
                            txtsalesproduct.Text = dt3.Rows[0][1].ToString();
                            txtsalesprice.Text = dt3.Rows[0][3].ToString();
                            txtsalesamount.Text = dt3.Rows[0][4].ToString();
                        }
                    }
                }
            }

            if (Itemsearch == "")
            {
                txtsalestotal.Text = "";
            }

        }
        private void txtsalescash_TextChanged(object sender, EventArgs e)
        {
            double cashValue;
            if (Double.TryParse(txtsalescash.Text, out cashValue))
            {
                // Parsing was successful, use the parsed value
                double totalValue;
                if (Double.TryParse(txtsalestotal.Text, out totalValue))
                {
                    // Parsing was successful, calculate the change and set the text box value
                    double changeValue = cashValue - totalValue;
                    txtsaleschange.Text = changeValue.ToString();
                }
                else
                {
                    // Parsing of totalValue failed, handle the error
                }
            }
            else
            {
                // Parsing of cashValue failed, handle the error
            }

            if (txtsalescash.Text == "")
            {
                txtsaleschange.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sales();
        }

        private void txtsalessearch_TextChanged(object sender, EventArgs e)
        {
            searchcode();
        }

        private void txtbarcode_TextChanged(object sender, EventArgs e)
        {
            barcode();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saleslistview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsalesclear_Click(object sender, EventArgs e)
        {
            txtsalestotal.Text = "";
            txtsalessearch.Text = "";
            txtsalesproduct.Text = "";
            txtsalesqty.Text = "";
            txtsalesprice.Text = "";
            txtsalesamount.Text = "";
            txtsalescash.Text = "";
            txtsaleschange.Text = "";
            txtsalesvat.Text = "";
            txtsalesdescription.Text = "";
            txtbarcode.Text = "";
            txtsalesid.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReceipt frmReceipt=new frmReceipt();
            frmReceipt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentSalesCash = txtsalescash.Text;
            currentSalesChange = txtsaleschange.Text;
            Checkorder checkorder = new Checkorder(this);
            checkorder.ShowDialog();
           

        }
        public string CurrentSalesId
        {
            get { return currentSalesId; }
        }
        public string CurrentSalesCash
        {
            get { return currentSalesCash; }
        }
        public string CurrentSalesCashier
        {
            get { return currentSalesCashier; }
        }
        public string CurrentSalesChange
        {
            get { return currentSalesChange; }
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtsaleschange_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
