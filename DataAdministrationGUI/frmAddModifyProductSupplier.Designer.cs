﻿
namespace DataAdministrationGUI
{
	partial class frmAddModifyProductSupplier
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
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblProduct = new System.Windows.Forms.Label();
			this.lblSupplier = new System.Windows.Forms.Label();
			this.cbxProduct = new System.Windows.Forms.ComboBox();
			this.cbxSupplier = new System.Windows.Forms.ComboBox();
			this.lblHeader = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(26, 124);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(169, 49);
			this.btnConfirm.TabIndex = 0;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(209, 124);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(169, 49);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblProduct
			// 
			this.lblProduct.AutoSize = true;
			this.lblProduct.Location = new System.Drawing.Point(26, 49);
			this.lblProduct.Name = "lblProduct";
			this.lblProduct.Size = new System.Drawing.Size(52, 15);
			this.lblProduct.TabIndex = 2;
			this.lblProduct.Text = "Product:";
			// 
			// lblSupplier
			// 
			this.lblSupplier.AutoSize = true;
			this.lblSupplier.Location = new System.Drawing.Point(26, 95);
			this.lblSupplier.Name = "lblSupplier";
			this.lblSupplier.Size = new System.Drawing.Size(53, 15);
			this.lblSupplier.TabIndex = 3;
			this.lblSupplier.Text = "Supplier:";
			// 
			// cbxProduct
			// 
			this.cbxProduct.FormattingEnabled = true;
			this.cbxProduct.Location = new System.Drawing.Point(85, 46);
			this.cbxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbxProduct.Name = "cbxProduct";
			this.cbxProduct.Size = new System.Drawing.Size(293, 23);
			this.cbxProduct.TabIndex = 6;
			this.cbxProduct.Tag = "Product";
			// 
			// cbxSupplier
			// 
			this.cbxSupplier.FormattingEnabled = true;
			this.cbxSupplier.Location = new System.Drawing.Point(85, 87);
			this.cbxSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbxSupplier.Name = "cbxSupplier";
			this.cbxSupplier.Size = new System.Drawing.Size(293, 23);
			this.cbxSupplier.TabIndex = 7;
			this.cbxSupplier.Tag = "Supplier";
			// 
			// lblHeader
			// 
			this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblHeader.Location = new System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.lblHeader.Size = new System.Drawing.Size(402, 45);
			this.lblHeader.TabIndex = 11;
			this.lblHeader.Text = "Add/Modify Product Supplier";
			this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmAddModifyProductSupplier
			// 
			this.AcceptButton = this.btnConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(402, 191);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.cbxSupplier);
			this.Controls.Add(this.cbxProduct);
			this.Controls.Add(this.lblSupplier);
			this.Controls.Add(this.lblProduct);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAddModifyProductSupplier";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Product-Suplier";
			this.Load += new System.EventHandler(this.frmAddModifyProductSupplier_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblProduct;
		private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label lblHeader;
    }
}