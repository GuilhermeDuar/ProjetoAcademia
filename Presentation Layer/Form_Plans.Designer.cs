
namespace Presentation_Layer
{
    partial class Form_Plans
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
            this.Dgv_Customer_Plans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_All_Plans = new System.Windows.Forms.DataGridView();
            this.Txb_Plan_Modality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Plan_Description = new System.Windows.Forms.TextBox();
            this.Txb_Customer_Plan_Description = new System.Windows.Forms.TextBox();
            this.Txb_Customer_Plan_Modality = new System.Windows.Forms.TextBox();
            this.Btn_Remove_Customer_Plan = new System.Windows.Forms.Button();
            this.Btn_Add_Plan_Customer = new System.Windows.Forms.Button();
            this.Nud_Customer_Plan_Price = new System.Windows.Forms.NumericUpDown();
            this.Nud_Plan_Price = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_GoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Customer_Plans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_All_Plans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Customer_Plan_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Plan_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Customer_Plans
            // 
            this.Dgv_Customer_Plans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Customer_Plans.Location = new System.Drawing.Point(12, 264);
            this.Dgv_Customer_Plans.Name = "Dgv_Customer_Plans";
            this.Dgv_Customer_Plans.ReadOnly = true;
            this.Dgv_Customer_Plans.Size = new System.Drawing.Size(385, 126);
            this.Dgv_Customer_Plans.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registered Plans";
            // 
            // Dgv_All_Plans
            // 
            this.Dgv_All_Plans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_All_Plans.Location = new System.Drawing.Point(403, 264);
            this.Dgv_All_Plans.Name = "Dgv_All_Plans";
            this.Dgv_All_Plans.ReadOnly = true;
            this.Dgv_All_Plans.Size = new System.Drawing.Size(382, 126);
            this.Dgv_All_Plans.TabIndex = 2;
            // 
            // Txb_Plan_Modality
            // 
            this.Txb_Plan_Modality.Enabled = false;
            this.Txb_Plan_Modality.Location = new System.Drawing.Point(403, 27);
            this.Txb_Plan_Modality.Multiline = true;
            this.Txb_Plan_Modality.Name = "Txb_Plan_Modality";
            this.Txb_Plan_Modality.Size = new System.Drawing.Size(99, 20);
            this.Txb_Plan_Modality.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "All Plans";
            // 
            // Txb_Plan_Description
            // 
            this.Txb_Plan_Description.Enabled = false;
            this.Txb_Plan_Description.Location = new System.Drawing.Point(403, 73);
            this.Txb_Plan_Description.Multiline = true;
            this.Txb_Plan_Description.Name = "Txb_Plan_Description";
            this.Txb_Plan_Description.Size = new System.Drawing.Size(176, 80);
            this.Txb_Plan_Description.TabIndex = 5;
            // 
            // Txb_Customer_Plan_Description
            // 
            this.Txb_Customer_Plan_Description.Enabled = false;
            this.Txb_Customer_Plan_Description.Location = new System.Drawing.Point(12, 73);
            this.Txb_Customer_Plan_Description.Multiline = true;
            this.Txb_Customer_Plan_Description.Name = "Txb_Customer_Plan_Description";
            this.Txb_Customer_Plan_Description.Size = new System.Drawing.Size(177, 80);
            this.Txb_Customer_Plan_Description.TabIndex = 8;
            // 
            // Txb_Customer_Plan_Modality
            // 
            this.Txb_Customer_Plan_Modality.Enabled = false;
            this.Txb_Customer_Plan_Modality.Location = new System.Drawing.Point(12, 27);
            this.Txb_Customer_Plan_Modality.Multiline = true;
            this.Txb_Customer_Plan_Modality.Name = "Txb_Customer_Plan_Modality";
            this.Txb_Customer_Plan_Modality.Size = new System.Drawing.Size(100, 20);
            this.Txb_Customer_Plan_Modality.TabIndex = 7;
            // 
            // Btn_Remove_Customer_Plan
            // 
            this.Btn_Remove_Customer_Plan.Location = new System.Drawing.Point(12, 205);
            this.Btn_Remove_Customer_Plan.Name = "Btn_Remove_Customer_Plan";
            this.Btn_Remove_Customer_Plan.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remove_Customer_Plan.TabIndex = 10;
            this.Btn_Remove_Customer_Plan.Text = "Remove Plan";
            this.Btn_Remove_Customer_Plan.UseVisualStyleBackColor = true;
            this.Btn_Remove_Customer_Plan.Click += new System.EventHandler(this.Btn_Remove_Customer_Plan_Click);
            // 
            // Btn_Add_Plan_Customer
            // 
            this.Btn_Add_Plan_Customer.Location = new System.Drawing.Point(403, 205);
            this.Btn_Add_Plan_Customer.Name = "Btn_Add_Plan_Customer";
            this.Btn_Add_Plan_Customer.Size = new System.Drawing.Size(74, 23);
            this.Btn_Add_Plan_Customer.TabIndex = 11;
            this.Btn_Add_Plan_Customer.Text = "Add Plan";
            this.Btn_Add_Plan_Customer.UseVisualStyleBackColor = true;
            this.Btn_Add_Plan_Customer.Click += new System.EventHandler(this.Btn_Add_Plan_Customer_Click);
            // 
            // Nud_Customer_Plan_Price
            // 
            this.Nud_Customer_Plan_Price.Enabled = false;
            this.Nud_Customer_Plan_Price.Location = new System.Drawing.Point(12, 179);
            this.Nud_Customer_Plan_Price.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.Nud_Customer_Plan_Price.Name = "Nud_Customer_Plan_Price";
            this.Nud_Customer_Plan_Price.Size = new System.Drawing.Size(120, 20);
            this.Nud_Customer_Plan_Price.TabIndex = 12;
            // 
            // Nud_Plan_Price
            // 
            this.Nud_Plan_Price.Enabled = false;
            this.Nud_Plan_Price.Location = new System.Drawing.Point(403, 179);
            this.Nud_Plan_Price.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.Nud_Plan_Price.Name = "Nud_Plan_Price";
            this.Nud_Plan_Price.Size = new System.Drawing.Size(120, 20);
            this.Nud_Plan_Price.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Modality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Modality";
            // 
            // Btn_GoBack
            // 
            this.Btn_GoBack.Location = new System.Drawing.Point(12, 396);
            this.Btn_GoBack.Name = "Btn_GoBack";
            this.Btn_GoBack.Size = new System.Drawing.Size(75, 23);
            this.Btn_GoBack.TabIndex = 23;
            this.Btn_GoBack.Text = "Go back";
            this.Btn_GoBack.UseVisualStyleBackColor = true;
            this.Btn_GoBack.Click += new System.EventHandler(this.Btn_GoBack_Click);
            // 
            // Form_Plans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 431);
            this.Controls.Add(this.Btn_GoBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nud_Plan_Price);
            this.Controls.Add(this.Nud_Customer_Plan_Price);
            this.Controls.Add(this.Btn_Add_Plan_Customer);
            this.Controls.Add(this.Btn_Remove_Customer_Plan);
            this.Controls.Add(this.Txb_Customer_Plan_Description);
            this.Controls.Add(this.Txb_Customer_Plan_Modality);
            this.Controls.Add(this.Txb_Plan_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Plan_Modality);
            this.Controls.Add(this.Dgv_All_Plans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Customer_Plans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Plans";
            this.Text = "Form_Plans";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Customer_Plans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_All_Plans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Customer_Plan_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Plan_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Customer_Plans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_All_Plans;
        private System.Windows.Forms.TextBox Txb_Plan_Modality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_Plan_Description;
        private System.Windows.Forms.TextBox Txb_Customer_Plan_Description;
        private System.Windows.Forms.TextBox Txb_Customer_Plan_Modality;
        private System.Windows.Forms.Button Btn_Remove_Customer_Plan;
        private System.Windows.Forms.Button Btn_Add_Plan_Customer;
        private System.Windows.Forms.NumericUpDown Nud_Customer_Plan_Price;
        private System.Windows.Forms.NumericUpDown Nud_Plan_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_GoBack;
    }
}