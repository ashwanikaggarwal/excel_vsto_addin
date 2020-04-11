using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework7
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();

             this.customersBindingSource = Globals.Sheet1.customersBindingSource;
             this.customersBindingSource.ResetBindings(false);
             this.customersDataGridView.DataSource = this.customersBindingSource;
             this.customersDataGridView[1, customersBindingSource.Position].Selected = true;
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesdatDataSet);
        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesdatDataSet);

        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesdatDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesdatDataSet.Customers);

        }
    }
}