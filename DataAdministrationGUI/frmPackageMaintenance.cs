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
using Microsoft.Data.SqlClient; // ADO.NET provider for SQL Server 
using Microsoft.EntityFrameworkCore;


// written by: Nigel, anybody else?
namespace DataAdministrationGUI
{
	public partial class frmPackageMaintenance : Form
	{
		// class-level declarations
		Package selectedPackage;
		private TravelExpertsContext context = new TravelExpertsContext();

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
			DialogResult result = addModifyPackageform.ShowDialog();
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
				dgvPackagesDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				dgvPackagesDisplay.Columns[0].HeaderText = "Package ID:";
				dgvPackagesDisplay.Columns[1].HeaderText = "Name:";
				dgvPackagesDisplay.Columns[2].HeaderText = "Start Date:";
				dgvPackagesDisplay.Columns[3].HeaderText = "End Date:";
				dgvPackagesDisplay.Columns[4].HeaderText = "Description:";
				dgvPackagesDisplay.Columns[5].HeaderText = "Base price:";
				dgvPackagesDisplay.Columns[6].HeaderText = "Agency commission:";

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
				string cellSelected = dgvPackagesDisplay.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
				selectedPackage = context.Packages.Find(cellSelected);
			}

			// if statements for the modify and delete buttons. We need to make a validator for the following requirements:
			// agency commission > base price
			// package end date must be later than start date
			// package name and description must not be null
		}
	}
}
