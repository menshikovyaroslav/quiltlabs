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
using System.Net;

namespace MainApp
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            var sheet = GetActiveWorksheet();
            sheet.SelectionChange += Sheet_SelectionChange;
        }

        SuggestionForm _suggestionForm;

        private void Sheet_SelectionChange(Excel.Range Target)
        {
            var positionHelper = new PositionHelper();
            positionHelper.ParseCell(Target);

            if (_suggestionForm == null)
            {
                _suggestionForm = new SuggestionForm(123.456);
                _suggestionForm.Show();
                //_suggestionForm.BringToFront();
            }

            _suggestionForm.Left = positionHelper.X;
            _suggestionForm.Top = positionHelper.Y;

            _suggestionForm.Width = positionHelper.Width;
            _suggestionForm.Height = positionHelper.Height;
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
