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
using System.IO;
using Franceschetti.Craig.Buisness;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents a CarWashEntryForm.
    /// </summary>
    public partial class CarWashEntryForm : Form
    {
        private BindingSource fragranceSource;
        private BindingSource packageSource;
        private BindingSource interiorSource;
        private BindingSource exteriorSource;
        private BindingSource carWashSource;
        private BindingList<string> interiorServices;
        private BindingList<string> exteriorServices;
        private BindingList<CarWashServices> packages;
        private BindingList<CarWashServices> fragrances;
        private List<string> interiorMasterList;
        private List<string> exteriorMasterList;
        private CarWashInvoice carWashInvoice;

        /// <summary>
        /// Initializes the CarWashEntryForm.
        /// </summary>
        public CarWashEntryForm()
        {
            InitializeComponent();
            this.carWashSource = new BindingSource();

            FragranceInput();
            PackageInput();

            this.carWashInvoice = new CarWashInvoice(.07m, .05m, ((CarWashServices)this.packageSource.Current).Price, ((CarWashServices)this.fragranceSource.Current).Price);
            this.carWashSource.DataSource = this.carWashInvoice;

            InteriorAndExteriorFinish();

            BindingControls();
            this.fragranceSource.PositionChanged += PackageSourceOrFragranceSource_PositionChanged;
            this.packageSource.PositionChanged += PackageSourceOrFragranceSource_PositionChanged;
            this.mnuFileGenerateInvoice.Click += MnuFileGenerateInvoice_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
        }

        /// <summary>
        /// Handles the Click event of the Exit menu selection.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of the generate invoice menu selection.
        /// </summary>
        private void MnuFileGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm carWashInvoiceForm = new CarWashInvoiceForm(this.fragranceSource, this.packageSource, this.carWashSource);
            carWashInvoiceForm.ShowDialog();
        }

        /// <summary>
        /// Setup for exterior and interior finish list boxes. Also sets the initial state.
        /// </summary>
        private void InteriorAndExteriorFinish()
        {
            this.interiorServices = new BindingList<string>();
            this.exteriorServices = new BindingList<string>();
            this.interiorMasterList = new List<string>();
            this.exteriorMasterList = new List<string>();

            this.interiorSource = new BindingSource();
            this.exteriorSource = new BindingSource();
            this.interiorSource.DataSource = interiorServices;
            this.exteriorSource.DataSource = exteriorServices;

            this.interiorMasterList.Add("Pine");
            this.interiorMasterList.Add("Shampoo Carpets");
            this.interiorMasterList.Add("Shampoo Upholstery");
            this.interiorMasterList.Add("Interior Protection Coat");
            this.exteriorMasterList.Add("Hand Wash");
            this.exteriorMasterList.Add("Hand Wax");
            this.exteriorMasterList.Add("Wheel Polish");
            this.exteriorMasterList.Add("Detail Engine Compartment");
            SelectInteriorExteriorChoices();
        }

        /// <summary>
        /// Selects the chosen interior and exterior finishes to display.
        /// </summary>
        private void SelectInteriorExteriorChoices()
        {
            string fragranceSelected = $"Fragrance - {((CarWashServices)this.fragranceSource.Current).Description}";
            for (int i = 0; i <= this.packageSource.Position; i++)
            {
                this.interiorServices.Add(interiorMasterList[i]);
                this.exteriorServices.Add(exteriorMasterList[i]);
            }
            this.interiorServices[0] = fragranceSelected;
        }

        /// <summary>
        /// Handles the PositionChanged event of the packageSource and fragranceSource.
        /// </summary>
        private void PackageSourceOrFragranceSource_PositionChanged(object sender, EventArgs e)
        {
            this.interiorServices.Clear();
            this.exteriorServices.Clear();
           
            SelectInteriorExteriorChoices();
            this.carWashInvoice = new CarWashInvoice(.07m, .05m, ((CarWashServices)this.cboPackage.SelectedItem).Price,
                ((CarWashServices)this.cboFragrance.SelectedItem).Price);
            this.carWashSource.DataSource = this.carWashInvoice;
        }

        /// <summary>
        /// Sets the initial values for Packages.
        /// </summary>
        private void PackageInput()
        {
            CarWashServices standard = new CarWashServices("Standard", 7.50m);
            CarWashServices deluxe = new CarWashServices("Deluxe", 15.00m);
            CarWashServices executive = new CarWashServices("Executive", 35.00m);
            CarWashServices luxury = new CarWashServices("Luxury", 55.00m);

            this.packages = new BindingList<CarWashServices>();
            this.packageSource = new BindingSource();
            this.packageSource.DataSource = this.packages;

            this.packages.Add(standard);
            this.packages.Add(deluxe);
            this.packages.Add(executive);
            this.packages.Add(luxury); 
        }

        /// <summary>
        /// Sets the initial Fragrance values from fragrance.txt.
        /// </summary>
        private void FragranceInput()
        {
            FileStream fragrancesStream = new FileStream("fragrances.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader;
            fragrancesStream.Flush();

            reader = new StreamReader(fragrancesStream);

            fragrances = new BindingList<CarWashServices>();
            this.fragranceSource = new BindingSource();
            this.fragranceSource.DataSource = fragrances;

            while (reader.Peek() != -1)
            {
                string splitter = reader.ReadLine();
                string[] fragranceData = splitter.Split(',');
                fragrances.Add(new CarWashServices(fragranceData[0], Decimal.Parse(fragranceData[1])));
            }
            fragrancesStream.Close();
        }

        /// <summary>
        /// Bind controls.
        /// </summary>
        private void BindingControls()
        {
            this.cboFragrance.DataSource = this.fragranceSource;
            this.cboFragrance.DisplayMember = "Description";
            this.cboFragrance.ValueMember = "Price";
            this.cboPackage.DataSource = this.packageSource;
            this.cboPackage.DisplayMember = "Description";
            this.cboPackage.ValueMember = "Price";
            this.lstInterior.DataSource = this.interiorSource;
            this.lstExterior.DataSource = this.exteriorSource;
            
            Binding subTotal = new Binding("Text", this.carWashSource, "SubTotal");
            subTotal.FormattingEnabled = true;
            subTotal.FormatString = "C";
            this.lblSubtotalOutput.DataBindings.Add(subTotal);

            Binding provincialSalesTax = new Binding("Text", this.carWashSource, "ProvincialSalesTaxCharged");
            provincialSalesTax.FormattingEnabled = true;
            provincialSalesTax.FormatString = "N2";
            this.lblPSTOutput.DataBindings.Add(provincialSalesTax);

            Binding goodsAndServicesSalesTax = new Binding("Text", this.carWashSource, "GoodsAndServicesTaxCharged");
            goodsAndServicesSalesTax.FormattingEnabled = true;
            goodsAndServicesSalesTax.FormatString = "N2";
            this.lblGSTOutput.DataBindings.Add(goodsAndServicesSalesTax);

            Binding total = new Binding("Text", this.carWashSource, "Total");
            total.FormattingEnabled = true;
            total.FormatString = "C";
            this.lblTotalOutput.DataBindings.Add(total);
        }
    }
}
