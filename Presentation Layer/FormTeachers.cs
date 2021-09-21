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
    public partial class FormTeachers : Form
    {
        private BLL_Teachers t_BLL = new BLL_Teachers();
        public FormTeachers()
        {

        }
        public FormTeachers(Users u)
        {
            InitializeComponent();
            this.Load += Form_Load;
            this.Lbl_User_ID.Text = u.ID.ToString();
        }
        
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.UpdateGrid();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            Data_Feedback<Teachers> response = t_BLL.GetAll();
            if (response.Successful)
            {
            }
            else
            {
                MessageBox.Show(response.Report);
            }
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.Teacher_Name = Txb_New_Data.Text;
            t.CPF = Txb_CPF.Text;
            t.RG = Txb_RG.Text;
            t.Adress = Txb_Adress.Text;
            t.Phone_Number = Txb_Phone_Number.Text;
            t.Wage = Convert.ToDouble(Nud_Wage.Value);
            Feedback response = t_BLL.Insert(t);
            MessageBox.Show(response.Report);
            UpdateGrid();
            this.Txb_New_Data.Clear();
        }

        private void Btn_Update_List_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
