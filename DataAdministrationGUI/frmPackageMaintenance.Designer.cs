
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
            this.dgvPackagesDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagesDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPackageToHome
            // 
            this.btnPackageToHome.Location = new System.Drawing.Point(844, 362);
            this.btnPackageToHome.Name = "btnPackageToHome";
            this.btnPackageToHome.Size = new System.Drawing.Size(144, 40);
            this.btnPackageToHome.TabIndex = 2;
            this.btnPackageToHome.Text = "Home";
            this.btnPackageToHome.UseVisualStyleBackColor = true;
            this.btnPackageToHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(660, 362);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(155, 40);
            this.btnAddPackage.TabIndex = 1;
            this.btnAddPackage.Text = "Add package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // dgvPackagesDisplay
            // 
            this.dgvPackagesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackagesDisplay.Location = new System.Drawing.Point(12, 86);
            this.dgvPackagesDisplay.Name = "dgvPackagesDisplay";
            this.dgvPackagesDisplay.RowTemplate.Height = 25;
            this.dgvPackagesDisplay.Size = new System.Drawing.Size(976, 243);
            this.dgvPackagesDisplay.TabIndex = 2;
            this.dgvPackagesDisplay.TabStop = false;
            this.dgvPackagesDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackagesDisplay_CellClick);
            // 
            // frmPackageMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnPackageToHome;
            this.ClientSize = new System.Drawing.Size(1000, 425);
            this.Controls.Add(this.dgvPackagesDisplay);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnPackageToHome);
            this.Name = "frmPackageMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Maintenance";
            this.Load += new System.EventHandler(this.frmPackageMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackagesDisplay)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPackageToHome;
		private System.Windows.Forms.Button btnAddPackage;
		private System.Windows.Forms.DataGridView dgvPackagesDisplay;
	}
}