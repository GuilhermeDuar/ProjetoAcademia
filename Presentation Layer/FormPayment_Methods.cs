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
    public partial class FormPayment_Methods : Form
    {
        private BLL_Payment_Methods pm_BLL = new BLL_Payment_Methods();
        public FormPayment_Methods()
        {
            InitializeComponent();
            this.Load += Form_Load;
            this.Dvg_Data.CellDoubleClick += Dgv_CellDoubleClick;
        }
        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Payment_Methods pm = (Payment_Methods)this.Dvg_Data.Rows[e.RowIndex].DataBoundItem;
            FormEditDelete_PaymentMethods frm = new FormEditDelete_PaymentMethods(pm);
            frm.ShowDialog();
            this.UpdateGrid();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            Data_Feedback<Payment_Methods> response = pm_BLL.GetAll();
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
            Payment_Methods pm = new Payment_Methods();
            pm.Method = Txb_New_Data.Text;
            Feedback response = pm_BLL.Insert(pm);
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
