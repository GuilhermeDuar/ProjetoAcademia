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
    public partial class FormEditFire_Users : Form
    {
        private BLL_Users u_BLL = new BLL_Users();
        public FormEditFire_Users(Users u)
        {
            InitializeComponent();
            this.Lbl_ID.Text = u.ID.ToString();
            this.Txb_Name.Text = "em andamento";
            this.Txb_Email.Text = u.Email;
            this.Txb_Password.Text = u.User_Password;
            this.Cbb_Users_Roles.Text = (string)u.Role.ToString();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Feedback response = u_BLL.Update(new Users()
            {
                ID = int.Parse(Lbl_ID.Text),
                //User_Name = Txb_Name.Text,
                Email = Txb_Email.Text,
                User_Password = Txb_Password.Text,
                Role = (Users_Roles)Cbb_Users_Roles.SelectedIndex,
            });
            MessageBox.Show(response.Report);
            Txb_Name.Clear();
            Txb_Email.Clear();
            Txb_Password.Clear();
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_Dismiss_User_Click(object sender, EventArgs e)
        {
            Feedback response = u_BLL.Turn_Desactivated(int.Parse(Lbl_ID.Text));
            MessageBox.Show(response.Report);
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_Readmit_User_Click(object sender, EventArgs e)
        {
            Feedback response = u_BLL.Turn_Activated(int.Parse(Lbl_ID.Text));
            MessageBox.Show(response.Report);
            if (response.Successful)
            {
                this.Close();
            }
        }
    }
}
