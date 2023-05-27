using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_with_points.ListProductItem
{
    public partial class ListProducts : UserControl
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        #region Properties

        private string _prodName;
        private string _prodVariant;
        private string _prodPrice;
        private string _prodId;

        [Category("Custom Props")]
        public string prodName
        {
            get { return _prodName; }
            set { _prodName = value; lblProdName.Text = value; }
        }



        [Category("Custom Props")]
        public string prodVariant
        {
            get { return _prodVariant; }
            set { _prodVariant = value; lblVariant.Text = value; }
        }


        [Category("Custom Props")]
        public string prodPrice
        {
            get { return _prodPrice; }
            set { _prodPrice = value; lblPrice.Text = value; }
        }

        [Category("Custom Props")]
        public string prodId
        {
            get { return _prodId; }
            set { _prodId = value; }
        }




        #endregion

        private void ListProducts_Load(object sender, EventArgs e)
        {
           

        }

        private void ListProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ListProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblProdName.Text + " selected");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblProdName.Text+ "["+prodId +"]" + " selected");
        }
    }
}
