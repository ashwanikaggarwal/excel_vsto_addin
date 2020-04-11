using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;

namespace Homework7
{
    partial class ActionsPaneOrder : UserControl
    {
        public ActionsPaneOrder()
        {
            InitializeComponent();
            this.ordersBindingNavigator.BindingSource = Globals.Sheet1.ordersBindingSource;

            this.productTextBox.DataBindings.Clear();
            this.productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", Globals.Sheet1.ordersBindingSource, "Product", true));
            this.unitsTextBox.DataBindings.Clear();
            this.unitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", Globals.Sheet1.ordersBindingSource, "Units", true));
            this.amountTextBox.DataBindings.Clear();
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", Globals.Sheet1.ordersBindingSource, "Amount", true));
            this.orderDateDateTimePicker.DataBindings.Clear();
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", Globals.Sheet1.ordersBindingSource, "OrderDate", true));
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            Globals.Sheet1.ordersBindingSource.EndEdit();
            Globals.Sheet1.tableAdapterManager.UpdateAll(Globals.Sheet1.salesdatDataSet);
        }
    }
}
