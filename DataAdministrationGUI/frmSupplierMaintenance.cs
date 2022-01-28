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


/// <summary>  Author: William Rust -- January 26, 2022
/// 
/// </summary>
namespace DataAdministrationGUI
{
	public partial class frmSupplierMaintenance : Form
	{
		Supplier selectedSupplier;
		private TravelExpertsContext context = new TravelExpertsContext();
		public frmSupplierMaintenance()
		{
			InitializeComponent();
			DisplaySuppliers();
		}

		private void btnAddSupplier_Click(object sender, EventArgs e)
		{
			//var addModifySupplierform = new frmAddModifySupplier();
			//DialogResult result = addModifySupplierform.ShowDialog();

			frmAddModifySupplier Form2 = new frmAddModifySupplier();
			Form2.isAdd = true;
			Form2.CurrentSupplier = null; //if get selection from datagridview is necessary
			DialogResult result = Form2.ShowDialog(); // display second form

			if (result == DialogResult.OK)
			{
				selectedSupplier = Form2.CurrentSupplier; // add Supplier to database
				try
				{
					using (TravelExpertsContext db = new TravelExpertsContext())
					{
						db.Suppliers.Add(selectedSupplier);
						db.SaveChanges();
						DisplaySuppliers();
					}
				}
				catch   // add exception handling here
				{

				}               //catch (DbUpdateException ex)
								//{
								//	this.HandleDbUpdateException(ex);
								//}
								//catch (Exception ex)
								//{
								//	MessageBox.Show("Error while adding a Supplier: " + ex.Message, ex.GetType().ToString());
								//}
			}
			else
            {
				this.Close();
            }
		}

		private void btnSuppliersToHome_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void DisplaySuppliers()
		{
			using (TravelExpertsContext db = new TravelExpertsContext())
			{
				dgvSuppliers.Columns.Clear();
				var suppliers = db.Suppliers.Select(p => new
				{
					p.SupplierId,
					p.SupName,

				}).ToList();
				dgvSuppliers.DataSource = suppliers;

				// add column for modify button
				var modifyColumn = new DataGridViewButtonColumn()
				{
					UseColumnTextForButtonValue = true,
					HeaderText = "",
					Text = "Modify"
				};
				dgvSuppliers.Columns.Add(modifyColumn);

				// add column for delete button
				var deleteColumn = new DataGridViewButtonColumn()
				{
					UseColumnTextForButtonValue = true,
					HeaderText = "",
					Text = "Delete"
				};
				dgvSuppliers.Columns.Add(deleteColumn);

				// column variables
				DataGridViewColumn column0 = dgvSuppliers.Columns[0];
				DataGridViewColumn column1 = dgvSuppliers.Columns[1];
				DataGridViewColumn column2 = dgvSuppliers.Columns[2];
				DataGridViewColumn column3 = dgvSuppliers.Columns[3];

				// format the columns
				//dgvSuppliers.EnableHeadersVisualStyles = false;
				//dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
				//dgvSuppliers.Columns[dgvSuppliers.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // last column fills the remaining width
				
				column0.HeaderText  = "Supplier ID:";
				column0.Width = 60;

				column1.HeaderText = "Supplier:";
				column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

				column2.Width = 100;

				column3.Width = 100;

				// format alternating rows
				dgvSuppliers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
			} // db is recycled
		}




		public void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			const int ModifyIndex = 0;
			const int DeleteIndex = 1;

			if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
			{
				// gets data from the row that the user pressed modify or delete on
				//int supplierID = Convert.ToInt32(dgvSuppliers.Rows[e.RowIndex].Cells[0].Value);
				string supplierID = dgvSuppliers.Rows[e.RowIndex].Cells[0].Value.ToString();
				MessageBox.Show(supplierID.ToString());
				selectedSupplier = context.Suppliers.Find(Convert.ToInt32(supplierID));
			}
			
			if (e.ColumnIndex == ModifyIndex)
			{
				ModifySupplier();
			}
			else if (e.ColumnIndex == DeleteIndex)
			{
				DeleteSupplier();
			}

		}

		// takes user to a second form to modify one of the table's rows
		private void ModifySupplier()
		{
			var addModifySupplierForm = new frmAddModifySupplier()
			{
				isAdd = false,
				CurrentSupplier = selectedSupplier
			};
			DialogResult result = addModifySupplierForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				try
				{
					selectedSupplier = addModifySupplierForm.CurrentSupplier;
					context.SaveChanges();
					DisplaySuppliers();
				}
				catch
				{ }
				//catch (DbUpdateConcurrencyException ex)
				//{
				//	HandleConcurrencyError(ex);
				//}
				//catch (DbUpdateException ex)
				//{
				//	HandleDatabaseError(ex);
				//}
				//catch (Exception ex)
				//{
				//	HandleGeneralError(ex);
				//}
			}
		}

		// removes selected row
		private void DeleteSupplier()
		{
			DialogResult result =
				MessageBox.Show($"Delete {selectedSupplier.SupplierId}?",
				"Confirm Delete", MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					context.Suppliers.Remove(selectedSupplier);
					context.SaveChanges(true);
					DisplaySuppliers();
				}
				catch // add exception handling here
				{

				}               //catch (DbUpdateConcurrencyException ex)
								//{
								//	HandleConcurrencyError(ex);
								//}
								//catch (DbUpdateException ex)
								//{
								//	HandleDatabaseError(ex);
								//}
								//catch (Exception ex)
								//{
								//	HandleGeneralError(ex);
								//}
			}
		}



















	}


}
