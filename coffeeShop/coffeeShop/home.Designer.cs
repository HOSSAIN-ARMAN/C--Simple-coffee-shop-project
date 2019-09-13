namespace coffeeShop
{
    partial class home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmButtonByCustomer = new System.Windows.Forms.Button();
            this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderItemComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerAddressTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerContactTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerOrderInvoiceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmButtonByCustomer);
            this.groupBox1.Controls.Add(this.orderQuantityTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.orderItemComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.customerAddressTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.customerContactTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(93, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // confirmButtonByCustomer
            // 
            this.confirmButtonByCustomer.Location = new System.Drawing.Point(144, 298);
            this.confirmButtonByCustomer.Name = "confirmButtonByCustomer";
            this.confirmButtonByCustomer.Size = new System.Drawing.Size(147, 23);
            this.confirmButtonByCustomer.TabIndex = 10;
            this.confirmButtonByCustomer.Text = "Save";
            this.confirmButtonByCustomer.UseVisualStyleBackColor = true;
            this.confirmButtonByCustomer.Click += new System.EventHandler(this.ConfirmButtonByCustomer_Click);
            // 
            // orderQuantityTextBox
            // 
            this.orderQuantityTextBox.Location = new System.Drawing.Point(144, 224);
            this.orderQuantityTextBox.Name = "orderQuantityTextBox";
            this.orderQuantityTextBox.Size = new System.Drawing.Size(147, 20);
            this.orderQuantityTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // orderItemComboBox
            // 
            this.orderItemComboBox.FormattingEnabled = true;
            this.orderItemComboBox.Items.AddRange(new object[] {
            "-----SELECT-ITEM------",
            "Black-120",
            "Cold-100",
            "Hot-90",
            "Regular-80"});
            this.orderItemComboBox.Location = new System.Drawing.Point(144, 163);
            this.orderItemComboBox.Name = "orderItemComboBox";
            this.orderItemComboBox.Size = new System.Drawing.Size(147, 21);
            this.orderItemComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order";
            // 
            // customerAddressTxtBox
            // 
            this.customerAddressTxtBox.Location = new System.Drawing.Point(144, 128);
            this.customerAddressTxtBox.Name = "customerAddressTxtBox";
            this.customerAddressTxtBox.Size = new System.Drawing.Size(147, 20);
            this.customerAddressTxtBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // customerContactTextBox
            // 
            this.customerContactTextBox.Location = new System.Drawing.Point(144, 88);
            this.customerContactTextBox.Name = "customerContactTextBox";
            this.customerContactTextBox.Size = new System.Drawing.Size(147, 20);
            this.customerContactTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact No";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(144, 52);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // customerOrderInvoiceRichTextBox
            // 
            this.customerOrderInvoiceRichTextBox.Location = new System.Drawing.Point(499, 84);
            this.customerOrderInvoiceRichTextBox.Name = "customerOrderInvoiceRichTextBox";
            this.customerOrderInvoiceRichTextBox.Size = new System.Drawing.Size(185, 269);
            this.customerOrderInvoiceRichTextBox.TabIndex = 1;
            this.customerOrderInvoiceRichTextBox.Text = "";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerOrderInvoiceRichTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "home";
            this.Text = "home";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button confirmButtonByCustomer;
        private System.Windows.Forms.TextBox orderQuantityTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox orderItemComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerAddressTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerContactTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox customerOrderInvoiceRichTextBox;
    }
}

