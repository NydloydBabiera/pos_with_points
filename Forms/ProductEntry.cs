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
        public static ProductEntry instance;
        public string prodSelected { get; set; }

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
                    this.txtDescription.Text = prodDialog.prodSelect;
                }
            }


        }


    }
}
