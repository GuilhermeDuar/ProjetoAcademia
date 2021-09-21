using BusinessLogicalLayer;
using Metadata;
using Metadata.GridViewModel;
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
    public partial class FormSellProducts : Form
    {
        BLL_Product p_BLL = new BLL_Product();
        public FormSellProducts()
        {
            InitializeComponent();
            this.Load += FormSellProducts_Load;
        }

        private void FormSellProducts_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

        }
        private void AtualizarGrid()
        {
            Data_Feedback<Products_GVM> response = p_BLL.GetAll();
            if (response.Successful)
            {
                List<Products_GVM> data = response.Data;
                foreach (Products_GVM item in data)
                {
                    clbProducts.Items.Add(item.ToString(), false);
                }
            }
            else
            {
                MessageBox.Show(response.Report);
            }
        }
    }
}
