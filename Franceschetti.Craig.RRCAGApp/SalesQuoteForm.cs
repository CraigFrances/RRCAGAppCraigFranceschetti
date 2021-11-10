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
using Franceschetti.Craig.RRCAG;

namespace Franceschetti.Craig.RRCAGApp
{
    public partial class SalesQuoteForm : Form
    {
        public SalesQuoteForm()
        {
            InitializeComponent();

            this.Load += SalesQuoteForm_Load;

            btnCalculateQuote.Click += BtnCalculateQuote_Click;
        }

        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            SalesQuoteFormDefaultState();
        }

        private void SalesQuoteFormDefaultState()
        {
            this.txtVehicleSalePrice.Text = string.Empty;
            this.txtTradeInValue.Text = "0";
            this.lblVehicleSalePriceOutput.Text = string.Empty;
            this.lblOptionsOutput.Text = string.Empty;
            this.lblSubTotalOutput.Text = string.Empty;
            this.lblSalesTaxOutput.Text = string.Empty;
            this.lblTotalOutput.Text = string.Empty;
            this.lblTradeInOutput.Text = string.Empty;
            this.lblAmountDueOutput.Text = string.Empty;
            this.lblMonthlyPaymentFinanceOutput.Text = string.Empty;
            this.errorProvider.SetIconPadding(this.txtVehicleSalePrice, 3);
            this.errorProvider.SetIconPadding(this.txtTradeInValue, 3);
        }

        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            decimal vehicleSalePrice;
            decimal tradeInValue;
            
            this.errorProvider.SetError(this.txtVehicleSalePrice, string.Empty);
            this.errorProvider.SetError(this.txtTradeInValue, string.Empty);

            try
            {
                vehicleSalePrice = Decimal.Parse(this.txtVehicleSalePrice.Text);

                if (vehicleSalePrice <= 0m)
                {
                    this.errorProvider.SetError(this.txtVehicleSalePrice, "Vehicle price cannot be less than or equal to 0.");
                }
            }
            catch (FormatException)
            {
                if (this.txtVehicleSalePrice.Text.Equals(string.Empty))
                {
                    this.errorProvider.SetError(this.txtVehicleSalePrice, "Vehicle price is a required field.");
                }
                else
                {
                    this.errorProvider.SetError(this.txtVehicleSalePrice, "Vehicle price cannot contain letters or special characters.");
                }
            }
            
            try
            {
                tradeInValue = Decimal.Parse(this.txtTradeInValue.Text);

                if (tradeInValue < 0)
                {
                    this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot be less than 0.");
                }
            }
            catch (FormatException)
            {
                if (this.txtTradeInValue.Text.Equals(string.Empty))
                {
                    this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value is a required field.");
                }
                else
                {
                    this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot contain letters or special characters.");
                }
            }

            if (tradeInValue > vehicleSalePrice)
            {
                errorProvider.SetError(txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
            }

           
                     
        }
    }
}
