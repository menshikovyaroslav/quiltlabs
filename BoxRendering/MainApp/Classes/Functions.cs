using Microsoft.Office.Interop.Excel;

namespace MainApp.Classes
{
    /// <summary>
    /// class to control standard formulas
    /// </summary>
    public static class Functions
    {
        public static Application Application => Globals.ThisAddIn.GetApplication();
        public static Worksheet Worksheet => Globals.ThisAddIn.GetActiveWorksheet();
        public static Range Cell => Globals.ThisAddIn.GetActiveCell();
        public static Workbook WorkBook => Globals.ThisAddIn.GetActiveWorkBook();
    }
}
