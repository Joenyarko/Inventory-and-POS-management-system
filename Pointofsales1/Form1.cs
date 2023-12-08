using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;


namespace Pointofsales1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adlogin adlogin = new Adlogin();
            adlogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Caslogin caslogin = new Caslogin();
            caslogin.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

            Adlogin adlogin = new Adlogin();
            adlogin.Show();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Caslogin caslogin = new Caslogin();
            caslogin.Show();
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
