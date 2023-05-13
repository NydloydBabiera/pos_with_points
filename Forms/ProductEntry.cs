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
using pos_with_points.productDialogform;

namespace pos_with_points.ProductEntryForm
{
    public partial class ProductEntry : Form
    {
        DatabaseClass member = new DatabaseClass();
        public static ProductEntry instance;
        public string prodSelected { get; set; }
        public string prodIdSelected = "";

        public ProductEntry()
        {
            InitializeComponent();
            //instance = this;
        }

        private void ProductEntry_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            using (productDialog prodDialog = new productDialog())
            {
                if (prodDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtProductName.Text = member.get_value("product_tbl", "product_name", "product_id = " + prodDialog.prodSelect);
                    this.txtDescription.Text = member.get_value("product_tbl", "product_variant", "product_id = " + prodDialog.prodSelect);
                    this.prodIdSelected = prodDialog.prodSelect;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dateTimeEntryDate.Format = DateTimePickerFormat.Custom;
            dateTimeEntryDate.CustomFormat = "yyyy-MM-dd";

            member.clearItems();
            member.setColumn("product_id");
            member.setColumn("entry_date");
            member.setColumn("quantity");

            member.setValues(prodIdSelected);
            member.setValues(dateTimeEntryDate.Text);
            member.setValues(txtQuantity.Text);

            member.AddRecord("product_inventory_tbl");

            MessageBox.Show("Product added!");
        }
    }
}
