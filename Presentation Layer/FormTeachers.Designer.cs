
namespace Presentation_Layer
{
    partial class FormTeachers
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
            this.Txb_Phone_Number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_Adress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txb_RG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_CPF = new System.Windows.Forms.TextBox();
            this.Btn_Update_List = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_New_Data = new System.Windows.Forms.TextBox();
            this.Nud_Wage = new System.Windows.Forms.NumericUpDown();
            this.Lbl_User_ID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Wage)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_Phone_Number
            // 
            this.Txb_Phone_Number.Location = new System.Drawing.Point(270, 21);
            this.Txb_Phone_Number.Name = "Txb_Phone_Number";
            this.Txb_Phone_Number.Size = new System.Drawing.Size(240, 20);
            this.Txb_Phone_Number.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Adress:";
            // 
            // Txb_Adress
            // 
            this.Txb_Adress.Location = new System.Drawing.Point(12, 115);
            this.Txb_Adress.Name = "Txb_Adress";
            this.Txb_Adress.Size = new System.Drawing.Size(240, 20);
            this.Txb_Adress.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Wage:";
            // 
            // Txb_RG
            // 
            this.Txb_RG.Location = new System.Drawing.Point(270, 68);
            this.Txb_RG.Name = "Txb_RG";
            this.Txb_RG.PasswordChar = '*';
            this.Txb_RG.Size = new System.Drawing.Size(240, 20);
            this.Txb_RG.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "RG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "CPF";
            // 
            // Txb_CPF
            // 
            this.Txb_CPF.Location = new System.Drawing.Point(12, 68);
            this.Txb_CPF.Name = "Txb_CPF";
            this.Txb_CPF.PasswordChar = '*';
            this.Txb_CPF.Size = new System.Drawing.Size(240, 20);
            this.Txb_CPF.TabIndex = 50;
            // 
            // Btn_Update_List
            // 
            this.Btn_Update_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Update_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update_List.Location = new System.Drawing.Point(134, 342);
            this.Btn_Update_List.Name = "Btn_Update_List";
            this.Btn_Update_List.Size = new System.Drawing.Size(116, 31);
            this.Btn_Update_List.TabIndex = 49;
            this.Btn_Update_List.Text = "Update List";
            this.Btn_Update_List.UseVisualStyleBackColor = false;
            this.Btn_Update_List.Click += new System.EventHandler(this.Btn_Update_List_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(12, 342);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(116, 31);
            this.Btn_Register.TabIndex = 48;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Insert a new teacher:";
            // 
            // Txb_New_Data
            // 
            this.Txb_New_Data.Location = new System.Drawing.Point(12, 21);
            this.Txb_New_Data.Name = "Txb_New_Data";
            this.Txb_New_Data.Size = new System.Drawing.Size(240, 20);
            this.Txb_New_Data.TabIndex = 46;
            // 
            // Nud_Wage
            // 
            this.Nud_Wage.Location = new System.Drawing.Point(270, 116);
            this.Nud_Wage.Name = "Nud_Wage";
            this.Nud_Wage.Size = new System.Drawing.Size(240, 20);
            this.Nud_Wage.TabIndex = 62;
            // 
            // Lbl_User_ID
            // 
            this.Lbl_User_ID.AutoSize = true;
            this.Lbl_User_ID.Location = new System.Drawing.Point(12, 160);
            this.Lbl_User_ID.Name = "Lbl_User_ID";
            this.Lbl_User_ID.Size = new System.Drawing.Size(0, 13);
            this.Lbl_User_ID.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "User ID";
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Lbl_User_ID);
            this.Controls.Add(this.Nud_Wage);
            this.Controls.Add(this.Txb_Phone_Number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txb_Adress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txb_RG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_CPF);
            this.Controls.Add(this.Btn_Update_List);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_New_Data);
            this.Name = "FormTeachers";
            this.Text = "FormTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Wage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txb_Phone_Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txb_Adress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_RG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_CPF;
        private System.Windows.Forms.Button Btn_Update_List;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_New_Data;
        private System.Windows.Forms.NumericUpDown Nud_Wage;
        private System.Windows.Forms.Label Lbl_User_ID;
        private System.Windows.Forms.Label label9;
    }
}