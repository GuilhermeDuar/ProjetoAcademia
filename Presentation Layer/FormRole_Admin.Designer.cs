
namespace Presentation_Layer
{
    partial class FormRole_Admin
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
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.Ssl_Current_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.Tsm_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Teachers = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Teachers_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Teacher_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Managers = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Manager_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Manager_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Admin_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Admin_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Customer_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Customer_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Transactions = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_New_Importation = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_New_Exportation = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Importation_Record = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Exportation_Record = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Modalities = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Linked_Plans = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Plan_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Plan_List = new System.Windows.Forms.ToolStripMenuItem();
            this.modalitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Modalities_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Modalities_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_PM = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_PM_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_PM_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Categories = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Categories_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Categories_List = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsm_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Product_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Product_List = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Edit_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Change_Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_Report = new System.Windows.Forms.Label();
            this.Lbl_Home = new System.Windows.Forms.Label();
            this.Lbl_HomeSub = new System.Windows.Forms.Label();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_RoleAdmin = new System.Windows.Forms.Panel();
            this.Btn_SignOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Pnl_RoleAdmin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ssl_Current_User});
            this.statusStrip2.Location = new System.Drawing.Point(0, 413);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(833, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // Ssl_Current_User
            // 
            this.Ssl_Current_User.Name = "Ssl_Current_User";
            this.Ssl_Current_User.Size = new System.Drawing.Size(64, 17);
            this.Ssl_Current_User.Text = "Logged as ";
            // 
            // Dgv_Data
            // 
            this.Dgv_Data.AllowUserToAddRows = false;
            this.Dgv_Data.AllowUserToDeleteRows = false;
            this.Dgv_Data.AllowUserToResizeColumns = false;
            this.Dgv_Data.AllowUserToResizeRows = false;
            this.Dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dgv_Data.Location = new System.Drawing.Point(198, 65);
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.ReadOnly = true;
            this.Dgv_Data.RowHeadersWidth = 51;
            this.Dgv_Data.Size = new System.Drawing.Size(622, 345);
            this.Dgv_Data.TabIndex = 33;
            this.Dgv_Data.Visible = false;
            // 
            // Tsm_Employee
            // 
            this.Tsm_Employee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Teachers,
            this.Tsm_Managers,
            this.Tsm_Admin});
            this.Tsm_Employee.Name = "Tsm_Employee";
            this.Tsm_Employee.Size = new System.Drawing.Size(134, 24);
            this.Tsm_Employee.Text = "Employee";
            // 
            // Tsm_Teachers
            // 
            this.Tsm_Teachers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Teachers_Insert,
            this.Tsm_Teacher_List});
            this.Tsm_Teachers.Name = "Tsm_Teachers";
            this.Tsm_Teachers.Size = new System.Drawing.Size(143, 24);
            this.Tsm_Teachers.Text = "Teachers";
            // 
            // Tsm_Teachers_Insert
            // 
            this.Tsm_Teachers_Insert.Name = "Tsm_Teachers_Insert";
            this.Tsm_Teachers_Insert.Size = new System.Drawing.Size(198, 24);
            this.Tsm_Teachers_Insert.Text = "Insert new teacher";
            this.Tsm_Teachers_Insert.Click += new System.EventHandler(this.Tsm_Teachers_Insert_Click);
            // 
            // Tsm_Teacher_List
            // 
            this.Tsm_Teacher_List.Name = "Tsm_Teacher_List";
            this.Tsm_Teacher_List.Size = new System.Drawing.Size(198, 24);
            this.Tsm_Teacher_List.Text = "Teachers list";
            this.Tsm_Teacher_List.Click += new System.EventHandler(this.Tsm_Teacher_List_Click);
            // 
            // Tsm_Managers
            // 
            this.Tsm_Managers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Manager_Insert,
            this.Tsm_Manager_List});
            this.Tsm_Managers.Name = "Tsm_Managers";
            this.Tsm_Managers.Size = new System.Drawing.Size(143, 24);
            this.Tsm_Managers.Text = "Managers";
            // 
            // Tsm_Manager_Insert
            // 
            this.Tsm_Manager_Insert.Name = "Tsm_Manager_Insert";
            this.Tsm_Manager_Insert.Size = new System.Drawing.Size(208, 24);
            this.Tsm_Manager_Insert.Text = "Insert new manager";
            this.Tsm_Manager_Insert.Click += new System.EventHandler(this.Tsm_Manager_Insert_Click);
            // 
            // Tsm_Manager_List
            // 
            this.Tsm_Manager_List.Name = "Tsm_Manager_List";
            this.Tsm_Manager_List.Size = new System.Drawing.Size(208, 24);
            this.Tsm_Manager_List.Text = "Managers list";
            this.Tsm_Manager_List.Click += new System.EventHandler(this.Tsm_Manager_List_Click);
            // 
            // Tsm_Admin
            // 
            this.Tsm_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Admin_Insert,
            this.Tsm_Admin_List});
            this.Tsm_Admin.Name = "Tsm_Admin";
            this.Tsm_Admin.Size = new System.Drawing.Size(143, 24);
            this.Tsm_Admin.Text = "Admin";
            // 
            // Tsm_Admin_Insert
            // 
            this.Tsm_Admin_Insert.Name = "Tsm_Admin_Insert";
            this.Tsm_Admin_Insert.Size = new System.Drawing.Size(191, 24);
            this.Tsm_Admin_Insert.Text = "Insert new admin";
            this.Tsm_Admin_Insert.Click += new System.EventHandler(this.Tsm_Admin_Insert_Click);
            // 
            // Tsm_Admin_List
            // 
            this.Tsm_Admin_List.Name = "Tsm_Admin_List";
            this.Tsm_Admin_List.Size = new System.Drawing.Size(191, 24);
            this.Tsm_Admin_List.Text = "Admin list";
            this.Tsm_Admin_List.Click += new System.EventHandler(this.Tsm_Admin_List_Click);
            // 
            // Tsm_Customer
            // 
            this.Tsm_Customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Customer_Insert,
            this.Tsm_Customer_List});
            this.Tsm_Customer.Name = "Tsm_Customer";
            this.Tsm_Customer.Size = new System.Drawing.Size(134, 24);
            this.Tsm_Customer.Text = "Customers";
            // 
            // Tsm_Customer_Insert
            // 
            this.Tsm_Customer_Insert.Name = "Tsm_Customer_Insert";
            this.Tsm_Customer_Insert.Size = new System.Drawing.Size(210, 24);
            this.Tsm_Customer_Insert.Text = "Insert new customer";
            this.Tsm_Customer_Insert.Click += new System.EventHandler(this.Tsm_Customer_Insert_Click);
            // 
            // Tsm_Customer_List
            // 
            this.Tsm_Customer_List.Name = "Tsm_Customer_List";
            this.Tsm_Customer_List.Size = new System.Drawing.Size(210, 24);
            this.Tsm_Customer_List.Text = "Customers list";
            this.Tsm_Customer_List.Click += new System.EventHandler(this.Tsm_Customer_List_Click);
            // 
            // Tsm_Transactions
            // 
            this.Tsm_Transactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_New_Importation,
            this.Tsm_New_Exportation,
            this.Tsm_Importation_Record,
            this.Tsm_Exportation_Record});
            this.Tsm_Transactions.Name = "Tsm_Transactions";
            this.Tsm_Transactions.Size = new System.Drawing.Size(134, 24);
            this.Tsm_Transactions.Text = "Transaction";
            // 
            // Tsm_New_Importation
            // 
            this.Tsm_New_Importation.Name = "Tsm_New_Importation";
            this.Tsm_New_Importation.Size = new System.Drawing.Size(210, 24);
            this.Tsm_New_Importation.Text = "Buy";
            this.Tsm_New_Importation.Click += new System.EventHandler(this.Tsm_New_Importation_Click);
            // 
            // Tsm_New_Exportation
            // 
            this.Tsm_New_Exportation.Name = "Tsm_New_Exportation";
            this.Tsm_New_Exportation.Size = new System.Drawing.Size(210, 24);
            this.Tsm_New_Exportation.Text = "Sell";
            this.Tsm_New_Exportation.Click += new System.EventHandler(this.Tsm_New_Exportation_Click);
            // 
            // Tsm_Importation_Record
            // 
            this.Tsm_Importation_Record.Name = "Tsm_Importation_Record";
            this.Tsm_Importation_Record.Size = new System.Drawing.Size(210, 24);
            this.Tsm_Importation_Record.Text = "Importations record";
            this.Tsm_Importation_Record.Click += new System.EventHandler(this.Tsm_Importation_Record_Click);
            // 
            // Tsm_Exportation_Record
            // 
            this.Tsm_Exportation_Record.Name = "Tsm_Exportation_Record";
            this.Tsm_Exportation_Record.Size = new System.Drawing.Size(210, 24);
            this.Tsm_Exportation_Record.Text = "Exportations record";
            this.Tsm_Exportation_Record.Click += new System.EventHandler(this.Tsm_Exportation_Record_Click);
            // 
            // Tsm_Modalities
            // 
            this.Tsm_Modalities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Linked_Plans,
            this.Tsm_Plan_Insert,
            this.Tsm_Plan_List,
            this.modalitiesToolStripMenuItem});
            this.Tsm_Modalities.Name = "Tsm_Modalities";
            this.Tsm_Modalities.Size = new System.Drawing.Size(134, 24);
            this.Tsm_Modalities.Text = "Plans";
            // 
            // Tsm_Linked_Plans
            // 
            this.Tsm_Linked_Plans.Name = "Tsm_Linked_Plans";
            this.Tsm_Linked_Plans.Size = new System.Drawing.Size(185, 24);
            this.Tsm_Linked_Plans.Text = "Linked plans";
            this.Tsm_Linked_Plans.Click += new System.EventHandler(this.Tsm_Linked_Plans_Click);
            // 
            // Tsm_Plan_Insert
            // 
            this.Tsm_Plan_Insert.Name = "Tsm_Plan_Insert";
            this.Tsm_Plan_Insert.Size = new System.Drawing.Size(185, 24);
            this.Tsm_Plan_Insert.Text = "Create new plan";
            this.Tsm_Plan_Insert.Click += new System.EventHandler(this.Tsm_Plan_Insert_Click);
            // 
            // Tsm_Plan_List
            // 
            this.Tsm_Plan_List.Name = "Tsm_Plan_List";
            this.Tsm_Plan_List.Size = new System.Drawing.Size(185, 24);
            this.Tsm_Plan_List.Text = "Plan list";
            this.Tsm_Plan_List.Click += new System.EventHandler(this.Tsm_Plan_List_Click);
            // 
            // modalitiesToolStripMenuItem
            // 
            this.modalitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Modalities_Insert,
            this.Tsm_Modalities_List});
            this.modalitiesToolStripMenuItem.Name = "modalitiesToolStripMenuItem";
            this.modalitiesToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.modalitiesToolStripMenuItem.Text = "Modalities";
            // 
            // Tsm_Modalities_Insert
            // 
            this.Tsm_Modalities_Insert.Name = "Tsm_Modalities_Insert";
            this.Tsm_Modalities_Insert.Size = new System.Drawing.Size(208, 24);
            this.Tsm_Modalities_Insert.Text = "Insert new modality";
            this.Tsm_Modalities_Insert.Click += new System.EventHandler(this.Tsm_Modalities_Insert_Click);
            // 
            // Tsm_Modalities_List
            // 
            this.Tsm_Modalities_List.Name = "Tsm_Modalities_List";
            this.Tsm_Modalities_List.Size = new System.Drawing.Size(208, 24);
            this.Tsm_Modalities_List.Text = "Modalities list";
            this.Tsm_Modalities_List.Click += new System.EventHandler(this.Tsm_Modalities_List_Click);
            // 
            // Tsm_PM
            // 
            this.Tsm_PM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_PM_Insert,
            this.Tsm_PM_List});
            this.Tsm_PM.Name = "Tsm_PM";
            this.Tsm_PM.Size = new System.Drawing.Size(134, 24);
            this.Tsm_PM.Text = "Payment Methods";
            // 
            // Tsm_PM_Insert
            // 
            this.Tsm_PM_Insert.Name = "Tsm_PM_Insert";
            this.Tsm_PM_Insert.Size = new System.Drawing.Size(261, 24);
            this.Tsm_PM_Insert.Text = "Insert new Payment Method";
            this.Tsm_PM_Insert.Click += new System.EventHandler(this.Tsm_PM_Insert_Click);
            // 
            // Tsm_PM_List
            // 
            this.Tsm_PM_List.Name = "Tsm_PM_List";
            this.Tsm_PM_List.Size = new System.Drawing.Size(261, 24);
            this.Tsm_PM_List.Text = "Payment methods list";
            this.Tsm_PM_List.Click += new System.EventHandler(this.Tsm_PM_List_Click);
            // 
            // Tsm_Categories
            // 
            this.Tsm_Categories.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Categories_Insert,
            this.Tsm_Categories_List});
            this.Tsm_Categories.Name = "Tsm_Categories";
            this.Tsm_Categories.Size = new System.Drawing.Size(134, 24);
            this.Tsm_Categories.Text = "Categories";
            // 
            // Tsm_Categories_Insert
            // 
            this.Tsm_Categories_Insert.Name = "Tsm_Categories_Insert";
            this.Tsm_Categories_Insert.Size = new System.Drawing.Size(207, 24);
            this.Tsm_Categories_Insert.Text = "Insert new category";
            this.Tsm_Categories_Insert.Click += new System.EventHandler(this.Tsm_Categories_Insert_Click);
            // 
            // Tsm_Categories_List
            // 
            this.Tsm_Categories_List.Name = "Tsm_Categories_List";
            this.Tsm_Categories_List.Size = new System.Drawing.Size(207, 24);
            this.Tsm_Categories_List.Text = "Category list";
            this.Tsm_Categories_List.Click += new System.EventHandler(this.Tsm_Categories_List_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Product,
            this.Tsm_Employee,
            this.Tsm_Customer,
            this.Tsm_Transactions,
            this.Tsm_Modalities,
            this.Tsm_PM,
            this.Tsm_Categories,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(143, 210);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_Product
            // 
            this.Tsm_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Product_Insert,
            this.Tsm_Product_List});
            this.Tsm_Product.Name = "Tsm_Product";
            this.Tsm_Product.Size = new System.Drawing.Size(134, 24);
            this.Tsm_Product.Text = "Products";
            // 
            // Tsm_Product_Insert
            // 
            this.Tsm_Product_Insert.Name = "Tsm_Product_Insert";
            this.Tsm_Product_Insert.Size = new System.Drawing.Size(201, 24);
            this.Tsm_Product_Insert.Text = "Insert new product";
            this.Tsm_Product_Insert.Click += new System.EventHandler(this.Tsm_Product_Insert_Click);
            // 
            // Tsm_Product_List
            // 
            this.Tsm_Product_List.Name = "Tsm_Product_List";
            this.Tsm_Product_List.Size = new System.Drawing.Size(201, 24);
            this.Tsm_Product_List.Text = "Products list";
            this.Tsm_Product_List.Click += new System.EventHandler(this.Tsm_Product_List_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Edit_Profile,
            this.Tsm_Change_Theme});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // Tsm_Edit_Profile
            // 
            this.Tsm_Edit_Profile.Name = "Tsm_Edit_Profile";
            this.Tsm_Edit_Profile.Size = new System.Drawing.Size(177, 24);
            this.Tsm_Edit_Profile.Text = "Edit Profile";
            this.Tsm_Edit_Profile.Click += new System.EventHandler(this.Tsm_Edit_Profile_Click);
            // 
            // Tsm_Change_Theme
            // 
            this.Tsm_Change_Theme.Name = "Tsm_Change_Theme";
            this.Tsm_Change_Theme.Size = new System.Drawing.Size(177, 24);
            this.Tsm_Change_Theme.Text = "Change Theme";
            this.Tsm_Change_Theme.Click += new System.EventHandler(this.Tsm_Change_Theme_Click);
            // 
            // Lbl_Report
            // 
            this.Lbl_Report.AutoSize = true;
            this.Lbl_Report.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Report.Location = new System.Drawing.Point(195, 48);
            this.Lbl_Report.Name = "Lbl_Report";
            this.Lbl_Report.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Report.TabIndex = 34;
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
            this.Lbl_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Welcome.Location = new System.Drawing.Point(184, 226);
            this.Lbl_Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Welcome.Name = "Lbl_Welcome";
            this.Lbl_Welcome.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Welcome.TabIndex = 37;
            this.Lbl_Welcome.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pnl_RoleAdmin
            // 
            this.Pnl_RoleAdmin.Controls.Add(this.Btn_SignOut);
            this.Pnl_RoleAdmin.Controls.Add(this.groupBox1);
            this.Pnl_RoleAdmin.Controls.Add(this.Lbl_Home);
            this.Pnl_RoleAdmin.Controls.Add(this.Lbl_HomeSub);
            this.Pnl_RoleAdmin.Location = new System.Drawing.Point(0, -4);
            this.Pnl_RoleAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_RoleAdmin.Name = "Pnl_RoleAdmin";
            this.Pnl_RoleAdmin.Size = new System.Drawing.Size(180, 414);
            this.Pnl_RoleAdmin.TabIndex = 38;
            // 
            // Btn_SignOut
            // 
            this.Btn_SignOut.Location = new System.Drawing.Point(12, 373);
            this.Btn_SignOut.Name = "Btn_SignOut";
            this.Btn_SignOut.Size = new System.Drawing.Size(155, 38);
            this.Btn_SignOut.TabIndex = 39;
            this.Btn_SignOut.Text = "Sign out";
            this.Btn_SignOut.UseVisualStyleBackColor = true;
            this.Btn_SignOut.Click += new System.EventHandler(this.Btn_SignOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 229);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // FormRole_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 435);
            this.Controls.Add(this.Pnl_RoleAdmin);
            this.Controls.Add(this.Lbl_Welcome);
            this.Controls.Add(this.Lbl_Report);
            this.Controls.Add(this.Dgv_Data);
            this.Controls.Add(this.statusStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRole_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pnl_RoleAdmin.ResumeLayout(false);
            this.Pnl_RoleAdmin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel Ssl_Current_User;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Employee;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Teachers;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Teachers_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Teacher_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Managers;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Manager_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Manager_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Admin;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Admin_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Admin_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Customer;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Customer_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Customer_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Transactions;
        private System.Windows.Forms.ToolStripMenuItem Tsm_New_Importation;
        private System.Windows.Forms.ToolStripMenuItem Tsm_New_Exportation;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Importation_Record;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Exportation_Record;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Modalities;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Plan_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Plan_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_PM;
        private System.Windows.Forms.ToolStripMenuItem Tsm_PM_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_PM_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Categories;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Categories_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Categories_List;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modalitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Modalities_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Modalities_List;
        private System.Windows.Forms.Label Lbl_Report;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Linked_Plans;
        private System.Windows.Forms.Label Lbl_Home;
        private System.Windows.Forms.Label Lbl_HomeSub;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Product;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Product_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Product_List;
        private System.Windows.Forms.Panel Pnl_RoleAdmin;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Edit_Profile;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Change_Theme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_SignOut;
    }
}