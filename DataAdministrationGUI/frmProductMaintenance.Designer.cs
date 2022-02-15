
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(233, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(31, 289);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(182, 49);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Maintenance";
            // 
            // dgvProductDisplay
            // 
            this.dgvProductDisplay.AllowUserToAddRows = false;
            this.dgvProductDisplay.AllowUserToDeleteRows = false;
            this.dgvProductDisplay.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvProductDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDisplay.Location = new System.Drawing.Point(31, 44);
            this.dgvProductDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductDisplay.Name = "dgvProductDisplay";
            this.dgvProductDisplay.ReadOnly = true;
            this.dgvProductDisplay.RowHeadersWidth = 51;
            this.dgvProductDisplay.RowTemplate.Height = 29;
            this.dgvProductDisplay.Size = new System.Drawing.Size(384, 229);
            this.dgvProductDisplay.TabIndex = 6;
            this.dgvProductDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDisplay_CellClick);
            // 
            // frmProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(441, 359);
            this.Controls.Add(this.dgvProductDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmProductMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Maintenance";
            this.Load += new System.EventHandler(this.frmAddModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProductDisplay;
    }
}