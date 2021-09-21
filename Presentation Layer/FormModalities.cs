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
    public partial class FormModalities : Form
    {
        private BLL_Modalities m_BLL = new BLL_Modalities();
        public FormModalities()
        {
            InitializeComponent();
            this.Load += Form_Load;
            this.Dvg_Data.CellDoubleClick += Dgv_CellDoubleClick;
        }
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modalities m = (Modalities)this.Dvg_Data.Rows[e.RowIndex].DataBoundItem;
            FormEditDelete_Modalities frm = new FormEditDelete_Modalities(m);
            frm.ShowDialog();
            this.UpdateGrid();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            Data_Feedback<Modalities> response = m_BLL.GetAll();
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
            Modalities c = new Modalities();
            c.Modality_Name = Txb_New_Data.Text;
            c.Modality_Description = Txb_Description.Text;
            c.Price = Convert.ToDouble(Nud_Price.Value);
            Feedback response = m_BLL.Insert(c);
            MessageBox.Show(response.Report);
            UpdateGrid();
            this.Txb_New_Data.Clear();
        }

        private void Btn_UpdateGrid_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
