using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataAdministrationData.Models;
using Microsoft.Data.SqlClient; // ADO.NET provider for SQL Server 
using Microsoft.EntityFrameworkCore;

// written by: Nigel
namespace DataAdministrationGUI
{
	public partial class frmPackageMaintenance : Form
	{
		// class-level declarations
		Package selectedPackage;
		private TravelExpertsContext packageContext = new TravelExpertsContext();

		public frmPackageMaintenance()
		{
			InitializeComponent();
		}

		// closes the form
		private void btnHome_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK; 
		}

		// takes you to another form in the application to add new data to the database
		private void btnAddPackage_Click(object sender, EventArgs e)
		{
			var addModifyPackageform = new frmAddModifyPackage();
			addModifyPackageform.isAdd = true;
			addModifyPackageform.CurrentPackage = null;
			DialogResult result = addModifyPackageform.ShowDialog();

			if (result == DialogResult.OK)
			{
				selectedPackage = addModifyPackageform.CurrentPackage; // add package to database
				try
				{
					using (TravelExpertsContext db = new TravelExpertsContext())
					{
						db.Packages.Add(selectedPackage);
						db.SaveChanges();
						DisplayPackages();
					}
				}
				catch (DbUpdateException ex)
				{
					this.HandleDbUpdateException(ex);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error while adding a product: " + ex.Message, ex.GetType().ToString());
				}
			}
		}

		// load data into the data grid view
		private void frmPackageMaintenance_Load(object sender, EventArgs e)
		{
			DisplayPackages();
		}

		private void DisplayPackages()
		{
			using (TravelExpertsContext db = new TravelExpertsContext())
			{
				dgvPackagesDisplay.Columns.Clear();
				var packages = db.Packages.Select(pac => new
				{
					pac.PackageId,
					pac.PkgName,
					pac.PkgStartDate,
					pac.PkgEndDate,
					pac.PkgDesc,
					pac.PkgBasePrice,
					pac.PkgAgencyCommission
				}).ToList();
				dgvPackagesDisplay.DataSource = packages;

				// add column for modify button
				var modifyColumn = new DataGridViewButtonColumn()
				{
					UseColumnTextForButtonValue = true,
					HeaderText = "",
					Text = "Modify"
				};
				dgvPackagesDisplay.Columns.Add(modifyColumn);

				// add column for delete button
				var deleteColumn = new DataGridViewButtonColumn()
				{
					UseColumnTextForButtonValue = true,
					HeaderText = "",
					Text = "Delete"
				};
				dgvPackagesDisplay.Columns.Add(deleteColumn);

				// format the columns
				dgvPackagesDisplay.EnableHeadersVisualStyles = false;
				//dgvPackagesDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				dgvPackagesDisplay.Columns[0].HeaderText = "Package ID:";
                dgvPackagesDisplay.Columns[0].Visible = false;
                dgvPackagesDisplay.Columns[1].HeaderText = "Name:";
				dgvPackagesDisplay.Columns[2].HeaderText = "Start Date:";
				dgvPackagesDisplay.Columns[3].HeaderText = "End Date:";
				dgvPackagesDisplay.Columns[4].HeaderText = "Description:";
				dgvPackagesDisplay.Columns[5].HeaderText = "Base price:";
				dgvPackagesDisplay.Columns[5].DefaultCellStyle.Format = "c";
				dgvPackagesDisplay.Columns[6].HeaderText = "Agency commission:";
				dgvPackagesDisplay.Columns[6].DefaultCellStyle.Format = "c";

				dgvPackagesDisplay.Columns[1].Width = 150;
				dgvPackagesDisplay.Columns[2].Width = 70;
				dgvPackagesDisplay.Columns[3].Width = 70;
				dgvPackagesDisplay.Columns[4].Width = 300;
				dgvPackagesDisplay.Columns[5].Width = 70;
				dgvPackagesDisplay.Columns[6].Width = 70;
				dgvPackagesDisplay.Columns[7].Width = 100;
				dgvPackagesDisplay.Columns[8].Width = 100;


				// format alternating rows
				dgvPackagesDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			} // db is recycled
		}

		// modify and delete buttons
		private void dgvPackagesDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			const int PackagesModifyIndex = 7;
			const int PackagesDeleteIndex = 8;

			if (e.ColumnIndex == PackagesModifyIndex || e.ColumnIndex == PackagesDeleteIndex)
			{
				// gets data from the row that the user pressed modify or delete on
				int cellSelected = (int)dgvPackagesDisplay.Rows[e.RowIndex].Cells[0].Value;
				selectedPackage = packageContext.Packages.Find(cellSelected); 
			}

			if (e.ColumnIndex == PackagesModifyIndex)
			{
				ModifyPackage();
			}
			else if (e.ColumnIndex == PackagesDeleteIndex)
			{
				DeletePackage();
			}
		}

		// takes user to another form to 
		private void ModifyPackage()
		{
			var addModifyPackageform = new frmAddModifyPackage();
			{
				addModifyPackageform.isAdd = false;
				addModifyPackageform.CurrentPackage = selectedPackage;
			}
			DialogResult result = addModifyPackageform.ShowDialog();

			if (result == DialogResult.OK)
			{
				try
				{
					selectedPackage = addModifyPackageform.CurrentPackage;
					packageContext.SaveChanges();
					DisplayPackages();
				}
				catch (DbUpdateConcurrencyException ex)
				{
					HandleConcurrencyError(ex);
				}
				catch (DbUpdateException ex)
				{
					HandleDatabaseError(ex);
				}
				catch (Exception ex)
				{
					HandleGeneralError(ex);
				}
			}
		}

		// gives a confirmation dialog box with yes or no options
		private void DeletePackage()
		{
			DialogResult result =
				MessageBox.Show($"Delete {selectedPackage.PkgName}?", 
				"Confirm Delete", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					packageContext.Packages.Remove(selectedPackage); 
					packageContext.SaveChanges(true);
					DisplayPackages();
				}
				catch (DbUpdateConcurrencyException ex)
				{
					HandleConcurrencyError(ex);
				}
				catch (DbUpdateException ex)
				{
					HandleDatabaseError(ex);
				}
				catch (Exception ex)
				{
					HandleGeneralError(ex);
				}
			}
		}

		// error handlers
		private void HandleDbUpdateException(DbUpdateException ex) // problems with saving changes
		{
			// get the inner exception with potentially multiple errors
			SqlException innerException = (SqlException)ex.InnerException;
			string message = "";
			foreach (SqlError err in innerException.Errors)
			{
				message += $"Error {err.Number}: {err.Message}\n";
			}
			MessageBox.Show(message, "Database error(s)");
		}

		
		private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
		{
			ex.Entries.Single().Reload();

			var state = packageContext.Entry(selectedPackage).State;
			if (state == EntityState.Detached)
			{
				MessageBox.Show("Another agent has deleted that package.",
					"Concurrency Error");
			}
			else
			{
				string message = "Another agent has updated that package.\n" +
					"The current database values will be displayed.";
				MessageBox.Show(message, "Concurrency Error");
			}
			this.DisplayPackages();
		}

		private void HandleDatabaseError(DbUpdateException ex)
		{
			string errorMessage = "";
			var sqlException = (SqlException)ex.InnerException;
			foreach (SqlError error in sqlException.Errors)
			{
				errorMessage += "ERROR CODE:  " + error.Number + " " +
								error.Message + "\n";
			}
			MessageBox.Show(errorMessage);
		}

		private void HandleGeneralError(Exception ex)
		{
			MessageBox.Show(ex.Message, ex.GetType().ToString());
		}
	}
}
