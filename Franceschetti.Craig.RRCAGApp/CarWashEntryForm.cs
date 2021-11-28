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
    public partial class CarWashEntryForm : Form
    {
        BindingSource fragranceSource;
        BindingSource packageSource;
        BindingSource interiorSource;
        BindingSource exteriorSource;
        BindingSource carWashSource;
        BindingList<string> interiorServices;
        BindingList<string> exteriorServices;
        List<string> interiorMasterList;
        List<string> exteriorMasterList;
        CarWashInvoice carWashInvoice;
        BindingList<CarWashServices> packages;
        BindingList<CarWashServices> fragrances;
        FileStream fragrancesStream;



        public CarWashEntryForm()
        {
            InitializeComponent();
            carWashSource = new BindingSource();
            


            
            ObtainFragranceDescriptionInput();
            PackageInput();

            carWashInvoice = new CarWashInvoice(.07m, .05m, ((CarWashServices)packageSource.Current).Price, ((CarWashServices)fragranceSource.Current).Price);
            this.carWashSource.DataSource = carWashInvoice;

            InteriorAndExteriorFinish();
           
            BindingControls();
            



            this.fragranceSource.PositionChanged += PackageSourceOrFragranceSource_PositionChanged;
            this.packageSource.PositionChanged += PackageSourceOrFragranceSource_PositionChanged;
            this.mnuFileGenerateInvoice.Click += MnuFileGenerateInvoice_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;


        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnuFileGenerateInvoice_Click(object sender, EventArgs e)
        {
            CarWashInvoiceForm carWashInvoiceForm = new CarWashInvoiceForm(this.fragranceSource, this.packageSource, this.carWashSource);
            carWashInvoiceForm.ShowDialog();
        }

        private void InteriorAndExteriorFinish()
        {
            interiorServices = new BindingList<string>();
            exteriorServices = new BindingList<string>();
            interiorMasterList = new List<string>();
            exteriorMasterList = new List<string>();

            this.interiorSource = new BindingSource();
            this.exteriorSource = new BindingSource();
            this.interiorSource.DataSource = interiorServices;
            this.exteriorSource.DataSource = exteriorServices;
            

            interiorMasterList.Add("Fragrance - Pine");
            interiorMasterList.Add("Shampoo Carpets");
            interiorMasterList.Add("Shampoo Upholstery");
            interiorMasterList.Add("Interior Protection Coat");
            exteriorMasterList.Add("Hand Wash");
            exteriorMasterList.Add("Hand Wax");
            exteriorMasterList.Add("Wheel Polish");
            exteriorMasterList.Add("Detail Engine Compartment");
            
            interiorServices.Add(interiorMasterList[0]);
            exteriorServices.Add(exteriorMasterList[0]);

        }

        

        private void PackageSourceOrFragranceSource_PositionChanged(object sender, EventArgs e)
        {
            interiorServices.Clear();
            exteriorServices.Clear();
            carWashSource.List.Clear();
            string fragranceSelected = $"Fragrance - {((CarWashServices)cboFragrance.SelectedItem).Description}";


            for (int i = 0; i <= packageSource.Position; i++)
            {
                interiorServices.Add(interiorMasterList[i]);
                exteriorServices.Add(exteriorMasterList[i]);
            }
            interiorServices[0] = fragranceSelected;
            carWashInvoice = new CarWashInvoice(.07m, .05m, ((CarWashServices)cboPackage.SelectedItem).Price, ((CarWashServices)cboFragrance.SelectedItem).Price);
            this.carWashSource.DataSource = carWashInvoice;
        }

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

        private void ObtainFragranceDescriptionInput()
        {
            
            fragrancesStream = new FileStream("fragrances.txt", FileMode.Open, FileAccess.Read);
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

        private void BindingControls()
        {
            cboFragrance.DataSource = this.fragranceSource;
            cboFragrance.DisplayMember = "Description";
            cboFragrance.ValueMember = "Price";
            cboPackage.DataSource = this.packageSource;
            cboPackage.DisplayMember = "Description";
            cboPackage.ValueMember = "Price";
            lstInterior.DataSource = this.interiorSource;
            lstExterior.DataSource = this.exteriorSource;

            Binding subTotal = new Binding("Text", carWashSource, "SubTotal");
            subTotal.FormattingEnabled = true;
            subTotal.FormatString = "C";
            lblSubtotalOutput.DataBindings.Add(subTotal);

            Binding provincialSalesTax = new Binding("Text", carWashSource, "ProvincialSalesTaxCharged");
            provincialSalesTax.FormattingEnabled = true;
            provincialSalesTax.FormatString = "N2";
            lblPSTOutput.DataBindings.Add(provincialSalesTax);

            Binding goodsAndServicesSalesTax = new Binding("Text", carWashSource, "GoodsAndServicesTaxCharged");
            goodsAndServicesSalesTax.FormattingEnabled = true;
            goodsAndServicesSalesTax.FormatString = "N2";
            lblGSTOutput.DataBindings.Add(goodsAndServicesSalesTax);

            Binding total = new Binding("Text", carWashSource, "Total");
            total.FormattingEnabled = true;
            total.FormatString = "C";
            lblTotalOutput.DataBindings.Add(total);

        }
    }
}
