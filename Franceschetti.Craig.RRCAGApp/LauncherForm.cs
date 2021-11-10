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
    public partial class LauncherForm : Form
    {
        public LauncherForm()
        {
            InitializeComponent();

            mnuFileOpenSalesQuote.Click += MnuFileOpen_Click;
            mnuHelpAbout.Click += MnuHelpAbout_Click;
            mnuFileExit.Click += MnuFileExit_Click;
        }

        private void MnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void MnuFileOpen_Click(object sender, EventArgs e)
        {
            SalesQuoteForm salesQuoteForm = new SalesQuoteForm();
            salesQuoteForm.ShowDialog();
        }
    }
}
