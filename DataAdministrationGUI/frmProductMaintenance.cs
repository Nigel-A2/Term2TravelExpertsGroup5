using DataAdministrationGUI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// written by: Filip
namespace DataAdministrationGUI
{
	public partial class frmProductMaintenance : Form
	{

		private List<Product> products;

		public frmProductMaintenance()
		{
			InitializeComponent();
		}

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					products = db.Products.ToList();
					FillDataGridView();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while getting products data: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void ShowDeleteDialog(Product product)
        {
			DialogResult answer = MessageBox.Show($"Are you sure you want to delete {product.ProdName}?",
					"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (answer == DialogResult.Yes)
			{
				DeleteProduct(product);
			}
		}

		private void DeleteProduct(Product product)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					db.Products.Remove(product);
					db.SaveChanges();
				}
				products.Remove(product);
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while deleting product! " + exception.Message, exception.GetType().ToString());
			}
		}

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
			frmAddModifyProduct addForm = CreateAddModifyForm(true, null);

			DialogResult result = addForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				AddProduct(addForm.product);
			}
		}

		private void AddProduct(Product product)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					db.Products.Add(product);
					db.SaveChanges();
				}
				products.Add(product);
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while adding new product: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void ShowModifyForm(Product product)
        {
			frmAddModifyProduct modifyForm = CreateAddModifyForm(false, product);

			DialogResult result = modifyForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				ModifyProduct(modifyForm.product);
			}
		}

		private void ModifyProduct(Product updatedProduct)
		{
			try
			{
				using (TravelExpertsContext db = new TravelExpertsContext())
				{
					Product productToUpdate = db.Products.Find(updatedProduct.ProductId);
					productToUpdate.ProdName = updatedProduct.ProdName;
					db.SaveChanges();
				}
				UpdateProductsList(updatedProduct);
				FillDataGridView();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while modifying product: " + exception.Message, exception.GetType().ToString());
			}
		}

		private void UpdateProductsList(Product updatedProduct)
		{
			Product productToUpdate = products.Find(p => p.ProductId.Equals(updatedProduct.ProductId));
			productToUpdate.ProdName = updatedProduct.ProdName;
		}

		private void FillDataGridView()
        {
			dgvProductDisplay.Columns.Clear();
			dgvProductDisplay.DataSource = null;
            dgvProductDisplay.DataSource = products;
			dgvProductDisplay.Columns["ProductsSuppliers"].Visible = false;

			// add column for modify button
			var modifyColumn = new DataGridViewButtonColumn()
			{
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Text = "Modify"
			};
			dgvProductDisplay.Columns.Add(modifyColumn);

			// add column for delete button
			var deleteColumn = new DataGridViewButtonColumn()
			{
				UseColumnTextForButtonValue = true,
				HeaderText = "",
				Text = "Delete"
			};
			dgvProductDisplay.Columns.Add(deleteColumn);

			// format the columns
			dgvProductDisplay.EnableHeadersVisualStyles = false;
			dgvProductDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dgvProductDisplay.Columns[0].HeaderText = "Product ID:";
			dgvProductDisplay.Columns[1].HeaderText = "Product name:";


			// format alternating rows
			dgvProductDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
		}


		private void dgvProductDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			const int ProductsModifyIndex = 3;
			const int ProductsDeleteIndex = 4;

			if (e.ColumnIndex == ProductsModifyIndex || e.ColumnIndex == ProductsDeleteIndex)
			{
				// gets data from the row that the user pressed modify or delete on
				int cellSelected = (int)dgvProductDisplay.Rows[e.RowIndex].Cells[0].Value;
				Product product = products.Find(p => p.ProductId.Equals(cellSelected));

				if (e.ColumnIndex == ProductsModifyIndex)
				{
					ShowModifyForm(product);
				}
				else if (e.ColumnIndex == ProductsDeleteIndex)
				{
					ShowDeleteDialog(product);
				}
			}
			
		}

		private frmAddModifyProduct CreateAddModifyForm(bool isAdd, Product selectedProduct)
		{
			frmAddModifyProduct form = new frmAddModifyProduct();
			form.isAdd = isAdd;
			form.product = selectedProduct;
			return form;
		}
    }
}
