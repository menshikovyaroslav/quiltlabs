using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Classes
{
    internal class PositionHelper
    {
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);
        private const int LOGPIXELSX = 88;
        private const int LOGPIXELSY = 90;

        public static System.Drawing.Point GetCellPosition(Range range)
        {
            Worksheet ws = range.Worksheet;
            IntPtr hdc = GetDC((IntPtr)0);
            long px = GetDeviceCaps(hdc, LOGPIXELSX);
            long py = GetDeviceCaps(hdc, LOGPIXELSY);
            ReleaseDC((IntPtr)0, hdc);
            double zoom = Functions.Application.ActiveWindow.Zoom;

            var pointsPerInch = Functions.Application.InchesToPoints(1); // usually 72 
            var zoomRatio = zoom / 100;
            var x = Functions.Application.ActiveWindow.PointsToScreenPixelsX(0);

            // Coordinates of current column 
            x = Convert.ToInt32(x + range.Left * zoomRatio * px / pointsPerInch);

            // Coordinates of next column 
            //x = Convert.ToInt32(x + (((Range)(ws.Columns)[range.Column]).Width + range.Left) * zoomRatio * px / pointsPerInch); 
            var y = Functions.Application.ActiveWindow.PointsToScreenPixelsY(0);
            y = Convert.ToInt32(y + range.Top * zoomRatio * py / pointsPerInch);

            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(range);

            return new System.Drawing.Point(x, y);
        }
    }
}
