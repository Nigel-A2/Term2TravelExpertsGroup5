
namespace DataAdministrationGUI
{
    partial class frmSupplierMaintenance
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
            this.btnSuppliersToHome = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuppliersToHome
            // 
            this.btnSuppliersToHome.Location = new System.Drawing.Point(728, 485);
            this.btnSuppliersToHome.Name = "btnSuppliersToHome";
            this.btnSuppliersToHome.Size = new System.Drawing.Size(182, 49);
            this.btnSuppliersToHome.TabIndex = 0;
            this.btnSuppliersToHome.Text = "Home";
            this.btnSuppliersToHome.UseVisualStyleBackColor = true;
            this.btnSuppliersToHome.Click += new System.EventHandler(this.btnSuppliersToHome_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(728, 418);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(182, 49);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Location = new System.Drawing.Point(12, 14);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowTemplate.Height = 25;
            this.dgvSuppliers.Size = new System.Drawing.Size(710, 520);
            this.dgvSuppliers.TabIndex = 2;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
            // 
            // frmSupplierMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSuppliersToHome;
            this.ClientSize = new System.Drawing.Size(922, 553);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnSuppliersToHome);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmSupplierMaintenance";
            this.Text = "Supplier Maintenance";
            this.Load += new System.EventHandler(this.frmSupplierMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuppliersToHome;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
    }
}