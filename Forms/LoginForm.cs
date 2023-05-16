using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos_with_points.Classes;
using pos_with_points.POS;
using pos_with_points.AdminDashboardForms;

namespace pos_with_points.Login
{
    public partial class LoginForm : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string userName = "";
        public string password = "";
        public string userRole = "";


        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnCance_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get_value(string dbTable, string dbColumn, string whereClause)
            userName = member.get_value("user_info_tbl", "userName", "userName = " + "'" +txtUsername.Text + "'");
            password = member.get_value("user_info_tbl", "user_password", "user_password = " + "'" + txtPassword.Text + "'" );
            userRole = member.get_value("user_info_tbl", "user_role", "userName = " + "'" + txtUsername.Text + "'" + " and user_password = " + "'" + txtPassword.Text + "'");
            
           

            if (userName == "")
            {
                MessageBox.Show("User account does not exist!");

            }else if(password == "")
            {
                MessageBox.Show("Wrong password!");
            }else if(userRole == "CASHIER")
            {
                POSform pos = new POSform();
                pos.userId = member.get_value("user_info_tbl", "user_info_id", "userName = " + "'" + txtUsername.Text + "'" + " and user_password = " + "'" + txtPassword.Text + "'");
                pos.Show();
            }else if(userRole == "ADMIN")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }

            txtPassword.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
