
namespace DataAdministrationGUI
{
	partial class frmAddModifyProduct
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
			this.tbxProductName = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.lblProductId = new System.Windows.Forms.Label();
			this.tbxProductId = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblHeader = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(22, 128);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(144, 49);
			this.btnConfirm.TabIndex = 3;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// tbxProductName
			// 
			this.tbxProductName.Location = new System.Drawing.Point(138, 89);
			this.tbxProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxProductName.Name = "tbxProductName";
			this.tbxProductName.Size = new System.Drawing.Size(188, 23);
			this.tbxProductName.TabIndex = 2;
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(22, 92);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(85, 15);
			this.lblProductName.TabIndex = 3;
			this.lblProductName.Text = "Product name:";
			// 
			// lblProductId
			// 
			this.lblProductId.AutoSize = true;
			this.lblProductId.Location = new System.Drawing.Point(22, 50);
			this.lblProductId.Name = "lblProductId";
			this.lblProductId.Size = new System.Drawing.Size(66, 15);
			this.lblProductId.TabIndex = 4;
			this.lblProductId.Text = "Product ID:";
			// 
			// tbxProductId
			// 
			this.tbxProductId.Enabled = false;
			this.tbxProductId.Location = new System.Drawing.Point(138, 47);
			this.tbxProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbxProductId.Name = "tbxProductId";
			this.tbxProductId.Size = new System.Drawing.Size(188, 23);
			this.tbxProductId.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(182, 128);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(144, 49);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lblHeader
			// 
			this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblHeader.Location = new System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
			this.lblHeader.Size = new System.Drawing.Size(347, 45);
			this.lblHeader.TabIndex = 10;
			this.lblHeader.Text = "Product Maintenance";
			this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmAddModifyProduct
			// 
			this.AcceptButton = this.btnConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(347, 198);
			this.Controls.Add(this.lblHeader);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.tbxProductId);
			this.Controls.Add(this.lblProductId);
			this.Controls.Add(this.lblProductName);
			this.Controls.Add(this.tbxProductName);
			this.Controls.Add(this.btnConfirm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmAddModifyProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add product";
			this.Load += new System.EventHandler(this.frmAddModifyProduct_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox tbxProductId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHeader;
    }
}