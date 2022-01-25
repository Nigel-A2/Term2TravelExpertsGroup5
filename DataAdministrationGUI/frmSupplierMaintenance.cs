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
	public partial class frmSupplierMaintenance : Form
	{
		public frmSupplierMaintenance()
		{
			InitializeComponent();
		}

		private void btnAddSupplier_Click(object sender, EventArgs e)
		{
			var addModifySupplierform = new frmAddModifySupplier();
			DialogResult result = addModifySupplierform.ShowDialog();
		}

		private void btnSuppliersToHome_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
