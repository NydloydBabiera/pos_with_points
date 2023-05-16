
namespace pos_with_points.ListProductItem
{
    partial class ListProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblVariant = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblProdName
            // 
            this.lblProdName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(94, 4);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(171, 23);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "Okinawa Milktea";
            // 
            // lblVariant
            // 
            this.lblVariant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariant.Location = new System.Drawing.Point(94, 38);
            this.lblVariant.Name = "lblVariant";
            this.lblVariant.Size = new System.Drawing.Size(171, 22);
            this.lblVariant.TabIndex = 2;
            this.lblVariant.Text = "Medium";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(271, 4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 57);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "105";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblVariant);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListProducts";
            this.Size = new System.Drawing.Size(345, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblVariant;
        private System.Windows.Forms.Label lblPrice;
    }
}
