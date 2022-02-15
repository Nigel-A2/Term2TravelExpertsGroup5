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
	public partial class frmAddModifyProductSupplier : Form
	{
		public bool isAdd;
		public ProductsSupplier productSupplier;
        private List<Product> products;
        private List<Supplier> suppliers;

        public frmAddModifyProductSupplier()
		{
			InitializeComponent();
		}

		private void frmAddModifyProductSupplier_Load(object sender, EventArgs e)
		{
            populateComboBoxes();
            if (isAdd)
            {
                this.Text = "Add Product-Supplier";
                lblHeader.Text = "Add Product-Supplier";
            }
            else
            {
                this.Text = "Modify Product-Supplier";
                lblHeader.Text = "Modify Product-Supplier";
                if (productSupplier == null)
                {
                    MessageBox.Show("There is no data of selected product-supplier", "Modify Error");
                    this.Close();
                }
                else
                {
                    string selectedProdName = products.Find(p => p.ProductId == productSupplier.ProductId).ProdName;
                    string selectedSupName = suppliers.Find(s => s.SupplierId == productSupplier.SupplierId).SupName;
                    cbxProduct.SelectedIndex = cbxProduct.FindStringExact(selectedProdName);
                    cbxSupplier.SelectedIndex = cbxSupplier.FindStringExact(selectedSupName);

                }
            }
        }

		private void btnConfirm_Click(object sender, EventArgs e)
		{
            if (ValidateProductSupplier())
            {
                int selectedProductId = products.Find(p => p.ProdName.Equals(cbxProduct.SelectedItem.ToString())).ProductId;
                int selectedSupplierId = suppliers.Find(s => s.SupName.Equals(cbxSupplier.SelectedItem.ToString())).SupplierId;
                if (isAdd)
                {
                    productSupplier = new ProductsSupplier();
                }
                productSupplier.ProductId = selectedProductId;
                productSupplier.SupplierId = selectedSupplierId;
                productSupplier.Product = products.Find(p => p.ProductId == selectedProductId);
                productSupplier.Supplier = suppliers.Find(s => s.SupplierId == selectedSupplierId);
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidateProductSupplier()
        {
            bool result = false;
            if (ValidateRequiredFields() && ValidateCompositeKey())
            {
                result = true;
            }
            return result;
        }

        private bool ValidateRequiredFields()
        {
            return Validator.IsSelected(cbxProduct) && Validator.IsSelected(cbxSupplier);
        }

        private bool ValidateCompositeKey()
        {
            bool result = false;
            try
            {
                int selectedProductId = products.Find(p => p.ProdName.Equals(cbxProduct.SelectedItem.ToString())).ProductId;
                int selectedSupplierId = suppliers.Find(s => s.SupName.Equals(cbxSupplier.SelectedItem.ToString())).SupplierId;
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    result = db.ProductsSuppliers
                        .Where(ps => ps.SupplierId == selectedSupplierId && ps.ProductId == selectedProductId)
                        .ToList().Count == 0;
                    if (!result)
                    {
                        MessageBox.Show("There already is a record with given Product and Supplier!", "Add-Modify Error");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error while getting TravelExperts data: " + exception.Message, exception.GetType().ToString());
            }
            return result;
        }

        private void populateComboBoxes()
        {
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    products = db.Products.OrderBy(p => p.ProdName).ToList();
                    suppliers = db.Suppliers.OrderBy(s => s.SupName).ToList();
                }
                foreach(Product p in products)
                {
                    cbxProduct.Items.Add(p.ProdName);
                                    }
                foreach(Supplier s in suppliers)
                {
                    cbxSupplier.Items.Add(s.SupName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error while getting TravelExperts data: " + exception.Message, exception.GetType().ToString());
            }
        }
    }
}
