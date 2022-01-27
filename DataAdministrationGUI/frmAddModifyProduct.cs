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
	public partial class frmAddModifyProduct : Form
	{
		public frmAddModifyProduct()
		{
			InitializeComponent();
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			var addModifyProductform = new frmProductMaintenance();
			DialogResult result = addModifyProductform.ShowDialog();
		}

		private void btnProductToHome_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
