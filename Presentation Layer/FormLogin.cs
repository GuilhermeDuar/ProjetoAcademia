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
using System.Drawing.Imaging;

namespace Presentation_Layer
{
    public partial class FormLogin : Form
    {
        BLL_User u_BLL = new BLL_User();
        public FormLogin()
        {
            InitializeComponent();
            
            Current_Theme.SetCurrentTheme(this);
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string error = (string.IsNullOrWhiteSpace(Txb_Email.Text) || string.IsNullOrWhiteSpace(Txb_Password.Text)) ? "All field must be informed!" : "";
            if (!string.IsNullOrWhiteSpace(error))
            {
                Lbl_Error.Text = error;
                return;
            }
            User u = new User() { Email = Txb_Email.Text, User_Password = Txb_Password.Text };
            Single_Feedback<User> response = u_BLL.Search(u);
            if (response.Successful)
            {
                if (response.Item.Active)
                {
                    Txb_Email.Clear();
                    Txb_Password.Clear();
                    Lbl_Error.Text = "";
                    u = response.Item;
                    this.Hide();
                    switch (u.Role)
                    {
                        case Users_Role.Administrator:
                            FormRole_Admin frmAdmin = new FormRole_Admin();
                            frmAdmin.ShowDialog();
                            break;
                        case Users_Role.Manager:
                            FormRole_Manager frmManager = new FormRole_Manager();
                            frmManager.ShowDialog();
                            break;
                        case Users_Role.Teacher:
                            FormRole_Teacher frmStudents = new FormRole_Teacher();
                            frmStudents.ShowDialog();
                            break;
                    }
                    this.Show();
                    Current_Theme.SetCurrentTheme(this);
                }
                else
                {
                    Lbl_Error.Text = "This user is desactivated, and it is not allowed to use this system";
                    return;
                }
            }
            else
            {
                Lbl_Error.Text = response.Report;
            }
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Change__Click(object sender, EventArgs e)
        {
            Current_Theme.SwitchCurrentTheme(this);
        }

        
    }
}
