using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pos_with_points.CustomerForm;
using pos_with_points.Classes;
using pos_with_points.Login;
using pos_with_points.ListProductItem;
using pos_with_points.CustomerDialogForm;


namespace pos_with_points.POS
{
    public partial class POSform : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string userId { get; set; }
        public string customerId { get; set; }
        string transNum = "";
        


        public POSform()
        {
            InitializeComponent();
        }

        private void POSform_Load(object sender, EventArgs e)
        {
           
            //  txtCashier.Text = member.get_value("user_info_tbl", "CONCAT(firstName, ' ' , middleName, ' ', lastName)", " user_info_id = " +  userId );
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.ShowDialog();
        }

        private void populateProductList(string prodDesc)
        {
            //requery product details using product description
            String prodCount = member.get_value("product_tbl", "count(product_id)", " CONVERT(VARCHAR,product_desc) = " + "'" + prodDesc + "'");
            String prodName = member.get_value("product_tbl", "product_name", " CONVERT(VARCHAR,product_desc) =  " + "'" + prodDesc + "'");
            String prodVariant = member.get_value("product_tbl", "product_variant", " CONVERT(VARCHAR,product_desc) = " + "'" + prodDesc + "'");
            String prodAmt = member.get_value("product_tbl", "product_price", " CONVERT(VARCHAR,product_desc) = " + "'" + prodDesc + "'");
            prodLayoutPanel.Controls.Clear();
            ListProducts[] listProducts = new ListProducts[Int32.Parse(prodCount)];

            for (int x = 0; x < listProducts.Length; x++)
            {
                //get value of products
                listProducts[x] = new ListProducts();
                listProducts[x].prodName = prodName;
                listProducts[x].prodVariant = prodVariant;
                listProducts[x].prodPrice = prodAmt;

                //add products in flow layout panel namely prodLayoutPanel
                if (prodLayoutPanel.Controls.Count < 0)
                {
                    prodLayoutPanel.Controls.Clear();
                }
                else
                {
                   
                    prodLayoutPanel.Controls.Add(listProducts[x]);

                }
            }
        }

        private void btnMkteaBarista_Click(object sender, EventArgs e)
        {
            populateProductList(btnMkteaBarista.Text);

        }

        private void btnFruitAuLait_Click(object sender, EventArgs e)
        {
            populateProductList(btnFruitAuLait.Text);
        }

        private void btnFruitTea_Click(object sender, EventArgs e)
        {
            populateProductList(btnFruitTea.Text);
        }

        private void btnPremFlavor_Click(object sender, EventArgs e)
        {
            populateProductList(btnPremFlavor.Text);
        }

        private void btnPeppermntSeries_Click(object sender, EventArgs e)
        {
            populateProductList(btnPeppermntSeries.Text);
        }

        private void btnNewFlavors_Click(object sender, EventArgs e)
        {
            populateProductList(btnNewFlavors.Text);
        }

        private void btnAddons_Click(object sender, EventArgs e)
        {
            populateProductList(btnAddons.Text);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            populateCustomer();
        }


        private void populateTransactionNum()
        {
            transNum = member.getDataNoCondition("transactions_tbl", "COUNT(transaction_id)");
            int currTransNum = Int32.Parse(transNum) + 1;
            int counter = currTransNum.ToString("D").Length + 9;
            txtTransactionNum.Text = currTransNum.ToString("D" + counter.ToString()); //

        }


        private void populateCustomer()
        {
            using (CustomerDialog customerDialog = new CustomerDialog())
            {
                if (customerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.txtCustomerName.Text = member.get_value("customer_data_tbl", "CONCAT(firstName, ' ' , middleName, ' ', lastName)", "customer_id = " + customerDialog.customerSelect);
                    this.txtCustomerPoints.Text = member.get_value("customer_data_tbl", "customer_points", "customer_ids = " + customerDialog.customerSelect);
                    this.customerId = customerDialog.customerSelect;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            populateTransactionNum();
        }
    }
}
