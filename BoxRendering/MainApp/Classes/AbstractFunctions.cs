using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Classes
{
    /// <summary>
    /// Abstract class to control standard formulas
    /// </summary>
    public abstract class AbstractFunctions
    {
        protected readonly Application application = Globals.ThisAddIn.GetApplication();
        protected readonly Worksheet worksheet = Globals.ThisAddIn.GetActiveWorksheet();
        protected readonly Range cell = Globals.ThisAddIn.GetActiveCell();
        protected readonly Workbook workBook = Globals.ThisAddIn.GetActiveWorkBook();
        public abstract void Start();
    }
}
