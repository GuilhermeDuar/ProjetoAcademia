
namespace Presentation_Layer
{
    partial class FormStudents
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
            this.Txb_RG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_CPF = new System.Windows.Forms.TextBox();
            this.Btn_Update_List = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_New_Data = new System.Windows.Forms.TextBox();
            this.Dvg_Data = new System.Windows.Forms.DataGridView();
            this.Txb_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txb_SPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_FPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_RG
            // 
            this.Txb_RG.Location = new System.Drawing.Point(270, 73);
            this.Txb_RG.Name = "Txb_RG";
            this.Txb_RG.PasswordChar = '*';
            this.Txb_RG.Size = new System.Drawing.Size(240, 20);
            this.Txb_RG.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "CPF";
            // 
            // Txb_CPF
            // 
            this.Txb_CPF.Location = new System.Drawing.Point(12, 73);
            this.Txb_CPF.Name = "Txb_CPF";
            this.Txb_CPF.Size = new System.Drawing.Size(240, 20);
            this.Txb_CPF.TabIndex = 33;
            // 
            // Btn_Update_List
            // 
            this.Btn_Update_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Update_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update_List.Location = new System.Drawing.Point(136, 367);
            this.Btn_Update_List.Name = "Btn_Update_List";
            this.Btn_Update_List.Size = new System.Drawing.Size(116, 31);
            this.Btn_Update_List.TabIndex = 32;
            this.Btn_Update_List.Text = "Update List";
            this.Btn_Update_List.UseVisualStyleBackColor = false;
            this.Btn_Update_List.Click += new System.EventHandler(this.Btn_Update_List_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(12, 367);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(116, 31);
            this.Btn_Register.TabIndex = 31;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Insert a new student:";
            // 
            // Txb_New_Data
            // 
            this.Txb_New_Data.Location = new System.Drawing.Point(12, 26);
            this.Txb_New_Data.Name = "Txb_New_Data";
            this.Txb_New_Data.Size = new System.Drawing.Size(240, 20);
            this.Txb_New_Data.TabIndex = 29;
            // 
            // Dvg_Data
            // 
            this.Dvg_Data.AllowUserToAddRows = false;
            this.Dvg_Data.AllowUserToDeleteRows = false;
            this.Dvg_Data.AllowUserToResizeColumns = false;
            this.Dvg_Data.AllowUserToResizeRows = false;
            this.Dvg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dvg_Data.Location = new System.Drawing.Point(12, 211);
            this.Dvg_Data.Name = "Dvg_Data";
            this.Dvg_Data.Size = new System.Drawing.Size(477, 150);
            this.Dvg_Data.TabIndex = 28;
            // 
            // Txb_Email
            // 
            this.Txb_Email.Location = new System.Drawing.Point(270, 26);
            this.Txb_Email.Name = "Txb_Email";
            this.Txb_Email.Size = new System.Drawing.Size(240, 20);
            this.Txb_Email.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email";
            // 
            // Txb_SPN
            // 
            this.Txb_SPN.Location = new System.Drawing.Point(270, 118);
            this.Txb_SPN.Name = "Txb_SPN";
            this.Txb_SPN.Size = new System.Drawing.Size(240, 20);
            this.Txb_SPN.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Second Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "First Phone Number";
            // 
            // Txb_FPN
            // 
            this.Txb_FPN.Location = new System.Drawing.Point(12, 118);
            this.Txb_FPN.Name = "Txb_FPN";
            this.Txb_FPN.Size = new System.Drawing.Size(240, 20);
            this.Txb_FPN.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Birthdate";
            // 
            // Dtp_Birthdate
            // 
            this.Dtp_Birthdate.CustomFormat = "dd/mm/yyyy";
            this.Dtp_Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Birthdate.Location = new System.Drawing.Point(15, 166);
            this.Dtp_Birthdate.Name = "Dtp_Birthdate";
            this.Dtp_Birthdate.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Birthdate.TabIndex = 44;
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dtp_Birthdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txb_SPN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txb_FPN);
            this.Controls.Add(this.Txb_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txb_RG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_CPF);
            this.Controls.Add(this.Btn_Update_List);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_New_Data);
            this.Controls.Add(this.Dvg_Data);
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txb_RG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_CPF;
        private System.Windows.Forms.Button Btn_Update_List;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_New_Data;
        private System.Windows.Forms.DataGridView Dvg_Data;
        private System.Windows.Forms.TextBox Txb_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_SPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txb_FPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Dtp_Birthdate;
    }
}