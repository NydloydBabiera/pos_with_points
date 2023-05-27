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


namespace pos_with_points.ChangePasswordForm
{
    public partial class ChangePassword : Form
    {
        public string userId { get; set; }
        DatabaseClass member = new DatabaseClass();
       
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtChangePassword.Text)
            {
                MessageBox.Show("Password did not match!");
                return;
            }
            member.clearItems();
            member.setwhereClause("user_info_id = " + userId);
            member.SetColumnUpdateRecord("user_password", txtNewPassword.Text);

            member.updateRecords("user_info_tbl");

            MessageBox.Show("Password changed successfully!");
            this.Close();
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
