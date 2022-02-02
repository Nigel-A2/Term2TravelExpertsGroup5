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
using Microsoft.EntityFrameworkCore;

namespace DataAdministrationGUI
{
	public partial class frmProductSupplierMaintenance : Form
	{

		private List<ProductsSupplier> productsSuppliers;

		public frmProductSupplierMaintenance()
		{
			InitializeComponent();
		}

		private void frmProductSupplierMaintenance_Load(object sender, EventArgs e)
		{ 
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					productsSuppliers = db.ProductsSuppliers
							.Include(ps => ps.Product)
							.Include(ps => ps.Supplier)
							.OrderBy(ps => ps.ProductSupplierId)
							.ToList();
					FillProductsSupplierListBox();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while getting products-suppliers data: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmAddModifyProductSupplier addForm = CreateAddModifyForm(true, null);

			DialogResult result = addForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				AddProductSupplier(addForm.productSupplier);
			}
		}

		private void AddProductSupplier(ProductsSupplier productSupplierToAdd)
		{
			try
			{
				//Object without navigation properties
				ProductsSupplier productSupplierDbCompatible = new ProductsSupplier();
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					productSupplierDbCompatible.SupplierId = productSupplierToAdd.SupplierId;
					productSupplierDbCompatible.ProductId = productSupplierToAdd.ProductId;
					db.ProductsSuppliers.Add(productSupplierDbCompatible);
					db.SaveChanges();
				}
				productSupplierToAdd.ProductSupplierId = productSupplierDbCompatible.ProductSupplierId;
				productsSuppliers.Add(productSupplierToAdd);
				FillProductsSupplierListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while adding new product-supplier: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			int selectedIndex = lbxProductSuppliers.SelectedIndex;
			if (selectedIndex != -1)
			{
				ProductsSupplier selectedProdSup = (ProductsSupplier)productsSuppliers[selectedIndex];
				frmAddModifyProductSupplier modifyForm = CreateAddModifyForm(false, selectedProdSup);
				DialogResult result = modifyForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					ModifyProduct(modifyForm.productSupplier);
				}
			}
			else
			{
				MessageBox.Show("You need to select a product!", "Modify Aborted");
			}
		}

		private void ModifyProduct(ProductsSupplier newProductSupplier)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					ProductsSupplier productSupplierToUpdate = db.ProductsSuppliers.Find(newProductSupplier.ProductSupplierId);
					productSupplierToUpdate.ProductId = newProductSupplier.ProductId;
					productSupplierToUpdate.SupplierId = newProductSupplier.SupplierId;
					db.SaveChanges();
				}
				UpdateProductsSuppliersList(newProductSupplier);
				FillProductsSupplierListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while modifying product-supplier: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void UpdateProductsSuppliersList(ProductsSupplier updatedProductSupplier)
		{
			ProductsSupplier productSupplierToUpdate = productsSuppliers.Find(ps => ps.ProductSupplierId.Equals(updatedProductSupplier.ProductSupplierId));
			productSupplierToUpdate.ProductId = updatedProductSupplier.ProductId;
			productSupplierToUpdate.SupplierId = updatedProductSupplier.SupplierId;
			productSupplierToUpdate.Product = updatedProductSupplier.Product;
			productSupplierToUpdate.Supplier = updatedProductSupplier.Supplier;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int selectedIndex = lbxProductSuppliers.SelectedIndex;
			if (selectedIndex != -1)
			{
				ProductsSupplier selectedProdSup = (ProductsSupplier)productsSuppliers[selectedIndex];
				DialogResult answer = MessageBox.Show($"Are you sure you want to delete item: {selectedProdSup.ProductSupplierId}?",
					"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (answer == DialogResult.Yes)
				{
					DeleteProduct(selectedProdSup);
				}
			}
			else
			{
				MessageBox.Show("You need to select a product-supplier!", "Delete Aborted");
			}
		}

		private void DeleteProduct(ProductsSupplier productSupplierToDelete)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					db.ProductsSuppliers.Remove(productSupplierToDelete);
					db.SaveChanges();
				}
				productsSuppliers.Remove(productSupplierToDelete);
				FillProductsSupplierListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while deleting product-supplier! " + exception.Message, exception.GetType().ToString());
			}
		}

		private void FillProductsSupplierListBox()
		{
			lbxProductSuppliers.Items.Clear();
			foreach (ProductsSupplier ps in productsSuppliers)
			{
				lbxProductSuppliers.Items.Add(ps.GetDisplayText("\t"));
			}
		}

		private frmAddModifyProductSupplier CreateAddModifyForm(bool isAdd, ProductsSupplier selectedProductSupplier)
		{
			frmAddModifyProductSupplier form = new frmAddModifyProductSupplier();
			form.isAdd = isAdd;
			form.productSupplier = selectedProductSupplier;
			return form;
		}
	}
}
