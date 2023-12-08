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
using Guna.UI.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace Pointofsales1
{
    public partial class Receiptform : Form
    {
        SqlConnection conn = new SqlConnection("Data source=CONFIRM;initial catalog=Possystem;integrated security=true");
        private Sales sales;
        public string CashierFirstName { get; set; }
        public Receiptform(Sales sales)
        {
            InitializeComponent();
            this.sales = sales;
        }

        public Receiptform(string cashierFirstName)
        {
            InitializeComponent();
            lblcashier.Text = $"Cashier, {cashierFirstName}!";
        }

        Bitmap bmp;

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTextBox.Text = DateTime.Now.ToShortDateString();
            TimeTextBox.Text = DateTime.Now.ToLongTimeString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            /*
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
            */
            lblsales.Text= sales.CurrentSalesId;
            lblcashier.Text = sales.CurrentSalesCashier;
            lblamount.Text = sales.CurrentSalesCash;
            lblchange.Text = sales.CurrentSalesChange;
            
           


            string salesid = lblsales.Text;
           

            string query = "Select * from sales where sales_id ='" + salesid + "'";

            using (SqlCommand cmd1 = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd1;
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                  
                        foreach (DataRow drow in dt.Rows)
                        {
                            receiptlistview.Items.Add(drow[2].ToString());
                            receiptlistview.Items[receiptlistview.Items.Count - 1].SubItems.Add(drow[1].ToString());
                            receiptlistview.Items[receiptlistview.Items.Count - 1].SubItems.Add(drow[3].ToString());
                            receiptlistview.Items[receiptlistview.Items.Count - 1].SubItems.Add(drow[4].ToString());
                        }
                    }
                }
            }
            decimal total = 0;
            foreach (ListViewItem item in receiptlistview.Items)
            {
                total += Convert.ToDecimal(item.SubItems[3].Text);
            }
            lbltotal.Text = total.ToString();

            decimal vat = total * 0.12M;
            lblvat.Text = vat.ToString();
            lbltotal.Text = (total ).ToString();
            lbltotal1.Text=(total-vat).ToString();
          


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            foreach (ListViewItem item in receiptlistview.Items)
            {
                string productName = item.SubItems[0].Text; // Assuming the product name is in the first column
                int quantity;

                if (int.TryParse(item.SubItems[1].Text, out quantity)) // Assuming the quantity is in the second column
                {
                    SqlCommand cmd2 = new SqlCommand("UPDATE inventory SET qty = qty - @Quantity, amount = (qty - @Quantity) * price WHERE Productname = @Productname", conn);

                    cmd2.Parameters.AddWithValue("@Productname", productName);
                    cmd2.Parameters.AddWithValue("@Quantity", quantity);

                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    // Handle the case where the quantity is not a valid integer
                    MessageBox.Show("Invalid quantity for product: " + productName);
                }
            }

            conn.Close();
            printDocument1.PrintPage += printDocument1_PrintPage;
          
        }
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            this.Close();
            printPreviewDialog1.ShowDialog();

          
        }
    }
}
