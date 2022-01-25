
namespace DataAdministrationGUI
{
	partial class frmAddModifySupplier
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
			this.btnCancelSupplier = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancelSupplier
			// 
			this.btnCancelSupplier.Location = new System.Drawing.Point(481, 330);
			this.btnCancelSupplier.Name = "btnCancelSupplier";
			this.btnCancelSupplier.Size = new System.Drawing.Size(185, 38);
			this.btnCancelSupplier.TabIndex = 0;
			this.btnCancelSupplier.Text = "Cancel";
			this.btnCancelSupplier.UseVisualStyleBackColor = true;
			this.btnCancelSupplier.Click += new System.EventHandler(this.btnCancelSupplier_Click);
			// 
			// frmAddModifySupplier
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCancelSupplier);
			this.Name = "frmAddModifySupplier";
			this.Text = "frmAddModifySupplier";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancelSupplier;
	}
}