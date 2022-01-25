
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
			this.lblCompanyName = new System.Windows.Forms.Label();
			this.lblProgramName = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPackages
			// 
			this.btnPackages.Location = new System.Drawing.Point(455, 185);
			this.btnPackages.Name = "btnPackages";
			this.btnPackages.Size = new System.Drawing.Size(116, 45);
			this.btnPackages.TabIndex = 0;
			this.btnPackages.Text = "Packages";
			this.btnPackages.UseVisualStyleBackColor = true;
			this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
			// 
			// btnSuppliers
			// 
			this.btnSuppliers.Location = new System.Drawing.Point(239, 185);
			this.btnSuppliers.Name = "btnSuppliers";
			this.btnSuppliers.Size = new System.Drawing.Size(116, 45);
			this.btnSuppliers.TabIndex = 1;
			this.btnSuppliers.Text = "Suppliers";
			this.btnSuppliers.UseVisualStyleBackColor = true;
			this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.Location = new System.Drawing.Point(71, 185);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(116, 45);
			this.btnProducts.TabIndex = 2;
			this.btnProducts.Text = "Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(642, 185);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(116, 45);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblCompanyName
			// 
			this.lblCompanyName.AutoSize = true;
			this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCompanyName.Location = new System.Drawing.Point(239, 34);
			this.lblCompanyName.Name = "lblCompanyName";
			this.lblCompanyName.Size = new System.Drawing.Size(332, 65);
			this.lblCompanyName.TabIndex = 4;
			this.lblCompanyName.Text = "TravelExperts";
			this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCompanyName.UseWaitCursor = true;
			// 
			// lblProgramName
			// 
			this.lblProgramName.AutoSize = true;
			this.lblProgramName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblProgramName.Location = new System.Drawing.Point(219, 99);
			this.lblProgramName.Name = "lblProgramName";
			this.lblProgramName.Size = new System.Drawing.Size(398, 45);
			this.lblProgramName.TabIndex = 5;
			this.lblProgramName.Text = "Data Administration Tool™";
			this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblProgramName.UseMnemonic = false;
			// 
			// lblCopyright
			// 
			this.lblCopyright.AutoSize = true;
			this.lblCopyright.Location = new System.Drawing.Point(322, 298);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(172, 15);
			this.lblCopyright.TabIndex = 6;
			this.lblCopyright.Text = "Copyright© TravelExperts, 2022";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblCopyright);
			this.Controls.Add(this.lblProgramName);
			this.Controls.Add(this.lblCompanyName);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnProducts);
			this.Controls.Add(this.btnSuppliers);
			this.Controls.Add(this.btnPackages);
			this.Name = "frmHome";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPackages;
		private System.Windows.Forms.Button btnSuppliers;
		private System.Windows.Forms.Button btnProducts;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblCompanyName;
		private System.Windows.Forms.Label lblProgramName;
		private System.Windows.Forms.Label lblCopyright;
	}
}

