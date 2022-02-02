
namespace DataAdministrationGUI
{
	partial class frmProductsInsidePackage
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
            this.lbxPackageProducts = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPackageProducts
            // 
            this.lbxPackageProducts.FormattingEnabled = true;
            this.lbxPackageProducts.ItemHeight = 15;
            this.lbxPackageProducts.Location = new System.Drawing.Point(40, 56);
            this.lbxPackageProducts.Name = "lbxPackageProducts";
            this.lbxPackageProducts.Size = new System.Drawing.Size(396, 349);
            this.lbxPackageProducts.TabIndex = 0;
            this.lbxPackageProducts.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(541, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(541, 150);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(158, 42);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(541, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 45);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(541, 357);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(157, 48);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmProductsInsidePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHome;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxPackageProducts);
            this.Name = "frmProductsInsidePackage";
            this.Text = "Products Inside Packages";
            this.Load += new System.EventHandler(this.frmProductsInsidePackage_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbxPackageProducts;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnHome;
	}
}