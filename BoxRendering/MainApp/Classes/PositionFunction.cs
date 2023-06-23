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

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public void ParseCell(Range range)
        {
            Worksheet ws = range.Worksheet;
            IntPtr hdc = GetDC((IntPtr)0);
            long px = GetDeviceCaps(hdc, LOGPIXELSX);
            long py = GetDeviceCaps(hdc, LOGPIXELSY);
            ReleaseDC((IntPtr)0, hdc);
            double zoom = Functions.Application.ActiveWindow.Zoom;

            var pointsPerInch = Functions.Application.InchesToPoints(1); // usually 72 
            var zoomRatio = zoom / 100;
            var x1 = Functions.Application.ActiveWindow.PointsToScreenPixelsX(0);

            // Coordinates of current column 
            x1 = Convert.ToInt32(x1 + range.Left * zoomRatio * px / pointsPerInch);

            // Coordinates of next column 
            var x2 = Convert.ToInt32(x1 + (((Range)(ws.Columns)[range.Column]).Width) * zoomRatio * px / pointsPerInch);

            var width = x2 - x1;

            var y1 = Functions.Application.ActiveWindow.PointsToScreenPixelsY(0);
            y1 = Convert.ToInt32(y1 + range.Top * zoomRatio * py / pointsPerInch);

            // Coordinates of next row 
            var y2 = Convert.ToInt32(y1 + (((Range)(ws.Rows)[range.Row]).Height) * zoomRatio * py / pointsPerInch);

            var height = y2 - y1;

            Marshal.ReleaseComObject(ws);
            Marshal.ReleaseComObject(range);

            X = x1 + width;
            Y = y1 - 2;
            Width = width;
            Height = height + 4;
        }
    }
}
