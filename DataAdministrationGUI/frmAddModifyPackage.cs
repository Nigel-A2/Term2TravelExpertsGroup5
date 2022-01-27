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
		// public data - main form needs access to it
		public Models.Package CurrentPackage { get; set; }
		public bool isAdd; // true - Add, false - Modify

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
