using BusinessLogicalLayer;
using Metadata;
using Presentation_Layer.GridViewModel;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class FormRole_Manager : Form
    {
        int i = Basic_Values.Zero;
        private BLL_User u_BLL = new BLL_User();
        private BLL_Product p_BLL = new BLL_Product();
        private BLL_Category c_BLL = new BLL_Category();
        private BLL_Payment_Method pm_BLL = new BLL_Payment_Method();
        private BLL_Importation i_BLL = new BLL_Importation();
        private BLL_Exportation e_BLL = new BLL_Exportation();
        private char[] welcomeMessage = { 'W', 'e', 'l', 'c', 'o', 'm', 'e', '!', ' ', 'W', 'e', ' ', 'w', 'i', 's', 'h', ' ', 'y', 'o', 'u', ' ', 'h', 'a', 'v', 'e', ' ', 'a', ' ', 'g', 'o', 'o', 'd', ' ', 'd', 'a', 'y', ' ', 'o', 'f', ' ', 'w', 'o', 'r', 'k', '!' };
        public FormRole_Manager()
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Ssl_Current_User.Text += $"{Current_System_User.GetCurrentUser().Role}: {Current_System_User.GetCurrentUser().Email} (Tap in the icon to see more)";
            this.Dgv_Data.CellDoubleClick += Dgv_CellDoubleClick;
            HomePage(true);
        }
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < Basic_Values.Zero)
            {
                return;
            }
            object unidentified = this.Dgv_Data.Rows[e.RowIndex].DataBoundItem;
            Type t = unidentified.GetType();
            if (t.Name == "Category")
            {
                Category c = (Category)unidentified;
                Form_Edit frm = new Form_Edit(c);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Category> response = c_BLL.GetAll();
                this.ValidateResult<Category>(response);
            }
            if (t.Name == "Importation_GVM")
            {
                Importation_GVM i_GVM = (Importation_GVM)unidentified;
                Importation i = i_BLL.GetByID(i_GVM.ID).Item;
                Form_Edit frm = new Form_Edit(i);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Importation> response = i_BLL.GetAll();
                List<Importation_GVM> GridData = new List<Importation_GVM>();
                foreach (Importation item in response.Data)
                {
                    Importation_GVM e_GVM = new Importation_GVM()
                    {
                        ID = item.ID,
                        Email = item.Current_User.Email,
                        Total = item.TotalPrice.ToString("C2"),
                        Import_Date = item.Import_date
                    };
                    GridData.Add(e_GVM);
                }
                this.Dgv_Data.Visible = true;
                this.Dgv_Data.DataSource = GridData;
                if (response.Successful)
                {
                    Lbl_Report.ForeColor = Color.Lime;
                }
                else
                {
                    Lbl_Report.ForeColor = Color.Red;
                }
                Lbl_Report.Text = response.Report;
            }
            if (t.Name == "Exportation_GVM")
            {
                Exportation_GVM exp_GVM = (Exportation_GVM)unidentified;
                Exportation exp = e_BLL.GetByID(exp_GVM.ID).Item;
                Form_Edit frm = new Form_Edit(exp);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Exportation> response = e_BLL.GetAll();
                List<Exportation_GVM> GridData = new List<Exportation_GVM>();
                foreach (Exportation item in response.Data)
                {
                    Exportation_GVM e_GVM = new Exportation_GVM()
                    {
                        ID = item.ID,
                        Name = item.Customer.Customer_Name,
                        Total = item.TotalValue.ToString("C2"),
                        Export_Date = item.Export_date
                    };
                    GridData.Add(e_GVM);
                }
                this.Dgv_Data.Visible = true;
                this.Dgv_Data.DataSource = GridData;
                if (response.Successful)
                {
                    Lbl_Report.ForeColor = Color.Lime;
                }
                else
                {
                    Lbl_Report.ForeColor = Color.Red;
                }
                Lbl_Report.Text = response.Report;
            }
            if (t.Name == "Payment_Method")
            {
                Payment_Method pm = (Payment_Method)unidentified;
                Form_Edit frm = new Form_Edit(pm);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Payment_Method> response = pm_BLL.GetAll();
                this.ValidateResult<Payment_Method>(response);
            }
            if (t.Name == "Product_GVM")
            {
                Product_GVM p_GVM = (Product_GVM)unidentified;
                Product p = p_BLL.GetByID(p_GVM.ID).Item;
                Form_Edit frm = new Form_Edit(p);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Product> response = p_BLL.GetAll();
                List<Product_GVM> GridData = new List<Product_GVM>();
                foreach (Product item in response.Data)
                {
                    Product_GVM p_GVM2 = new Product_GVM()
                    {
                        ID = item.ID,
                        Info = item.ToString(),
                        Stock = item.Stock,
                        Price = item.Price.ToString("C2")
                    };
                    GridData.Add(p_GVM2);
                }
                this.Dgv_Data.Visible = true;
                this.Dgv_Data.DataSource = GridData;
                if (response.Successful)
                {
                    Lbl_Report.ForeColor = Color.Lime;
                }
                else
                {
                    Lbl_Report.ForeColor = Color.Red;
                }
                Lbl_Report.Text = response.Report;
            }
        }
            private void Tsm_Insert_Product_Click(object sender, EventArgs e)
        {
            Form_Insert frm = new Form_Insert(new Product());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Data_Feedback<Product> response = p_BLL.GetAll();
            List<Product_GVM> GridData = new List<Product_GVM>();
            foreach (Product item in response.Data)
            {
                Product_GVM p_GVM = new Product_GVM()
                {
                    ID = item.ID,
                    Info = item.ToString(),
                    Stock = item.Stock,
                    Price = item.Price.ToString("C2")
                };
                GridData.Add(p_GVM);
            }
            this.Dgv_Data.Visible = true;
            this.Dgv_Data.DataSource = GridData;
            if (response.Successful)
            {
                Lbl_Report.ForeColor = Color.Lime;
            }
            else
            {
                Lbl_Report.ForeColor = Color.Red;
            }
            Lbl_Report.Text = response.Report;
            HomePage(false);
        }

        private void Tsm_Product_List_Click(object sender, EventArgs e)
        {
            Data_Feedback<Product> response = p_BLL.GetAll();
            List<Product_GVM> GridData = new List<Product_GVM>();
            foreach (Product item in response.Data)
            {
                Product_GVM p_GVM = new Product_GVM()
                {
                    ID = item.ID,
                    Info = item.ToString(),
                    Stock = item.Stock,
                    Price = item.Price.ToString("C2")
                };
                GridData.Add(p_GVM);
            }
            this.Dgv_Data.Visible = true;
            this.Dgv_Data.DataSource = GridData;
            if (response.Successful)
            {
                Lbl_Report.ForeColor = Color.Lime;
            }
            else
            {
                Lbl_Report.ForeColor = Color.Red;
            }
            Lbl_Report.Text = response.Report;
            HomePage(false);
        }

        private void Tsm_Insert_Category_Click(object sender, EventArgs e)
        {
            Form_Insert frm = new Form_Insert(new Category());
            this.Hide();
            frm.ShowDialog();
            this.Show(); Data_Feedback<Category> response = c_BLL.GetAll();
            this.ValidateResult<Category>(response);
        }

        private void Tsm_Category_List_Click(object sender, EventArgs e)
        {
            Data_Feedback<Category> response = c_BLL.GetAll();
            this.ValidateResult<Category>(response);
        }
        private void Tsm_New_Importation_Click(object sender, EventArgs e)
        {
            Form_Business frm = new Form_Business(new Importation());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Data_Feedback<Importation> response = i_BLL.GetAll();
            List<Importation_GVM> GridData = new List<Importation_GVM>();
            foreach (Importation item in response.Data)
            {
                Importation_GVM i_GVM = new Importation_GVM()
                {
                    ID = item.ID,
                    Email = item.Current_User.Email,
                    Total = item.TotalPrice.ToString("C2"),
                    Import_Date = item.Import_date
                };
                GridData.Add(i_GVM);
            }
            this.Dgv_Data.Visible = true;
            this.Dgv_Data.DataSource = GridData;
            if (response.Successful)
            {
                Lbl_Report.ForeColor = Color.Lime;
            }
            else
            {
                Lbl_Report.ForeColor = Color.Red;
            }
            Lbl_Report.Text = response.Report;
            HomePage(false);
        }
        private void Tsm_Importation_List_Click(object sender, EventArgs e)
        {
            Data_Feedback<Importation> response = i_BLL.GetAll();
            List<Importation_GVM> GridData = new List<Importation_GVM>();
            foreach (Importation item in response.Data)
            {
                Importation_GVM i_GVM = new Importation_GVM()
                {
                    ID = item.ID,
                    Email = item.Current_User.Email,
                    Total = item.TotalPrice.ToString("C2"),
                    Import_Date = item.Import_date
                };
                GridData.Add(i_GVM);
            }
            this.Dgv_Data.Visible = true;
            this.Dgv_Data.DataSource = GridData;
            if (response.Successful)
            {
                Lbl_Report.ForeColor = Color.Lime;
            }
            else
            {
                Lbl_Report.ForeColor = Color.Red;
            }
            Lbl_Report.Text = response.Report;
            HomePage(false);
        }
        private void Tsm_New_Exportation_Click(object sender, EventArgs e)
        {
            Form_Business frm = new Form_Business(new Exportation());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Data_Feedback<Exportation> response = e_BLL.GetAll();
            List<Exportation_GVM> GridData = new List<Exportation_GVM>();
            foreach (Exportation item in response.Data)
            {
                Exportation_GVM e_GVM = new Exportation_GVM()
                {
                    ID = item.ID,
                    Name = item.Customer.Customer_Name,
                    Total = item.TotalValue.ToString("C2"),
                    Export_Date = item.Export_date
                };
                GridData.Add(e_GVM);
            }
            this.Dgv_Data.Visible = true;
            this.Dgv_Data.DataSource = GridData;
            if (response.Successful)
            {
                Lbl_Report.ForeColor = Color.Lime;
            }
            else
            {
                Lbl_Report.ForeColor = Color.Red;
            }
            Lbl_Report.Text = response.Report;
            HomePage(false);
        }
        private void Tsm_Exportation_List_Click(object sender, EventArgs e)
        {
            Data_Feedback<Exportation> response = e_BLL.GetAll();
            List<Exportation_GVM> GridData = new List<Exportation_GVM>();
            foreach (Exportation item in response.Data)
            {
                Exportation_GVM e_GVM = new Exportation_GVM()
                {
                    ID = item.ID,
                    Name = item.Customer.Customer_Name,
                    Total = item.TotalValue.ToString("C2"),
                    Export_Date = item.Export_date
                };
                GridData.Add(e_GVM);
            }
            this.Dgv_Data.Visible = true;
            this.Dgv_Data.DataSource = GridData;
            if (response.Successful)
            {
                Lbl_Report.ForeColor = Color.Lime;
            }
            else
            {
                Lbl_Report.ForeColor = Color.Red;
            }
            Lbl_Report.Text = response.Report;
            HomePage(false);
        }
        private void Tsm_PM_Insert_Click(object sender, EventArgs e)
        {
            Form_Insert frm = new Form_Insert(new Payment_Method());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Data_Feedback<Payment_Method> response = pm_BLL.GetAll();
            this.ValidateResult<Payment_Method>(response);
        }

        private void Tsm_PM_List_Click(object sender, EventArgs e)
        {
            Data_Feedback<Payment_Method> response = pm_BLL.GetAll();
            this.ValidateResult<Payment_Method>(response);
        }

        private void ValidateResult<T>(Data_Feedback<T> fb)
        {
            Lbl_Report.Text = fb.Report;
            if (!fb.Successful)
            {
                Lbl_Report.ForeColor = Color.Red;
            }
            else
            {
                Lbl_Report.ForeColor = Color.Lime;
            }
            var data_Feedback = (Data_Feedback<T>)fb;
            this.Dgv_Data.DataSource = data_Feedback.Data;
            this.Dgv_Data.Visible = true;
            HomePage(false);
        }
        public void HomePage(bool home)
        {
            if (home)
            {
                this.Dgv_Data.Visible = false;
                this.Lbl_Report.Text = "";
                this.Lbl_Welcome.Visible = true;
                this.timer1.Start();
            }
            else
            {
                this.Lbl_Welcome.Visible = false;
                this.Lbl_Welcome.Text = "";
            }
        }

        private void Lbl_Home_Click(object sender, EventArgs e)
        {
            if (!Lbl_Welcome.Visible)
            {
                this.HomePage(true);
            }
        }
        
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                this.Lbl_Welcome.Text += welcomeMessage[i];
                i++;
                if (this.Lbl_Welcome.Text.Length == welcomeMessage.Length)
                {
                    this.timer1.Stop();
                    i = Basic_Values.Zero;
                }
            }
            catch (Exception ex)
            {
                Lbl_Welcome.Text = "";
                this.timer1.Stop();
                i = Basic_Values.Zero;
                return;
            }
        }

        private void Tsm_Edit_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Edit frm = new Form_Edit(Current_System_User.GetCurrentUser());
            frm.ShowDialog();
            this.Show();
        }

        private void Tsm_Change_Theme_Click(object sender, EventArgs e)
        {
            Current_Theme.SwitchCurrentTheme(this);
        }

        private void Btn_SignOut_Click(object sender, EventArgs e)
        {
            Current_System_User.Logout();
            this.Close();
        }
    }
}