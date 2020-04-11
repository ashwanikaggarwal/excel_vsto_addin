﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace Homework7
{
    public partial class Sheet1
    {
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            // TODO: Delete this line of code to remove the default AutoFill for 'salesdatDataSet.Orders'.
            if (this.NeedsFill("salesdatDataSet"))
            {
                this.ordersTableAdapter.Fill(this.salesdatDataSet.Orders);
            }
            // TODO: Delete this line of code to remove the default AutoFill for 'salesdatDataSet.Customers'.
            if (this.NeedsFill("salesdatDataSet"))
            {
                this.customersTableAdapter.Fill(this.salesdatDataSet.Customers);
            }

            this.customersBindingSource.BindingComplete += new BindingCompleteEventHandler(customersBindingSource_BindingComplete);
        }

        void customersBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext == BindingCompleteContext.DataSourceUpdate && e.Exception == null)
                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
