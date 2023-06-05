using pos_with_points.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_with_points.QuantityStock
{
    public partial class QuantityStockDialog : Form
    {
        public string prodId { set; get; }
        public string prodDetails { set; get; }
        public string prodStocks { set; get; }
        public string desiredStocks { set; get; }
        DatabaseClass member = new DatabaseClass();
        public QuantityStockDialog()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QuantityStockDialog_Load(object sender, EventArgs e)
        {
            lblProduct.Text = "Product: " + prodDetails;
            lblStock.Text = member.get_value("product_tbl", "quantity", "product_id = " + prodId);
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("No quantity entered");
            }
            else if (Int32.Parse(txtQuantity.Text) > Int32.Parse(lblStock.Text))
            {
                MessageBox.Show("Stocks are not enough");
            }
            else
            {
                desiredStocks = txtQuantity.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
