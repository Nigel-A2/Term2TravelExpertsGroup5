using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdministrationGUI.Models;

namespace DataAdministrationGUI
{
	public partial class frmProductsInPackageMaintenance : Form
	{
		private List<PackageDisplayObject> productsInPackages;

		public frmProductsInPackageMaintenance()
		{
			InitializeComponent();
		}

		private void frmProductsInsidePackage_Load(object sender, EventArgs e)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{

					var packageQuery =
						from p in db.Products
						join ps in db.ProductsSuppliers on p.ProductId equals ps.ProductId
						join s in db.Suppliers on ps.SupplierId equals s.SupplierId
						join pps in db.PackagesProductsSuppliers on ps.ProductSupplierId equals pps.ProductSupplierId
						join pckg in db.Packages on pps.PackageId equals pckg.PackageId
						orderby pckg.PkgName, p.ProdName descending
						select new PackageDisplayObject()
						{
							PackageId = pckg.PackageId,
							ProductSupplierId = ps.ProductSupplierId,
							PackageName = pckg.PkgName,
							ProductName = p.ProdName,
							SupplierName = s.SupName
						};

					productsInPackages = packageQuery.ToList();
						
					FillProductsInPackagesListBox();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while getting packages-products-suppliers data: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmAddModifyProductsToPackage addForm = CreateAddModifyForm(true, null);

			DialogResult result = addForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				AddPackageProductSupplier(addForm.packagesProductsSupplier, addForm.packageDisplayObject);
			}
		}

		private void AddPackageProductSupplier(PackagesProductsSupplier packageProductSupplierToAdd, PackageDisplayObject packageDisplayObject)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
				
					db.PackagesProductsSuppliers.Add(packageProductSupplierToAdd);
					db.SaveChanges();
				}
				productsInPackages.Add(packageDisplayObject);
				FillProductsInPackagesListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while adding new product-supplier: " + exception.Message, exception.GetType().ToString());
			}
		}



		private void btnModify_Click(object sender, EventArgs e)
		{

		}



		private void btnDelete_Click(object sender, EventArgs e)
		{
			int selectedIndex = lbxPackageProducts.SelectedIndex;
			if (selectedIndex != -1)
			{
				PackageDisplayObject selectedProductInPackage = productsInPackages[selectedIndex];
				DialogResult answer = MessageBox.Show($"Are you sure you want to delete {selectedProductInPackage.ProductName} from package: {selectedProductInPackage.PackageName}?",
					"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (answer == DialogResult.Yes)
				{
					DeleteProduct(new PackagesProductsSupplier 
					{	
						ProductSupplierId = selectedProductInPackage.ProductSupplierId,
						PackageId = selectedProductInPackage.PackageId
					});
				}
			}
			else
			{
				MessageBox.Show("You need to select a package-product-supplier!", "Delete Aborted");
			}
		}


		private void DeleteProduct(PackagesProductsSupplier productInPackage)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					db.PackagesProductsSuppliers.Remove(productInPackage);
					db.SaveChanges();
				}
				productsInPackages.Remove
					(
						productsInPackages.Find
						(
							p => p.PackageId == productInPackage.PackageId &&
							p.ProductSupplierId == productInPackage.ProductSupplierId
						)
					);
				FillProductsInPackagesListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while deleting product-supplier! " + exception.Message, exception.GetType().ToString());
			}
		}

		private void FillProductsInPackagesListBox()
		{
			lbxPackageProducts.Items.Clear();
			foreach (PackageDisplayObject p in productsInPackages)
			{
				lbxPackageProducts.Items.Add(p.GetDisplayText("\t"));
			}
		}

		private frmAddModifyProductsToPackage CreateAddModifyForm(bool isAdd, PackagesProductsSupplier selectedPackageProductSupplier)
		{
			frmAddModifyProductsToPackage form = new frmAddModifyProductsToPackage();
			form.isAdd = isAdd;
			form.packagesProductsSupplier = selectedPackageProductSupplier;
			return form;
		}


	}
}
