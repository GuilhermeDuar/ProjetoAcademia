
namespace Presentation_Layer
{
    partial class FormSellProducts
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
            this.Gbb_Exportation_Info = new System.Windows.Forms.GroupBox();
            this.Cbb_PM_Exportation = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.Txb_Customer_Email = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clbProducts = new System.Windows.Forms.CheckedListBox();
            this.Gbb_Exportation_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbb_Exportation_Info
            // 
            this.Gbb_Exportation_Info.Controls.Add(this.clbProducts);
            this.Gbb_Exportation_Info.Controls.Add(this.button1);
            this.Gbb_Exportation_Info.Controls.Add(this.Cbb_PM_Exportation);
            this.Gbb_Exportation_Info.Controls.Add(this.label33);
            this.Gbb_Exportation_Info.Controls.Add(this.label32);
            this.Gbb_Exportation_Info.Controls.Add(this.Txb_Customer_Email);
            this.Gbb_Exportation_Info.Controls.Add(this.label31);
            this.Gbb_Exportation_Info.Controls.Add(this.radioButton2);
            this.Gbb_Exportation_Info.Controls.Add(this.radioButton1);
            this.Gbb_Exportation_Info.Controls.Add(this.label24);
            this.Gbb_Exportation_Info.Location = new System.Drawing.Point(12, 12);
            this.Gbb_Exportation_Info.Name = "Gbb_Exportation_Info";
            this.Gbb_Exportation_Info.Size = new System.Drawing.Size(685, 203);
            this.Gbb_Exportation_Info.TabIndex = 32;
            this.Gbb_Exportation_Info.TabStop = false;
            this.Gbb_Exportation_Info.Text = "Exportation Info";
            this.Gbb_Exportation_Info.Visible = false;
            // 
            // Cbb_PM_Exportation
            // 
            this.Cbb_PM_Exportation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_PM_Exportation.FormattingEnabled = true;
            this.Cbb_PM_Exportation.Location = new System.Drawing.Point(9, 128);
            this.Cbb_PM_Exportation.Name = "Cbb_PM_Exportation";
            this.Cbb_PM_Exportation.Size = new System.Drawing.Size(134, 21);
            this.Cbb_PM_Exportation.TabIndex = 38;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 112);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(139, 13);
            this.label33.TabIndex = 37;
            this.label33.Text = "Select the payment method:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 69);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 13);
            this.label32.TabIndex = 36;
            this.label32.Text = "Select the products";
            // 
            // Txb_Customer_Email
            // 
            this.Txb_Customer_Email.Location = new System.Drawing.Point(9, 47);
            this.Txb_Customer_Email.Name = "Txb_Customer_Email";
            this.Txb_Customer_Email.Size = new System.Drawing.Size(225, 20);
            this.Txb_Customer_Email.TabIndex = 35;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 13);
            this.label31.TabIndex = 33;
            this.label31.Text = "Inform his email";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(137, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Registered user";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Anonymous";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Sell to:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clbProducts
            // 
            this.clbProducts.FormattingEnabled = true;
            this.clbProducts.Location = new System.Drawing.Point(297, 17);
            this.clbProducts.Name = "clbProducts";
            this.clbProducts.Size = new System.Drawing.Size(342, 184);
            this.clbProducts.TabIndex = 40;
            // 
            // FormSellProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbb_Exportation_Info);
            this.Name = "FormSellProducts";
            this.Text = "FormSellProducts";
            this.Gbb_Exportation_Info.ResumeLayout(false);
            this.Gbb_Exportation_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbb_Exportation_Info;
        private System.Windows.Forms.ComboBox Cbb_PM_Exportation;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox Txb_Customer_Email;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox clbProducts;
    }
}