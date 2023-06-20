using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_with_points.notrificationForm

{
    public partial class notificationDialog : Form
    {
        private int x, y;
        public notificationDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            this.Close();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
         
            switch (this.action)
            {
                case enAction.wait:
                    timer1.Interval = 5000;
                    action = enAction.close;
                    break;
                case enAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        //MessageBox.Show("reached here");
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enAction.wait;
                        }
                    }
                    break;
                case enAction.close:
                    timer1.Interval = 1; 
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }

                    break;
            }

         
        }


        public enum enAction
        {
            wait,
            start,
            close
        }

        private notificationDialog.enAction action;


        public void showAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
               
                fname = "alert" + i.ToString();
                notificationDialog frm = (notificationDialog)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Width - this.Width * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
             
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            MessageBox.Show("this.x: " + this.x + "location.X:" + this.Location.X);
            this.label1.Text = msg;

            this.Show();
            this.action = enAction.start;
            this.timer1.Interval = 1;
            timer1.Start();

        }
    }
}
