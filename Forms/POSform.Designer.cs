
namespace pos_with_points.POS
{
    partial class POSform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POSform));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtCashier = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTransactionNum = new System.Windows.Forms.TextBox();
            this.btnUsePoints = new System.Windows.Forms.Button();
            this.btnTotalSales = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCustomerPoints = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.DGV_Orders = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_variant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Orders)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "POINT OF SALES";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.Image")));
            this.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProduct.Location = new System.Drawing.Point(262, 0);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(250, 60);
            this.btnSearchProduct.TabIndex = 10;
            this.btnSearchProduct.Text = "SEARCH PRODUCT";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(1286, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(46, 60);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.White;
            this.groupBox10.Controls.Add(this.txtCashier);
            this.groupBox10.Location = new System.Drawing.Point(13, 167);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(420, 49);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Cashier";
            // 
            // txtCashier
            // 
            this.txtCashier.Location = new System.Drawing.Point(6, 22);
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.Size = new System.Drawing.Size(406, 22);
            this.txtCashier.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.txtTransactionNum);
            this.groupBox6.Location = new System.Drawing.Point(13, 8);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(418, 48);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transaction No.";
            // 
            // txtTransactionNum
            // 
            this.txtTransactionNum.Location = new System.Drawing.Point(6, 19);
            this.txtTransactionNum.Name = "txtTransactionNum";
            this.txtTransactionNum.Size = new System.Drawing.Size(403, 22);
            this.txtTransactionNum.TabIndex = 0;
            // 
            // btnUsePoints
            // 
            this.btnUsePoints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnUsePoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsePoints.Image = ((System.Drawing.Image)(resources.GetObject("btnUsePoints.Image")));
            this.btnUsePoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsePoints.Location = new System.Drawing.Point(255, 294);
            this.btnUsePoints.Name = "btnUsePoints";
            this.btnUsePoints.Size = new System.Drawing.Size(178, 51);
            this.btnUsePoints.TabIndex = 10;
            this.btnUsePoints.Text = "USE POINTS";
            this.btnUsePoints.UseVisualStyleBackColor = true;
            // 
            // btnTotalSales
            // 
            this.btnTotalSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnTotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalSales.Image = ((System.Drawing.Image)(resources.GetObject("btnTotalSales.Image")));
            this.btnTotalSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalSales.Location = new System.Drawing.Point(1030, 0);
            this.btnTotalSales.Name = "btnTotalSales";
            this.btnTotalSales.Size = new System.Drawing.Size(250, 60);
            this.btnTotalSales.TabIndex = 9;
            this.btnTotalSales.Text = "TOTAL SALES";
            this.btnTotalSales.UseVisualStyleBackColor = true;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
            this.btnNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCustomer.Location = new System.Drawing.Point(774, 0);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(250, 60);
            this.btnNewCustomer.TabIndex = 8;
            this.btnNewCustomer.Text = "NEW CUSTOMER";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(255, 223);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(178, 58);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.Text = "DISCOUNT";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.White;
            this.groupBox9.Controls.Add(this.txtTime);
            this.groupBox9.Location = new System.Drawing.Point(249, 64);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox9.Size = new System.Drawing.Size(182, 48);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(6, 19);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(165, 22);
            this.txtTime.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(518, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(250, 60);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(374, 119);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(59, 45);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.txtDate);
            this.groupBox8.Location = new System.Drawing.Point(10, 64);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(233, 48);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(6, 19);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(223, 22);
            this.txtDate.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.Location = new System.Drawing.Point(13, 473);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(420, 109);
            this.btnPay.TabIndex = 1;
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTransaction.Image")));
            this.btnNewTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTransaction.Location = new System.Drawing.Point(6, 0);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(250, 60);
            this.btnNewTransaction.TabIndex = 4;
            this.btnNewTransaction.Text = "NEW TRANSACTION";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(13, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(418, 116);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TOTAL";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(9, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(399, 62);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "9,999,999.99";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.txtCustomerPoints);
            this.groupBox4.Location = new System.Drawing.Point(296, 116);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(72, 48);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Points";
            // 
            // txtCustomerPoints
            // 
            this.txtCustomerPoints.Location = new System.Drawing.Point(6, 22);
            this.txtCustomerPoints.Name = "txtCustomerPoints";
            this.txtCustomerPoints.Size = new System.Drawing.Size(58, 22);
            this.txtCustomerPoints.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Location = new System.Drawing.Point(13, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(277, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(6, 22);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(267, 22);
            this.txtCustomerName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(13, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 58);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discount";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(9, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 32);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "9,999,999.99";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(13, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 58);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sub total";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(9, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 32);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "9,999,999.99";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnUsePoints);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox10);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.btnDiscount);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(901, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 585);
            this.panel2.TabIndex = 3;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.White;
            this.groupBox11.Controls.Add(this.DGV_Orders);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(0, 72);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(908, 585);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Orders";
            // 
            // DGV_Orders
            // 
            this.DGV_Orders.AllowUserToAddRows = false;
            this.DGV_Orders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Orders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Orders.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.product_variant,
            this.quantity,
            this.product_price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Orders.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Orders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Orders.Location = new System.Drawing.Point(3, 25);
            this.DGV_Orders.Name = "DGV_Orders";
            this.DGV_Orders.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Orders.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Orders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Orders.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_Orders.Size = new System.Drawing.Size(902, 557);
            this.DGV_Orders.TabIndex = 0;
            // 
            // product_name
            // 
            this.product_name.HeaderText = "Item";
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.product_name.Width = 500;
            // 
            // product_variant
            // 
            this.product_variant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_variant.HeaderText = "Size";
            this.product_variant.Name = "product_variant";
            this.product_variant.ReadOnly = true;
            this.product_variant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.HeaderText = "Qty";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // product_price
            // 
            this.product_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.product_price.HeaderText = "Price";
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            this.product_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSearchProduct);
            this.panel3.Controls.Add(this.btnTotalSales);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.btnNewCustomer);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Controls.Add(this.btnNewTransaction);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 657);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1344, 64);
            this.panel3.TabIndex = 1;
            // 
            // POSform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 721);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "POSform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSform";
            this.Load += new System.EventHandler(this.POSform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Orders)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCustomerPoints;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTransactionNum;
        private System.Windows.Forms.Button btnTotalSales;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtCashier;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnUsePoints;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView DGV_Orders;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_variant;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
    }
}