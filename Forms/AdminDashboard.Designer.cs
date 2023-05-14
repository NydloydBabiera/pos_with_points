
namespace pos_with_points.AdminDashboardForms
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(12, 13);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(142, 28);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(160, 13);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(142, 28);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "PRODUCTS";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(308, 13);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(142, 28);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "USER";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(456, 13);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(142, 28);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(604, 13);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(142, 28);
            this.btnPOS.TabIndex = 4;
            this.btnPOS.Text = "POINT OF SALES";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnInventory);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnPOS;
    }
}