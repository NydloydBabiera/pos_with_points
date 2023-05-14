using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_with_points.POS
{
    public partial class POSform : Form
    {
        public POSform()
        {
            InitializeComponent();
        }

        private void POSform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
