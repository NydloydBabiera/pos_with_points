using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace pos_with_points.ReceiptReportForm
{
   
    public partial class ReceiptForm : Form
    {
        public string transactionId { get; set; }
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("E:/Nydloyd/Others/thesis2/AMA marbel/pos_with_points/Reports/receipt.rpt");
            report.SetDatabaseLogon("sa", "123456");
            report.SetParameterValue("transactionId", transactionId);
            // Display the report in a Crystal Reports Viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
