using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos_with_points.UserRegistration;
using pos_with_points.CustomerForm;
using pos_with_points.ProductRegistrationForm;
using pos_with_points.ProductEntryForm;
using pos_with_points.AdminDashboardForms;
using pos_with_points.POS;
using pos_with_points.Login;

namespace pos_with_points
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new POSform());
        }
    }
}
