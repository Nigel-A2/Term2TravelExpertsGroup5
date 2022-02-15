
namespace DataAdministrationGUI
{
	partial class frmProductSupplierMaintenance
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
            this.dgvProductSupplierDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSupplierDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHome
            // 
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHome.Location = new System.Drawing.Point(450, 291);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 49);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Cancel";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // dgvProductSupplierDisplay
            // 
            this.dgvProductSupplierDisplay.AllowUserToAddRows = false;
            this.dgvProductSupplierDisplay.AllowUserToDeleteRows = false;
            this.dgvProductSupplierDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductSupplierDisplay.Location = new System.Drawing.Point(24, 19);
            this.dgvProductSupplierDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductSupplierDisplay.Name = "dgvProductSupplierDisplay";
            this.dgvProductSupplierDisplay.ReadOnly = true;
            this.dgvProductSupplierDisplay.RowHeadersWidth = 51;
            this.dgvProductSupplierDisplay.RowTemplate.Height = 29;
            this.dgvProductSupplierDisplay.Size = new System.Drawing.Size(608, 256);
            this.dgvProductSupplierDisplay.TabIndex = 8;
            this.dgvProductSupplierDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDisplay_CellClick);
            // 
            // frmProductSupplierMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 357);
            this.Controls.Add(this.dgvProductSupplierDisplay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmProductSupplierMaintenance";
            this.Text = "frmProductSupplierMaintenance";
            this.Load += new System.EventHandler(this.frmProductSupplierMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSupplierDisplay)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvProductSupplierDisplay;
    }
}