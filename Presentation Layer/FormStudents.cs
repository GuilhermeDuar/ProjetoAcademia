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
    public partial class FormStudents : Form
    {
        private BLL_Students s_BLL = new BLL_Students();
        public FormStudents()
        {
            InitializeComponent();
            this.Load += Form_Load;
            this.Dvg_Data.CellDoubleClick += Dgv_CellDoubleClick;
        }
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Students s = (Students)this.Dvg_Data.Rows[e.RowIndex].DataBoundItem;
            FormEditActive_Students frm = new FormEditActive_Students(s);
            frm.ShowDialog();
            this.UpdateGrid();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            Data_Feedback<Students> response = s_BLL.GetAll();
            if (response.Successful)
            {
                this.Dvg_Data.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Report);
            }
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.Student_Name = Txb_New_Data.Text;
            s.CPF = Txb_CPF.Text;
            s.RG = Txb_RG.Text;
            s.First_Phone_Number = Txb_FPN.Text;
            s.Second_Phone_Number = Txb_SPN.Text;
            s.Email = Txb_Email.Text;
            s.BirthDate = Dtp_Birthdate.Value;
            Feedback response = s_BLL.Insert(s);
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
