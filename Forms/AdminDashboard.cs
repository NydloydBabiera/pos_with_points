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
using pos_with_points.POS;
using pos_with_points.Login;

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
            timer1.Start();
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

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSform pOSForm = new POSform();
            pOSForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                lblDataTime.Text = DateTime.Now.ToString("MMMM dd, yyyy") + "\n" + DateTime.Now.ToLongTimeString(); ;
            
        }
    }
}
