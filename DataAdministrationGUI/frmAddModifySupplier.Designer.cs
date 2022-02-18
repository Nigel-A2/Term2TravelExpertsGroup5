
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnConfirmModify = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelSupplier
            // 
            this.btnCancelSupplier.Location = new System.Drawing.Point(223, 91);
            this.btnCancelSupplier.Name = "btnCancelSupplier";
            this.btnCancelSupplier.Size = new System.Drawing.Size(182, 49);
            this.btnCancelSupplier.TabIndex = 3;
            this.btnCancelSupplier.Text = "Cancel";
            this.btnCancelSupplier.UseVisualStyleBackColor = true;
            this.btnCancelSupplier.Click += new System.EventHandler(this.btnCancelSupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier ID:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(10, 190);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(119, 23);
            this.txtSupplierID.TabIndex = 3;
            this.txtSupplierID.Visible = false;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(126, 52);
            this.txtSupplierName.MaxLength = 255;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(279, 23);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.Tag = "Supplier Name";
            // 
            // btnConfirmModify
            // 
            this.btnConfirmModify.Location = new System.Drawing.Point(24, 91);
            this.btnConfirmModify.Name = "btnConfirmModify";
            this.btnConfirmModify.Size = new System.Drawing.Size(182, 49);
            this.btnConfirmModify.TabIndex = 2;
            this.btnConfirmModify.Text = "Confirm";
            this.btnConfirmModify.UseVisualStyleBackColor = true;
            this.btnConfirmModify.Click += new System.EventHandler(this.btnConfirmModify_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.lblHeader.Size = new System.Drawing.Size(432, 45);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "Add/Modify Supplier";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddModifySupplier
            // 
            this.AcceptButton = this.btnConfirmModify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSupplier;
            this.ClientSize = new System.Drawing.Size(432, 170);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnConfirmModify);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddModifySupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddModifySupplier";
            this.Load += new System.EventHandler(this.frmAddModifySupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnConfirmModify;
        private System.Windows.Forms.Label lblHeader;
    }
}