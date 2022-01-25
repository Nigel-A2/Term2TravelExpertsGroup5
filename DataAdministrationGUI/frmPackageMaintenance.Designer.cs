
namespace DataAdministrationGUI
{
	partial class frmPackageMaintenance
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
			this.btnPackageToHome = new System.Windows.Forms.Button();
			this.btnAddPackage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnPackageToHome
			// 
			this.btnPackageToHome.Location = new System.Drawing.Point(391, 394);
			this.btnPackageToHome.Name = "btnPackageToHome";
			this.btnPackageToHome.Size = new System.Drawing.Size(144, 38);
			this.btnPackageToHome.TabIndex = 0;
			this.btnPackageToHome.Text = "Home";
			this.btnPackageToHome.UseVisualStyleBackColor = true;
			this.btnPackageToHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// btnAddPackage
			// 
			this.btnAddPackage.Location = new System.Drawing.Point(379, 320);
			this.btnAddPackage.Name = "btnAddPackage";
			this.btnAddPackage.Size = new System.Drawing.Size(155, 40);
			this.btnAddPackage.TabIndex = 1;
			this.btnAddPackage.Text = "Add package";
			this.btnAddPackage.UseVisualStyleBackColor = true;
			this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
			// 
			// frmPackageMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddPackage);
			this.Controls.Add(this.btnPackageToHome);
			this.Name = "frmPackageMaintenance";
			this.Text = "frmPackageMaintenance";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPackageToHome;
		private System.Windows.Forms.Button btnAddPackage;
	}
}