using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using MainApp.Classes;
using MainApp.Forms;
using Microsoft.Office.Tools;
using System.Runtime.InteropServices;

namespace MainApp
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            var sheet = GetActiveWorksheet();
            sheet.SelectionChange += Sheet_SelectionChange;
        }

        private void Sheet_SelectionChange(Excel.Range Target)
        {
            var position = PositionHelper.GetCellPosition(Target);

            var form = new SuggestionForm(123.456);
            form.Left = position.X;
            form.Top = position.Y;

            form.Width = 100;
            form.Height = 50;

            form.Show();

            //MessageBox.Show($"{position.X}, {position.Y}");
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
