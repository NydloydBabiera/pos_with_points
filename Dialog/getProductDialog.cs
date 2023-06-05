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

namespace pos_with_points.GetProductDialog
{
    public partial class getProductDialog : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string prodSelect { get; set; }
        //public List<String> getIds { get; set; }
        public List<String> getIds = new List<string>();
        public DataGridView SelectedDataGridView { get; private set; }
        // Define an event for data selection
        private List<string> selectedData;
        List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

        public getProductDialog()
        {
            InitializeComponent();
        }

        private void getProductDialog_Load(object sender, EventArgs e)
        {
            DG_Product.AutoGenerateColumns = false;
            DG_Product.DataSource = member.getdataRestricted("product_tbl", "quantity > 0");
        }
        
        private void txtSearchProd_TextChanged(object sender, EventArgs e)
        {
            DG_Product.DataSource = member.searchData("product_tbl", " (quantity > 0) and (product_name like " + "'%" + txtSearchProd.Text + "%'" + " OR product_desc like " + "'%" + txtSearchProd.Text + "%'" + " OR product_variant like " + "'%" + txtSearchProd.Text + "%'" + " OR product_price like " + "'%" + txtSearchProd.Text + "%')");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DG_Product.SelectedRows)
            {
                selectedRows.Add(row);
            }
            Close();
        }

        public List<DataGridViewRow> GetSelectedData()
        {
            return selectedRows;
        }
        private String getRowValue(string colName)
        {
            int selectedrowindex = DG_Product.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DG_Product.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[colName].Value);
            return cellValue;
        }
    }
}
