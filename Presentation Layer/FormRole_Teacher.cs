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
    public partial class FormRole_Teacher : Form
    {
        int i = Basic_Values.Zero;
        private BLL_Plan sc_BLL = new BLL_Plan();
        private BLL_User u_BLL = new BLL_User();
        private BLL_Modality m_BLL = new BLL_Modality();
        private BLL_Customer s_BLL = new BLL_Customer();
        private BLL_Plan pl_BLL = new BLL_Plan();
        private BLL_Plan_User_Customer puc_BLL = new BLL_Plan_User_Customer();
        private char[] welcomeMessage = { 'W', 'e', 'l', 'c', 'o', 'm', 'e', '!', ' ', 'W', 'e', ' ', 'w', 'i', 's', 'h', ' ', 'y', 'o', 'u', ' ', 'h', 'a', 'v', 'e', ' ', 'a', ' ', 'g', 'o', 'o', 'd', ' ', 'd', 'a', 'y', ' ', 'o', 'f', ' ', 'w', 'o', 'r', 'k', '!' };
        public FormRole_Teacher()
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            this.Ssl_Current_User.Text += $"{Current_System_User.GetCurrentUser()} - (Tap in the icon to see more)";
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
            if (t.Name == "Customer_GVM")
            {
                Customer_GVM s_GVM = (Customer_GVM)unidentified;
                Customer s = s_BLL.GetByID(s_GVM.ID).Item;
                Form_Edit frm = new Form_Edit(s);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Customer> response = s_BLL.GetAll();
                List<Customer_GVM> GridData = new List<Customer_GVM>();
                foreach (Customer item in response.Data)
                {
                    Customer_GVM c_GVM = new Customer_GVM()
                    {
                        ID = item.ID,
                        Name = item.Customer_Name,
                        Active = item.Active
                    };
                    GridData.Add(c_GVM);
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
            if (t.Name == "Modality")
            {
                Modality m = (Modality)unidentified;
                if (m.ID == Basic_Values.Null_ID)
                {
                    MessageBox.Show("Please don't change this modality!");
                    return;
                }
                Form_Edit frm = new Form_Edit(m);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Modality> response = m_BLL.GetAll();
                this.ValidateResult<Modality>(response);
            }
            if (t.Name == "Plan_GVM")
            {
                Plan_GVM gridData = (Plan_GVM)unidentified;
                Plan sc = sc_BLL.GetByID(gridData.ID).Item;
                if (sc.ID == Basic_Values.Null_ID)
                {
                    MessageBox.Show("Please don't change this plan!");
                    return;
                }
                Form_Edit frm = new Form_Edit(sc);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Data_Feedback<Plan> response = sc_BLL.GetAll();
                List<Plan_GVM> GridData = new List<Plan_GVM>();
                foreach (Plan item in response.Data)
                {
                    Plan_GVM p_GVM = new Plan_GVM()
                    {
                        ID = item.ID,
                        Info = item.Display
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
            }
        }
        private void Tsm_Customer_Insert_Click(object sender, EventArgs e)
        {
            HomePage(false);
            Form_Insert frm = new Form_Insert(new Customer());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Data_Feedback<Customer> response = s_BLL.GetAll();
            List<Customer_GVM> GridData = new List<Customer_GVM>();
            foreach (Customer item in response.Data)
            {
                Customer_GVM c_GVM = new Customer_GVM()
                {
                    ID = item.ID,
                    Name = item.Customer_Name,
                    Active = item.Active
                };
                GridData.Add(c_GVM);
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

        private void Tsm_Customer_List_Click(object sender, EventArgs e)
        {
            HomePage(false);
            Data_Feedback<Customer> response = s_BLL.GetAll();
            List<Customer_GVM> GridData = new List<Customer_GVM>();
            foreach (Customer item in response.Data)
            {
                Customer_GVM c_GVM = new Customer_GVM()
                {
                    ID = item.ID,
                    Name = item.Customer_Name,
                    Active = item.Active
                };
                GridData.Add(c_GVM);
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
        private void Tsm_Arrangement_List_Click(object sender, EventArgs e)
        {
            HomePage(false);
            Data_Feedback<Plan_User_Customer> response = puc_BLL.GetAll();
            List<PUC_GVM> GridData = new List<PUC_GVM>();
            foreach (Plan_User_Customer item in response.Data)
            {
                PUC_GVM p_GVM = new PUC_GVM()
                {
                    ID = item.ID_customer,
                    Name = item.The_Customer.Customer_Name,
                    Plan = item.The_Plan.Display,
                    Register = item.The_User.Email,
                    Active = item.Active
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
        }

        private void Tsm_Schedule_Insert_Click(object sender, EventArgs e)
        {
            HomePage(false);
            Form_Insert frm = new Form_Insert(new Plan());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Data_Feedback<Plan> response = sc_BLL.GetAll();
            List<Plan_GVM> GridData = new List<Plan_GVM>();
            foreach (Plan item in response.Data)
            {
                Plan_GVM p_GVM = new Plan_GVM()
                {
                    ID = item.ID,
                    Info = item.Display
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
        }

        private void Tsm_Schedule_List_Click(object sender, EventArgs e)
        {
            HomePage(false);
            Data_Feedback<Plan> response = sc_BLL.GetAll();
            List<Plan_GVM> GridData = new List<Plan_GVM>();
            foreach (Plan item in response.Data)
            {
                Plan_GVM p_GVM = new Plan_GVM()
                {
                    ID = item.ID,
                    Info = item.Display
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
        }

        private void Tsm_Modalities_Insert_Click(object sender, EventArgs e)
        {
            Form_Insert frm = new Form_Insert(new Modality());
            this.Hide();
            frm.ShowDialog();
            this.Show();
            Data_Feedback<Modality> response = m_BLL.GetAll();
            this.ValidateResult<Modality>(response);
        }

        private void Tsm_Modalities_List_Click(object sender, EventArgs e)
        {
            Data_Feedback<Modality> response = m_BLL.GetAll();
            this.ValidateResult<Modality>(response);
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
            User u = Current_System_User.GetCurrentUser();
            Teacher t = u_BLL.MatchTeacher(u).Item;
            Form_Edit frm = new Form_Edit(u, t);
            frm.ShowDialog();
            this.Show();
        }

        private void Tsm_Change_theme_Click(object sender, EventArgs e)
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
