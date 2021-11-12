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
        private SalesQuote salesQuote;
        private decimal vehicleSalePrice;
        private decimal tradeInValue;
        private decimal options;
        private decimal rate;
        private int paymentPeriods;
        private decimal presentValue;
        private decimal monthlyPaymentOutput;

        public SalesQuoteForm()
        {
            InitializeComponent();
            
            this.Load += SalesQuoteForm_Load;

            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
            this.txtVehicleSalePrice.TextChanged += TxtVehicleSalePriceOrTxtTradeInValue_TextChanged;
            this.txtTradeInValue.TextChanged += TxtVehicleSalePriceOrTxtTradeInValue_TextChanged;
            this.chkStereoSystem.Click += ChkStereoSystem_Click;
            this.chkLeatherInterior.Click += ChkLeatherInterior_Click;
            this.chkComputerNavigation.Click += ChkComputerNavigation_Click;
            
        }

        private void ChkComputerNavigation_Click(object sender, EventArgs e)
        {
            if (salesQuote != null && !lblMonthlyPaymentFinanceOutput.Text.Equals(string.Empty))
            {
                AccessoriesChosen();
                VehicleSummaryOutputAndFinanceSummaryOutputExcludingTradeIn();
            }
        }

        private void ChkLeatherInterior_Click(object sender, EventArgs e)
        {
            if (salesQuote != null && !lblMonthlyPaymentFinanceOutput.Text.Equals(string.Empty))
            {
                AccessoriesChosen();
                VehicleSummaryOutputAndFinanceSummaryOutputExcludingTradeIn();
            }
        }

        private void ChkStereoSystem_Click(object sender, EventArgs e)
        {
            if (salesQuote != null && !lblMonthlyPaymentFinanceOutput.Text.Equals(string.Empty))
            {
                AccessoriesChosen();
                VehicleSummaryOutputAndFinanceSummaryOutputExcludingTradeIn();
            }
        }

        private void TxtVehicleSalePriceOrTxtTradeInValue_TextChanged(object sender, EventArgs e)
        {
            ClearVehicleSummaryAndFinanceOutput();
        }

        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            SalesQuoteFormDefaultState();
        }

        private void SalesQuoteFormDefaultState()
        {
            this.txtVehicleSalePrice.Text = string.Empty;
            this.txtTradeInValue.Text = "0";
            ClearVehicleSummaryAndFinanceOutput();
            this.errorProvider.SetIconPadding(this.txtVehicleSalePrice, 3);
            this.errorProvider.SetIconPadding(this.txtTradeInValue, 3);
        }

        private void ClearVehicleSummaryAndFinanceOutput()
        {
            this.lblVehicleSalePriceOutput.Text = string.Empty;
            this.lblOptionsOutput.Text = string.Empty;
            this.lblSubTotalOutput.Text = string.Empty;
            this.lblSalesTaxOutput.Text = string.Empty;
            this.lblTotalOutput.Text = string.Empty;
            this.lblTradeInOutput.Text = string.Empty;
            this.lblAmountDueOutput.Text = string.Empty;
            this.lblMonthlyPaymentFinanceOutput.Text = string.Empty;
        }

        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.txtVehicleSalePrice, string.Empty);
            this.errorProvider.SetError(this.txtTradeInValue, string.Empty);

            try
            {
                this.vehicleSalePrice = Decimal.Parse(this.txtVehicleSalePrice.Text);

                if (this.vehicleSalePrice <= 0m)
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
                this.tradeInValue = Decimal.Parse(this.txtTradeInValue.Text);

                if (this.tradeInValue < 0)
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

            if (this.errorProvider.GetError(txtVehicleSalePrice).Equals(string.Empty) && this.errorProvider.GetError(txtTradeInValue).Equals(string.Empty))
            {
                this.vehicleSalePrice = Decimal.Parse(this.txtVehicleSalePrice.Text);
                this.tradeInValue = Decimal.Parse(this.txtTradeInValue.Text);
                if(this.tradeInValue > this.vehicleSalePrice)
                {
                    errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                    ClearVehicleSummaryAndFinanceOutput();
                }
                else
                {
                    const decimal SalesTaxRate = .12m;
                    salesQuote = new SalesQuote(this.vehicleSalePrice, this.tradeInValue, SalesTaxRate);
                    AccessoriesChosen();
                    ExteriorFinishChosen();
                    VehicleSummaryOutput();
                    FinancialOutput();
                }
            } 
            else
            {
                ClearVehicleSummaryAndFinanceOutput();
            }
            
        }

        private void ExteriorFinishChosen()
        {
            if (radStandard.Checked)
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Standard;
            }
            else if (radPearlized.Checked)
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;
            }
            else if (radCustomizedDetailing.Checked)
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Custom;
            }
        }

        private void AccessoriesChosen()
        {
            if (chkStereoSystem.Checked && !chkLeatherInterior.Checked && !chkComputerNavigation.Checked)
            {
                salesQuote.AccessoriesChosen = Accessories.StereoSystem;
            }
            else if (chkLeatherInterior.Checked && !chkStereoSystem.Checked && !chkComputerNavigation.Checked)
            {
                salesQuote.AccessoriesChosen = Accessories.LeatherInterior;
            }
            else if (chkComputerNavigation.Checked && !chkLeatherInterior.Checked && !chkStereoSystem.Checked)
            {
                salesQuote.AccessoriesChosen = Accessories.ComputerNavigation;
            }
            else if (chkStereoSystem.Checked && chkLeatherInterior.Checked && !chkComputerNavigation.Checked)
            {
                salesQuote.AccessoriesChosen = Accessories.StereoAndLeather;
            }
            else if (chkStereoSystem.Checked && chkComputerNavigation.Checked && !chkLeatherInterior.Checked)
            {
                salesQuote.AccessoriesChosen = Accessories.StereoAndNavigation;
            }
            else if (chkLeatherInterior.Checked && !chkStereoSystem.Checked && chkComputerNavigation.Checked)
            {
                salesQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;
            }
            else if (chkLeatherInterior.Checked && chkComputerNavigation.Checked && chkStereoSystem.Checked)
            {
                salesQuote.AccessoriesChosen = Accessories.All;
            }
            else
            {
                salesQuote.AccessoriesChosen = Accessories.None;
            }
        }

        private void VehicleSummaryOutput()
        {
            this.lblVehicleSalePriceOutput.Text = salesQuote.VehicleSalePrice.ToString("C");
            this.options = salesQuote.AccessoryCost + salesQuote.FinishCost;
            lblOptionsOutput.Text = options.ToString("N");

            lblSubTotalOutput.Text = salesQuote.SubTotal.ToString("C");
            lblSalesTaxOutput.Text = salesQuote.SalesTax.ToString("N");
            lblTotalOutput.Text = salesQuote.Total.ToString("C");

            decimal tradeInAsNegative = -1m * salesQuote.TradeInAmount;
            lblTradeInOutput.Text = tradeInAsNegative.ToString("N");
            lblAmountDueOutput.Text = salesQuote.AmountDue.ToString("C");
        }

        private void VehicleSummaryOutputAndFinanceSummaryOutputExcludingTradeIn()
        {
            this.options = salesQuote.AccessoryCost + salesQuote.FinishCost;
            lblOptionsOutput.Text = options.ToString("N");

            lblSubTotalOutput.Text = salesQuote.SubTotal.ToString("C");
            lblSalesTaxOutput.Text = salesQuote.SalesTax.ToString("N");
            lblTotalOutput.Text = salesQuote.Total.ToString("C");
            lblAmountDueOutput.Text = salesQuote.AmountDue.ToString("C");
            FinancialOutput();
        }

        private void FinancialOutput()
        {
            this.rate = nudAnnualInterestRate.Value / 100;
            this.paymentPeriods = (int)nudNumberOfYears.Value * 12;
            this.presentValue = salesQuote.AmountDue;
            this.monthlyPaymentOutput = Financial.GetPayment(rate, paymentPeriods, presentValue);

            lblMonthlyPaymentFinanceOutput.Text = monthlyPaymentOutput.ToString("C");
        }
    }
}
