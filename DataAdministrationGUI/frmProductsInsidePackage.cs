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
	public partial class frmProductsInsidePackage : Form
	{
		private List<PackagesProductsSupplier> packageProduct;

		public frmProductsInsidePackage()
		{
			InitializeComponent();
		}

		private void frmProductsInsidePackage_Load(object sender, EventArgs e)
		{

			 try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					packageProduct = db.PackagesProductsSuppliers.ToList();
					FillPackageProductsListBox();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while getting package products data: " + exception.Message, exception.GetType().ToString());

			}
			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{

			frmAddModifyProductsToPackage addForm = CreateAddModifyForm(true, null);

			DialogResult result = addForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				AddPackageProduct(addForm.packageProduct);
			}

		}

		
		  private void AddPackageProduct(PackagesProductsSupplier packageProduct)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					db.PackagesProductsSuppliers.Add(packageProduct);
					db.SaveChanges();
				}
				packageProduct.Add(packageProduct);
				FillPackageProductsListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while adding new product: " + exception.Message, exception.GetType().ToString());
			}
		}
		 

		private void btnModify_Click(object sender, EventArgs e)
		{

			int selectedIndex = lbxPackageProducts.SelectedIndex;
			if (selectedIndex != -1)
			{
				PackagesProductsSupplier currentPackageProduct = (PackagesProductsSupplier)packageProduct[selectedIndex];
				frmAddModifyProductsToPackage modifyForm = CreateAddModifyForm(false, currentPackageProduct);

				DialogResult result = modifyForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					ModifyPackageProduct(modifyForm.packageProduct);
				}
			}
			else
			{
				MessageBox.Show("You need to select a product!", "Modify Aborted");
			}

		}

		
		  private void ModifyPackageProduct(Product updatedProduct)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					PackagesProductsSupplier productToUpdate = db.PackagesProductsSuppliers.Find(updatedPackageProduct.PackageId);
					
					db.SaveChanges();
				}
				UpdatePackageProductsList(updatedPackageProduct);
				FillPackageProductsListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while modifying product: " + exception.Message, exception.GetType().ToString());
			}
		}
		 

		private void btnDelete_Click(object sender, EventArgs e)
		{

			int selectedIndex = lbxPackageProducts.SelectedIndex;
			if (selectedIndex != -1)
			{
				PackagesProductsSupplier currentPackageProduct = (PackagesProductsSupplier)packageProduct[selectedIndex];
				DialogResult answer = MessageBox.Show($"Are you sure you want to delete {packageProduct.ProductSupplierId}?",
					"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (answer == DialogResult.Yes)
				{
					DeletePackageProduct(packageProduct);
				}
			}
			else
			{
				MessageBox.Show("You need to select a product!", "Delete Aborted");
			}

		}

		
		  private void DeletePackageProduct(PackagesProductsSupplier currentPackageProduct)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					db.PackagesProductsSuppliers.Remove(currentPackageProduct);
					db.SaveChanges();
				}
				packageProduct.Remove(currentPackageProduct);
				FillPackageProductsListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while deleting product! " + exception.Message, exception.GetType().ToString());
			}
		}
		 

		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
		  private void UpdatePackageProductsList(PackagesProductsSupplier updatedPackageProduct)
		{
			PackagesProductsSupplier packageproductToUpdate = packageProduct.Find(pp => pp.ProductSupplierId.Equals(updatedPackageProduct.ProductSupplierId));
			
		}

		private void FillPackageProductsListBox()
		{
			lbxPackageProducts.Items.Clear();
			foreach (PackagesProductsSupplier pp in packageProduct)
			{
				lbxPackageProducts.Items.Add(pp.GetDisplayText("\t"));
			}
		}

		private frmAddModifyProductsToPackage CreateAddModifyForm(bool isAdd, PackagesProductsSupplier selectedPackageProduct)
		{
			frmAddModifyProductsToPackage form = new frmAddModifyProductsToPackage();
			form.isAdd = isAdd;
			form.packageProduct = selectedPackageProduct;
			return form;
		}
		
	}
}
