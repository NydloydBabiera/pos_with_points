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

namespace pos_with_points.CustomerDialogForm
{
    public partial class CustomerDialog : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string customerSelect { get; set; }

        public CustomerDialog()
        {
            InitializeComponent();
        }

        private void CustomerDialog_Load(object sender, EventArgs e)
        {
            DGV_Customer.AutoGenerateColumns = false;
            DGV_Customer.DataSource = member.getdata("customer_data_tbl", "customer_id");

        }

        private String getRowValue(string colName)
        {
            int selectedrowindex = DGV_Customer.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DGV_Customer.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[colName].Value);
            return cellValue;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            customerSelect = getRowValue("customer_id");

            if (customerSelect == "")
            {
                MessageBox.Show("No customer selected!");
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            customerSelect = "";
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DGV_Customer.DataSource = member.searchData("customer_data_tbl", " firstName like " + "'%" + textBox1.Text + "%'" + " OR middleName like " + "'%" + textBox1.Text + "%'" + " OR lastName like " + "'%" + textBox1.Text + "%'" + " OR customer_address like " + "'%" + textBox1.Text + "%'");
        }
    }
}
