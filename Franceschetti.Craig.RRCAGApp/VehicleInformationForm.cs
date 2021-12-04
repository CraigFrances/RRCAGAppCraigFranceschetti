/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-28
 * Updated: 
 */
using System.Windows.Forms;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents a VehicleInformationForm.
    /// </summary>
    public partial class VehicleInformationForm : Form
    {
        /// <summary>
        /// Initializes the VehicleInformationForm.
        /// </summary>
        /// <param name="vehicleSource">Binding source that will be used to bind to the UI controls of the form.</param>
        public VehicleInformationForm(BindingSource vehicleSource)
        {
            InitializeComponent();

            this.lblStockIdOutput.DataBindings.Add("Text", vehicleSource, "StockID");

            this.lblYearOutput.DataBindings.Add("Text", vehicleSource, "ManufacturedYear");

            this.lblManufacturerOutput.DataBindings.Add("Text", vehicleSource, "Manufacturer");

            this.lblModelOutput.DataBindings.Add("Text", vehicleSource, "Model");

            Binding transmission = new Binding("Text", vehicleSource, "IsAutomatic");
            transmission.Format += Transmission_Format;
            this.lblTransmissionOutput.DataBindings.Add(transmission);

            Binding mileage = new Binding("Text", vehicleSource, "Mileage");
            mileage.FormattingEnabled = true;
            mileage.FormatString = "N0";
            this.lblMileageOutput.DataBindings.Add(mileage);

            this.lblColourOutput.DataBindings.Add("Text", vehicleSource, "Colour");

            Binding basePrice = new Binding("Text", vehicleSource, "BasePrice");
            basePrice.FormattingEnabled = true;
            basePrice.FormatString = "C";
            this.lblBasePriceOutput.DataBindings.Add(basePrice);

            this.Text = vehicleSource.Current.ToString();

            btnClose.Click += BtnClose_Click;
        }

        /// <summary>
        /// Handles the Click event of the close button.
        /// </summary>
        private void BtnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Format event of the transmission binding.
        /// </summary>
        private void Transmission_Format(object sender, ConvertEventArgs e)
        {
            e.Value = (bool)e.Value == true ? "Automatic" : "Manual";
        }
    }
}
