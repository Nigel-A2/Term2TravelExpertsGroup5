using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdministrationGUI
{
	public partial class frmAddModifyProductsToPackage : Form
	{

		/*
		* public bool isAdd;
		public Product product;
		*/

		public frmAddModifyProductsToPackage()
		{
			InitializeComponent();
		}

		private void frmAddModifyProductsToPackage_Load(object sender, EventArgs e)
		{
			/*
			 * if (isAdd)
            {
                this.Text = "Add products to a package";
                tbxProductId.Text = "ID is generated automatically";
            }
            else
            {
                this.Text = "Modify Product";
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
			 */
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			/*
			 * if (ValidateProduct())
            {
                if (isAdd)
                {
                    product = new Product();
                }
                product.ProdName = tbxProductName.Text;
                this.DialogResult = DialogResult.OK;
            }
			 */
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			/*
			 * this.Close();
			 */
		}

		/*
		 * private bool ValidateProduct()
        {
            return Validator.IsPresent(tbxProductName) && tbxProductName.TextLength <= Product.MAX_NAME_LENGTH;
        }
		 */
	}
}
