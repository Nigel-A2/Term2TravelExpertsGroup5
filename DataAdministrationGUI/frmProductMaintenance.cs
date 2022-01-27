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
					FillProductsListBox();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while getting products data: " + exception.Message, exception.GetType().ToString());

			}
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			int selectedIndex = lbxProducts.SelectedIndex;
			if (selectedIndex != -1)
			{
				Product product = (Product)products[selectedIndex];
				DialogResult answer = MessageBox.Show($"Are you sure you want to delete {product.ProdName}?",
					"Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (answer == DialogResult.Yes)
				{
					DeleteProduct(product);
				}
			}
			else
			{
				MessageBox.Show("You need to select a product!", "Delete Aborted");
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
				FillProductsListBox();
			}
			catch (Exception exception)
			{
				MessageBox.Show("Error while deleting product! " + exception.Message, exception.GetType().ToString());
			}
		}

		private void FillProductsListBox()
		{
			lbxProducts.Items.Clear();
			foreach (Product p in products)
			{
				lbxProducts.Items.Add(p.GetDisplayText("\t"));
			}
		}
    }
}
