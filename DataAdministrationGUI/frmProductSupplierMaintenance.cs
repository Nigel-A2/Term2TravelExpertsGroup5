using DataAdministrationData.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


//Author: Filip Florek
namespace DataAdministrationGUI
{
	public partial class frmProductSupplierMaintenance : Form
	{
		private List<ProductsSupplier> productsSuppliers;

		public frmProductSupplierMaintenance()
		{
			InitializeComponent();
		}

		//send query to database, to populate product suppliers data
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
					FillDataGridView();
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
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while adding new product-supplier: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void ShowModifyForm(ProductsSupplier selectedProdSup)
		{
			frmAddModifyProductSupplier modifyForm = CreateAddModifyForm(false, selectedProdSup);
			DialogResult result = modifyForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				ModifyProduct(modifyForm.productSupplier);
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
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while modifying product-supplier: " + exception.Message, exception.GetType().ToString());
			}
		}

		//update list which is data source for grid view
		private void UpdateProductsSuppliersList(ProductsSupplier updatedProductSupplier)
		{
			ProductsSupplier productSupplierToUpdate = productsSuppliers.Find(ps => ps.ProductSupplierId.Equals(updatedProductSupplier.ProductSupplierId));
			productSupplierToUpdate.ProductId = updatedProductSupplier.ProductId;
			productSupplierToUpdate.SupplierId = updatedProductSupplier.SupplierId;
			productSupplierToUpdate.Product = updatedProductSupplier.Product;
			productSupplierToUpdate.Supplier = updatedProductSupplier.Supplier;
		}

		private void ShowDeleteDialog(ProductsSupplier selectedProdSup)
		{
			DialogResult answer = MessageBox.Show($"Are you sure you want to delete item: {selectedProdSup.ProductSupplierId}?",
					"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (answer == DialogResult.Yes)
			{
				DeleteProduct(selectedProdSup);
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
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while deleting product-supplier! " + exception.Message, exception.GetType().ToString());
			}
		}

		//fills data grid view, updates source and visible columns
		private void FillDataGridView()
		{
			dgvProductSupplierDisplay.Columns.Clear();
			dgvProductSupplierDisplay.DataSource = null;
			dgvProductSupplierDisplay.DataSource = productsSuppliers;
			dgvProductSupplierDisplay.Columns["ProductId"].Visible = false;
			dgvProductSupplierDisplay.Columns["SupplierId"].Visible = false;
			dgvProductSupplierDisplay.Columns["BookingDetails"].Visible = false;
			dgvProductSupplierDisplay.Columns["PackagesProductsSuppliers"].Visible = false;

			
			// add column for modify button
			var modifyColumn = new DataGridViewButtonColumn()
			{
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Text = "Modify"
			};

			dgvProductSupplierDisplay.Columns.Add(modifyColumn);

			// add column for delete button
			var deleteColumn = new DataGridViewButtonColumn()
			{
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Text = "Delete"
			};
			dgvProductSupplierDisplay.Columns.Add(deleteColumn);

			// format the columns
			dgvProductSupplierDisplay.EnableHeadersVisualStyles = false;
			//dgvProductSupplierDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvProductSupplierDisplay.Columns[0].HeaderText = "Product-supplier ID:";
			dgvProductSupplierDisplay.Columns[0].Visible = false;

			dgvProductSupplierDisplay.Columns[3].HeaderText = "Product name:";
			dgvProductSupplierDisplay.Columns[4].HeaderText = "Supplier name:";

			// standardizing column widths
            dgvProductSupplierDisplay.Columns[3].Width = 100;
            dgvProductSupplierDisplay.Columns[4].Width = 250;

			// Modify / Delete buttons
			dgvProductSupplierDisplay.Columns[7].Width = 100;
			dgvProductSupplierDisplay.Columns[8].Width = 100;



			// format alternating rows
			dgvProductSupplierDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
		}


		private void dgvProductDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//indexes of buttons in data grid view
			const int ProductsModifyIndex = 7;
			const int ProductsDeleteIndex = 8;

			if (e.ColumnIndex == ProductsModifyIndex || e.ColumnIndex == ProductsDeleteIndex)
			{
				// gets data from the row that the user pressed modify or delete on
				int cellSelected = (int)dgvProductSupplierDisplay.Rows[e.RowIndex].Cells[0].Value;
				ProductsSupplier productSupplier = productsSuppliers.Find(p => p.ProductSupplierId.Equals(cellSelected));

				if (e.ColumnIndex == ProductsModifyIndex)
				{
					ShowModifyForm(productSupplier);
				}
				else if (e.ColumnIndex == ProductsDeleteIndex)
				{
					ShowDeleteDialog(productSupplier);
				}
			}

		}

		//creates form to add or modify product-supplier
		private frmAddModifyProductSupplier CreateAddModifyForm(bool isAdd, ProductsSupplier selectedProductSupplier)
		{
			frmAddModifyProductSupplier form = new frmAddModifyProductSupplier();
			form.isAdd = isAdd;
			form.productSupplier = selectedProductSupplier;
			return form;
		}
	}
}
