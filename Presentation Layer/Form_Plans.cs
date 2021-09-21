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
    public partial class Form_Plans : Form
    {
        private int customer_ID;
        private int customer_plan_ID;
        private int Selected_plan;
        private BLL_Plan pl_BLL = new BLL_Plan();
        private BLL_Plan_User_Customer puc_BLL = new BLL_Plan_User_Customer();
        private BLL_Customer s_BLL = new BLL_Customer();
        private BLL_User u_BLL = new BLL_User();
        public Form_Plans(Customer c)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            customer_ID = c.ID;
            List<Plan> all_Plans = pl_BLL.GetAll().Data;
            List<Plan_GVM> all_Plans_GVM = new List<Plan_GVM>();
            foreach (Plan item in all_Plans)
            {
                Plan_GVM pl_GVM = new Plan_GVM()
                {
                    ID = item.ID,
                    Info = item.Display
                };
                all_Plans_GVM.Add(pl_GVM);
            }
            this.Dgv_All_Plans.DataSource = all_Plans_GVM;
            List<Plan_User_Customer> customer_Puc = puc_BLL.GetAll().Data.Where(p => p.ID_customer == c.ID && p.Active == true).ToList();
            List<PUC_GVM> customer_Plans = new List<PUC_GVM>();
            foreach (Plan_User_Customer item in customer_Puc)
            {
                PUC_GVM puc = new PUC_GVM()
                {
                    ID = item.ID_plan,
                    Name = item.The_Customer.Customer_Name,
                    Plan = item.The_Plan.Display,
                    Register = item.The_User.Email,
                    Active = item.Active
                };
                customer_Plans.Add(puc);
            }
            Dgv_Customer_Plans.DataSource = customer_Plans;
            this.Dgv_Customer_Plans.CellDoubleClick += Dvg_Customer_Plans_CellDoubleClick;
            this.Dgv_All_Plans.CellDoubleClick += Dvg_All_Plans_CellDoubleClick;
        }

        private void Dvg_All_Plans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < Basic_Values.Zero)
            {
                return;
            }
            Plan_GVM unidentified = (Plan_GVM)this.Dgv_All_Plans.Rows[e.RowIndex].DataBoundItem;
            Plan pl = pl_BLL.GetByID(unidentified.ID).Item;
            this.Txb_Plan_Modality.Text = pl.m.Modality_Name;
            this.Txb_Plan_Description.Text = pl.Description;
            this.Nud_Plan_Price.Value = Convert.ToDecimal(pl.Price);
            Selected_plan = pl.ID;
        }

        private void Dvg_Customer_Plans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < Basic_Values.Zero)
            {
                return;
            }
            PUC_GVM unidentified = (PUC_GVM)this.Dgv_Customer_Plans.Rows[e.RowIndex].DataBoundItem;
            Plan pl = pl_BLL.GetByID(unidentified.ID).Item;
            this.Txb_Customer_Plan_Modality.Text = pl.m.Modality_Name;
            this.Txb_Customer_Plan_Description.Text = pl.Description;
            this.Nud_Customer_Plan_Price.Value = Convert.ToDecimal(pl.Price);
            customer_plan_ID = pl.ID;
        }

        private void Btn_Remove_Customer_Plan_Click(object sender, EventArgs e)
        {
            Feedback response = puc_BLL.Turn_Desactivated(customer_ID, customer_plan_ID);
            if (response.Successful)
            {
                Txb_Customer_Plan_Modality.Clear();
                Txb_Customer_Plan_Description.Clear();
                Nud_Customer_Plan_Price.Value = Convert.ToDecimal(Basic_Values.Zero);
            }
            MessageBox.Show(response.Report);
            List<Plan_User_Customer> customer_Puc = puc_BLL.GetAll().Data.Where(p => p.ID_customer == customer_ID && p.Active == true).ToList();
            List<PUC_GVM> customer_Plans = new List<PUC_GVM>();
            foreach (Plan_User_Customer item in customer_Puc)
            {
                PUC_GVM puc2 = new PUC_GVM()
                {
                    ID = item.ID_plan,
                    Name = item.The_Customer.Customer_Name,
                    Plan = item.The_Plan.Display,
                    Register = item.The_User.Email,
                    Active = item.Active
                };
                customer_Plans.Add(puc2);
            }
            Dgv_Customer_Plans.DataSource = customer_Plans.ToList();
        }

        private void Btn_Add_Plan_Customer_Click(object sender, EventArgs e)
        {
            Plan_User_Customer puc = new Plan_User_Customer()
            {
                ID_customer = customer_ID,
                The_Customer = s_BLL.GetByID(customer_ID).Item,
                ID_plan = Selected_plan,
                The_Plan = pl_BLL.GetByID(Selected_plan).Item,
                ID_user = Current_System_User.GetCurrentUser().ID,
                The_User = Current_System_User.GetCurrentUser()
            };
            Feedback response = puc_BLL.Insert(puc);
            if (!response.Successful && response.Report == "This user is already registered in this plan!")
            {
                response = puc_BLL.Turn_Activate(puc.ID_customer, puc.ID_plan);
            }
            MessageBox.Show(response.Report);
            List<Plan_User_Customer> customer_Puc = puc_BLL.GetAll().Data.Where(p => p.ID_customer == customer_ID && p.Active == true).ToList();
            List<PUC_GVM> customer_Plans = new List<PUC_GVM>();
            foreach (Plan_User_Customer item in customer_Puc)
            {
                PUC_GVM puc2 = new PUC_GVM()
                {
                    ID = item.ID_plan,
                    Name = item.The_Customer.Customer_Name,
                    Plan = item.The_Plan.Display,
                    Register = item.The_User.Email,
                    Active = item.Active
                };
                customer_Plans.Add(puc2);
            }
            Dgv_Customer_Plans.DataSource = customer_Plans.ToList();
        }

        private void Btn_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
