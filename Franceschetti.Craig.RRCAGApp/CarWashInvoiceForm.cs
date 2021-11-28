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
    public partial class CarWashInvoiceForm : InvoiceForm
    {
        private BindingSource carWashSource;
        private BindingSource packageSource;
        private BindingSource fragranceSource;
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

        private void Taxes_Format(object sender, ConvertEventArgs e)
        {
            e.Value = (Decimal.Parse(e.Value.ToString()) + ((CarWashInvoice)carWashSource.Current).GoodsAndServicesTaxCharged).ToString("N2");
        }

        private void CarWashInvoiceForm_Load(object sender, EventArgs e)
        {
            lblInvoiceTitle.Text = "Car Wash Invoice";
            
        }
    }
}
