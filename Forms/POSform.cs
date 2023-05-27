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
using pos_with_points.GetProductDialog;


namespace pos_with_points.POS
{
    public partial class POSform : Form
    {
        DatabaseClass member = new DatabaseClass();
        public string userId { get; set; }
        string transNum = "";
        string customerSelected = "";


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
                        this.txtCustomerName.Text = member.get_value("customer_data_tbl", "CONCAT(firstName, ' ' , middleName, ' ', lastName)", "customer_id = " + customerDialog.customerSelect);
                        this.txtCustomerPoints.Text = member.get_value("customer_data_tbl", "customer_points", "customer_id = " + customerDialog.customerSelect);
                        this.customerSelected = customerDialog.customerSelect;
                    }
                  
                }
            }
        }

        private void getProducts()
        {
            getProductDialog dialogForm = new getProductDialog();
            DialogResult result = dialogForm.ShowDialog();
           

            if (result == System.Windows.Forms.DialogResult.OK)
            {
               
                DataGridView selectedDataGridView = dialogForm.SelectedDataGridView;
                MessageBox.Show(selectedDataGridView.Rows.ToString());
                // Set the retrieved DataGridView as the data source of the target DataGridView
                DGV_Orders.DataSource = selectedDataGridView.DataSource;
               DisplayDataInMainForm(selectedDataGridView);
            }
            
        }
        public void DisplayDataInMainForm(DataGridView selectedDataGridView)
        {
            DGV_Orders.DataSource = selectedDataGridView.DataSource;
        }

        public void LoadData(DataGridView sourceDataGridView)
        {
            DGV_Orders.DataSource = sourceDataGridView.DataSource;
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            populateTransactionNum();
            populateCustomer();
        }


        private void DGV_ProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            MessageBox.Show("product selected");
            // Clear existing rows in the destinationGrid
           // DGV_Orders.Rows.Clear();

            // Iterate over the selected rows in the sourceGrid
            //foreach (DataGridViewRow row in DGV_ProductList.SelectedRows)
            //{
            //    // Extract the data from the selected row
            //    object[] rowData = new object[row.Cells.Count];
            //    for (int i = 0; i < row.Cells.Count; i++)
            //    {
            //        if(i == 2)
            //        {
            //            rowData[i] = 1;
            //        }else if(i == 0)
            //        {
            //            rowData[i] = row.Cells[i + 1].Value;
            //        }else if(i == 1)
            //        {
            //            rowData[i] = row.Cells[i + 1].Value;
            //        }
            //        else
            //        {
            //            rowData[i] = row.Cells[i].Value;
            //        }
                    
            //    }

            //    // Add the data to the destinationGrid
            //    DGV_Orders.Rows.Add(rowData);
            //}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            getProducts();
        }

       
        //private string getProdDetails(string columnName)
        //{
        //    int selectedrowindex = DGV_ProductList.SelectedCells[0].RowIndex;
        //    DataGridViewRow selectedRow = DGV_ProductList.Rows[selectedrowindex];
        //    return Convert.ToString(selectedRow.Cells[columnName].Value);
        //}

    }
}

