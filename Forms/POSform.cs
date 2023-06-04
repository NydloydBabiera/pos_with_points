using System;
using System.Numerics;
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
using pos_with_points.GetProductDialog;
using CrystalDecisions.CrystalReports.Engine;
using pos_with_points.ReceiptReportForm;
using pos_with_points.SalesReportForm;
using pos_with_points.CustomerPointsDialog;
using pos_with_points.QuantityStock;

namespace pos_with_points.POS
{
    public partial class POSform : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string userId { get; set; }
        string transNum = "";
        string customerSelected = "";
        float totalAmt = 0;
        float subTotal = 0;
        float ptsDiscount = 0;
        float capDiscount = 0;
        float discountTotal = 0;
        float prodPrice = 0;
        //object[] prodIds = new object[0];
        List<String> prodIds = new List<String>();
        int addCustPts = 0;
        int lessCustPts = 0;
        string transId = "";
        int getEditedCell = 0;

        public POSform()
        {
            InitializeComponent();
        }

        private void POSform_Load(object sender, EventArgs e)
        {
            if (userId != null)
            {
                txtCashier.Text = member.get_value("user_info_tbl", "firstName + ' ' + middleName + ' ' + lastName", " user_info_id = " + userId);
            }
            else
            {
                txtCashier.Text = "ADMIN";
            }
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
                    if (customerDialog.customerSelect == "")
                    {
                        txtCustomerName.Text = "WALKIN CUSTOMER";
                    }
                    else
                    {
                        this.txtCustomerName.Text = member.get_value("customer_data_tbl", "customer_id", "customer_id = " + customerDialog.customerSelect).PadLeft(6, '0'); ;
                        this.txtCustomerPoints.Text = member.get_value("customer_data_tbl", "customer_points", "customer_id = " + customerDialog.customerSelect);
                        this.customerSelected = customerDialog.customerSelect;
                    }
                  
                }
            }
        }

        private void getProducts()
        {
            getProductDialog dialogForm = new getProductDialog();
            dialogForm.ShowDialog();

            List<DataGridViewRow> selectedData = dialogForm.GetSelectedData();

           // DGV_Orders.Rows.Clear();

            
            foreach (DataGridViewRow row in selectedData)
            {
         
                object[] rowData = new object[row.Cells.Count];
                prodIds.Capacity = row.Cells.Count;
                for (int x = 0; x < row.Cells.Count; x++)
                {
                    if (x == 0)
                    {
                        prodIds.Add(row.Cells[x].Value.ToString());
                        rowData[x] = row.Cells[x + 1].Value;
                    }
                    else if (x == 1)
                    {
                        rowData[x] = row.Cells[x + 1].Value;
                    }
                    else if (x == 2)
                    {
                        rowData[x] = 1;
                    }
                    else
                    {
                        rowData[x] = row.Cells[x].Value;
                        prodPrice += float.Parse(row.Cells[x].Value.ToString());
                        computeTotal();
                    }

                }
                DGV_Orders.Rows.Add(rowData);
            }
           


        }

        private void computeTotal()
        {
            subTotal = prodPrice;

            if(capDiscount > 0)
            {
                discountTotal = subTotal * capDiscount;
            }
            else
            {
                discountTotal = 0;
            }
            
            totalAmt = subTotal - discountTotal - ptsDiscount;

            txtSubTotal.Text = subTotal.ToString();
            txtTotal.Text = totalAmt.ToString();
        }



        public void LoadData(DataGridView sourceDataGridView)
        {
            DGV_Orders.DataSource = sourceDataGridView.DataSource;
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            DGV_Orders.Rows.Clear();
            txtCustomerName.Text = "";
            txtCustomerPoints.Text = "";
            customerSelected = "";
            txtAmtRendered.Text = "0.00";
            txtChange.Text = "0.00";
            prodPrice = 0;
            transId = "";
            prodIds.Clear();
            populateTransactionNum();
            populateCustomer();
            computeTotal();
           
        }


        private void DGV_ProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            MessageBox.Show("product selected");
          
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            //this.Close();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            getProducts();
        }

        private void cbxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbxDiscount_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxDiscount.Text != "None")
            {
                capDiscount = 0.20F;
            }
            else
            {
                capDiscount = 0F;
            }
            computeTotal();
        }

        private void btnUsePoints_Click(object sender, EventArgs e)
        {
            if (customerSelected == "")
            {
                MessageBox.Show("No customer selected");
            }
            else
            {
                using (CustomerPoints customerPoints = new CustomerPoints())
                {
                    customerPoints.customerName = txtCustomerName.Text;
                    customerPoints.customerPoints = txtCustomerPoints.Text;
                    if (customerPoints.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.txtPointsDiscount.Text = customerPoints.customerDesire;
                        ptsDiscount = float.Parse(customerPoints.customerDesire);
                        computeTotal();
                    }
                }
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (restrictions())
            {
                saveHeader();
                saveLine();
                lessPointsCustomer();
                addPointsCustomer();
                computeChange();
                MessageBox.Show("saved!");
                //ReceiptForm receiptForm = new ReceiptForm();
                //receiptForm.transactionId = transId;
                //receiptForm.ShowDialog();
            }

        }

        private void computeChange()
        {
            float pmtChange = float.Parse(txtAmtRendered.Text) - float.Parse(txtTotal.Text);
            txtChange.Text = pmtChange.ToString("F2");
        }

        private void saveHeader()
        {
            //save header in transactions table
            member.clearItems();
            member.setColumn("transaction_code");
            member.setColumn("customer_id");
            member.setColumn("cashier_id");
            member.setColumn("total_amount");
            member.setColumn("payment_type");
            member.setColumn("transaction_date");
            member.setColumn("discountType");
            member.setColumn("points_used");
            member.setColumn("amt_rendered");

            member.setValues(txtTransactionNum.Text);
            member.setValues("@" + customerSelected);
            member.setValues( "@" + userId);
            member.setValues(txtTotal.Text);
            member.setValues("CASH");
            member.setValues(txtDate.Text);
            member.setValues(cbxDiscount.Text);
            member.setValues("@" + txtPointsDiscount.Text);
            member.setValues(txtAmtRendered.Text);

            member.AddRecord("transactions_tbl");

        }

        private void saveLine()
        {
           for (int x = 0; x < DGV_Orders.Rows.Count; x++)
            {

                 transId = member.get_value("transactions_tbl", "transaction_id", "transaction_code = " + txtTransactionNum.Text);
                member.clearItems();
                member.setColumn("transaction_id");
                member.setColumn("product_id");
                member.setColumn("quantity");
                member.setColumn("amount");

                member.setValues("@" + transId);
                member.setValues("@" + prodIds[x]);
                member.setValues(DGV_Orders.Rows[x].Cells[2].Value.ToString());
                member.setValues(DGV_Orders.Rows[x].Cells[3].Value.ToString());

                member.AddRecord("transactions_line_tbl");

                lessProdStock(DGV_Orders.Rows[x].Cells[2].Value.ToString(), prodIds[x]);

            }

        }

        private void lessProdStock(String quantity, String prodId)
        {
            string getProdStock = member.get_value("product_tbl", "quantity", "product_id = " + prodId);
            int stockRemains = Int32.Parse(getProdStock) - Int32.Parse(quantity);
            member.clearItems();
            member.setwhereClause("product_id = " + prodId);
            member.SetColumnUpdateRecord("quantity", stockRemains.ToString());

            member.updateRecords("product_tbl");

        }

        private void addPointsCustomer()
        {
            addCustPts = Int32.Parse(txtCustomerPoints.Text) + 1;
            member.clearItems();
            member.setwhereClause("customer_id = " + customerSelected);
            member.SetColumnUpdateRecord("customer_points", addCustPts.ToString());

            member.updateRecords("customer_data_tbl");

           // txtCustomerName.Text = member.get_value("customer_data_tbl", "CONCAT(firstName, ' ' , middleName, ' ', lastName)", "customer_id = " + customerSelected);
            txtCustomerPoints.Text = member.get_value("customer_data_tbl", "customer_points", "customer_id = " + customerSelected);
        }

        private void lessPointsCustomer()
        {
            lessCustPts = Int32.Parse(txtCustomerPoints.Text) - Int32.Parse(txtPointsDiscount.Text);
            member.clearItems();
            member.setwhereClause("customer_id = " + customerSelected);
            member.SetColumnUpdateRecord("customer_points", lessCustPts.ToString());

            member.updateRecords("customer_data_tbl");

            // txtCustomerName.Text = member.get_value("customer_data_tbl", "CONCAT(firstName, ' ' , middleName, ' ', lastName)", "customer_id = " + customerSelected);
            txtCustomerPoints.Text = member.get_value("customer_data_tbl", "customer_points", "customer_id = " + customerSelected);
        }

        private String getRowValue(string colName)
        {
            int selectedrowindex = DGV_Orders.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DGV_Orders.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells[colName].Value);
            return cellValue;
        }

        private bool restrictions()
        {
            bool istrue = true;
            if (txtTransactionNum.Text == "")
            {
                MessageBox.Show("No transaction found");
                istrue = false;
            }
            else if (DGV_Orders.Rows.Count == 0)
            {
                MessageBox.Show("No product selected");
                istrue = false;
            }
            else if (txtAmtRendered.Text == "0" || txtAmtRendered.Text == "0.00")
            {
                MessageBox.Show("No amount entered");
                istrue = false;
            }
            else if (cbxDiscount.Text == "")
            {
                MessageBox.Show("No discount selected");
                istrue = false ;
            }
            else if (transId != "")
            {
                MessageBox.Show("Transaction already done!");
                istrue = false;
            }
            else if (float.Parse(txtAmtRendered.Text) < float.Parse(txtTotal.Text))
            {
                MessageBox.Show("AMOUNT TENDERED is less than TOTAL amount!");
                istrue = false;
            }


            return istrue;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.transactionId = transId;
            receiptForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTotalSales_Click(object sender, EventArgs e)
        {
            SalesReportViewer salesReport = new SalesReportViewer();
            salesReport.ShowDialog();
        }

        private void DGV_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Orders_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //QuantityStockDialog quantityStockDialog = new QuantityStockDialog();
            //foreach (DataGridViewRow row in DGV_Orders.SelectedRows)
            //{
            //    quantityStockDialog.prodDetails = row.Cells[0].Value.ToString() + " -  " + row.Cells[1].Value.ToString();
            //    quantityStockDialog.prodId = prodIds[row.Index];

            //    if (quantityStockDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        row.Cells[3].Value = quantityStockDialog.desiredStocks;

            //        double lineTotal = 0;
            //        lineTotal = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
            //        DGV_Orders.Rows[e.RowIndex].Cells["product_price"].Value = lineTotal;
            //        computeTotal();
            //    }
            //}
            //quantityStockDialog.Show();
            //prodPrice = 0;
            //var row = DGV_Orders.Rows[DGV_Orders.CurrentCell.RowIndex];
            //double lineTotal = 0;
            //    lineTotal = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
            //    DGV_Orders.Rows[e.RowIndex].Cells["product_price"].Value = lineTotal;

            //foreach (DataGridViewRow rows in DGV_Orders.Rows)
            //{
            //    prodPrice += float.Parse(rows.Cells[3].Value.ToString());
            //    computeTotal();
            //}
        }

        private void DGV_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void DGV_Orders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            prodPrice = 0;
            QuantityStockDialog quantityStockDialog = new QuantityStockDialog();
            foreach (DataGridViewRow row in DGV_Orders.SelectedRows)
            {
                quantityStockDialog.prodDetails = row.Cells[0].Value.ToString() + " -  " + row.Cells[1].Value.ToString();
                quantityStockDialog.prodId = prodIds[row.Index];

                if (quantityStockDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    row.Cells[2].Value = quantityStockDialog.desiredStocks;

                    double lineTotal = 0;
                    lineTotal = Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                    DGV_Orders.Rows[e.RowIndex].Cells["product_price"].Value = lineTotal;
                }
            }
            foreach (DataGridViewRow rows in DGV_Orders.Rows)
            {
                prodPrice += float.Parse(rows.Cells[3].Value.ToString());
                computeTotal();
            }
            quantityStockDialog.Show();
            btnSearchProduct.Focus();
        }
    }
}

