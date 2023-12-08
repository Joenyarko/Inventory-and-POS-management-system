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
    public partial class sweetalert : Form
    {
        private Form callingForm;
        public sweetalert(Form callingForm)
        {
            InitializeComponent();
            this.callingForm = callingForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callingForm.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

