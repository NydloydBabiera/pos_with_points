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

namespace pos_with_points.ProductRegistrationForm
{
    public partial class ProductRegistration : Form
    {
        DatabaseClass member = new DatabaseClass();
        Boolean isEdit = false;
        string prod_id = "";


        public ProductRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                member.clearItems();
                member.setwhereClause("product_id = " + prod_id);
                member.SetColumnUpdateRecord("product_name", txtProductName.Text);
                member.SetColumnUpdateRecord("product_variant", txtVariant.Text);
                member.SetColumnUpdateRecord("product_desc", txtDescription.Text);
                member.SetColumnUpdateRecord("is_active", cbActive.Text == "AVAILABLE" ? "TRUE" : "FALSE");
                member.SetColumnUpdateRecord("product_price", txtPrice.Text);
                member.SetColumnUpdateRecord("quantity", txtQty.Text);

                member.updateRecords("product_tbl");

                MessageBox.Show("Update successfull!");

            }
            else
            {
                member.clearItems();
                member.setColumn("product_name");
                member.setColumn("product_variant");
                member.setColumn("product_desc");
                member.setColumn("is_active");
                member.setColumn("product_price");
                member.setColumn("quantity");

                member.setValues(txtProductName.Text);
                member.setValues(txtVariant.Text);
                member.setValues(txtDescription.Text);
                member.setValues(cbActive.Text == "AVAILABLE" ? "TRUE" : "FALSE");
                member.setValues(txtPrice.Text);
                member.setValues(txtQty.Text);

                member.AddRecord("product_tbl");

                MessageBox.Show("Product Saved!");
            }
            

            DG_Product.DataSource = member.getProddata("product_tbl", "product_id");
            disableFields();
        }

        private void ProductRegistration_Load(object sender, EventArgs e)
        {
            DG_Product.AutoGenerateColumns = false;
            DG_Product.DataSource = member.getProddata("product_tbl", "product_id");
            disableFields();

        }

        private void DG_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = DG_Product.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DG_Product.Rows[selectedrowindex];
            prod_id = Convert.ToString(selectedRow.Cells["product_id"].Value);

        }

        private String getRowValue(string colName)
        {
            int selectedrowindex = DG_Product.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DG_Product.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[colName].Value);
            return cellValue;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            if(prod_id == "")
            {
                MessageBox.Show("No data selected!");
            }
            else
            {
                txtProductName.Text = getRowValue("product_name");
                txtVariant.Text = getRowValue("product_variant");
                txtDescription.Text = getRowValue("product_desc");
                cbActive.Text = getRowValue("is_active") != "TRUE" ? "AVAILABLE" : "NOT AVAILABLE";
                txtPrice.Text = getRowValue("product_price");
                txtQty.Text = getRowValue("quantity");

                enableFields();
                btnSave.Text = "UPDATE";
            }
            

        }
        
        private void clearTexts()
        {
            txtProductName.Text = "";
            txtVariant.Text = "";
            txtDescription.Text = "";
            cbActive.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
        }
        private void disableFields()
        {
            txtProductName.Enabled = false;
            txtVariant.Enabled = false;
            txtDescription.Enabled = false;
            cbActive.Enabled = false;
            txtPrice.Enabled = false;
            txtQty.Enabled = false;
        }
        private void enableFields()
        {
            txtProductName.Enabled = true;
            txtVariant.Enabled = true;
            txtDescription.Enabled = true;
            cbActive.Enabled = true;
            txtPrice.Enabled = true;
            txtQty.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableFields();
            clearTexts();
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            clearTexts();
            disableFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          DG_Product.DataSource =  member.searchData("product_tbl", " product_name like " + "'%" + txtSearch.Text + "%'" + " OR product_desc like " + "'%" + txtSearch.Text + "%'" + " OR product_variant like " + "'%" + txtSearch.Text + "%'" + " OR product_price like " + "'%" + txtSearch.Text + "%'");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Display a message box with buttons Yes, No, and Cancel

            // Check the user's choice
            if (prod_id == "")
            {
                MessageBox.Show("No product selected");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo);
                DataTable prodList = new DataTable();
                prodList = member.searchData("transactions_line_tbl", "product_id = " + prod_id);// Check the user's choice
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(prodList.Rows.Count.ToString());
                    if (prodList.Rows.Count > 0)
                    {
                        MessageBox.Show("You cannot delete this product, product was already used in transaction!");
                    }
                    else
                    {
                        member.DeleteRecords("product_tbl", "product_id = " + prod_id);

                        MessageBox.Show("Data deleted successfully!");
                        DG_Product.DataSource = member.getProddata("product_tbl", "product_id");
                    }
                }
            }

        }
    }
}
