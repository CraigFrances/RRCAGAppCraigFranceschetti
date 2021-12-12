
namespace Franceschetti.Craig.RRCAGApp
{
    partial class SalesQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.lblTradeInValue = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkComputerNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeatherInterior = new System.Windows.Forms.CheckBox();
            this.chkStereoSystem = new System.Windows.Forms.CheckBox();
            this.grpExteriorFinish = new System.Windows.Forms.GroupBox();
            this.radCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblVehicleSalePriceOutput = new System.Windows.Forms.Label();
            this.lblAmountDueOutput = new System.Windows.Forms.Label();
            this.lblTradeInOutput = new System.Windows.Forms.Label();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblSalesTaxOutput = new System.Windows.Forms.Label();
            this.lblSubTotalOutput = new System.Windows.Forms.Label();
            this.lblOptionsOutput = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblSummaryVehicleSalePrice = new System.Windows.Forms.Label();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPaymentFinanceOutput = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfYears = new System.Windows.Forms.NumericUpDown();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblAnnualInterestRate = new System.Windows.Forms.Label();
            this.lblNumberOfYears = new System.Windows.Forms.Label();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewVehicleInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAccessories.SuspendLayout();
            this.grpExteriorFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.AutoSize = true;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(80, 36);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(45, 13);
            this.lblVehicleSalePrice.TabIndex = 0;
            this.lblVehicleSalePrice.Text = "Vehicle:";
            // 
            // lblTradeInValue
            // 
            this.lblTradeInValue.AutoSize = true;
            this.lblTradeInValue.Location = new System.Drawing.Point(45, 73);
            this.lblTradeInValue.Name = "lblTradeInValue";
            this.lblTradeInValue.Size = new System.Drawing.Size(79, 13);
            this.lblTradeInValue.TabIndex = 2;
            this.lblTradeInValue.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(130, 70);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(129, 20);
            this.txtTradeInValue.TabIndex = 2;
            this.txtTradeInValue.Text = "9999";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkComputerNavigation);
            this.grpAccessories.Controls.Add(this.chkLeatherInterior);
            this.grpAccessories.Controls.Add(this.chkStereoSystem);
            this.grpAccessories.Location = new System.Drawing.Point(24, 115);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(235, 157);
            this.grpAccessories.TabIndex = 4;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkComputerNavigation
            // 
            this.chkComputerNavigation.AutoSize = true;
            this.chkComputerNavigation.Location = new System.Drawing.Point(24, 106);
            this.chkComputerNavigation.Name = "chkComputerNavigation";
            this.chkComputerNavigation.Size = new System.Drawing.Size(125, 17);
            this.chkComputerNavigation.TabIndex = 5;
            this.chkComputerNavigation.Text = "Computer Navigation";
            this.chkComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeatherInterior
            // 
            this.chkLeatherInterior.AutoSize = true;
            this.chkLeatherInterior.Location = new System.Drawing.Point(24, 70);
            this.chkLeatherInterior.Name = "chkLeatherInterior";
            this.chkLeatherInterior.Size = new System.Drawing.Size(97, 17);
            this.chkLeatherInterior.TabIndex = 4;
            this.chkLeatherInterior.Text = "Leather Interior";
            this.chkLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // chkStereoSystem
            // 
            this.chkStereoSystem.AutoSize = true;
            this.chkStereoSystem.Location = new System.Drawing.Point(24, 34);
            this.chkStereoSystem.Name = "chkStereoSystem";
            this.chkStereoSystem.Size = new System.Drawing.Size(94, 17);
            this.chkStereoSystem.TabIndex = 3;
            this.chkStereoSystem.Text = "Stereo System";
            this.chkStereoSystem.UseVisualStyleBackColor = true;
            // 
            // grpExteriorFinish
            // 
            this.grpExteriorFinish.Controls.Add(this.radCustomizedDetailing);
            this.grpExteriorFinish.Controls.Add(this.radPearlized);
            this.grpExteriorFinish.Controls.Add(this.radStandard);
            this.grpExteriorFinish.Location = new System.Drawing.Point(24, 298);
            this.grpExteriorFinish.Name = "grpExteriorFinish";
            this.grpExteriorFinish.Size = new System.Drawing.Size(235, 153);
            this.grpExteriorFinish.TabIndex = 5;
            this.grpExteriorFinish.TabStop = false;
            this.grpExteriorFinish.Text = "Exterior Finish";
            // 
            // radCustomizedDetailing
            // 
            this.radCustomizedDetailing.AutoSize = true;
            this.radCustomizedDetailing.Location = new System.Drawing.Point(24, 104);
            this.radCustomizedDetailing.Name = "radCustomizedDetailing";
            this.radCustomizedDetailing.Size = new System.Drawing.Size(123, 17);
            this.radCustomizedDetailing.TabIndex = 2;
            this.radCustomizedDetailing.Text = "Customized Detailing";
            this.radCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(24, 68);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(68, 17);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(24, 32);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 6;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(24, 466);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblVehicleSalePriceOutput);
            this.grpSummary.Controls.Add(this.lblAmountDueOutput);
            this.grpSummary.Controls.Add(this.lblTradeInOutput);
            this.grpSummary.Controls.Add(this.lblTotalOutput);
            this.grpSummary.Controls.Add(this.lblSalesTaxOutput);
            this.grpSummary.Controls.Add(this.lblSubTotalOutput);
            this.grpSummary.Controls.Add(this.lblOptionsOutput);
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.lblTradeIn);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.lblSummaryVehicleSalePrice);
            this.grpSummary.Location = new System.Drawing.Point(297, 26);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(307, 307);
            this.grpSummary.TabIndex = 7;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblVehicleSalePriceOutput
            // 
            this.lblVehicleSalePriceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalePriceOutput.Location = new System.Drawing.Point(144, 32);
            this.lblVehicleSalePriceOutput.Name = "lblVehicleSalePriceOutput";
            this.lblVehicleSalePriceOutput.Size = new System.Drawing.Size(126, 20);
            this.lblVehicleSalePriceOutput.TabIndex = 20;
            this.lblVehicleSalePriceOutput.Text = "9999";
            this.lblVehicleSalePriceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDueOutput
            // 
            this.lblAmountDueOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDueOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDueOutput.Location = new System.Drawing.Point(144, 257);
            this.lblAmountDueOutput.Name = "lblAmountDueOutput";
            this.lblAmountDueOutput.Size = new System.Drawing.Size(126, 20);
            this.lblAmountDueOutput.TabIndex = 19;
            this.lblAmountDueOutput.Text = "9999";
            this.lblAmountDueOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeInOutput
            // 
            this.lblTradeInOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeInOutput.Location = new System.Drawing.Point(144, 220);
            this.lblTradeInOutput.Name = "lblTradeInOutput";
            this.lblTradeInOutput.Size = new System.Drawing.Size(126, 20);
            this.lblTradeInOutput.TabIndex = 18;
            this.lblTradeInOutput.Text = "9999";
            this.lblTradeInOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOutput.Location = new System.Drawing.Point(144, 183);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(126, 20);
            this.lblTotalOutput.TabIndex = 17;
            this.lblTotalOutput.Text = "9999";
            this.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxOutput
            // 
            this.lblSalesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTaxOutput.Location = new System.Drawing.Point(144, 145);
            this.lblSalesTaxOutput.Name = "lblSalesTaxOutput";
            this.lblSalesTaxOutput.Size = new System.Drawing.Size(126, 20);
            this.lblSalesTaxOutput.TabIndex = 16;
            this.lblSalesTaxOutput.Text = "9999";
            this.lblSalesTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalOutput
            // 
            this.lblSubTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotalOutput.Location = new System.Drawing.Point(144, 109);
            this.lblSubTotalOutput.Name = "lblSubTotalOutput";
            this.lblSubTotalOutput.Size = new System.Drawing.Size(126, 20);
            this.lblSubTotalOutput.TabIndex = 15;
            this.lblSubTotalOutput.Text = "9999";
            this.lblSubTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptionsOutput
            // 
            this.lblOptionsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptionsOutput.Location = new System.Drawing.Point(144, 71);
            this.lblOptionsOutput.Name = "lblOptionsOutput";
            this.lblOptionsOutput.Size = new System.Drawing.Size(126, 20);
            this.lblOptionsOutput.TabIndex = 14;
            this.lblOptionsOutput.Text = "9999";
            this.lblOptionsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(69, 261);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.AutoSize = true;
            this.lblTradeIn.Location = new System.Drawing.Point(89, 224);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(49, 13);
            this.lblTradeIn.TabIndex = 11;
            this.lblTradeIn.Text = "Trade-in:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(104, 187);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(52, 149);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(86, 13);
            this.lblSalesTax.TabIndex = 7;
            this.lblSalesTax.Text = "Sales Tax (12%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(89, 113);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(92, 75);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(46, 13);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.Text = "Options:";
            // 
            // lblSummaryVehicleSalePrice
            // 
            this.lblSummaryVehicleSalePrice.AutoSize = true;
            this.lblSummaryVehicleSalePrice.Location = new System.Drawing.Point(35, 36);
            this.lblSummaryVehicleSalePrice.Name = "lblSummaryVehicleSalePrice";
            this.lblSummaryVehicleSalePrice.Size = new System.Drawing.Size(103, 13);
            this.lblSummaryVehicleSalePrice.TabIndex = 1;
            this.lblSummaryVehicleSalePrice.Text = "Vehicle\'s Sale Price:";
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblMonthlyPaymentFinanceOutput);
            this.grpFinance.Controls.Add(this.nudAnnualInterestRate);
            this.grpFinance.Controls.Add(this.nudNumberOfYears);
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.lblAnnualInterestRate);
            this.grpFinance.Controls.Add(this.lblNumberOfYears);
            this.grpFinance.Location = new System.Drawing.Point(297, 339);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(307, 112);
            this.grpFinance.TabIndex = 8;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblMonthlyPaymentFinanceOutput
            // 
            this.lblMonthlyPaymentFinanceOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPaymentFinanceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPaymentFinanceOutput.Location = new System.Drawing.Point(201, 59);
            this.lblMonthlyPaymentFinanceOutput.Name = "lblMonthlyPaymentFinanceOutput";
            this.lblMonthlyPaymentFinanceOutput.Size = new System.Drawing.Size(88, 20);
            this.lblMonthlyPaymentFinanceOutput.TabIndex = 21;
            this.lblMonthlyPaymentFinanceOutput.Text = "9999";
            this.lblMonthlyPaymentFinanceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(114, 58);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(65, 20);
            this.nudAnnualInterestRate.TabIndex = 8;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            131072});
            // 
            // nudNumberOfYears
            // 
            this.nudNumberOfYears.Location = new System.Drawing.Point(21, 59);
            this.nudNumberOfYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfYears.Name = "nudNumberOfYears";
            this.nudNumberOfYears.Size = new System.Drawing.Size(63, 20);
            this.nudNumberOfYears.TabIndex = 7;
            this.nudNumberOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(201, 37);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 13);
            this.lblMonthlyPayment.TabIndex = 2;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // lblAnnualInterestRate
            // 
            this.lblAnnualInterestRate.Location = new System.Drawing.Point(111, 24);
            this.lblAnnualInterestRate.Name = "lblAnnualInterestRate";
            this.lblAnnualInterestRate.Size = new System.Drawing.Size(85, 34);
            this.lblAnnualInterestRate.TabIndex = 1;
            this.lblAnnualInterestRate.Text = "Annual       Interest Rate";
            // 
            // lblNumberOfYears
            // 
            this.lblNumberOfYears.AutoSize = true;
            this.lblNumberOfYears.Location = new System.Drawing.Point(18, 37);
            this.lblNumberOfYears.Name = "lblNumberOfYears";
            this.lblNumberOfYears.Size = new System.Drawing.Size(66, 13);
            this.lblNumberOfYears.TabIndex = 0;
            this.lblNumberOfYears.Text = "No. of Years";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(495, 466);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(109, 30);
            this.btnCalculateQuote.TabIndex = 9;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(131, 33);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(128, 21);
            this.cboVehicle.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuFileClose.Size = new System.Drawing.Size(148, 22);
            this.mnuFileClose.Text = "&Close";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewVehicleInformation});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "&View";
            // 
            // mnuViewVehicleInformation
            // 
            this.mnuViewVehicleInformation.Name = "mnuViewVehicleInformation";
            this.mnuViewVehicleInformation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuViewVehicleInformation.Size = new System.Drawing.Size(246, 22);
            this.mnuViewVehicleInformation.Text = "Vehicle &Information";
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 508);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpExteriorFinish);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.lblTradeInValue);
            this.Controls.Add(this.lblVehicleSalePrice);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpExteriorFinish.ResumeLayout(false);
            this.grpExteriorFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label lblTradeInValue;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkComputerNavigation;
        private System.Windows.Forms.CheckBox chkLeatherInterior;
        private System.Windows.Forms.CheckBox chkStereoSystem;
        private System.Windows.Forms.GroupBox grpExteriorFinish;
        private System.Windows.Forms.RadioButton radCustomizedDetailing;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblSummaryVehicleSalePrice;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.NumericUpDown nudNumberOfYears;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblAnnualInterestRate;
        private System.Windows.Forms.Label lblNumberOfYears;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblVehicleSalePriceOutput;
        private System.Windows.Forms.Label lblAmountDueOutput;
        private System.Windows.Forms.Label lblTradeInOutput;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblSalesTaxOutput;
        private System.Windows.Forms.Label lblSubTotalOutput;
        private System.Windows.Forms.Label lblOptionsOutput;
        private System.Windows.Forms.Label lblMonthlyPaymentFinanceOutput;
        private System.Windows.Forms.ComboBox cboVehicle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewVehicleInformation;
    }
}