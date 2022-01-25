
namespace DataAdministrationGUI
{
	partial class frmAddModifyPackage
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
			this.btnCancelPackage = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCancelPackage
			// 
			this.btnCancelPackage.Location = new System.Drawing.Point(489, 307);
			this.btnCancelPackage.Name = "btnCancelPackage";
			this.btnCancelPackage.Size = new System.Drawing.Size(197, 46);
			this.btnCancelPackage.TabIndex = 0;
			this.btnCancelPackage.Text = "Cancel";
			this.btnCancelPackage.UseVisualStyleBackColor = true;
			this.btnCancelPackage.Click += new System.EventHandler(this.btnCancelPackage_Click);
			// 
			// frmAddModifyPackage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCancelPackage);
			this.Name = "frmAddModifyPackage";
			this.Text = "frmAddModifyPackage";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancelPackage;
	}
}