/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-9
 * Updated: 2021-11-28
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
using RRCAG.Data;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents a Sales Quote Form.
    /// </summary>
    public partial class SalesQuoteForm : Form
    {
        private SalesQuote salesQuote;
        private BindingList<Vehicle> vehicles;
        private BindingSource salesQuoteSource;
        private BindingSource vehicleSource;
        
        /// <summary>
        /// Initializes the SalesQuoteForm.
        /// </summary>
        public SalesQuoteForm()
        {
            InitializeComponent();
            this.Load += SalesQuoteForm_Load;

            this.salesQuoteSource = new BindingSource();
            this.salesQuoteSource.DataSource = typeof(SalesQuote);

            this.vehicles = new BindingList<Vehicle>(DataRetriever.GetVehicles());
            this.vehicleSource = new BindingSource();
            this.vehicleSource.DataSource = this.vehicles;

            BindControls();
            this.btnCalculateQuote.Click += BtnCalculateQuote_Click;
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
            this.vehicleSource.CurrentChanged += vehicleSource_CurrentChanged;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.mnuViewVehicleInformation.Click += MnuViewVehicleInformation_Click;
        }

        /// <summary>
        /// handles the Click event for the view vehicle information menu selection.
        /// </summary>
        private void MnuViewVehicleInformation_Click(object sender, EventArgs e)
        {
            VehicleInformationForm vehichleInformationForm = new VehicleInformationForm(vehicleSource);
            vehichleInformationForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event for the close menu selection.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the CurrentChanged event for vehicle source.
        /// </summary>
        private void vehicleSource_CurrentChanged(object sender, EventArgs e)
        {
            ClearVehicleSummaryAndFinanceOutput();
            this.mnuViewVehicleInformation.Enabled = true;
        }

        /// <summary>
        /// Handles the Format event for the options bind.
        /// </summary>
        private void OptionsBind_Format(object sender, ConvertEventArgs e)
        {
            e.Value = (((SalesQuote)this.salesQuoteSource.Current).AccessoryCost + ((SalesQuote)this.salesQuoteSource.Current).FinishCost);
        }

        /// <summary>
        /// UI binding controls.
        /// </summary>
        private void BindControls()
        {
            this.cboVehicle.DataSource = this.vehicleSource;
            this.cboVehicle.DisplayMember = "StockID";
            VehicleSummaryBindedOutput();
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
            decimal tradeInValue;

            if (this.cboVehicle.SelectedItem == null)
            {
                this.errorProvider.SetError(this.cboVehicle, "A vehicle must be selected.");
            }
            else
            {
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
                if (this.errorProvider.GetError(txtTradeInValue).Equals(string.Empty))
                {

                    tradeInValue = Decimal.Parse(this.txtTradeInValue.Text);
                    const decimal SalesTaxRate = .12m;
                    this.salesQuote = new SalesQuote(((Vehicle)cboVehicle.SelectedItem).BasePrice, tradeInValue, SalesTaxRate);
                    AccessoriesChosen();
                    ExteriorFinishChosen();

                    this.salesQuoteSource.DataSource = this.salesQuote;

                    if (tradeInValue > ((Vehicle)this.cboVehicle.SelectedItem).BasePrice)
                    {
                        this.errorProvider.SetError(this.txtTradeInValue, "Trade-in value cannot exceed the vehicle sale price.");
                        ClearVehicleSummaryAndFinanceOutput();
                    }
                    else
                    {
                        FinancialOutput();
                    }
                }
                else
                {
                    ClearVehicleSummaryAndFinanceOutput();
                }
            }
        }

        /// <summary>
        /// Binds the UI controls to the salesQuote binding source.
        /// </summary>
        private void VehicleSummaryBindedOutput()
        {
            Binding vehicleSalePriceBind = new Binding("Text", this.salesQuoteSource, "VehicleSalePrice");
            vehicleSalePriceBind.FormattingEnabled = true;
            vehicleSalePriceBind.FormatString = "C";
            this.lblVehicleSalePriceOutput.DataBindings.Add(vehicleSalePriceBind);

            Binding optionsBind = new Binding("Text", this.salesQuoteSource, "FinishCost");
            optionsBind.Format += OptionsBind_Format;
            this.lblOptionsOutput.DataBindings.Add(optionsBind);

            Binding subTotal = new Binding("Text", this.salesQuoteSource, "SubTotal");
            subTotal.FormattingEnabled = true;
            subTotal.FormatString = "C";
            this.lblSubTotalOutput.DataBindings.Add(subTotal);

            Binding salesTax = new Binding("Text", this.salesQuoteSource, "SalesTax");
            salesTax.FormattingEnabled = true;
            salesTax.FormatString = "N";
            this.lblSalesTaxOutput.DataBindings.Add(salesTax);

            Binding total = new Binding("Text", this.salesQuoteSource, "Total");
            total.FormattingEnabled = true;
            total.FormatString = "C";
            this.lblTotalOutput.DataBindings.Add(total);

            Binding tradeInAmount = new Binding("Text", this.salesQuoteSource, "TradeInAmount");
            tradeInAmount.Format += TradeInAmount_Format;
            this.lblTradeInOutput.DataBindings.Add(tradeInAmount);

            Binding amountDue = new Binding("Text", this.salesQuoteSource, "AmountDue");
            amountDue.FormattingEnabled = true;
            amountDue.FormatString = "C";
            this.lblAmountDueOutput.DataBindings.Add(amountDue);
        }

        /// <summary>
        /// Handles the Format event for the trade in amount bind.
        /// </summary>
        private void TradeInAmount_Format(object sender, ConvertEventArgs e)
        {
            e.Value = Decimal.Parse(e.Value.ToString()) * -1;
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
                FinancialOutput();
                this.salesQuoteSource.ResetBindings(false);
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
                FinancialOutput();
                this.salesQuoteSource.ResetBindings(false);
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
            this.txtTradeInValue.Focus();
            this.txtTradeInValue.Text = "0";
            this.nudNumberOfYears.Value = 1m;
            this.nudAnnualInterestRate.Value = 5m;
            this.chkStereoSystem.Checked = false;
            this.chkLeatherInterior.Checked = false;
            this.chkComputerNavigation.Checked = false;
            this.radStandard.Checked = true;
            this.radPearlized.Checked = false;
            this.radCustomizedDetailing.Checked = false;
            this.cboVehicle.SelectedItem = null;
            this.mnuViewVehicleInformation.Enabled = false;
            this.errorProvider.SetIconPadding(this.cboVehicle, 3);
            this.errorProvider.SetIconPadding(this.txtTradeInValue, 3);
            this.lblVehicleSalePriceOutput.Text = string.Empty;
            this.lblOptionsOutput.Text = string.Empty;
            this.lblSubTotalOutput.Text = string.Empty;
            this.lblSalesTaxOutput.Text = string.Empty;
            this.lblTotalOutput.Text = string.Empty;
            this.lblTradeInOutput.Text = string.Empty;
            this.lblAmountDueOutput.Text = string.Empty;
            this.lblMonthlyPaymentFinanceOutput.Text = string.Empty;
            ResetErrorIcons();
        }

        /// <summary>
        /// Clears the vehicle summary and finance output section of the form.
        /// </summary>
        private void ClearVehicleSummaryAndFinanceOutput()
        {
            this.salesQuoteSource.List.Clear();
            this.lblMonthlyPaymentFinanceOutput.Text = string.Empty;
        }

        /// <summary>
        /// Removes any error messages for the VehicleSalePrice and TradeInValue text boxes.
        /// </summary>
        private void ResetErrorIcons()
        {
            this.errorProvider.SetError(this.cboVehicle, string.Empty);
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
