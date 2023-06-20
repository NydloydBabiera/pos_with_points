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

namespace pos_with_points.lowStock
{
    public partial class lowStockDialog : Form
    {
        // Example data
        List<string> data = new List<string>();
        DatabaseClass member = new DatabaseClass();

        public lowStockDialog()
        {
            InitializeComponent();
        }

        private void lowStockDialog_Load(object sender, EventArgs e)
        {
            DataTable prodList = new DataTable();
            prodList = member.searchData("product_tbl", "quantity <= 5");// Check the user's choice

            foreach (DataRow row in prodList.Rows)
            {
                // Assuming you want to retrieve the value from the "ColumnName" column
                string columnValue = row["product_name"].ToString();
                string prod_variant = row["product_variant"].ToString();
                string qty = row["quantity"].ToString();
                data.Add(columnValue + " " + prod_variant + " " + qty);
            }

            if (data.Count == 0)
            {
                label1.Text = "No product/s low in stock";
                listBox1.Hide();
            }
            else
            {
                foreach (string item in data)
                {
                    listBox1.Items.Add(item);
                }
            }

            

            //string message = string.Join(Environment.NewLine, data);

            //MessageBox.Show(message, "List Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
