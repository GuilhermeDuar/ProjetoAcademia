
namespace Presentation_Layer
{
    partial class Form_Business
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
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_Products = new System.Windows.Forms.DataGridView();
            this.Dgv_Cart = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Gbb_Business_Service = new System.Windows.Forms.GroupBox();
            this.Nud_Product_Stock = new System.Windows.Forms.NumericUpDown();
            this.Nud_Product_Price = new System.Windows.Forms.NumericUpDown();
            this.Cbb_PM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbb_Customers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_Product_Category = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Txb_Product_Description = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Txb_Product_Name = new System.Windows.Forms.TextBox();
            this.Btn_CancelTransaction = new System.Windows.Forms.Button();
            this.Btn_RemoveFromCart = new System.Windows.Forms.Button();
            this.Btn_StartTransaction = new System.Windows.Forms.Button();
            this.Btn_AddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cart)).BeginInit();
            this.Gbb_Business_Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Product_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Product_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "All products";
            // 
            // Dgv_Products
            // 
            this.Dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Products.Location = new System.Drawing.Point(400, 42);
            this.Dgv_Products.Name = "Dgv_Products";
            this.Dgv_Products.ReadOnly = true;
            this.Dgv_Products.Size = new System.Drawing.Size(388, 226);
            this.Dgv_Products.TabIndex = 53;
            // 
            // Dgv_Cart
            // 
            this.Dgv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Cart.Location = new System.Drawing.Point(6, 42);
            this.Dgv_Cart.Name = "Dgv_Cart";
            this.Dgv_Cart.ReadOnly = true;
            this.Dgv_Cart.Size = new System.Drawing.Size(388, 92);
            this.Dgv_Cart.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Selected products";
            // 
            // Gbb_Business_Service
            // 
            this.Gbb_Business_Service.Controls.Add(this.Nud_Product_Stock);
            this.Gbb_Business_Service.Controls.Add(this.Nud_Product_Price);
            this.Gbb_Business_Service.Controls.Add(this.Cbb_PM);
            this.Gbb_Business_Service.Controls.Add(this.label6);
            this.Gbb_Business_Service.Controls.Add(this.Cbb_Customers);
            this.Gbb_Business_Service.Controls.Add(this.label3);
            this.Gbb_Business_Service.Controls.Add(this.Txb_Product_Category);
            this.Gbb_Business_Service.Controls.Add(this.label2);
            this.Gbb_Business_Service.Controls.Add(this.label4);
            this.Gbb_Business_Service.Controls.Add(this.label14);
            this.Gbb_Business_Service.Controls.Add(this.label17);
            this.Gbb_Business_Service.Controls.Add(this.Txb_Product_Description);
            this.Gbb_Business_Service.Controls.Add(this.label18);
            this.Gbb_Business_Service.Controls.Add(this.Txb_Product_Name);
            this.Gbb_Business_Service.Location = new System.Drawing.Point(6, 140);
            this.Gbb_Business_Service.Name = "Gbb_Business_Service";
            this.Gbb_Business_Service.Size = new System.Drawing.Size(382, 296);
            this.Gbb_Business_Service.TabIndex = 57;
            this.Gbb_Business_Service.TabStop = false;
            this.Gbb_Business_Service.Text = "Transaction info";
            // 
            // Nud_Product_Stock
            // 
            this.Nud_Product_Stock.Enabled = false;
            this.Nud_Product_Stock.Location = new System.Drawing.Point(6, 186);
            this.Nud_Product_Stock.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.Nud_Product_Stock.Name = "Nud_Product_Stock";
            this.Nud_Product_Stock.Size = new System.Drawing.Size(367, 20);
            this.Nud_Product_Stock.TabIndex = 54;
            // 
            // Nud_Product_Price
            // 
            this.Nud_Product_Price.Enabled = false;
            this.Nud_Product_Price.Location = new System.Drawing.Point(6, 147);
            this.Nud_Product_Price.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.Nud_Product_Price.Name = "Nud_Product_Price";
            this.Nud_Product_Price.Size = new System.Drawing.Size(367, 20);
            this.Nud_Product_Price.TabIndex = 53;
            // 
            // Cbb_PM
            // 
            this.Cbb_PM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_PM.Enabled = false;
            this.Cbb_PM.FormattingEnabled = true;
            this.Cbb_PM.Location = new System.Drawing.Point(6, 265);
            this.Cbb_PM.Name = "Cbb_PM";
            this.Cbb_PM.Size = new System.Drawing.Size(367, 21);
            this.Cbb_PM.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Payment method";
            // 
            // Cbb_Customers
            // 
            this.Cbb_Customers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_Customers.Enabled = false;
            this.Cbb_Customers.FormattingEnabled = true;
            this.Cbb_Customers.Location = new System.Drawing.Point(6, 225);
            this.Cbb_Customers.Name = "Cbb_Customers";
            this.Cbb_Customers.Size = new System.Drawing.Size(367, 21);
            this.Cbb_Customers.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer";
            // 
            // Txb_Product_Category
            // 
            this.Txb_Product_Category.Enabled = false;
            this.Txb_Product_Category.ForeColor = System.Drawing.SystemColors.Window;
            this.Txb_Product_Category.Location = new System.Drawing.Point(6, 108);
            this.Txb_Product_Category.Name = "Txb_Product_Category";
            this.Txb_Product_Category.Size = new System.Drawing.Size(367, 20);
            this.Txb_Product_Category.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Category";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Product description";
            // 
            // Txb_Product_Description
            // 
            this.Txb_Product_Description.Enabled = false;
            this.Txb_Product_Description.ForeColor = System.Drawing.SystemColors.Window;
            this.Txb_Product_Description.Location = new System.Drawing.Point(6, 69);
            this.Txb_Product_Description.MaxLength = 100;
            this.Txb_Product_Description.Multiline = true;
            this.Txb_Product_Description.Name = "Txb_Product_Description";
            this.Txb_Product_Description.Size = new System.Drawing.Size(370, 20);
            this.Txb_Product_Description.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Product name";
            // 
            // Txb_Product_Name
            // 
            this.Txb_Product_Name.Enabled = false;
            this.Txb_Product_Name.ForeColor = System.Drawing.SystemColors.Window;
            this.Txb_Product_Name.Location = new System.Drawing.Point(6, 30);
            this.Txb_Product_Name.MaxLength = 50;
            this.Txb_Product_Name.Name = "Txb_Product_Name";
            this.Txb_Product_Name.Size = new System.Drawing.Size(370, 20);
            this.Txb_Product_Name.TabIndex = 40;
            // 
            // Btn_CancelTransaction
            // 
            this.Btn_CancelTransaction.Location = new System.Drawing.Point(652, 389);
            this.Btn_CancelTransaction.Name = "Btn_CancelTransaction";
            this.Btn_CancelTransaction.Size = new System.Drawing.Size(136, 37);
            this.Btn_CancelTransaction.TabIndex = 61;
            this.Btn_CancelTransaction.Text = "Cancel Transaction";
            this.Btn_CancelTransaction.UseVisualStyleBackColor = true;
            this.Btn_CancelTransaction.Click += new System.EventHandler(this.Btn_CancelTransaction_Click);
            // 
            // Btn_RemoveFromCart
            // 
            this.Btn_RemoveFromCart.Location = new System.Drawing.Point(652, 310);
            this.Btn_RemoveFromCart.Name = "Btn_RemoveFromCart";
            this.Btn_RemoveFromCart.Size = new System.Drawing.Size(136, 36);
            this.Btn_RemoveFromCart.TabIndex = 60;
            this.Btn_RemoveFromCart.Text = "Remove from cart";
            this.Btn_RemoveFromCart.UseVisualStyleBackColor = true;
            this.Btn_RemoveFromCart.Click += new System.EventHandler(this.Btn_RemoveFromCart_Click);
            // 
            // Btn_StartTransaction
            // 
            this.Btn_StartTransaction.Location = new System.Drawing.Point(652, 349);
            this.Btn_StartTransaction.Name = "Btn_StartTransaction";
            this.Btn_StartTransaction.Size = new System.Drawing.Size(136, 37);
            this.Btn_StartTransaction.TabIndex = 59;
            this.Btn_StartTransaction.Text = "Start Transaction";
            this.Btn_StartTransaction.UseVisualStyleBackColor = true;
            this.Btn_StartTransaction.Click += new System.EventHandler(this.Btn_StartTransaction_Click);
            // 
            // Btn_AddToCart
            // 
            this.Btn_AddToCart.Location = new System.Drawing.Point(652, 271);
            this.Btn_AddToCart.Name = "Btn_AddToCart";
            this.Btn_AddToCart.Size = new System.Drawing.Size(136, 36);
            this.Btn_AddToCart.TabIndex = 58;
            this.Btn_AddToCart.Text = "Add to cart";
            this.Btn_AddToCart.UseVisualStyleBackColor = true;
            this.Btn_AddToCart.Click += new System.EventHandler(this.Btn_AddToCart_Click);
            // 
            // Form_Business
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 440);
            this.Controls.Add(this.Btn_CancelTransaction);
            this.Controls.Add(this.Btn_RemoveFromCart);
            this.Controls.Add(this.Btn_StartTransaction);
            this.Controls.Add(this.Btn_AddToCart);
            this.Controls.Add(this.Gbb_Business_Service);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Cart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Business";
            this.Text = "Form_Business";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Cart)).EndInit();
            this.Gbb_Business_Service.ResumeLayout(false);
            this.Gbb_Business_Service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Product_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Product_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_Products;
        private System.Windows.Forms.DataGridView Dgv_Cart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gbb_Business_Service;
        private System.Windows.Forms.NumericUpDown Nud_Product_Stock;
        private System.Windows.Forms.NumericUpDown Nud_Product_Price;
        private System.Windows.Forms.ComboBox Cbb_PM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbb_Customers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_Product_Category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Txb_Product_Description;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Txb_Product_Name;
        private System.Windows.Forms.Button Btn_CancelTransaction;
        private System.Windows.Forms.Button Btn_RemoveFromCart;
        private System.Windows.Forms.Button Btn_StartTransaction;
        private System.Windows.Forms.Button Btn_AddToCart;
    }
}