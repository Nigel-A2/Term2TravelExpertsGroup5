
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
            this.SuspendLayout();
            // 
            // btnCancelSupplier
            // 
            this.btnCancelSupplier.Location = new System.Drawing.Point(259, 238);
            this.btnCancelSupplier.Name = "btnCancelSupplier";
            this.btnCancelSupplier.Size = new System.Drawing.Size(185, 38);
            this.btnCancelSupplier.TabIndex = 0;
            this.btnCancelSupplier.Text = "Cancel";
            this.btnCancelSupplier.UseVisualStyleBackColor = true;
            this.btnCancelSupplier.Click += new System.EventHandler(this.btnCancelSupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(165, 49);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(119, 23);
            this.txtSupplierID.TabIndex = 3;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(165, 112);
            this.txtSupplierName.MaxLength = 255;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(279, 23);
            this.txtSupplierName.TabIndex = 4;
            this.txtSupplierName.Tag = "Supplier Name";
            // 
            // btnConfirmModify
            // 
            this.btnConfirmModify.Location = new System.Drawing.Point(259, 179);
            this.btnConfirmModify.Name = "btnConfirmModify";
            this.btnConfirmModify.Size = new System.Drawing.Size(185, 41);
            this.btnConfirmModify.TabIndex = 5;
            this.btnConfirmModify.Text = "Confirm";
            this.btnConfirmModify.UseVisualStyleBackColor = true;
            this.btnConfirmModify.Click += new System.EventHandler(this.btnConfirmModify_Click);
            // 
            // frmAddModifySupplier
            // 
            this.AcceptButton = this.btnConfirmModify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelSupplier;
            this.ClientSize = new System.Drawing.Size(464, 299);
            this.Controls.Add(this.btnConfirmModify);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelSupplier);
            this.Name = "frmAddModifySupplier";
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
    }
}