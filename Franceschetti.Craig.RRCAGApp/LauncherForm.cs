/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-11-8
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
            mnuFileOpenSalesQuote.Click += MnuFileOpenSalesQuote_Click;
            mnuHelpAbout.Click += MnuHelpAbout_Click;
            mnuFileExit.Click += MnuFileExit_Click;
            mnuFileOpenCarWash.Click += MnuFileOpenCarWash_Click;
        }

        private void MnuFileOpenCarWash_Click(object sender, EventArgs e)
        {
            CarWashEntryForm carWashEntryForm = new CarWashEntryForm();
            carWashEntryForm.ShowDialog();
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
