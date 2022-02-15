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

		private PackageDisplayObject selectedPdo;

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
					FillDataGridView();
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
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while adding new product-supplier: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void ShowModifyForm()
		{
			PackagesProductsSupplier selectedPkgProdSup = new PackagesProductsSupplier();
			selectedPkgProdSup.PackageId = selectedPdo.PackageId;
			selectedPkgProdSup.ProductSupplierId = selectedPdo.ProductSupplierId;
			frmAddModifyProductsToPackage modifyForm = CreateAddModifyForm(false, selectedPkgProdSup);
			DialogResult result = modifyForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				ModifyProduct(modifyForm.packagesProductsSupplier, modifyForm.packageDisplayObject);
			}
		}

		private void ModifyProduct(PackagesProductsSupplier packagesProductsSupplier, PackageDisplayObject packageDisplayObject)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					PackagesProductsSupplier productPackageSupplierToDelete =
						db.PackagesProductsSuppliers
						.Where(pps => pps.ProductSupplierId == selectedPdo.ProductSupplierId && pps.PackageId == selectedPdo.PackageId)
						.First();
					db.Remove(productPackageSupplierToDelete);

					PackagesProductsSupplier productPackageSupplierToInsert = new PackagesProductsSupplier();
					productPackageSupplierToInsert.ProductSupplierId = packagesProductsSupplier.ProductSupplierId;
					productPackageSupplierToInsert.PackageId = packagesProductsSupplier.PackageId;
					db.Add(productPackageSupplierToInsert);
					db.SaveChanges();
				}
				UpdateProductsSuppliersList(packageDisplayObject);
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while modifying package-product-supplier: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void UpdateProductsSuppliersList(PackageDisplayObject packageDisplayObject)
		{
			PackageDisplayObject pdoToUpdate = productsInPackages
				.Find(p => p.ProductSupplierId.Equals(selectedPdo.ProductSupplierId) && p.PackageId.Equals(selectedPdo.PackageId));
			pdoToUpdate.SupplierName = packageDisplayObject.SupplierName;
			pdoToUpdate.ProductSupplierId = packageDisplayObject.ProductSupplierId;
			pdoToUpdate.ProductName = packageDisplayObject.ProductName;
		}

		private void ShowDeleteDialog(PackageDisplayObject selectedProductInPackage)
		{
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
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while deleting product-supplier! " + exception.Message, exception.GetType().ToString());
			}
		}

		private void FillDataGridView()
		{
			dgvProductsPackagesDisplay.Columns.Clear();
			dgvProductsPackagesDisplay.DataSource = null;
			dgvProductsPackagesDisplay.DataSource = productsInPackages;
			dgvProductsPackagesDisplay.Columns["PackageId"].Visible = false;
			dgvProductsPackagesDisplay.Columns["ProductSupplierId"].Visible = false;



			// add column for modify button
			var modifyColumn = new DataGridViewButtonColumn()
			{
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Text = "Modify"
			};
			dgvProductsPackagesDisplay.Columns.Add(modifyColumn);

			// add column for delete button
			var deleteColumn = new DataGridViewButtonColumn()
			{
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Text = "Delete"
			};
			dgvProductsPackagesDisplay.Columns.Add(deleteColumn);

			// format the columns
			dgvProductsPackagesDisplay.EnableHeadersVisualStyles = false;
			dgvProductsPackagesDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvProductsPackagesDisplay.Columns[2].HeaderText = "Package name:";
			dgvProductsPackagesDisplay.Columns[3].HeaderText = "Product name:";
			dgvProductsPackagesDisplay.Columns[4].HeaderText = "Supplier name:";


			// format alternating rows
			dgvProductsPackagesDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
		}


		private void dgvProductDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			const int ProductsModifyIndex = 5;
			const int ProductsDeleteIndex = 6;

			if (e.ColumnIndex == ProductsModifyIndex || e.ColumnIndex == ProductsDeleteIndex)
			{
				// gets data from the row that the user pressed modify or delete on
				int selectedIndex = dgvProductsPackagesDisplay.CurrentCell.RowIndex;
				selectedPdo = productsInPackages[selectedIndex];

				if (e.ColumnIndex == ProductsModifyIndex)
				{
					ShowModifyForm();
				}
				else if (e.ColumnIndex == ProductsDeleteIndex)
				{
					ShowDeleteDialog(productsInPackages[selectedIndex]);
				}
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
