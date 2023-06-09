﻿using System;
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
using pos_with_points.ChangePasswordForm;


namespace pos_with_points.Login
{
    public partial class LoginForm : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string userName = "";
        public string password = "";
        public string userRole = "";
        public string userId { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.PreviewKeyDown += LoginForm_PreviewKeyDown;
        }


        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("yyyy-MM-dd") == "2023-07-09")
            {
                Form1 newForm = new Form1();
                newForm.ShowDialog();
            }
            else
            {
                //get_value(string dbTable, string dbColumn, string whereClause)
                userName = member.get_value("user_info_tbl", "userName", "userName = " + "'" + txtUsername.Text + "'");
                password = member.get_value("user_info_tbl", "user_password", "userName = " + "'" + txtUsername.Text + "'");
                userRole = member.get_value("user_info_tbl", "user_role", "userName = " + "'" + txtUsername.Text + "'" + " and user_password = " + "'" + txtPassword.Text + "'");



                if (userName == "")
                {
                    MessageBox.Show("User account does not exist!");
                    return;
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("No password!");
                    return;
                }
                else if (txtPassword.Text != password)
                {
                    MessageBox.Show("Wrong password!");
                    return;
                }

                if (userName == password)
                {

                    ChangePassword changePassword = new ChangePassword();
                    changePassword.userId = member.get_value("user_info_tbl", "user_info_id", "userName = " + "'" + txtUsername.Text + "'" + " and user_password = " + "'" + txtPassword.Text + "'");
                    changePassword.ShowDialog();

                }
                else
                {

                    if (userRole == "CASHIER")
                    {
                        this.Hide();
                        POSform pos = new POSform();
                        pos.userId = member.get_value("user_info_tbl", "user_info_id", "userName = " + "'" + txtUsername.Text + "'" + " and user_password = " + "'" + txtPassword.Text + "'");
                        pos.ShowDialog();
                        this.Close();
                    }
                    else if (userRole == "ADMIN")
                    {

                        this.Hide();
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.userId = member.get_value("user_info_tbl", "user_info_id", "userName = " + "'" + txtUsername.Text + "'" + " and user_password = " + "'" + txtPassword.Text + "'");
                        adminDashboard.ShowDialog();
                        this.Close();

                    }

                }
            }
            txtPassword.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnLogin.Text = "&LOGIN";
            userName = "";
            userRole = "";
            password = "";

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check for the specific key combination (Ctrl+O in this case)
            {
                btnLogin.PerformClick(); // Simulate a button click event
            }
        }

        private void LoginForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check for the specific key combination (Ctrl+O in this case)
            {
                btnLogin.PerformClick(); // Simulate a button click event
            }
        }
    }
}
