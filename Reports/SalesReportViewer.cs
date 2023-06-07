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

namespace pos_with_points.SalesReportForm
{
    public partial class SalesReportViewer : Form
    {
        public string dateFrom { set; get; }
        public string dateTo { set; get; }
        public SalesReportViewer()
        {
            InitializeComponent();
        }

        private void SalesReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:/Users/user/Desktop/thesis/pos_with_points/Reports/Sales.rpt");
            report.SetDatabaseLogon("sa", "123456");
            report.SetParameterValue("dateFrom", dpDateFrom.Value);
            report.SetParameterValue("dateTo", dpDateTo.Value);
            // Display the report in a Crystal Reports Viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("C:/Users/user/Desktop/thesis/pos_with_points/Reports/Sales.rpt");
            report.SetDatabaseLogon("sa", "123456");
            report.SetParameterValue("dateFrom", dpDateFrom.Value);
            report.SetParameterValue("dateTo", dpDateTo.Value);
            // Display the report in a Crystal Reports Viewer
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
