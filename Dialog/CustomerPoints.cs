using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_with_points.CustomerPointsDialog
{
    public partial class CustomerPoints : Form
    {
        public string customerPoints { get; set; }
        public string customerName { get; set; }
        public string customerDesire { get; set; }
        public CustomerPoints()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtPointsDesire.Text == "")
            {
                MessageBox.Show("No points entered!");
            }
            else if (int.Parse(txtPointsDesire.Text) > int.Parse(lblPoints.Text))
            {
                MessageBox.Show("Not enough points desired!");
            }
            else
            {
                customerDesire = txtPointsDesire.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void CustomerPoints_Load(object sender, EventArgs e)
        {
            lblCustomer.Text = "Customer Code:" + customerName;
            lblPoints.Text = customerPoints;
        }

        private void btnCance_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
