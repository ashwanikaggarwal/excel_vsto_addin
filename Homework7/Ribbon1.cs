using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Homework7
{
    public partial class Ribbon1 : ExcelRibbon
    {
        public Ribbon1()
        {
            InitializeComponent();
        }

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonCustomers_Click(object sender, RibbonControlEventArgs e)
        {
            new FormCustomers().ShowDialog();
        }

        private void buttonOrders_Click(object sender, RibbonControlEventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
