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

namespace DataAdministrationGUI
{
	public partial class frmAddModifyPackage : Form
	{
		public frmAddModifyPackage()
		{
			InitializeComponent();
		}

		private void btnCancelPackage_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void frmAddModifyPackage_Load(object sender, EventArgs e)
		{

		}

		private void btnPackageOK_Click(object sender, EventArgs e)
		{

		}
	}
}
