using DataAdministrationGUI.Models;
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

		
		 public bool isAdd;
			public PackagesProductsSupplier packageProduct;
		

		public frmAddModifyProductsToPackage()
		{
			InitializeComponent();
		}

		private void frmAddModifyProductsToPackage_Load(object sender, EventArgs e)
		{

			if (isAdd)
			{
				this.Text = "Add products to a package";
			}
			else
			{
				this.Text = "Modify product of a package";
				if (packageProduct == null)
				{
					MessageBox.Show("There is no data selected", "Modify Error");
					this.Close();
				}
				else
				{
					txtPackageID.Text = Convert.ToString(packageProduct.PackageId);
					
				}
			}

		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{

			 if (ValidateProduct())
			{
				if (isAdd)
				{
					packageProduct = new PackagesProductsSupplier();
				}
				
				this.DialogResult = DialogResult.OK;
			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			  this.Close();
		}

		
		 private bool ValidateProduct()
		{
			return Validator.IsPresent(txtPackageID);
		}

	}
}
