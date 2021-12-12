/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-8
 * Updated: 2021-12-12
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents the launcher form.
    /// </summary>
    public partial class LauncherForm : Form
    {
        /// <summary>
        /// Initializes the launcher.
        /// </summary>
        public LauncherForm()
        {
            InitializeComponent();
            this.mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            this.mnuHelpAbout.Click += MnuHelpAbout_Click;
            this.mnuFileExit.Click += MnuFileExit_Click;
            this.mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
            this.mnuDataVehicle.Click += MnuDataVehicle_Click;
        }

        /// <summary>
        /// Handles the Click even of the data vehicle menu selection.
        /// </summary>
        private void MnuDataVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = AMDatabase.mdb");
                connection.Open();
                connection.Close();
                connection.Dispose();
                VehicleDataForm vehicleData = new VehicleDataForm();
                vehicleData.ShowDialog();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Handles the Click event of the open car wash menu selection.
        /// </summary
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            try
            {
                CarWashEntryForm carWashEntryForm = new CarWashEntryForm();
                carWashEntryForm.ShowDialog();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Fragrances data file not found.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (IOException)
            {
                MessageBox.Show("An error occurred while reading the data file.", "Data File Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Handles the Click event of the exit menu item.
        /// </summary>
        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the about menu item.
        /// </summary>
        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the open menu item for SalesQuote.
        /// </summary>
        private void MnuFileOpenSalesQuote_Click(object sender, EventArgs e)
        {
            try
            {
                SalesQuoteForm salesQuoteForm = new SalesQuoteForm();
                salesQuoteForm.ShowDialog();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Unable to load vehicle data.", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (NoRowsException)
            {
                MessageBox.Show("There are no vehicles in stock.", "Sales Quote Data", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            
        }

       
    }
}
