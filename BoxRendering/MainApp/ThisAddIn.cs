using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

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

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
