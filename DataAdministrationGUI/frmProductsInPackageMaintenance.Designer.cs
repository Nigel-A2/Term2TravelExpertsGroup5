
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsPackagesDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 295);
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
            this.btnHome.Location = new System.Drawing.Point(396, 295);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(182, 49);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Cancel";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // dgvProductsPackagesDisplay
            // 
            this.dgvProductsPackagesDisplay.AllowUserToAddRows = false;
            this.dgvProductsPackagesDisplay.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvProductsPackagesDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductsPackagesDisplay.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProductsPackagesDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductsPackagesDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductsPackagesDisplay.Location = new System.Drawing.Point(26, 31);
            this.dgvProductsPackagesDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductsPackagesDisplay.Name = "dgvProductsPackagesDisplay";
            this.dgvProductsPackagesDisplay.ReadOnly = true;
            this.dgvProductsPackagesDisplay.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductsPackagesDisplay.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductsPackagesDisplay.RowTemplate.Height = 29;
            this.dgvProductsPackagesDisplay.Size = new System.Drawing.Size(552, 247);
            this.dgvProductsPackagesDisplay.TabIndex = 5;
            this.dgvProductsPackagesDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDisplay_CellClick);
            // 
            // frmProductsInPackageMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHome;
            this.ClientSize = new System.Drawing.Size(603, 364);
            this.Controls.Add(this.dgvProductsPackagesDisplay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
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