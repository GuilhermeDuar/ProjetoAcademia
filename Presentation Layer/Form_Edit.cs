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
    public partial class Form_Edit : Form
    {
        private BLL_Modality m_BLL = new BLL_Modality();
        private BLL_Customer s_BLL = new BLL_Customer();
        private BLL_Product p_BLL = new BLL_Product();
        private BLL_Category c_BLL = new BLL_Category();
        private BLL_Payment_Method pm_BLL = new BLL_Payment_Method();
        private BLL_User u_BLL = new BLL_User();
        private BLL_Teacher t_BLL = new BLL_Teacher();
        private BLL_Plan pl_BLL = new BLL_Plan();
        private BLL_Importation i_BLL = new BLL_Importation();
        private BLL_Exportation e_BLL = new BLL_Exportation();
        private int ID_category;
        private int ID_pm;
        private int ID_modality;
        private int ID_customer;
        private int ID_user;
        private int ID_plan;
        private int ID_product;
        public Form_Edit(Modality m)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_modality = m.ID;
            this.Txb_Modality_Name.Text = m.Modality_Name;
            this.Gbb_Edit_Modality.Location = new Point(12, 12);
            this.Gbb_Edit_Modality.Size = new Size(233, 79);
            this.Gbb_Edit_Modality.Visible = true;
            this.Btn_Edit_Save.Visible = true;
            this.Btn_Delete.Visible = true;
        }
        public Form_Edit(Customer c)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_customer = c.ID;
            this.Txb_Customer_Name.Text = c.Customer_Name;
            this.Txb_Customer_Email.Text = c.Email;
            this.Txb_Customer_CPF.Text = c.CPF;
            this.Txb_Customer_RG.Text = c.RG;
            this.Txb_FPN.Text = c.First_Phone_Number;
            this.Txb_SPN.Text = c.Second_Phone_Number;
            this.Dtp_Student_Birthdate.Value = Convert.ToDateTime(c.BirthDate);
            this.Gbb_Edit_Customer.Location = new Point(12, 12);
            this.Gbb_Edit_Customer.Size = new Size(522, 185);
            this.Gbb_Edit_Customer.Visible = true;
            this.Btn_Activate_User.Text = "Active Customer";
            this.Btn_Desactive_User.Text = "Desactive Customer";
            this.Btn_Edit_Save.Location = new Point(12, 370);
            this.Btn_Edit_Save.Visible = true;
            this.Btn_Activate_User.Visible = true;
            this.Btn_Desactive_User.Visible = true;
        }
        public Form_Edit(Importation i)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            List<Import_Item> transactions = i_BLL.GetImportsByID(i.ID).Data;
            List<Trans_Product_GVM> transac_Products_GVM = new List<Trans_Product_GVM>();
            foreach (Import_Item item in transactions)
            {
                Trans_Product_GVM tp_GVM = new Trans_Product_GVM()
                {
                    Product_Name = item.Imported_Product.Product_Name,
                    Amount = item.Amount,
                    Price = item.Unitary_Value.ToString("C2")
                };
                transac_Products_GVM.Add(tp_GVM);
            }
            Dgv_Transaction_Products.DataSource = transac_Products_GVM;
            Gbb_Transaction.Location = new Point(12, 12);
            Gbb_Transaction.Size = new Size(675, 315);
            Gbb_Transaction.Visible = true;
            Btn_Edit_Cancel.Text = "Go back";
            Btn_Edit_Cancel.Location = new Point(12, 333);
        }
        public Form_Edit(Exportation ex)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            List<Export_Item> transactions = e_BLL.GetExportsByID(ex.ID).Data;
            List<Trans_Product_GVM> transac_Products_GVM = new List<Trans_Product_GVM>();
            foreach (Export_Item item in transactions)
            {
                Trans_Product_GVM tp_GVM = new Trans_Product_GVM()
                {
                    Product_Name = item.Exported_Product.Product_Name,
                    Amount = item.Amount,
                    Price = item.Unitary_Value.ToString("C2")
                };
                transac_Products_GVM.Add(tp_GVM);
            }
            Dgv_Transaction_Products.DataSource = transac_Products_GVM;
            Gbb_Transaction.Location = new Point(12, 12);
            Gbb_Transaction.Size = new Size(675, 315);
            Gbb_Transaction.Visible = true;
            Btn_Edit_Cancel.Text = "Go back";
            Btn_Edit_Cancel.Location = new Point(12, 333);
        }
        public Form_Edit(Product p)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_product = p.ID;
            this.Txb_Product_Name.Text = p.Product_Name;
            this.Txb_Product_Description.Text = p.Product_Description;
            this.Cbb_Categories.DataSource = c_BLL.GetAll().Data;
            this.Cbb_Categories.DisplayMember = "CATEGORY_NAME";
            this.Cbb_Categories.ValueMember = "ID";
            this.Cbb_Categories.Text = p.Category;
            this.Gbb_Edit_Product.Location = new Point(12, 12);
            this.Gbb_Edit_Product.Size = new Size(270, 205);
            this.Gbb_Edit_Product.Visible = true;
            this.Btn_Edit_Save.Visible = true;
            this.Btn_Delete.Visible = true;
        }
        public Form_Edit(Plan sc)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_plan = sc.ID;
            this.Txb_Plan_Description.Text = sc.Description;
            this.Nud_Plan_Price.Value = Convert.ToDecimal(sc.Price);
            this.Gbb_Plan_Edit.Location = new Point(12, 12);
            this.Gbb_Plan_Edit.Size = new Size(233, 204);
            this.Gbb_Plan_Edit.Visible = true;
            this.Cbb_Modalities.DataSource = m_BLL.GetAll().Data;
            this.Cbb_Modalities.DisplayMember = "MODALITY_NAME";
            this.Cbb_Modalities.ValueMember = "ID";
            this.Btn_Edit_Save.Visible = true;
            this.Btn_Delete.Visible = true;
        }
        public Form_Edit(Category c)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_category = c.ID;
            this.Txb_Category_Name.Text = c.Category_Name;
            this.Gbb_Edit_Category.Size = new Size();
            this.Gbb_Edit_Category.Location = new Point(12, 12);
            this.Gbb_Edit_Category.Size = new Size(233, 73);
            this.Gbb_Edit_Category.Visible = true;
            this.Btn_Edit_Save.Visible = true;
            this.Btn_Delete.Visible = true;
        }
        public Form_Edit(Payment_Method pm)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_pm = pm.ID;
            this.Txb_PM_Name.Text = pm.Method;
            this.Gbb_Edit_PM.Location = new Point(12, 12);
            this.Gbb_Edit_PM.Size = new Size(233, 70);
            this.Gbb_Edit_PM.Visible = true;
            this.Btn_Edit_Save.Visible = true;
            this.Btn_Delete.Visible = true;
        }
        public Form_Edit(User u)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_user = u.ID; 
            this.Txb_User_Email.Text = u.Email;
            this.Gbb_Edit_User.Location = new Point(12, 12);
            this.Gbb_Edit_User.Size = new Size(523, 118);
            this.Gbb_Edit_User.Visible = true;
            this.Cbb_Roles.DataSource = Enum.GetValues(typeof(Users_Role));
            this.Cbb_Roles.SelectedIndex = (int)u.Role;
            this.Btn_Activate_User.Text = "Readmit User";
            this.Btn_Desactive_User.Text = "Dismiss User";
            this.Btn_Edit_Save.Location = new Point(12, 370);
            this.Btn_Edit_Save.Visible = true;
            switch (Current_System_User.GetCurrentUser().Role)
            {
                case Users_Role.Administrator:
                    this.Btn_Desactive_User.Visible = true;
                    this.Btn_Activate_User.Visible = true;
                    break;
                case Users_Role.Manager:
                    this.Btn_Desactive_User.Visible = false;
                    this.Btn_Activate_User.Visible = false;
                    break;
                case Users_Role.Teacher:
                    this.Gbb_Edit_User.Size = new Size(516, 252);
                    this.Btn_Desactive_User.Visible = false;
                    this.Btn_Activate_User.Visible = false;
                    this.Gbb_Teacher_Edit.Visible = true;
                    break;
            }
        }
        public Form_Edit(User u, Teacher t)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            ID_user = u.ID;
            this.Txb_User_Email.Text = u.Email;
            this.Txb_Teacher_Name.Text = t.Teacher_Name;
            this.Txb_Teacher_CPF.Text = t.CPF.ToString();
            this.Txb_Teacher_RG.Text = t.RG.ToString();
            this.Txb_Teacher_Adress.Text = t.Adress;
            this.Txb_Phone_Number.Text = t.Phone_Number;
            this.Txb_Teacher_Wage.Text = t.Wage.ToString("C2");
            this.Txb_Teacher_Comission.Text = t.Comission.ToString("C2");
            this.Gbb_Edit_User.Location = new Point(12, 12);
            this.Gbb_Edit_User.Size = new Size(538, 264);
            this.Gbb_Teacher_Edit.Location = new Point(7, 130);
            this.Gbb_Teacher_Edit.Size = new Size(527, 152);
            this.Gbb_Edit_User.Visible = true;
            this.Gbb_Teacher_Edit.Visible = true;
            this.Cbb_Roles.DataSource = Enum.GetValues(typeof(Users_Role));
            this.Cbb_Roles.SelectedIndex = (int)u.Role;
            this.Btn_Activate_User.Text = "Readmit User";
            this.Btn_Desactive_User.Text = "Dismiss User";
            this.Btn_Edit_Save.Location = new Point(12, 370);
            this.Btn_Edit_Save.Visible = true;

            switch (Current_System_User.GetCurrentUser().Role)
            {
                case Users_Role.Administrator:
                    this.Btn_Desactive_User.Visible = true;
                    this.Btn_Activate_User.Visible = true;
                    break;
                case Users_Role.Manager:
                    this.Btn_Desactive_User.Visible = false;
                    this.Btn_Activate_User.Visible = false;
                    break;
                case Users_Role.Teacher:
                    this.Btn_Desactive_User.Visible = false;
                    this.Btn_Activate_User.Visible = false;
                    this.Gbb_Teacher_Edit.Visible = true;
                    break;
            }
        }

        private void Btn_Edit_Save_Click(object sender, EventArgs e)
        {
            Feedback response = new Feedback();
            if (Gbb_Edit_Category.Visible)
            {
                response = c_BLL.Update(new Category()
                {
                    ID = ID_category,
                    Category_Name = Txb_Category_Name.Text
                });
            }
            else if (Gbb_Edit_Customer.Visible)
            {
                response = s_BLL.Update(new Customer()
                {
                    ID = ID_customer,
                    Customer_Name = Txb_Customer_Name.Text,
                    Email = Txb_Customer_Email.Text,
                    First_Phone_Number = Txb_FPN.Text,
                    Second_Phone_Number = Txb_SPN.Text,
                });
            }
            else if (Gbb_Edit_Modality.Visible)
            {
                response = m_BLL.Update(new Modality()
                {
                    ID = ID_modality,
                    Modality_Name = Txb_Modality_Name.Text,
                });
            }
            else if (Gbb_Plan_Edit.Visible)
            {
                if (Convert.ToInt32(Cbb_Modalities.SelectedValue) == Basic_Values.Null_ID)
                {
                    MessageBox.Show("This modality is invalid for a plan!");
                    return;
                }

                response = pl_BLL.Update(new Plan()
                {
                    ID = ID_plan,
                    Modality_ID = Convert.ToInt32(Cbb_Modalities.SelectedValue),
                    Description = Txb_Plan_Description.Text,
                    Price = Convert.ToDouble(Nud_Plan_Price.Value)
                });
            }
            else if (Gbb_Edit_PM.Visible)
            {
                response = pm_BLL.Update(new Payment_Method()
                {
                    ID = ID_modality,
                    Method = Txb_PM_Name.Text
                });
            }
            else if (Gbb_Edit_Product.Visible)
            {
                response = p_BLL.Update(new Product()
                {
                ID = ID_product,
                Product_Name = Txb_Product_Name.Text,
                Product_Description = Txb_Product_Description.Text,
                Category = Convert.ToString(Cbb_Categories.SelectedValue),
                });
            }
            else if (Gbb_Edit_User.Visible)
            {
                response = u_BLL.Update(new User()
                {
                    ID = ID_user,
                    Email = Txb_User_Email.Text,
                    User_Password = Txb_User_Password.Text,
                    Role = (Users_Role)Cbb_Roles.SelectedIndex
                });
                if (Gbb_Teacher_Edit.Visible)
                {
                    response = t_BLL.Update(new Teacher()
                    {
                        Teacher_Name = Txb_Teacher_Name.Text,
                        CPF = Txb_Teacher_CPF.Text,
                        RG = Txb_Teacher_RG.Text,
                        Adress = Txb_Teacher_Adress.Text,
                        Phone_Number = Txb_Phone_Number.Text,
                        Wage = Convert.ToDouble(Txb_Teacher_Wage.Text.Replace("R$ ", "")),
                        Comission = Convert.ToDouble(Txb_Teacher_Comission.Text.Replace("R$ ", "")),
                        User_ID = Convert.ToInt32(ID_user)
                    });
                }
            }
            MessageBox.Show(response.Report);
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        
        {
            Feedback response = new Feedback();
            if (Gbb_Edit_Category.Visible)
            {
                response = c_BLL.Delete(ID_category);
            }
            else if (Gbb_Edit_Modality.Visible)
            {
                response = m_BLL.Delete(ID_modality);
            }
            else if (Gbb_Plan_Edit.Visible)
            {
                response = pl_BLL.Delete(ID_plan);
            }
            else if (Gbb_Edit_PM.Visible)
            {
                response = pm_BLL.Delete(ID_pm);
            }
            else if (Gbb_Edit_Product.Visible)
            {
                response = p_BLL.Delete(ID_product);
            }
            MessageBox.Show(response.Report);
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_Desactive_User_Click(object sender, EventArgs e)
        {
            Feedback response = new Feedback();
            if (Gbb_Edit_Customer.Visible)
            {
                response = s_BLL.Turn_Desactivated(ID_customer);
            }
            else if (Gbb_Edit_User.Visible)
            {
                if (Current_System_User.GetCurrentUser().ID == ID_user)
                {
                    response.Report = "You can't deactivate yourself!";
                    response.Successful = false;
                }
                else
                {
                    response = u_BLL.Turn_Desactivated(ID_user);
                }
            }
            MessageBox.Show(response.Report);
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_Activate_User_Click(object sender, EventArgs e)
        {
            Feedback response = new Feedback();
            if (Gbb_Edit_Customer.Visible)
            {
                response = s_BLL.Turn_Activated(ID_customer);
            }
            else if (Gbb_Edit_User.Visible)
            {
                response = u_BLL.Turn_Activated(ID_user);
            }
            MessageBox.Show(response.Report);
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_Edit_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Edit_Plans_Click(object sender, EventArgs e)
        {
            Customer c = s_BLL.GetByID(ID_customer).Item;
            Form_Plans frm = new Form_Plans(c);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
