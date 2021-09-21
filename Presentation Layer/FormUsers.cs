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
    public partial class FormUsers : Form
    {
        private BLL_Users u_BLL = new BLL_Users();
        public FormUsers()
        {
            InitializeComponent();
            this.Load += Form_Load;
            this.Dvg_Data.CellDoubleClick += Dgv_CellDoubleClick;
        }
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Users u = (Users)this.Dvg_Data.Rows[e.RowIndex].DataBoundItem;
            FormEditFire_Users frm = new FormEditFire_Users(u);
            frm.ShowDialog();
            this.UpdateGrid();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            Data_Feedback<Users> response = u_BLL.GetAll();
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
            Users u = new Users();
            u.Email = Txb_Email.Text;
            u.User_Password= Txb_Password.Text;
            u.Role = (Users_Roles)Cbb_Users_Roles.SelectedIndex;
            Feedback response = u_BLL.Insert(u);
            MessageBox.Show(response.Report);
            if (u.Role == Users_Roles.Teacher)
            {
                FormTeachers frm = new FormTeachers(u);
                frm.ShowDialog();
            }
            UpdateGrid();

        }

        private void Btn_Update_List_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void Cbb_Users_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbb_Users_Roles.SelectedIndex == 2)
            {
                gbTeacher.Visible = true;
            }
            else
            {
                gbTeacher.Visible = false;
            }
        }
    }
}
