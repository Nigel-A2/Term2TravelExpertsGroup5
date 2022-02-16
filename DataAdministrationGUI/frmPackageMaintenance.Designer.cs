
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnPackageToHome = new System.Windows.Forms.Button();
			this.btnAddPackage = new System.Windows.Forms.Button();
			this.dgvPackagesDisplay = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPackagesDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPackageToHome
			// 
			this.btnPackageToHome.Location = new System.Drawing.Point(933, 225);
			this.btnPackageToHome.Name = "btnPackageToHome";
			this.btnPackageToHome.Size = new System.Drawing.Size(182, 49);
			this.btnPackageToHome.TabIndex = 2;
			this.btnPackageToHome.Text = "Home";
			this.btnPackageToHome.UseVisualStyleBackColor = true;
			this.btnPackageToHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// btnAddPackage
			// 
			this.btnAddPackage.Location = new System.Drawing.Point(18, 225);
			this.btnAddPackage.Name = "btnAddPackage";
			this.btnAddPackage.Size = new System.Drawing.Size(182, 49);
			this.btnAddPackage.TabIndex = 1;
			this.btnAddPackage.Text = "Add package";
			this.btnAddPackage.UseVisualStyleBackColor = true;
			this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
			// 
			// dgvPackagesDisplay
			// 
			this.dgvPackagesDisplay.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvPackagesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPackagesDisplay.Location = new System.Drawing.Point(18, 47);
			this.dgvPackagesDisplay.Name = "dgvPackagesDisplay";
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvPackagesDisplay.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPackagesDisplay.RowTemplate.Height = 25;
			this.dgvPackagesDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvPackagesDisplay.Size = new System.Drawing.Size(1097, 161);
			this.dgvPackagesDisplay.TabIndex = 2;
			this.dgvPackagesDisplay.TabStop = false;
			this.dgvPackagesDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackagesDisplay_CellClick);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label1.Size = new System.Drawing.Size(1127, 45);
			this.label1.TabIndex = 10;
			this.label1.Text = "Package Maintenance";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmPackageMaintenance
			// 
			this.AcceptButton = this.btnAddPackage;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnPackageToHome;
			this.ClientSize = new System.Drawing.Size(1127, 290);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvPackagesDisplay);
			this.Controls.Add(this.btnAddPackage);
			this.Controls.Add(this.btnPackageToHome);
			this.MinimizeBox = false;
			this.Name = "frmPackageMaintenance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Package Maintenance";
			this.Load += new System.EventHandler(this.frmPackageMaintenance_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPackagesDisplay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnPackageToHome;
		private System.Windows.Forms.Button btnAddPackage;
		private System.Windows.Forms.DataGridView dgvPackagesDisplay;
        private System.Windows.Forms.Label label1;
    }
}