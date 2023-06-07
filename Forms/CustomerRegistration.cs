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

namespace pos_with_points.CustomerForm
{
    public partial class CustomerRegistration : Form
    {
        DatabaseClass member = new DatabaseClass();
        Boolean isEdit = false;
        string customerId = "";
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {
            DGV_CustomerData.AutoGenerateColumns = false;
            DGV_CustomerData.DataSource = member.getdata("customer_data_tbl", "customer_id");
            disableFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                member.clearItems();
                member.setwhereClause("customer_id = " + customerId);
                member.SetColumnUpdateRecord("firstName", txtFirstName.Text);
                member.SetColumnUpdateRecord("middleName", txtMiddleName.Text);
                member.SetColumnUpdateRecord("lastName", txtLastName.Text);
                member.SetColumnUpdateRecord("customer_address", txtAddress.Text);

                member.updateRecords("customer_data_tbl");

                MessageBox.Show("Update successfull!");
            }
            else
            {
                member.clearItems();
                member.setColumn("firstName");
                member.setColumn("middleName");
                member.setColumn("lastName");
                member.setColumn("customer_address");
                member.setColumn("customer_points");


                member.setValues(txtFirstName.Text);
                member.setValues(txtMiddleName.Text);
                member.setValues(txtLastName.Text);
                member.setValues(txtAddress.Text);
                member.setValues("0");

                member.AddRecord("customer_data_tbl");

                MessageBox.Show("Record Saved!");
            }
            DGV_CustomerData.DataSource = member.getdata("customer_data_tbl", "customer_id");
        }

        private String getRowValue(string colName)
        {
            int selectedrowindex = DGV_CustomerData.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DGV_CustomerData.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[colName].Value);
            return cellValue;
        }

        private void clearTexts()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
        }
        private void disableFields()
        {
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
        }
        private void enableFields()
        {
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            txtAddress.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableFields();
            clearTexts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTexts();
            disableFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            if (customerId == "")
            {
                MessageBox.Show("No data selected!");
            }
            else
            {
                enableFields();
                txtFirstName.Text = getRowValue("firstName");
                txtMiddleName.Text = getRowValue("middleName");
                txtLastName.Text = getRowValue("lastName");
                txtAddress.Text = getRowValue("customer_address");

                btnSave.Text = "UPDATE";
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            enableFields();
            clearTexts();
        }

        private void DGV_CustomerData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = DGV_CustomerData.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DGV_CustomerData.Rows[selectedrowindex];
            customerId = Convert.ToString(selectedRow.Cells["customer_id"].Value);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DGV_CustomerData.DataSource = member.searchData("customer_data_tbl", " firstName like " + "'%" + txtSearch.Text + "%'" + " OR middleName like " + "'%" + txtSearch.Text + "%'" + " OR lastName like " + "'%" + txtSearch.Text + "%'" + " OR customer_address like " + "'%" + txtSearch.Text + "%'");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //// Display a message box with buttons Yes, No, and Cancel
            //DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);

            //// Check the user's choice
            //if (result == DialogResult.Yes)
            //{
            //    member.DeleteRecords("customer_data_tbl", "customer_id = " + customerId);

            //    MessageBox.Show("Data deleted successfully!");
            //    DGV_CustomerData.DataSource = member.getdata("customer_data_tbl", "customer_id");
            //}

            if (customerId == "")
            {
                MessageBox.Show("No user selected");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                DataTable custrList = new DataTable();
                custrList = member.searchData("transactions_tbl", "customer_id = " + customerId);// Check the user's choice

                // Check the user's choice
                if (result == DialogResult.Yes)
                {
                    if (custrList.Rows.Count > 0)
                    {
                        MessageBox.Show("You cannot delete this user, user was already used in transaction!");
                    }
                    else
                    {
                        member.DeleteRecords("customer_data_tbl", "customer_id = " + customerId);

                        MessageBox.Show("Data deleted successfully!");
                        DGV_CustomerData.DataSource = member.getdata("customer_data_tbl", "customer_id");
                    }
                }
            }
        }
    }
}
