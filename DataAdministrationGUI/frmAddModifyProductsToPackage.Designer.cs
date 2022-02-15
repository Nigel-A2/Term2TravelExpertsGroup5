
namespace DataAdministrationGUI
{
	partial class frmAddModifyProductsToPackage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.cbxProductSupplier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(23, 104);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(169, 49);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 49);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(66, 31);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(54, 15);
            this.lblPackageID.TabIndex = 2;
            this.lblPackageID.Text = "Package:";
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Location = new System.Drawing.Point(23, 74);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(97, 15);
            this.lblProductSupplier.TabIndex = 3;
            this.lblProductSupplier.Text = "Product supplier:";
            // 
            // cbxPackage
            // 
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.Location = new System.Drawing.Point(126, 28);
            this.cbxPackage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(255, 23);
            this.cbxPackage.TabIndex = 8;
            // 
            // cbxProductSupplier
            // 
            this.cbxProductSupplier.FormattingEnabled = true;
            this.cbxProductSupplier.Location = new System.Drawing.Point(126, 66);
            this.cbxProductSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxProductSupplier.Name = "cbxProductSupplier";
            this.cbxProductSupplier.Size = new System.Drawing.Size(255, 23);
            this.cbxProductSupplier.TabIndex = 9;
            // 
            // frmAddModifyProductsToPackage
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(402, 171);
            this.Controls.Add(this.cbxProductSupplier);
            this.Controls.Add(this.cbxPackage);
            this.Controls.Add(this.lblProductSupplier);
            this.Controls.Add(this.lblPackageID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmAddModifyProductsToPackage";
            this.Text = "Add Package";
            this.Load += new System.EventHandler(this.frmAddModifyProductsToPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblPackageID;
		private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.ComboBox cbxProductSupplier;
    }
}