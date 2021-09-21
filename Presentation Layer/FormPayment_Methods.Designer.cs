
namespace Presentation_Layer
{
    partial class FormPayment_Methods
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dvg_Data = new System.Windows.Forms.DataGridView();
            this.Txb_New_Data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Update_List = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Dvg_Data
            // 
            this.Dvg_Data.AllowUserToAddRows = false;
            this.Dvg_Data.AllowUserToDeleteRows = false;
            this.Dvg_Data.AllowUserToResizeColumns = false;
            this.Dvg_Data.AllowUserToResizeRows = false;
            this.Dvg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dvg_Data.Location = new System.Drawing.Point(15, 51);
            this.Dvg_Data.Name = "Dvg_Data";
            this.Dvg_Data.ReadOnly = true;
            this.Dvg_Data.Size = new System.Drawing.Size(240, 150);
            this.Dvg_Data.TabIndex = 0;
            // 
            // Txb_New_Data
            // 
            this.Txb_New_Data.Location = new System.Drawing.Point(15, 25);
            this.Txb_New_Data.Name = "Txb_New_Data";
            this.Txb_New_Data.Size = new System.Drawing.Size(240, 20);
            this.Txb_New_Data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert a new payment method:";
            // 
            // Btn_Update_List
            // 
            this.Btn_Update_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Update_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update_List.Location = new System.Drawing.Point(137, 207);
            this.Btn_Update_List.Name = "Btn_Update_List";
            this.Btn_Update_List.Size = new System.Drawing.Size(116, 31);
            this.Btn_Update_List.TabIndex = 6;
            this.Btn_Update_List.Text = "Update List";
            this.Btn_Update_List.UseVisualStyleBackColor = false;
            this.Btn_Update_List.Click += new System.EventHandler(this.btnUpdateGrid_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(15, 207);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(116, 31);
            this.Btn_Register.TabIndex = 5;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormPayment_Methods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 267);
            this.Controls.Add(this.Btn_Update_List);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_New_Data);
            this.Controls.Add(this.Dvg_Data);
            this.Name = "FormPayment_Methods";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dvg_Data;
        private System.Windows.Forms.TextBox Txb_New_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Update_List;
        private System.Windows.Forms.Button Btn_Register;
    }
}

