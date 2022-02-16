using System;
using System.Windows.Forms;
using DataAdministrationData.Models;
using DataAdministrationData;

/// <summary>  Author: William Rust -- January 26, 2022
/// 
/// </summary>
namespace DataAdministrationGUI
{
	public partial class frmAddModifySupplier : Form
	{
		public int newID;
		public bool isAdd; // True = Add form, False = Modify form
		public Supplier CurrentSupplier { get; set; }
		public frmAddModifySupplier()
		{
			InitializeComponent();
		}

		private void btnCancelSupplier_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAddModifySupplier_Load(object sender, EventArgs e)
		{
			// no validation on name length necessary; 
			try
			{
				if (isAdd)
				{
					this.Text = "Add Supplier";
					lblHeader.Text = "Add Supplier";
					txtSupplierID.Text = newID.ToString();
					///	add function to create product ID as the latest entry ID + 1
				}
				else
				{
					this.Text = "Modify Supplier";
					lblHeader.Text = "Modify Supplier";
					if (CurrentSupplier == null)
					{
						MessageBox.Show("There is no current supplier", "Modify Error");
						this.Close();
					}
					// retrieve data for modification
					// could only get these two to work
					txtSupplierID.Text = CurrentSupplier.SupplierId.ToString();
					txtSupplierName.Text = CurrentSupplier.SupName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error retrieving database: " + ex.Message, e.GetType().ToString());
			}
		}

        private void btnConfirmModify_Click(object sender, EventArgs e)
        {
			if (
                Validator.IsPresent(txtSupplierID) &&
                Validator.IsNonNegativeInt(txtSupplierID) &&

                Validator.IsPresent(txtSupplierName))
            {
				if (isAdd == true)
                {
					CurrentSupplier = new Supplier();
                }

				CurrentSupplier.SupplierId = Convert.ToInt32(txtSupplierID.Text);
				CurrentSupplier.SupName = txtSupplierName.Text;

				if (isAdd == true)
                {
					MessageBox.Show("Entry added successfuly");

				}
				else
                {
					MessageBox.Show("Entry modified successfuly");

				}

				this.DialogResult = DialogResult.OK; // closes the form

			}
		}


  
    }
}
