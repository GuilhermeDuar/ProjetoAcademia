
namespace Presentation_Layer
{
    partial class FormRole_Manager
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsm_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Insert_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Product_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Categories = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Insert_Category = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Category_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Transactions = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Importation_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Exportation_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Business = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_New_Importation = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_New_Exportation = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_PM = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_PM_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_PM_List = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Edit_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Change_Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.Lbl_Report = new System.Windows.Forms.Label();
            this.Pnl_RoleManager = new System.Windows.Forms.Panel();
            this.Btn_SignOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Home = new System.Windows.Forms.Label();
            this.Lbl_HomeSub = new System.Windows.Forms.Label();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ssl_Current_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.Pnl_RoleManager.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Products,
            this.Tsm_Transactions,
            this.Tsm_Business,
            this.Tsm_PM,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(145, 160);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_Products
            // 
            this.Tsm_Products.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Insert_Product,
            this.Tsm_Product_List,
            this.Tsm_Categories});
            this.Tsm_Products.Name = "Tsm_Products";
            this.Tsm_Products.Size = new System.Drawing.Size(132, 24);
            this.Tsm_Products.Text = "Products";
            // 
            // Tsm_Insert_Product
            // 
            this.Tsm_Insert_Product.Name = "Tsm_Insert_Product";
            this.Tsm_Insert_Product.Size = new System.Drawing.Size(204, 24);
            this.Tsm_Insert_Product.Text = "Insert new product";
            this.Tsm_Insert_Product.Click += new System.EventHandler(this.Tsm_Insert_Product_Click);
            // 
            // Tsm_Product_List
            // 
            this.Tsm_Product_List.Name = "Tsm_Product_List";
            this.Tsm_Product_List.Size = new System.Drawing.Size(204, 24);
            this.Tsm_Product_List.Text = "Products List";
            this.Tsm_Product_List.Click += new System.EventHandler(this.Tsm_Product_List_Click);
            // 
            // Tsm_Categories
            // 
            this.Tsm_Categories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Insert_Category,
            this.Tsm_Category_List});
            this.Tsm_Categories.Name = "Tsm_Categories";
            this.Tsm_Categories.Size = new System.Drawing.Size(204, 24);
            this.Tsm_Categories.Text = "Product Categories";
            // 
            // Tsm_Insert_Category
            // 
            this.Tsm_Insert_Category.Name = "Tsm_Insert_Category";
            this.Tsm_Insert_Category.Size = new System.Drawing.Size(207, 24);
            this.Tsm_Insert_Category.Text = "Insert new category";
            this.Tsm_Insert_Category.Click += new System.EventHandler(this.Tsm_Insert_Category_Click);
            // 
            // Tsm_Category_List
            // 
            this.Tsm_Category_List.Name = "Tsm_Category_List";
            this.Tsm_Category_List.Size = new System.Drawing.Size(207, 24);
            this.Tsm_Category_List.Text = "Category List";
            this.Tsm_Category_List.Click += new System.EventHandler(this.Tsm_Category_List_Click);
            // 
            // Tsm_Transactions
            // 
            this.Tsm_Transactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Importation_List,
            this.Tsm_Exportation_List});
            this.Tsm_Transactions.Name = "Tsm_Transactions";
            this.Tsm_Transactions.Size = new System.Drawing.Size(132, 24);
            this.Tsm_Transactions.Text = "Transactions";
            // 
            // Tsm_Importation_List
            // 
            this.Tsm_Importation_List.Name = "Tsm_Importation_List";
            this.Tsm_Importation_List.Size = new System.Drawing.Size(180, 24);
            this.Tsm_Importation_List.Text = "Importation list";
            this.Tsm_Importation_List.Click += new System.EventHandler(this.Tsm_Importation_List_Click);
            // 
            // Tsm_Exportation_List
            // 
            this.Tsm_Exportation_List.Name = "Tsm_Exportation_List";
            this.Tsm_Exportation_List.Size = new System.Drawing.Size(180, 24);
            this.Tsm_Exportation_List.Text = "Exportation list";
            this.Tsm_Exportation_List.Click += new System.EventHandler(this.Tsm_Exportation_List_Click);
            // 
            // Tsm_Business
            // 
            this.Tsm_Business.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_New_Importation,
            this.Tsm_New_Exportation});
            this.Tsm_Business.Name = "Tsm_Business";
            this.Tsm_Business.Size = new System.Drawing.Size(132, 24);
            this.Tsm_Business.Text = "Business";
            // 
            // Tsm_New_Importation
            // 
            this.Tsm_New_Importation.Name = "Tsm_New_Importation";
            this.Tsm_New_Importation.Size = new System.Drawing.Size(102, 24);
            this.Tsm_New_Importation.Text = "Buy";
            this.Tsm_New_Importation.Click += new System.EventHandler(this.Tsm_New_Importation_Click);
            // 
            // Tsm_New_Exportation
            // 
            this.Tsm_New_Exportation.Name = "Tsm_New_Exportation";
            this.Tsm_New_Exportation.Size = new System.Drawing.Size(102, 24);
            this.Tsm_New_Exportation.Text = "Sell";
            this.Tsm_New_Exportation.Click += new System.EventHandler(this.Tsm_New_Exportation_Click);
            // 
            // Tsm_PM
            // 
            this.Tsm_PM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_PM_Insert,
            this.Tsm_PM_List});
            this.Tsm_PM.Name = "Tsm_PM";
            this.Tsm_PM.Size = new System.Drawing.Size(132, 24);
            this.Tsm_PM.Text = "Payment Methods";
            // 
            // Tsm_PM_Insert
            // 
            this.Tsm_PM_Insert.Name = "Tsm_PM_Insert";
            this.Tsm_PM_Insert.Size = new System.Drawing.Size(263, 24);
            this.Tsm_PM_Insert.Text = "Insert new payment method";
            this.Tsm_PM_Insert.Click += new System.EventHandler(this.Tsm_PM_Insert_Click);
            // 
            // Tsm_PM_List
            // 
            this.Tsm_PM_List.Name = "Tsm_PM_List";
            this.Tsm_PM_List.Size = new System.Drawing.Size(263, 24);
            this.Tsm_PM_List.Text = "Payment method list";
            this.Tsm_PM_List.Click += new System.EventHandler(this.Tsm_PM_List_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Edit_Profile,
            this.Tsm_Change_Theme});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.settingToolStripMenuItem.Text = "Settings";
            // 
            // Tsm_Edit_Profile
            // 
            this.Tsm_Edit_Profile.Name = "Tsm_Edit_Profile";
            this.Tsm_Edit_Profile.Size = new System.Drawing.Size(174, 24);
            this.Tsm_Edit_Profile.Text = "Edit profile";
            this.Tsm_Edit_Profile.Click += new System.EventHandler(this.Tsm_Edit_Profile_Click);
            // 
            // Tsm_Change_Theme
            // 
            this.Tsm_Change_Theme.Name = "Tsm_Change_Theme";
            this.Tsm_Change_Theme.Size = new System.Drawing.Size(174, 24);
            this.Tsm_Change_Theme.Text = "Change theme";
            this.Tsm_Change_Theme.Click += new System.EventHandler(this.Tsm_Change_Theme_Click);
            // 
            // Dgv_Data
            // 
            this.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data.Location = new System.Drawing.Point(198, 65);
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.Size = new System.Drawing.Size(622, 345);
            this.Dgv_Data.TabIndex = 15;
            // 
            // Lbl_Report
            // 
            this.Lbl_Report.AutoSize = true;
            this.Lbl_Report.Location = new System.Drawing.Point(195, 48);
            this.Lbl_Report.Name = "Lbl_Report";
            this.Lbl_Report.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Report.TabIndex = 16;
            // 
            // Pnl_RoleManager
            // 
            this.Pnl_RoleManager.Controls.Add(this.Btn_SignOut);
            this.Pnl_RoleManager.Controls.Add(this.groupBox1);
            this.Pnl_RoleManager.Controls.Add(this.Lbl_Home);
            this.Pnl_RoleManager.Controls.Add(this.Lbl_HomeSub);
            this.Pnl_RoleManager.Location = new System.Drawing.Point(0, -4);
            this.Pnl_RoleManager.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_RoleManager.Name = "Pnl_RoleManager";
            this.Pnl_RoleManager.Size = new System.Drawing.Size(180, 414);
            this.Pnl_RoleManager.TabIndex = 39;
            // 
            // Btn_SignOut
            // 
            this.Btn_SignOut.Location = new System.Drawing.Point(12, 373);
            this.Btn_SignOut.Name = "Btn_SignOut";
            this.Btn_SignOut.Size = new System.Drawing.Size(155, 38);
            this.Btn_SignOut.TabIndex = 44;
            this.Btn_SignOut.Text = "Sign out";
            this.Btn_SignOut.UseVisualStyleBackColor = true;
            this.Btn_SignOut.Click += new System.EventHandler(this.Btn_SignOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 179);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // Lbl_Home
            // 
            this.Lbl_Home.AutoSize = true;
            this.Lbl_Home.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Home.Location = new System.Drawing.Point(25, 11);
            this.Lbl_Home.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Home.Name = "Lbl_Home";
            this.Lbl_Home.Size = new System.Drawing.Size(117, 55);
            this.Lbl_Home.TabIndex = 35;
            this.Lbl_Home.Text = "ZYX";
            this.Lbl_Home.Click += new System.EventHandler(this.Lbl_Home_Click);
            // 
            // Lbl_HomeSub
            // 
            this.Lbl_HomeSub.AutoSize = true;
            this.Lbl_HomeSub.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_HomeSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_HomeSub.Location = new System.Drawing.Point(48, 66);
            this.Lbl_HomeSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_HomeSub.Name = "Lbl_HomeSub";
            this.Lbl_HomeSub.Size = new System.Drawing.Size(69, 18);
            this.Lbl_HomeSub.TabIndex = 36;
            this.Lbl_HomeSub.Text = "Academy";
            // 
            // Lbl_Welcome
            // 
            this.Lbl_Welcome.AutoSize = true;
            this.Lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Welcome.Location = new System.Drawing.Point(184, 226);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Welcome.TabIndex = 42;
            this.Lbl_Welcome.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Ssl_Current_User
            // 
            this.Ssl_Current_User.Name = "Ssl_Current_User";
            this.Ssl_Current_User.Size = new System.Drawing.Size(64, 17);
            this.Ssl_Current_User.Text = "Logged as ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ssl_Current_User});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(833, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormRole_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 435);
            this.Controls.Add(this.Lbl_Welcome);
            this.Controls.Add(this.Pnl_RoleManager);
            this.Controls.Add(this.Lbl_Report);
            this.Controls.Add(this.Dgv_Data);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRole_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.Pnl_RoleManager.ResumeLayout(false);
            this.Pnl_RoleManager.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Products;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Insert_Product;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Product_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Categories;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Insert_Category;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Category_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Transactions;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Importation_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Exportation_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Business;
        private System.Windows.Forms.ToolStripMenuItem Tsm_New_Importation;
        private System.Windows.Forms.ToolStripMenuItem Tsm_New_Exportation;
        private System.Windows.Forms.ToolStripMenuItem Tsm_PM;
        private System.Windows.Forms.ToolStripMenuItem Tsm_PM_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_PM_List;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.Label Lbl_Report;
        private System.Windows.Forms.Panel Pnl_RoleManager;
        private System.Windows.Forms.Label Lbl_Home;
        private System.Windows.Forms.Label Lbl_HomeSub;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Edit_Profile;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Change_Theme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_SignOut;
        private System.Windows.Forms.ToolStripStatusLabel Ssl_Current_User;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}