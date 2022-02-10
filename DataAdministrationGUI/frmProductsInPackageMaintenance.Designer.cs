
namespace DataAdministrationGUI
{
	partial class frmProductsInPackageMaintenance
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvProductsPackagesDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsPackagesDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(819, 75);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 57);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Location = new System.Drawing.Point(819, 452);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(179, 64);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Cancel";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // dgvProductsPackagesDisplay
            // 
            this.dgvProductsPackagesDisplay.AllowUserToAddRows = false;
            this.dgvProductsPackagesDisplay.AllowUserToDeleteRows = false;
            this.dgvProductsPackagesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsPackagesDisplay.Location = new System.Drawing.Point(30, 41);
            this.dgvProductsPackagesDisplay.Name = "dgvProductsPackagesDisplay";
            this.dgvProductsPackagesDisplay.ReadOnly = true;
            this.dgvProductsPackagesDisplay.RowHeadersWidth = 51;
            this.dgvProductsPackagesDisplay.RowTemplate.Height = 29;
            this.dgvProductsPackagesDisplay.Size = new System.Drawing.Size(757, 510);
            this.dgvProductsPackagesDisplay.TabIndex = 5;
            this.dgvProductsPackagesDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDisplay_CellClick);
            // 
            // frmProductsInPackageMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHome;
            this.ClientSize = new System.Drawing.Size(1226, 603);
            this.Controls.Add(this.dgvProductsPackagesDisplay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductsInPackageMaintenance";
            this.Text = "Products Inside Packages";
            this.Load += new System.EventHandler(this.frmProductsInsidePackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsPackagesDisplay)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvProductsPackagesDisplay;
    }
}