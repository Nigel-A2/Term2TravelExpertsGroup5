
namespace DataAdministrationGUI
{
	partial class frmSupplierMaintenance
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
			this.btnSuppliersToHome = new System.Windows.Forms.Button();
			this.btnAddSupplier = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSuppliersToHome
			// 
			this.btnSuppliersToHome.Location = new System.Drawing.Point(456, 337);
			this.btnSuppliersToHome.Name = "btnSuppliersToHome";
			this.btnSuppliersToHome.Size = new System.Drawing.Size(189, 43);
			this.btnSuppliersToHome.TabIndex = 0;
			this.btnSuppliersToHome.Text = "Home";
			this.btnSuppliersToHome.UseVisualStyleBackColor = true;
			this.btnSuppliersToHome.Click += new System.EventHandler(this.btnSuppliersToHome_Click);
			// 
			// btnAddSupplier
			// 
			this.btnAddSupplier.Location = new System.Drawing.Point(462, 278);
			this.btnAddSupplier.Name = "btnAddSupplier";
			this.btnAddSupplier.Size = new System.Drawing.Size(182, 43);
			this.btnAddSupplier.TabIndex = 1;
			this.btnAddSupplier.Text = "Add";
			this.btnAddSupplier.UseVisualStyleBackColor = true;
			this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
			// 
			// frmSupplierMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddSupplier);
			this.Controls.Add(this.btnSuppliersToHome);
			this.Name = "frmSupplierMaintenance";
			this.Text = "frmSupplierMaintenance";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSuppliersToHome;
		private System.Windows.Forms.Button btnAddSupplier;
	}
}