using BusinessLogicalLayer;
using Metadata;
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
    public partial class Form_Insert : Form
    {
        private BLL_Modality m_BLL = new BLL_Modality();
        private BLL_Customer s_BLL = new BLL_Customer();
        private BLL_Product p_BLL = new BLL_Product();
        private BLL_Category c_BLL = new BLL_Category();
        private BLL_Payment_Method pm_BLL = new BLL_Payment_Method();
        private BLL_User u_BLL = new BLL_User();
        private BLL_Teacher t_BLL = new BLL_Teacher();
        private BLL_Plan pl_BLL = new BLL_Plan();
        private BLL_Plan_User_Customer puc_BLL = new BLL_Plan_User_Customer();
        
        public Form_Insert(Modality m)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Gbb_Modality_Register.Location = new Point(12, 12);
            this.Gbb_Modality_Register.Size = new Size(265, 70);
            this.Gbb_Modality_Register.Visible = true;
        }
        public Form_Insert(Customer c)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Gbb_Customer_Register.Location = new Point(12, 12);
            this.Gbb_Customer_Register.Size = new Size(616, 239);
            this.Gbb_Customer_Register.Visible = true;
            List<Plan> plans = pl_BLL.GetAll().Data;
            Cbb_Plans_1.DataSource = plans.ToList();
            Cbb_Plans_2.DataSource = plans.ToList(); 
            Cbb_Plans_3.DataSource = plans.ToList(); 
            Cbb_Plans_1.ValueMember = "ID";
            Cbb_Plans_2.ValueMember = "ID";
            Cbb_Plans_3.ValueMember = "ID";
            Cbb_Plans_1.DisplayMember = "Display";
            Cbb_Plans_2.DisplayMember = "Display";
            Cbb_Plans_3.DisplayMember = "Display";
        }
        public Form_Insert(Product p)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Gbb_Product_Register.Location = new Point(12, 12);
            this.Gbb_Product_Register.Size = new Size(408, 227);
            this.Gbb_Product_Register.Visible = true;
            this.Cbb_Category.DataSource = c_BLL.GetAll().Data;
            this.Cbb_Category.DisplayMember = "CATEGORY_NAME";
            this.Cbb_Category.ValueMember = "ID";
        }
        public Form_Insert(Category c)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Gbb_Category_Register.Location = new Point(12, 12);
            this.Gbb_Category_Register.Size = new Size(323, 92);
            this.Gbb_Category_Register.Visible = true;
        }
        public Form_Insert(Payment_Method pm)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Gbb_PM_Register.Location = new Point(12, 12);
            this.Gbb_PM_Register.Size = new Size(261, 67);
            this.Gbb_PM_Register.Visible = true;
        }
        public Form_Insert(Plan sc)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Gbb_Plan_Register.Location = new Point(12, 12);
            this.Gbb_Plan_Register.Size = new Size(257, 196);
            this.Gbb_Plan_Register.Visible = true;
            this.Cbb_Modalities.DataSource = m_BLL.GetAll().Data;
            this.Cbb_Modalities.DisplayMember = "MODALITY_NAME";
            this.Cbb_Modalities.ValueMember = "ID";
        }
        public Form_Insert(User u, Users_Role ur)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Gbb_User_Register.Location = new Point(12, 12);
            this.Gbb_User_Register.Size = new Size(255, 172);
            this.Gbb_User_Register.Visible = true;
            this.Cbb_Roles.DataSource = Enum.GetValues(typeof(Users_Role));
            this.Cbb_Roles.SelectedIndex = (int)ur;
            if (ur == Users_Role.Teacher)
            {
                this.Gbb_Teacher_Register.Location = new Point(279, 12);
                this.Gbb_Teacher_Register.Size = new Size(349, 172);
                this.Gbb_Teacher_Register.Visible = true;
            }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Feedback response = new Feedback();
            if (Gbb_User_Register.Visible && Gbb_Teacher_Register.Visible)
            {
                User u = new User();
                u.Email = Txb_User_Email.Text;
                u.User_Password = Txb_User_Password.Text;
                u.Role = (Users_Role)Cbb_Roles.SelectedIndex;
                response = u_BLL.Insert(u);
                if (response.Successful)
                {
                    Teacher t = new Teacher();
                    t.Teacher_Name = Txb_Teacher_Name.Text;
                    t.CPF = Txb_Teacher_CPF.Text.Replace(".","").Replace("-","");
                    t.RG = Txb_Teacher_RG.Text.Replace(".","").Replace("-", "");
                    t.Adress = Txb_Teacher_Adress.Text;
                    t.Phone_Number = Txb_Teacher_PN.Text.Replace("(","").Replace(")","").Replace("-","");
                    t.Wage = Convert.ToDouble(Nud_Teacher_Wage.Value);
                    t.User_ID = u.ID;
                    Feedback _response = t_BLL.Insert(t);
                    if (_response.Successful)
                    {
                        Txb_Teacher_Name.Clear();
                        Txb_Teacher_CPF.Clear();
                        Txb_Teacher_RG.Clear();
                        Txb_Teacher_PN.Clear();
                        Txb_Teacher_Adress.Clear();
                        Nud_Teacher_Wage.Value = Convert.ToDecimal(Basic_Values.MinimumSalary);
                        Txb_User_Email.Clear();
                        Txb_User_Password.Clear();
                    }
                    else
                    {
                        MessageBox.Show(_response.Report);
                        response = u_BLL.Delete(u.ID);
                        return;
                    }
                }
            }
            else if (this.Gbb_Modality_Register.Visible)
            {
                Modality m = new Modality();
                m.Modality_Name = Txb_Modality_Name.Text;
                response = m_BLL.Insert(m);
                if (response.Successful)
                {
                    Txb_Modality_Name.Clear();
                }
            }
            else if (this.Gbb_Customer_Register.Visible)
            {
                Customer s = new Customer();
                s.Customer_Name = Txb_Student_Name.Text;
                s.CPF = Txb_Customer_CPF.Text.Replace(".", "").Replace("-","");
                s.RG = Txb_Customer_RG.Text.Replace(".", "").Replace("-", "");
                s.First_Phone_Number = Txb_Customer_FPN.Text.Replace("(", "").Replace(")", "").Replace("-","");
                s.Second_Phone_Number = Txb_Customer_SPN.Text.Replace("(", "").Replace(")", "").Replace("-", "");
                s.Email = Txb_Student_Email.Text;
                s.BirthDate = Dtp_Birthdate.Value;
                if (s.First_Phone_Number == s.Second_Phone_Number)
                {
                    MessageBox.Show("The second phone number cannot be the same as the first phone number!");
                    return;
                }
                response = s_BLL.Insert(s);
                if (response.Successful)
                {
                    List<Plan_User_Customer> pucs = new List<Plan_User_Customer>();
                    if (Cbb_Plans_1.SelectedIndex != 0)
                    {
                        Plan_User_Customer puc = new Plan_User_Customer();
                        puc.ID_customer = s.ID;
                        puc.The_Customer = s;
                        puc.ID_user = Current_System_User.GetCurrentUser().ID;
                        puc.The_User = Current_System_User.GetCurrentUser();
                        puc.ID_plan = Convert.ToInt32(Cbb_Plans_1.SelectedValue);
                        puc.The_Plan = pl_BLL.GetByID(puc.ID_plan).Item;
                        pucs.Add(puc);
                    }
                    if (Cbb_Plans_2.SelectedIndex != 0)
                    {
                        Plan_User_Customer puc = new Plan_User_Customer();
                        puc.ID_customer = s.ID;
                        puc.The_Customer = s;
                        puc.ID_user = Current_System_User.GetCurrentUser().ID;
                        puc.The_User = Current_System_User.GetCurrentUser();
                        puc.ID_plan = Convert.ToInt32(Cbb_Plans_2.SelectedValue);
                        puc.The_Plan = pl_BLL.GetByID(puc.ID_plan).Item;
                        pucs.Add(puc);
                    }
                    if (Cbb_Plans_3.SelectedIndex != 0)
                    {
                        Plan_User_Customer puc = new Plan_User_Customer();
                        puc.ID_customer = s.ID;
                        puc.The_Customer = s;
                        puc.ID_user = Current_System_User.GetCurrentUser().ID;
                        puc.The_User = Current_System_User.GetCurrentUser();
                        puc.ID_plan = Convert.ToInt32(Cbb_Plans_3.SelectedValue);
                        puc.The_Plan = pl_BLL.GetByID(puc.ID_plan).Item;
                        pucs.Add(puc);
                    }
                    foreach (Plan_User_Customer  item in pucs)
                    {
                        Feedback _response = puc_BLL.Insert(item);
                        if (!_response.Successful)
                        {
                            MessageBox.Show(_response.Report);
                        }
                    }
                    Txb_Student_Name.Clear();
                    Txb_Customer_CPF.Clear();
                    Txb_Customer_RG.Clear();
                    Txb_Customer_FPN.Clear();
                    Txb_Customer_SPN.Clear();
                    Txb_Student_Email.Clear();
                }
            }
            else if (this.Gbb_Category_Register.Visible)
            {
                Category c = new Category();
                c.Category_Name = Txb_Category_Name.Text;
                response = c_BLL.Insert(c);
                if (response.Successful)
                {
                    Txb_Category_Name.Clear();
                }
            }
            else if (this.Gbb_Product_Register.Visible)
            {
                Product p = new Product();
                p.Product_Name = Txb_Product_Name.Text;
                p.Product_Description = Txb_Product_Description.Text;
                p.Category = Convert.ToString(Cbb_Category.SelectedValue);
                response = p_BLL.Insert(p);
                if (response.Successful)
                {
                    Txb_Product_Name.Clear();
                    Txb_Product_Description.Clear();
                    Cbb_Category.Text = "Select a category";
                }
            }
            else if (this.Gbb_PM_Register.Visible)
            {
                Payment_Method pm = new Payment_Method();
                pm.Method = Txb_PM_Name.Text;
                response = pm_BLL.Insert(pm);
                if (response.Successful)
                {
                    Txb_PM_Name.Clear();
                }
            }
            else if (this.Gbb_Plan_Register.Visible)
            {
                if (Convert.ToInt32(Cbb_Modalities.SelectedValue) == Basic_Values.Null_ID)
                {
                    MessageBox.Show("This modality is invalid for a plan!");
                    return;
                }
                Plan sc = new Plan();
                sc.Modality_ID = Convert.ToInt32(Cbb_Modalities.SelectedValue);
                sc.Description = Txb_Plan_Description.Text;
                sc.Price = Convert.ToDouble(Nud_Plan_Price.Value);
                response = pl_BLL.Insert(sc);
                if (response.Successful)
                {
                    Txb_Plan_Description.Clear();
                    Nud_Plan_Price.Value = Basic_Values.Zero;
                }
            }
            else if (Gbb_User_Register.Visible)
            {
                User u = new User();
                u.Email = Txb_User_Email.Text;
                u.User_Password = Txb_User_Password.Text;
                u.Role = (Users_Role)Cbb_Roles.SelectedIndex;
                response = u_BLL.Insert(u);
                if (response.Successful)
                {
                    Txb_User_Email.Clear();
                    Txb_User_Password.Clear();
                }
            }
            else
            {
                response.Report = "Please select an operation!";
            }
            MessageBox.Show(response.Report);
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
