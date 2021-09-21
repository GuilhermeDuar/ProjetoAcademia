using BusinessLogicalLayer;
using Metadata;
using Presentation_Layer.GridViewModel;
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
    public partial class Form_Business : Form
    {
        private Importation importation;
        private Exportation exportation;
        private Product current_Product;
        private List<Import_Item> imports = new List<Import_Item>();
        private List<Export_Item> exports = new List<Export_Item>();
        private List<Product> selected_Products = new List<Product>();
        private BLL_Exportation e_BLL = new BLL_Exportation();
        private BLL_Importation i_BLL = new BLL_Importation();
        private BLL_Product p_BLL = new BLL_Product();
        private BLL_Payment_Method pm_BLL = new BLL_Payment_Method();
        private BLL_Customer c_BLL = new BLL_Customer();
        public Form_Business(Exportation ex)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            exportation = ex;
            List<Product> gridData = p_BLL.GetAll().Data;
            List<Product_GVM> gridData_all_GVM = new List<Product_GVM>();
            foreach (Product item in gridData)
            {
                Product_GVM p_GVM = new Product_GVM()
                {
                    ID = item.ID,
                    Info = item.ToString(),
                    Stock = item.Stock,
                    Price = item.Price.ToString("C2")
                };
                gridData_all_GVM.Add(p_GVM);
            }
            this.Dgv_Products.DataSource = gridData_all_GVM;
            this.Cbb_Customers.DataSource = c_BLL.GetAll().Data;
            this.Cbb_PM.DataSource = pm_BLL.GetAll().Data;
            this.Cbb_Customers.DisplayMember = "CUSTOMER_NAME";
            this.Cbb_Customers.ValueMember = "ID";
            this.Cbb_PM.DisplayMember = "METHOD";
            this.Cbb_PM.ValueMember = "ID";
            this.Cbb_Customers.Enabled = true;
            this.Cbb_PM.Enabled = true;
            this.label2.Text = "Amount";
            this.Nud_Product_Stock.Enabled = true;
            this.Dgv_Cart.CellDoubleClick += Dgv_Cart_CellDoubleClick;
            this.Dgv_Products.CellDoubleClick += Dgv_Products_CellDoubleClick;
        }

        public Form_Business(Importation im)
        {
            InitializeComponent();
            Current_Theme.SetCurrentTheme(this);
            importation = im;
            List<Product> gridData = p_BLL.GetAll().Data;
            List<Product_GVM> gridData_all_GVM = new List<Product_GVM>();
            foreach (Product item in gridData)
            {
                Product_GVM p_GVM = new Product_GVM()
                {
                    ID = item.ID,
                    Info = item.ToString(),
                    Stock = item.Stock,
                    Price = item.Price.ToString("C2")
                };
                gridData_all_GVM.Add(p_GVM);
            }
            this.Dgv_Products.DataSource = gridData_all_GVM;
            this.Nud_Product_Price.Enabled = true;
            this.Nud_Product_Stock.Enabled = true;
            this.Dgv_Cart.CellDoubleClick += Dgv_Cart_CellDoubleClick;
            this.Dgv_Products.CellDoubleClick += Dgv_Products_CellDoubleClick;
        }

        private void Dgv_Cart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < Basic_Values.Zero)
            {
                return;
            }
            Product_GVM p_GVM = (Product_GVM)this.Dgv_Cart.Rows[e.RowIndex].DataBoundItem;
            current_Product = p_BLL.GetByID(p_GVM.ID).Item;
            Txb_Product_Name.Text = current_Product.Product_Name;
            Txb_Product_Description.Text = current_Product.Product_Description;
            Txb_Product_Category.Text = current_Product.Category;
            Nud_Product_Price.Value = Convert.ToDecimal(current_Product.Price);
            Nud_Product_Stock.Value = Convert.ToDecimal(current_Product.Stock);
        }

        private void Dgv_Products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < Basic_Values.Zero)
            {
                return;
            }
            Product_GVM p_GVM = (Product_GVM)this.Dgv_Products.Rows[e.RowIndex].DataBoundItem;
            current_Product = p_BLL.GetByID(p_GVM.ID).Item;
            Txb_Product_Name.Text = current_Product.Product_Name;
            Txb_Product_Description.Text = current_Product.Product_Description;
            Txb_Product_Category.Text = current_Product.Category;
            Nud_Product_Price.Value = Convert.ToDecimal(current_Product.Price);
            Nud_Product_Stock.Value = Convert.ToDecimal(current_Product.Stock);
        }

        private void Btn_AddToCart_Click(object sender, EventArgs e)
        {
            if (Nud_Product_Price.Value == Basic_Values.Zero || Nud_Product_Stock.Value == Basic_Values.Zero)
            {
                MessageBox.Show("Stock and price value must be higher than zero!");
                return;
            }
            Product p = new Product()
            {
                ID = current_Product.ID,
                Product_Name = current_Product.Product_Name,
                Product_Description = current_Product.Product_Description,
                Category = current_Product.Category,
                Stock = Convert.ToInt32(Nud_Product_Stock.Value),
                Price = Convert.ToDouble(Nud_Product_Price.Value)
            };
            Product verify = selected_Products.Find(sp => sp.ID == p.ID);
            if (verify != null)
            {
                MessageBox.Show("This product is already in the list!");
                return;
            }
            selected_Products.Add(p);
            List<Product_GVM> gridData_selected_GVM = new List<Product_GVM>();
            foreach (Product item in selected_Products)
            {
                Product_GVM p_GVM = new Product_GVM()
                {
                    ID = item.ID,
                    Info = item.ToString(),
                    Stock = item.Stock,
                    Price = item.Price.ToString("C2")
                };
                gridData_selected_GVM.Add(p_GVM);
            }
            Dgv_Cart.DataSource = gridData_selected_GVM;
            this.Txb_Product_Name.Clear();
            this.Txb_Product_Description.Clear();
            this.Txb_Product_Category.Clear();
            this.Nud_Product_Stock.Value = Basic_Values.Zero;
            this.Nud_Product_Price.Value = Basic_Values.Zero;
        }

        private void Btn_RemoveFromCart_Click(object sender, EventArgs e)
        {
            current_Product.Stock = Convert.ToInt32(Nud_Product_Stock.Value);
            current_Product.Price = Convert.ToDouble(Nud_Product_Price.Value);
            Product removal = selected_Products.Find(p => p.ID == current_Product.ID);
            selected_Products.Remove(removal);
            List<Product_GVM> gridData_selected_GVM = new List<Product_GVM>();
            foreach (Product item in selected_Products)
            {
                Product_GVM p_GVM = new Product_GVM()
                {
                    ID = item.ID,
                    Info = item.ToString(),
                    Stock = item.Stock,
                    Price = item.Price.ToString("C2")
                };
                gridData_selected_GVM.Add(p_GVM);
            }
            Dgv_Cart.DataSource = gridData_selected_GVM;
            this.Txb_Product_Name.Clear();
            this.Txb_Product_Description.Clear();
            this.Txb_Product_Category.Clear();
            this.Nud_Product_Stock.Value = Basic_Values.Zero;
            this.Nud_Product_Price.Value = Basic_Values.Zero;
        }

        private void Btn_StartTransaction_Click(object sender, EventArgs e)
        {
            Feedback response = new Feedback();
            if (importation != null)
            {
                Importation transaction = new Importation();
                transaction.Current_User = Current_System_User.GetCurrentUser();
                transaction.User_ID = Current_System_User.GetCurrentUser().ID;
                foreach (Product item in selected_Products)
                {
                    Import_Item import = new Import_Item()
                    {
                        Product_ID = item.ID,
                        Imported_Product = item,
                        Amount = item.Stock,
                        Unitary_Value = item.Price
                    };
                    imports.Add(import);
                }
                transaction.Imported_products = imports.ToList();
                transaction.TotalPrice = imports.Sum(p => p.Amount * p.Unitary_Value);
                response = i_BLL.Insert(transaction);
                MessageBox.Show(response.Report);
            }
            else
            {
                Exportation transaction = new Exportation();
                transaction.User_ID = Current_System_User.GetCurrentUser().ID;
                transaction.Customer_ID = Convert.ToInt32(Cbb_Customers.SelectedValue);
                transaction.ID_Payment_Method = Convert.ToInt32(Cbb_PM.SelectedValue);
                transaction.Current_User = Current_System_User.GetCurrentUser();
                transaction.Customer = c_BLL.GetByID(Convert.ToInt32(Cbb_Customers.SelectedValue)).Item;
                transaction.PM = pm_BLL.GetByID(Convert.ToInt32(Cbb_PM.SelectedValue)).Item;
                foreach (Product item in selected_Products)
                {
                    Export_Item export = new Export_Item()
                    {
                        Product_ID = item.ID,
                        Exported_Product = item,
                        Amount = item.Stock,
                        Unitary_Value = item.Price
                    };
                    exports.Add(export);
                }
                transaction.Exported_products = exports.ToList();
                transaction.TotalValue = exports.Sum(p => p.Amount * p.Unitary_Value);
                response = e_BLL.Insert(transaction);
                MessageBox.Show(response.Report);
            }
            if (response.Successful)
            {
                this.Close();
            }
        }

        private void Btn_CancelTransaction_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
