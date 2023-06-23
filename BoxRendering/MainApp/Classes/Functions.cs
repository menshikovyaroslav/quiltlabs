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
    public static class Functions
    {
        public static Application Application => Globals.ThisAddIn.GetApplication();
        public static Worksheet Worksheet => Globals.ThisAddIn.GetActiveWorksheet();
        public static Range Cell => Globals.ThisAddIn.GetActiveCell();
        public static Workbook WorkBook => Globals.ThisAddIn.GetActiveWorkBook();
    }
}
