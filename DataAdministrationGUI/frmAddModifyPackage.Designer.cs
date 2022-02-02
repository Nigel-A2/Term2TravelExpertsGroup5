
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
            this.lblPackageID = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgDesc = new System.Windows.Forms.Label();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.lblPkgAgencyComission = new System.Windows.Forms.Label();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.txtPkgStartDate = new System.Windows.Forms.TextBox();
            this.txtPkgEndDate = new System.Windows.Forms.TextBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.btnPackageOK = new System.Windows.Forms.Button();
            this.lblPkgIdDisclaimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelPackage
            // 
            this.btnCancelPackage.Location = new System.Drawing.Point(490, 377);
            this.btnCancelPackage.Name = "btnCancelPackage";
            this.btnCancelPackage.Size = new System.Drawing.Size(197, 45);
            this.btnCancelPackage.TabIndex = 9;
            this.btnCancelPackage.Text = "Cancel";
            this.btnCancelPackage.UseVisualStyleBackColor = true;
            this.btnCancelPackage.Click += new System.EventHandler(this.btnCancelPackage_Click);
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(139, 33);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(68, 15);
            this.lblPackageID.TabIndex = 1;
            this.lblPackageID.Text = "Package ID:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(160, 72);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(42, 15);
            this.lblPkgName.TabIndex = 2;
            this.lblPkgName.Text = "Name:";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(61, 106);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(141, 15);
            this.lblPkgStartDate.TabIndex = 3;
            this.lblPkgStartDate.Text = "Start date (yyyy-mm-dd):";
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Location = new System.Drawing.Point(65, 143);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(137, 15);
            this.lblPkgEndDate.TabIndex = 4;
            this.lblPkgEndDate.Text = "End date (yyyy-mm-dd):";
            // 
            // lblPkgDesc
            // 
            this.lblPkgDesc.AutoSize = true;
            this.lblPkgDesc.Location = new System.Drawing.Point(139, 185);
            this.lblPkgDesc.Name = "lblPkgDesc";
            this.lblPkgDesc.Size = new System.Drawing.Size(70, 15);
            this.lblPkgDesc.TabIndex = 5;
            this.lblPkgDesc.Text = "Description:";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(139, 232);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(63, 15);
            this.lblPkgBasePrice.TabIndex = 6;
            this.lblPkgBasePrice.Text = "Base price:";
            // 
            // lblPkgAgencyComission
            // 
            this.lblPkgAgencyComission.AutoSize = true;
            this.lblPkgAgencyComission.Location = new System.Drawing.Point(95, 274);
            this.lblPkgAgencyComission.Name = "lblPkgAgencyComission";
            this.lblPkgAgencyComission.Size = new System.Drawing.Size(107, 15);
            this.lblPkgAgencyComission.TabIndex = 7;
            this.lblPkgAgencyComission.Text = "Agency comission:";
            // 
            // txtPackageID
            // 
            this.txtPackageID.Location = new System.Drawing.Point(218, 33);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(116, 23);
            this.txtPackageID.TabIndex = 99;
            this.txtPackageID.TabStop = false;
            this.txtPackageID.Tag = "Package ID";
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(218, 69);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(367, 23);
            this.txtPkgName.TabIndex = 2;
            this.txtPkgName.Tag = "Name";
            // 
            // txtPkgStartDate
            // 
            this.txtPkgStartDate.Location = new System.Drawing.Point(218, 103);
            this.txtPkgStartDate.Name = "txtPkgStartDate";
            this.txtPkgStartDate.Size = new System.Drawing.Size(259, 23);
            this.txtPkgStartDate.TabIndex = 3;
            this.txtPkgStartDate.Tag = "Start date";
            // 
            // txtPkgEndDate
            // 
            this.txtPkgEndDate.Location = new System.Drawing.Point(218, 140);
            this.txtPkgEndDate.Name = "txtPkgEndDate";
            this.txtPkgEndDate.Size = new System.Drawing.Size(259, 23);
            this.txtPkgEndDate.TabIndex = 4;
            this.txtPkgEndDate.Tag = "End date";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(218, 182);
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(469, 23);
            this.txtPkgDesc.TabIndex = 5;
            this.txtPkgDesc.Tag = "Description";
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(218, 229);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(116, 23);
            this.txtPkgBasePrice.TabIndex = 6;
            this.txtPkgBasePrice.Tag = "Base price";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(218, 271);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(116, 23);
            this.txtPkgAgencyCommission.TabIndex = 7;
            this.txtPkgAgencyCommission.Tag = "Agency comission";
            // 
            // btnPackageOK
            // 
            this.btnPackageOK.Location = new System.Drawing.Point(160, 377);
            this.btnPackageOK.Name = "btnPackageOK";
            this.btnPackageOK.Size = new System.Drawing.Size(158, 45);
            this.btnPackageOK.TabIndex = 8;
            this.btnPackageOK.Text = "OK";
            this.btnPackageOK.UseVisualStyleBackColor = true;
            this.btnPackageOK.Click += new System.EventHandler(this.btnPackageOK_Click);
            // 
            // lblPkgIdDisclaimer
            // 
            this.lblPkgIdDisclaimer.AutoSize = true;
            this.lblPkgIdDisclaimer.Location = new System.Drawing.Point(355, 33);
            this.lblPkgIdDisclaimer.Name = "lblPkgIdDisclaimer";
            this.lblPkgIdDisclaimer.Size = new System.Drawing.Size(210, 15);
            this.lblPkgIdDisclaimer.TabIndex = 16;
            this.lblPkgIdDisclaimer.Text = "(Package ID increments automatically)";
            // 
            // frmAddModifyPackage
            // 
            this.AcceptButton = this.btnPackageOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelPackage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPkgIdDisclaimer);
            this.Controls.Add(this.btnPackageOK);
            this.Controls.Add(this.txtPkgAgencyCommission);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(this.txtPkgEndDate);
            this.Controls.Add(this.txtPkgStartDate);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.txtPackageID);
            this.Controls.Add(this.lblPkgAgencyComission);
            this.Controls.Add(this.lblPkgBasePrice);
            this.Controls.Add(this.lblPkgDesc);
            this.Controls.Add(this.lblPkgEndDate);
            this.Controls.Add(this.lblPkgStartDate);
            this.Controls.Add(this.lblPkgName);
            this.Controls.Add(this.lblPackageID);
            this.Controls.Add(this.btnCancelPackage);
            this.Name = "frmAddModifyPackage";
            this.Text = "frmAddModifyPackage";
            this.Load += new System.EventHandler(this.frmAddModifyPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancelPackage;
		private System.Windows.Forms.Label lblPackageID;
		private System.Windows.Forms.Label lblPkgName;
		private System.Windows.Forms.Label lblPkgStartDate;
		private System.Windows.Forms.Label lblPkgEndDate;
		private System.Windows.Forms.Label lblPkgDesc;
		private System.Windows.Forms.Label lblPkgBasePrice;
		private System.Windows.Forms.Label lblPkgAgencyComission;
		private System.Windows.Forms.TextBox txtPackageID;
		private System.Windows.Forms.TextBox txtPkgName;
		private System.Windows.Forms.TextBox txtPkgStartDate;
		private System.Windows.Forms.TextBox txtPkgEndDate;
		private System.Windows.Forms.TextBox txtPkgDesc;
		private System.Windows.Forms.TextBox txtPkgBasePrice;
		private System.Windows.Forms.TextBox txtPkgAgencyCommission;
		private System.Windows.Forms.Button btnPackageOK;
		private System.Windows.Forms.Label lblPkgIdDisclaimer;
	}
}