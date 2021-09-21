
namespace Presentation_Layer
{
    partial class FormCategories
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
            this.Btn_Update_List = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_New_Data = new System.Windows.Forms.TextBox();
            this.Dvg_Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Update_List
            // 
            this.Btn_Update_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Update_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update_List.Location = new System.Drawing.Point(134, 208);
            this.Btn_Update_List.Name = "Btn_Update_List";
            this.Btn_Update_List.Size = new System.Drawing.Size(116, 31);
            this.Btn_Update_List.TabIndex = 11;
            this.Btn_Update_List.Text = "Update List";
            this.Btn_Update_List.UseVisualStyleBackColor = false;
            this.Btn_Update_List.Click += new System.EventHandler(this.btnUpdateGrid_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(12, 208);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(116, 31);
            this.Btn_Register.TabIndex = 10;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insert a new category";
            // 
            // Txb_New_Data
            // 
            this.Txb_New_Data.Location = new System.Drawing.Point(12, 26);
            this.Txb_New_Data.Name = "Txb_New_Data";
            this.Txb_New_Data.Size = new System.Drawing.Size(240, 20);
            this.Txb_New_Data.TabIndex = 8;
            // 
            // Dvg_Data
            // 
            this.Dvg_Data.AllowUserToAddRows = false;
            this.Dvg_Data.AllowUserToDeleteRows = false;
            this.Dvg_Data.AllowUserToResizeColumns = false;
            this.Dvg_Data.AllowUserToResizeRows = false;
            this.Dvg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dvg_Data.Location = new System.Drawing.Point(12, 52);
            this.Dvg_Data.Name = "Dvg_Data";
            this.Dvg_Data.ReadOnly = true;
            this.Dvg_Data.Size = new System.Drawing.Size(240, 150);
            this.Dvg_Data.TabIndex = 7;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Update_List);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_New_Data);
            this.Controls.Add(this.Dvg_Data);
            this.Name = "FormCategories";
            this.Text = "FormCategories";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Update_List;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_New_Data;
        private System.Windows.Forms.DataGridView Dvg_Data;
    }
}