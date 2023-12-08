using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Pointofsales1
{
    public partial class frmReceipt : Form
    {
        
        public frmReceipt()
        {
            InitializeComponent();
           

            Microsoft.Reporting.WinForms.ReportViewer reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            SetReportPath();
        }
        private void SetReportPath()
        {
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(reportViewer1.LocalReport.ReportPath));
            reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
          
        }

        private void txtsalesid2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
