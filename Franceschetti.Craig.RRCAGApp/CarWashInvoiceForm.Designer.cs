
namespace Franceschetti.Craig.RRCAGApp
{
    partial class CarWashInvoiceForm
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
            this.lblPackagePriceOutput = new System.Windows.Forms.Label();
            this.lblFragrancePriceOutput = new System.Windows.Forms.Label();
            this.lblTaxesOutput = new System.Windows.Forms.Label();
            this.lblSubTotalOutput = new System.Windows.Forms.Label();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblPackagePrice = new System.Windows.Forms.Label();
            this.lblFragrancePrice = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPackagePriceOutput
            // 
            this.lblPackagePriceOutput.Location = new System.Drawing.Point(496, 237);
            this.lblPackagePriceOutput.Name = "lblPackagePriceOutput";
            this.lblPackagePriceOutput.Size = new System.Drawing.Size(100, 23);
            this.lblPackagePriceOutput.TabIndex = 7;
            this.lblPackagePriceOutput.Text = "[Package Price]";
            this.lblPackagePriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFragrancePriceOutput
            // 
            this.lblFragrancePriceOutput.Location = new System.Drawing.Point(496, 266);
            this.lblFragrancePriceOutput.Name = "lblFragrancePriceOutput";
            this.lblFragrancePriceOutput.Size = new System.Drawing.Size(100, 23);
            this.lblFragrancePriceOutput.TabIndex = 8;
            this.lblFragrancePriceOutput.Text = "[Fragrance Price]";
            this.lblFragrancePriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxesOutput
            // 
            this.lblTaxesOutput.Location = new System.Drawing.Point(496, 324);
            this.lblTaxesOutput.Name = "lblTaxesOutput";
            this.lblTaxesOutput.Size = new System.Drawing.Size(100, 23);
            this.lblTaxesOutput.TabIndex = 10;
            this.lblTaxesOutput.Text = "[Taxes]";
            this.lblTaxesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalOutput
            // 
            this.lblSubTotalOutput.Location = new System.Drawing.Point(496, 295);
            this.lblSubTotalOutput.Name = "lblSubTotalOutput";
            this.lblSubTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.lblSubTotalOutput.TabIndex = 9;
            this.lblSubTotalOutput.Text = "[Subtotal]";
            this.lblSubTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.Location = new System.Drawing.Point(496, 353);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.lblTotalOutput.TabIndex = 11;
            this.lblTotalOutput.Text = "[Total]";
            this.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPackagePrice
            // 
            this.lblPackagePrice.AutoSize = true;
            this.lblPackagePrice.Location = new System.Drawing.Point(410, 242);
            this.lblPackagePrice.Name = "lblPackagePrice";
            this.lblPackagePrice.Size = new System.Drawing.Size(80, 13);
            this.lblPackagePrice.TabIndex = 12;
            this.lblPackagePrice.Text = "Package Price:";
            // 
            // lblFragrancePrice
            // 
            this.lblFragrancePrice.AutoSize = true;
            this.lblFragrancePrice.Location = new System.Drawing.Point(405, 271);
            this.lblFragrancePrice.Name = "lblFragrancePrice";
            this.lblFragrancePrice.Size = new System.Drawing.Size(85, 13);
            this.lblFragrancePrice.TabIndex = 13;
            this.lblFragrancePrice.Text = "Fragrance Price:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(441, 300);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(451, 329);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(39, 13);
            this.lblTaxes.TabIndex = 15;
            this.lblTaxes.Text = "Taxes:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(456, 358);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // CarWashInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 392);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblFragrancePrice);
            this.Controls.Add(this.lblPackagePrice);
            this.Controls.Add(this.lblTotalOutput);
            this.Controls.Add(this.lblTaxesOutput);
            this.Controls.Add(this.lblSubTotalOutput);
            this.Controls.Add(this.lblFragrancePriceOutput);
            this.Controls.Add(this.lblPackagePriceOutput);
            this.Name = "CarWashInvoiceForm";
            this.Text = "Car Wash Invoice";
            this.Controls.SetChildIndex(this.lblPackagePriceOutput, 0);
            this.Controls.SetChildIndex(this.lblFragrancePriceOutput, 0);
            this.Controls.SetChildIndex(this.lblSubTotalOutput, 0);
            this.Controls.SetChildIndex(this.lblTaxesOutput, 0);
            this.Controls.SetChildIndex(this.lblTotalOutput, 0);
            this.Controls.SetChildIndex(this.lblPackagePrice, 0);
            this.Controls.SetChildIndex(this.lblFragrancePrice, 0);
            this.Controls.SetChildIndex(this.lblSubTotal, 0);
            this.Controls.SetChildIndex(this.lblTaxes, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackagePriceOutput;
        private System.Windows.Forms.Label lblFragrancePriceOutput;
        private System.Windows.Forms.Label lblTaxesOutput;
        private System.Windows.Forms.Label lblSubTotalOutput;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblPackagePrice;
        private System.Windows.Forms.Label lblFragrancePrice;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblTotal;
    }
}