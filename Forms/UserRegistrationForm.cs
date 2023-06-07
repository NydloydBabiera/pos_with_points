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

namespace pos_with_points.UserRegistration
{
    public partial class UserRegistrationForm : Form
    {
        DatabaseClass member = new DatabaseClass();
        string userId = "";
        Boolean isEdit = false;

        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {
            disableFields();
            clearTexts();
            DGV_UserData.AutoGenerateColumns = false;
            DGV_UserData.DataSource = member.getdata("user_info_tbl", "user_info_id");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userCreds = txtFirstName.Text[0] + txtLastName.Text.Trim();

            if(isEdit == true)
            {
                member.clearItems();
                member.setwhereClause("user_info_id = " + userId);
                member.SetColumnUpdateRecord("firstName", txtFirstName.Text);
                member.SetColumnUpdateRecord("middleName", txtMiddleName.Text);
                member.SetColumnUpdateRecord("lastName", txtLastName.Text);
                member.SetColumnUpdateRecord("user_role", cbUserRole.Text);

                member.updateRecords("user_info_tbl");

                MessageBox.Show("Update successfull!");
            }
            else
            {
                member.clearItems();
                member.setColumn("firstName");
                member.setColumn("middleName");
                member.setColumn("lastName");
                member.setColumn("username");
                member.setColumn("user_password");
                member.setColumn("user_role");


                member.setValues(txtFirstName.Text);
                member.setValues(txtMiddleName.Text);
                member.setValues(txtLastName.Text);
                member.setValues(userCreds);
                member.setValues(userCreds);
                member.setValues(cbUserRole.Text);

                member.AddRecord("user_info_tbl");

                MessageBox.Show("Record Saved!");
            }
            
            DGV_UserData.DataSource = member.getdata("user_info_tbl", "user_info_id");
            disableFields();
        }

        private void clearTexts()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            cbUserRole.Text = "";
        }
        private void disableFields()
        {
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            cbUserRole.Enabled = false;
        }
        private void enableFields()
        {
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            cbUserRole.Enabled = true;
        }

        private void DGV_UserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = DGV_UserData.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DGV_UserData.Rows[selectedrowindex];
            userId = Convert.ToString(selectedRow.Cells["user_info_id"].Value);
        }

        private String getRowValue(string colName)
        {
            int selectedrowindex = DGV_UserData.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DGV_UserData.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[colName].Value);
            return cellValue;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            if (userId == "")
            {
                MessageBox.Show("No data selected!");
            }
            else
            {
                clearTexts();
                enableFields();
                txtFirstName.Text = getRowValue("firstName");
                txtMiddleName.Text = getRowValue("middleName");
                txtLastName.Text = getRowValue("lastName");
                cbUserRole.Text = getRowValue("user_role");

                btnSave.Text = "UPDATE";
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearTexts();
            enableFields();
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            clearTexts();
            disableFields();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if(userId == null)
            {
                MessageBox.Show("No data selected!");
            }else
            {
                member.clearItems();
                member.setwhereClause("user_info_id = " + userId);
                member.SetColumnUpdateRecord("user_password", getRowValue("userName"));

                member.updateRecords("user_info_tbl");

                MessageBox.Show("Reset password successfull!");
            }
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DGV_UserData.DataSource = member.searchData("user_info_tbl", " firstName like " + "'%" + txtSearch.Text + "%'" + " OR middleName like " + "'%" + txtSearch.Text + "%'" + " OR lastName like " + "'%" + txtSearch.Text + "%'" + " OR userName like " + "'%" + txtSearch.Text + "%'" + " OR user_role like " + "'%" + txtSearch.Text + "%'");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Display a message box with buttons Yes, No, and Cancel
            if (userId == "")
            {
                MessageBox.Show("No user selected");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                DataTable userList = new DataTable();
                userList = member.searchData("transactions_tbl", "cashier_id = " + userId);// Check the user's choice

                // Check the user's choice
                if (result == DialogResult.Yes)
                {
                    if (userList.Rows.Count > 0)
                    {
                        MessageBox.Show("You cannot delete this user, user was already used in transaction!");
                    }
                    else
                    {
                        member.DeleteRecords("user_info_tbl", "user_info_id = " + userId);

                        MessageBox.Show("Data deleted successfully!");
                        DGV_UserData.DataSource = member.getdata("user_info_tbl", "user_info_id");
                    }
                }
            }
        }
    }
}
