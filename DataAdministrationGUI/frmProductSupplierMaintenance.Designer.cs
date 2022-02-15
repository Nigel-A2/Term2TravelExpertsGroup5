
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvProductSupplierDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSupplierDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 324);
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
            this.btnHome.Location = new System.Drawing.Point(462, 324);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 49);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // dgvProductSupplierDisplay
            // 
            this.dgvProductSupplierDisplay.AllowUserToAddRows = false;
            this.dgvProductSupplierDisplay.AllowUserToDeleteRows = false;
            this.dgvProductSupplierDisplay.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvProductSupplierDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductSupplierDisplay.Location = new System.Drawing.Point(26, 52);
            this.dgvProductSupplierDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductSupplierDisplay.Name = "dgvProductSupplierDisplay";
            this.dgvProductSupplierDisplay.ReadOnly = true;
            this.dgvProductSupplierDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductSupplierDisplay.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductSupplierDisplay.RowTemplate.Height = 29;
            this.dgvProductSupplierDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductSupplierDisplay.Size = new System.Drawing.Size(618, 256);
            this.dgvProductSupplierDisplay.TabIndex = 8;
            this.dgvProductSupplierDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDisplay_CellClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.label1.Size = new System.Drawing.Size(677, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product/Supplier Maintenance";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProductSupplierMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductSupplierDisplay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
            this.MinimizeBox = false;
            this.Name = "frmProductSupplierMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProductSupplierMaintenance";
            this.Load += new System.EventHandler(this.frmProductSupplierMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSupplierDisplay)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dgvProductSupplierDisplay;
        private System.Windows.Forms.Label label1;
    }
}