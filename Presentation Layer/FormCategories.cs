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
    public partial class FormCategories : Form
    {
        private BLL_Categories c_BLL = new BLL_Categories();
        public FormCategories()
        {
            InitializeComponent();
            this.Load += Form_Load;
            this.Dvg_Data.CellDoubleClick += Dgv_CellDoubleClick;
        }
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Categories c = (Categories)this.Dvg_Data.Rows[e.RowIndex].DataBoundItem;
            FormEditDelete_Categories frm = new FormEditDelete_Categories(c); 
            frm.ShowDialog();
            this.UpdateGrid();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            Data_Feedback<Categories> response = c_BLL.GetAll();
            if (response.Successful)
            {
                this.Dvg_Data.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Report);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();
            c.Category_Name = Txb_New_Data.Text;
            Feedback response = c_BLL.Insert(c);
            MessageBox.Show(response.Report);
            UpdateGrid();
            this.Txb_New_Data.Clear();
        }

        private void btnUpdateGrid_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
