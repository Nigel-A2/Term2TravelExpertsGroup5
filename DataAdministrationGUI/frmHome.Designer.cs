
namespace DataAdministrationGUI
{
	partial class frmHome
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPackages = new System.Windows.Forms.Button();
			this.btnSuppliers = new System.Windows.Forms.Button();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnPackages
			// 
			this.btnPackages.Location = new System.Drawing.Point(420, 355);
			this.btnPackages.Name = "btnPackages";
			this.btnPackages.Size = new System.Drawing.Size(116, 45);
			this.btnPackages.TabIndex = 0;
			this.btnPackages.Text = "Packages";
			this.btnPackages.UseVisualStyleBackColor = true;
			this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
			// 
			// btnSuppliers
			// 
			this.btnSuppliers.Location = new System.Drawing.Point(269, 355);
			this.btnSuppliers.Name = "btnSuppliers";
			this.btnSuppliers.Size = new System.Drawing.Size(116, 45);
			this.btnSuppliers.TabIndex = 1;
			this.btnSuppliers.Text = "Suppliers";
			this.btnSuppliers.UseVisualStyleBackColor = true;
			this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.Location = new System.Drawing.Point(95, 355);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(135, 45);
			this.btnProducts.TabIndex = 2;
			this.btnProducts.Text = "Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(567, 355);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(135, 45);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnProducts);
			this.Controls.Add(this.btnSuppliers);
			this.Controls.Add(this.btnPackages);
			this.Name = "frmHome";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPackages;
		private System.Windows.Forms.Button btnSuppliers;
		private System.Windows.Forms.Button btnProducts;
		private System.Windows.Forms.Button btnExit;
	}
}

