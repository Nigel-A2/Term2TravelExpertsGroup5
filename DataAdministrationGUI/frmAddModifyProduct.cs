using DataAdministrationData.Models;
using System;
using System.Windows.Forms;
using DataAdministrationData;
using System.Linq;

// written by: Filip Florek
namespace DataAdministrationGUI
{
	public partial class frmAddModifyProduct : Form
	{
        //determines if form is supposed to add or modify product
		public bool isAdd;
		public Product product;

		public frmAddModifyProduct()
		{
			InitializeComponent();
		}

        //adjust headers and product value
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

        //validate product name
        private bool ValidateProduct()
        {
            return Validator.IsPresent(tbxProductName) && tbxProductName.TextLength <= Product.MAX_NAME_LENGTH && checkIfNameIsUnique(tbxProductName.Text);
        }

        private bool checkIfNameIsUnique(string productName)
        {
            bool result = true;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                var uniqueNameQuery = db.Products.Where(p => p.ProdName.Equals(productName)).FirstOrDefault();
                if(uniqueNameQuery != null)
                {
                    result = false;
                }
            }
            if(result == false)
            {
                MessageBox.Show("Product name has to be unique!");
            }
            return result;
        }
    }
}
