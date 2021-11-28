/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-28
 * Updated: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Franceschetti.Craig.Buisness;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents a CarWashInvoiceForm.
    /// </summary>
    public partial class CarWashInvoiceForm : InvoiceForm
    {
        private BindingSource carWashSource;
        private BindingSource packageSource;
        private BindingSource fragranceSource;

        /// <summary>
        /// Initializes the CarWashInvoiceForm with three binding sources to bind the UI controls with.
        /// </summary>
        /// <param name="fragrance">Used to connect fragranceSource to the relevant UI controls</param>
        /// <param name="package">Used to connect packageSource to the relevant UI controls</param>
        /// <param name="carwash">Used to connect carwashSource to the relevant UI controls</param>
        public CarWashInvoiceForm(BindingSource fragrance, BindingSource package, BindingSource carwash)
        {
            InitializeComponent();
            Load += CarWashInvoiceForm_Load;

            this.packageSource = package;
            this.fragranceSource = fragrance;
            this.carWashSource = carwash;

            Binding packagePrice = new Binding("Text", this.packageSource, "Price");
            packagePrice.FormattingEnabled = true;
            packagePrice.FormatString = "C";
            this.lblPackagePriceOutput.DataBindings.Add(packagePrice);

            Binding fragrancePrice = new Binding("Text", this.fragranceSource, "Price");
            fragrancePrice.FormattingEnabled = true;
            fragrancePrice.FormatString = "N";
            this.lblFragrancePriceOutput.DataBindings.Add(fragrancePrice);

            Binding subTotal = new Binding("Text", this.carWashSource, "SubTotal");
            subTotal.FormattingEnabled = true;
            subTotal.FormatString = "C";
            this.lblSubTotalOutput.DataBindings.Add(subTotal);

            // add taxes
            Binding taxes = new Binding("Text", this.carWashSource, "ProvincialSalesTaxCharged");
            taxes.Format += Taxes_Format;
            this.lblTaxesOutput.DataBindings.Add(taxes);

            Binding total = new Binding("Text", this.carWashSource, "Total");
            total.FormattingEnabled = true;
            total.FormatString = "C";
            this.lblTotalOutput.DataBindings.Add(total);
        }

        /// <summary>
        /// Handles the Format event for the taxes binding.
        /// </summary>
        private void Taxes_Format(object sender, ConvertEventArgs e)
        {
            e.Value = (Decimal.Parse(e.Value.ToString()) + ((CarWashInvoice)this.carWashSource.Current).GoodsAndServicesTaxCharged).ToString("N2");
        }

        /// <summary>
        /// Handles the Load event for the form
        /// </summary>
        private void CarWashInvoiceForm_Load(object sender, EventArgs e)
        {
            this.lblInvoiceTitle.Text = "Car Wash Invoice";
            this.lblDateFormatted.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
    }
}
