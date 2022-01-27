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

		private void btnCancelProduct_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
