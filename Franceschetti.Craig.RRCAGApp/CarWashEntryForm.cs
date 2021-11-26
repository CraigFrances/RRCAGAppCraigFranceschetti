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


        public CarWashEntryForm()
        {
            InitializeComponent();

            ObtainFragranceDescriptionInput();
            PackageInput();
            InteriorAndExteriorFinish();
            BindingControls();

            this.fragranceSource.PositionChanged += PackageSourceOrFragranceSource_PositionChanged;
            this.packageSource.PositionChanged += PackageSourceOrFragranceSource_PositionChanged;


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
            string fragranceSelected = $"Fragrance - {((Fragrance)cboFragrance.SelectedItem).FragranceDescription}";


            for (int i = 0; i <= packageSource.Position; i++)
            {
                interiorServices.Add(interiorMasterList[i]);
                exteriorServices.Add(exteriorMasterList[i]);
            }

            interiorServices[0] = fragranceSelected;

        }

        private void PackageInput()
        {
            Package standard = new Package("Standard", 7.50m);
            Package deluxe = new Package("Deluxe", 15.00m);
            Package executive = new Package("Executive", 35.00m);
            Package luxury = new Package("Luxury", 55.00m);

            BindingList<Package> packageList;
            packageList = new BindingList<Package>();
            this.packageSource = new BindingSource();
            this.packageSource.DataSource = packageList;

            packageList.Add(standard);
            packageList.Add(deluxe);
            packageList.Add(executive);
            packageList.Add(luxury);
        }

        private void ObtainFragranceDescriptionInput()
        {
            BindingList<Fragrance> fragranceList;
            FileStream fragrancesStream;
            StreamReader reader;
            fragrancesStream = new FileStream("fragrances.txt", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(fragrancesStream);

            fragranceList = new BindingList<Fragrance>();
            this.fragranceSource = new BindingSource();
            this.fragranceSource.DataSource = fragranceList;

            while (reader.Peek() != -1)
            {
                string stringManipulation = reader.ReadLine();
                string fragranceDescription = stringManipulation.Substring(0, stringManipulation.IndexOf('$'));
                string fragrancePrice = stringManipulation.Substring(stringManipulation.IndexOf('$') + 1);
                decimal fragranceDecimal = Decimal.Parse(fragrancePrice.TrimEnd(','));
                fragranceList.Add(new Fragrance (fragranceDescription, fragranceDecimal));
            }
        }

        private void BindingControls()
        {
            cboFragrance.DataSource = this.fragranceSource;
            cboFragrance.DisplayMember = "FragranceDescription";
            cboFragrance.ValueMember = "FragrancePrice";
            cboPackage.DataSource = this.packageSource;
            cboPackage.DisplayMember = "PackageDescription";
            cboPackage.ValueMember = "PackagePrice";
            lstInterior.DataSource = this.interiorSource;
            lstExterior.DataSource = this.exteriorSource;
        }
    }
}
