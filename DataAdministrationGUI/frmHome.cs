using System;
using System.Windows.Forms;


// written by: Nigel
namespace DataAdministrationGUI
{
	public partial class frmHome : Form
	{
		public frmHome()
		{
			InitializeComponent();
		}

		// go to frmProductMaintenance
		private void btnProducts_Click(object sender, EventArgs e)
		{
			var productForm = new frmProductMaintenance();
			DialogResult result = productForm.ShowDialog();
		}

		// go to frmSupplierMaintenance
		private void btnSuppliers_Click(object sender, EventArgs e)
		{
			var supplierForm = new frmSupplierMaintenance();
			DialogResult result = supplierForm.ShowDialog();
		}

		// go to frmPackageMaintenance
		private void btnPackages_Click(object sender, EventArgs e)
		{
			var packageForm = new frmPackageMaintenance();
			DialogResult result = packageForm.ShowDialog();
		}

		// terminate application
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
