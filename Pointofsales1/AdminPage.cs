using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointofsales1
{
   
    public partial class AdminPage : Form
    {
        public string AdminFirstName { get; set; }
        public AdminPage(string adminFirstName)
        {
            InitializeComponent();
            gunaLabel3.Text = $"WELCOME, {adminFirstName}!";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_form admin_Form = new Admin_form();
            admin_Form.Show();
        }

        private void cashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierPage cashierPage = new CashierPage();
            cashierPage.Show();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addproduct addproduct = new Addproduct();
            addproduct.Show();
        }

        private void addItemQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductQuantity addProductQuantity = new AddProductQuantity();
            addProductQuantity.Show();
        }

        private void outOfStockitemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outofstock outofstock = new Outofstock();
            outofstock.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addemployee addemployee = new Addemployee();
            addemployee.Show();
        }

        private void manageDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registeremployee registeremployee = new Registeremployee();
            registeremployee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip3.Show(button5, 0, button5.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip1.Show(button1, 0, button1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip2.Show(button2, 0, button2.Height);
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void gunaCirclePictureBox7_Click(object sender, EventArgs e)
        {
            sweetalert Sweetalert = new sweetalert(this);
            Sweetalert.Show();
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip1.Show(button1, 0, button1.Height);
        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip2.Show(button2, 0, button2.Height);
        }

        private void gunaCirclePictureBox3_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void gunaCirclePictureBox4_Click(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip3.Show(button5, 0, button5.Height);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void btn_cat_MouseClick(object sender, MouseEventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTextBox.Text = DateTime.Now.ToShortDateString();
            TimeTextBox.Text = DateTime.Now.ToLongTimeString();
        }

        private void gunaCirclePictureBox6_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.Show();
        }

        private void DateTextBox_Click(object sender, EventArgs e)
        {

        }

        private void TimeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox5_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    }

