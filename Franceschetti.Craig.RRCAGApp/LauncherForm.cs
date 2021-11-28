/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-8
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
        }

        /// <summary>
        /// Handles the Click event of the open car wash menu selection.
        /// </summary
        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fragranceStream = new FileStream("fragrances.txt", FileMode.Open, FileAccess.Read);
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
            SalesQuoteForm salesQuoteForm = new SalesQuoteForm();
            salesQuoteForm.ShowDialog();
        }
    }
}
