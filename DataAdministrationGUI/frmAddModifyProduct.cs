using DataAdministrationGUI.Models;
using System;
using System.Windows.Forms;
// written by: Filip
namespace DataAdministrationGUI
{
	public partial class frmAddModifyProduct : Form
	{

		public bool isAdd;
		public Product product;

		public frmAddModifyProduct()
		{
			InitializeComponent();
		}

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                this.Text = "Add Product";
                lblHeader.Text = "Add Product";
                tbxProductId.Text = "ID is generated automatically";
            }
            else
            {
                this.Text = "Modify Product";
                lblHeader.Text = "Modify Product";
                if (product == null)
                {
                    MessageBox.Show("There is no data of selected product", "Modify Error");
                    this.Close();
                }
                else
                {
                    tbxProductId.Text = Convert.ToString(product.ProductId);
                    tbxProductName.Text = product.ProdName;
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (ValidateProduct())
            {
                if (isAdd)
                {
                    product = new Product();
                }
                product.ProdName = tbxProductName.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidateProduct()
        {
            return Validator.IsPresent(tbxProductName) && tbxProductName.TextLength <= Product.MAX_NAME_LENGTH;
        }
    }
}
