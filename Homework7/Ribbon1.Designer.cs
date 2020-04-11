namespace Homework7
{
    partial class Ribbon1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = new Microsoft.Office.Tools.Ribbon.RibbonTab();
            this.tabHW7 = new Microsoft.Office.Tools.Ribbon.RibbonTab();
            this.group2 = new Microsoft.Office.Tools.Ribbon.RibbonGroup();
            this.buttonCustomers = new Microsoft.Office.Tools.Ribbon.RibbonButton();
            this.buttonAbout = new Microsoft.Office.Tools.Ribbon.RibbonButton();
            this.tab1.SuspendLayout();
            this.tabHW7.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            this.tab1.Visible = false;
            // 
            // tabHW7
            // 
            this.tabHW7.Groups.Add(this.group2);
            this.tabHW7.Label = "Homework 7";
            this.tabHW7.Name = "tabHW7";
            // 
            // group2
            // 
            this.group2.Items.Add(this.buttonCustomers);
            this.group2.Items.Add(this.buttonAbout);
            this.group2.Label = "Manage";
            this.group2.Name = "group2";
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonCustomers.Image = global::Homework7.Properties.Resources.businessman_view;
            this.buttonCustomers.Label = "Customers";
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.ShowImage = true;
            this.buttonCustomers.Click += new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs>(this.buttonCustomers_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonAbout.Image = global::Homework7.Properties.Resources.about;
            this.buttonAbout.Label = "About";
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.ShowImage = true;
            this.buttonAbout.Click += new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs>(this.buttonOrders_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.StartFromScratch = true;
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tabHW7);
            this.Load += new System.EventHandler<Microsoft.Office.Tools.Ribbon.RibbonUIEventArgs>(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabHW7.ResumeLayout(false);
            this.tabHW7.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabHW7;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonCustomers;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAbout;
    }
}
