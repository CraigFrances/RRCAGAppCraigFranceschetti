
namespace Franceschetti.Craig.RRCAGApp
{
    partial class CarWashEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.lblFragrance = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.lblExterior = new System.Windows.Forms.Label();
            this.lblInterior = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalOutput = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblPSTOutput = new System.Windows.Forms.Label();
            this.lblGSTOutput = new System.Windows.Forms.Label();
            this.lblTotalOutput = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileGenerateInvoice,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileGenerateInvoice
            // 
            this.mnuFileGenerateInvoice.Name = "mnuFileGenerateInvoice";
            this.mnuFileGenerateInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuFileGenerateInvoice.Size = new System.Drawing.Size(231, 22);
            this.mnuFileGenerateInvoice.Text = "Generate &Invoice";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(231, 22);
            this.mnuFileExit.Text = "E&xit";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(26, 47);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(53, 13);
            this.lblPackage.TabIndex = 1;
            this.lblPackage.Text = "Package:";
            // 
            // cboPackage
            // 
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(29, 72);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(160, 21);
            this.cboPackage.TabIndex = 1;
            // 
            // cboFragrance
            // 
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Location = new System.Drawing.Point(224, 72);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(160, 21);
            this.cboFragrance.TabIndex = 2;
            // 
            // lblFragrance
            // 
            this.lblFragrance.AutoSize = true;
            this.lblFragrance.Location = new System.Drawing.Point(221, 47);
            this.lblFragrance.Name = "lblFragrance";
            this.lblFragrance.Size = new System.Drawing.Size(58, 13);
            this.lblFragrance.TabIndex = 3;
            this.lblFragrance.Text = "Fragrance:";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lstExterior);
            this.grpSummary.Controls.Add(this.lstInterior);
            this.grpSummary.Controls.Add(this.lblExterior);
            this.grpSummary.Controls.Add(this.lblInterior);
            this.grpSummary.Location = new System.Drawing.Point(12, 118);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(395, 180);
            this.grpSummary.TabIndex = 5;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lstExterior
            // 
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.Location = new System.Drawing.Point(212, 55);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExterior.Size = new System.Drawing.Size(160, 95);
            this.lstExterior.TabIndex = 3;
            this.lstExterior.TabStop = false;
            // 
            // lstInterior
            // 
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.Location = new System.Drawing.Point(17, 55);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstInterior.Size = new System.Drawing.Size(160, 95);
            this.lstInterior.TabIndex = 2;
            this.lstInterior.TabStop = false;
            // 
            // lblExterior
            // 
            this.lblExterior.AutoSize = true;
            this.lblExterior.Location = new System.Drawing.Point(212, 30);
            this.lblExterior.Name = "lblExterior";
            this.lblExterior.Size = new System.Drawing.Size(45, 13);
            this.lblExterior.TabIndex = 1;
            this.lblExterior.Text = "Exterior:";
            // 
            // lblInterior
            // 
            this.lblInterior.AutoSize = true;
            this.lblInterior.Location = new System.Drawing.Point(17, 30);
            this.lblInterior.Name = "lblInterior";
            this.lblInterior.Size = new System.Drawing.Size(42, 13);
            this.lblInterior.TabIndex = 0;
            this.lblInterior.Text = "Interior:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(244, 321);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalOutput
            // 
            this.lblSubtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotalOutput.Location = new System.Drawing.Point(299, 316);
            this.lblSubtotalOutput.Name = "lblSubtotalOutput";
            this.lblSubtotalOutput.Size = new System.Drawing.Size(108, 23);
            this.lblSubtotalOutput.TabIndex = 7;
            this.lblSubtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPST
            // 
            this.lblPST.AutoSize = true;
            this.lblPST.Location = new System.Drawing.Point(262, 353);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(31, 13);
            this.lblPST.TabIndex = 8;
            this.lblPST.Text = "PST:";
            // 
            // lblPSTOutput
            // 
            this.lblPSTOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPSTOutput.Location = new System.Drawing.Point(299, 348);
            this.lblPSTOutput.Name = "lblPSTOutput";
            this.lblPSTOutput.Size = new System.Drawing.Size(108, 23);
            this.lblPSTOutput.TabIndex = 9;
            this.lblPSTOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGSTOutput
            // 
            this.lblGSTOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGSTOutput.Location = new System.Drawing.Point(299, 380);
            this.lblGSTOutput.Name = "lblGSTOutput";
            this.lblGSTOutput.Size = new System.Drawing.Size(108, 23);
            this.lblGSTOutput.TabIndex = 10;
            this.lblGSTOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalOutput
            // 
            this.lblTotalOutput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOutput.Location = new System.Drawing.Point(299, 412);
            this.lblTotalOutput.Name = "lblTotalOutput";
            this.lblTotalOutput.Size = new System.Drawing.Size(108, 23);
            this.lblTotalOutput.TabIndex = 11;
            this.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(262, 385);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(32, 13);
            this.lblGST.TabIndex = 12;
            this.lblGST.Text = "GST:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(259, 418);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total:";
            // 
            // CarWashEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblTotalOutput);
            this.Controls.Add(this.lblGSTOutput);
            this.Controls.Add(this.lblPSTOutput);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblSubtotalOutput);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.lblFragrance);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CarWashEntryForm";
            this.ShowIcon = false;
            this.Text = "Car Wash";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileGenerateInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.Label lblFragrance;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.Label lblExterior;
        private System.Windows.Forms.Label lblInterior;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalOutput;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblPSTOutput;
        private System.Windows.Forms.Label lblGSTOutput;
        private System.Windows.Forms.Label lblTotalOutput;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
    }
}