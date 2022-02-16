using System;
using System.Windows.Forms;
using DataAdministrationData.Models;
using DataAdministrationData;

// written by: Nigel
namespace DataAdministrationGUI
{
	public partial class frmAddModifyPackage : Form
	{
		// public data - main form needs access to it
		public Package CurrentPackage { get; set; }
		public bool isAdd; // true - Add, false - Modify

		public frmAddModifyPackage()
		{
			InitializeComponent();
		}

		// We need to make a validator for the following requirements:
		// agency commission > base price
		// package end date must be later than start date (int dateComparison = DateTime.Compare(CurrentPackage.PkgStartDate, CurrentPackage.PkgEndDate)) if (dateComparison >= 0) throw error
		// package name and description must not be null

		private void btnCancelPackage_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// determines whether the user clicked add or modify, and determines the form's behavior accordingly
		private void frmAddModifyPackage_Load(object sender, EventArgs e)
		{
			try
			{
				if (isAdd)
				{
					this.Text = "Add Package";
					lblHeader.Text = "Add Package";
					txtPackageID.ReadOnly = true; // packageID auto-increments
					txtPackageID.Text = "Generated automatically";
				}
				else
				{
					this.Text = "Modify Package";
					lblHeader.Text = "Modify Package";
					if (CurrentPackage == null)
					{
						MessageBox.Show("There is no selected package", "Modify Error");
						this.Close();
					}
					// retrieve data for modification 
					// why did I not realize Convert.ToString was the solution to this problem in lab 3...
					txtPackageID.Text = Convert.ToString(CurrentPackage.PackageId); // int to string
					txtPkgName.Text = CurrentPackage.PkgName;
					dtpStartDate.Value = (DateTime)CurrentPackage.PkgStartDate; // DateTime to string
					dtpEndDate.Value = (DateTime)CurrentPackage.PkgEndDate; // DateTime to string
					txtPkgDesc.Text = CurrentPackage.PkgDesc;
					txtPkgBasePrice.Text = Convert.ToString(CurrentPackage.PkgBasePrice); // decimal to string
					txtPkgAgencyCommission.Text = Convert.ToString(CurrentPackage.PkgAgencyCommission); // decimal to string
					txtPackageID.ReadOnly = true; // can't change existing package ID
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error retrieving database: " + ex.Message, e.GetType().ToString());
			}
		}

		// confirms and executes the user's actions
		private void btnPackageOK_Click(object sender, EventArgs e)
		{
			if (
				Validator.IsPresent(txtPkgName) &&
				Validator.IsPresent(txtPkgDesc) &&
				Validator.IsNonNegativeDecimal(txtPkgBasePrice) &&
				Validator.IsNonNegativeDecimal(txtPkgAgencyCommission))
			{
				// agency commission > base price
				// package end date must be later than start date (int dateComparison = DateTime.Compare(CurrentPackage.PkgStartDate, CurrentPackage.PkgEndDate)) if (dateComparison >= 0) throw error
				
				if (isAdd) // need to create package object
				{
					CurrentPackage = new Package();
				}
				// put data from the form into the package object
				CurrentPackage.PkgName = txtPkgName.Text;
				CurrentPackage.PkgStartDate = dtpStartDate.Value;
				CurrentPackage.PkgEndDate = dtpEndDate.Value;
				CurrentPackage.PkgDesc = txtPkgDesc.Text;
				CurrentPackage.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
				CurrentPackage.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text);
				int dateComparison = DateTime.Compare((DateTime)CurrentPackage.PkgStartDate, (DateTime)CurrentPackage.PkgEndDate);
				// the validators I was talking about
				if (CurrentPackage.PkgBasePrice > CurrentPackage.PkgAgencyCommission &&
				dateComparison < 0)
				{
					this.DialogResult = DialogResult.OK; // closes the form
				}
				else
				{
					MessageBox.Show($"ERROR: One of the following conditions has not been met: \n (1) Package start date must be earlier than its end date. \n (2) The base price of a package must be higher than its agency commission.");
				}
			}
		}
    }
}
