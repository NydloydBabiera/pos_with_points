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
    }
}
