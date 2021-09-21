
namespace Presentation_Layer
{
    partial class FormProducts
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
            this.Nud_Price = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Description = new System.Windows.Forms.TextBox();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_New_Data = new System.Windows.Forms.TextBox();
            this.Nud_Stock = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbb_Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // Nud_Price
            // 
            this.Nud_Price.Location = new System.Drawing.Point(12, 218);
            this.Nud_Price.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Nud_Price.Name = "Nud_Price";
            this.Nud_Price.Size = new System.Drawing.Size(240, 20);
            this.Nud_Price.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Insert the price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Insert a new description:";
            // 
            // Txb_Description
            // 
            this.Txb_Description.Location = new System.Drawing.Point(12, 76);
            this.Txb_Description.Name = "Txb_Description";
            this.Txb_Description.Size = new System.Drawing.Size(240, 20);
            this.Txb_Description.TabIndex = 22;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(12, 409);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(116, 31);
            this.Btn_Register.TabIndex = 20;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Insert a new product:";
            // 
            // Txb_New_Data
            // 
            this.Txb_New_Data.Location = new System.Drawing.Point(12, 29);
            this.Txb_New_Data.Name = "Txb_New_Data";
            this.Txb_New_Data.Size = new System.Drawing.Size(240, 20);
            this.Txb_New_Data.TabIndex = 18;
            // 
            // Nud_Stock
            // 
            this.Nud_Stock.Location = new System.Drawing.Point(12, 179);
            this.Nud_Stock.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Nud_Stock.Name = "Nud_Stock";
            this.Nud_Stock.Size = new System.Drawing.Size(240, 20);
            this.Nud_Stock.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Insert the amount:";
            // 
            // Cbb_Category
            // 
            this.Cbb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_Category.FormattingEnabled = true;
            this.Cbb_Category.Location = new System.Drawing.Point(12, 139);
            this.Cbb_Category.Name = "Cbb_Category";
            this.Cbb_Category.Size = new System.Drawing.Size(121, 21);
            this.Cbb_Category.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Select the category";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbb_Category);
            this.Controls.Add(this.Nud_Stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nud_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Description);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_New_Data);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Nud_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_Description;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_New_Data;
        private System.Windows.Forms.NumericUpDown Nud_Stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbb_Category;
        private System.Windows.Forms.Label label5;
    }
}