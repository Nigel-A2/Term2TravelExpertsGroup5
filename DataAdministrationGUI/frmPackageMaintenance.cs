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
	public partial class frmPackageMaintenance : Form
	{
		public frmPackageMaintenance()
		{
			InitializeComponent();
		}

		// closes the form, feel free to copy to the other forms
		private void btnHome_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK; 
		}

		private void btnAddPackage_Click(object sender, EventArgs e)
		{
			var addModifyPackageform = new frmAddModifyPackage();
			DialogResult result = addModifyPackageform.ShowDialog();
		}
	}
}
