using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRCAG.Data;

namespace Franceschetti.Craig.RRCAGApp
{
    public partial class VehicleInformationForm : Form
    {
        
        public VehicleInformationForm(BindingSource vehicleSource)
        {
            InitializeComponent();

            lblStockIdOutput.DataBindings.Add("Text", vehicleSource, "StockID");

            lblYearOutput.DataBindings.Add("Text", vehicleSource, "ManufacturedYear");

            lblManufacturerOutput.DataBindings.Add("Text", vehicleSource, "Manufacturer");

            lblModelOutput.DataBindings.Add("Text", vehicleSource, "Model");

            Binding transmission = new Binding("Text", vehicleSource, "IsAutomatic");
            transmission.Format += Transmission_Format;
            lblTransmissionOutput.DataBindings.Add(transmission);

            Binding mileage = new Binding("Text", vehicleSource, "Mileage");
            mileage.FormattingEnabled = true;
            mileage.FormatString = "N0";
            lblMileageOutput.DataBindings.Add(mileage);

            lblColourOutput.DataBindings.Add("Text", vehicleSource, "Colour");

            Binding basePrice = new Binding("Text", vehicleSource, "BasePrice");
            basePrice.FormattingEnabled = true;
            basePrice.FormatString = "C";
            lblBasePriceOutput.DataBindings.Add(basePrice);

            this.Text = vehicleSource.Current.ToString();
        }


        private void Transmission_Format(object sender, ConvertEventArgs e)
        {
            e.Value = (bool)e.Value == true ? "Automatic" : "Manual";
        }
    }
}
