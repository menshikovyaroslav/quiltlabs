using System;
using System.Collections.Generic;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace MainApp
{
    public partial class ThisAddIn
    {
        /// <summary>
        /// Get Application Object
        /// </summary>
        /// <returns></returns>
        public Excel.Application GetApplication()
        {
            return Application;
        }

        /// <summary>
        /// Get Active Work Book
        /// </summary>
        /// <returns></returns>
        public Excel.Workbook GetActiveWorkBook()
        {
            return (Excel.Workbook)Application.ActiveWorkbook;
        }

        /// <summary>
        /// Get Active Work Sheet
        /// </summary>
        /// <returns></returns>
        public Excel.Worksheet GetActiveWorksheet()
        {
            return (Excel.Worksheet)Application.ActiveSheet;
        }

        /// <summary>
        /// Get Active Cell
        /// </summary>
        /// <returns></returns>
        public Excel.Range GetActiveCell()
        {
            return (Excel.Range)Application.Selection;
        }
    }
}
