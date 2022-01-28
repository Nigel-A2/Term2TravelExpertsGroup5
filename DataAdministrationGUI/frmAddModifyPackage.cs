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

// written by: Nigel, anyone else?
namespace DataAdministrationGUI
{
	public partial class frmAddModifyPackage : Form
	{
		// public data - main form needs access to it
		public Models.Package CurrentPackage { get; set; }
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
					txtPackageID.ReadOnly = false; // allow entry of new package ID
				}
				else
				{
					this.Text = "Modify Package";
					if (CurrentPackage == null)
					{
						MessageBox.Show("There is no selected package", "Modify Error");
						this.Close();
					}
					// retrieve data for modification 
					// why did I not realize Convert.ToString was the solution to this problem in lab 3...
					txtPackageID.Text = Convert.ToString(CurrentPackage.PackageId); // int to string
					txtPkgName.Text = CurrentPackage.PkgName;
					txtPkgStartDate.Text = Convert.ToString(CurrentPackage.PkgStartDate); // DateTime to string
					txtPkgEndDate.Text = Convert.ToString(CurrentPackage.PkgEndDate); // DateTime to string
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
			if (Validator.IsNonNegativeInt(txtPackageID) &&
				Validator.IsPresent(txtPkgName) &&
				Validator.IsPresent(txtPkgStartDate) &&
				Validator.IsPresent(txtPkgEndDate) &&
				Validator.IsPresent(txtPkgDesc) &&
				Validator.IsNonNegativeDecimal(txtPkgBasePrice) &&
				Validator.IsNonNegativeDecimal(txtPkgAgencyCommission))
			{
				// agency commission > base price
				// package end date must be later than start date (int dateComparison = DateTime.Compare(CurrentPackage.PkgStartDate, CurrentPackage.PkgEndDate)) if (dateComparison >= 0) throw error
				// if statement
				//{
					if (isAdd) // need to create package object
					{
						CurrentPackage = new Package();
					}
					// put data from the form into the package object
					CurrentPackage.PackageId = Convert.ToInt32(txtPackageID.Text);
					CurrentPackage.PkgName = txtPkgName.Text;
					CurrentPackage.PkgStartDate = Convert.ToDateTime(txtPkgStartDate.Text);
					CurrentPackage.PkgEndDate = Convert.ToDateTime(txtPkgEndDate.Text);
					CurrentPackage.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
					CurrentPackage.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text);


					this.DialogResult = DialogResult.OK; // closes the form
				//}
				// else MessageBox.Show
			}
		}
	}
}
