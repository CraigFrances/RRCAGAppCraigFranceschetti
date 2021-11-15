/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-9
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
using Franceschetti.Craig.RRCAG;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents a Sales Quote Form.
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        private SalesQuote salesQuote;
        
        /// <summary>
        /// Initializes the SalesQuoteForm.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();
            this.Load += SalesQuoteForm_Load;
            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
            this.txtVehicleSalePrice.TextChanged += TxtVehicleSalePriceOrTxtTradeInValue_TextChanged;
            this.txtTradeInValue.TextChanged += TxtVehicleSalePriceOrTxtTradeInValue_TextChanged;
            this.chkStereoSystem.Click += ChkAccessories_Click;
            this.chkLeatherInterior.Click += ChkAccessories_Click;
            this.chkComputerNavigation.Click += ChkAccessories_Click;
            this.radStandard.Click += RadExteriorFinish_Click;
            this.radPearlized.Click += RadExteriorFinish_Click;
            this.radCustomizedDetailing.Click += RadExteriorFinish_Click;
            this.nudNumberOfYears.ValueChanged += NudFinancial_ValueChanged;
            this.nudAnnualInterestRate.ValueChanged += NudFinancial_ValueChanged;
            this.btnReset.Click += BtnReset_Click;
        }

        /// <summary>
        /// Handles the Load event of the SalesQuoteForm.
        /// </summary>
        private void SalesQuoteForm_Load(object sender, EventArgs e)
        {
            SalesQuoteFormInitialState();
        }


        /// <summary>
        /// Handles the Click event of the calculate quote button.
        /// </summary>
        private void BtnCalculateQuote_Click(object sender, EventArgs e)
        {
            ResetErrorIcons();
            decimal vehicleSalePrice;
            decimal tradeInValue;

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

            if (this.errorProvider.GetError(txtVehicleSalePrice).Equals(string.Empty) && this.errorProvider.GetError(txtTradeInValue).Equals(string.Empty))
            {
                vehicleSalePrice = Decimal.Parse(this.txtVehicleSalePrice.Text);
                tradeInValue = Decimal.Parse(this.txtTradeInValue.Text);

                if (tradeInValue > vehicleSalePrice)
                {
                    errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                    ClearVehicleSummaryAndFinanceOutput();
                }
                else
                {
                    const decimal SalesTaxRate = .12m;
                    salesQuote = new SalesQuote(vehicleSalePrice, tradeInValue, SalesTaxRate);
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

        /// <summary>
        /// Handles the TextChanged events for both the vehicleSalePrice text box, and the tradeInValue text box.
        /// </summary>
        private void TxtVehicleSalePriceOrTxtTradeInValue_TextChanged(object sender, EventArgs e)
        {
            ClearVehicleSummaryAndFinanceOutput();
        }

        /// <summary>
        /// Handles the Click event for the Accessories check boxes.
        /// </summary>
        private void ChkAccessories_Click(object sender, EventArgs e)
        {
            if (!lblVehicleSalePriceOutput.Text.Equals(string.Empty))
            {
                AccessoriesChosen();
                VehicleSummaryOutputAndFinanceSummaryOutputExcludingTradeIn();
            }
        }

        /// <summary>
        /// Handles the Click event for the Exterior Finish radio buttons.
        /// </summary>
        private void RadExteriorFinish_Click(object sender, EventArgs e)
        {
            if (!lblVehicleSalePriceOutput.Text.Equals(string.Empty))
            {
                ExteriorFinishChosen();
                VehicleSummaryOutputAndFinanceSummaryOutputExcludingTradeIn();
            }
        }

        /// <summary>
        /// Handles the ValueChanged event for the Financial number up-downs.
        /// </summary>
        private void NudFinancial_ValueChanged(object sender, EventArgs e)
        {
            if (!lblVehicleSalePriceOutput.Text.Equals(string.Empty))
            {
                FinancialOutput();
            }
        }

        /// <summary>
        /// Handles the Click event for the Reset button.
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            const string Message = "Do you want to reset the form?";
            const string Caption = "Reset Form";
            const MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            const MessageBoxIcon Warning = MessageBoxIcon.Warning;
            const MessageBoxDefaultButton DefaultButton = MessageBoxDefaultButton.Button2;
            DialogResult messageBoxDialogResult = MessageBox.Show(this, Message, Caption, Buttons, Warning, DefaultButton);
            
            if (messageBoxDialogResult.Equals(DialogResult.Yes))
            {
                SalesQuoteFormInitialState();
            }
        }

        /// <summary>
        /// Resets the SalesQuoteForm to it's initial state.
        /// </summary>
        private void SalesQuoteFormInitialState()
        {
            this.txtVehicleSalePrice.Focus();
            this.txtVehicleSalePrice.Text = string.Empty;
            this.txtTradeInValue.Text = "0";
            this.nudNumberOfYears.Value = 1m;
            this.nudAnnualInterestRate.Value = 5m;
            this.chkStereoSystem.Checked = false;
            this.chkLeatherInterior.Checked = false;
            this.chkComputerNavigation.Checked = false;
            this.radStandard.Checked = true;
            this.radPearlized.Checked = false;
            this.radCustomizedDetailing.Checked = false;
            this.errorProvider.SetIconPadding(this.txtVehicleSalePrice, 3);
            this.errorProvider.SetIconPadding(this.txtTradeInValue, 3);
            ClearVehicleSummaryAndFinanceOutput();
            ResetErrorIcons();
        }

        /// <summary>
        /// Clears the vehicle summary and finance output section of the form.
        /// </summary>
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
            this.salesQuote = null;
        }

        /// <summary>
        /// Removes any error messages for the VehicleSalePrice and TradeInValue text boxes.
        /// </summary>
        private void ResetErrorIcons()
        {
            this.errorProvider.SetError(this.txtVehicleSalePrice, string.Empty);
            this.errorProvider.SetError(this.txtTradeInValue, string.Empty);
        }

        /// <summary>
        /// Determines the exterior finish chosen.
        /// </summary>
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

        /// <summary>
        /// Determines the accessories chosen.
        /// </summary>
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

        /// <summary>
        /// Sets the Summary state. 
        /// </summary>
        private void VehicleSummaryOutput()
        {
            this.lblVehicleSalePriceOutput.Text = salesQuote.VehicleSalePrice.ToString("C");
            decimal options = salesQuote.AccessoryCost + salesQuote.FinishCost;
            lblOptionsOutput.Text = options.ToString("N");

            lblSubTotalOutput.Text = salesQuote.SubTotal.ToString("C");
            lblSalesTaxOutput.Text = salesQuote.SalesTax.ToString("N");
            lblTotalOutput.Text = salesQuote.Total.ToString("C");

            decimal tradeInAsNegative = -1m * salesQuote.TradeInAmount;
            lblTradeInOutput.Text = tradeInAsNegative.ToString("N");
            lblAmountDueOutput.Text = salesQuote.AmountDue.ToString("C");
        }

        /// <summary>
        /// Sets the vehicle summary output, excluding trade in value.
        /// </summary>
        private void VehicleSummaryOutputAndFinanceSummaryOutputExcludingTradeIn()
        {
            decimal options = salesQuote.AccessoryCost + salesQuote.FinishCost;
            lblOptionsOutput.Text = options.ToString("N");

            lblSubTotalOutput.Text = salesQuote.SubTotal.ToString("C");
            lblSalesTaxOutput.Text = salesQuote.SalesTax.ToString("N");
            lblTotalOutput.Text = salesQuote.Total.ToString("C");
            lblAmountDueOutput.Text = salesQuote.AmountDue.ToString("C");

            FinancialOutput();
        }

        /// <summary>
        /// Sets the Finance state.
        /// </summary>
        private void FinancialOutput()
        {
            decimal rate = (nudAnnualInterestRate.Value / 100) / 12;
            int paymentPeriods = (int)nudNumberOfYears.Value * 12;
            decimal presentValue = salesQuote.AmountDue;
            decimal monthlyPaymentOutput = Financial.GetPayment(rate, paymentPeriods, presentValue);

            lblMonthlyPaymentFinanceOutput.Text = monthlyPaymentOutput.ToString("C");
        }
    }
}
