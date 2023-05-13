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
using pos_with_points.ProductEntryForm;

namespace pos_with_points.productDialogform
{
    public partial class productDialog : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string prodSelect { get; set; }

        public productDialog()
        {
            InitializeComponent();
        }

        private void productDialog_Load(object sender, EventArgs e)
        {
            DG_Product.AutoGenerateColumns = false;
            DG_Product.DataSource = member.getdata("product_tbl", "product_id");
        }

        private String getRowValue(string colName)
        {
            int selectedrowindex = DG_Product.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DG_Product.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[colName].Value);
            return cellValue;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            prodSelect = getRowValue("product_id");

            if(prodSelect == "")
            {
                MessageBox.Show("No product selected!");
            }
            else{
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }

        }
    }
}
