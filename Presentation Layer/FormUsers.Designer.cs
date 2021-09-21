
namespace Presentation_Layer
{
    partial class FormUsers
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_Email = new System.Windows.Forms.TextBox();
            this.Btn_Update_List = new System.Windows.Forms.Button();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.Dvg_Data = new System.Windows.Forms.DataGridView();
            this.Txb_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbb_Users_Roles = new System.Windows.Forms.ComboBox();
            this.gbTeacher = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_User_ID = new System.Windows.Forms.Label();
            this.Nud_Wage = new System.Windows.Forms.NumericUpDown();
            this.Txb_Phone_Number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_Adress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txb_RG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txb_CPF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).BeginInit();
            this.gbTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Wage)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "User password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "User Email:";
            // 
            // Txb_Email
            // 
            this.Txb_Email.Location = new System.Drawing.Point(12, 49);
            this.Txb_Email.Name = "Txb_Email";
            this.Txb_Email.Size = new System.Drawing.Size(240, 20);
            this.Txb_Email.TabIndex = 22;
            // 
            // Btn_Update_List
            // 
            this.Btn_Update_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_Update_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update_List.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update_List.Location = new System.Drawing.Point(136, 366);
            this.Btn_Update_List.Name = "Btn_Update_List";
            this.Btn_Update_List.Size = new System.Drawing.Size(116, 31);
            this.Btn_Update_List.TabIndex = 21;
            this.Btn_Update_List.Text = "Update List";
            this.Btn_Update_List.UseVisualStyleBackColor = false;
            this.Btn_Update_List.Click += new System.EventHandler(this.Btn_Update_List_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Location = new System.Drawing.Point(12, 366);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(116, 31);
            this.Btn_Register.TabIndex = 20;
            this.Btn_Register.Text = "Register";
            this.Btn_Register.UseVisualStyleBackColor = true;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Dvg_Data
            // 
            this.Dvg_Data.AllowUserToAddRows = false;
            this.Dvg_Data.AllowUserToDeleteRows = false;
            this.Dvg_Data.AllowUserToResizeColumns = false;
            this.Dvg_Data.AllowUserToResizeRows = false;
            this.Dvg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dvg_Data.Location = new System.Drawing.Point(12, 210);
            this.Dvg_Data.Name = "Dvg_Data";
            this.Dvg_Data.Size = new System.Drawing.Size(776, 150);
            this.Dvg_Data.TabIndex = 17;
            // 
            // Txb_Password
            // 
            this.Txb_Password.Location = new System.Drawing.Point(12, 103);
            this.Txb_Password.Name = "Txb_Password";
            this.Txb_Password.Size = new System.Drawing.Size(240, 20);
            this.Txb_Password.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "User Role";
            // 
            // Cbb_Users_Roles
            // 
            this.Cbb_Users_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_Users_Roles.FormattingEnabled = true;
            this.Cbb_Users_Roles.Items.AddRange(new object[] {
            "Administrator",
            "Manager",
            "Teacher"});
            this.Cbb_Users_Roles.Location = new System.Drawing.Point(12, 153);
            this.Cbb_Users_Roles.Name = "Cbb_Users_Roles";
            this.Cbb_Users_Roles.Size = new System.Drawing.Size(121, 21);
            this.Cbb_Users_Roles.TabIndex = 27;
            this.Cbb_Users_Roles.SelectedIndexChanged += new System.EventHandler(this.Cbb_Users_Roles_SelectedIndexChanged);
            // 
            // gbTeacher
            // 
            this.gbTeacher.Controls.Add(this.label9);
            this.gbTeacher.Controls.Add(this.Lbl_User_ID);
            this.gbTeacher.Controls.Add(this.Nud_Wage);
            this.gbTeacher.Controls.Add(this.Txb_Phone_Number);
            this.gbTeacher.Controls.Add(this.label5);
            this.gbTeacher.Controls.Add(this.label6);
            this.gbTeacher.Controls.Add(this.Txb_Adress);
            this.gbTeacher.Controls.Add(this.label7);
            this.gbTeacher.Controls.Add(this.Txb_RG);
            this.gbTeacher.Controls.Add(this.label8);
            this.gbTeacher.Controls.Add(this.label10);
            this.gbTeacher.Controls.Add(this.Txb_CPF);
            this.gbTeacher.Controls.Add(this.label11);
            this.gbTeacher.Controls.Add(this.textBox1);
            this.gbTeacher.Location = new System.Drawing.Point(303, 9);
            this.gbTeacher.Name = "gbTeacher";
            this.gbTeacher.Size = new System.Drawing.Size(485, 187);
            this.gbTeacher.TabIndex = 28;
            this.gbTeacher.TabStop = false;
            this.gbTeacher.Text = "Teacher Info:";
            this.gbTeacher.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "User ID";
            // 
            // Lbl_User_ID
            // 
            this.Lbl_User_ID.AutoSize = true;
            this.Lbl_User_ID.Location = new System.Drawing.Point(6, 176);
            this.Lbl_User_ID.Name = "Lbl_User_ID";
            this.Lbl_User_ID.Size = new System.Drawing.Size(0, 13);
            this.Lbl_User_ID.TabIndex = 78;
            // 
            // Nud_Wage
            // 
            this.Nud_Wage.Location = new System.Drawing.Point(264, 132);
            this.Nud_Wage.Name = "Nud_Wage";
            this.Nud_Wage.Size = new System.Drawing.Size(183, 20);
            this.Nud_Wage.TabIndex = 77;
            // 
            // Txb_Phone_Number
            // 
            this.Txb_Phone_Number.Location = new System.Drawing.Point(264, 37);
            this.Txb_Phone_Number.Name = "Txb_Phone_Number";
            this.Txb_Phone_Number.Size = new System.Drawing.Size(183, 20);
            this.Txb_Phone_Number.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Adress:";
            // 
            // Txb_Adress
            // 
            this.Txb_Adress.Location = new System.Drawing.Point(6, 131);
            this.Txb_Adress.Name = "Txb_Adress";
            this.Txb_Adress.Size = new System.Drawing.Size(183, 20);
            this.Txb_Adress.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Wage:";
            // 
            // Txb_RG
            // 
            this.Txb_RG.Location = new System.Drawing.Point(264, 84);
            this.Txb_RG.Name = "Txb_RG";
            this.Txb_RG.PasswordChar = '*';
            this.Txb_RG.Size = new System.Drawing.Size(183, 20);
            this.Txb_RG.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 70;
            this.label8.Text = "RG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "CPF";
            // 
            // Txb_CPF
            // 
            this.Txb_CPF.Location = new System.Drawing.Point(6, 84);
            this.Txb_CPF.Name = "Txb_CPF";
            this.Txb_CPF.PasswordChar = '*';
            this.Txb_CPF.Size = new System.Drawing.Size(183, 20);
            this.Txb_CPF.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Insert a new teacher:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 66;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbTeacher);
            this.Controls.Add(this.Cbb_Users_Roles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txb_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_Email);
            this.Controls.Add(this.Btn_Update_List);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.Dvg_Data);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Data)).EndInit();
            this.gbTeacher.ResumeLayout(false);
            this.gbTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Wage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_Email;
        private System.Windows.Forms.Button Btn_Update_List;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.DataGridView Dvg_Data;
        private System.Windows.Forms.TextBox Txb_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbb_Users_Roles;
        private System.Windows.Forms.GroupBox gbTeacher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_User_ID;
        private System.Windows.Forms.NumericUpDown Nud_Wage;
        private System.Windows.Forms.TextBox Txb_Phone_Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txb_Adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txb_RG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txb_CPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}