
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
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.txtProductSupplier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(95, 143);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(108, 46);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(348, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(74, 53);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(68, 15);
            this.lblPackageID.TabIndex = 2;
            this.lblPackageID.Text = "Package ID:";
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Location = new System.Drawing.Point(31, 94);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(111, 15);
            this.lblProductSupplier.TabIndex = 3;
            this.lblProductSupplier.Text = "Product supplier ID:";
            // 
            // txtPackageID
            // 
            this.txtPackageID.Location = new System.Drawing.Point(157, 50);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(223, 23);
            this.txtPackageID.TabIndex = 4;
            // 
            // txtProductSupplier
            // 
            this.txtProductSupplier.Location = new System.Drawing.Point(157, 91);
            this.txtProductSupplier.Name = "txtProductSupplier";
            this.txtProductSupplier.Size = new System.Drawing.Size(223, 23);
            this.txtProductSupplier.TabIndex = 5;
            // 
            // frmAddModifyProductsToPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 233);
            this.Controls.Add(this.txtProductSupplier);
            this.Controls.Add(this.txtPackageID);
            this.Controls.Add(this.lblProductSupplier);
            this.Controls.Add(this.lblPackageID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmAddModifyProductsToPackage";
            this.Text = "text here";
            this.Load += new System.EventHandler(this.frmAddModifyProductsToPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblPackageID;
		private System.Windows.Forms.Label lblProductSupplier;
		private System.Windows.Forms.TextBox txtPackageID;
		private System.Windows.Forms.TextBox txtProductSupplier;
	}
}