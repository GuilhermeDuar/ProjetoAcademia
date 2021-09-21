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
    public partial class FormProducts : Form
    {
        private BLL_Products p_BLL = new BLL_Products();
        private BLL_Categories c_BLL = new BLL_Categories();
        public FormProducts()
        {
            InitializeComponent();
            this.Cbb_Category.DataSource = c_BLL.GetAll().Data; 
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Product_Name = Txb_New_Data.Text;
            p.Product_Description = Txb_Description.Text;
            p.Category = Cbb_Category.SelectedIndex;
            p.Stock = Convert.ToInt32(Nud_Stock.Value);
            p.Price = Convert.ToDouble(Nud_Price.Value);
            Feedback response = p_BLL.Insert(p);
            MessageBox.Show(response.Report);
            this.Txb_New_Data.Clear();
        }
        
    }
}
