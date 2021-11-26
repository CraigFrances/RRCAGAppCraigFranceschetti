
namespace Franceschetti.Craig.RRCAGApp
{
    partial class InvoiceForm
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityProvincePostal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateFormatted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(9, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(299, 31);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "RRC Automotive Group";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 52);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(109, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "777 Inheritance Drive";
            // 
            // lblCityProvincePostal
            // 
            this.lblCityProvincePostal.AutoSize = true;
            this.lblCityProvincePostal.Location = new System.Drawing.Point(12, 74);
            this.lblCityProvincePostal.Name = "lblCityProvincePostal";
            this.lblCityProvincePostal.Size = new System.Drawing.Size(144, 13);
            this.lblCityProvincePostal.TabIndex = 2;
            this.lblCityProvincePostal.Text = "Winnipeg, Manitoba, 101010";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 95);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "204-867-5309";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(11, 142);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(120, 24);
            this.lblInvoiceTitle.TabIndex = 4;
            this.lblInvoiceTitle.Text = "[Invoice Title]";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(482, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date:";
            // 
            // lblDateFormatted
            // 
            this.lblDateFormatted.Location = new System.Drawing.Point(521, 8);
            this.lblDateFormatted.Name = "lblDateFormatted";
            this.lblDateFormatted.Size = new System.Drawing.Size(74, 23);
            this.lblDateFormatted.TabIndex = 6;
            this.lblDateFormatted.Text = "11/26/2021";
            this.lblDateFormatted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 393);
            this.Controls.Add(this.lblDateFormatted);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInvoiceTitle);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCityProvincePostal);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceForm";
            this.Text = "[Form Title]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCityProvincePostal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateFormatted;
        protected System.Windows.Forms.Label lblInvoiceTitle;
    }
}