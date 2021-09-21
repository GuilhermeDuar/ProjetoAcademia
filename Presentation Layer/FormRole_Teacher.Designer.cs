
namespace Presentation_Layer
{
    partial class FormRole_Teacher
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
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Customer_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Customer_List = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Arrangement_List = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Plan_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Plan_List = new System.Windows.Forms.ToolStripMenuItem();
            this.modalitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Modalities_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Modalities_List = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Edit_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Change_theme = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Ssl_Current_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dgv_Data = new System.Windows.Forms.DataGridView();
            this.Lbl_Report = new System.Windows.Forms.Label();
            this.Pnl_RoleTeacher = new System.Windows.Forms.Panel();
            this.Btn_SignOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Home = new System.Windows.Forms.Label();
            this.Lbl_HomeSub = new System.Windows.Forms.Label();
            this.Lbl_Welcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).BeginInit();
            this.Pnl_RoleTeacher.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.arrangementToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(114, 91);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Customer_Insert,
            this.Tsm_Customer_List});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.studentsToolStripMenuItem.Text = "Customers";
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
            this.Tsm_Customer_List.Text = "Customer list";
            this.Tsm_Customer_List.Click += new System.EventHandler(this.Tsm_Customer_List_Click);
            // 
            // arrangementToolStripMenuItem
            // 
            this.arrangementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Arrangement_List,
            this.Tsm_Plan_Insert,
            this.Tsm_Plan_List,
            this.modalitiesToolStripMenuItem});
            this.arrangementToolStripMenuItem.Name = "arrangementToolStripMenuItem";
            this.arrangementToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.arrangementToolStripMenuItem.Text = "Arrangement";
            // 
            // Tsm_Arrangement_List
            // 
            this.Tsm_Arrangement_List.Name = "Tsm_Arrangement_List";
            this.Tsm_Arrangement_List.Size = new System.Drawing.Size(197, 24);
            this.Tsm_Arrangement_List.Text = "Schedule list";
            this.Tsm_Arrangement_List.Click += new System.EventHandler(this.Tsm_Arrangement_List_Click);
            // 
            // Tsm_Plan_Insert
            // 
            this.Tsm_Plan_Insert.Name = "Tsm_Plan_Insert";
            this.Tsm_Plan_Insert.Size = new System.Drawing.Size(197, 24);
            this.Tsm_Plan_Insert.Text = "Create a new plan";
            this.Tsm_Plan_Insert.Click += new System.EventHandler(this.Tsm_Schedule_Insert_Click);
            // 
            // Tsm_Plan_List
            // 
            this.Tsm_Plan_List.Name = "Tsm_Plan_List";
            this.Tsm_Plan_List.Size = new System.Drawing.Size(197, 24);
            this.Tsm_Plan_List.Text = "Plan list";
            this.Tsm_Plan_List.Click += new System.EventHandler(this.Tsm_Schedule_List_Click);
            // 
            // modalitiesToolStripMenuItem
            // 
            this.modalitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Modalities_Insert,
            this.Tsm_Modalities_List});
            this.modalitiesToolStripMenuItem.Name = "modalitiesToolStripMenuItem";
            this.modalitiesToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.modalitiesToolStripMenuItem.Text = "Modalities";
            // 
            // Tsm_Modalities_Insert
            // 
            this.Tsm_Modalities_Insert.Name = "Tsm_Modalities_Insert";
            this.Tsm_Modalities_Insert.Size = new System.Drawing.Size(220, 24);
            this.Tsm_Modalities_Insert.Text = "Insert a new modality";
            this.Tsm_Modalities_Insert.Click += new System.EventHandler(this.Tsm_Modalities_Insert_Click);
            // 
            // Tsm_Modalities_List
            // 
            this.Tsm_Modalities_List.Name = "Tsm_Modalities_List";
            this.Tsm_Modalities_List.Size = new System.Drawing.Size(220, 24);
            this.Tsm_Modalities_List.Text = "Modalities list";
            this.Tsm_Modalities_List.Click += new System.EventHandler(this.Tsm_Modalities_List_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Edit_Profile,
            this.Tsm_Change_theme});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // Tsm_Edit_Profile
            // 
            this.Tsm_Edit_Profile.Name = "Tsm_Edit_Profile";
            this.Tsm_Edit_Profile.Size = new System.Drawing.Size(177, 24);
            this.Tsm_Edit_Profile.Text = "Edit profile";
            this.Tsm_Edit_Profile.Click += new System.EventHandler(this.Tsm_Edit_Profile_Click);
            // 
            // Tsm_Change_theme
            // 
            this.Tsm_Change_theme.Name = "Tsm_Change_theme";
            this.Tsm_Change_theme.Size = new System.Drawing.Size(177, 24);
            this.Tsm_Change_theme.Text = "Change Theme";
            this.Tsm_Change_theme.Click += new System.EventHandler(this.Tsm_Change_theme_Click);
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
            this.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dgv_Data.Location = new System.Drawing.Point(198, 65);
            this.Dgv_Data.Name = "Dgv_Data";
            this.Dgv_Data.ReadOnly = true;
            this.Dgv_Data.Size = new System.Drawing.Size(622, 345);
            this.Dgv_Data.TabIndex = 34;
            // 
            // Lbl_Report
            // 
            this.Lbl_Report.AutoSize = true;
            this.Lbl_Report.Location = new System.Drawing.Point(195, 48);
            this.Lbl_Report.Name = "Lbl_Report";
            this.Lbl_Report.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Report.TabIndex = 35;
            // 
            // Pnl_RoleTeacher
            // 
            this.Pnl_RoleTeacher.Controls.Add(this.Btn_SignOut);
            this.Pnl_RoleTeacher.Controls.Add(this.groupBox1);
            this.Pnl_RoleTeacher.Controls.Add(this.Lbl_Home);
            this.Pnl_RoleTeacher.Controls.Add(this.Lbl_HomeSub);
            this.Pnl_RoleTeacher.Location = new System.Drawing.Point(0, -4);
            this.Pnl_RoleTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_RoleTeacher.Name = "Pnl_RoleTeacher";
            this.Pnl_RoleTeacher.Size = new System.Drawing.Size(180, 414);
            this.Pnl_RoleTeacher.TabIndex = 40;
            // 
            // Btn_SignOut
            // 
            this.Btn_SignOut.Location = new System.Drawing.Point(12, 373);
            this.Btn_SignOut.Name = "Btn_SignOut";
            this.Btn_SignOut.Size = new System.Drawing.Size(155, 38);
            this.Btn_SignOut.TabIndex = 40;
            this.Btn_SignOut.Text = "Sign out";
            this.Btn_SignOut.UseVisualStyleBackColor = true;
            this.Btn_SignOut.Click += new System.EventHandler(this.Btn_SignOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 110);
            this.groupBox1.TabIndex = 42;
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
            this.Lbl_Welcome.TabIndex = 41;
            this.Lbl_Welcome.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FormRole_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 435);
            this.Controls.Add(this.Lbl_Welcome);
            this.Controls.Add(this.Pnl_RoleTeacher);
            this.Controls.Add(this.Lbl_Report);
            this.Controls.Add(this.Dgv_Data);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRole_Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Data)).EndInit();
            this.Pnl_RoleTeacher.ResumeLayout(false);
            this.Pnl_RoleTeacher.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Ssl_Current_User;
        private System.Windows.Forms.DataGridView Dgv_Data;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Customer_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Customer_List;
        private System.Windows.Forms.ToolStripMenuItem arrangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Arrangement_List;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Plan_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Plan_List;
        private System.Windows.Forms.ToolStripMenuItem modalitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Modalities_Insert;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Modalities_List;
        private System.Windows.Forms.Label Lbl_Report;
        private System.Windows.Forms.Panel Pnl_RoleTeacher;
        private System.Windows.Forms.Label Lbl_Home;
        private System.Windows.Forms.Label Lbl_HomeSub;
        private System.Windows.Forms.Label Lbl_Welcome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Edit_Profile;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Change_theme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_SignOut;
    }
}