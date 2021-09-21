
namespace Presentation_Layer
{
    partial class GridProduct
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
            this.Dvg_Data = new System.Windows.Forms.DataGridView();
            this.Btn_Update_List = new System.Windows.Forms.Button();
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
            this.Dvg_Data.Location = new System.Drawing.Point(12, 12);
            this.Dvg_Data.Name = "Dvg_Data";
            this.Dvg_Data.ReadOnly = true;
            this.Dvg_Data.Size = new System.Drawing.Size(776, 426);
            this.Dvg_Data.TabIndex = 18;
            // 
            // Btn_Update_List
            // 
            this.Btn_Update_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Update_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update_List.Location = new System.Drawing.Point(12, 444);
            this.Btn_Update_List.Name = "Btn_Update_List";
            this.Btn_Update_List.Size = new System.Drawing.Size(116, 31);
            this.Btn_Update_List.TabIndex = 22;
            this.Btn_Update_List.Text = "Update List";
            this.Btn_Update_List.UseVisualStyleBackColor = false;
            this.Btn_Update_List.Click += new System.EventHandler(this.Btn_Update_List_Click_1);
            // 
            // GridProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.Btn_Update_List);
            this.Controls.Add(this.Dvg_Data);
            this.Name = "GridProduct";
            this.Text = "GridProduct";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dvg_Data;
        private System.Windows.Forms.Button Btn_Update_List;
    }
}