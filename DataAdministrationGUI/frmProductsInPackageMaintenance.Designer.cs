
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.dgvProductsPackagesDisplay = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsPackagesDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(25, 313);
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
			this.btnHome.Location = new System.Drawing.Point(395, 313);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(182, 49);
			this.btnHome.TabIndex = 4;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = true;
			// 
			// dgvProductsPackagesDisplay
			// 
			this.dgvProductsPackagesDisplay.AllowUserToAddRows = false;
			this.dgvProductsPackagesDisplay.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgvProductsPackagesDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductsPackagesDisplay.BackgroundColor = System.Drawing.Color.LightGray;
			this.dgvProductsPackagesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProductsPackagesDisplay.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProductsPackagesDisplay.Location = new System.Drawing.Point(25, 49);
			this.dgvProductsPackagesDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvProductsPackagesDisplay.Name = "dgvProductsPackagesDisplay";
			this.dgvProductsPackagesDisplay.ReadOnly = true;
			this.dgvProductsPackagesDisplay.RowHeadersWidth = 51;
			this.dgvProductsPackagesDisplay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvProductsPackagesDisplay.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProductsPackagesDisplay.RowTemplate.Height = 29;
			this.dgvProductsPackagesDisplay.Size = new System.Drawing.Size(552, 247);
			this.dgvProductsPackagesDisplay.TabIndex = 5;
			this.dgvProductsPackagesDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDisplay_CellClick);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.label1.Size = new System.Drawing.Size(603, 45);
			this.label1.TabIndex = 10;
			this.label1.Text = "Products Inside Packages Maintenance";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmProductsInPackageMaintenance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnHome;
			this.ClientSize = new System.Drawing.Size(603, 379);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvProductsPackagesDisplay);
			this.Controls.Add(this.btnHome);
			this.Controls.Add(this.btnAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmProductsInPackageMaintenance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Products Inside Packages";
			this.Load += new System.EventHandler(this.frmProductsInsidePackage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsPackagesDisplay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvProductsPackagesDisplay;
        private System.Windows.Forms.Label label1;
    }
}