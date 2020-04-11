using System;
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
    public partial class ThisWorkbook
    {
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            ActionsPaneOrder apc = new ActionsPaneOrder();
            this.ActionsPane.Width = apc.Width;
            this.ActionsPane.Controls.Add(apc);
            this.ActionsPane.Visible = true;

            AboutBox1 ab = new AboutBox1();

            foreach (Excel.Window item in this.Windows)
            {
                item.DisplayGridlines = false;
                item.DisplayHeadings = false;
                item.Caption = ab.AssemblyProduct;
            }

            object missing = Type.Missing;

            foreach (Excel.Worksheet item in this.Worksheets)
            {
                // Works only when the workbook is protected
                item.EnableSelection = Excel.XlEnableSelection.xlNoSelection;
                //item.Protect(string.Empty,
                //missing, missing, missing, missing, missing, missing, missing, missing,
                //missing, missing, missing, missing, true, missing, missing);
            }

            DisplayBars(false);

            Application.Caption = ab.AssemblyCopyright;

            this.SheetBeforeRightClick += new Excel.WorkbookEvents_SheetBeforeRightClickEventHandler(ThisWorkbook_SheetBeforeRightClick);
            this.SheetBeforeDoubleClick += new Excel.WorkbookEvents_SheetBeforeDoubleClickEventHandler(ThisWorkbook_SheetBeforeDoubleClick);
        }

        void ThisWorkbook_SheetBeforeRightClick(object Sh, Excel.Range Target, ref bool Cancel)
        {
            Cancel = true;
        }

        void ThisWorkbook_SheetBeforeDoubleClick(object Sh, Microsoft.Office.Interop.Excel.Range Target, ref bool Cancel)
        {
            Cancel = true;
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
            DisplayBars(true);
        }

        private void DisplayBars(bool show)
        {
            Application.DisplayAlerts = show;
            Application.DisplayFormulaBar = show;
            Application.DisplayScrollBars = show;
            Application.DisplayStatusBar = show;
            Application.DisplayRecentFiles = show;
            Application.DisplayInsertOptions = show;

            Application.ActiveWindow.DisplayHeadings = show;
            Application.ActiveWindow.DisplayGridlines = show;
            Application.ActiveWindow.DisplayWorkbookTabs = show;
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

    }
}
