using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos_with_points.UserRegistration;
using pos_with_points.CustomerForm;
using pos_with_points.ProductRegistrationForm;
using pos_with_points.ProductEntryForm;

namespace pos_with_points.AdminDashboardForms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ProductEntry productEntry = new ProductEntry();
            productEntry.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductRegistration productRegistration = new ProductRegistration();
            productRegistration.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserRegistrationForm userRegistration = new UserRegistrationForm();
            userRegistration.ShowDialog();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.ShowDialog();
        }
    }
}
