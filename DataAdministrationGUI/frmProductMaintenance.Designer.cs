
namespace DataAdministrationGUI
{
	partial class frmProductMaintenance
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
			this.btnProductToHome = new System.Windows.Forms.Button();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnProductToHome
			// 
			this.btnProductToHome.Location = new System.Drawing.Point(339, 304);
			this.btnProductToHome.Name = "btnProductToHome";
			this.btnProductToHome.Size = new System.Drawing.Size(185, 42);
			this.btnProductToHome.TabIndex = 0;
			this.btnProductToHome.Text = "Home";
			this.btnProductToHome.UseVisualStyleBackColor = true;
			this.btnProductToHome.Click += new System.EventHandler(this.btnProductToHome_Click);
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(323, 237);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(200, 40);
			this.btnAddProduct.TabIndex = 1;
			this.btnAddProduct.Text = "Add product";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// frmProductMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.btnProductToHome);
			this.Name = "frmProductMaintenance";
			this.Text = "frmProductMaintenance";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnProductToHome;
		private System.Windows.Forms.Button btnAddProduct;
	}
}