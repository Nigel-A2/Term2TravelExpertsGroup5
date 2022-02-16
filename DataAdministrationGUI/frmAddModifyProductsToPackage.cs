using DataAdministrationData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdministrationData;

namespace DataAdministrationGUI
{
	public partial class frmAddModifyProductsToPackage : Form
	{

		public bool isAdd;
        public PackagesProductsSupplier packagesProductsSupplier;
        public PackageDisplayObject packageDisplayObject;
        private List<ProductsSupplier> productsSuppliers;
        private List<Package> packages;
        


        public frmAddModifyProductsToPackage()
		{
			InitializeComponent();
		}

		private void frmAddModifyProductsToPackage_Load(object sender, EventArgs e)
		{
            LoadPackagesData();
            if (isAdd)
            {
                this.Text = "Add product to package";
                lblHeader.Text = "Add product to package";
            }
            else
            {
                this.Text = "Modify product in package";
                lblHeader.Text = "Modify product in package";
                if (packagesProductsSupplier == null)
                {
                    MessageBox.Show("There is no data of selected package-product-supplier", "Modify Error");
                    this.Close();
                }
                else
                {
                    cbxPackage.SelectedIndex = packages
                        .IndexOf(packages.Find(p => packagesProductsSupplier.PackageId == p.PackageId));
                    cbxPackage.Enabled = false;

                    cbxProductSupplier.SelectedIndex = productsSuppliers
                        .IndexOf(productsSuppliers.Find(ps => packagesProductsSupplier.ProductSupplierId == ps.ProductSupplierId));
                }
            }

        }

		private void btnConfirm_Click(object sender, EventArgs e)
		{
            if (ValidateRequiredFields())
            {
                int selectedPackageId = packages.Find(p => p.PkgName.Equals(cbxPackage.SelectedItem.ToString())).PackageId;
                int selectedProductsSupplierId = productsSuppliers
                    .Find(ps => (ps.ProductSupplierId == Convert.ToInt32(cbxProductSupplier.SelectedValue)))
                    .ProductSupplierId;
                if (ValidateCompositeKey(selectedPackageId, selectedProductsSupplierId))
                {
                    if (isAdd)
                    {
                        packagesProductsSupplier = new PackagesProductsSupplier();
                    }
                    packagesProductsSupplier.PackageId = selectedPackageId;
                    packagesProductsSupplier.ProductSupplierId = selectedProductsSupplierId;
                    createPackageDisplayObject(selectedPackageId, selectedProductsSupplierId);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private bool ValidateRequiredFields()
        {
            return Validator.IsSelected(cbxPackage) && Validator.IsSelected(cbxProductSupplier);
        }

        private bool ValidateCompositeKey(int selectedPackageId, int selectedProductsSupplierId)
        {
            bool result = false;
            try
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    result = db.PackagesProductsSuppliers
                        .Where(pps => pps.ProductSupplierId == selectedProductsSupplierId && pps.PackageId == selectedPackageId)
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

        private void LoadPackagesData()
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
                    packages = db.Packages.ToList();
                    PopulateComboBoxes();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error while getting products-suppliers data: " + exception.Message, exception.GetType().ToString());
            }
        }

        private void PopulateComboBoxes()
        {
            foreach(Package p in packages)
            {
                cbxPackage.Items.Add(p.PkgName);
            }

            cbxProductSupplier.DisplayMember = "Text";
            cbxProductSupplier.ValueMember = "Value";

            var items = new List<Object>();
            foreach (ProductsSupplier ps in productsSuppliers)
            {
                items.Add(new {Text = ps.Product.ProdName + ", " + ps.Supplier.SupName, Value = ps.ProductSupplierId });
            }

            cbxProductSupplier.DataSource = items;
        }

        private void createPackageDisplayObject(int packageId, int productSupplierId)
        {
            string packageName = packages.Find(p => p.PackageId.Equals(packageId)).PkgName;
            string productName = productsSuppliers.Find(ps => ps.ProductSupplierId.Equals(productSupplierId)).Product.ProdName;
            string supplierName = productsSuppliers.Find(ps => ps.ProductSupplierId.Equals(productSupplierId)).Supplier.SupName;
            packageDisplayObject = new PackageDisplayObject
                (
                    packageId,
                    productSupplierId,
                    packageName,
                    productName,
                    supplierName
                );
        }



    }
}
