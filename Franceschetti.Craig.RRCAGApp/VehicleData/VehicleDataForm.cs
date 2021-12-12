/*
 * Name: Craig Franceschetti
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2021-12-12
 * Updated: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Franceschetti.Craig.RRCAGApp
{
    /// <summary>
    /// Represents a VehicleDataForm.
    /// </summary>
    public partial class VehicleDataForm : Form
    {
        private OleDbConnection connection;
        private DataSet dataSet;
        private BindingSource source;
        private OleDbDataAdapter dataAdapter;
        
        /// <summary>
        /// Initializes an instance of VehicleDataForm.
        /// </summary>
        public VehicleDataForm()
        {
            InitializeComponent();

            this.Load += VehicleDataForm_Load;
            this.mnuFileClose.Click += MnuFileClose_Click;
            this.FormClosing += VehicleDataForm_FormClosing;
            this.dgvVehicles.DataBindingComplete += DgvVehicles_DataBindingComplete;
            this.mnuEditDelete.Click += MnuEditDelete_Click;
            this.mnuFileSave.Click += MnuFileSave_Click;
            this.dgvVehicles.SelectionChanged += DgvVehicles_SelectionChanged;
            this.dgvVehicles.CellValueChanged += DgvVehicles_CellValueChanged;
        }

        /// <summary>
        /// Handles the RowsAdded event of the vehicle data grid view.
        /// </summary>
        private void DgvVehicles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.dgvVehicles.Rows[e.RowIndex-1].Cells["SoldBy"].Value = 0;
        }

        /// <summary>
        /// Handles the CellValueChanged event of the vehicle data grid view.
        /// </summary>
        private void DgvVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.source.EndEdit();
            this.Text = "* Vehicle Data";
            this.mnuFileSave.Enabled = true;
        }

        /// <summary>
        /// Handles the SelectionChanged event of the vehicle data grid view.
        /// </summary>
        private void DgvVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvVehicles.CurrentRow != null)
            {
                this.mnuEditDelete.Enabled = !this.dgvVehicles.CurrentRow.IsNewRow;
            }
        }

        /// <summary>
        /// Handles the Click event of the Save menu option.
        /// </summary>
        private void MnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvVehicles.EndEdit();
                this.source.EndEdit();
                this.dataAdapter.Update(dataSet, "VehicleStock");
                this.Text = "Vehicle Data";
                this.mnuFileSave.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete menu option.
        /// </summary>
        private void MnuEditDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to permanently delete stock item {dgvVehicles.CurrentRow.Cells["StockNumber"].Value}?", "Delete Stock Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(result.Equals(DialogResult.Yes))
            {
                try
                {
                    this.dgvVehicles.Rows.Remove(dgvVehicles.CurrentRow);
                    this.dataAdapter.Update(dataSet, "VehicleStock");
                    this.source.EndEdit();
                    this.mnuEditDelete.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while deleting the selected vehicle", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }  
            }  
        }

        /// <summary>
        /// Handles the DataBindingComplete event of the vehicle data grid view.
        /// </summary>
        private void DgvVehicles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvVehicles.Columns["ID"].Visible = false;
            this.dgvVehicles.Columns["SoldBy"].Visible = false;
        }

        /// <summary>
        /// Handles the FormClosing event of the vehicle data form.
        /// </summary>
        private void VehicleDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(this.Text == "* Vehicle Data")
            {
                DialogResult result = MessageBox.Show("Do you wish to save changes?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.dgvVehicles.EndEdit();
                        this.source.EndEdit();
                        this.dataAdapter.Update(dataSet, "VehicleStock");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occurred while saving. Do you still wish to close?", "Save Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    }
                }
                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            connection.Close();
            connection.Dispose();
        }

        /// <summary>
        /// Handles the Click event of the Close menu option.
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Load event of the vehicle data form.
        /// </summary>
        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            mnuFileSave.Enabled = false;
            mnuEditDelete.Enabled = false;
            source = new BindingSource();
            
            this.connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = AMDatabase.mdb");
            connection.Open();
            
            OleDbCommand command = new OleDbCommand("SELECT * FROM VehicleStock;", connection);

            this.dataAdapter = new OleDbDataAdapter(command);

            this.dataSet = new DataSet();
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(this.dataAdapter);
            commandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

            this.dataAdapter.Fill(this.dataSet, "VehicleStock");
           
            source.DataSource = this.dataSet.Tables["VehicleStock"];
            
            BindControls();
            this.dgvVehicles.RowsAdded += DgvVehicles_RowsAdded;

        }

        /// <summary>
        /// Bind controls for the form.
        /// </summary>
        private void BindControls()
        {
            this.dgvVehicles.DataSource = source;
        }
    }
}
